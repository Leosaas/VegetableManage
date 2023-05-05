using BUS;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI.Bill
{
	public partial class ReportByMonth : UserControl
	{
		DataTable data;
		bool sellSelected;
		public ReportByMonth()
		{
			InitializeComponent();



			dtpFrom.MaxDate = DateTime.Now;
			dtpTo.MaxDate = DateTime.Now;
			dtpFrom.CustomFormat = "MM/yyyy";
			dtpTo.CustomFormat = "MM/yyyy";
			LoadSellBill();
			LoadOrderBill();
		}
		private void LoadSellBill()
		{

			BindingSource binding = new BindingSource();
			binding.DataSource = SellBillBUS.GetSellBillByMonthAndYearFromDateToDate(dtpFrom.Value, dtpTo.Value);
			dgvSell.DataSource = binding;



		}
		private void LoadOrderBill()
		{
			
			BindingSource binding = new BindingSource();
			binding.DataSource = OrderProductBUS.GetOrderBillByMonthAndYearFromDateToDate(dtpFrom.Value,dtpTo.Value);
			dgvBuy.DataSource = binding;
	
			

		}




		private void btnDetail_Click(object sender, EventArgs e)
		{
			if (dgvSell.SelectedRows[0].Index < 0)
				return;
			string[] time = sellSelected ? dgvSell.SelectedRows[0].Cells["sellDate"].Value.ToString().Split('-') : dgvBuy.SelectedRows[0].Cells["buyDate"].Value.ToString().Split('-');
			int month = int.Parse(time[0]);
			int year = int.Parse(time[1]);
			new ReportDetail(month, year, sellSelected).ShowDialog();
		}

		private void dtpFrom_ValueChanged(object sender, EventArgs e)
		{
			LoadSellBill();
			LoadOrderBill();
		}

		private void dtpTo_ValueChanged(object sender, EventArgs e)
		{
			LoadSellBill();
			LoadOrderBill();
		}

		private void dgvSell_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			sellSelected = true;
		}

		private void dgvBuy_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			sellSelected = false;
		}
	}
}
