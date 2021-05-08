namespace 图书馆管理系统
{
    partial class frmPenaltryInfo
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbChange = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbReflesh = new System.Windows.Forms.ToolStripButton();
            this.tsbToExcel = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.butCheckBook = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.butCheckReader = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReaderName = new System.Windows.Forms.TextBox();
            this.txtReaderId = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtPenaltyMoney = new System.Windows.Forms.TextBox();
            this.txtRemorandum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.butOk = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPenaltryInfo = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenaltryInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbChange,
            this.tsbDelete,
            this.tsbReflesh,
            this.tsbToExcel,
            this.tsbExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(972, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::图书馆管理系统.Properties.Resources.Shell32_096;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(52, 22);
            this.tsbAdd.Text = "添加";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbChange
            // 
            this.tsbChange.Image = global::图书馆管理系统.Properties.Resources.Shell32_097;
            this.tsbChange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChange.Name = "tsbChange";
            this.tsbChange.Size = new System.Drawing.Size(52, 22);
            this.tsbChange.Text = "修改";
            this.tsbChange.Click += new System.EventHandler(this.tsbChange_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::图书馆管理系统.Properties.Resources.Shell32_063;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(52, 22);
            this.tsbDelete.Text = "删除";
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
            // tsbExit
            // 
            this.tsbExit.BackColor = System.Drawing.SystemColors.Control;
            this.tsbExit.Image = global::图书馆管理系统.Properties.Resources.退出系统1;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(52, 22);
            this.tsbExit.Text = "退出";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.cmbType);
            this.splitContainer1.Panel1.Controls.Add(this.txtPenaltyMoney);
            this.splitContainer1.Panel1.Controls.Add(this.txtRemorandum);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.butOk);
            this.splitContainer1.Panel1.Controls.Add(this.butExit);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvPenaltryInfo);
            this.splitContainer1.Panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainer1.Size = new System.Drawing.Size(972, 571);
            this.splitContainer1.SplitterDistance = 146;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtBookId);
            this.groupBox2.Controls.Add(this.txtBookName);
            this.groupBox2.Controls.Add(this.butCheckBook);
            this.groupBox2.Location = new System.Drawing.Point(488, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 100);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "涉及图书";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "图书编号：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 26;
            this.label10.Text = "图书名称：";
            // 
            // txtBookId
            // 
            this.txtBookId.Enabled = false;
            this.txtBookId.Location = new System.Drawing.Point(77, 21);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(91, 21);
            this.txtBookId.TabIndex = 18;
            // 
            // txtBookName
            // 
            this.txtBookName.Enabled = false;
            this.txtBookName.Location = new System.Drawing.Point(77, 65);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(91, 21);
            this.txtBookName.TabIndex = 19;
            // 
            // butCheckBook
            // 
            this.butCheckBook.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.butCheckBook.Enabled = false;
            this.butCheckBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butCheckBook.Location = new System.Drawing.Point(168, 21);
            this.butCheckBook.Name = "butCheckBook";
            this.butCheckBook.Size = new System.Drawing.Size(23, 65);
            this.butCheckBook.TabIndex = 20;
            this.butCheckBook.Text = "选择";
            this.butCheckBook.UseVisualStyleBackColor = true;
            this.butCheckBook.Click += new System.EventHandler(this.butCheckBook_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.butCheckReader);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtReaderName);
            this.groupBox1.Controls.Add(this.txtReaderId);
            this.groupBox1.Location = new System.Drawing.Point(169, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 100);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "罚款读者";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "读者编号：";
            // 
            // butCheckReader
            // 
            this.butCheckReader.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.butCheckReader.Enabled = false;
            this.butCheckReader.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butCheckReader.Location = new System.Drawing.Point(168, 21);
            this.butCheckReader.Name = "butCheckReader";
            this.butCheckReader.Size = new System.Drawing.Size(23, 65);
            this.butCheckReader.TabIndex = 10;
            this.butCheckReader.Text = "选择";
            this.butCheckReader.UseVisualStyleBackColor = true;
            this.butCheckReader.Click += new System.EventHandler(this.butCheckReader_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "读者姓名：";
            // 
            // txtReaderName
            // 
            this.txtReaderName.Enabled = false;
            this.txtReaderName.Location = new System.Drawing.Point(77, 65);
            this.txtReaderName.Name = "txtReaderName";
            this.txtReaderName.Size = new System.Drawing.Size(93, 21);
            this.txtReaderName.TabIndex = 9;
            // 
            // txtReaderId
            // 
            this.txtReaderId.Enabled = false;
            this.txtReaderId.Location = new System.Drawing.Point(77, 21);
            this.txtReaderId.Name = "txtReaderId";
            this.txtReaderId.Size = new System.Drawing.Size(93, 21);
            this.txtReaderId.TabIndex = 16;
            // 
            // cmbType
            // 
            this.cmbType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Enabled = false;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "",
            "图书损坏",
            "超期未还"});
            this.cmbType.Location = new System.Drawing.Point(710, 94);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(130, 20);
            this.cmbType.TabIndex = 1;
            // 
            // txtPenaltyMoney
            // 
            this.txtPenaltyMoney.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtPenaltyMoney.Enabled = false;
            this.txtPenaltyMoney.Location = new System.Drawing.Point(710, 44);
            this.txtPenaltyMoney.Name = "txtPenaltyMoney";
            this.txtPenaltyMoney.Size = new System.Drawing.Size(128, 21);
            this.txtPenaltyMoney.TabIndex = 22;
            // 
            // txtRemorandum
            // 
            this.txtRemorandum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRemorandum.Enabled = false;
            this.txtRemorandum.Location = new System.Drawing.Point(11, 44);
            this.txtRemorandum.Name = "txtRemorandum";
            this.txtRemorandum.ReadOnly = true;
            this.txtRemorandum.Size = new System.Drawing.Size(134, 21);
            this.txtRemorandum.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(708, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "罚款类型:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(708, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "交款金额（元）：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 21);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "操作编号:";
            // 
            // butOk
            // 
            this.butOk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.butOk.Location = new System.Drawing.Point(858, 42);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(91, 23);
            this.butOk.TabIndex = 12;
            this.butOk.Text = "确定(&O)";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // butExit
            // 
            this.butExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.butExit.Location = new System.Drawing.Point(858, 92);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(91, 23);
            this.butExit.TabIndex = 13;
            this.butExit.Text = "取消(&C)";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "交款时间:";
            // 
            // dgvPenaltryInfo
            // 
            this.dgvPenaltryInfo.AllowUserToAddRows = false;
            this.dgvPenaltryInfo.AllowUserToDeleteRows = false;
            this.dgvPenaltryInfo.AllowUserToResizeRows = false;
            this.dgvPenaltryInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPenaltryInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPenaltryInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPenaltryInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPenaltryInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPenaltryInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvPenaltryInfo.MultiSelect = false;
            this.dgvPenaltryInfo.Name = "dgvPenaltryInfo";
            this.dgvPenaltryInfo.ReadOnly = true;
            this.dgvPenaltryInfo.RowTemplate.Height = 23;
            this.dgvPenaltryInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPenaltryInfo.ShowEditingIcon = false;
            this.dgvPenaltryInfo.Size = new System.Drawing.Size(970, 421);
            this.dgvPenaltryInfo.TabIndex = 0;
            this.dgvPenaltryInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPenaltryInfo_CellClick);
            // 
            // frmPenaltryInfo
            // 
            this.AcceptButton = this.butOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 596);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(737, 534);
            this.Name = "frmPenaltryInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "图书罚款";
            this.Load += new System.EventHandler(this.frmPenaltryInfo_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPenaltryInfo_Paint);
            this.Resize += new System.EventHandler(this.frmPenaltryInfo_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenaltryInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbChange;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbToExcel;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPenaltryInfo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtRemorandum;
        private System.Windows.Forms.Button butCheckReader;
        private System.Windows.Forms.TextBox txtReaderName;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ToolStripButton tsbReflesh;
        private System.Windows.Forms.Button butCheckBook;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.TextBox txtReaderId;
        private System.Windows.Forms.TextBox txtPenaltyMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}