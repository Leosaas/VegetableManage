using BUS;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI.Bill
{
	public partial class ReportByProduct : UserControl
	{
		DataTable data;
		bool sellSelected;
		public ReportByProduct()
		{
			InitializeComponent();



			dtpFrom.MaxDate = DateTime.Now;
			dtpTo.MaxDate = DateTime.Now;
			dtpFrom.CustomFormat = "MM/yyyy";
			dtpTo.CustomFormat = "MM/yyyy";
			LoadData();
		}

		private void LoadData()
		{
			
			BindingSource binding = new BindingSource();
			binding.DataSource = ProductBUS.GetBuyAndSellOfAllProductFromDateToDate(dtpFrom.Value,dtpTo.Value);
			dgvData.DataSource = binding;
			foreach(DataGridViewRow dr in dgvData.Rows)
			{
				if (dr.Cells["buy"].Value == null || dr.Cells["buy"].Value == DBNull.Value)
				{
					dr.Cells["buy"].Value = 0;
				}
				if (dr.Cells["sell"].Value == null || dr.Cells["sell"].Value == DBNull.Value)
				{
					dr.Cells["sell"].Value = 0;
				}
			}
			

		}




		private void btnDetail_Click(object sender, EventArgs e)
		{
			new ReportDetail(dtpFrom.Value, dtpTo.Value).ShowDialog();
		}

		private void dtpFrom_ValueChanged(object sender, EventArgs e)
		{
			LoadData();
		}

		private void dtpTo_ValueChanged(object sender, EventArgs e)
		{
			LoadData();
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
