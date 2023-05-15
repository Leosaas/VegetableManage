using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
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
			if (ServerConfigBUS.ReadConfigFile() == null || !ServerConfigBUS.CheckDatabaseExist())
			{
				MessageBoxForm.Show("Tệp cấu hình cơ sở dữ liệu không tìm thấy hoặc cơ sở dữ liệu chưa được khởi tạo, vui lòng cấu hình cơ sở dữ liệu trước khi dùng", "Thông báo");
				Application.Run(new ServerConfigForm());
				return;
			}
			Application.Run(new FlashForm());
		}
	}
}
