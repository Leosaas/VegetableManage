using BUS;
using DTO;
using GUI;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;
using System.Data;

namespace GUI
{
	public partial class ReportDetail : Form
	{
		int month, year;
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool ReleaseCapture();
		bool maximize = false;
		public ReportDetail(int month,int year,bool sell)	
		{
			InitializeComponent();
			this.month = month;
			this.year = year;
			if (sell)
			{
				LoadSellBill();
			}
			else
			{
				LoadOrderBill();
			}
		}
		public ReportDetail(DateTime dateFrom,DateTime dateTo)
		{
			InitializeComponent();
			LoadProductReport(dateFrom,dateTo);
			
		}
		private void LoadProductReport(DateTime dateFrom,DateTime dateTo)
		{
			ReportParameter[] parameters = new ReportParameter[]
			{
				new ReportParameter("date",DateTime.Now.ToString("dd/MM/yyyy")),
				new ReportParameter("username",User.Username),
				new ReportParameter("dateFrom",dateFrom.ToString("dd/MM/yyyy")),
				new ReportParameter("dateTo",dateTo.ToString("dd/MM/yyyy"))
			};
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportDefinition.ProductReport.rdlc";
			reportViewer1.LocalReport.SetParameters(parameters);

			DataTable list = ProductBUS.GetBuyAndSellOfAllProductFromDateToDate(dateFrom, dateTo);

			ReportDataSource rds = new ReportDataSource("ProductDataset", list);
			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(rds);
			reportViewer1.SetDisplayMode(DisplayMode.Normal);
			reportViewer1.ZoomMode = ZoomMode.PageWidth;
			reportViewer1.RefreshReport();
		}
		private void LoadOrderBill()
		{
			ReportParameter[] parameters = new ReportParameter[]
			{
				new ReportParameter("date",DateTime.Now.ToString("dd/MM/yyyy")),
				new ReportParameter("username",User.Username),
				new ReportParameter("month",month.ToString()+"/"+year.ToString())
			};
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportDefinition.OrderBillByMonth.rdlc";
			reportViewer1.LocalReport.SetParameters(parameters);

			DataTable list = OrderProductBUS.GetOrderBillByMonthAndYear(month, year);

			ReportDataSource rds = new ReportDataSource("PurchaseBillDataset", list);
			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(rds);
			reportViewer1.SetDisplayMode(DisplayMode.Normal);
			reportViewer1.ZoomMode = ZoomMode.PageWidth;
			reportViewer1.RefreshReport();
		}
		private void LoadSellBill()
		{
			ReportParameter[] parameters = new ReportParameter[]
			{
				new ReportParameter("date",DateTime.Now.ToString("dd/MM/yyyy")),
				new ReportParameter("username",User.Username),
				new ReportParameter("month",month.ToString()+"/"+year.ToString())
			};
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportDefinition.SellBillByMonth.rdlc";
			reportViewer1.LocalReport.SetParameters(parameters);

			DataTable list = SellBillBUS.GetSellBillByMonthAndYear(month, year);

			ReportDataSource rds = new ReportDataSource("SellBillDataset", list);
			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(rds);
			reportViewer1.SetDisplayMode(DisplayMode.Normal);
			reportViewer1.ZoomMode = ZoomMode.PageWidth;
			reportViewer1.RefreshReport();
		}
		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void BillReportPrint_Load(object sender, EventArgs e)
		{

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
			reportViewer1.PrintDialog();
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



		private void reportViewer1_ReportRefresh(object sender, System.ComponentModel.CancelEventArgs e)
		{
			reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
			reportViewer1.ZoomMode = ZoomMode.PageWidth;
			
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			reportViewer1.PrintDialog();
		}
	}
}
