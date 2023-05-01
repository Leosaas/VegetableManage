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
	public partial class AccountList : UserControl
	{
		public AccountList()
		{
			InitializeComponent();
			dgvData.AutoGenerateColumns = false;

			Reload();
		}
		private void Reload()
		{
			dgvData.DataSource = AccountBUS.GetAllAccount();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (new UserHandleForm().ShowDialog() == DialogResult.OK)
			{
				MessageBoxForm.Show("Thêm người dùng thành công", "Thông báo");
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
			string username = dgvData.SelectedRows[0].Cells["username"].Value.ToString();
			string name = dgvData.SelectedRows[0].Cells["name"].Value.ToString();
			string address = dgvData.SelectedRows[0].Cells["address"].Value.ToString();
			string phonenumber = dgvData.SelectedRows[0].Cells["phonenumber"].Value.ToString();
			UserDTO user = new UserDTO(username, name, address, phonenumber);
			if (MessageBoxForm.Show("Thao tác này sẽ đồng thời xoá luôn tài khoản người dùng, bạn có chắc chắn ?", "Cảnh báo") == DialogResult.OK)
			{
				string message = UserBUS.DeleteUser(user);
				if (!string.IsNullOrEmpty(message))
				{
					MessageBoxForm.Show(message, "Thông báo");
					return;
				}
				MessageBoxForm.Show("Xoá thành công", "Thông báo");
				Reload();
			}
		}

		private void btnChange_Click(object sender, EventArgs e)
		{
			if (dgvData.SelectedRows[0].Index < 0)
			{
				return;
			}
			string username = dgvData.SelectedRows[0].Cells["username"].Value.ToString();
			string password = dgvData.SelectedRows[0].Cells["password"].Value.ToString();
			bool type = bool.Parse(dgvData.SelectedRows[0].Cells["type"].Value.ToString());

			AccountDTO account = new AccountDTO(username, password, type);
			if (new AccountHandleForm(account).ShowDialog() == DialogResult.OK)
			{
				MessageBoxForm.Show("Cập nhật thông tin người dùng thành công", "Thông báo");
				Reload();
			}
		}

	}
}
