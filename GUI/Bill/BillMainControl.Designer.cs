using System.Drawing;
using System.Windows.Forms;

namespace GUI.Bill
{
	partial class BillMainControl
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
			this.btnSellBill = new System.Windows.Forms.Button();
			this.btnBillList = new System.Windows.Forms.Button();
			this.btnOrder = new System.Windows.Forms.Button();
			this.contentPanel = new System.Windows.Forms.Panel();
			this.menuPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuPanel
			// 
			this.menuPanel.BackColor = System.Drawing.Color.Gray;
			this.menuPanel.Controls.Add(this.btnSellBill);
			this.menuPanel.Controls.Add(this.btnBillList);
			this.menuPanel.Controls.Add(this.btnOrder);
			this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.menuPanel.Location = new System.Drawing.Point(0, 0);
			this.menuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.menuPanel.Name = "menuPanel";
			this.menuPanel.Size = new System.Drawing.Size(1008, 124);
			this.menuPanel.TabIndex = 0;
			// 
			// btnSellBill
			// 
			this.btnSellBill.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSellBill.ForeColor = System.Drawing.Color.Black;
			this.btnSellBill.Image = global::GUI.Properties.Resources.sellBill;
			this.btnSellBill.Location = new System.Drawing.Point(289, 10);
			this.btnSellBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSellBill.Name = "btnSellBill";
			this.btnSellBill.Size = new System.Drawing.Size(254, 102);
			this.btnSellBill.TabIndex = 3;
			this.btnSellBill.Text = "Lập hoá đơn bán hàng";
			this.btnSellBill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSellBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSellBill.UseVisualStyleBackColor = true;
			this.btnSellBill.Click += new System.EventHandler(this.btnSellBill_Click);
			// 
			// btnBillList
			// 
			this.btnBillList.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBillList.ForeColor = System.Drawing.Color.Black;
			this.btnBillList.Image = global::GUI.Properties.Resources.billIcon;
			this.btnBillList.Location = new System.Drawing.Point(549, 10);
			this.btnBillList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBillList.Name = "btnBillList";
			this.btnBillList.Size = new System.Drawing.Size(265, 102);
			this.btnBillList.TabIndex = 2;
			this.btnBillList.Text = "Danh sách hoá đơn";
			this.btnBillList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnBillList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnBillList.UseVisualStyleBackColor = true;
			this.btnBillList.Click += new System.EventHandler(this.btnOrderList_Click);
			// 
			// btnOrder
			// 
			this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOrder.ForeColor = System.Drawing.Color.Black;
			this.btnOrder.Image = global::GUI.Properties.Resources.orderIcon;
			this.btnOrder.Location = new System.Drawing.Point(29, 10);
			this.btnOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnOrder.Name = "btnOrder";
			this.btnOrder.Size = new System.Drawing.Size(254, 102);
			this.btnOrder.TabIndex = 1;
			this.btnOrder.Text = "Lập phiếu nhập hàng";
			this.btnOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnOrder.UseVisualStyleBackColor = true;
			this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
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
			// BillMainControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.contentPanel);
			this.Controls.Add(this.menuPanel);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "BillMainControl";
			this.Size = new System.Drawing.Size(1008, 647);
			this.menuPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Panel menuPanel;
		private Button btnOrder;
		private Panel contentPanel;
		private Button btnBillList;
		private Button btnSellBill;
	}
}
