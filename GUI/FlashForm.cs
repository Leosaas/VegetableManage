using BUS;
using DTO;
using GUI;
using System.Windows.Forms;
using System;
using System.Drawing;

namespace GUI
{
	public partial class FlashForm : Form
	{

		public FlashForm()	
		{

			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			new LoginForm().Show();
			timer1.Enabled =false;
			this.Hide();
		}
	}
}
