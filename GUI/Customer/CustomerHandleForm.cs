using BUS;
using DTO;
using GUI;
using System.Windows.Forms;
using System;

namespace VegetablesManager.AppForm
{
	public partial class CustomerHandleForm : Form
	{
		CustomerDTO customer;
		bool isAddNew;

		public CustomerDTO Customer { get => customer;  }

		public CustomerHandleForm()
		{
			InitializeComponent();
			isAddNew = true;
			this.AcceptButton = btnAccept;
			lblTitle.Text = "Thêm";
			lblRank.Visible = false;
			nmrRank.Visible = false;
		
		}
		public CustomerHandleForm(CustomerDTO customer)
		{
			InitializeComponent();
			this.AcceptButton = btnAccept;
			isAddNew = false;
			this.customer = customer;
			lblTitle.Text = "Sửa";
			txtPhoneNumber.Enabled = false;

			txtPhoneNumber.Text = customer.PhoneNumber;
			txtName.Text = customer.CustomerName;
			txtAddress.Text = customer.Address;
			nmrRank.Value = customer.Rank;

			if (!User.IsManager)
			{
				lblRank.Visible = false;
				nmrRank.Visible = false;
			}
		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			
			customer = new CustomerDTO(txtPhoneNumber.Text, txtName.Text, txtAddress.Text, (int)nmrRank.Value);
			if (string.IsNullOrEmpty(customer.PhoneNumber))
			{
				MessageBoxForm.Show("Số điện thoại không được để trống", "Thông báo");
				txtPhoneNumber.Focus();
				return;
			}
			if (string.IsNullOrEmpty(customer.CustomerName))
			{
				MessageBoxForm.Show("Tên khách hàng không được để trống", "Thông báo");
				txtName.Focus();
				return;
			}
			string message = isAddNew ? CustomerBUS.AddNewCustomer(customer) : CustomerBUS.UpdateCustomer(customer);
			if (!string.IsNullOrEmpty(message))
			{
				MessageBoxForm.Show(message, "Thông báo");
				txtPhoneNumber.Focus();
				return;
			}
			string log = isAddNew ? "Thêm khách hàng " + customer.CustomerName : "Sửa thông tin khách hàng " + customer.CustomerName;
			Log.Write(log);
			this.DialogResult = DialogResult.OK;
		}

	}
}
