using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Drawing;

namespace GUI
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mainPanel = new System.Windows.Forms.Panel();
			this.topPanel = new System.Windows.Forms.Panel();
			this.btnHide = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnResize = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.bottomPanel = new System.Windows.Forms.Panel();
			this.btnLogout = new System.Windows.Forms.Button();
			this.lblUser = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.leftMenuPanel = new System.Windows.Forms.Panel();
			this.btnHelp = new System.Windows.Forms.Button();
			this.btnSystem = new System.Windows.Forms.Button();
			this.btnReport = new System.Windows.Forms.Button();
			this.btnCustomer = new System.Windows.Forms.Button();
			this.btnInfomation = new System.Windows.Forms.Button();
			this.btnAccount = new System.Windows.Forms.Button();
			this.btnBill = new System.Windows.Forms.Button();
			this.btnPrice = new System.Windows.Forms.Button();
			this.btnProduct = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnMenu = new System.Windows.Forms.Button();
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.topPanel.SuspendLayout();
			this.bottomPanel.SuspendLayout();
			this.leftMenuPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.AutoScroll = true;
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(300, 46);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1300, 622);
			this.mainPanel.TabIndex = 1;
			// 
			// topPanel
			// 
			this.topPanel.BackColor = System.Drawing.Color.Green;
			this.topPanel.Controls.Add(this.btnHide);
			this.topPanel.Controls.Add(this.btnExit);
			this.topPanel.Controls.Add(this.btnResize);
			this.topPanel.Controls.Add(this.lblTitle);
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Location = new System.Drawing.Point(0, 0);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(1600, 46);
			this.topPanel.TabIndex = 23;
			// 
			// btnHide
			// 
			this.btnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnHide.FlatAppearance.BorderSize = 0;
			this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHide.Image = global::GUI.Properties.Resources.minus;
			this.btnHide.Location = new System.Drawing.Point(1445, 3);
			this.btnHide.Name = "btnHide";
			this.btnHide.Size = new System.Drawing.Size(46, 38);
			this.btnHide.TabIndex = 10;
			this.btnHide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnHide.UseVisualStyleBackColor = true;
			this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.FlatAppearance.BorderSize = 0;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Image = global::GUI.Properties.Resources.exit;
			this.btnExit.Location = new System.Drawing.Point(1549, 3);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(48, 38);
			this.btnExit.TabIndex = 9;
			this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnResize
			// 
			this.btnResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnResize.FlatAppearance.BorderSize = 0;
			this.btnResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnResize.Image = global::GUI.Properties.Resources.minimize;
			this.btnResize.Location = new System.Drawing.Point(1497, 3);
			this.btnResize.Name = "btnResize";
			this.btnResize.Size = new System.Drawing.Size(46, 38);
			this.btnResize.TabIndex = 8;
			this.btnResize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnResize.UseVisualStyleBackColor = true;
			this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.BackColor = System.Drawing.Color.Green;
			this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
			this.lblTitle.Location = new System.Drawing.Point(0, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(1600, 46);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Quản lý vựa rau";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
			// 
			// bottomPanel
			// 
			this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.bottomPanel.Controls.Add(this.btnLogout);
			this.bottomPanel.Controls.Add(this.lblUser);
			this.bottomPanel.Controls.Add(this.label1);
			this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomPanel.Location = new System.Drawing.Point(300, 668);
			this.bottomPanel.Name = "bottomPanel";
			this.bottomPanel.Size = new System.Drawing.Size(1300, 52);
			this.bottomPanel.TabIndex = 24;
			// 
			// btnLogout
			// 
			this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLogout.BackColor = System.Drawing.Color.Red;
			this.btnLogout.FlatAppearance.BorderSize = 0;
			this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnLogout.ForeColor = System.Drawing.Color.White;
			this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
			this.btnLogout.Location = new System.Drawing.Point(1106, 3);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(191, 47);
			this.btnLogout.TabIndex = 12;
			this.btnLogout.Text = " Đăng xuất";
			this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
			// 
			// lblUser
			// 
			this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblUser.AutoSize = true;
			this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUser.ForeColor = System.Drawing.Color.Lime;
			this.lblUser.Location = new System.Drawing.Point(147, 14);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(64, 29);
			this.lblUser.TabIndex = 1;
			this.lblUser.Text = "user";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Xin chào: ";
			// 
			// leftMenuPanel
			// 
			this.leftMenuPanel.AutoScroll = true;
			this.leftMenuPanel.Controls.Add(this.btnHelp);
			this.leftMenuPanel.Controls.Add(this.btnSystem);
			this.leftMenuPanel.Controls.Add(this.btnReport);
			this.leftMenuPanel.Controls.Add(this.btnCustomer);
			this.leftMenuPanel.Controls.Add(this.btnInfomation);
			this.leftMenuPanel.Controls.Add(this.btnAccount);
			this.leftMenuPanel.Controls.Add(this.btnBill);
			this.leftMenuPanel.Controls.Add(this.btnPrice);
			this.leftMenuPanel.Controls.Add(this.btnProduct);
			this.leftMenuPanel.Controls.Add(this.panel1);
			this.leftMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftMenuPanel.Location = new System.Drawing.Point(0, 46);
			this.leftMenuPanel.Name = "leftMenuPanel";
			this.leftMenuPanel.Size = new System.Drawing.Size(300, 674);
			this.leftMenuPanel.TabIndex = 25;
			// 
			// btnHelp
			// 
			this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnHelp.FlatAppearance.BorderSize = 0;
			this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnHelp.ForeColor = System.Drawing.Color.White;
			this.btnHelp.Image = global::GUI.Properties.Resources.help;
			this.btnHelp.Location = new System.Drawing.Point(0, 702);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(279, 73);
			this.btnHelp.TabIndex = 31;
			this.btnHelp.Text = " Trợ giúp";
			this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnHelp.UseVisualStyleBackColor = true;
			// 
			// btnSystem
			// 
			this.btnSystem.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSystem.FlatAppearance.BorderSize = 0;
			this.btnSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnSystem.ForeColor = System.Drawing.Color.White;
			this.btnSystem.Image = global::GUI.Properties.Resources.system;
			this.btnSystem.Location = new System.Drawing.Point(0, 629);
			this.btnSystem.Name = "btnSystem";
			this.btnSystem.Size = new System.Drawing.Size(279, 73);
			this.btnSystem.TabIndex = 30;
			this.btnSystem.Text = " Hệ thống";
			this.btnSystem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSystem.UseVisualStyleBackColor = true;
			this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
			// 
			// btnReport
			// 
			this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnReport.FlatAppearance.BorderSize = 0;
			this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnReport.ForeColor = System.Drawing.Color.White;
			this.btnReport.Image = global::GUI.Properties.Resources.report;
			this.btnReport.Location = new System.Drawing.Point(0, 556);
			this.btnReport.Name = "btnReport";
			this.btnReport.Size = new System.Drawing.Size(279, 73);
			this.btnReport.TabIndex = 29;
			this.btnReport.Text = " Báo cáo doanh thu";
			this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnReport.UseVisualStyleBackColor = true;
			// 
			// btnCustomer
			// 
			this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnCustomer.FlatAppearance.BorderSize = 0;
			this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnCustomer.ForeColor = System.Drawing.Color.White;
			this.btnCustomer.Image = global::GUI.Properties.Resources.customer;
			this.btnCustomer.Location = new System.Drawing.Point(0, 483);
			this.btnCustomer.Name = "btnCustomer";
			this.btnCustomer.Size = new System.Drawing.Size(279, 73);
			this.btnCustomer.TabIndex = 28;
			this.btnCustomer.Text = " Khách hàng";
			this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCustomer.UseVisualStyleBackColor = true;
			this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
			// 
			// btnInfomation
			// 
			this.btnInfomation.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnInfomation.FlatAppearance.BorderSize = 0;
			this.btnInfomation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInfomation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnInfomation.ForeColor = System.Drawing.Color.White;
			this.btnInfomation.Image = global::GUI.Properties.Resources.user2;
			this.btnInfomation.Location = new System.Drawing.Point(0, 410);
			this.btnInfomation.Name = "btnInfomation";
			this.btnInfomation.Size = new System.Drawing.Size(279, 73);
			this.btnInfomation.TabIndex = 27;
			this.btnInfomation.Text = " Cá nhân";
			this.btnInfomation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnInfomation.UseVisualStyleBackColor = true;
			this.btnInfomation.Click += new System.EventHandler(this.btnInfomation_Click);
			// 
			// btnAccount
			// 
			this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnAccount.FlatAppearance.BorderSize = 0;
			this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnAccount.ForeColor = System.Drawing.Color.White;
			this.btnAccount.Image = global::GUI.Properties.Resources.user;
			this.btnAccount.Location = new System.Drawing.Point(0, 337);
			this.btnAccount.Name = "btnAccount";
			this.btnAccount.Size = new System.Drawing.Size(279, 73);
			this.btnAccount.TabIndex = 26;
			this.btnAccount.Text = "  Tài khoản";
			this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAccount.UseVisualStyleBackColor = true;
			this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
			// 
			// btnBill
			// 
			this.btnBill.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnBill.FlatAppearance.BorderSize = 0;
			this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnBill.ForeColor = System.Drawing.Color.White;
			this.btnBill.Image = global::GUI.Properties.Resources.billIcon;
			this.btnBill.Location = new System.Drawing.Point(0, 264);
			this.btnBill.Name = "btnBill";
			this.btnBill.Size = new System.Drawing.Size(279, 73);
			this.btnBill.TabIndex = 25;
			this.btnBill.Text = "  Hoá đơn";
			this.btnBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBill.UseVisualStyleBackColor = true;
			this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
			// 
			// btnPrice
			// 
			this.btnPrice.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnPrice.FlatAppearance.BorderSize = 0;
			this.btnPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnPrice.ForeColor = System.Drawing.Color.White;
			this.btnPrice.Image = global::GUI.Properties.Resources.priceLogo;
			this.btnPrice.Location = new System.Drawing.Point(0, 191);
			this.btnPrice.Name = "btnPrice";
			this.btnPrice.Size = new System.Drawing.Size(279, 73);
			this.btnPrice.TabIndex = 24;
			this.btnPrice.Text = "  Giá bán";
			this.btnPrice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPrice.UseVisualStyleBackColor = true;
			this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
			// 
			// btnProduct
			// 
			this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnProduct.FlatAppearance.BorderSize = 0;
			this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnProduct.ForeColor = System.Drawing.Color.White;
			this.btnProduct.Image = global::GUI.Properties.Resources.vegetableicon;
			this.btnProduct.Location = new System.Drawing.Point(0, 118);
			this.btnProduct.Name = "btnProduct";
			this.btnProduct.Size = new System.Drawing.Size(279, 73);
			this.btnProduct.TabIndex = 23;
			this.btnProduct.Text = "  Sản phẩm";
			this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnProduct.UseVisualStyleBackColor = true;
			this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnMenu);
			this.panel1.Controls.Add(this.picLogo);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(279, 118);
			this.panel1.TabIndex = 0;
			// 
			// btnMenu
			// 
			this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnMenu.FlatAppearance.BorderSize = 0;
			this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnMenu.ForeColor = System.Drawing.Color.White;
			this.btnMenu.Image = global::GUI.Properties.Resources.menuLogo;
			this.btnMenu.Location = new System.Drawing.Point(224, 0);
			this.btnMenu.Name = "btnMenu";
			this.btnMenu.Size = new System.Drawing.Size(55, 118);
			this.btnMenu.TabIndex = 16;
			this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMenu.UseVisualStyleBackColor = false;
			this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
			// 
			// picLogo
			// 
			this.picLogo.Dock = System.Windows.Forms.DockStyle.Left;
			this.picLogo.Image = global::GUI.Properties.Resources.logo;
			this.picLogo.Location = new System.Drawing.Point(0, 0);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(224, 118);
			this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picLogo.TabIndex = 22;
			this.picLogo.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1600, 720);
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.bottomPanel);
			this.Controls.Add(this.leftMenuPanel);
			this.Controls.Add(this.topPanel);
			this.ForeColor = System.Drawing.SystemColors.Control;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.IsMdiContainer = true;
			this.MinimumSize = new System.Drawing.Size(1600, 720);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản Lý Vựa Rau";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.topPanel.ResumeLayout(false);
			this.bottomPanel.ResumeLayout(false);
			this.bottomPanel.PerformLayout();
			this.leftMenuPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Button btnResize;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Panel topPanel;
		private System.Windows.Forms.Panel bottomPanel;
		private System.Windows.Forms.Panel leftMenuPanel;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button btnMenu;
		private Button btnHide;
		private Label lblUser;
		private Label label1;
		private Button btnLogout;
		private Button btnInfomation;
		private Button btnAccount;
		private Button btnBill;
		private Button btnPrice;
		private Button btnProduct;
		private Panel panel1;
		private PictureBox picLogo;
		private Button btnCustomer;
		private Button btnReport;
		private Button btnSystem;
		private Button btnHelp;
	}
}