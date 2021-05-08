namespace 图书馆管理系统
{
    partial class frmSystemSet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSetReserDay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dudCommonNuber = new System.Windows.Forms.DomainUpDown();
            this.dudVipNumber = new System.Windows.Forms.DomainUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radbtnno = new System.Windows.Forms.RadioButton();
            this.radbtnyes = new System.Windows.Forms.RadioButton();
            this.txtSetMoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butOk = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtSetReserDay);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dudCommonNuber);
            this.groupBox1.Controls.Add(this.dudVipNumber);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.radbtnno);
            this.groupBox1.Controls.Add(this.radbtnyes);
            this.groupBox1.Controls.Add(this.txtSetMoney);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(126, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 173);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(276, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 19;
            this.label11.Text = "天";
            // 
            // txtSetReserDay
            // 
            this.txtSetReserDay.Location = new System.Drawing.Point(170, 92);
            this.txtSetReserDay.Name = "txtSetReserDay";
            this.txtSetReserDay.Size = new System.Drawing.Size(100, 21);
            this.txtSetReserDay.TabIndex = 18;
            this.txtSetReserDay.Text = "15";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "读者预借资料有效期：";
            // 
            // dudCommonNuber
            // 
            this.dudCommonNuber.Items.Add("1");
            this.dudCommonNuber.Items.Add("2");
            this.dudCommonNuber.Items.Add("3");
            this.dudCommonNuber.Items.Add("4");
            this.dudCommonNuber.Items.Add("5");
            this.dudCommonNuber.Items.Add("6");
            this.dudCommonNuber.Items.Add("7");
            this.dudCommonNuber.Items.Add("8");
            this.dudCommonNuber.Location = new System.Drawing.Point(261, 26);
            this.dudCommonNuber.Name = "dudCommonNuber";
            this.dudCommonNuber.ReadOnly = true;
            this.dudCommonNuber.Size = new System.Drawing.Size(44, 21);
            this.dudCommonNuber.TabIndex = 16;
            this.dudCommonNuber.Text = "4";
            // 
            // dudVipNumber
            // 
            this.dudVipNumber.Items.Add("4");
            this.dudVipNumber.Items.Add("5");
            this.dudVipNumber.Items.Add("6");
            this.dudVipNumber.Items.Add("7");
            this.dudVipNumber.Items.Add("8");
            this.dudVipNumber.Items.Add("9");
            this.dudVipNumber.Items.Add("10");
            this.dudVipNumber.Location = new System.Drawing.Point(198, 26);
            this.dudVipNumber.Name = "dudVipNumber";
            this.dudVipNumber.ReadOnly = true;
            this.dudVipNumber.Size = new System.Drawing.Size(44, 21);
            this.dudVipNumber.TabIndex = 15;
            this.dudVipNumber.Text = "10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "教师\\学生可借图书数目:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "元/天";
            // 
            // radbtnno
            // 
            this.radbtnno.AutoSize = true;
            this.radbtnno.Checked = true;
            this.radbtnno.Location = new System.Drawing.Point(261, 126);
            this.radbtnno.Name = "radbtnno";
            this.radbtnno.Size = new System.Drawing.Size(35, 16);
            this.radbtnno.TabIndex = 9;
            this.radbtnno.TabStop = true;
            this.radbtnno.Text = "否";
            this.radbtnno.UseVisualStyleBackColor = true;
            // 
            // radbtnyes
            // 
            this.radbtnyes.AutoSize = true;
            this.radbtnyes.Location = new System.Drawing.Point(220, 126);
            this.radbtnyes.Name = "radbtnyes";
            this.radbtnyes.Size = new System.Drawing.Size(35, 16);
            this.radbtnyes.TabIndex = 8;
            this.radbtnyes.Text = "是";
            this.radbtnyes.UseVisualStyleBackColor = true;
            // 
            // txtSetMoney
            // 
            this.txtSetMoney.Location = new System.Drawing.Point(170, 56);
            this.txtSetMoney.Name = "txtSetMoney";
            this.txtSetMoney.Size = new System.Drawing.Size(100, 21);
            this.txtSetMoney.TabIndex = 7;
            this.txtSetMoney.Text = "0.2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "启动是否自动显示到期/超期信息：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "图书借阅超期罚款金额：";
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(191, 202);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(75, 23);
            this.butOk.TabIndex = 2;
            this.butOk.Text = "确定(&O)";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // butClose
            // 
            this.butClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butClose.Location = new System.Drawing.Point(293, 202);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(75, 23);
            this.butClose.TabIndex = 3;
            this.butClose.Text = "取消(&C)";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::图书馆管理系统.Properties.Resources.xitongshezhi;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmSystemSet
            // 
            this.AcceptButton = this.butOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butClose;
            this.ClientSize = new System.Drawing.Size(472, 235);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSystemSet";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "参数设置";
            this.Load += new System.EventHandler(this.frmSystemSet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSetMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSetReserDay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DomainUpDown dudCommonNuber;
        private System.Windows.Forms.DomainUpDown dudVipNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radbtnno;
        private System.Windows.Forms.RadioButton radbtnyes;
        private System.Windows.Forms.Label label4;
    }
}