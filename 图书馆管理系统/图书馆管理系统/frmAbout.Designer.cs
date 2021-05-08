namespace 图书馆管理系统
{
    partial class frmAbout
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picbLogo = new System.Windows.Forms.PictureBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lalVersion = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblDevelop = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.05325F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.picbLogo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblProductName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lalVersion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCopyright, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDevelop, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbxDescription, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnOk, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(369, 246);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // picbLogo
            // 
            this.picbLogo.Image = global::图书馆管理系统.Properties.Resources.logo2_副本;
            this.picbLogo.Location = new System.Drawing.Point(3, 3);
            this.picbLogo.Name = "picbLogo";
            this.tableLayoutPanel1.SetRowSpan(this.picbLogo, 6);
            this.picbLogo.Size = new System.Drawing.Size(128, 246);
            this.picbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbLogo.TabIndex = 0;
            this.picbLogo.TabStop = false;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("宋体", 11F);
            this.lblProductName.Location = new System.Drawing.Point(137, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(188, 15);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "产品名称: 图书馆管理系统";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lalVersion
            // 
            this.lalVersion.AutoSize = true;
            this.lalVersion.Font = new System.Drawing.Font("宋体", 11F);
            this.lalVersion.Location = new System.Drawing.Point(137, 32);
            this.lalVersion.Name = "lalVersion";
            this.lalVersion.Size = new System.Drawing.Size(85, 15);
            this.lalVersion.TabIndex = 2;
            this.lalVersion.Text = "版本: V1.0";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("宋体", 11F);
            this.lblCopyright.Location = new System.Drawing.Point(137, 62);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(159, 15);
            this.lblCopyright.TabIndex = 3;
            this.lblCopyright.Text = "Copyright 2012-2013";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDevelop
            // 
            this.lblDevelop.AutoSize = true;
            this.lblDevelop.Font = new System.Drawing.Font("宋体", 11F);
            this.lblDevelop.Location = new System.Drawing.Point(137, 93);
            this.lblDevelop.Name = "lblDevelop";
            this.lblDevelop.Size = new System.Drawing.Size(112, 15);
            this.lblDevelop.TabIndex = 4;
            this.lblDevelop.Text = "开发：千鸟软件";
            // 
            // tbxDescription
            // 
            this.tbxDescription.BackColor = System.Drawing.SystemColors.Control;
            this.tbxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxDescription.Font = new System.Drawing.Font("宋体", 11F);
            this.tbxDescription.Location = new System.Drawing.Point(140, 131);
            this.tbxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.ReadOnly = true;
            this.tbxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxDescription.Size = new System.Drawing.Size(226, 82);
            this.tbxDescription.TabIndex = 5;
            this.tbxDescription.Text = "说明:                                    这是一款功能齐全的图书管理系统,界面友好,操作简单,易学易用.适合大中小各类图书馆使" +
                "用!";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.Location = new System.Drawing.Point(291, 222);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click_1);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 267);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于图书管理系统";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picbLogo;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lalVersion;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblDevelop;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Button btnOk;

    }
}