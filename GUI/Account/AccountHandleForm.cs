using BUS;
using DTO;
using GUI;
using System.Windows.Forms;
using System;

namespace VegetablesManager.AppForm
{
	public partial class AccountHandleForm : Form
	{
		AccountDTO account;
		public AccountDTO Account { get => account; set => account = value; }

		public AccountHandleForm()
		{
			InitializeComponent();
			
		}
		public AccountHandleForm(AccountDTO account)
		{
			InitializeComponent();
			AcceptButton = btnAccept;
			this.account = account;
			txtUsername.Text = account.Username;
			txtUsername.Enabled = false;
			txtPassword.Text = account.Password;
			cboRight.SelectedIndex = account.Type;
			txtPassword.UseSystemPasswordChar = true;
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

		private void chkShowPass_CheckedChanged(object sender, EventArgs e)
		{
			txtPassword.UseSystemPasswordChar = !chkShowPass.Checked;
		}

		private void btnAccept_Click(object sender, EventArgs e)
		{
			account = new AccountDTO(txtUsername.Text, txtPassword.Text, cboRight.SelectedIndex);
			if (string.IsNullOrEmpty(account.Username))
			{
				MessageBoxForm.Show("Tên đăng nhập không được để trống", "Thông báo");
				txtUsername.Focus();
				return;
			}

			string message = AccountBUS.UpdateAccount(account);
			if (!string.IsNullOrEmpty(message))
			{
				MessageBoxForm.Show(message, "Thông báo");
				txtUsername.Focus();
				return;
			}
			Log.Write("Cập nhật thông tin tài khoản " + account.Username);
			this.DialogResult = DialogResult.OK;
		}

	}
}
