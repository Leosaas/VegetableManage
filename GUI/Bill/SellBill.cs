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

namespace GUI.Bill
{
	public partial class SellBill : UserControl
	{
		int count = 1;
		DataTable billDetails;
		bool isChanging = false;
		string selectedProductId;
		CustomerDTO customer;
		public SellBill()
		{
			InitializeComponent();
			dgvProduct.AutoGenerateColumns = false;
			LoadCategory();
			LoadProduct();
			InitBillDetail();
			//    ClearProductBinding();
			AddProductBinding();
		}
		private void CalculateTotalPrice()
		{
			double totalPrice = 0;
			double finishPrice = 0;
			foreach (DataRow dr in billDetails.Rows)
			{
				totalPrice += float.Parse(dr["total"].ToString());
			}
			lblTotal.Text = totalPrice.ToString() + " VND";
			lblDiscount.Text = customer == null ? "0%" : customer.Rank * 5 + "%";
			if(customer == null || customer.Rank == 0)
			{
				finishPrice = totalPrice;
			}
			else
			{
				float discount = customer.Rank * 5;
				finishPrice = totalPrice - (totalPrice * (discount / 100));
			}
			lblFinishMoney.Text = finishPrice + " VND";
		}
		private void InitBillDetail()
		{
			count = 1;
			billDetails = new DataTable();
			billDetails.Columns.Add("id", typeof(int));
			billDetails.Columns.Add("idproduct", typeof(string));
			billDetails.Columns.Add("product_name", typeof(string));
			billDetails.Columns.Add("unit_name", typeof(string));
			billDetails.Columns.Add("price", typeof(float));
			billDetails.Columns.Add("quantity", typeof(int));
			billDetails.Columns.Add("total", typeof(float));
			BindingSource bd = new BindingSource();
			bd.DataSource = billDetails;
			dgvOrderDetail.DataSource = bd;
		}
		private void LoadProduct()
		{
			BindingSource binding = new BindingSource();
			binding.DataSource = ProductBUS.GetAllProductsWithCategoryAndUnitAndSellPrice();
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
		private void ClearProductBinding()
		{
			txtUnit.DataBindings.Clear();
			txtProductName.DataBindings.Clear();
		}
		private void AddProductBinding()
		{
			txtProductName.DataBindings.Add("Text", dgvProduct.DataSource, "product_name");
			txtUnit.DataBindings.Add("Text", dgvProduct.DataSource, "unit_name");
			txtUnitPrice.DataBindings.Add("Text", dgvProduct.DataSource, "price");
		}
		private void btnChange_Click(object sender, EventArgs e)
		{
			isChanging = !isChanging;
			changeDetailPanel.Visible = isChanging;
			btnChange.BackColor = isChanging ? Color.Red : Color.Blue;
			btnChange.Text = isChanging ? "Ẩn" : "Chỉnh sửa phiếu";
			leftMenuPanel.Enabled = !isChanging;
			dgvOrderDetail.Enabled = isChanging;
		}
		private bool FindProductInBill(string productId)
		{
			foreach (DataRow dr in billDetails.Rows)
			{
				if (dr["idproduct"].ToString().Equals(productId))
				{
					return true;
				}
			}
			return false;
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (FindProductInBill(dgvProduct.SelectedRows[0].Cells["idproduct"].Value.ToString()))
			{
				MessageBoxForm.Show("Sản phẩm đã có trong phiếu, vui lòng cập nhật sản phẩm trong phiếu thay vì thêm vào", "Thông báo");
				return;
			}
			DataRow row = billDetails.NewRow();
			row["id"] = count++;
			row["idproduct"] = dgvProduct.SelectedRows[0].Cells["idproduct"].Value.ToString();
			row["product_name"] = txtProductName.Text;
			row["unit_name"] = txtUnit.Text;
			float unitPrice = float.Parse(txtUnitPrice.Text);
			int quantity = int.Parse(nmrCount.Value.ToString());
			float total = unitPrice * quantity;
			row["price"] = unitPrice;
			row["quantity"] = quantity;
			row["total"] = total;
			billDetails.Rows.Add(row);
			btnMakeOrder.Enabled = true;
			btnReset.Enabled = true;
			CalculateTotalPrice();
		}

		private void dgvOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;
			txtChangeDetailProductName.Text = dgvOrderDetail.SelectedRows[0].Cells["orderDetailProductName"].Value.ToString();
			txtChangeDetailProductUnit.Text = dgvOrderDetail.SelectedRows[0].Cells["orderDetailUnitName"].Value.ToString();
			nmrChangeDetailCount.Value = int.Parse(dgvOrderDetail.SelectedRows[0].Cells["quantity"].Value.ToString());
			txtChangeDetailUnitPrice.Text = dgvOrderDetail.SelectedRows[0].Cells["price"].Value.ToString();
			selectedProductId = dgvOrderDetail.SelectedRows[0].Cells["orderDetailIdProduct"].Value.ToString();
			changeDetailPanel.Enabled = true;
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			if (MessageBoxForm.Show("Bạn có thực sự muốn xoá toàn bộ ?", "Thông báp") == DialogResult.OK)
			{
				count = 0;
				billDetails.Clear();
				MessageBoxForm.Show("Đã xoá", "Thông báo");
				changeDetailPanel.Enabled = false;
				btnMakeOrder.Enabled = false;
				btnReset.Enabled = false;
			}
			CalculateTotalPrice();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{

			if (MessageBoxForm.Show("Bạn có thực sự muốn xoá dòng này ?", "Xác nhận") == DialogResult.OK)
			{
				count--;
				dgvOrderDetail.Rows.Remove(dgvOrderDetail.SelectedRows[0]);
				MessageBoxForm.Show("Đã xoá", "Thông báo");
			}
			if (dgvOrderDetail.Rows.Count == 0)
			{
				changeDetailPanel.Enabled = false;
				btnMakeOrder.Enabled = false;
				btnReset.Enabled = false;
			}
			CalculateTotalPrice();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			int quantity = int.Parse(nmrChangeDetailCount.Value.ToString());
			float price = float.Parse(txtChangeDetailUnitPrice.Text);
			float total = quantity * price;
			var row = dgvOrderDetail.SelectedRows[0];
			row.Cells["quantity"].Value = quantity;
			row.Cells["price"].Value = price;
			row.Cells["total"].Value = total;
			MessageBoxForm.Show("Đã lưu", "Thông báo");
			CalculateTotalPrice();
		}

		private void btnMakeOrder_Click(object sender, EventArgs e)
		{
			List<BillDetailDTO> lst = new List<BillDetailDTO>();
			double billTotal = 0;
			foreach (DataRow dr in billDetails.Rows)
			{
				string idProduct = dr["idproduct"].ToString();
				int quantity = int.Parse(dr["quantity"].ToString());
				float price = float.Parse(dr["price"].ToString());
				billTotal += quantity * price;
				lst.Add(new BillDetailDTO(idProduct, quantity, price));
			}
			string customerPhone = customer == null ? null : customer.PhoneNumber;
			int discount = customer == null ? 0 : customer.Rank * 5;
			billTotal -= billTotal * (discount / 100.0);
			SellBillDTO bill = new SellBillDTO(DateTime.Now, (float)billTotal, User.Username, discount, customer, lst);
			string message = SellBillBUS.MakeBill(bill);
			if(message != null)
			{
				MessageBoxForm.Show(message, "Thông báo");
				return;
			}
			MessageBoxForm.Show("Lập hoá đơn bán hàng thành công", "Thông báo");
			Log.Write("Lập hoá đơn bán hàng " + SellBillBUS.GetLastID());
			InitBillDetail();
			CalculateTotalPrice();
		}

		private void btnCustomer_Click(object sender, EventArgs e)
		{
			ChooseCustomerForm frm = new ChooseCustomerForm();
			string phoneNumber = "";
			if(frm.ShowDialog() == DialogResult.OK)
			{
				phoneNumber = frm.CustomerPhone;
				
			}
			if (string.IsNullOrEmpty(phoneNumber))
			{
				customer = null;
				lblCustomer.Text = "Khách vãng lai";
			}
				
			else
			{
				customer = CustomerBUS.GetCustomerByPhoneNumber(phoneNumber);
				lblCustomer.Text = customer.CustomerName;
			}
				
			CalculateTotalPrice();
		}

	}
}
