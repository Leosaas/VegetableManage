using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Product
{
	public partial class AccountMainControl : UserControl
	{
		int state;
		public AccountMainControl()
		{
			InitializeComponent();
			state = 1;
			enableControl(new UserList());
		}
		public void enableControl(UserControl control)
		{
			if (contentPanel.Controls.Count > 0)
			{
				contentPanel.Controls.Clear();
			}
			control.Dock = DockStyle.Fill;
			control.Visible = true;
			control.Enabled = true;
			control.BringToFront();
			contentPanel.Controls.Add(control);
		}

		private void btnUserList_Click(object sender, EventArgs e)
		{
			if (state == 1)
				return;
			enableControl(new UserList());
			state = 1;
		}

		private void btnAccountList_Click(object sender, EventArgs e)
		{
			if (state == 2)
				return;
			enableControl(new AccountList());
			state = 2;
		}

	}
}
