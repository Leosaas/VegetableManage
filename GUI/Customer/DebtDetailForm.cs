using BUS;
using DTO;
using GUI;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;
using System.Data;
using VegetablesManager.AppForm;
using System.Drawing;

namespace GUI
{
	public partial class DebtDetailForm : Form
	{
		string customerPhone = "";
		float pay = 0;
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool ReleaseCapture();
		bool maximize = false;

		public string CustomerPhone { get => customerPhone;}

		public DebtDetailForm(string customerPhone)	
		{
			
			InitializeComponent();
			if(DebtBUS.GetTotalDebtOfCustomer(customerPhone) == 0)
			{
				rightPanel.Visible = false;
				panelBill.Visible = false;
			}
			dgvData.AutoGenerateColumns = false;
			dgvData.DataSource = DebtBUS.GetDetailDebtOfCustomer(customerPhone);
			dgvDetailPay.AutoGenerateColumns = false;
			dgvDetailPay.DataSource = DebtBUS.GetDebtPayDetailOfCustomer(customerPhone);
			lblCustomer.Text = CustomerBUS.GetCustomerByPhoneNumber(customerPhone).CustomerName;
			this.customerPhone = customerPhone;
			pay = DebtBUS.GetTotalPayOfCustomer(customerPhone);
			double total = GetTotalDebtMoney();
			RefreshDisplay(total);
			nmrMoney.Maximum = (decimal)(total - pay);
		}
		private void RefreshDisplay(double total)
		{
			lblPay.Text = pay + " VND";
			lblTotal.Text = total + " VND";
			lblLeft.Text = total - pay + " VND";
		}
		private double GetTotalDebtMoney()
		{
			double total = 0;
			foreach (DataGridViewRow dr in dgvData.Rows)
			{
				double value = double.Parse(dr.Cells["total"].Value.ToString());
				total += value;
			}
			return total;
		}
		private double GetTotalDebtOfSelectedBill()
		{
			double total = 0;
			foreach (DataGridViewRow dr in dgvData.SelectedRows)
			{
				double value = double.Parse(dr.Cells["total"].Value.ToString());
				total += value;
			}
			return total;
		}
		private void Reload()
		{
			dgvData.DataSource = DebtBUS.GetDetailDebtOfCustomer(customerPhone);
			dgvDetailPay.DataSource = DebtBUS.GetDebtPayDetailOfCustomer(customerPhone);
			if (DebtBUS.GetTotalDebtOfCustomer(customerPhone) == 0)
			{
				rightPanel.Visible = false;
				panelBill.Visible = false;
			}
		}
		private void btnExit_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		private void btnResize_Click(object sender, EventArgs e)
		{
			if (maximize)
			{
				WindowState = FormWindowState.Normal;
				btnResize.Image = Properties.Resources.maximize;

			}
			else
			{
				WindowState = FormWindowState.Maximized;
				btnResize.Image = Properties.Resources.minimize;
			}

			maximize = !maximize;
		}

		private void btnHide_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
			
		}

		private void topPanel_MouseDown(object sender, MouseEventArgs e)
		{
			if (maximize)
				return;
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void topPanel_Paint(object sender, PaintEventArgs e)
		{

		}



	


		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			string searchValue = txtSearch.Text;
			foreach (DataGridViewRow row in dgvData.Rows)
			{
				CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvData.DataSource];
				currencyManager1.SuspendBinding();
				row.Visible = false;
				currencyManager1.ResumeBinding();
			}
			foreach (DataGridViewRow row in dgvData.Rows)
			{
				foreach (DataGridViewCell cell in row.Cells)
				{
					if (cell.Value.ToString().Contains(searchValue))
					{
						CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvData.DataSource];
						currencyManager1.SuspendBinding();
						row.Visible = true;
						currencyManager1.ResumeBinding();
					}
				}
			}
		}


	
	

		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex != dgvData.Columns["action"].Index || e.RowIndex < 0)
			{
				if (radBillPay.Checked)
				{
					dgvData.MultiSelect = true;
					RefreshDisplay(GetTotalDebtOfSelectedBill());
				}
				return;
			}
			int id = int.Parse(dgvData.SelectedRows[0].Cells["idsellbill"].Value.ToString());
			SellBillDTO sellBill = SellBillBUS.GetSellBillById(id);
			DataTable orderDetails = SellBillBUS.GetBillDetailsById(sellBill.Id);
			new BillReportPrint(sellBill, orderDetails).ShowDialog();
		}

		private void radBillPay_CheckedChanged(object sender, EventArgs e)
		{
			if(radBillPay.Checked)
			{
				dgvData.MultiSelect = true;
				double total = GetTotalDebtOfSelectedBill();
				RefreshDisplay(total);
			}
			else
				dgvData.MultiSelect=false;
		}

		private void radMoneyPay_CheckedChanged(object sender, EventArgs e)
		{
			if (radMoneyPay.Checked)
			{
				nmrMoney.Enabled = true;
				double total = (double)nmrMoney.Value;

				RefreshDisplay(total);
				lblLeft.Text = nmrMoney.Maximum - nmrMoney.Value + " VND";
			}
			else nmrMoney.Enabled = false;
		}

		private void btnMakePayment_Click(object sender, EventArgs e)
		{

			if (radAllPay.Checked)
			{
				if (MessageBoxForm.Show("Xác nhận thanh toán " + lblLeft.Text + " ?", "Thông báo") == DialogResult.OK)
				{
					DebtDTO debit = new DebtDTO();
					debit.CustomerPhone = customerPhone;
					debit.Pay = DebtBUS.GetTotalDebtOfCustomer(customerPhone) - DebtBUS.GetTotalPayOfCustomer(customerPhone);
					debit.Infomation = "Thanh toán " + debit.Pay + " ,số nợ còn lại: 0 VND";
					string message = DebtBUS.RemoveAllDebtOfCustomer(debit);
					if (message != null)
					{
						MessageBoxForm.Show(message, "Thông báo");
						return;
					}
					MessageBoxForm.Show("Thanh toán thành công", "Thông báo");
					Reload();
					Log.Write("Thanh toán toàn bộ nợ cho khách hàng "+CustomerBUS.GetCustomerByPhoneNumber(customerPhone).CustomerName+", số tiền: "+debit.Pay);
				}
			}
			else if (radBillPay.Checked)
			{
				if(dgvData.SelectedRows.Count <= 0)
				{
					MessageBoxForm.Show("Vui lòng chọn những hoá đơn cần thanh toán", "Thông báo");
					return;
				}
				if (MessageBoxForm.Show("Xác nhận thanh toán " + lblLeft.Text + " ?", "Thông báo") == DialogResult.OK)
				{
					if(dgvData.SelectedRows.Count == dgvData.RowCount)
					{
						DebtDTO debt = new DebtDTO();
						debt.CustomerPhone = customerPhone;
						debt.Pay = DebtBUS.GetTotalDebtOfCustomer(customerPhone) - DebtBUS.GetTotalPayOfCustomer(customerPhone);
						debt.Infomation = "Thanh toán toàn bộ phiếu với giá trị: " + debt.Pay + " ,số nợ còn lại: 0 VND";
						string messageFromBus = DebtBUS.RemoveAllDebtOfCustomer(debt);
						if (messageFromBus != null)
						{
							MessageBoxForm.Show(messageFromBus, "Thông báo");
							return;
						}
						MessageBoxForm.Show("Thanh toán thành công", "Thông báo");
						Reload();
						Log.Write("Thanh toán toàn bộ nợ cho khách hàng " + CustomerBUS.GetCustomerByPhoneNumber(customerPhone).CustomerName + ", số tiền: " + debt.Pay);
						return;
					}
					DebtDTO debit = new DebtDTO();
					debit.CustomerPhone = customerPhone;
					double total = GetTotalDebtOfSelectedBill();
					float pay = DebtBUS.GetTotalPayOfCustomer(customerPhone);
					float left = (float)(total - pay);
					debit.Pay = left;
					debit.Infomation = "Thanh toán " + debit.Pay + " cho " + dgvData.SelectedRows.Count + " đơn hàng";
					string message = DebtBUS.PayDebitByAmount(debit);
					if (message != null)
					{
						MessageBoxForm.Show(message, "Thông báo");
						return;
					}

					foreach (DataGridViewRow dr in dgvData.SelectedRows)
					{
						int billId = int.Parse(dr.Cells["idsellbill"].Value.ToString());
						SellBillDTO sellBill = SellBillBUS.GetSellBillById(billId);	


						debit = new DebtDTO();
						debit.CustomerPhone = customerPhone;
						debit.IdBill = sellBill.Id;

						debit.Pay = sellBill.Total;
						message = DebtBUS.RemoveDebtOneBill(debit);
						if (message != null)
						{
							MessageBoxForm.Show(message, "Thông báo");
							return;
						}
						Log.Write("Thanh toán nợ hoá đơn số: "+billId+" cho khách hàng " + CustomerBUS.GetCustomerByPhoneNumber(customerPhone).CustomerName + ", số tiền: " + -debit.Pay);
					}
					MessageBoxForm.Show("Thanh toán thành công", "Thông báo");
					Reload();
				}
			}
			else if (radMoneyPay.Checked)
			{
				if (MessageBoxForm.Show("Xác nhận thanh toán " + lblTotal.Text + " ?", "Thông báo") == DialogResult.OK)
				{
					double money = double.Parse(nmrMoney.Value.ToString());
				
					DebtDTO debit = new DebtDTO();
					debit.CustomerPhone = customerPhone;
					debit.Pay = (float)money;
					debit.Infomation = "Thanh toán " + lblTotal.Text + " ,số nợ còn lại: " + lblLeft.Text;
					float total = DebtBUS.GetTotalDebtOfCustomer(customerPhone);
					float pay = DebtBUS.GetTotalPayOfCustomer(customerPhone);
					
					string message = money >= total - pay ? DebtBUS.RemoveAllDebtOfCustomer(debit):DebtBUS.PayDebitByAmount(debit);
					if (message != null)
					{
						MessageBoxForm.Show(message, "Thông báo");
						return;
					}
					MessageBoxForm.Show("Thanh toán thành công", "Thông báo");
					Reload();
					Log.Write("Thanh toán nợ cho khách hàng " + CustomerBUS.GetCustomerByPhoneNumber(customerPhone).CustomerName + ", số tiền: " + debit.Pay);
				}
			}
			
			
		}

		private void radAllPay_CheckedChanged(object sender, EventArgs e)
		{

			if(radAllPay.Checked)
			{
				RefreshDisplay(GetTotalDebtMoney());
			}
		}

		private void nmrMoney_ValueChanged(object sender, EventArgs e)
		{
			
			RefreshDisplay((double)nmrMoney.Value);
			lblLeft.Text = nmrMoney.Maximum - nmrMoney.Value + " VND";
		}

	}
}
