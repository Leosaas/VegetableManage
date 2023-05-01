using System.Drawing;
using System.Windows.Forms;

namespace GUI.Bill
{
	partial class BillList
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
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvBill = new System.Windows.Forms.DataGridView();
			this.panel4 = new System.Windows.Forms.Panel();
			this.cboType = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnDetail = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// dtpTo
			// 
			this.dtpTo.CalendarFont = new System.Drawing.Font("Segoe UI", 18F);
			this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 16.2F);
			this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpTo.Location = new System.Drawing.Point(492, 54);
			this.dtpTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(176, 43);
			this.dtpTo.TabIndex = 38;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.White;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.label13.ForeColor = System.Drawing.Color.Black;
			this.label13.Location = new System.Drawing.Point(343, 63);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(143, 32);
			this.label13.TabIndex = 37;
			this.label13.Text = "Đến ngày:";
			// 
			// dtpFrom
			// 
			this.dtpFrom.CalendarFont = new System.Drawing.Font("Segoe UI", 18F);
			this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 16.2F);
			this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFrom.Location = new System.Drawing.Point(159, 52);
			this.dtpFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.Size = new System.Drawing.Size(176, 43);
			this.dtpFrom.TabIndex = 36;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(3, 63);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(124, 32);
			this.label7.TabIndex = 35;
			this.label7.Text = "Từ ngày:";
			// 
			// txtSearch
			// 
			this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.txtSearch.Location = new System.Drawing.Point(159, 9);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(509, 38);
			this.txtSearch.TabIndex = 0;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(3, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(147, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tìm phiếu:";
			// 
			// dgvBill
			// 
			this.dgvBill.AllowUserToAddRows = false;
			this.dgvBill.AllowUserToDeleteRows = false;
			this.dgvBill.AllowUserToResizeColumns = false;
			this.dgvBill.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvBill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvBill.BackgroundColor = System.Drawing.Color.White;
			this.dgvBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvBill.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvBill.EnableHeadersVisualStyles = false;
			this.dgvBill.Location = new System.Drawing.Point(0, 0);
			this.dgvBill.MultiSelect = false;
			this.dgvBill.Name = "dgvBill";
			this.dgvBill.ReadOnly = true;
			this.dgvBill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvBill.RowHeadersVisible = false;
			this.dgvBill.RowHeadersWidth = 51;
			this.dgvBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvBill.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvBill.RowTemplate.Height = 24;
			this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvBill.Size = new System.Drawing.Size(1154, 688);
			this.dgvBill.TabIndex = 34;
			this.dgvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellClick);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.cboType);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.btnDetail);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label1);
			this.panel4.Controls.Add(this.dtpTo);
			this.panel4.Controls.Add(this.label13);
			this.panel4.Controls.Add(this.txtSearch);
			this.panel4.Controls.Add(this.dtpFrom);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1154, 103);
			this.panel4.TabIndex = 40;
			// 
			// cboType
			// 
			this.cboType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboType.FormattingEnabled = true;
			this.cboType.Items.AddRange(new object[] {
            "Hoá đơn bán hàng",
            "Phiếu nhập hàng"});
			this.cboType.Location = new System.Drawing.Point(757, 57);
			this.cboType.Name = "cboType";
			this.cboType.Size = new System.Drawing.Size(202, 39);
			this.cboType.TabIndex = 42;
			this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(674, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 32);
			this.label2.TabIndex = 41;
			this.label2.Text = "Loại:";
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
			this.btnDetail.Location = new System.Drawing.Point(967, 54);
			this.btnDetail.Name = "btnDetail";
			this.btnDetail.Size = new System.Drawing.Size(184, 43);
			this.btnDetail.TabIndex = 40;
			this.btnDetail.Text = "Xem chi tiết";
			this.btnDetail.UseVisualStyleBackColor = false;
			this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.dgvBill);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 103);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(1154, 688);
			this.panel5.TabIndex = 41;
			// 
			// BillList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Margin = new System.Windows.Forms.Padding(12);
			this.Name = "BillList";
			this.Size = new System.Drawing.Size(1154, 791);
			((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private Panel panel1;
		private Panel panel3;
		private Button btnChange;
		private NumericUpDown nmrCount;
		private TextBox txtUnit;
		private TextBox txtProductName;
		private Label label1;
		private TextBox txtSearch;
		private Button btnAdd;
		private Label label8;
		private Button btnMakeOrder;
		private Button btnReset;
		private NumericUpDown nmrUnitPrice;
		private DataGridView dgvBill;
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
		private ComboBox cboType;
		private Label label2;
	}
}
