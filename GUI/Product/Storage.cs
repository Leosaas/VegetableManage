
using DTO;
using System.Data;
using BUS;
using System.Windows.Forms;
using System;

namespace GUI
{
	public partial class Storage : UserControl
	{
		public Storage()
		{
			InitializeComponent();
			Reload();

		}




		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
			{
				return;
			}
			int value = int.Parse(dgvData.SelectedRows[0].Cells["storage_quantity"].Value.ToString());
			nmrQuantity.Maximum = value;
			nmrQuantity.Value = value;
	
			nmrQuantity.Enabled = true;
			btnSave.Enabled = true;
		}
		private void Reload()
		{
			DataTable list = StorageBUS.GetStorageInfo();
			if (list == null)
			{
				MessageBoxForm.Show("Không thể tải thông tin kho", "Lỗi");
				return;
			}
			BindingSource binding = new BindingSource();
			binding.DataSource = list;
			dgvData.DataSource = binding;
			nmrQuantity.Enabled = false;
			btnSave.Enabled = false;
		}


		private void btnSave_Click(object sender, EventArgs e)
		{
			string id = dgvData.SelectedRows[0].Cells["idproduct"].Value.ToString();
			string productName = ProductBUS.GetProductById(id).Name;
			int quantity = int.Parse(nmrQuantity.Value.ToString());
			int oldQuantity = StorageBUS.GetQuantityOfProduct(id);
			StorageDTO detail = new StorageDTO();
			detail.Quantity = quantity;
			detail.IdProduct = id;
			string result = StorageBUS.UpdateQuantity(detail);
			if (result != null)
			{
				MessageBoxForm.Show(result, "Thông báo");
				return;
			}
			MessageBoxForm.Show("Cập nhật số lượng thành công", "Thông báo");
			Log.Write("Cập nhật số lượng tồn kho của " + productName + " từ " + oldQuantity + " thành " + quantity);
			Reload();
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

	}
}
