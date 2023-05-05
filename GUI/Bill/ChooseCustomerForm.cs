using BUS;
using DTO;
using GUI;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;
using System.Data;
using VegetablesManager.AppForm;

namespace GUI
{
	public partial class ChooseCustomerForm : Form
	{
		string customerPhone = "";
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool ReleaseCapture();
		bool maximize = false;

		public string CustomerPhone { get => customerPhone;}

		public ChooseCustomerForm()	
		{
			
			InitializeComponent();
			dgvData.DataSource = CustomerBUS.GetAllCustomer();
			AcceptButton = btnAccept;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
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


		private void btnMakeOrder_Click(object sender, EventArgs e)
		{
			customerPhone = dgvData.SelectedRows[0].Cells["phonenumber"].Value.ToString();
			this.DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			//this.Hide();
			if(new CustomerHandleForm().ShowDialog() == DialogResult.OK)
			{
				MessageBoxForm.Show("Thêm thành công", "Thông báo");
				dgvData.DataSource = CustomerBUS.GetAllCustomer();
			}
			//this.Show();
		}
	}
}
