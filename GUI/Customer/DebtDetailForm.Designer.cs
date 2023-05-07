using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
	partial class DebtDetailForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panelBill = new System.Windows.Forms.Panel();
			this.dgvDetailPay = new System.Windows.Forms.DataGridView();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dgvData = new System.Windows.Forms.DataGridView();
			this.idsellbill = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.action = new System.Windows.Forms.DataGridViewButtonColumn();
			this.rightPanel = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.lblLeft = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblPay = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnMakePayment = new System.Windows.Forms.Button();
			this.nmrMoney = new System.Windows.Forms.NumericUpDown();
			this.radMoneyPay = new System.Windows.Forms.RadioButton();
			this.radBillPay = new System.Windows.Forms.RadioButton();
			this.radAllPay = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.lblCustomer = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.topPanel = new System.Windows.Forms.Panel();
			this.btnHide = new System.Windows.Forms.Button();
			this.btnResize = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pay_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pay_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.information = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panelBill.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDetailPay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
			this.rightPanel.SuspendLayout();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmrMoney)).BeginInit();
			this.panel4.SuspendLayout();
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
			this.panel1.Size = new System.Drawing.Size(1298, 931);
			this.panel1.TabIndex = 4;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel3.Controls.Add(this.panel7);
			this.panel3.Controls.Add(this.panelBill);
			this.panel3.Controls.Add(this.rightPanel);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 50);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1298, 818);
			this.panel3.TabIndex = 5;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.dgvDetailPay);
			this.panel7.Controls.Add(this.label8);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(0, 482);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(999, 336);
			this.panel7.TabIndex = 38;
			// 
			// panelBill
			// 
			this.panelBill.Controls.Add(this.label6);
			this.panelBill.Controls.Add(this.dgvData);
			this.panelBill.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelBill.Location = new System.Drawing.Point(0, 93);
			this.panelBill.Name = "panelBill";
			this.panelBill.Size = new System.Drawing.Size(999, 389);
			this.panelBill.TabIndex = 37;
			// 
			// dgvDetailPay
			// 
			this.dgvDetailPay.AllowUserToAddRows = false;
			this.dgvDetailPay.AllowUserToDeleteRows = false;
			this.dgvDetailPay.AllowUserToResizeColumns = false;
			this.dgvDetailPay.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LimeGreen;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDetailPay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvDetailPay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDetailPay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvDetailPay.BackgroundColor = System.Drawing.Color.LightGray;
			this.dgvDetailPay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDetailPay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvDetailPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDetailPay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.pay_date,
            this.pay_amount,
            this.information});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LimeGreen;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDetailPay.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvDetailPay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvDetailPay.EnableHeadersVisualStyles = false;
			this.dgvDetailPay.Location = new System.Drawing.Point(0, 33);
			this.dgvDetailPay.MultiSelect = false;
			this.dgvDetailPay.Name = "dgvDetailPay";
			this.dgvDetailPay.ReadOnly = true;
			this.dgvDetailPay.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDetailPay.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvDetailPay.RowHeadersVisible = false;
			this.dgvDetailPay.RowHeadersWidth = 51;
			this.dgvDetailPay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LimeGreen;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDetailPay.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvDetailPay.RowTemplate.Height = 24;
			this.dgvDetailPay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDetailPay.Size = new System.Drawing.Size(999, 303);
			this.dgvDetailPay.TabIndex = 35;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Dock = System.Windows.Forms.DockStyle.Top;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(0, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(999, 33);
			this.label8.TabIndex = 40;
			this.label8.Text = "Chi tiết trả nợ";
			this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Dock = System.Windows.Forms.DockStyle.Top;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(0, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(999, 34);
			this.label6.TabIndex = 39;
			this.label6.Text = "Các đơn hàng nợ";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// dgvData
			// 
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.AllowUserToResizeColumns = false;
			this.dgvData.AllowUserToResizeRows = false;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LimeGreen;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvData.BackgroundColor = System.Drawing.Color.LightGray;
			this.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsellbill,
            this.date,
            this.username,
            this.total,
            this.action});
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LimeGreen;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.DefaultCellStyle = dataGridViewCellStyle9;
			this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvData.EnableHeadersVisualStyles = false;
			this.dgvData.Location = new System.Drawing.Point(0, 0);
			this.dgvData.MultiSelect = false;
			this.dgvData.Name = "dgvData";
			this.dgvData.ReadOnly = true;
			this.dgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
			dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.dgvData.RowHeadersVisible = false;
			this.dgvData.RowHeadersWidth = 51;
			this.dgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LimeGreen;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle11;
			this.dgvData.RowTemplate.Height = 24;
			this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvData.Size = new System.Drawing.Size(999, 389);
			this.dgvData.TabIndex = 34;
			this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
			// 
			// idsellbill
			// 
			this.idsellbill.DataPropertyName = "idsellbill";
			this.idsellbill.FillWeight = 37.27943F;
			this.idsellbill.HeaderText = "Mã";
			this.idsellbill.MinimumWidth = 6;
			this.idsellbill.Name = "idsellbill";
			this.idsellbill.ReadOnly = true;
			// 
			// date
			// 
			this.date.DataPropertyName = "date";
			this.date.FillWeight = 147.2048F;
			this.date.HeaderText = "Ngày lập";
			this.date.MinimumWidth = 6;
			this.date.Name = "date";
			this.date.ReadOnly = true;
			// 
			// username
			// 
			this.username.DataPropertyName = "username";
			this.username.FillWeight = 92.00533F;
			this.username.HeaderText = "Người lập";
			this.username.MinimumWidth = 6;
			this.username.Name = "username";
			this.username.ReadOnly = true;
			// 
			// total
			// 
			this.total.DataPropertyName = "total";
			this.total.FillWeight = 129.9276F;
			this.total.HeaderText = "Tổng tiền";
			this.total.MinimumWidth = 6;
			this.total.Name = "total";
			this.total.ReadOnly = true;
			// 
			// action
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.action.DefaultCellStyle = dataGridViewCellStyle8;
			this.action.FillWeight = 93.5829F;
			this.action.HeaderText = "Thao tác";
			this.action.MinimumWidth = 6;
			this.action.Name = "action";
			this.action.ReadOnly = true;
			this.action.Text = "Chi tiết";
			this.action.UseColumnTextForButtonValue = true;
			// 
			// rightPanel
			// 
			this.rightPanel.BackColor = System.Drawing.Color.White;
			this.rightPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rightPanel.Controls.Add(this.panel6);
			this.rightPanel.Controls.Add(this.nmrMoney);
			this.rightPanel.Controls.Add(this.radMoneyPay);
			this.rightPanel.Controls.Add(this.radBillPay);
			this.rightPanel.Controls.Add(this.radAllPay);
			this.rightPanel.Controls.Add(this.label3);
			this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.rightPanel.Location = new System.Drawing.Point(999, 93);
			this.rightPanel.Name = "rightPanel";
			this.rightPanel.Size = new System.Drawing.Size(299, 725);
			this.rightPanel.TabIndex = 36;
			// 
			// panel6
			// 
			this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel6.Controls.Add(this.lblLeft);
			this.panel6.Controls.Add(this.label7);
			this.panel6.Controls.Add(this.lblPay);
			this.panel6.Controls.Add(this.label5);
			this.panel6.Controls.Add(this.lblTotal);
			this.panel6.Controls.Add(this.label4);
			this.panel6.Controls.Add(this.btnMakePayment);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel6.Location = new System.Drawing.Point(0, 556);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(297, 167);
			this.panel6.TabIndex = 27;
			// 
			// lblLeft
			// 
			this.lblLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblLeft.AutoSize = true;
			this.lblLeft.BackColor = System.Drawing.Color.Transparent;
			this.lblLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLeft.ForeColor = System.Drawing.Color.Green;
			this.lblLeft.Location = new System.Drawing.Point(130, 69);
			this.lblLeft.Name = "lblLeft";
			this.lblLeft.Size = new System.Drawing.Size(82, 29);
			this.lblLeft.TabIndex = 29;
			this.lblLeft.Text = "0 VND";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(4, 69);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 29);
			this.label7.TabIndex = 28;
			this.label7.Text = "Còn lại:";
			// 
			// lblPay
			// 
			this.lblPay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPay.AutoSize = true;
			this.lblPay.BackColor = System.Drawing.Color.Transparent;
			this.lblPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPay.ForeColor = System.Drawing.Color.Green;
			this.lblPay.Location = new System.Drawing.Point(130, 40);
			this.lblPay.Name = "lblPay";
			this.lblPay.Size = new System.Drawing.Size(82, 29);
			this.lblPay.TabIndex = 27;
			this.lblPay.Text = "0 VND";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(4, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 29);
			this.label5.TabIndex = 26;
			this.label5.Text = "Đã trả:";
			// 
			// lblTotal
			// 
			this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTotal.AutoSize = true;
			this.lblTotal.BackColor = System.Drawing.Color.Transparent;
			this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.ForeColor = System.Drawing.Color.Green;
			this.lblTotal.Location = new System.Drawing.Point(131, 11);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(82, 29);
			this.lblTotal.TabIndex = 25;
			this.lblTotal.Text = "0 VND";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(4, 11);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(121, 29);
			this.label4.TabIndex = 24;
			this.label4.Text = "Tổng tiền:";
			// 
			// btnMakePayment
			// 
			this.btnMakePayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMakePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnMakePayment.FlatAppearance.BorderSize = 0;
			this.btnMakePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMakePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMakePayment.ForeColor = System.Drawing.Color.White;
			this.btnMakePayment.Location = new System.Drawing.Point(7, 101);
			this.btnMakePayment.Name = "btnMakePayment";
			this.btnMakePayment.Size = new System.Drawing.Size(282, 63);
			this.btnMakePayment.TabIndex = 23;
			this.btnMakePayment.Text = "  Thanh toán";
			this.btnMakePayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMakePayment.UseVisualStyleBackColor = false;
			this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
			// 
			// nmrMoney
			// 
			this.nmrMoney.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nmrMoney.Enabled = false;
			this.nmrMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nmrMoney.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nmrMoney.Location = new System.Drawing.Point(8, 285);
			this.nmrMoney.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.nmrMoney.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nmrMoney.Name = "nmrMoney";
			this.nmrMoney.Size = new System.Drawing.Size(278, 34);
			this.nmrMoney.TabIndex = 26;
			this.nmrMoney.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nmrMoney.ValueChanged += new System.EventHandler(this.nmrMoney_ValueChanged);
			// 
			// radMoneyPay
			// 
			this.radMoneyPay.AutoSize = true;
			this.radMoneyPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radMoneyPay.Location = new System.Drawing.Point(5, 246);
			this.radMoneyPay.Name = "radMoneyPay";
			this.radMoneyPay.Size = new System.Drawing.Size(272, 33);
			this.radMoneyPay.TabIndex = 25;
			this.radMoneyPay.Text = "Thanh toán theo tiền";
			this.radMoneyPay.UseVisualStyleBackColor = true;
			this.radMoneyPay.CheckedChanged += new System.EventHandler(this.radMoneyPay_CheckedChanged);
			// 
			// radBillPay
			// 
			this.radBillPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radBillPay.Location = new System.Drawing.Point(5, 112);
			this.radBillPay.Name = "radBillPay";
			this.radBillPay.Size = new System.Drawing.Size(272, 137);
			this.radBillPay.TabIndex = 24;
			this.radBillPay.Text = "Thanh toán theo đơn (chọn những đơn muốn thanh toán ở bên trái)";
			this.radBillPay.UseVisualStyleBackColor = true;
			this.radBillPay.CheckedChanged += new System.EventHandler(this.radBillPay_CheckedChanged);
			// 
			// radAllPay
			// 
			this.radAllPay.AutoSize = true;
			this.radAllPay.Checked = true;
			this.radAllPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radAllPay.Location = new System.Drawing.Point(5, 73);
			this.radAllPay.Name = "radAllPay";
			this.radAllPay.Size = new System.Drawing.Size(258, 33);
			this.radAllPay.TabIndex = 23;
			this.radAllPay.TabStop = true;
			this.radAllPay.Text = "Thanh toán toàn bộ";
			this.radAllPay.UseVisualStyleBackColor = true;
			this.radAllPay.CheckedChanged += new System.EventHandler(this.radAllPay_CheckedChanged);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(297, 50);
			this.label3.TabIndex = 22;
			this.label3.Text = "Thanh toán";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.DimGray;
			this.panel4.Controls.Add(this.lblCustomer);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.label1);
			this.panel4.Controls.Add(this.txtSearch);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1298, 93);
			this.panel4.TabIndex = 36;
			// 
			// lblCustomer
			// 
			this.lblCustomer.AutoSize = true;
			this.lblCustomer.BackColor = System.Drawing.Color.Transparent;
			this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCustomer.ForeColor = System.Drawing.Color.Lime;
			this.lblCustomer.Location = new System.Drawing.Point(378, 61);
			this.lblCustomer.Name = "lblCustomer";
			this.lblCustomer.Size = new System.Drawing.Size(74, 29);
			this.lblCustomer.TabIndex = 22;
			this.lblCustomer.Text = "Value";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(3, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(304, 29);
			this.label2.TabIndex = 21;
			this.label2.Text = "Chi tiết nợ của khách hàng: ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 29);
			this.label1.TabIndex = 2;
			this.label1.Text = "Tìm hoá đơn:";
			// 
			// txtSearch
			// 
			this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.txtSearch.Location = new System.Drawing.Point(198, 9);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(707, 38);
			this.txtSearch.TabIndex = 1;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 868);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1298, 63);
			this.panel2.TabIndex = 4;
			// 
			// topPanel
			// 
			this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.topPanel.Controls.Add(this.btnHide);
			this.topPanel.Controls.Add(this.btnResize);
			this.topPanel.Controls.Add(this.btnExit);
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Location = new System.Drawing.Point(0, 0);
			this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(1298, 50);
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
			this.btnHide.Location = new System.Drawing.Point(1136, 6);
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
			this.btnResize.Location = new System.Drawing.Point(1188, 6);
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
			this.btnExit.Location = new System.Drawing.Point(1251, 10);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(35, 31);
			this.btnExit.TabIndex = 2;
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// id
			// 
			this.id.DataPropertyName = "id";
			this.id.FillWeight = 15.21306F;
			this.id.HeaderText = "";
			this.id.MinimumWidth = 6;
			this.id.Name = "id";
			this.id.ReadOnly = true;
			// 
			// pay_date
			// 
			this.pay_date.DataPropertyName = "pay_date";
			this.pay_date.FillWeight = 55.08046F;
			this.pay_date.HeaderText = "Ngày trả";
			this.pay_date.MinimumWidth = 6;
			this.pay_date.Name = "pay_date";
			this.pay_date.ReadOnly = true;
			// 
			// pay_amount
			// 
			this.pay_amount.DataPropertyName = "pay";
			this.pay_amount.HeaderText = "Số tiền";
			this.pay_amount.MinimumWidth = 6;
			this.pay_amount.Name = "pay_amount";
			this.pay_amount.ReadOnly = true;
			// 
			// information
			// 
			this.information.DataPropertyName = "information";
			this.information.FillWeight = 214.1907F;
			this.information.HeaderText = "Chi tiết";
			this.information.MinimumWidth = 6;
			this.information.Name = "information";
			this.information.ReadOnly = true;
			// 
			// DebtDetailForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1298, 931);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "DebtDetailForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MessageBoxForm";
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panelBill.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDetailPay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
			this.rightPanel.ResumeLayout(false);
			this.rightPanel.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmrMoney)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
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
		private Panel panel4;
		private TextBox txtSearch;
		private Label label1;
		private DataGridView dgvData;
		private Label lblCustomer;
		private Label label2;
		private Panel panelBill;
		private Panel rightPanel;
		private Panel panel6;
		private Label lblTotal;
		private Label label4;
		private Button btnMakePayment;
		private NumericUpDown nmrMoney;
		private RadioButton radMoneyPay;
		private RadioButton radBillPay;
		private RadioButton radAllPay;
		private Label label3;
		private DataGridViewTextBoxColumn idsellbill;
		private DataGridViewTextBoxColumn date;
		private DataGridViewTextBoxColumn username;
		private DataGridViewTextBoxColumn total;
		private DataGridViewButtonColumn action;
		private Label lblLeft;
		private Label label7;
		private Label lblPay;
		private Label label5;
		private Label label8;
		private Label label6;
		private Panel panel7;
		private DataGridView dgvDetailPay;
		private DataGridViewTextBoxColumn id;
		private DataGridViewTextBoxColumn pay_date;
		private DataGridViewTextBoxColumn pay_amount;
		private DataGridViewTextBoxColumn information;
	}
}