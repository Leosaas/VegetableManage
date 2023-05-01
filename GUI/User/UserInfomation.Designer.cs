using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
	partial class UserInfomation
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnPassUpdate = new System.Windows.Forms.Button();
			this.btnInfoUpdate = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblUsername = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblPhoneNumber = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnPassUpdate);
			this.panel1.Controls.Add(this.btnInfoUpdate);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(898, 116);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(256, 675);
			this.panel1.TabIndex = 0;
			// 
			// btnPassUpdate
			// 
			this.btnPassUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPassUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnPassUpdate.FlatAppearance.BorderSize = 0;
			this.btnPassUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPassUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnPassUpdate.ForeColor = System.Drawing.Color.White;
			this.btnPassUpdate.Image = global::GUI.Properties.Resources.user;
			this.btnPassUpdate.Location = new System.Drawing.Point(3, 83);
			this.btnPassUpdate.Name = "btnPassUpdate";
			this.btnPassUpdate.Size = new System.Drawing.Size(248, 74);
			this.btnPassUpdate.TabIndex = 14;
			this.btnPassUpdate.Text = " Đổi mật khẩu";
			this.btnPassUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPassUpdate.UseVisualStyleBackColor = false;
			this.btnPassUpdate.Click += new System.EventHandler(this.btnPassUpdate_Click);
			// 
			// btnInfoUpdate
			// 
			this.btnInfoUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnInfoUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnInfoUpdate.FlatAppearance.BorderSize = 0;
			this.btnInfoUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInfoUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnInfoUpdate.ForeColor = System.Drawing.Color.White;
			this.btnInfoUpdate.Image = global::GUI.Properties.Resources.user2;
			this.btnInfoUpdate.Location = new System.Drawing.Point(3, 3);
			this.btnInfoUpdate.Name = "btnInfoUpdate";
			this.btnInfoUpdate.Size = new System.Drawing.Size(248, 74);
			this.btnInfoUpdate.TabIndex = 13;
			this.btnInfoUpdate.Text = " Cập nhật thông tin";
			this.btnInfoUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnInfoUpdate.UseVisualStyleBackColor = false;
			this.btnInfoUpdate.Click += new System.EventHandler(this.btnInfoUpdate_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(16, 134);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(234, 39);
			this.label1.TabIndex = 6;
			this.label1.Text = "Tên đăng nhập:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(16, 173);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(234, 39);
			this.label2.TabIndex = 7;
			this.label2.Text = "Tên hiển thị:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(16, 212);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(234, 39);
			this.label3.TabIndex = 8;
			this.label3.Text = "Số điện thoại:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(16, 251);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(234, 39);
			this.label4.TabIndex = 9;
			this.label4.Text = "Địa chỉ: ";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblUsername
			// 
			this.lblUsername.BackColor = System.Drawing.Color.Transparent;
			this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsername.ForeColor = System.Drawing.Color.Black;
			this.lblUsername.Location = new System.Drawing.Point(276, 134);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(234, 39);
			this.lblUsername.TabIndex = 10;
			this.lblUsername.Text = "Value";
			this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblName
			// 
			this.lblName.BackColor = System.Drawing.Color.Transparent;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.ForeColor = System.Drawing.Color.Black;
			this.lblName.Location = new System.Drawing.Point(276, 173);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(234, 39);
			this.lblName.TabIndex = 11;
			this.lblName.Text = "Value";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPhoneNumber
			// 
			this.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
			this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPhoneNumber.ForeColor = System.Drawing.Color.Black;
			this.lblPhoneNumber.Location = new System.Drawing.Point(276, 212);
			this.lblPhoneNumber.Name = "lblPhoneNumber";
			this.lblPhoneNumber.Size = new System.Drawing.Size(234, 39);
			this.lblPhoneNumber.TabIndex = 12;
			this.lblPhoneNumber.Text = "Value";
			this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblAddress
			// 
			this.lblAddress.BackColor = System.Drawing.Color.Transparent;
			this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAddress.ForeColor = System.Drawing.Color.Black;
			this.lblAddress.Location = new System.Drawing.Point(276, 251);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(234, 39);
			this.lblAddress.TabIndex = 13;
			this.lblAddress.Text = "Value";
			this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Dock = System.Windows.Forms.DockStyle.Top;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(1154, 116);
			this.label5.TabIndex = 14;
			this.label5.Text = "Thông tin cá nhân";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// UserInfomation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.lblAddress);
			this.Controls.Add(this.lblPhoneNumber);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label5);
			this.Margin = new System.Windows.Forms.Padding(12);
			this.Name = "UserInfomation";
			this.Size = new System.Drawing.Size(1154, 791);
			this.Load += new System.EventHandler(this.UserInfomation_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label lblUsername;
		private Label lblName;
		private Label lblPhoneNumber;
		private Label lblAddress;
		private Button btnPassUpdate;
		private Button btnInfoUpdate;
		private Label label5;
	}
}
