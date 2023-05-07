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
	public partial class BillMainControl : UserControl
	{
		int state;
		public BillMainControl()
		{
			InitializeComponent();
			enableControl(new OrderProduct());
			state = 1;
			if (!User.IsManager)
			{
				btnBillList.Visible = false;
			}
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
			enableControl(new OrderProduct());
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
			enableControl(new SellBill());
			state = 2;
		}
	}
}
