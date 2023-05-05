using System.Drawing;
using System.Windows.Forms;

namespace GUI.Bill
{
	partial class ReportByMonth
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.label13 = new System.Windows.Forms.Label();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnDetail = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvSell = new System.Windows.Forms.DataGridView();
			this.dgvBuy = new System.Windows.Forms.DataGridView();
			this.sellDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sellTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buyTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSell)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvBuy)).BeginInit();
			this.SuspendLayout();
			// 
			// dtpTo
			// 
			this.dtpTo.CalendarFont = new System.Drawing.Font("Segoe UI", 18F);
			this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 16.2F);
			this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpTo.Location = new System.Drawing.Point(503, 2);
			this.dtpTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(176, 43);
			this.dtpTo.TabIndex = 38;
			this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.White;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.label13.ForeColor = System.Drawing.Color.Black;
			this.label13.Location = new System.Drawing.Point(344, 11);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(153, 32);
			this.label13.TabIndex = 37;
			this.label13.Text = "Đến tháng:";
			// 
			// dtpFrom
			// 
			this.dtpFrom.CalendarFont = new System.Drawing.Font("Segoe UI", 18F);
			this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 16.2F);
			this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFrom.Location = new System.Drawing.Point(143, 2);
			this.dtpFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.Size = new System.Drawing.Size(176, 43);
			this.dtpFrom.TabIndex = 36;
			this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(3, 11);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(134, 32);
			this.label7.TabIndex = 35;
			this.label7.Text = "Từ tháng:";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.btnDetail);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.dtpTo);
			this.panel4.Controls.Add(this.label13);
			this.panel4.Controls.Add(this.dtpFrom);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1154, 52);
			this.panel4.TabIndex = 40;
			// 
			// btnDetail
			// 
			this.btnDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDetail.BackColor = System.Drawing.Color.Green;
			this.btnDetail.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnDetail.FlatAppearance.BorderSize = 0;
			this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnDetail.ForeColor = System.Drawing.Color.White;
			this.btnDetail.Location = new System.Drawing.Point(967, 3);
			this.btnDetail.Name = "btnDetail";
			this.btnDetail.Size = new System.Drawing.Size(184, 43);
			this.btnDetail.TabIndex = 40;
			this.btnDetail.Text = "Xem chi tiết";
			this.btnDetail.UseVisualStyleBackColor = false;
			this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.splitContainer1);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 52);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(1154, 739);
			this.panel5.TabIndex = 41;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.dgvSell);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dgvBuy);
			this.splitContainer1.Panel2.Controls.Add(this.label2);
			this.splitContainer1.Size = new System.Drawing.Size(1154, 739);
			this.splitContainer1.SplitterDistance = 417;
			this.splitContainer1.TabIndex = 37;
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(417, 72);
			this.label1.TabIndex = 36;
			this.label1.Text = "Doanh thu bán hàng";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(733, 72);
			this.label2.TabIndex = 37;
			this.label2.Text = "Tiền nhập hàng";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dgvSell
			// 
			this.dgvSell.AllowUserToAddRows = false;
			this.dgvSell.AllowUserToDeleteRows = false;
			this.dgvSell.AllowUserToResizeColumns = false;
			this.dgvSell.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LimeGreen;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSell.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSell.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSell.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvSell.BackgroundColor = System.Drawing.Color.LightGray;
			this.dgvSell.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvSell.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSell.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSell.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sellDate,
            this.sellTotal});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LimeGreen;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSell.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvSell.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvSell.EnableHeadersVisualStyles = false;
			this.dgvSell.Location = new System.Drawing.Point(0, 72);
			this.dgvSell.MultiSelect = false;
			this.dgvSell.Name = "dgvSell";
			this.dgvSell.ReadOnly = true;
			this.dgvSell.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSell.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvSell.RowHeadersVisible = false;
			this.dgvSell.RowHeadersWidth = 51;
			this.dgvSell.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LimeGreen;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSell.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvSell.RowTemplate.Height = 24;
			this.dgvSell.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSell.Size = new System.Drawing.Size(417, 667);
			this.dgvSell.TabIndex = 37;
			// 
			// dgvBuy
			// 
			this.dgvBuy.AllowUserToAddRows = false;
			this.dgvBuy.AllowUserToDeleteRows = false;
			this.dgvBuy.AllowUserToResizeColumns = false;
			this.dgvBuy.AllowUserToResizeRows = false;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LimeGreen;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvBuy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvBuy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvBuy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvBuy.BackgroundColor = System.Drawing.Color.LightGray;
			this.dgvBuy.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvBuy.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvBuy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buyDate,
            this.buyTotal});
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LimeGreen;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvBuy.DefaultCellStyle = dataGridViewCellStyle8;
			this.dgvBuy.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvBuy.EnableHeadersVisualStyles = false;
			this.dgvBuy.Location = new System.Drawing.Point(0, 72);
			this.dgvBuy.MultiSelect = false;
			this.dgvBuy.Name = "dgvBuy";
			this.dgvBuy.ReadOnly = true;
			this.dgvBuy.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvBuy.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dgvBuy.RowHeadersVisible = false;
			this.dgvBuy.RowHeadersWidth = 51;
			this.dgvBuy.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LimeGreen;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvBuy.RowsDefaultCellStyle = dataGridViewCellStyle10;
			this.dgvBuy.RowTemplate.Height = 24;
			this.dgvBuy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvBuy.Size = new System.Drawing.Size(733, 667);
			this.dgvBuy.TabIndex = 38;
			// 
			// sellDate
			// 
			this.sellDate.DataPropertyName = "date";
			this.sellDate.FillWeight = 53.47594F;
			this.sellDate.HeaderText = "Tháng";
			this.sellDate.MinimumWidth = 6;
			this.sellDate.Name = "sellDate";
			this.sellDate.ReadOnly = true;
			// 
			// sellTotal
			// 
			this.sellTotal.DataPropertyName = "total";
			this.sellTotal.FillWeight = 146.5241F;
			this.sellTotal.HeaderText = "Doanh thu bán";
			this.sellTotal.MinimumWidth = 6;
			this.sellTotal.Name = "sellTotal";
			this.sellTotal.ReadOnly = true;
			// 
			// buyDate
			// 
			this.buyDate.DataPropertyName = "date";
			this.buyDate.FillWeight = 53.47594F;
			this.buyDate.HeaderText = "Tháng";
			this.buyDate.MinimumWidth = 6;
			this.buyDate.Name = "buyDate";
			this.buyDate.ReadOnly = true;
			// 
			// buyTotal
			// 
			this.buyTotal.DataPropertyName = "total";
			this.buyTotal.FillWeight = 146.5241F;
			this.buyTotal.HeaderText = "Tiền nhập hàng";
			this.buyTotal.MinimumWidth = 6;
			this.buyTotal.Name = "buyTotal";
			this.buyTotal.ReadOnly = true;
			// 
			// ReportByMonth
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Margin = new System.Windows.Forms.Padding(12);
			this.Name = "ReportByMonth";
			this.Size = new System.Drawing.Size(1154, 791);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvSell)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvBuy)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Panel panel1;
		private Panel panel3;
		private Button btnChange;
		private NumericUpDown nmrCount;
		private TextBox txtUnit;
		private TextBox txtProductName;
		private Button btnAdd;
		private Label label8;
		private Button btnMakeOrder;
		private Button btnReset;
		private NumericUpDown nmrUnitPrice;
		private Panel changeDetailPanel;
		private Panel panel7;
		private TextBox txtChangeDetailProductUnit;
		private Label label12;
		private TextBox txtChangeDetailProductName;
		private Label label11;
		private NumericUpDown nmrChangeDetailCount;
		private Label label10;
		private NumericUpDown nmrChangeDetailUnitPrice;
		private Label label9;
		private Panel panel2;
		private Button btnDelete;
		private Button btnSave;
		private DateTimePicker dtpTo;
		private Label label13;
		private DateTimePicker dtpFrom;
		private Label label7;
		private Panel panel4;
		private Panel panel5;
		private Button btnDetail;
		private SplitContainer splitContainer1;
		private Label label1;
		private Label label2;
		private DataGridView dgvSell;
		private DataGridViewTextBoxColumn sellDate;
		private DataGridViewTextBoxColumn sellTotal;
		private DataGridView dgvBuy;
		private DataGridViewTextBoxColumn buyDate;
		private DataGridViewTextBoxColumn buyTotal;
	}
}
