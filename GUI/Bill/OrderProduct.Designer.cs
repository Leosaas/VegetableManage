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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
			this.leftMenuPanel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.nmrUnitPrice = new System.Windows.Forms.NumericUpDown();
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
			this.leftMenuPanel.Size = new System.Drawing.Size(324, 791);
			this.leftMenuPanel.TabIndex = 32;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.nmrUnitPrice);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.nmrCount);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtUnit);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtProductName);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 466);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(322, 323);
			this.panel1.TabIndex = 33;
			// 
			// nmrUnitPrice
			// 
			this.nmrUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nmrUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			this.nmrUnitPrice.Location = new System.Drawing.Point(16, 191);
			this.nmrUnitPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.nmrUnitPrice.Name = "nmrUnitPrice";
			this.nmrUnitPrice.Size = new System.Drawing.Size(301, 34);
			this.nmrUnitPrice.TabIndex = 41;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(15, 160);
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
			this.panel3.Location = new System.Drawing.Point(0, 268);
			this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(320, 53);
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
			this.btnAdd.Size = new System.Drawing.Size(301, 45);
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
			this.nmrCount.Location = new System.Drawing.Point(156, 229);
			this.nmrCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.nmrCount.Name = "nmrCount";
			this.nmrCount.Size = new System.Drawing.Size(160, 34);
			this.nmrCount.TabIndex = 38;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(10, 234);
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
			this.txtUnit.Location = new System.Drawing.Point(16, 118);
			this.txtUnit.Name = "txtUnit";
			this.txtUnit.Size = new System.Drawing.Size(301, 38);
			this.txtUnit.TabIndex = 36;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(15, 86);
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
			this.txtProductName.Location = new System.Drawing.Point(16, 45);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(301, 38);
			this.txtProductName.TabIndex = 34;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(15, 13);
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
			this.cboCategory.Size = new System.Drawing.Size(301, 39);
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
			this.txtSearch.Size = new System.Drawing.Size(301, 38);
			this.txtSearch.TabIndex = 0;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            this.unit_name});
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle13;
			this.dgvProduct.EnableHeadersVisualStyles = false;
			this.dgvProduct.Location = new System.Drawing.Point(16, 116);
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
			this.dgvProduct.Size = new System.Drawing.Size(301, 345);
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
			this.mainPanel.Location = new System.Drawing.Point(324, 112);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(830, 515);
			this.mainPanel.TabIndex = 1;
			// 
			// dgvOrderDetail
			// 
			this.dgvOrderDetail.AllowUserToAddRows = false;
			this.dgvOrderDetail.AllowUserToDeleteRows = false;
			this.dgvOrderDetail.AllowUserToResizeColumns = false;
			this.dgvOrderDetail.AllowUserToResizeRows = false;
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvOrderDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
			this.dgvOrderDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvOrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvOrderDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvOrderDetail.BackgroundColor = System.Drawing.Color.White;
			this.dgvOrderDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvOrderDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.BackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvOrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
			this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderDetailIdproduct,
            this.orderDetailProductName,
            this.orderDetailUnitName,
            this.price,
            this.quantity,
            this.total});
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvOrderDetail.DefaultCellStyle = dataGridViewCellStyle18;
			this.dgvOrderDetail.EnableHeadersVisualStyles = false;
			this.dgvOrderDetail.Location = new System.Drawing.Point(5, 3);
			this.dgvOrderDetail.MultiSelect = false;
			this.dgvOrderDetail.Name = "dgvOrderDetail";
			this.dgvOrderDetail.ReadOnly = true;
			this.dgvOrderDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
			dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvOrderDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
			this.dgvOrderDetail.RowHeadersVisible = false;
			this.dgvOrderDetail.RowHeadersWidth = 51;
			this.dgvOrderDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvOrderDetail.RowsDefaultCellStyle = dataGridViewCellStyle20;
			this.dgvOrderDetail.RowTemplate.Height = 24;
			this.dgvOrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvOrderDetail.Size = new System.Drawing.Size(821, 451);
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
			this.panel5.Size = new System.Drawing.Size(828, 54);
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
			this.label7.Location = new System.Drawing.Point(324, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(830, 112);
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
			this.btnMakeOrder.Location = new System.Drawing.Point(604, 4);
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
			this.btnReset.Location = new System.Drawing.Point(358, 6);
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
			this.changeDetailPanel.Location = new System.Drawing.Point(324, 683);
			this.changeDetailPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.changeDetailPanel.Name = "changeDetailPanel";
			this.changeDetailPanel.Size = new System.Drawing.Size(830, 108);
			this.changeDetailPanel.TabIndex = 34;
			this.changeDetailPanel.Visible = false;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.btnDelete);
			this.panel2.Controls.Add(this.btnSave);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(602, 0);
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
			this.txtChangeDetailProductUnit.Size = new System.Drawing.Size(148, 34);
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
			this.txtChangeDetailProductName.Size = new System.Drawing.Size(194, 34);
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
			this.nmrChangeDetailCount.Location = new System.Drawing.Point(474, 54);
			this.nmrChangeDetailCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.nmrChangeDetailCount.Name = "nmrChangeDetailCount";
			this.nmrChangeDetailCount.Size = new System.Drawing.Size(122, 34);
			this.nmrChangeDetailCount.TabIndex = 47;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.White;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(321, 56);
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
			this.nmrChangeDetailUnitPrice.Location = new System.Drawing.Point(474, 19);
			this.nmrChangeDetailUnitPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.nmrChangeDetailUnitPrice.Name = "nmrChangeDetailUnitPrice";
			this.nmrChangeDetailUnitPrice.Size = new System.Drawing.Size(122, 34);
			this.nmrChangeDetailUnitPrice.TabIndex = 49;
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.White;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(321, 19);
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
			this.panel7.Location = new System.Drawing.Point(324, 627);
			this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(830, 56);
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
		private Label label8;
		private Button btnMakeOrder;
		private Button btnReset;
		private NumericUpDown nmrUnitPrice;
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
		private DataGridViewTextBoxColumn idproduct;
		private DataGridViewTextBoxColumn product_name;
		private DataGridViewTextBoxColumn unit_name;
		private DataGridViewTextBoxColumn orderDetailIdproduct;
		private DataGridViewTextBoxColumn orderDetailProductName;
		private DataGridViewTextBoxColumn orderDetailUnitName;
		private DataGridViewTextBoxColumn price;
		private DataGridViewTextBoxColumn quantity;
		private DataGridViewTextBoxColumn total;
		private Button btnSave;
	}
}
