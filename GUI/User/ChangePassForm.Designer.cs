using System.Windows.Forms;
using System.Drawing;
namespace VegetablesManager.AppForm
{
	partial class ChangePassForm
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
			this.txtOldPass = new System.Windows.Forms.TextBox();
			this.btnAccept = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.txtRepeat = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNewPass = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.chkShowpass = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtOldPass
			// 
			this.txtOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			this.txtOldPass.Location = new System.Drawing.Point(12, 39);
			this.txtOldPass.Name = "txtOldPass";
			this.txtOldPass.Size = new System.Drawing.Size(312, 34);
			this.txtOldPass.TabIndex = 1;
			this.txtOldPass.UseSystemPasswordChar = true;
			// 
			// btnAccept
			// 
			this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAccept.BackColor = System.Drawing.Color.LimeGreen;
			this.btnAccept.FlatAppearance.BorderSize = 0;
			this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
			this.btnAccept.ForeColor = System.Drawing.Color.White;
			this.btnAccept.Location = new System.Drawing.Point(12, 10);
			this.btnAccept.Name = "btnAccept";
			this.btnAccept.Size = new System.Drawing.Size(135, 45);
			this.btnAccept.TabIndex = 7;
			this.btnAccept.Text = "Lưu";
			this.btnAccept.UseVisualStyleBackColor = false;
			this.btnAccept.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.BackColor = System.Drawing.Color.Red;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Location = new System.Drawing.Point(194, 10);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(134, 45);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Huỷ";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.chkShowpass);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtRepeat);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtNewPass);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtOldPass);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 75);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(343, 247);
			this.panel1.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(12, 141);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(198, 25);
			this.label4.TabIndex = 16;
			this.label4.Text = "Xác nhận mật khẩu";
			// 
			// txtRepeat
			// 
			this.txtRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			this.txtRepeat.Location = new System.Drawing.Point(12, 169);
			this.txtRepeat.Name = "txtRepeat";
			this.txtRepeat.Size = new System.Drawing.Size(312, 34);
			this.txtRepeat.TabIndex = 15;
			this.txtRepeat.UseSystemPasswordChar = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(12, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(141, 25);
			this.label3.TabIndex = 14;
			this.label3.Text = "Mật khẩu mới";
			// 
			// txtNewPass
			// 
			this.txtNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			this.txtNewPass.Location = new System.Drawing.Point(12, 104);
			this.txtNewPass.Name = "txtNewPass";
			this.txtNewPass.Size = new System.Drawing.Size(312, 34);
			this.txtNewPass.TabIndex = 13;
			this.txtNewPass.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(12, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 25);
			this.label2.TabIndex = 12;
			this.label2.Text = "Mật khẩu cũ";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lblTitle);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(343, 75);
			this.panel2.TabIndex = 13;
			// 
			// lblTitle
			// 
			this.lblTitle.BackColor = System.Drawing.Color.Gray;
			this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(0, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(343, 75);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Đổi mật khẩu";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.DimGray;
			this.panel3.Controls.Add(this.btnAccept);
			this.panel3.Controls.Add(this.btnCancel);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 322);
			this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(343, 65);
			this.panel3.TabIndex = 14;
			// 
			// chkShowpass
			// 
			this.chkShowpass.AutoSize = true;
			this.chkShowpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkShowpass.ForeColor = System.Drawing.Color.White;
			this.chkShowpass.Location = new System.Drawing.Point(137, 209);
			this.chkShowpass.Name = "chkShowpass";
			this.chkShowpass.Size = new System.Drawing.Size(187, 33);
			this.chkShowpass.TabIndex = 17;
			this.chkShowpass.Text = "Hiện mật khẩu";
			this.chkShowpass.UseVisualStyleBackColor = true;
			this.chkShowpass.CheckedChanged += new System.EventHandler(this.chkShowpass_CheckedChanged);
			// 
			// ChangePassForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(343, 387);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ChangePassForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddProductForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TextBox txtOldPass;
		private System.Windows.Forms.Button btnAccept;
		private System.Windows.Forms.Button btnCancel;
		private Panel panel1;
		private Label label2;
		private Panel panel2;
		private Label lblTitle;
		private Panel panel3;
		private Label label4;
		private TextBox txtRepeat;
		private Label label3;
		private TextBox txtNewPass;
		private CheckBox chkShowpass;
	}
}