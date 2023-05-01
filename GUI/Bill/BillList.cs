using BUS;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI.Bill
{
	public partial class BillList : UserControl
	{
		public BillList()
		{
			InitializeComponent();
			LoadOrderBill();
			dtpFrom.MaxDate = DateTime.Now;
			dtpTo.MaxDate = DateTime.Now;
			cboType.SelectedIndex = 1;

		}
		private void LoadSellBill()
		{

			BindingSource binding = new BindingSource();
			binding.DataSource = SellBillBUS.GetAllBill();
			dgvBill.DataSource = binding;



		}
		private void LoadOrderBill()
		{
			
			BindingSource binding = new BindingSource();
			binding.DataSource = OrderProductBUS.GetAllBill();
			dgvBill.DataSource = binding;
	
			

		}


		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			string searchValue = txtSearch.Text;
			foreach (DataGridViewRow row in dgvBill.Rows)
			{
				CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvBill.DataSource];
				currencyManager1.SuspendBinding();
				row.Visible = false;
				currencyManager1.ResumeBinding();
			}
			foreach (DataGridViewRow row in dgvBill.Rows)
			{
				foreach (DataGridViewCell cell in row.Cells)
				{
					if (cell.Value.ToString().Contains(searchValue))
					{
						CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvBill.DataSource];
						currencyManager1.SuspendBinding();
						row.Visible = true;
						currencyManager1.ResumeBinding();
					}
				}
			}
		}








		private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
		{
		/*	if (e.RowIndex < 0)
				return;
			int id = int.Parse(dgvBill.Rows[e.RowIndex].Cells["idpurchasebill"].Value.ToString());
			BindingSource binding = new BindingSource();
			binding.DataSource = OrderProductBUS.GetBillDetailsById(id);
			dgvBillDetail.DataSource = binding;
			foreach (DataGridViewRow dr in dgvBillDetail.Rows)
			{
				int quantity = int.Parse(dr.Cells["quantity"].Value.ToString());
				float price = float.Parse(dr.Cells["price"].Value.ToString());
				dr.Cells["total"].Value = quantity * price;
			}
			lblBillId.Text = dgvBill.SelectedRows[0].Cells["idpurchasebill"].Value.ToString();
			lblDate.Text = dgvBill.SelectedRows[0].Cells["date"].Value.ToString();
			lblUsername.Text = dgvBill.SelectedRows[0].Cells["username"].Value.ToString();
			lblTotal.Text = dgvBill.SelectedRows[0].Cells["billTotal"].Value.ToString() + " VND";*/
		}


		private void btnDetail_Click(object sender, EventArgs e)
		{
			if (dgvBill.SelectedRows[0].Index < 0)
				return;
			if(cboType.SelectedIndex == 1)
			{
				OrderBillDTO order = new OrderBillDTO();
				order.Id = int.Parse(dgvBill.SelectedRows[0].Cells["id"].Value.ToString());
				order.Username = dgvBill.SelectedRows[0].Cells["username"].Value.ToString(); ;
				order.Date = DateTime.Parse(dgvBill.SelectedRows[0].Cells["date"].Value.ToString());
				DataTable orderDetails = OrderProductBUS.GetBillDetailsById(order.Id);

				new BillReportPrint(order, orderDetails).ShowDialog();
			}
			else
			{
				SellBillDTO sellBill = new SellBillDTO();
				sellBill.Id = int.Parse(dgvBill.SelectedRows[0].Cells["id"].Value.ToString());
				sellBill.Username = dgvBill.SelectedRows[0].Cells["username"].Value.ToString(); 
				sellBill.Date = DateTime.Parse(dgvBill.SelectedRows[0].Cells["date"].Value.ToString());
				sellBill.Customer = new CustomerDTO();
				sellBill.Customer.CustomerName = dgvBill.SelectedRows[0].Cells["customerName"].Value.ToString(); 
				sellBill.Discount = int.Parse(dgvBill.SelectedRows[0].Cells["discount"].Value.ToString());
				sellBill.Total = float.Parse(dgvBill.SelectedRows[0].Cells["total"].Value.ToString());
				DataTable orderDetails = SellBillBUS.GetBillDetailsById(sellBill.Id);
				new BillReportPrint(sellBill, orderDetails).ShowDialog();
			}
			
		}

		private void cboType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cboType.SelectedIndex == 1)
			{
				LoadOrderBill();
			}
			else
			{
				LoadSellBill();
			}
		}
	}
}
