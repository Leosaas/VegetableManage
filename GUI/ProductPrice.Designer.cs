using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
	partial class ProductPrice
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.sellPricePanel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgvSellPrice = new System.Windows.Forms.DataGridView();
			this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.btnPriceUpdate = new System.Windows.Forms.Button();
			this.sellRightPanel = new System.Windows.Forms.Panel();
			this.nmrPrice = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.sellTitlePanel = new System.Windows.Forms.Panel();
			this.btnHideSell = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.buyPanel = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dgvBuyPrice = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.buyTitlePanel = new System.Windows.Forms.Panel();
			this.btnHideBuy = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.leftMenuPanel = new System.Windows.Forms.Panel();
			this.cboCategory = new System.Windows.Forms.ComboBox();
			this.dgvProduct = new System.Windows.Forms.DataGridView();
			this.idproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnFilter = new System.Windows.Forms.Button();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			this.sellPricePanel.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSellPrice)).BeginInit();
			this.sellRightPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmrPrice)).BeginInit();
			this.sellTitlePanel.SuspendLayout();
			this.buyPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBuyPrice)).BeginInit();
			this.buyTitlePanel.SuspendLayout();
			this.leftMenuPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tìm rau củ:";
			// 
			// txtSearch
			// 
			this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.txtSearch.Location = new System.Drawing.Point(16, 29);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(250, 38);
			this.txtSearch.TabIndex = 0;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.sellPricePanel);
			this.mainPanel.Controls.Add(this.sellTitlePanel);
			this.mainPanel.Controls.Add(this.buyPanel);
			this.mainPanel.Controls.Add(this.buyTitlePanel);
			this.mainPanel.Controls.Add(this.leftMenuPanel);
			this.mainPanel.Controls.Add(this.panel3);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1154, 791);
			this.mainPanel.TabIndex = 1;
			// 
			// sellPricePanel
			// 
			this.sellPricePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.sellPricePanel.Controls.Add(this.panel1);
			this.sellPricePanel.Controls.Add(this.sellRightPanel);
			this.sellPricePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sellPricePanel.Location = new System.Drawing.Point(284, 373);
			this.sellPricePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.sellPricePanel.Name = "sellPricePanel";
			this.sellPricePanel.Size = new System.Drawing.Size(870, 418);
			this.sellPricePanel.TabIndex = 35;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dgvSellPrice);
			this.panel1.Controls.Add(this.btnPriceUpdate);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(618, 416);
			this.panel1.TabIndex = 37;
			// 
			// dgvSellPrice
			// 
			this.dgvSellPrice.AllowUserToAddRows = false;
			this.dgvSellPrice.AllowUserToDeleteRows = false;
			this.dgvSellPrice.AllowUserToResizeColumns = false;
			this.dgvSellPrice.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSellPrice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSellPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvSellPrice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSellPrice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvSellPrice.BackgroundColor = System.Drawing.Color.White;
			this.dgvSellPrice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvSellPrice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSellPrice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvSellPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSellPrice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.price,
            this.status});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSellPrice.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvSellPrice.EnableHeadersVisualStyles = false;
			this.dgvSellPrice.Location = new System.Drawing.Point(5, 50);
			this.dgvSellPrice.MultiSelect = false;
			this.dgvSellPrice.Name = "dgvSellPrice";
			this.dgvSellPrice.ReadOnly = true;
			this.dgvSellPrice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSellPrice.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvSellPrice.RowHeadersVisible = false;
			this.dgvSellPrice.RowHeadersWidth = 51;
			this.dgvSellPrice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSellPrice.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvSellPrice.RowTemplate.Height = 24;
			this.dgvSellPrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSellPrice.Size = new System.Drawing.Size(607, 363);
			this.dgvSellPrice.TabIndex = 34;
			// 
			// date
			// 
			this.date.DataPropertyName = "date";
			this.date.HeaderText = "Ngày cập nhật";
			this.date.MinimumWidth = 6;
			this.date.Name = "date";
			this.date.ReadOnly = true;
			// 
			// price
			// 
			this.price.DataPropertyName = "price";
			this.price.HeaderText = "Giá bán ra";
			this.price.MinimumWidth = 6;
			this.price.Name = "price";
			this.price.ReadOnly = true;
			// 
			// status
			// 
			this.status.DataPropertyName = "status";
			this.status.HeaderText = "Trạng thái";
			this.status.MinimumWidth = 6;
			this.status.Name = "status";
			this.status.ReadOnly = true;
			this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// btnPriceUpdate
			// 
			this.btnPriceUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPriceUpdate.BackColor = System.Drawing.Color.Green;
			this.btnPriceUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPriceUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnPriceUpdate.ForeColor = System.Drawing.Color.White;
			this.btnPriceUpdate.Location = new System.Drawing.Point(421, 5);
			this.btnPriceUpdate.Name = "btnPriceUpdate";
			this.btnPriceUpdate.Size = new System.Drawing.Size(191, 39);
			this.btnPriceUpdate.TabIndex = 36;
			this.btnPriceUpdate.Text = "Cập nhật giá bán";
			this.btnPriceUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPriceUpdate.UseVisualStyleBackColor = false;
			this.btnPriceUpdate.Click += new System.EventHandler(this.btnPriceUpdate_Click);
			// 
			// sellRightPanel
			// 
			this.sellRightPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.sellRightPanel.Controls.Add(this.nmrPrice);
			this.sellRightPanel.Controls.Add(this.label4);
			this.sellRightPanel.Controls.Add(this.btnSave);
			this.sellRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.sellRightPanel.Location = new System.Drawing.Point(618, 0);
			this.sellRightPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.sellRightPanel.Name = "sellRightPanel";
			this.sellRightPanel.Size = new System.Drawing.Size(250, 416);
			this.sellRightPanel.TabIndex = 35;
			this.sellRightPanel.Visible = false;
			// 
			// nmrPrice
			// 
			this.nmrPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.nmrPrice.Location = new System.Drawing.Point(12, 54);
			this.nmrPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.nmrPrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.nmrPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nmrPrice.Name = "nmrPrice";
			this.nmrPrice.Size = new System.Drawing.Size(235, 38);
			this.nmrPrice.TabIndex = 39;
			this.nmrPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(12, 11);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(196, 32);
			this.label4.TabIndex = 33;
			this.label4.Text = "Nhập giá mới: ";
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(10, 97);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(233, 45);
			this.btnSave.TabIndex = 37;
			this.btnSave.Text = "Lưu";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// sellTitlePanel
			// 
			this.sellTitlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.sellTitlePanel.Controls.Add(this.btnHideSell);
			this.sellTitlePanel.Controls.Add(this.label3);
			this.sellTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.sellTitlePanel.Location = new System.Drawing.Point(284, 326);
			this.sellTitlePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.sellTitlePanel.Name = "sellTitlePanel";
			this.sellTitlePanel.Size = new System.Drawing.Size(870, 47);
			this.sellTitlePanel.TabIndex = 40;
			// 
			// btnHideSell
			// 
			this.btnHideSell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnHideSell.BackColor = System.Drawing.Color.Red;
			this.btnHideSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHideSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnHideSell.ForeColor = System.Drawing.Color.White;
			this.btnHideSell.Location = new System.Drawing.Point(719, 2);
			this.btnHideSell.Name = "btnHideSell";
			this.btnHideSell.Size = new System.Drawing.Size(147, 39);
			this.btnHideSell.TabIndex = 37;
			this.btnHideSell.Text = "Ẩn";
			this.btnHideSell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnHideSell.UseVisualStyleBackColor = false;
			this.btnHideSell.Click += new System.EventHandler(this.btnHideSell_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(6, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(146, 32);
			this.label3.TabIndex = 34;
			this.label3.Text = "Giá bán ra";
			// 
			// buyPanel
			// 
			this.buyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.buyPanel.Controls.Add(this.panel2);
			this.buyPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.buyPanel.Location = new System.Drawing.Point(284, 122);
			this.buyPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buyPanel.Name = "buyPanel";
			this.buyPanel.Size = new System.Drawing.Size(870, 204);
			this.buyPanel.TabIndex = 34;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dgvBuyPrice);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(868, 202);
			this.panel2.TabIndex = 36;
			// 
			// dgvBuyPrice
			// 
			this.dgvBuyPrice.AllowUserToAddRows = false;
			this.dgvBuyPrice.AllowUserToDeleteRows = false;
			this.dgvBuyPrice.AllowUserToResizeColumns = false;
			this.dgvBuyPrice.AllowUserToResizeRows = false;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvBuyPrice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvBuyPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvBuyPrice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvBuyPrice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvBuyPrice.BackgroundColor = System.Drawing.Color.White;
			this.dgvBuyPrice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvBuyPrice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvBuyPrice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvBuyPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBuyPrice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.buyPrice,
            this.priceStatus});
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvBuyPrice.DefaultCellStyle = dataGridViewCellStyle8;
			this.dgvBuyPrice.EnableHeadersVisualStyles = false;
			this.dgvBuyPrice.Location = new System.Drawing.Point(5, 5);
			this.dgvBuyPrice.MultiSelect = false;
			this.dgvBuyPrice.Name = "dgvBuyPrice";
			this.dgvBuyPrice.ReadOnly = true;
			this.dgvBuyPrice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvBuyPrice.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dgvBuyPrice.RowHeadersVisible = false;
			this.dgvBuyPrice.RowHeadersWidth = 51;
			this.dgvBuyPrice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvBuyPrice.RowsDefaultCellStyle = dataGridViewCellStyle10;
			this.dgvBuyPrice.RowTemplate.Height = 24;
			this.dgvBuyPrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvBuyPrice.Size = new System.Drawing.Size(857, 193);
			this.dgvBuyPrice.TabIndex = 33;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "date";
			this.dataGridViewTextBoxColumn1.HeaderText = "Ngày cập nhật";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// buyPrice
			// 
			this.buyPrice.DataPropertyName = "price";
			this.buyPrice.HeaderText = "Giá mua vào";
			this.buyPrice.MinimumWidth = 6;
			this.buyPrice.Name = "buyPrice";
			this.buyPrice.ReadOnly = true;
			// 
			// priceStatus
			// 
			this.priceStatus.DataPropertyName = "status";
			this.priceStatus.HeaderText = "Trạng thái";
			this.priceStatus.MinimumWidth = 6;
			this.priceStatus.Name = "priceStatus";
			this.priceStatus.ReadOnly = true;
			this.priceStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.priceStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// buyTitlePanel
			// 
			this.buyTitlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.buyTitlePanel.Controls.Add(this.btnHideBuy);
			this.buyTitlePanel.Controls.Add(this.label2);
			this.buyTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.buyTitlePanel.Location = new System.Drawing.Point(284, 81);
			this.buyTitlePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buyTitlePanel.Name = "buyTitlePanel";
			this.buyTitlePanel.Size = new System.Drawing.Size(870, 41);
			this.buyTitlePanel.TabIndex = 39;
			// 
			// btnHideBuy
			// 
			this.btnHideBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnHideBuy.BackColor = System.Drawing.Color.Red;
			this.btnHideBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHideBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnHideBuy.ForeColor = System.Drawing.Color.White;
			this.btnHideBuy.Location = new System.Drawing.Point(719, 2);
			this.btnHideBuy.Name = "btnHideBuy";
			this.btnHideBuy.Size = new System.Drawing.Size(147, 35);
			this.btnHideBuy.TabIndex = 38;
			this.btnHideBuy.Text = "Ẩn";
			this.btnHideBuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnHideBuy.UseVisualStyleBackColor = false;
			this.btnHideBuy.Click += new System.EventHandler(this.btnHideBuy_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(3, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(174, 32);
			this.label2.TabIndex = 33;
			this.label2.Text = "Giá mua vào";
			// 
			// leftMenuPanel
			// 
			this.leftMenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.leftMenuPanel.Controls.Add(this.cboCategory);
			this.leftMenuPanel.Controls.Add(this.label1);
			this.leftMenuPanel.Controls.Add(this.dgvProduct);
			this.leftMenuPanel.Controls.Add(this.txtSearch);
			this.leftMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftMenuPanel.Location = new System.Drawing.Point(0, 81);
			this.leftMenuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.leftMenuPanel.Name = "leftMenuPanel";
			this.leftMenuPanel.Size = new System.Drawing.Size(284, 710);
			this.leftMenuPanel.TabIndex = 32;
			// 
			// cboCategory
			// 
			this.cboCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.cboCategory.FormattingEnabled = true;
			this.cboCategory.Location = new System.Drawing.Point(16, 68);
			this.cboCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cboCategory.Name = "cboCategory";
			this.cboCategory.Size = new System.Drawing.Size(250, 39);
			this.cboCategory.TabIndex = 32;
			this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
			// 
			// dgvProduct
			// 
			this.dgvProduct.AllowUserToAddRows = false;
			this.dgvProduct.AllowUserToDeleteRows = false;
			this.dgvProduct.AllowUserToResizeColumns = false;
			this.dgvProduct.AllowUserToResizeRows = false;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
			this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
			this.dgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproduct,
            this.product_name,
            this.idcategory});
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle13;
			this.dgvProduct.EnableHeadersVisualStyles = false;
			this.dgvProduct.Location = new System.Drawing.Point(16, 105);
			this.dgvProduct.MultiSelect = false;
			this.dgvProduct.Name = "dgvProduct";
			this.dgvProduct.ReadOnly = true;
			this.dgvProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
			dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
			this.dgvProduct.RowHeadersVisible = false;
			this.dgvProduct.RowHeadersWidth = 51;
			this.dgvProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProduct.RowsDefaultCellStyle = dataGridViewCellStyle15;
			this.dgvProduct.RowTemplate.Height = 24;
			this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProduct.Size = new System.Drawing.Size(250, 600);
			this.dgvProduct.TabIndex = 31;
			this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
			// 
			// idproduct
			// 
			this.idproduct.DataPropertyName = "idproduct";
			this.idproduct.HeaderText = "Mã rau củ";
			this.idproduct.MinimumWidth = 6;
			this.idproduct.Name = "idproduct";
			this.idproduct.ReadOnly = true;
			this.idproduct.Visible = false;
			// 
			// product_name
			// 
			this.product_name.DataPropertyName = "product_name";
			this.product_name.HeaderText = "Tên rau củ";
			this.product_name.MinimumWidth = 6;
			this.product_name.Name = "product_name";
			this.product_name.ReadOnly = true;
			// 
			// idcategory
			// 
			this.idcategory.DataPropertyName = "idcategory";
			this.idcategory.HeaderText = "Loại";
			this.idcategory.MinimumWidth = 6;
			this.idcategory.Name = "idcategory";
			this.idcategory.ReadOnly = true;
			this.idcategory.Visible = false;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnRefresh);
			this.panel3.Controls.Add(this.btnFilter);
			this.panel3.Controls.Add(this.dtpTo);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.dtpFrom);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1154, 81);
			this.panel3.TabIndex = 38;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRefresh.BackColor = System.Drawing.Color.Green;
			this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnRefresh.ForeColor = System.Drawing.Color.White;
			this.btnRefresh.Location = new System.Drawing.Point(1004, 38);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(147, 36);
			this.btnRefresh.TabIndex = 37;
			this.btnRefresh.Text = "Làm mới";
			this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnFilter
			// 
			this.btnFilter.BackColor = System.Drawing.Color.Green;
			this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
			this.btnFilter.ForeColor = System.Drawing.Color.White;
			this.btnFilter.Location = new System.Drawing.Point(684, 38);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new System.Drawing.Size(147, 36);
			this.btnFilter.TabIndex = 36;
			this.btnFilter.Text = "Lọc";
			this.btnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFilter.UseVisualStyleBackColor = false;
			this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
			// 
			// dtpTo
			// 
			this.dtpTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpTo.Location = new System.Drawing.Point(148, 38);
			this.dtpTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(530, 38);
			this.dtpTo.TabIndex = 36;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.White;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(4, 42);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(139, 32);
			this.label9.TabIndex = 35;
			this.label9.Text = "đến ngày:";
			// 
			// dtpFrom
			// 
			this.dtpFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFrom.Location = new System.Drawing.Point(148, 2);
			this.dtpFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.Size = new System.Drawing.Size(530, 38);
			this.dtpFrom.TabIndex = 34;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(4, 7);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(124, 32);
			this.label8.TabIndex = 33;
			this.label8.Text = "Từ ngày:";
			// 
			// ProductPrice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.mainPanel);
			this.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
			this.Name = "ProductPrice";
			this.Size = new System.Drawing.Size(1154, 791);
			this.mainPanel.ResumeLayout(false);
			this.sellPricePanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvSellPrice)).EndInit();
			this.sellRightPanel.ResumeLayout(false);
			this.sellRightPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmrPrice)).EndInit();
			this.sellTitlePanel.ResumeLayout(false);
			this.sellTitlePanel.PerformLayout();
			this.buyPanel.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvBuyPrice)).EndInit();
			this.buyTitlePanel.ResumeLayout(false);
			this.buyTitlePanel.PerformLayout();
			this.leftMenuPanel.ResumeLayout(false);
			this.leftMenuPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvProduct;
		private Panel sellPricePanel;
		private Panel buyPanel;
		private Panel leftMenuPanel;
		private ComboBox cboCategory;
		private Label label3;
		private DataGridView dgvSellPrice;
		private Label label2;
		private DataGridView dgvBuyPrice;
		private Panel sellRightPanel;
		private Button btnPriceUpdate;
		private NumericUpDown nmrPrice;
		private Label label4;
		private Button btnSave;
		private Panel panel1;
		private Panel panel2;
		private Panel panel3;
		private DateTimePicker dtpTo;
		private Label label9;
		private DateTimePicker dtpFrom;
		private Label label8;
		private Panel sellTitlePanel;
		private Button btnHideSell;
		private Panel buyTitlePanel;
		private Button btnHideBuy;
		private Button btnFilter;
		private Button btnRefresh;
		private DataGridViewTextBoxColumn date;
		private DataGridViewTextBoxColumn price;
		private DataGridViewCheckBoxColumn status;
		private DataGridViewTextBoxColumn idproduct;
		private DataGridViewTextBoxColumn product_name;
		private DataGridViewTextBoxColumn idcategory;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn buyPrice;
		private DataGridViewCheckBoxColumn priceStatus;
	}
}
