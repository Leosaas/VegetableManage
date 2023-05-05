using System.Drawing;
using System.Windows.Forms;

namespace GUI.Bill
{
	partial class CustomerMainControl
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
			this.menuPanel = new System.Windows.Forms.Panel();
			this.contentPanel = new System.Windows.Forms.Panel();
			this.btnDebtList = new System.Windows.Forms.Button();
			this.btnCustomerList = new System.Windows.Forms.Button();
			this.menuPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuPanel
			// 
			this.menuPanel.BackColor = System.Drawing.Color.Gray;
			this.menuPanel.Controls.Add(this.btnDebtList);
			this.menuPanel.Controls.Add(this.btnCustomerList);
			this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.menuPanel.Location = new System.Drawing.Point(0, 0);
			this.menuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.menuPanel.Name = "menuPanel";
			this.menuPanel.Size = new System.Drawing.Size(1008, 124);
			this.menuPanel.TabIndex = 0;
			// 
			// contentPanel
			// 
			this.contentPanel.AutoScroll = true;
			this.contentPanel.AutoSize = true;
			this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.contentPanel.Location = new System.Drawing.Point(0, 124);
			this.contentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.contentPanel.Name = "contentPanel";
			this.contentPanel.Size = new System.Drawing.Size(1008, 523);
			this.contentPanel.TabIndex = 1;
			// 
			// btnDebtList
			// 
			this.btnDebtList.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDebtList.ForeColor = System.Drawing.Color.Black;
			this.btnDebtList.Image = global::GUI.Properties.Resources.debt;
			this.btnDebtList.Location = new System.Drawing.Point(289, 10);
			this.btnDebtList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDebtList.Name = "btnDebtList";
			this.btnDebtList.Size = new System.Drawing.Size(254, 102);
			this.btnDebtList.TabIndex = 3;
			this.btnDebtList.Text = "Quản lý nợ";
			this.btnDebtList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnDebtList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnDebtList.UseVisualStyleBackColor = true;
			this.btnDebtList.Click += new System.EventHandler(this.btnSellBill_Click);
			// 
			// btnCustomerList
			// 
			this.btnCustomerList.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCustomerList.ForeColor = System.Drawing.Color.Black;
			this.btnCustomerList.Image = global::GUI.Properties.Resources.customer;
			this.btnCustomerList.Location = new System.Drawing.Point(29, 10);
			this.btnCustomerList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCustomerList.Name = "btnCustomerList";
			this.btnCustomerList.Size = new System.Drawing.Size(254, 102);
			this.btnCustomerList.TabIndex = 1;
			this.btnCustomerList.Text = "Danh sách khách hàng";
			this.btnCustomerList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnCustomerList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnCustomerList.UseVisualStyleBackColor = true;
			this.btnCustomerList.Click += new System.EventHandler(this.btnOrder_Click);
			// 
			// CustomerMainControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.contentPanel);
			this.Controls.Add(this.menuPanel);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "CustomerMainControl";
			this.Size = new System.Drawing.Size(1008, 647);
			this.menuPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Panel menuPanel;
		private Button btnCustomerList;
		private Panel contentPanel;
		private Button btnDebtList;
	}
}
