using DTO;
using GUI.Product;
using GUI.Bill;
using System;
using System.Drawing;
using System.Windows.Forms;
using BUS;

namespace GUI
{
	public partial class MainForm : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		bool maximize = true;
		bool showLog = false;
		bool menuExtend = true;
		static UserDTO user;
		int state;
		public Panel MainPanel { get; set; }
		public static AccountDTO account;
		public static UserDTO User { get => user; }
		public static AccountDTO Account { get => account; }

		public MainForm(UserDTO user,AccountDTO account)
		{
			InitializeComponent();
			MainForm.account = account;
			MainForm.user = user;
			//         changeMenubar(new AdminMenuBar(this));
			state = 1;
			enableControl(new ProductMainControl());
			EnableButton(btnProduct);
		
			leftMenuPanel.Width = 230;
			lblUser.Text = user.Name;
			btnMenu.BackColor = Color.FromArgb(12, 108, 44);
			GrantUserRight();
		}
		private void MakeButtonInvisible(params Button[] buttons)
		{
			foreach(Button button in buttons)
			{
				button.Visible = false;	
			}
		}
		private void GrantUserRight()
		{
			switch (account.Type)
			{
				case 0: //Nhân viên
					MakeButtonInvisible(btnPrice, btnAccount, btnReport, btnSystem);
					enableControl(new ProductMainControl());
					EnableButton(btnProduct);
					break;
				case 1: //Admin
					MakeButtonInvisible(btnPrice, btnReport, btnBill,btnProduct,btnCustomer );
					enableControl(new AccountMainControl());
					EnableButton(btnAccount);
					break;
				default://Quản lý
					MakeButtonInvisible(btnAccount, btnSystem);
					enableControl(new ProductMainControl());
					EnableButton(btnProduct);
					break;
			}

		}
		private void EnableButton(Button b)
		{

			foreach (Control control in leftMenuPanel.Controls)
			{

				if (control is Button)
				{
					control.BackColor = Color.FromArgb(64, 64, 64);
				}

			}
			b.BackColor = Color.Green;
		}
		public void enableControl(UserControl control)
		{
			if (mainPanel.Controls.Count > 0)
			{
				mainPanel.Controls.Clear();
			}
			control.Dock = DockStyle.Fill;
			control.Visible = true;
			control.Enabled = true;
			control.BringToFront();
			mainPanel.Controls.Add(control);
		}


		private void btnResize_Click(object sender, EventArgs e)
		{
			if (maximize)
			{
				WindowState = FormWindowState.Normal;
				btnResize.Image = Properties.Resources.maximize;

			}
			else
			{
				WindowState = FormWindowState.Maximized;
				btnResize.Image = Properties.Resources.minimize;
			}

			maximize = !maximize;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			if (MessageBoxForm.Show("Bạn có thực sự muốn thoát ?", "Xác nhận") == DialogResult.OK)
			{
				Log.Write("Đăng xuất");
				Application.Exit();
			}
				
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{


		}
		private void RemoveButtonTextLeftPanel()
		{
			foreach (Control b in leftMenuPanel.Controls)
			{
				if (b is Button)
				{
					((Button)b).Text = "";
					((Button)b).ImageAlign = ContentAlignment.MiddleCenter;
				}

			}
		}
		private void btnMenu_Click(object sender, EventArgs e)
		{
			menuExtend = !menuExtend;
			if (menuExtend)
			{
				leftMenuPanel.Width = 230;
				btnProduct.Text = " Sản phẩm";
				btnPrice.Text = " Giá bán";
				btnBill.Text = " Hoá đơn";
				btnAccount.Text = "Tài khoản";
				btnInfomation.Text = " Cá nhân";
				foreach (Control b in leftMenuPanel.Controls)
				{
					if (b is Button)
					{
						((Button)b).TextImageRelation = TextImageRelation.ImageBeforeText;
					}

				}
				picLogo.Visible = true;
				btnMenu.BackColor = Color.FromArgb(12, 108, 44);
				return;
			}
			leftMenuPanel.Width = 70;
			RemoveButtonTextLeftPanel();
			picLogo.Visible = false;
			btnMenu.BackColor = Color.FromArgb(64, 64, 64);
		}



		private void btnProduct_Click(object sender, EventArgs e)
		{
			if (state == 1)
				return;
			EnableButton(btnProduct);
			enableControl(new ProductMainControl());

			state = 1;

		}




		private void btnPrice_Click(object sender, EventArgs e)
		{
			if (state == 2)
				return;
			EnableButton(btnPrice);
			enableControl(new ProductPrice());

			state = 2;
		}

		private void lblTitle_Click(object sender, EventArgs e)
		{
			enableControl(new UserControl());
		}





		private void btnBill_Click(object sender, EventArgs e)
		{
			if (state == 3)
				return;
			EnableButton(btnBill);
			enableControl(new BillMainControl());
			state = 3;
		}

		private void topPanel_MouseDown(object sender, MouseEventArgs e)
		{
			if (maximize)
				return;
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void lblTitle_MouseDown(object sender, MouseEventArgs e)
		{
			if (maximize)
				return;
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void btnHide_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void btnAccount_Click(object sender, EventArgs e)
		{
			if (state == 4)
				return;
			EnableButton(btnAccount);
			enableControl(new AccountMainControl());
			state = 4;
		}

		private void btnLogout_Click_1(object sender, EventArgs e)
		{
			if(MessageBoxForm.Show("Bạn có thực sự muốn đăng xuất ?","Xác nhận")== DialogResult.OK)
			{
				Log.Write("Đăng xuất");
				new LoginForm().Show();
				this.Close();
			}
			
		}

		private void btnInfomation_Click(object sender, EventArgs e)
		{
			if (state == 5)
				return;
			EnableButton(btnInfomation);
			enableControl(new UserInfomation(user,account));
			state = 5;
			
		}

		private void btnCustomer_Click(object sender, EventArgs e)
		{
			if (state == 6)
				return;
			EnableButton(btnCustomer);
			enableControl(new CustomerMainControl());
			state = 6;
		}

		private void btnSystem_Click(object sender, EventArgs e)
		{
			if (state == 7)
				return;
			EnableButton(btnSystem);
			enableControl(new SystemControl());
			state = 7;
		}

		private void btnReport_Click(object sender, EventArgs e)
		{
			if (state == 8)
				return;
			EnableButton(btnReport);
			enableControl(new ReportMainControl());
			state = 8;
		}
	}
}
