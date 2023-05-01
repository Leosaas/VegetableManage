using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
	partial class SystemControl
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgvData = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.action = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblTitle = new System.Windows.Forms.Label();
			this.btnRestore = new System.Windows.Forms.Button();
			this.btnBackup = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.lblTitle);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1154, 56);
			this.panel1.TabIndex = 1;
			// 
			// dgvData
			// 
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.AllowUserToResizeColumns = false;
			this.dgvData.AllowUserToResizeRows = false;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LimeGreen;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
			this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvData.BackgroundColor = System.Drawing.Color.LightGray;
			this.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.time,
            this.username,
            this.action});
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
			dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.LimeGreen;
			dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.DefaultCellStyle = dataGridViewCellStyle13;
			this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvData.EnableHeadersVisualStyles = false;
			this.dgvData.Location = new System.Drawing.Point(0, 56);
			this.dgvData.MultiSelect = false;
			this.dgvData.Name = "dgvData";
			this.dgvData.ReadOnly = true;
			this.dgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
			dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
			this.dgvData.RowHeadersVisible = false;
			this.dgvData.RowHeadersWidth = 51;
			this.dgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.LimeGreen;
			dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle15;
			this.dgvData.RowTemplate.Height = 24;
			this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvData.Size = new System.Drawing.Size(899, 735);
			this.dgvData.TabIndex = 33;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DimGray;
			this.panel2.Controls.Add(this.btnRestore);
			this.panel2.Controls.Add(this.btnBackup);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(899, 56);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(255, 735);
			this.panel2.TabIndex = 34;
			// 
			// id
			// 
			this.id.DataPropertyName = "ID";
			this.id.FillWeight = 22.16342F;
			this.id.HeaderText = "";
			this.id.MinimumWidth = 6;
			this.id.Name = "id";
			this.id.ReadOnly = true;
			// 
			// time
			// 
			this.time.DataPropertyName = "time";
			this.time.FillWeight = 98.91744F;
			this.time.HeaderText = "Thời điểm";
			this.time.MinimumWidth = 6;
			this.time.Name = "time";
			this.time.ReadOnly = true;
			// 
			// username
			// 
			this.username.DataPropertyName = "username";
			this.username.FillWeight = 66.21729F;
			this.username.HeaderText = "Người dùng";
			this.username.MinimumWidth = 6;
			this.username.Name = "username";
			this.username.ReadOnly = true;
			// 
			// action
			// 
			this.action.DataPropertyName = "action";
			this.action.FillWeight = 225.4563F;
			this.action.HeaderText = "Hành động";
			this.action.MinimumWidth = 6;
			this.action.Name = "action";
			this.action.ReadOnly = true;
			// 
			// lblTitle
			// 
			this.lblTitle.BackColor = System.Drawing.Color.Transparent;
			this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(0, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(1154, 56);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "Lịch sử";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnRestore
			// 
			this.btnRestore.BackColor = System.Drawing.Color.White;
			this.btnRestore.FlatAppearance.BorderSize = 0;
			this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRestore.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRestore.ForeColor = System.Drawing.Color.Black;
			this.btnRestore.Image = global::GUI.Properties.Resources.restore;
			this.btnRestore.Location = new System.Drawing.Point(3, 110);
			this.btnRestore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnRestore.Name = "btnRestore";
			this.btnRestore.Size = new System.Drawing.Size(246, 102);
			this.btnRestore.TabIndex = 3;
			this.btnRestore.Text = "Phục hồi dữ liệu";
			this.btnRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnRestore.UseCompatibleTextRendering = true;
			this.btnRestore.UseVisualStyleBackColor = false;
			this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
			// 
			// btnBackup
			// 
			this.btnBackup.BackColor = System.Drawing.Color.White;
			this.btnBackup.FlatAppearance.BorderSize = 0;
			this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBackup.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBackup.ForeColor = System.Drawing.Color.Black;
			this.btnBackup.Image = global::GUI.Properties.Resources.backup;
			this.btnBackup.Location = new System.Drawing.Point(3, 4);
			this.btnBackup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBackup.Name = "btnBackup";
			this.btnBackup.Size = new System.Drawing.Size(246, 102);
			this.btnBackup.TabIndex = 2;
			this.btnBackup.Text = "Sao lưu dữ liệu";
			this.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnBackup.UseCompatibleTextRendering = true;
			this.btnBackup.UseVisualStyleBackColor = false;
			this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
			// 
			// SystemControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.dgvData);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(12);
			this.Name = "SystemControl";
			this.Size = new System.Drawing.Size(1154, 791);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private DataGridView dgvData;
		private Panel panel1;
		private Panel panel2;
		private Button btnRestore;
		private Button btnBackup;
		private DataGridViewTextBoxColumn id;
		private DataGridViewTextBoxColumn time;
		private DataGridViewTextBoxColumn username;
		private DataGridViewTextBoxColumn action;
		private Label lblTitle;
	}
}
