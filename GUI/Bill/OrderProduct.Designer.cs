using System.Drawing;
using System.Windows.Forms;

namespace GUI.Bill
{
	partial class OrderProduct
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
			this.leftMenuPanel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.nmrUnitPrice = new System.Windows.Forms.NumericUpDown();
			this.txtStorageQuantity = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
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
			this.storage_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnChange = new System.Windows.Forms.Button();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
			this.orderDetailIdproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderDetailProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderDetailUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel5 = new System.Windows.Forms.Panel();
			this.lblTotal = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btnMakeOrder = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.changeDetailPanel = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtChangeDetailProductUnit = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtChangeDetailProductName = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.nmrChangeDetailCount = new System.Windows.Forms.NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			this.nmrChangeDetailUnitPrice = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.leftMenuPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmrUnitPrice)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmrCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
			this.panel5.SuspendLayout();
			this.changeDetailPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmrChangeDetailCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmrChangeDetailUnitPrice)).BeginInit();
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
			this.leftMenuPanel.Size = new System.Drawing.Size(386, 791);
			this.leftMenuPanel.TabIndex = 32;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.nmrUnitPrice);
			this.panel1.Controls.Add(this.txtStorageQuantity);
			this.panel1.Controls.Add(this.label13);
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
			this.panel1.Size = new System.Drawing.Size(384, 277);
			this.panel1.TabIndex = 35;
			// 
			// nmrUnitPrice
			// 
			this.nmrUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nmrUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			this.nmrUnitPrice.Location = new System.Drawing.Point(158, 142);
			this.nmrUnitPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.nmrUnitPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.nmrUnitPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nmrUnitPrice.Name = "nmrUnitPrice";
			this.nmrUnitPrice.Size = new System.Drawing.Size(222, 34);
			this.nmrUnitPrice.TabIndex = 44;
			this.nmrUnitPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// txtStorageQuantity
			// 
			this.txtStorageQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtStorageQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtStorageQuantity.Enabled = false;
			this.txtStorageQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.txtStorageQuantity.Location = new System.Drawing.Point(175, 94);
			this.txtStorageQuantity.Name = "txtStorageQuantity";
			this.txtStorageQuantity.Size = new System.Drawing.Size(203, 38);
			this.txtStorageQuantity.TabIndex = 43;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.White;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Black;
			this.label13.Location = new System.Drawing.Point(15, 103);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(154, 29);
			this.label13.TabIndex = 42;
			this.label13.Text = "Số lượng tồn:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(15, 147);
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
			this.panel3.Size = new System.Drawing.Size(382, 53);
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
			this.nmrCount.Size = new System.Drawing.Size(222, 34);
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
			this.txtUnit.Size = new System.Drawing.Size(224, 38);
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
			this.txtProductName.Size = new System.Drawing.Size(223, 38);
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
			this.cboCategory.Size = new System.Drawing.Size(363, 39);
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
			this.txtSearch.Size = new System.Drawing.Size(363, 38);
			this.txtSearch.TabIndex = 0;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// dgvProduct
			// 
			this.dgvProduct.AllowUserToAddRows = false;
			this.dgvProduct.AllowUserToDeleteRows = false;
			this.dgvProduct.AllowUserToResizeColumns = false;
			this.dgvProduct.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
			this.dgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproduct,
            this.product_name,
            this.unit_name,
            this.storage_quantity});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvProduct.EnableHeadersVisualStyles = false;
			this.dgvProduct.Location = new System.Drawing.Point(16, 116);
			this.dgvProduct.MultiSelect = false;
			this.dgvProduct.Name = "dgvProduct";
			this.dgvProduct.ReadOnly = true;
			this.dgvProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvProduct.RowHeadersVisible = false;
			this.dgvProduct.RowHeadersWidth = 51;
			this.dgvProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProduct.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvProduct.RowTemplate.Height = 24;
			this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProduct.Size = new System.Drawing.Size(363, 391);
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
			this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.mainPanel.Controls.Add(this.dgvOrderDetail);
			this.mainPanel.Controls.Add(this.panel5);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(386, 112);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(768, 515);
			this.mainPanel.TabIndex = 1;
			// 
			// dgvOrderDetail
			// 
			this.dgvOrderDetail.AllowUserToAddRows = false;
			this.dgvOrderDetail.AllowUserToDeleteRows = false;
			this.dgvOrderDetail.AllowUserToResizeColumns = false;
			this.dgvOrderDetail.AllowUserToResizeRows = false;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvOrderDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvOrderDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvOrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvOrderDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvOrderDetail.BackgroundColor = System.Drawing.Color.White;
			this.dgvOrderDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvOrderDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvOrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderDetailIdproduct,
            this.orderDetailProductName,
            this.orderDetailUnitName,
            this.price,
            this.quantity,
            this.total});
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvOrderDetail.DefaultCellStyle = dataGridViewCellStyle8;
			this.dgvOrderDetail.EnableHeadersVisualStyles = false;
			this.dgvOrderDetail.Location = new System.Drawing.Point(5, 3);
			this.dgvOrderDetail.MultiSelect = false;
			this.dgvOrderDetail.Name = "dgvOrderDetail";
			this.dgvOrderDetail.ReadOnly = true;
			this.dgvOrderDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvOrderDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dgvOrderDetail.RowHeadersVisible = false;
			this.dgvOrderDetail.RowHeadersWidth = 51;
			this.dgvOrderDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvOrderDetail.RowsDefaultCellStyle = dataGridViewCellStyle10;
			this.dgvOrderDetail.RowTemplate.Height = 24;
			this.dgvOrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvOrderDetail.Size = new System.Drawing.Size(759, 451);
			this.dgvOrderDetail.TabIndex = 34;
			this.dgvOrderDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetail_CellClick);
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
			this.orderDetailProductName.HeaderText = "Tên rau củ";
			this.orderDetailProductName.MinimumWidth = 6;
			this.orderDetailProductName.Name = "orderDetailProductName";
			this.orderDetailProductName.ReadOnly = true;
			// 
			// orderDetailUnitName
			// 
			this.orderDetailUnitName.DataPropertyName = "unit_name";
			this.orderDetailUnitName.HeaderText = "Đơn vị tính";
			this.orderDetailUnitName.MinimumWidth = 6;
			this.orderDetailUnitName.Name = "orderDetailUnitName";
			this.orderDetailUnitName.ReadOnly = true;
			// 
			// price
			// 
			this.price.DataPropertyName = "price";
			this.price.HeaderText = "Giá đơn vị";
			this.price.MinimumWidth = 6;
			this.price.Name = "price";
			this.price.ReadOnly = true;
			// 
			// quantity
			// 
			this.quantity.DataPropertyName = "quantity";
			this.quantity.HeaderText = "Số lượng";
			this.quantity.MinimumWidth = 6;
			this.quantity.Name = "quantity";
			this.quantity.ReadOnly = true;
			// 
			// total
			// 
			this.total.DataPropertyName = "total";
			this.total.HeaderText = "Thành tiền";
			this.total.MinimumWidth = 6;
			this.total.Name = "total";
			this.total.ReadOnly = true;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.lblTotal);
			this.panel5.Controls.Add(this.label5);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel5.Location = new System.Drawing.Point(0, 459);
			this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(766, 54);
			this.panel5.TabIndex = 1;
			// 
			// lblTotal
			// 
			this.lblTotal.BackColor = System.Drawing.Color.White;
			this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.lblTotal.ForeColor = System.Drawing.Color.Green;
			this.lblTotal.Location = new System.Drawing.Point(152, 16);
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
			this.label5.Location = new System.Drawing.Point(5, 16);
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
			this.label7.Location = new System.Drawing.Point(386, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(768, 112);
			this.label7.TabIndex = 34;
			this.label7.Text = "Phiếu nhập hàng";
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
			this.btnMakeOrder.Location = new System.Drawing.Point(542, 4);
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
			this.btnReset.Location = new System.Drawing.Point(296, 6);
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
			this.changeDetailPanel.Controls.Add(this.panel2);
			this.changeDetailPanel.Controls.Add(this.txtChangeDetailProductUnit);
			this.changeDetailPanel.Controls.Add(this.label12);
			this.changeDetailPanel.Controls.Add(this.txtChangeDetailProductName);
			this.changeDetailPanel.Controls.Add(this.label11);
			this.changeDetailPanel.Controls.Add(this.nmrChangeDetailCount);
			this.changeDetailPanel.Controls.Add(this.label10);
			this.changeDetailPanel.Controls.Add(this.nmrChangeDetailUnitPrice);
			this.changeDetailPanel.Controls.Add(this.label9);
			this.changeDetailPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.changeDetailPanel.Enabled = false;
			this.changeDetailPanel.Location = new System.Drawing.Point(386, 683);
			this.changeDetailPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.changeDetailPanel.Name = "changeDetailPanel";
			this.changeDetailPanel.Size = new System.Drawing.Size(768, 108);
			this.changeDetailPanel.TabIndex = 34;
			this.changeDetailPanel.Visible = false;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.btnDelete);
			this.panel2.Controls.Add(this.btnSave);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(540, 0);
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
			this.txtChangeDetailProductUnit.Size = new System.Drawing.Size(96, 34);
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
			this.txtChangeDetailProductName.Size = new System.Drawing.Size(140, 34);
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
			this.nmrChangeDetailCount.Location = new System.Drawing.Point(420, 55);
			this.nmrChangeDetailCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.nmrChangeDetailCount.Name = "nmrChangeDetailCount";
			this.nmrChangeDetailCount.Size = new System.Drawing.Size(114, 34);
			this.nmrChangeDetailCount.TabIndex = 47;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.White;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(267, 57);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(135, 32);
			this.label10.TabIndex = 48;
			this.label10.Text = "Số lượng:";
			// 
			// nmrChangeDetailUnitPrice
			// 
			this.nmrChangeDetailUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nmrChangeDetailUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			this.nmrChangeDetailUnitPrice.Location = new System.Drawing.Point(420, 20);
			this.nmrChangeDetailUnitPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.nmrChangeDetailUnitPrice.Name = "nmrChangeDetailUnitPrice";
			this.nmrChangeDetailUnitPrice.Size = new System.Drawing.Size(114, 34);
			this.nmrChangeDetailUnitPrice.TabIndex = 49;
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.White;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(267, 20);
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
			this.panel7.Location = new System.Drawing.Point(386, 627);
			this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(768, 56);
			this.panel7.TabIndex = 35;
			// 
			// OrderProduct
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
			this.Name = "OrderProduct";
			this.Size = new System.Drawing.Size(1154, 791);
			this.leftMenuPanel.ResumeLayout(false);
			this.leftMenuPanel.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmrUnitPrice)).EndInit();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nmrCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.changeDetailPanel.ResumeLayout(false);
			this.changeDetailPanel.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nmrChangeDetailCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmrChangeDetailUnitPrice)).EndInit();
			this.panel7.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Panel leftMenuPanel;
		private Button btnChange;
		private ComboBox cboCategory;
		private Label label1;
		private TextBox txtSearch;
		private Panel mainPanel;
		private DataGridView dgvOrderDetail;
		private Panel panel5;
		private Label lblTotal;
		private Label label5;
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
		private NumericUpDown nmrChangeDetailUnitPrice;
		private Label label9;
		private Panel panel2;
		private Button btnDelete;
		private DataGridViewTextBoxColumn orderDetailIdproduct;
		private DataGridViewTextBoxColumn orderDetailProductName;
		private DataGridViewTextBoxColumn orderDetailUnitName;
		private DataGridViewTextBoxColumn price;
		private DataGridViewTextBoxColumn quantity;
		private DataGridViewTextBoxColumn total;
		private Button btnSave;
		private Panel panel1;
		private NumericUpDown nmrUnitPrice;
		private TextBox txtStorageQuantity;
		private Label label13;
		private Label label8;
		private Panel panel3;
		private Button btnAdd;
		private NumericUpDown nmrCount;
		private Label label4;
		private TextBox txtUnit;
		private Label label3;
		private TextBox txtProductName;
		private Label label2;
		private DataGridViewTextBoxColumn idproduct;
		private DataGridViewTextBoxColumn product_name;
		private DataGridViewTextBoxColumn unit_name;
		private DataGridViewTextBoxColumn storage_quantity;
	}
}
