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
			this.btnOrderList = new System.Windows.Forms.Button();
			this.btnOrder = new System.Windows.Forms.Button();
			this.contentPanel = new System.Windows.Forms.Panel();
			this.menuPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuPanel
			// 
			this.menuPanel.BackColor = System.Drawing.Color.Gray;
			this.menuPanel.Controls.Add(this.btnSellBill);
			this.menuPanel.Controls.Add(this.btnOrderList);
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
			// btnOrderList
			// 
			this.btnOrderList.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOrderList.ForeColor = System.Drawing.Color.Black;
			this.btnOrderList.Image = global::GUI.Properties.Resources.billIcon;
			this.btnOrderList.Location = new System.Drawing.Point(549, 10);
			this.btnOrderList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnOrderList.Name = "btnOrderList";
			this.btnOrderList.Size = new System.Drawing.Size(265, 102);
			this.btnOrderList.TabIndex = 2;
			this.btnOrderList.Text = "Danh sách phiếu nhập";
			this.btnOrderList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnOrderList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnOrderList.UseVisualStyleBackColor = true;
			this.btnOrderList.Click += new System.EventHandler(this.btnOrderList_Click);
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
		private Button btnOrderList;
		private Button btnSellBill;
	}
}
