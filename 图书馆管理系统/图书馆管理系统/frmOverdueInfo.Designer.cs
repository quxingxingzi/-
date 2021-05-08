namespace 图书馆管理系统
{
    partial class frmOverdueInfo
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbToBorrow = new System.Windows.Forms.ToolStripButton();
            this.tsbReflesh = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbToExcel = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butClose = new System.Windows.Forms.Button();
            this.txtBookIDorName = new System.Windows.Forms.TextBox();
            this.txtReaderIDorName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvOverdueInfo = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverdueInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbToBorrow,
            this.tsbReflesh,
            this.tsbDelete,
            this.tsbToExcel,
            this.tsbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(745, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbToBorrow
            // 
            this.tsbToBorrow.Image = global::图书馆管理系统.Properties.Resources._1_1_;
            this.tsbToBorrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbToBorrow.Name = "tsbToBorrow";
            this.tsbToBorrow.Size = new System.Drawing.Size(52, 22);
            this.tsbToBorrow.Text = "罚款";
            // 
            // tsbReflesh
            // 
            this.tsbReflesh.Image = global::图书馆管理系统.Properties.Resources.luru;
            this.tsbReflesh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReflesh.Name = "tsbReflesh";
            this.tsbReflesh.Size = new System.Drawing.Size(52, 22);
            this.tsbReflesh.Text = "刷新";
            this.tsbReflesh.Click += new System.EventHandler(this.tsbReflesh_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::图书馆管理系统.Properties.Resources.Shell32_063;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(52, 22);
            this.tsbDelete.Text = "删除";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbToExcel
            // 
            this.tsbToExcel.Image = global::图书馆管理系统.Properties.Resources.Shell32_115;
            this.tsbToExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbToExcel.Name = "tsbToExcel";
            this.tsbToExcel.Size = new System.Drawing.Size(52, 22);
            this.tsbToExcel.Text = "导出";
            this.tsbToExcel.ToolTipText = "导出至Excel表格";
            this.tsbToExcel.Click += new System.EventHandler(this.tsbToExcel_Click);
            // 
            // tsbClose
            // 
            this.tsbClose.Image = global::图书馆管理系统.Properties.Resources.退出系统1;
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(52, 22);
            this.tsbClose.Text = "退出";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butClose);
            this.groupBox1.Controls.Add(this.txtBookIDorName);
            this.groupBox1.Controls.Add(this.txtReaderIDorName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "条件查询";
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(574, 26);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(58, 23);
            this.butClose.TabIndex = 6;
            this.butClose.Text = "退出(&C)";
            this.butClose.UseVisualStyleBackColor = true;
            // 
            // txtBookIDorName
            // 
            this.txtBookIDorName.Location = new System.Drawing.Point(393, 28);
            this.txtBookIDorName.MaxLength = 50;
            this.txtBookIDorName.Name = "txtBookIDorName";
            this.txtBookIDorName.Size = new System.Drawing.Size(100, 21);
            this.txtBookIDorName.TabIndex = 5;
            this.txtBookIDorName.TextChanged += new System.EventHandler(this.txtBookIDorName_TextChanged);
            // 
            // txtReaderIDorName
            // 
            this.txtReaderIDorName.Location = new System.Drawing.Point(142, 28);
            this.txtReaderIDorName.MaxLength = 50;
            this.txtReaderIDorName.Name = "txtReaderIDorName";
            this.txtReaderIDorName.Size = new System.Drawing.Size(100, 21);
            this.txtReaderIDorName.TabIndex = 4;
            this.txtReaderIDorName.TextChanged += new System.EventHandler(this.txtReaderIDorName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "图书编号或名称(&B):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "读者编号或姓名(&R):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvOverdueInfo);
            this.groupBox2.Location = new System.Drawing.Point(11, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(722, 266);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "逾期信息";
            // 
            // dgvOverdueInfo
            // 
            this.dgvOverdueInfo.AllowUserToAddRows = false;
            this.dgvOverdueInfo.AllowUserToDeleteRows = false;
            this.dgvOverdueInfo.AllowUserToResizeRows = false;
            this.dgvOverdueInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvOverdueInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOverdueInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOverdueInfo.Location = new System.Drawing.Point(6, 20);
            this.dgvOverdueInfo.MultiSelect = false;
            this.dgvOverdueInfo.Name = "dgvOverdueInfo";
            this.dgvOverdueInfo.ReadOnly = true;
            this.dgvOverdueInfo.RowTemplate.Height = 23;
            this.dgvOverdueInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOverdueInfo.Size = new System.Drawing.Size(710, 240);
            this.dgvOverdueInfo.TabIndex = 0;
            // 
            // frmOverdueInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 386);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmOverdueInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "逾期详情";
            this.Load += new System.EventHandler(this.frmOverdueInfo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmOverdueInfo_KeyDown);
            this.Resize += new System.EventHandler(this.frmOverdueInfo_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverdueInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBookIDorName;
        private System.Windows.Forms.TextBox txtReaderIDorName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvOverdueInfo;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.ToolStripButton tsbToBorrow;
        private System.Windows.Forms.ToolStripButton tsbReflesh;
        private System.Windows.Forms.ToolStripButton tsbToExcel;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbDelete;
    }
}