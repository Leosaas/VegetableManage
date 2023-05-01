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
	public partial class BillReportPrint : Form
	{
		OrderBillDTO order;
		SellBillDTO sellBill;
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool ReleaseCapture();
		bool maximize = false;
		public BillReportPrint(OrderBillDTO order,DataTable list)	
		{
			InitializeComponent();
			this.order = order;
			LoadOrderBill(list);
		}
		public BillReportPrint(SellBillDTO sellBill, DataTable list)
		{
			InitializeComponent();
			this.sellBill = sellBill;
			LoadSellBill(list);
		}
		private void LoadOrderBill(DataTable list)
		{
			ReportParameter[] parameters = new ReportParameter[]
			{
				new ReportParameter("idpurchasebill",order.Id.ToString()),
				new ReportParameter("date",order.Date.ToString("dd/MM/yyyy")),
				new ReportParameter("username",order.Username.ToString())
			};
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportDefinition.OrderBillReport.rdlc";
			reportViewer1.LocalReport.SetParameters(parameters);
			ReportDataSource rds = new ReportDataSource("PurchaseBillDetailProductDataset", list);
			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(rds);
			reportViewer1.SetDisplayMode(DisplayMode.Normal);
			reportViewer1.ZoomMode = ZoomMode.PageWidth;
			reportViewer1.RefreshReport();
		}
		private void LoadSellBill(DataTable list)
		{
			ReportParameter[] parameters = new ReportParameter[]
			{
				new ReportParameter("idsellbill",sellBill.Id.ToString()),
				new ReportParameter("date",sellBill.Date.ToString("dd/MM/yyyy")),
				new ReportParameter("username",sellBill.Username.ToString()),
				new ReportParameter("customer",sellBill.CustomerName),
				new ReportParameter("discount",sellBill.Discount.ToString()),
				new ReportParameter("total",sellBill.Total.ToString())
			};
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportDefinition.SellBillReport.rdlc";
			reportViewer1.LocalReport.SetParameters(parameters);
			ReportDataSource rds = new ReportDataSource("SellBillDetailProductDataset", list);
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
