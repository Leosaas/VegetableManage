using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
	partial class BillReportPrint
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.panel2 = new System.Windows.Forms.Panel();
			this.topPanel = new System.Windows.Forms.Panel();
			this.btnHide = new System.Windows.Forms.Button();
			this.btnResize = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.topPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.BackColor = System.Drawing.Color.DimGray;
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.topPanel);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1067, 700);
			this.panel1.TabIndex = 4;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel3.Controls.Add(this.reportViewer1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 50);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1067, 603);
			this.panel3.TabIndex = 5;
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.reportViewer1.DocumentMapCollapsed = true;
			this.reportViewer1.IsDocumentMapWidthFixed = true;
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportDefinition.OrderBillReport.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(1067, 603);
			this.reportViewer1.TabIndex = 0;
			this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
			this.reportViewer1.ReportRefresh += new System.ComponentModel.CancelEventHandler(this.reportViewer1_ReportRefresh);
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 653);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1067, 47);
			this.panel2.TabIndex = 4;
			// 
			// topPanel
			// 
			this.topPanel.Controls.Add(this.btnHide);
			this.topPanel.Controls.Add(this.btnResize);
			this.topPanel.Controls.Add(this.btnExit);
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Location = new System.Drawing.Point(0, 0);
			this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(1067, 50);
			this.topPanel.TabIndex = 10;
			this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
			this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
			// 
			// btnHide
			// 
			this.btnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnHide.FlatAppearance.BorderSize = 0;
			this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHide.Image = global::GUI.Properties.Resources.minus;
			this.btnHide.Location = new System.Drawing.Point(905, 6);
			this.btnHide.Name = "btnHide";
			this.btnHide.Size = new System.Drawing.Size(46, 38);
			this.btnHide.TabIndex = 12;
			this.btnHide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnHide.UseVisualStyleBackColor = true;
			this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
			// 
			// btnResize
			// 
			this.btnResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnResize.FlatAppearance.BorderSize = 0;
			this.btnResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnResize.Image = global::GUI.Properties.Resources.maximize;
			this.btnResize.Location = new System.Drawing.Point(957, 6);
			this.btnResize.Name = "btnResize";
			this.btnResize.Size = new System.Drawing.Size(46, 38);
			this.btnResize.TabIndex = 11;
			this.btnResize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnResize.UseVisualStyleBackColor = true;
			this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
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
			// BillReportPrint
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1067, 700);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "BillReportPrint";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MessageBoxForm";
			this.Load += new System.EventHandler(this.BillReportPrint_Load);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.topPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private Panel topPanel;
		private Button btnHide;
		private Button btnResize;
		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
	}
}