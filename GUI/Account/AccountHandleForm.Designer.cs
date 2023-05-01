using System.Drawing;
using System.Windows.Forms;

namespace VegetablesManager.AppForm
{
	partial class AccountHandleForm
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
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.chkAdmin = new System.Windows.Forms.CheckBox();
			this.chkShowPass = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnAccept = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtUsername
			// 
			this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			this.txtUsername.Location = new System.Drawing.Point(204, 10);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(291, 34);
			this.txtUsername.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.chkAdmin);
			this.panel1.Controls.Add(this.chkShowPass);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtPassword);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtUsername);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 49);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(507, 136);
			this.panel1.TabIndex = 12;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(3, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 29);
			this.label3.TabIndex = 23;
			this.label3.Text = "Admin: ";
			// 
			// chkAdmin
			// 
			this.chkAdmin.AutoSize = true;
			this.chkAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
			this.chkAdmin.ForeColor = System.Drawing.Color.White;
			this.chkAdmin.Location = new System.Drawing.Point(204, 94);
			this.chkAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chkAdmin.Name = "chkAdmin";
			this.chkAdmin.Size = new System.Drawing.Size(88, 36);
			this.chkAdmin.TabIndex = 22;
			this.chkAdmin.Text = "Yes";
			this.chkAdmin.UseVisualStyleBackColor = true;
			// 
			// chkShowPass
			// 
			this.chkShowPass.AutoSize = true;
			this.chkShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
			this.chkShowPass.ForeColor = System.Drawing.Color.White;
			this.chkShowPass.Location = new System.Drawing.Point(393, 59);
			this.chkShowPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chkShowPass.Name = "chkShowPass";
			this.chkShowPass.Size = new System.Drawing.Size(99, 36);
			this.chkShowPass.TabIndex = 21;
			this.chkShowPass.Text = "Hiện";
			this.chkShowPass.UseVisualStyleBackColor = true;
			this.chkShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(3, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 29);
			this.label1.TabIndex = 19;
			this.label1.Text = "Mật khẩu:";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			this.txtPassword.Location = new System.Drawing.Point(204, 57);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(183, 34);
			this.txtPassword.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(3, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(178, 29);
			this.label2.TabIndex = 12;
			this.label2.Text = "Tên tài khoản:";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lblTitle);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(507, 49);
			this.panel2.TabIndex = 13;
			// 
			// lblTitle
			// 
			this.lblTitle.BackColor = System.Drawing.Color.Gray;
			this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(0, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(507, 49);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Sửa";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.DimGray;
			this.panel3.Controls.Add(this.btnAccept);
			this.panel3.Controls.Add(this.btnCancel);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 185);
			this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(507, 62);
			this.panel3.TabIndex = 14;
			// 
			// btnAccept
			// 
			this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAccept.BackColor = System.Drawing.Color.LimeGreen;
			this.btnAccept.FlatAppearance.BorderSize = 0;
			this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
			this.btnAccept.ForeColor = System.Drawing.Color.White;
			this.btnAccept.Image = global::GUI.Properties.Resources.save;
			this.btnAccept.Location = new System.Drawing.Point(12, 6);
			this.btnAccept.Name = "btnAccept";
			this.btnAccept.Size = new System.Drawing.Size(135, 45);
			this.btnAccept.TabIndex = 7;
			this.btnAccept.Text = " Lưu";
			this.btnAccept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAccept.UseCompatibleTextRendering = true;
			this.btnAccept.UseVisualStyleBackColor = false;
			this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.BackColor = System.Drawing.Color.Red;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Image = global::GUI.Properties.Resources.exit;
			this.btnCancel.Location = new System.Drawing.Point(358, 6);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(134, 45);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Huỷ";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// AccountHandleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(507, 247);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AccountHandleForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddProductForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Button btnAccept;
		private System.Windows.Forms.Button btnCancel;
		private Panel panel1;
		private Label label2;
		private Panel panel2;
		private Label lblTitle;
		private Panel panel3;
		private TextBox txtPassword;
		private CheckBox chkShowPass;
		private Label label1;
		private Label label3;
		private CheckBox chkAdmin;
	}
}