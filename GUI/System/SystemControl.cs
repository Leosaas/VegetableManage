using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VegetablesManager.AppForm;

namespace GUI
{
	public partial class SystemControl : UserControl
	{
		bool isAddNew = false;
		public SystemControl()
		{
			InitializeComponent();
			dgvData.AutoGenerateColumns = false;

			Reload();



		}
		private void Reload()
		{
			dgvData.DataSource = LogBUS.GetLog();
		}






		



		private void btnBackup_Click(object sender, EventArgs e)
		{
			string message = SystemBUS.BackupDatabase();
			if(message != null)
			{
				MessageBoxForm.Show(message, "Thông báo");
				return;
			}
			MessageBoxForm.Show("Sao lưu thành công", "Thông báo");
			Reload();
		}

		private void btnRestore_Click(object sender, EventArgs e)
		{
			/*string workingDirectory = Environment.CurrentDirectory;
			string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
			string path = Directory.GetParent(projectDirectory).Parent.FullName + @"\VegetableManage\Data\Backup";
			OpenFileDialog phuchoiFile = new OpenFileDialog();
			phuchoiFile.InitialDirectory = path;	
			phuchoiFile.Filter = "*.bak|*.bak";
			phuchoiFile.Title = "Chọn tập tin phục hồi (.bak)";
			if (phuchoiFile.ShowDialog() == DialogResult.OK &&
			phuchoiFile.CheckFileExists == true)
			{
				string sDuongDan = phuchoiFile.FileName;
				MessageBoxForm.Show(sDuongDan, "");
			}*/
			ChooseBackupFileForm frmBackup = new ChooseBackupFileForm();
			if(frmBackup.ShowDialog() == DialogResult.OK)
			{
				string message = SystemBUS.RestoreDatabase(frmBackup.FileName);
				if(message != null)
				{
					MessageBoxForm.Show(message, "Thông báo");
					return;
				}
				MessageBoxForm.Show("Phục hồi cơ sở dữ liệu thành công, vui lòng khởi động lại ứng dụng để áp dụng thay đổi","Thông báo");
				Log.Write("Phục hồi dữ liệu từ file " + frmBackup.FileName);
				Application.Exit();
			}
		}

		private void btnClearLog_Click(object sender, EventArgs e)
		{
			if(MessageBoxForm.Show("Thao tác này sẽ xoá toàn bộ lịch sử, bạn có chắc chắn ?","Xác nhận") == DialogResult.OK)
			{
				LogBUS.ClearLog();
				MessageBoxForm.Show("Xoá thành công", "Thông báo");
				Reload();
			}
		}

        private void btnServerConfig_Click(object sender, EventArgs e)
        {
			new ServerConfigForm().ShowDialog();
        }
    }
}
