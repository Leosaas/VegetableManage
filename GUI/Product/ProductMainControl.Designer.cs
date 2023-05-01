using System.Drawing;
using System.Windows.Forms;

namespace GUI.Product
{
	partial class ProductMainControl
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
			this.menuPanel = new System.Windows.Forms.Panel();
			this.btnStorage = new System.Windows.Forms.Button();
			this.btnUnit = new System.Windows.Forms.Button();
			this.btnCategory = new System.Windows.Forms.Button();
			this.btnProduct = new System.Windows.Forms.Button();
			this.contentPanel = new System.Windows.Forms.Panel();
			this.menuPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuPanel
			// 
			this.menuPanel.BackColor = System.Drawing.Color.Gray;
			this.menuPanel.Controls.Add(this.btnStorage);
			this.menuPanel.Controls.Add(this.btnUnit);
			this.menuPanel.Controls.Add(this.btnCategory);
			this.menuPanel.Controls.Add(this.btnProduct);
			this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.menuPanel.Location = new System.Drawing.Point(0, 0);
			this.menuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.menuPanel.Name = "menuPanel";
			this.menuPanel.Size = new System.Drawing.Size(1008, 124);
			this.menuPanel.TabIndex = 0;
			// 
			// btnStorage
			// 
			this.btnStorage.Font = new System.Drawing.Font("Segoe UI", 16.2F);
			this.btnStorage.ForeColor = System.Drawing.Color.Black;
			this.btnStorage.Image = global::GUI.Properties.Resources.storageIcon__2_;
			this.btnStorage.Location = new System.Drawing.Point(623, 10);
			this.btnStorage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnStorage.Name = "btnStorage";
			this.btnStorage.Size = new System.Drawing.Size(168, 102);
			this.btnStorage.TabIndex = 4;
			this.btnStorage.Text = "Kho";
			this.btnStorage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnStorage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnStorage.UseVisualStyleBackColor = true;
			this.btnStorage.Click += new System.EventHandler(this.btnStorage_Click);
			// 
			// btnUnit
			// 
			this.btnUnit.Font = new System.Drawing.Font("Segoe UI", 16.2F);
			this.btnUnit.ForeColor = System.Drawing.Color.Black;
			this.btnUnit.Image = global::GUI.Properties.Resources.unit;
			this.btnUnit.Location = new System.Drawing.Point(409, 10);
			this.btnUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnUnit.Name = "btnUnit";
			this.btnUnit.Size = new System.Drawing.Size(168, 102);
			this.btnUnit.TabIndex = 3;
			this.btnUnit.Text = "Đơn vị tính";
			this.btnUnit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnUnit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnUnit.UseVisualStyleBackColor = true;
			this.btnUnit.Click += new System.EventHandler(this.btnUnit_Click);
			// 
			// btnCategory
			// 
			this.btnCategory.Font = new System.Drawing.Font("Segoe UI", 16.2F);
			this.btnCategory.ForeColor = System.Drawing.Color.Black;
			this.btnCategory.Image = global::GUI.Properties.Resources.categoryIcon;
			this.btnCategory.Location = new System.Drawing.Point(219, 10);
			this.btnCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCategory.Name = "btnCategory";
			this.btnCategory.Size = new System.Drawing.Size(151, 102);
			this.btnCategory.TabIndex = 2;
			this.btnCategory.Text = "Loại";
			this.btnCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnCategory.UseVisualStyleBackColor = true;
			this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
			// 
			// btnProduct
			// 
			this.btnProduct.Font = new System.Drawing.Font("Segoe UI", 16.2F);
			this.btnProduct.ForeColor = System.Drawing.Color.Black;
			this.btnProduct.Image = global::GUI.Properties.Resources.vegetableicon;
			this.btnProduct.Location = new System.Drawing.Point(29, 10);
			this.btnProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnProduct.Name = "btnProduct";
			this.btnProduct.Size = new System.Drawing.Size(165, 102);
			this.btnProduct.TabIndex = 1;
			this.btnProduct.Text = "Sản phẩm";
			this.btnProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnProduct.UseVisualStyleBackColor = true;
			this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
			// 
			// contentPanel
			// 
			this.contentPanel.AutoScroll = true;
			this.contentPanel.AutoSize = true;
			this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.contentPanel.Location = new System.Drawing.Point(0, 124);
			this.contentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.contentPanel.Name = "contentPanel";
			this.contentPanel.Size = new System.Drawing.Size(1008, 523);
			this.contentPanel.TabIndex = 1;
			// 
			// ProductMainControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.contentPanel);
			this.Controls.Add(this.menuPanel);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "ProductMainControl";
			this.Size = new System.Drawing.Size(1008, 647);
			this.menuPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Panel menuPanel;
		private Button btnProduct;
		private Panel contentPanel;
		private Button btnUnit;
		private Button btnCategory;
		private Button btnStorage;
	}
}
