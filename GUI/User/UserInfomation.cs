
using DTO;
using System.Data;
using BUS;
using System.Windows.Forms;
using System.Xml.Linq;
using System;
using VegetablesManager.AppForm;

namespace GUI
{
	public partial class UserInfomation : UserControl
	{
		UserDTO user;
		AccountDTO account;	
		public UserInfomation(UserDTO user,AccountDTO account)
		{
			InitializeComponent();
			this.user = user;
			this.account = account;

		}

		private void btnInfoUpdate_Click(object sender, EventArgs e)
		{
			UserHandleForm frm = new UserHandleForm(user);
			if(frm.ShowDialog() == DialogResult.OK)
			{
				MessageBoxForm.Show("Cập nhật thành công", "Thông báo");
				user = frm.User;
				UserInfomation_Load(sender, e);
			}
		}

		private void btnPassUpdate_Click(object sender, EventArgs e)
		{
			if(new ChangePassForm(account).ShowDialog() == DialogResult.OK)
			{
				MessageBoxForm.Show("Cập nhật thành công", "Thông báo");
			}
		}

		private void UserInfomation_Load(object sender, EventArgs e)
		{
			lblUsername.Text = user.Username;
			lblName.Text = user.Name;
			lblAddress.Text = user.Address;
			lblPhoneNumber.Text = user.Phonenumber;
		}
	}
}
