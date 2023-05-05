using System.Drawing;
using System.Windows.Forms;

namespace GUI.Bill
{
	partial class ReportByProduct
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
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.label13 = new System.Windows.Forms.Label();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnExport = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.dgvData = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buy = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sell = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
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
			this.panel4.Controls.Add(this.btnExport);
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
			// btnExport
			// 
			this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExport.BackColor = System.Drawing.Color.Green;
			this.btnExport.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnExport.FlatAppearance.BorderSize = 0;
			this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnExport.ForeColor = System.Drawing.Color.White;
			this.btnExport.Location = new System.Drawing.Point(967, 3);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(184, 43);
			this.btnExport.TabIndex = 40;
			this.btnExport.Text = "Xuất báo cáo";
			this.btnExport.UseVisualStyleBackColor = false;
			this.btnExport.Click += new System.EventHandler(this.btnDetail_Click);
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.dgvData);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 52);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(1154, 739);
			this.panel5.TabIndex = 41;
			// 
			// dgvData
			// 
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.AllowUserToResizeColumns = false;
			this.dgvData.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LimeGreen;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvData.BackgroundColor = System.Drawing.Color.LightGray;
			this.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.product_name,
            this.buy,
            this.sell});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LimeGreen;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvData.EnableHeadersVisualStyles = false;
			this.dgvData.Location = new System.Drawing.Point(0, 0);
			this.dgvData.MultiSelect = false;
			this.dgvData.Name = "dgvData";
			this.dgvData.ReadOnly = true;
			this.dgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvData.RowHeadersVisible = false;
			this.dgvData.RowHeadersWidth = 51;
			this.dgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LimeGreen;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvData.RowTemplate.Height = 24;
			this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvData.Size = new System.Drawing.Size(1154, 739);
			this.dgvData.TabIndex = 34;
			// 
			// id
			// 
			this.id.DataPropertyName = "idproduct";
			this.id.FillWeight = 32.08555F;
			this.id.HeaderText = "Mã rau củ";
			this.id.MinimumWidth = 6;
			this.id.Name = "id";
			this.id.ReadOnly = true;
			// 
			// product_name
			// 
			this.product_name.DataPropertyName = "product_name";
			this.product_name.FillWeight = 177.6394F;
			this.product_name.HeaderText = "Tên sản phẩm";
			this.product_name.MinimumWidth = 6;
			this.product_name.Name = "product_name";
			this.product_name.ReadOnly = true;
			// 
			// buy
			// 
			this.buy.DataPropertyName = "buy";
			this.buy.FillWeight = 83.76353F;
			this.buy.HeaderText = "Mua vào";
			this.buy.MinimumWidth = 6;
			this.buy.Name = "buy";
			this.buy.ReadOnly = true;
			// 
			// sell
			// 
			this.sell.DataPropertyName = "sell";
			this.sell.FillWeight = 106.5115F;
			this.sell.HeaderText = "Bán ra";
			this.sell.MinimumWidth = 6;
			this.sell.Name = "sell";
			this.sell.ReadOnly = true;
			// 
			// ReportByProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Margin = new System.Windows.Forms.Padding(12);
			this.Name = "ReportByProduct";
			this.Size = new System.Drawing.Size(1154, 791);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
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
		private Button btnExport;
		private DataGridView dgvData;
		private DataGridViewTextBoxColumn id;
		private DataGridViewTextBoxColumn product_name;
		private DataGridViewTextBoxColumn buy;
		private DataGridViewTextBoxColumn sell;
	}
}
