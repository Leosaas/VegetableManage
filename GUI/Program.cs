using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			ServerConfigDTO server = ServerConfigBUS.ReadConfigFile();

			if (server == null)
			{
				MessageBoxForm.Show("Không tìm thấy file cấu hình, vui lòng cấu hình cơ sở dữ liệu trước khi dùng", "Thông báo");
				Application.Run(new ServerConfigForm());
				return;
			}
            server.ServerName = Regex.Replace(server.ServerName, @"\t|\n|\r", "");
			server.DatabaseName = Regex.Replace(server.DatabaseName, @"\t|\n|\r", "");
			if (!ServerConfigBUS.CheckDatabaseExist(server))
			{
                MessageBoxForm.Show("Cơ sở dữ liệu chưa được tạo, vui lòng cấu hình cơ sở dữ liệu trước khi dùng", "Thông báo");
                Application.Run(new ServerConfigForm());
                return;
            }

            Application.Run(new FlashForm());
		}
	}
}
