namespace 图书馆管理系统
{
    partial class frmBackup
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackup));
            this.txtBackupWay = new System.Windows.Forms.TextBox();
            this.butBackWay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butOk = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBackupinfo = new System.Windows.Forms.DataGridView();
            this.butSure = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBackupinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBackupWay
            // 
            this.txtBackupWay.Location = new System.Drawing.Point(90, 35);
            this.txtBackupWay.Name = "txtBackupWay";
            this.txtBackupWay.Size = new System.Drawing.Size(199, 21);
            this.txtBackupWay.TabIndex = 5;
            // 
            // butBackWay
            // 
            this.butBackWay.Location = new System.Drawing.Point(307, 33);
            this.butBackWay.Name = "butBackWay";
            this.butBackWay.Size = new System.Drawing.Size(61, 23);
            this.butBackWay.TabIndex = 2;
            this.butBackWay.Text = "浏览(&B)";
            this.butBackWay.UseVisualStyleBackColor = true;
            this.butBackWay.Click += new System.EventHandler(this.butBackWay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.butOk);
            this.groupBox1.Controls.Add(this.butBackWay);
            this.groupBox1.Controls.Add(this.txtBackupWay);
            this.groupBox1.Location = new System.Drawing.Point(7, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 81);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据库备份/还原";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "备份路径：";
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(416, 35);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(58, 22);
            this.butOk.TabIndex = 3;
            this.butOk.Text = "确定(&O)";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvBackupinfo);
            this.groupBox2.Location = new System.Drawing.Point(7, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 250);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "备份日志";
            // 
            // dgvBackupinfo
            // 
            this.dgvBackupinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBackupinfo.Location = new System.Drawing.Point(6, 16);
            this.dgvBackupinfo.Name = "dgvBackupinfo";
            this.dgvBackupinfo.RowTemplate.Height = 23;
            this.dgvBackupinfo.Size = new System.Drawing.Size(513, 228);
            this.dgvBackupinfo.TabIndex = 0;
            // 
            // butSure
            // 
            this.butSure.Location = new System.Drawing.Point(158, 352);
            this.butSure.Name = "butSure";
            this.butSure.Size = new System.Drawing.Size(75, 23);
            this.butSure.TabIndex = 8;
            this.butSure.Text = "查看(&S)";
            this.butSure.UseVisualStyleBackColor = true;
            this.butSure.Click += new System.EventHandler(this.butSure_Click);
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(300, 352);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(75, 23);
            this.butExit.TabIndex = 9;
            this.butExit.Text = "退出(&C)";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 388);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butSure);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBackup";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据备份/还原";
            this.Load += new System.EventHandler(this.frmBackup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBackupinfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBackupWay;
        private System.Windows.Forms.Button butBackWay;
        private System.Windows.Forms.Button butOk;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvBackupinfo;
        private System.Windows.Forms.Button butSure;
        private System.Windows.Forms.Button butExit;

    }
}