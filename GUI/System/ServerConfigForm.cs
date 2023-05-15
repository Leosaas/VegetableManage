using BUS;
using DTO;
using GUI;
using System.Windows.Forms;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.Sql;
using System.IO;
using System.Data.SqlClient;

namespace GUI
{
	public partial class ServerConfigForm : Form
	{

		public ServerConfigForm()	
		{

			InitializeComponent();
			AcceptButton = btnAccept;
			InitCboInstanceList();
		

        }
		private void InitCboInstanceList()
		{
            List<string> data = ServerConfigBUS.GetListInstanceOfServer();
            if (data == null)
            {
				MessageBoxForm.Show("Không thể lấy danh sách máy chủ từ cơ sở dữ liệu !","Thông báo");
				return;
            }
			cboInstanceList.DataSource = data;
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
			ServerConfigDTO server = new ServerConfigDTO();
			server.ServerName = cboInstanceList.Text;
			if (radWindow.Checked)
			{
				server.Integrated_security = radWindow.Checked;
			}
			else
			{
				server.Username = txtUsername.Text;
				server.Password = txtPassword.Text;
                server.Integrated_security = radWindow.Checked;

            }
			if (string.IsNullOrEmpty(txtDatabaseName.Text))
			{
				MessageBoxForm.Show("Tên cơ sở dữ liệu không được bỏ trống", "Thông báo");
				return;
			}
				
			server.DatabaseName = txtDatabaseName.Text;
			
			
			string message = ServerConfigBUS.WriteConfigFile(server);
			if (message != null)
			{
				MessageBoxForm.Show("Không thể cấu hình máy chủ do lỗi: " + message, "Thông báo");
				return;
			}
			MessageBoxForm.Show("Cấu hình thành công, vui lòng khởi động lại hệ thống để áp dụng thay đổi", "Thông báo");
			Application.Exit();

		}


		private void chkShowPass_CheckedChanged(object sender, EventArgs e)
		{
			txtPassword.UseSystemPasswordChar = !chkShowPass.Checked;
		}

		private void radWindow_CheckedChanged(object sender, EventArgs e)
		{
			if(radWindow.Checked)
			{
				txtPassword.Enabled = false;
				txtUsername.Enabled = false;
				chkShowPass.Enabled = false;
			}
		}

		private void radAccount_CheckedChanged(object sender, EventArgs e)
		{
			if (radAccount.Checked)
			{
				txtPassword.Enabled = true;
				txtUsername.Enabled = true;
				chkShowPass.Enabled = true;
			}
		}

		private void ServerConfigForm_Load(object sender, EventArgs e)
		{
			
		}
	}
}
