using BUS;
using DTO;
using GUI;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;
using System.Data;
using System.IO;

namespace GUI
{
	public partial class ChooseBackupFileForm : Form
	{
		string filename;
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool ReleaseCapture();
		bool maximize = false;

		public string FileName { get => filename;}

		public ChooseBackupFileForm()	
		{
			
			InitializeComponent();
			dgvData.DataSource = CustomerBUS.GetAllCustomer();
			AcceptButton = btnAccept;
			InitData();
		}
		private void InitData()
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("filename", typeof(string));
			dt.Columns["filename"].ColumnName = "Tên tập tin phục hồi";
		//	string workingDirectory = Environment.CurrentDirectory;
		//	string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            //	string path = Directory.GetParent(projectDirectory).Parent.FullName + @"\VegetableManage\Data\Backup";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\Backup");
            string[] items = Directory.GetFiles(path);
			foreach (string item in items)
			{
				dt.Rows.Add(item);
			}
			
			dgvData.DataSource = dt;
		}
		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnResize_Click(object sender, EventArgs e)
		{
			if (maximize)
			{
				WindowState = FormWindowState.Normal;
				btnResize.Image = Properties.Resources.maximize;

			}
			else
			{
				WindowState = FormWindowState.Maximized;
				btnResize.Image = Properties.Resources.minimize;
			}

			maximize = !maximize;
		}

		private void btnHide_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
			
		}

		private void topPanel_MouseDown(object sender, MouseEventArgs e)
		{
			if (maximize)
				return;
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void topPanel_Paint(object sender, PaintEventArgs e)
		{

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

		private void btnMakeOrder_Click(object sender, EventArgs e)
		{
			filename = dgvData.SelectedRows[0].Cells[0].Value.ToString();

			this.DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
	}
}
