using BUS;
using DTO;
using GUI;
using System.Windows.Forms;
using System;

namespace VegetablesManager.AppForm
{
	public partial class UserHandleForm : Form
	{
		UserDTO user;
		bool isAddNew;
		public UserDTO User { get => user; }

		public UserHandleForm()
		{
			InitializeComponent();
			isAddNew = true;
			this.AcceptButton = btnAccept;
			lblTitle.Text = "Thêm";
		}
		public UserHandleForm(UserDTO user)
		{
			InitializeComponent();
			this.AcceptButton = btnAccept;
			isAddNew = false;
			this.user = user;
			lblTitle.Text = "Sửa";
			txtUsername.Text = user.Username;
			txtUsername.Enabled = false;
			txtName.Text = user.Name;
			txtAddress.Text = user.Address;
			txtPhoneNumber.Text = user.Phonenumber;
		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		private void Clear()
		{
			txtUsername.Text = "";
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{

			user = new UserDTO(txtUsername.Text, txtName.Text, txtAddress.Text, txtPhoneNumber.Text);
			if (string.IsNullOrEmpty(user.Username))
			{
				MessageBoxForm.Show("Tên đăng nhập không được để trống", "Thông báo");
				txtUsername.Focus();
				return;
			}
			if (string.IsNullOrEmpty(user.Name))
			{
				MessageBoxForm.Show("Tên hiển thị không được để trống", "Thông báo");
				txtName.Focus();
				return;
			}
			
			string message = isAddNew ? UserBUS.AddNewUser(user) : UserBUS.UpdateUser(user);
			if (!string.IsNullOrEmpty(message))
			{
				MessageBoxForm.Show(message, "Thông báo");
				txtUsername.Focus();
				return;
			}
			string log = isAddNew ? "Thêm người dùng " + user.Username : "Sửa thông tin người dùng " + user.Username;
			Log.Write(log);
			this.DialogResult = DialogResult.OK;
		}

	}
}
