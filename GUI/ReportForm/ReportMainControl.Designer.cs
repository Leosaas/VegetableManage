using System.Drawing;
using System.Windows.Forms;

namespace GUI.Bill
{
	partial class ReportMainControl
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
			this.btnReportByProduct = new System.Windows.Forms.Button();
			this.btnReportByMonth = new System.Windows.Forms.Button();
			this.contentPanel = new System.Windows.Forms.Panel();
			this.menuPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuPanel
			// 
			this.menuPanel.BackColor = System.Drawing.Color.Gray;
			this.menuPanel.Controls.Add(this.btnReportByProduct);
			this.menuPanel.Controls.Add(this.btnReportByMonth);
			this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.menuPanel.Location = new System.Drawing.Point(0, 0);
			this.menuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.menuPanel.Name = "menuPanel";
			this.menuPanel.Size = new System.Drawing.Size(1008, 124);
			this.menuPanel.TabIndex = 0;
			// 
			// btnReportByProduct
			// 
			this.btnReportByProduct.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReportByProduct.ForeColor = System.Drawing.Color.Black;
			this.btnReportByProduct.Image = global::GUI.Properties.Resources.sellBill;
			this.btnReportByProduct.Location = new System.Drawing.Point(289, 10);
			this.btnReportByProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnReportByProduct.Name = "btnReportByProduct";
			this.btnReportByProduct.Size = new System.Drawing.Size(254, 102);
			this.btnReportByProduct.TabIndex = 3;
			this.btnReportByProduct.Text = "Thống kê doanh thu theo sản phẩm";
			this.btnReportByProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnReportByProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnReportByProduct.UseVisualStyleBackColor = true;
			this.btnReportByProduct.Click += new System.EventHandler(this.btnSellBill_Click);
			// 
			// btnReportByMonth
			// 
			this.btnReportByMonth.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReportByMonth.ForeColor = System.Drawing.Color.Black;
			this.btnReportByMonth.Image = global::GUI.Properties.Resources.orderIcon;
			this.btnReportByMonth.Location = new System.Drawing.Point(29, 10);
			this.btnReportByMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnReportByMonth.Name = "btnReportByMonth";
			this.btnReportByMonth.Size = new System.Drawing.Size(254, 102);
			this.btnReportByMonth.TabIndex = 1;
			this.btnReportByMonth.Text = "Thống kê doanh thu theo tháng";
			this.btnReportByMonth.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnReportByMonth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnReportByMonth.UseVisualStyleBackColor = true;
			this.btnReportByMonth.Click += new System.EventHandler(this.btnOrder_Click);
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
			// ReportMainControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.contentPanel);
			this.Controls.Add(this.menuPanel);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "ReportMainControl";
			this.Size = new System.Drawing.Size(1008, 647);
			this.menuPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Panel menuPanel;
		private Button btnReportByMonth;
		private Panel contentPanel;
		private Button btnReportByProduct;
	}
}
