using System.Windows.Forms;
using System.Drawing;
namespace VegetablesManager.AppForm
{
	partial class CustomerHandleForm
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
			this.txtPhoneNumber = new System.Windows.Forms.TextBox();
			this.btnAccept = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lblRank = new System.Windows.Forms.Label();
			this.nmrRank = new System.Windows.Forms.NumericUpDown();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmrRank)).BeginInit();
			this.SuspendLayout();
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			this.txtPhoneNumber.Location = new System.Drawing.Point(12, 39);
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.Size = new System.Drawing.Size(312, 34);
			this.txtPhoneNumber.TabIndex = 1;
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
			this.btnCancel.Location = new System.Drawing.Point(190, 10);
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
			this.panel1.Controls.Add(this.nmrRank);
			this.panel1.Controls.Add(this.lblRank);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtAddress);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtName);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtPhoneNumber);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 75);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(339, 269);
			this.panel1.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(12, 141);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 25);
			this.label4.TabIndex = 16;
			this.label4.Text = "Địa chỉ";
			// 
			// txtAddress
			// 
			this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			this.txtAddress.Location = new System.Drawing.Point(12, 169);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(312, 34);
			this.txtAddress.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(12, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(168, 25);
			this.label3.TabIndex = 14;
			this.label3.Text = "Tên khách hàng";
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			this.txtName.Location = new System.Drawing.Point(12, 104);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(312, 34);
			this.txtName.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(12, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(139, 25);
			this.label2.TabIndex = 12;
			this.label2.Text = "Số điện thoại";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lblTitle);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(339, 75);
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
			this.lblTitle.Size = new System.Drawing.Size(339, 75);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Thêm người dùng";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.DimGray;
			this.panel3.Controls.Add(this.btnAccept);
			this.panel3.Controls.Add(this.btnCancel);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 344);
			this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(339, 65);
			this.panel3.TabIndex = 14;
			// 
			// lblRank
			// 
			this.lblRank.AutoSize = true;
			this.lblRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.lblRank.ForeColor = System.Drawing.Color.White;
			this.lblRank.Location = new System.Drawing.Point(12, 226);
			this.lblRank.Name = "lblRank";
			this.lblRank.Size = new System.Drawing.Size(56, 25);
			this.lblRank.TabIndex = 18;
			this.lblRank.Text = "Bậc:";
			// 
			// nmrRank
			// 
			this.nmrRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nmrRank.Location = new System.Drawing.Point(74, 221);
			this.nmrRank.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.nmrRank.Name = "nmrRank";
			this.nmrRank.Size = new System.Drawing.Size(250, 30);
			this.nmrRank.TabIndex = 19;
			this.nmrRank.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// CustomerHandleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(339, 409);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CustomerHandleForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddProductForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nmrRank)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TextBox txtPhoneNumber;
		private System.Windows.Forms.Button btnAccept;
		private System.Windows.Forms.Button btnCancel;
		private Panel panel1;
		private Label label2;
		private Panel panel2;
		private Label lblTitle;
		private Panel panel3;
		private Label label4;
		private TextBox txtAddress;
		private Label label3;
		private TextBox txtName;
		private Label lblRank;
		private NumericUpDown nmrRank;
	}
}