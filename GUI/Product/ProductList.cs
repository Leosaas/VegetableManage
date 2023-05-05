using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace GUI
{
	public partial class ProductList : UserControl
	{
		bool isAddNew = false;
		public ProductList()
		{
			InitializeComponent();
			LoadCboCategory();
			LoadCboUnit();
			dgvData.AutoGenerateColumns = false;
			Reload();
			if (!User.IsAdmin)
			{
				rightPanel.Visible = false;
				btnAdd.Visible = false;
				btnDelete.Visible = false;
			}

		}
		private void LoadCboCategory()
		{
			cboCategory.DataSource = CategoryBUS.GetAllCategory();
			cboCategory.DisplayMember = "category_name";
			cboCategory.ValueMember = "idcategory";
		}
		private void LoadCboUnit()
		{
			cboUnit.DataSource = UnitBUS.GetAllUnit();
			cboUnit.DisplayMember = "unit_name";
			cboUnit.ValueMember = "idunit";
		}


		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtName.Enabled = true;
			txtId.Enabled = false;
			txtId.Text = dgvData.SelectedRows[0].Cells["idproduct"].Value.ToString();
			txtName.Text = dgvData.SelectedRows[0].Cells["product_name"].Value.ToString();
			cboCategory.SelectedValue = dgvData.SelectedRows[0].Cells["idcategory"].Value.ToString();
			cboUnit.SelectedValue = dgvData.SelectedRows[0].Cells["idunit"].Value.ToString();
			isAddNew = false;
			btnDelete.Enabled = true;
		}
		private void Reload()
		{
			BindingSource binding = new BindingSource();
			DataTable data = ProductBUS.GetAllProductsWithCategoryAndUnit();
			if (data == null)
			{
				MessageBoxForm.Show("Không thể tải lên danh sách sản phẩm", "Lỗi");
				return;
			}
			binding.DataSource = data;
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
			string type = cboCategory.SelectedValue.ToString();
			string unit = cboUnit.SelectedValue.ToString();
			ProductDTO product = new ProductDTO(id, name, type, unit);
			if (isAddNew)
			{
				string result = ProductBUS.InsertProduct(product);
				if (result != null)
				{
					MessageBoxForm.Show(result, "Thông báo");
					return;
				}
				MessageBoxForm.Show("Thêm thành công", "Thông báo");
				Log.Write("Thêm rau củ " + name);
			}
			else
			{
				string oldName = ProductBUS.GetProductById(id).Name;
				string result = ProductBUS.UpdateProduct(product);
				if (result != null)
				{
					MessageBoxForm.Show(result, "Thông báo");
					return;
				}
				MessageBoxForm.Show("Sửa thành công", "Thông báo");
				Log.Write("Sửa rau củ " + oldName + " thành "+name);
			}
			Reload();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string id = txtId.Text;
			string name = txtName.Text;
			string type = cboCategory.SelectedValue.ToString();
			string unit = cboUnit.SelectedValue.ToString();
			ProductDTO product = new ProductDTO(id, name, type, unit);
			if (MessageBoxForm.Show("Bạn có thực sự muốn xoá ?", "Xác nhận") == DialogResult.OK)
			{
				string result = ProductBUS.DeleteProduct(product);
				if (result != null)
				{
					MessageBoxForm.Show(result, "Thông báo");
					return;
				}
				MessageBoxForm.Show("Xoá thành công", "Thông báo");
				Log.Write("Xoá rau củ " + name);

			}
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
