namespace 图书馆管理系统
{
    partial class frmlogin
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
            this.components = new System.ComponentModel.Container();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnOsk = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fadeTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("宋体", 12F);
            this.txtPassword.Location = new System.Drawing.Point(243, 242);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(127, 26);
            this.txtPassword.TabIndex = 4;
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBoxUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxUser.Font = new System.Drawing.Font("宋体", 12F);
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Items.AddRange(new object[] {
            "系统管理员",
            "图书管理员"});
            this.comboBoxUser.Location = new System.Drawing.Point(243, 189);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(157, 24);
            this.comboBoxUser.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogin.Font = new System.Drawing.Font("华文行楷", 13F);
            this.btnLogin.Location = new System.Drawing.Point(147, 307);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(65, 35);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "登  录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancle.Font = new System.Drawing.Font("华文行楷", 13F);
            this.btnCancle.Location = new System.Drawing.Point(274, 307);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(65, 35);
            this.btnCancle.TabIndex = 8;
            this.btnCancle.Text = "取  消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnOsk
            // 
            this.btnOsk.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnOsk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOsk.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOsk.Location = new System.Drawing.Point(370, 242);
            this.btnOsk.Name = "btnOsk";
            this.btnOsk.Size = new System.Drawing.Size(30, 26);
            this.btnOsk.TabIndex = 10;
            this.btnOsk.Text = "K";
            this.btnOsk.UseVisualStyleBackColor = false;
            this.btnOsk.Click += new System.EventHandler(this.btnOsk_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::图书馆管理系统.Properties.Resources.交叉;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(513, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 25);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // fadeTimer
            // 
            this.fadeTimer.Tick += new System.EventHandler(this.fadeTimer_Tick);
            // 
            // frmlogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::图书馆管理系统.Properties.Resources._3910250376464741521_副本;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(547, 385);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOsk);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.txtPassword);
            this.ForeColor = System.Drawing.Color.DarkViolet;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmlogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmlogin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmlogin_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancle;
        public System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnOsk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer fadeTimer;
    }
}