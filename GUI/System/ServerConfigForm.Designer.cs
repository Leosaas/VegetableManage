using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
	partial class ServerConfigForm
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
			this.lblTitle = new System.Windows.Forms.Label();
			this.btnAccept = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lblTest = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.radWindow = new System.Windows.Forms.RadioButton();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.radAccount = new System.Windows.Forms.RadioButton();
			this.chkShowPass = new System.Windows.Forms.CheckBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnExit = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.BackColor = System.Drawing.Color.DimGray;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(12, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(939, 50);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Cấu hình máy chủ cơ sở dữ liệu";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnAccept
			// 
			this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAccept.FlatAppearance.BorderSize = 0;
			this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnAccept.ForeColor = System.Drawing.Color.White;
			this.btnAccept.Location = new System.Drawing.Point(769, 10);
			this.btnAccept.Name = "btnAccept";
			this.btnAccept.Size = new System.Drawing.Size(286, 59);
			this.btnAccept.TabIndex = 3;
			this.btnAccept.Text = "Xác nhận";
			this.btnAccept.UseVisualStyleBackColor = false;
			this.btnAccept.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.BackColor = System.Drawing.Color.DimGray;
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1067, 508);
			this.panel1.TabIndex = 4;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel3.Controls.Add(this.lblTest);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.radWindow);
			this.panel3.Controls.Add(this.txtUsername);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.radAccount);
			this.panel3.Controls.Add(this.chkShowPass);
			this.panel3.Controls.Add(this.pictureBox1);
			this.panel3.Controls.Add(this.txtPassword);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 50);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1067, 377);
			this.panel3.TabIndex = 5;
			// 
			// lblTest
			// 
			this.lblTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
			this.lblTest.ForeColor = System.Drawing.Color.White;
			this.lblTest.Location = new System.Drawing.Point(617, 70);
			this.lblTest.Name = "lblTest";
			this.lblTest.Size = new System.Drawing.Size(427, 39);
			this.lblTest.TabIndex = 29;
			this.lblTest.Text = "Localhost";
			this.lblTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(377, 122);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(234, 39);
			this.label4.TabIndex = 28;
			this.label4.Text = "Đăng nhập:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// radWindow
			// 
			this.radWindow.AutoSize = true;
			this.radWindow.Checked = true;
			this.radWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radWindow.ForeColor = System.Drawing.Color.White;
			this.radWindow.Location = new System.Drawing.Point(419, 178);
			this.radWindow.Name = "radWindow";
			this.radWindow.Size = new System.Drawing.Size(232, 33);
			this.radWindow.TabIndex = 27;
			this.radWindow.TabStop = true;
			this.radWindow.Text = "Tích hợp window";
			this.radWindow.UseVisualStyleBackColor = true;
			this.radWindow.CheckedChanged += new System.EventHandler(this.radWindow_CheckedChanged);
			// 
			// txtUsername
			// 
			this.txtUsername.Enabled = false;
			this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.txtUsername.Location = new System.Drawing.Point(653, 268);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(391, 38);
			this.txtUsername.TabIndex = 26;
			this.txtUsername.Text = "admin";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(439, 270);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(212, 39);
			this.label3.TabIndex = 25;
			this.label3.Text = "Tên tài khoản:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// radAccount
			// 
			this.radAccount.AutoSize = true;
			this.radAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radAccount.ForeColor = System.Drawing.Color.White;
			this.radAccount.Location = new System.Drawing.Point(419, 217);
			this.radAccount.Name = "radAccount";
			this.radAccount.Size = new System.Drawing.Size(206, 33);
			this.radAccount.TabIndex = 24;
			this.radAccount.Text = "Bằng tài khoản";
			this.radAccount.UseVisualStyleBackColor = true;
			this.radAccount.CheckedChanged += new System.EventHandler(this.radAccount_CheckedChanged);
			// 
			// chkShowPass
			// 
			this.chkShowPass.AutoSize = true;
			this.chkShowPass.Enabled = false;
			this.chkShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
			this.chkShowPass.ForeColor = System.Drawing.Color.White;
			this.chkShowPass.Location = new System.Drawing.Point(951, 311);
			this.chkShowPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chkShowPass.Name = "chkShowPass";
			this.chkShowPass.Size = new System.Drawing.Size(99, 36);
			this.chkShowPass.TabIndex = 22;
			this.chkShowPass.Text = "Hiện";
			this.chkShowPass.UseVisualStyleBackColor = true;
			this.chkShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::GUI.Properties.Resources.server_config;
			this.pictureBox1.Location = new System.Drawing.Point(12, 70);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(334, 281);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// txtPassword
			// 
			this.txtPassword.Enabled = false;
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.txtPassword.Location = new System.Drawing.Point(653, 312);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(287, 38);
			this.txtPassword.TabIndex = 8;
			this.txtPassword.Text = "admin";
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(439, 312);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(181, 39);
			this.label2.TabIndex = 7;
			this.label2.Text = "Mật khẩu:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(377, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(234, 39);
			this.label1.TabIndex = 5;
			this.label1.Text = "Tên máy chủ:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnAccept);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 427);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1067, 81);
			this.panel2.TabIndex = 4;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.btnExit);
			this.panel4.Controls.Add(this.lblTitle);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1067, 50);
			this.panel4.TabIndex = 10;
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.BackColor = System.Drawing.Color.Transparent;
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.FlatAppearance.BorderSize = 0;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnExit.ForeColor = System.Drawing.Color.White;
			this.btnExit.Image = global::GUI.Properties.Resources.exit;
			this.btnExit.Location = new System.Drawing.Point(1020, 10);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(35, 31);
			this.btnExit.TabIndex = 2;
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// ServerConfigForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1067, 508);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ServerConfigForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MessageBoxForm";
			this.Load += new System.EventHandler(this.ServerConfigForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnAccept;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private PictureBox pictureBox1;
		private Panel panel4;
		private CheckBox chkShowPass;
		private TextBox txtUsername;
		private Label label3;
		private RadioButton radAccount;
		private Label label4;
		private RadioButton radWindow;
		private Label lblTest;
	}
}