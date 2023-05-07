
using DTO;
using System.Data;
using BUS;
using System.Windows.Forms;
using System.Xml.Linq;
using System;

namespace GUI
{
	public partial class ProductUnit : UserControl
	{
		bool isAddNew = false;
		public ProductUnit()
		{
			InitializeComponent();
			Reload();
			if (!User.IsManager)
			{
				rightPanel.Visible = false;
				btnAdd.Visible = false;
				btnDelete.Visible = false;
			}
		}




		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtName.Enabled = true;
			txtId.Enabled = false;
			txtId.Text = dgvData.SelectedRows[0].Cells["idunit"].Value.ToString();
			txtName.Text = dgvData.SelectedRows[0].Cells["unit_name"].Value.ToString();
			isAddNew = false;
			btnDelete.Enabled = true;
		}
		private void Reload()
		{
			DataTable list = UnitBUS.GetAllUnit();
			if (list == null)
			{
				MessageBoxForm.Show("Không thể tải danh sách đơn vị", "Lỗi");
				return;
			}
			BindingSource binding = new BindingSource();
			binding.DataSource = list;
			dgvData.DataSource = binding;
			txtId.Text = "";
			txtName.Text = "";
			txtId.Enabled = false;
			txtName.Enabled = false;
			btnDelete.Enabled = false;
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			isAddNew = true;
			txtId.Text = "";
			txtName.Text = "";
			txtName.Enabled = true;
			txtId.Enabled = true;
			txtId.Focus();
			btnDelete.Enabled = false;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string id = txtId.Text;
			string name = txtName.Text;
			UnitDTO unit = new UnitDTO(id, name);
			if (isAddNew)
			{
				string result = UnitBUS.InsertUnit(unit);
				if (result != null)
				{
					MessageBoxForm.Show(result, "Thông báo");
					return;
				}
				MessageBoxForm.Show("Thêm thành công", "Thông báo");
				Log.Write("Thêm đơn vị " + name);
				Reload();
				btnDelete.Enabled = true;
			}
			else
			{
				string oldName = UnitBUS.GetUnitById(id).Name;
				string result = UnitBUS.UpdateUnit(unit);
				if (result != null)
				{
					MessageBoxForm.Show(result, "Thông báo");
					return;
				}
				MessageBoxForm.Show("Sửa thành công", "Thông báo");
				Log.Write("Sửa đơn vị " + oldName + " thành "+name);
		
				Reload();

			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string id = txtId.Text;
			string name = txtName.Text;
			UnitDTO unit = new UnitDTO(id, name);
			if (MessageBoxForm.Show("Bạn có thực sự muốn xoá ?", "Xác nhận") == DialogResult.OK)
			{
				string result = UnitBUS.DeleteUnit(unit);
				if (result != null)
				{
					MessageBoxForm.Show(result, "Thông báo");
					return;
				}
				MessageBoxForm.Show("Xoá thành công", "Thông báo");
				Log.Write("Xoá đơn vị "  + name);
				Reload();
			}
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
