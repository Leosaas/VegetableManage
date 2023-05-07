
using DTO;
using System.Data;
using BUS;
using System.Windows.Forms;
using System;

namespace GUI
{
	public partial class Category : UserControl
	{
		bool isAddNew = false;
		public Category()
		{
			InitializeComponent();
			Reload();
			if(!User.IsManager)
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
			txtId.Text = dgvData.SelectedRows[0].Cells["idcategory"].Value.ToString();
			txtName.Text = dgvData.SelectedRows[0].Cells["category_name"].Value.ToString();
			isAddNew = false;
			btnDelete.Enabled = true;
		}
		private void Reload()
		{
			DataTable list = CategoryBUS.GetAllCategory();
			if (list == null)
			{
				MessageBoxForm.Show("Không thể tải danh sách thể loại", "Lỗi");
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
			CategoryDTO category = new CategoryDTO(id, name);
			
			if (isAddNew)
			{
				string result = CategoryBUS.InsertCategory(category);
				if(result != null)
				{
					MessageBoxForm.Show(result, "Thông báo");
					return;
				}
				MessageBoxForm.Show("Thêm thành công", "Thông báo");
				Log.Write("Thêm thể loại " + category.Name);
				Reload();
				btnDelete.Enabled = true;
			}
			else
			{
				string oldName = CategoryBUS.GetCategoryByID(id).Name;
				string result = CategoryBUS.UpdateCategory(category);
				if (result != null)
				{
					MessageBoxForm.Show(result, "Thông báo");
					return;
				}
				MessageBoxForm.Show("Sửa thành công", "Thông báo");
				Log.Write("Sửa thể loại " + oldName + " thành " + name);
				Reload();

			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string id = txtId.Text;
			string name = txtName.Text;
			CategoryDTO category = new CategoryDTO(id, name);
			if (MessageBoxForm.Show("Bạn có thực sự muốn xoá ?", "Xác nhận") == DialogResult.OK)
			{
				string result = CategoryBUS.DeleteCategory(category);
				if (result != null)
				{
					MessageBoxForm.Show(result, "Thông báo");
					return;
				}
				MessageBoxForm.Show("Xoá thành công", "Thông báo");
				Log.Write("Xoá thể loại " + name);
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
