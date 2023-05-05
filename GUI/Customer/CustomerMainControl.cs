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
	public partial class CustomerMainControl : UserControl
	{
		int state;
		public CustomerMainControl()
		{
			InitializeComponent();
			enableControl(new CustomerList());
			state = 1;
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

		private void btnOrder_Click(object sender, EventArgs e)
		{
			if (state == 1)
				return;
			enableControl(new CustomerList());
			state = 1;

		}

		private void btnOrderList_Click(object sender, EventArgs e)
		{
			if (state == 3)
				return;
			enableControl(new BillList());
			state = 3;
		}

		private void btnSellBill_Click(object sender, EventArgs e)
		{
			if (state == 2)
				return;
			enableControl(new CustomerDebtList());
			state = 2;
		}
	}
}
