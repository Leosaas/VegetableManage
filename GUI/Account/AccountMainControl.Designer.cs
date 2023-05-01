using System.Drawing;
using System.Windows.Forms;

namespace GUI.Product
{
	partial class AccountMainControl
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
			this.contentPanel = new System.Windows.Forms.Panel();
			this.btnAccountList = new System.Windows.Forms.Button();
			this.btnUserList = new System.Windows.Forms.Button();
			this.menuPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuPanel
			// 
			this.menuPanel.BackColor = System.Drawing.Color.Gray;
			this.menuPanel.Controls.Add(this.btnAccountList);
			this.menuPanel.Controls.Add(this.btnUserList);
			this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.menuPanel.Location = new System.Drawing.Point(0, 0);
			this.menuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.menuPanel.Name = "menuPanel";
			this.menuPanel.Size = new System.Drawing.Size(1008, 124);
			this.menuPanel.TabIndex = 0;
			// 
			// contentPanel
			// 
			this.contentPanel.AutoScroll = true;
			this.contentPanel.AutoSize = true;
			this.contentPanel.BackColor = System.Drawing.Color.White;
			this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.contentPanel.Location = new System.Drawing.Point(0, 124);
			this.contentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.contentPanel.Name = "contentPanel";
			this.contentPanel.Size = new System.Drawing.Size(1008, 523);
			this.contentPanel.TabIndex = 1;
			// 
			// btnAccountList
			// 
			this.btnAccountList.BackColor = System.Drawing.Color.White;
			this.btnAccountList.FlatAppearance.BorderSize = 0;
			this.btnAccountList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAccountList.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAccountList.ForeColor = System.Drawing.Color.Black;
			this.btnAccountList.Image = global::GUI.Properties.Resources.account;
			this.btnAccountList.Location = new System.Drawing.Point(300, 10);
			this.btnAccountList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAccountList.Name = "btnAccountList";
			this.btnAccountList.Size = new System.Drawing.Size(246, 102);
			this.btnAccountList.TabIndex = 2;
			this.btnAccountList.Text = "Danh sách tài khoản";
			this.btnAccountList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnAccountList.UseCompatibleTextRendering = true;
			this.btnAccountList.UseVisualStyleBackColor = false;
			this.btnAccountList.Click += new System.EventHandler(this.btnAccountList_Click);
			// 
			// btnUserList
			// 
			this.btnUserList.BackColor = System.Drawing.Color.White;
			this.btnUserList.FlatAppearance.BorderSize = 0;
			this.btnUserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUserList.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUserList.ForeColor = System.Drawing.Color.Black;
			this.btnUserList.Image = global::GUI.Properties.Resources.user2;
			this.btnUserList.Location = new System.Drawing.Point(29, 10);
			this.btnUserList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnUserList.Name = "btnUserList";
			this.btnUserList.Size = new System.Drawing.Size(246, 102);
			this.btnUserList.TabIndex = 1;
			this.btnUserList.Text = "Danh sách người dùng";
			this.btnUserList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnUserList.UseCompatibleTextRendering = true;
			this.btnUserList.UseVisualStyleBackColor = false;
			this.btnUserList.Click += new System.EventHandler(this.btnUserList_Click);
			// 
			// AccountMainControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.contentPanel);
			this.Controls.Add(this.menuPanel);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "AccountMainControl";
			this.Size = new System.Drawing.Size(1008, 647);
			this.menuPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Panel menuPanel;
		private Button btnUserList;
		private Panel contentPanel;
		private Button btnAccountList;
	}
}
