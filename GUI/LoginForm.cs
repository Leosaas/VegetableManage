using BUS;
using DTO;
using GUI;
using System.Windows.Forms;
using System;

namespace GUI
{
	public partial class LoginForm : Form
	{

		public LoginForm()	
		{

			InitializeComponent();
			AcceptButton = btnLogin;

		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			if (MessageBoxForm.Show("Bạn có thực sự muốn thoát ?", "Xác nhận") == DialogResult.OK)
			{
				Application.Exit();
			}

		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = txtUsername.Text;
			if (string.IsNullOrEmpty(username))
			{
				MessageBoxForm.Show("Tên đăng nhập không được để trống !", "Thông báo");
				return;
			}
			string password = txtPassword.Text;
			AccountDTO account = AccountBUS.VerifyAccount(username, password);
			if (account != null)
			{
				UserDTO user = UserBUS.GetUserFromAccount(account);
				MainForm mainForm = new MainForm(user,account);
				Log.Write("Đăng nhập vào hệ thống");
				mainForm.Show();
				this.Hide();
			}
			else
			{
				MessageBoxForm.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo");
				txtUsername.Focus();


			}



		}

		private void lblTitle_Click(object sender, EventArgs e)
		{

		}

		private void chkShowPass_CheckedChanged(object sender, EventArgs e)
		{
			txtPassword.UseSystemPasswordChar = !chkShowPass.Checked;
		}

	}
}
