using BUS;
using DTO;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace GUI
{
	public partial class ProductPrice : UserControl
	{
		bool isUpdateSellPrice = false;
		bool isAddNew = false;
		bool isHideBuy = false;
		bool isHideSell = false;
		string selectedProductId;
		public ProductPrice()
		{
			InitializeComponent();
			LoadCategory();
			dgvProduct.AutoGenerateColumns = false;
			dgvSellPrice.AutoGenerateColumns = false;
			dgvBuyPrice.AutoGenerateColumns = false;
			LoadProduct();
			dgvSellPrice.Enabled = false;
			dgvBuyPrice.Enabled = false;
			dtpFrom.MaxDate = DateTime.Today;
			dtpTo.MaxDate = DateTime.Today;

		}
		private void LoadSellPrice()
		{
			DataTable sellPriceData = ProductPriceBUS.GetSellPriceOfProduct(selectedProductId);
			BindingSource binding = new BindingSource();
			binding.DataSource = sellPriceData;
			dgvSellPrice.DataSource = binding;
		}
		private void LoadBuyPrice()
		{
			DataTable buyPriceData = ProductPriceBUS.GetBuyPriceOfProduct(selectedProductId);
			BindingSource binding = new BindingSource();
			binding.DataSource = buyPriceData;
			dgvBuyPrice.DataSource = binding;
		}
		private void LoadProduct()
		{
			BindingSource binding = new BindingSource();
			binding.DataSource = ProductBUS.GetAllProductsWithCategoryAndUnit();
			dgvProduct.DataSource = binding;
		}
		private void LoadCategory()
		{
			DataTable categoryData = CategoryBUS.GetAllCategory();
			DataRow dr = categoryData.NewRow();
			dr["category_name"] = "Tất cả";
			dr["idcategory"] = "All";
			categoryData.Rows.InsertAt(dr, 0);
			cboCategory.DataSource = categoryData;
			cboCategory.DisplayMember = "category_name";
			cboCategory.ValueMember = "idcategory";
		}





		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			string searchValue = txtSearch.Text;
			foreach (DataGridViewRow row in dgvProduct.Rows)
			{
				CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvProduct.DataSource];
				currencyManager1.SuspendBinding();
				row.Visible = false;
				currencyManager1.ResumeBinding();
			}
			foreach (DataGridViewRow row in dgvProduct.Rows)
			{
				foreach (DataGridViewCell cell in row.Cells)
				{
					if (cell.Value.ToString().Contains(searchValue))
					{
						CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvProduct.DataSource];
						currencyManager1.SuspendBinding();
						row.Visible = true;
						currencyManager1.ResumeBinding();
					}
				}
			}
		}
		private void AdjustSellTitle()
		{
			if (isHideSell && !isHideBuy)
			{
				sellTitlePanel.Dock = DockStyle.Bottom;
			}
			else
			{
				sellTitlePanel.Dock = DockStyle.Top;
			}
		}
		private void btnFind_Click(object sender, EventArgs e)
		{

		}


		private void btnPriceUpdate_Click(object sender, EventArgs e)
		{
			isUpdateSellPrice = !isUpdateSellPrice;
			sellRightPanel.Visible = isUpdateSellPrice;
			if (isUpdateSellPrice)
			{
				btnPriceUpdate.BackColor = Color.Red;
				btnPriceUpdate.Text = "Huỷ";
			}
			else
			{
				btnPriceUpdate.BackColor = Color.Green;
				btnPriceUpdate.Text = "Cập nhật giá bán";
			}

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			ProductPriceDTO productPriceDTO = new ProductPriceDTO();
			float price = float.Parse(nmrPrice.Value.ToString());
			DateTime date = DateTime.Today;
			productPriceDTO.Price = price;
			productPriceDTO.Idproduct = selectedProductId;
			productPriceDTO.Date = date;
			string result = ProductPriceBUS.AddProductSellPrice(productPriceDTO);
			if(result != null)
			{
				MessageBoxForm.Show(result, "Thông báo");
				return;
			}
			MessageBoxForm.Show("Cập nhật thành công", "Thông báo");
			LoadSellPrice();
			string productName = ProductBUS.GetProductById(selectedProductId).Name;
			Log.Write("Cập nhật giá bán của sản phẩm " + productName + " thành " + price);

		}

		private void btnHideBuy_Click(object sender, EventArgs e)
		{
			isHideBuy = !isHideBuy;
			buyPanel.Visible = !isHideBuy;
			if (isHideBuy)
			{
				btnHideBuy.Text = "Hiện";
				btnHideBuy.BackColor = Color.Green;
			}
			else
			{
				btnHideBuy.Text = "Ẩn";
				btnHideBuy.BackColor = Color.Red;
			}
			AdjustSellTitle();
		}

		private void btnHideSell_Click(object sender, EventArgs e)
		{
			isHideSell = !isHideSell;
			sellPricePanel.Visible = !isHideSell;
			if (isHideSell)
			{
				buyPanel.Dock = DockStyle.Fill;
				btnHideSell.BackColor = Color.Green;
				btnHideSell.Text = "Hiện";
			}
			else
			{
				buyPanel.Dock = DockStyle.Top;
				btnHideSell.BackColor = Color.Red;
				btnHideSell.Text = "Ẩn";
			}
			AdjustSellTitle();
		}

		private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (dgvProduct.Rows.Count == 0)
			{
				return;
			}
			CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvProduct.DataSource];
			currencyManager1.SuspendBinding();
			if (cboCategory.SelectedValue.ToString().Equals("All"))
			{
				foreach (DataGridViewRow row in dgvProduct.Rows)
				{

					row.Visible = true;

				}
				currencyManager1.ResumeBinding();
				return;
			}
			foreach (DataGridViewRow row in dgvProduct.Rows)
			{

				row.Visible = false;

			}
			foreach (DataGridViewRow row in dgvProduct.Rows)
			{
				if (row.Cells["idcategory"].Value.ToString().Equals(cboCategory.SelectedValue.ToString()))
				{

					row.Visible = true;
				}

			}
			currencyManager1.ResumeBinding();
		}


		private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;
			dgvSellPrice.Enabled = true;
			dgvBuyPrice.Enabled = true;
			selectedProductId = dgvProduct.SelectedRows[0].Cells["idproduct"].Value.ToString();
			LoadSellPrice();
			LoadBuyPrice();

		}

		private void btnFilter_Click(object sender, EventArgs e)
		{
			DataTable sellPriceData = ProductPriceBUS.GetProductSellPriceByDate(selectedProductId, dtpFrom.Value, dtpTo.Value.AddDays(1));
			BindingSource binding = new BindingSource();
			binding.DataSource = sellPriceData;
			dgvSellPrice.DataSource = binding;

			DataTable buyPriceData = ProductPriceBUS.GetProductBuyPriceByDate(selectedProductId, dtpFrom.Value, dtpTo.Value.AddDays(1));
			dgvBuyPrice.DataSource = buyPriceData;
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			LoadSellPrice();
			LoadBuyPrice();

		}

	}
}
