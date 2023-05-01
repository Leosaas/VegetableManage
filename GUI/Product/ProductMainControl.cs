using GUI.Bill;
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
	public partial class ProductMainControl : UserControl
	{
		int state;
		public ProductMainControl()
		{
			InitializeComponent();
			state = 1;
			enableControl(new ProductList());
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
		private void btnProduct_Click(object sender, EventArgs e)
		{
			if (state == 1)
				return;
			enableControl(new ProductList());
			state = 1;
		}

		private void btnCategory_Click(object sender, EventArgs e)
		{
			if (state == 2)
				return;
			enableControl(new Category());
			state = 2;
		}

		private void btnUnit_Click(object sender, EventArgs e)
		{
			if (state == 3)
				return;
			enableControl(new ProductUnit());
			state = 3;
		}

		private void btnStorage_Click(object sender, EventArgs e)
		{
			if (state == 4)
				return;
			enableControl(new Storage());
			state = 4;
		}

	}
}
