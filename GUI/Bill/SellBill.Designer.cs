using System.Drawing;
using System.Windows.Forms;

namespace GUI.Bill
{
	partial class SellBill
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
			this.leftMenuPanel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtStorageQuantity = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtUnitPrice = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnAdd = new System.Windows.Forms.Button();
			this.nmrCount = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.txtUnit = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cboCategory = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.dgvProduct = new System.Windows.Forms.DataGridView();
			this.idproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unit_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.product_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.storage_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnChange = new System.Windows.Forms.Button();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.lblCustomer = new System.Windows.Forms.Label();
			this.btnCustomer = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderDetailIdproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderDetailProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderDetailUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel5 = new System.Windows.Forms.Panel();
			this.lblFinishMoney = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.lblDiscount = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btnMakeOrder = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.changeDetailPanel = new System.Windows.Forms.Panel();
			this.txtChangeDetailUnitPrice = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtChangeDetailProductUnit = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtChangeDetailProductName = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.nmrChangeDetailCount = new System.Windows.Forms.NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.chkToDebt = new System.Windows.Forms.CheckBox();
			this.leftMenuPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmrCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
			this.panel5.SuspendLayout();
			this.changeDetailPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmrChangeDetailCount)).BeginInit();
			this.panel7.SuspendLayout();
			this.SuspendLayout();
			// 
			// leftMenuPanel
			// 
			this.leftMenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.leftMenuPanel.Controls.Add(this.panel1);
			this.leftMenuPanel.Controls.Add(this.cboCategory);
			this.leftMenuPanel.Controls.Add(this.label1);
			this.leftMenuPanel.Controls.Add(this.txtSearch);
			this.leftMenuPanel.Controls.Add(this.dgvProduct);
			this.leftMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftMenuPanel.Location = new System.Drawing.Point(0, 0);
			this.leftMenuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.leftMenuPanel.Name = "leftMenuPanel";
			this.leftMenuPanel.Size = new System.Drawing.Size(381, 791);
			this.leftMenuPanel.TabIndex = 32;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.txtStorageQuantity);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.txtUnitPrice);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.nmrCount);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtUnit);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtProductName);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 512);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(379, 277);
			this.panel1.TabIndex = 33;
			// 
			// txtStorageQuantity
			// 
			this.txtStorageQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtStorageQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtStorageQuantity.Enabled = false;
			this.txtStorageQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.txtStorageQuantity.Location = new System.Drawing.Point(175, 138);
			this.txtStorageQuantity.Name = "txtStorageQuantity";
			this.txtStorageQuantity.Size = new System.Drawing.Size(198, 38);
			this.txtStorageQuantity.TabIndex = 43;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.White;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Black;
			this.label13.Location = new System.Drawing.Point(15, 147);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(154, 29);
			this.label13.TabIndex = 42;
			this.label13.Text = "Số lượng tồn:";
			// 
			// txtUnitPrice
			// 
			this.txtUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUnitPrice.Enabled = false;
			this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.txtUnitPrice.Location = new System.Drawing.Point(156, 94);
			this.txtUnitPrice.Name = "txtUnitPrice";
			this.txtUnitPrice.Size = new System.Drawing.Size(217, 38);
			this.txtUnitPrice.TabIndex = 41;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(15, 103);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(126, 29);
			this.label8.TabIndex = 40;
			this.label8.Text = "Giá đơn vị:";
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.btnAdd);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 222);
			this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(377, 53);
			this.panel3.TabIndex = 39;
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.Green;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Location = new System.Drawing.Point(14, 3);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(358, 45);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "Thêm vào phiếu";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// nmrCount
			// 
			this.nmrCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nmrCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			this.nmrCount.Location = new System.Drawing.Point(158, 184);
			this.nmrCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.nmrCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.nmrCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nmrCount.Name = "nmrCount";
			this.nmrCount.Size = new System.Drawing.Size(217, 34);
			this.nmrCount.TabIndex = 38;
			this.nmrCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(15, 186);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 29);
			this.label4.TabIndex = 37;
			this.label4.Text = "Số lượng:";
			// 
			// txtUnit
			// 
			this.txtUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUnit.Enabled = false;
			this.txtUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.txtUnit.Location = new System.Drawing.Point(156, 50);
			this.txtUnit.Name = "txtUnit";
			this.txtUnit.Size = new System.Drawing.Size(219, 38);
			this.txtUnit.TabIndex = 36;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(15, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 29);
			this.label3.TabIndex = 35;
			this.label3.Text = "Đơn vị tính:";
			// 
			// txtProductName
			// 
			this.txtProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtProductName.Enabled = false;
			this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.txtProductName.Location = new System.Drawing.Point(156, 8);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(218, 38);
			this.txtProductName.TabIndex = 34;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(15, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 29);
			this.label2.TabIndex = 34;
			this.label2.Text = "Rau củ:";
			// 
			// cboCategory
			// 
			this.cboCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.cboCategory.FormattingEnabled = true;
			this.cboCategory.Location = new System.Drawing.Point(16, 72);
			this.cboCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cboCategory.Name = "cboCategory";
			this.cboCategory.Size = new System.Drawing.Size(358, 39);
			this.cboCategory.TabIndex = 32;
			this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
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
			this.txtSearch.Size = new System.Drawing.Size(358, 38);
			this.txtSearch.TabIndex = 0;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// dgvProduct
			// 
			this.dgvProduct.AllowUserToAddRows = false;
			this.dgvProduct.AllowUserToDeleteRows = false;
			this.dgvProduct.AllowUserToResizeColumns = false;
			this.dgvProduct.AllowUserToResizeRows = false;
			dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			dataGridViewCellStyle51.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle51.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle51.SelectionBackColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle51.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle51.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle51;
			this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
			this.dgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle52.BackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle52.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle52.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle52.SelectionBackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle52.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle52.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle52;
			this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproduct,
            this.product_name,
            this.unit_name,
            this.product_price,
            this.storage_quantity});
			dataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle53.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle53.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			dataGridViewCellStyle53.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle53.SelectionBackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle53.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle53.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle53;
			this.dgvProduct.EnableHeadersVisualStyles = false;
			this.dgvProduct.Location = new System.Drawing.Point(16, 116);
			this.dgvProduct.MultiSelect = false;
			this.dgvProduct.Name = "dgvProduct";
			this.dgvProduct.ReadOnly = true;
			this.dgvProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle54.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle54.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
			dataGridViewCellStyle54.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle54.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle54.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle54;
			this.dgvProduct.RowHeadersVisible = false;
			this.dgvProduct.RowHeadersWidth = 51;
			this.dgvProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle55.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle55.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle55.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle55.SelectionBackColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle55.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle55.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProduct.RowsDefaultCellStyle = dataGridViewCellStyle55;
			this.dgvProduct.RowTemplate.Height = 24;
			this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProduct.Size = new System.Drawing.Size(358, 391);
			this.dgvProduct.TabIndex = 34;
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
			// unit_name
			// 
			this.unit_name.DataPropertyName = "unit_name";
			this.unit_name.HeaderText = "Đơn vị tính";
			this.unit_name.MinimumWidth = 6;
			this.unit_name.Name = "unit_name";
			this.unit_name.ReadOnly = true;
			this.unit_name.Visible = false;
			// 
			// product_price
			// 
			this.product_price.DataPropertyName = "price";
			this.product_price.HeaderText = "Giá đơn vị";
			this.product_price.MinimumWidth = 6;
			this.product_price.Name = "product_price";
			this.product_price.ReadOnly = true;
			this.product_price.Visible = false;
			// 
			// storage_quantity
			// 
			this.storage_quantity.DataPropertyName = "storage_quantity";
			this.storage_quantity.HeaderText = "Số lượng tồn kho";
			this.storage_quantity.MinimumWidth = 6;
			this.storage_quantity.Name = "storage_quantity";
			this.storage_quantity.ReadOnly = true;
			this.storage_quantity.Visible = false;
			// 
			// btnChange
			// 
			this.btnChange.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnChange.FlatAppearance.BorderSize = 0;
			this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnChange.ForeColor = System.Drawing.Color.White;
			this.btnChange.Location = new System.Drawing.Point(4, 6);
			this.btnChange.Name = "btnChange";
			this.btnChange.Size = new System.Drawing.Size(218, 43);
			this.btnChange.TabIndex = 5;
			this.btnChange.Text = "Chỉnh sửa phiếu";
			this.btnChange.UseVisualStyleBackColor = false;
			this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.chkToDebt);
			this.mainPanel.Controls.Add(this.lblCustomer);
			this.mainPanel.Controls.Add(this.btnCustomer);
			this.mainPanel.Controls.Add(this.label6);
			this.mainPanel.Controls.Add(this.dgvOrderDetail);
			this.mainPanel.Controls.Add(this.panel5);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(381, 54);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(773, 573);
			this.mainPanel.TabIndex = 1;
			// 
			// lblCustomer
			// 
			this.lblCustomer.AutoSize = true;
			this.lblCustomer.BackColor = System.Drawing.Color.White;
			this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCustomer.ForeColor = System.Drawing.Color.Green;
			this.lblCustomer.Location = new System.Drawing.Point(161, 10);
			this.lblCustomer.Name = "lblCustomer";
			this.lblCustomer.Size = new System.Drawing.Size(168, 29);
			this.lblCustomer.TabIndex = 35;
			this.lblCustomer.Text = "Khách vãng lai";
			// 
			// btnCustomer
			// 
			this.btnCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCustomer.BackColor = System.Drawing.Color.Green;
			this.btnCustomer.FlatAppearance.BorderSize = 0;
			this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnCustomer.ForeColor = System.Drawing.Color.White;
			this.btnCustomer.Location = new System.Drawing.Point(546, 3);
			this.btnCustomer.Name = "btnCustomer";
			this.btnCustomer.Size = new System.Drawing.Size(222, 45);
			this.btnCustomer.TabIndex = 36;
			this.btnCustomer.Text = "Chọn khách hàng";
			this.btnCustomer.UseVisualStyleBackColor = false;
			this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(7, 10);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(145, 29);
			this.label6.TabIndex = 35;
			this.label6.Text = "Khách hàng:";
			// 
			// dgvOrderDetail
			// 
			this.dgvOrderDetail.AllowUserToAddRows = false;
			this.dgvOrderDetail.AllowUserToDeleteRows = false;
			this.dgvOrderDetail.AllowUserToResizeColumns = false;
			this.dgvOrderDetail.AllowUserToResizeRows = false;
			dataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			dataGridViewCellStyle56.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle56.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle56.SelectionBackColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle56.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle56.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvOrderDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle56;
			this.dgvOrderDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvOrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvOrderDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvOrderDetail.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle57.BackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle57.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle57.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle57.SelectionBackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle57.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle57.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvOrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle57;
			this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.orderDetailIdproduct,
            this.orderDetailProductName,
            this.orderDetailUnitName,
            this.price,
            this.quantity,
            this.total});
			dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle58.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle58.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			dataGridViewCellStyle58.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle58.SelectionBackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle58.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvOrderDetail.DefaultCellStyle = dataGridViewCellStyle58;
			this.dgvOrderDetail.EnableHeadersVisualStyles = false;
			this.dgvOrderDetail.Location = new System.Drawing.Point(5, 54);
			this.dgvOrderDetail.MultiSelect = false;
			this.dgvOrderDetail.Name = "dgvOrderDetail";
			this.dgvOrderDetail.ReadOnly = true;
			this.dgvOrderDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle59.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle59.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
			dataGridViewCellStyle59.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle59.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle59.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvOrderDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle59;
			this.dgvOrderDetail.RowHeadersVisible = false;
			this.dgvOrderDetail.RowHeadersWidth = 51;
			this.dgvOrderDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle60.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle60.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle60.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle60.SelectionBackColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle60.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle60.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvOrderDetail.RowsDefaultCellStyle = dataGridViewCellStyle60;
			this.dgvOrderDetail.RowTemplate.Height = 24;
			this.dgvOrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvOrderDetail.Size = new System.Drawing.Size(766, 400);
			this.dgvOrderDetail.TabIndex = 34;
			this.dgvOrderDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetail_CellClick);
			// 
			// Id
			// 
			this.Id.DataPropertyName = "id";
			this.Id.FillWeight = 44.13591F;
			this.Id.HeaderText = "";
			this.Id.MinimumWidth = 6;
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			// 
			// orderDetailIdproduct
			// 
			this.orderDetailIdproduct.DataPropertyName = "idproduct";
			this.orderDetailIdproduct.HeaderText = "Mã rau củ";
			this.orderDetailIdproduct.MinimumWidth = 6;
			this.orderDetailIdproduct.Name = "orderDetailIdproduct";
			this.orderDetailIdproduct.ReadOnly = true;
			this.orderDetailIdproduct.Visible = false;
			// 
			// orderDetailProductName
			// 
			this.orderDetailProductName.DataPropertyName = "product_name";
			this.orderDetailProductName.FillWeight = 244.1972F;
			this.orderDetailProductName.HeaderText = "Tên rau củ";
			this.orderDetailProductName.MinimumWidth = 6;
			this.orderDetailProductName.Name = "orderDetailProductName";
			this.orderDetailProductName.ReadOnly = true;
			// 
			// orderDetailUnitName
			// 
			this.orderDetailUnitName.DataPropertyName = "unit_name";
			this.orderDetailUnitName.FillWeight = 90.66545F;
			this.orderDetailUnitName.HeaderText = "Đơn vị tính";
			this.orderDetailUnitName.MinimumWidth = 6;
			this.orderDetailUnitName.Name = "orderDetailUnitName";
			this.orderDetailUnitName.ReadOnly = true;
			// 
			// price
			// 
			this.price.DataPropertyName = "price";
			this.price.FillWeight = 82.81207F;
			this.price.HeaderText = "Giá đơn vị";
			this.price.MinimumWidth = 6;
			this.price.Name = "price";
			this.price.ReadOnly = true;
			// 
			// quantity
			// 
			this.quantity.DataPropertyName = "quantity";
			this.quantity.FillWeight = 74.01818F;
			this.quantity.HeaderText = "Số lượng";
			this.quantity.MinimumWidth = 6;
			this.quantity.Name = "quantity";
			this.quantity.ReadOnly = true;
			// 
			// total
			// 
			this.total.DataPropertyName = "total";
			this.total.FillWeight = 64.17111F;
			this.total.HeaderText = "Thành tiền";
			this.total.MinimumWidth = 6;
			this.total.Name = "total";
			this.total.ReadOnly = true;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.lblFinishMoney);
			this.panel5.Controls.Add(this.label16);
			this.panel5.Controls.Add(this.lblDiscount);
			this.panel5.Controls.Add(this.label14);
			this.panel5.Controls.Add(this.lblTotal);
			this.panel5.Controls.Add(this.label5);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel5.Location = new System.Drawing.Point(0, 459);
			this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(773, 114);
			this.panel5.TabIndex = 1;
			// 
			// lblFinishMoney
			// 
			this.lblFinishMoney.BackColor = System.Drawing.Color.White;
			this.lblFinishMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.lblFinishMoney.ForeColor = System.Drawing.Color.Green;
			this.lblFinishMoney.Location = new System.Drawing.Point(188, 75);
			this.lblFinishMoney.Name = "lblFinishMoney";
			this.lblFinishMoney.Size = new System.Drawing.Size(445, 26);
			this.lblFinishMoney.TabIndex = 45;
			this.lblFinishMoney.Text = "0 VND";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.BackColor = System.Drawing.Color.White;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.label16.ForeColor = System.Drawing.Color.Black;
			this.label16.Location = new System.Drawing.Point(4, 75);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(157, 32);
			this.label16.TabIndex = 44;
			this.label16.Text = "Thành tiền:";
			// 
			// lblDiscount
			// 
			this.lblDiscount.BackColor = System.Drawing.Color.White;
			this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.lblDiscount.ForeColor = System.Drawing.Color.Green;
			this.lblDiscount.Location = new System.Drawing.Point(189, 43);
			this.lblDiscount.Name = "lblDiscount";
			this.lblDiscount.Size = new System.Drawing.Size(445, 26);
			this.lblDiscount.TabIndex = 43;
			this.lblDiscount.Text = "0%";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.White;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.label14.ForeColor = System.Drawing.Color.Black;
			this.label14.Location = new System.Drawing.Point(6, 43);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(136, 32);
			this.label14.TabIndex = 42;
			this.label14.Text = "Giảm giá:";
			// 
			// lblTotal
			// 
			this.lblTotal.BackColor = System.Drawing.Color.White;
			this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.lblTotal.ForeColor = System.Drawing.Color.Green;
			this.lblTotal.Location = new System.Drawing.Point(189, 11);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(445, 26);
			this.lblTotal.TabIndex = 41;
			this.lblTotal.Text = "0 VND";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(5, 11);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(141, 32);
			this.label5.TabIndex = 40;
			this.label5.Text = "Tổng tiền:";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Dock = System.Windows.Forms.DockStyle.Top;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(381, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(773, 54);
			this.label7.TabIndex = 34;
			this.label7.Text = "Hoá đơn bán hàng";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnMakeOrder
			// 
			this.btnMakeOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMakeOrder.BackColor = System.Drawing.Color.Green;
			this.btnMakeOrder.Enabled = false;
			this.btnMakeOrder.FlatAppearance.BorderSize = 0;
			this.btnMakeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMakeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnMakeOrder.ForeColor = System.Drawing.Color.White;
			this.btnMakeOrder.Location = new System.Drawing.Point(547, 4);
			this.btnMakeOrder.Name = "btnMakeOrder";
			this.btnMakeOrder.Size = new System.Drawing.Size(222, 45);
			this.btnMakeOrder.TabIndex = 8;
			this.btnMakeOrder.Text = "Lập phiếu";
			this.btnMakeOrder.UseVisualStyleBackColor = false;
			this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
			// 
			// btnReset
			// 
			this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReset.BackColor = System.Drawing.Color.Red;
			this.btnReset.Enabled = false;
			this.btnReset.FlatAppearance.BorderSize = 0;
			this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnReset.ForeColor = System.Drawing.Color.White;
			this.btnReset.Location = new System.Drawing.Point(301, 6);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(239, 45);
			this.btnReset.TabIndex = 7;
			this.btnReset.Text = "Xoá toàn bộ phiếu";
			this.btnReset.UseVisualStyleBackColor = false;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// changeDetailPanel
			// 
			this.changeDetailPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.changeDetailPanel.Controls.Add(this.txtChangeDetailUnitPrice);
			this.changeDetailPanel.Controls.Add(this.panel2);
			this.changeDetailPanel.Controls.Add(this.txtChangeDetailProductUnit);
			this.changeDetailPanel.Controls.Add(this.label12);
			this.changeDetailPanel.Controls.Add(this.txtChangeDetailProductName);
			this.changeDetailPanel.Controls.Add(this.label11);
			this.changeDetailPanel.Controls.Add(this.nmrChangeDetailCount);
			this.changeDetailPanel.Controls.Add(this.label10);
			this.changeDetailPanel.Controls.Add(this.label9);
			this.changeDetailPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.changeDetailPanel.Enabled = false;
			this.changeDetailPanel.Location = new System.Drawing.Point(381, 683);
			this.changeDetailPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.changeDetailPanel.Name = "changeDetailPanel";
			this.changeDetailPanel.Size = new System.Drawing.Size(773, 108);
			this.changeDetailPanel.TabIndex = 34;
			this.changeDetailPanel.Visible = false;
			// 
			// txtChangeDetailUnitPrice
			// 
			this.txtChangeDetailUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtChangeDetailUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtChangeDetailUnitPrice.Enabled = false;
			this.txtChangeDetailUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChangeDetailUnitPrice.Location = new System.Drawing.Point(437, 16);
			this.txtChangeDetailUnitPrice.Name = "txtChangeDetailUnitPrice";
			this.txtChangeDetailUnitPrice.Size = new System.Drawing.Size(102, 34);
			this.txtChangeDetailUnitPrice.TabIndex = 52;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.btnDelete);
			this.panel2.Controls.Add(this.btnSave);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(545, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(226, 106);
			this.panel2.TabIndex = 51;
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.BackColor = System.Drawing.Color.Red;
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(19, 6);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(187, 45);
			this.btnDelete.TabIndex = 9;
			this.btnDelete.Text = "Xoá";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.BackColor = System.Drawing.Color.Green;
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(19, 57);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(187, 45);
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtChangeDetailProductUnit
			// 
			this.txtChangeDetailProductUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtChangeDetailProductUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtChangeDetailProductUnit.Enabled = false;
			this.txtChangeDetailProductUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChangeDetailProductUnit.Location = new System.Drawing.Point(165, 54);
			this.txtChangeDetailProductUnit.Name = "txtChangeDetailProductUnit";
			this.txtChangeDetailProductUnit.Size = new System.Drawing.Size(110, 34);
			this.txtChangeDetailProductUnit.TabIndex = 43;
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.White;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.label12.ForeColor = System.Drawing.Color.Black;
			this.label12.Location = new System.Drawing.Point(3, 58);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(156, 32);
			this.label12.TabIndex = 44;
			this.label12.Text = "Đơn vị tính:";
			// 
			// txtChangeDetailProductName
			// 
			this.txtChangeDetailProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtChangeDetailProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtChangeDetailProductName.Enabled = false;
			this.txtChangeDetailProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChangeDetailProductName.Location = new System.Drawing.Point(121, 18);
			this.txtChangeDetailProductName.Name = "txtChangeDetailProductName";
			this.txtChangeDetailProductName.Size = new System.Drawing.Size(154, 34);
			this.txtChangeDetailProductName.TabIndex = 45;
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.White;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(3, 20);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(111, 32);
			this.label11.TabIndex = 46;
			this.label11.Text = "Rau củ:";
			// 
			// nmrChangeDetailCount
			// 
			this.nmrChangeDetailCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nmrChangeDetailCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			this.nmrChangeDetailCount.Location = new System.Drawing.Point(434, 55);
			this.nmrChangeDetailCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.nmrChangeDetailCount.Name = "nmrChangeDetailCount";
			this.nmrChangeDetailCount.Size = new System.Drawing.Size(105, 34);
			this.nmrChangeDetailCount.TabIndex = 47;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.White;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(281, 57);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(135, 32);
			this.label10.TabIndex = 48;
			this.label10.Text = "Số lượng:";
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.White;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(281, 20);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(150, 32);
			this.label9.TabIndex = 50;
			this.label9.Text = "Giá đơn vị:";
			// 
			// panel7
			// 
			this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel7.Controls.Add(this.btnReset);
			this.panel7.Controls.Add(this.btnChange);
			this.panel7.Controls.Add(this.btnMakeOrder);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel7.Location = new System.Drawing.Point(381, 627);
			this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(773, 56);
			this.panel7.TabIndex = 35;
			// 
			// chkToDebt
			// 
			this.chkToDebt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkToDebt.AutoSize = true;
			this.chkToDebt.Enabled = false;
			this.chkToDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkToDebt.ForeColor = System.Drawing.Color.Black;
			this.chkToDebt.Location = new System.Drawing.Point(429, 10);
			this.chkToDebt.Name = "chkToDebt";
			this.chkToDebt.Size = new System.Drawing.Size(111, 33);
			this.chkToDebt.TabIndex = 37;
			this.chkToDebt.Text = "Ghi nợ";
			this.chkToDebt.UseVisualStyleBackColor = true;
			// 
			// SellBill
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.changeDetailPanel);
			this.Controls.Add(this.leftMenuPanel);
			this.Margin = new System.Windows.Forms.Padding(12);
			this.Name = "SellBill";
			this.Size = new System.Drawing.Size(1154, 791);
			this.leftMenuPanel.ResumeLayout(false);
			this.leftMenuPanel.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nmrCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.changeDetailPanel.ResumeLayout(false);
			this.changeDetailPanel.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nmrChangeDetailCount)).EndInit();
			this.panel7.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Panel leftMenuPanel;
		private Panel panel1;
		private Panel panel3;
		private Button btnChange;
		private NumericUpDown nmrCount;
		private Label label4;
		private TextBox txtUnit;
		private Label label3;
		private TextBox txtProductName;
		private Label label2;
		private ComboBox cboCategory;
		private Label label1;
		private TextBox txtSearch;
		private Panel mainPanel;
		private DataGridView dgvOrderDetail;
		private Panel panel5;
		private Label lblTotal;
		private Label label5;
		private Button btnAdd;
		private Label label7;
		private Button btnMakeOrder;
		private Button btnReset;
		private DataGridView dgvProduct;
		private Panel changeDetailPanel;
		private Panel panel7;
		private TextBox txtChangeDetailProductUnit;
		private Label label12;
		private TextBox txtChangeDetailProductName;
		private Label label11;
		private NumericUpDown nmrChangeDetailCount;
		private Label label10;
		private Panel panel2;
		private Button btnDelete;
		private Button btnSave;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn orderDetailIdproduct;
		private DataGridViewTextBoxColumn orderDetailProductName;
		private DataGridViewTextBoxColumn orderDetailUnitName;
		private DataGridViewTextBoxColumn price;
		private DataGridViewTextBoxColumn quantity;
		private DataGridViewTextBoxColumn total;
		private Label label6;
		private Button btnCustomer;
		private Label lblCustomer;
		private Label lblFinishMoney;
		private Label label16;
		private Label lblDiscount;
		private Label label14;
		private Label label8;
		private Label label9;
		private TextBox txtUnitPrice;
		private TextBox txtChangeDetailUnitPrice;
		private TextBox txtStorageQuantity;
		private Label label13;
		private DataGridViewTextBoxColumn idproduct;
		private DataGridViewTextBoxColumn product_name;
		private DataGridViewTextBoxColumn unit_name;
		private DataGridViewTextBoxColumn product_price;
		private DataGridViewTextBoxColumn storage_quantity;
		private CheckBox chkToDebt;
	}
}
