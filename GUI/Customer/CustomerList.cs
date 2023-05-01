using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VegetablesManager.AppForm;

namespace GUI
{
	public partial class CustomerList : UserControl
	{
		bool isAddNew = false;
		public CustomerList()
		{
			InitializeComponent();
			dgvData.AutoGenerateColumns = false;

			Reload();
			


		}
		private void Reload()
		{
			dgvData.DataSource = CustomerBUS.GetAllCustomer();
			
			
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (new CustomerHandleForm().ShowDialog() == DialogResult.OK)
			{
				MessageBoxForm.Show("Thêm khách hàng thành công", "Thông báo");
				Reload();
			}
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

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgvData.SelectedRows[0].Index < 0)
			{
				return;
			}


			CustomerDTO customer = CustomerBUS.GetCustomerByPhoneNumber(dgvData.SelectedRows[0].Cells["phonenumber"].Value.ToString());
			if (MessageBoxForm.Show("Bạn có chắc chắn xoá khách hàng ?", "Cảnh báo") == DialogResult.OK)
			{
				string message = CustomerBUS.DeleteCustomer(customer);
				if (!string.IsNullOrEmpty(message))
				{
					MessageBoxForm.Show(message, "Thông báo");
					return;
				}
				MessageBoxForm.Show("Xoá thành công", "Thông báo");
				Log.Write("Xoá khách hàng " + customer.CustomerName);
				Reload();
			}
		}

		private void btnChange_Click(object sender, EventArgs e)
		{
			if (dgvData.SelectedRows[0].Index < 0)
			{
				return;
			}
			int rank = int.Parse(dgvData.SelectedRows[0].Cells["rank"].Value.ToString());
			string name = dgvData.SelectedRows[0].Cells["customer_name"].Value.ToString();
			string address = dgvData.SelectedRows[0].Cells["address"].Value.ToString();
			string phonenumber = dgvData.SelectedRows[0].Cells["phonenumber"].Value.ToString();
			CustomerDTO customer = new CustomerDTO(phonenumber, name, address, rank);
			if (new CustomerHandleForm(customer).ShowDialog() == DialogResult.OK)
			{
				MessageBoxForm.Show("Cập nhật thông tin người dùng thành công", "Thông báo");
				Reload();
			}
		}

	}
}
