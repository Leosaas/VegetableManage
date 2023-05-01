using BUS;
using DTO;
using GUI;
using System.Windows.Forms;
using System;

namespace VegetablesManager.AppForm
{
	public partial class ChangePassForm : Form
	{
		AccountDTO account;
		string username;

		public ChangePassForm(AccountDTO account)
		{
			InitializeComponent();
			this.AcceptButton = btnAccept;
			this.account = account;
		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtOldPass.Text))
			{
				MessageBoxForm.Show("Mật khẩu cũ không được để trống", "Thông báo");
				txtNewPass.Focus();
				return;
			}
			if (string.IsNullOrEmpty(txtNewPass.Text))
			{
				MessageBoxForm.Show("Mật khẩu mới không được để trống", "Thông báo");
				txtOldPass.Focus();
				return;
			}
			if (!txtNewPass.Text.Equals(txtRepeat.Text))
			{
				MessageBoxForm.Show("Xác nhận mật khẩu không đúng", "Thông báo");
				txtNewPass.Focus();
				return;
			}
			if (AccountBUS.VerifyAccount(account.Username,txtOldPass.Text) == null)
			{
				MessageBoxForm.Show("Mật khẩu cũ không đúng", "Thông báo");
				txtOldPass.Focus();
				return;
			}
			AccountDTO accountDTO = new AccountDTO(account.Username,txtNewPass.Text,account.Type);



			string message = AccountBUS.UpdateAccount(accountDTO);
			if (!string.IsNullOrEmpty(message))
			{
				MessageBoxForm.Show(message, "Thông báo");
				txtOldPass.Focus();
				return;
			}
			Log.Write("Đổi mật khẩu ");
			this.DialogResult = DialogResult.OK;
		}

		private void chkShowpass_CheckedChanged(object sender, EventArgs e)
		{
			txtOldPass.UseSystemPasswordChar = !chkShowpass.Checked;
			txtNewPass.UseSystemPasswordChar = !chkShowpass.Checked;
			txtRepeat.UseSystemPasswordChar = !chkShowpass.Checked;
		}
	}
}
