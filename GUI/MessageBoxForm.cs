using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
	public partial class MessageBoxForm : Form
	{
		private static MessageBoxForm instance = new MessageBoxForm();

		private MessageBoxForm()
		{

			InitializeComponent();
			this.AcceptButton = btnAccept;

		}
		public static DialogResult Show(string info, string title)
		{
			instance.lblInfo.Text = info;
			instance.lblTitle.Text = title;
			return instance.ShowDialog();
		}
	}
}
