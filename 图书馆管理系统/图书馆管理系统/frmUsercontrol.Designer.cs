namespace 图书馆管理系统
{
    partial class frmUsercontrol
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
            this.comboxUsertype = new System.Windows.Forms.ComboBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtRepass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvUserselect = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.butExit = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butSuerAdd = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserselect)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboxUsertype);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtRepass);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加用户";
            // 
            // comboxUsertype
            // 
            this.comboxUsertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxUsertype.FormattingEnabled = true;
            this.comboxUsertype.Items.AddRange(new object[] {
            "系统管理员",
            "图书管理员"});
            this.comboxUsertype.Location = new System.Drawing.Point(255, 52);
            this.comboxUsertype.Name = "comboxUsertype";
            this.comboxUsertype.Size = new System.Drawing.Size(102, 20);
            this.comboxUsertype.TabIndex = 7;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(255, 18);
            this.txtPass.MaxLength = 16;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(102, 21);
            this.txtPass.TabIndex = 6;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // txtRepass
            // 
            this.txtRepass.Location = new System.Drawing.Point(78, 52);
            this.txtRepass.MaxLength = 16;
            this.txtRepass.Name = "txtRepass";
            this.txtRepass.PasswordChar = '*';
            this.txtRepass.Size = new System.Drawing.Size(100, 21);
            this.txtRepass.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(78, 18);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 21);
            this.txtUsername.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "用户类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "确认密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvUserselect);
            this.groupBox2.Location = new System.Drawing.Point(12, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 211);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查看/删除用户";
            // 
            // dgvUserselect
            // 
            this.dgvUserselect.AllowUserToAddRows = false;
            this.dgvUserselect.AllowUserToDeleteRows = false;
            this.dgvUserselect.AllowUserToResizeRows = false;
            this.dgvUserselect.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUserselect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUserselect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserselect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.u_pass,
            this.Column3,
            this.Column4});
            this.dgvUserselect.Location = new System.Drawing.Point(4, 15);
            this.dgvUserselect.MultiSelect = false;
            this.dgvUserselect.Name = "dgvUserselect";
            this.dgvUserselect.ReadOnly = true;
            this.dgvUserselect.RowTemplate.Height = 23;
            this.dgvUserselect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserselect.Size = new System.Drawing.Size(355, 190);
            this.dgvUserselect.TabIndex = 0;
            this.dgvUserselect.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserselect_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "u_Name";
            this.Column1.HeaderText = "用户名";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // u_pass
            // 
            this.u_pass.DataPropertyName = "u_Pass";
            this.u_pass.HeaderText = "用户密码";
            this.u_pass.Name = "u_pass";
            this.u_pass.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "u_Type";
            this.Column3.HeaderText = "用户类型";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "u_Stopuser";
            this.Column4.HeaderText = "是否停用";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.butExit);
            this.groupBox3.Controls.Add(this.butDelete);
            this.groupBox3.Controls.Add(this.butSuerAdd);
            this.groupBox3.Controls.Add(this.butCancel);
            this.groupBox3.Controls.Add(this.butAdd);
            this.groupBox3.Location = new System.Drawing.Point(398, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(111, 188);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(15, 154);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(83, 28);
            this.butExit.TabIndex = 4;
            this.butExit.Text = "确认退出(&E)";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(15, 118);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(83, 28);
            this.butDelete.TabIndex = 3;
            this.butDelete.Text = "确认删除(&D)";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butSuerAdd
            // 
            this.butSuerAdd.Location = new System.Drawing.Point(15, 84);
            this.butSuerAdd.Name = "butSuerAdd";
            this.butSuerAdd.Size = new System.Drawing.Size(83, 28);
            this.butSuerAdd.TabIndex = 2;
            this.butSuerAdd.Text = "确认添加(&S)";
            this.butSuerAdd.UseVisualStyleBackColor = true;
            this.butSuerAdd.Click += new System.EventHandler(this.butSuerAdd_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(15, 50);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(83, 28);
            this.butCancel.TabIndex = 1;
            this.butCancel.Text = "取消添加(&C)";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(15, 16);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(83, 28);
            this.butAdd.TabIndex = 0;
            this.butAdd.Text = "选择添加(&A)";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::图书馆管理系统.Properties.Resources.nowuser;
            this.pictureBox1.Location = new System.Drawing.Point(398, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10F);
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(64, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "单击作部标头按钮,选定用户,然后对其进行编辑!";
            // 
            // frmUsercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 359);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmUsercontrol";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.frmUsercontrol_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmUsercontrol_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserselect)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboxUsertype;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtRepass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvUserselect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butSuerAdd;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}