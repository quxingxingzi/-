namespace 图书馆管理系统
{
    partial class frmInfoDiffusion
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
            this.tbcBackstage = new System.Windows.Forms.TabControl();
            this.tbpInformation = new System.Windows.Forms.TabPage();
            this.tbxInformation = new System.Windows.Forms.TextBox();
            this.tapRules = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clhTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhContent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tapAnnouncement = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.clhTitle2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhContent2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnTow = new System.Windows.Forms.Button();
            this.btnRevise = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbcBackstage.SuspendLayout();
            this.tbpInformation.SuspendLayout();
            this.tapRules.SuspendLayout();
            this.tapAnnouncement.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcBackstage
            // 
            this.tbcBackstage.Controls.Add(this.tbpInformation);
            this.tbcBackstage.Controls.Add(this.tapRules);
            this.tbcBackstage.Controls.Add(this.tapAnnouncement);
            this.tbcBackstage.Location = new System.Drawing.Point(2, 1);
            this.tbcBackstage.Name = "tbcBackstage";
            this.tbcBackstage.SelectedIndex = 0;
            this.tbcBackstage.Size = new System.Drawing.Size(480, 391);
            this.tbcBackstage.TabIndex = 0;
            this.tbcBackstage.Click += new System.EventHandler(this.tbcBackstage_Click);
            // 
            // tbpInformation
            // 
            this.tbpInformation.Controls.Add(this.tbxInformation);
            this.tbpInformation.Location = new System.Drawing.Point(4, 22);
            this.tbpInformation.Name = "tbpInformation";
            this.tbpInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInformation.Size = new System.Drawing.Size(472, 365);
            this.tbpInformation.TabIndex = 0;
            this.tbpInformation.Text = "本馆概况";
            this.tbpInformation.UseVisualStyleBackColor = true;
            // 
            // tbxInformation
            // 
            this.tbxInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxInformation.Location = new System.Drawing.Point(3, 3);
            this.tbxInformation.Multiline = true;
            this.tbxInformation.Name = "tbxInformation";
            this.tbxInformation.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxInformation.Size = new System.Drawing.Size(466, 359);
            this.tbxInformation.TabIndex = 0;
            // 
            // tapRules
            // 
            this.tapRules.Controls.Add(this.listView1);
            this.tapRules.Location = new System.Drawing.Point(4, 22);
            this.tapRules.Name = "tapRules";
            this.tapRules.Padding = new System.Windows.Forms.Padding(3);
            this.tapRules.Size = new System.Drawing.Size(472, 365);
            this.tapRules.TabIndex = 1;
            this.tapRules.Text = "规章信息";
            this.tapRules.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhTitle,
            this.clhContent});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(466, 359);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clhTitle
            // 
            this.clhTitle.Text = "          标题";
            this.clhTitle.Width = 150;
            // 
            // clhContent
            // 
            this.clhContent.Text = "                    内容";
            this.clhContent.Width = 350;
            // 
            // tapAnnouncement
            // 
            this.tapAnnouncement.Controls.Add(this.listView2);
            this.tapAnnouncement.Location = new System.Drawing.Point(4, 22);
            this.tapAnnouncement.Name = "tapAnnouncement";
            this.tapAnnouncement.Padding = new System.Windows.Forms.Padding(3);
            this.tapAnnouncement.Size = new System.Drawing.Size(472, 365);
            this.tapAnnouncement.TabIndex = 2;
            this.tapAnnouncement.Text = "最新公告";
            this.tapAnnouncement.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhTitle2,
            this.clhContent2});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.Location = new System.Drawing.Point(3, 3);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(466, 359);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // clhTitle2
            // 
            this.clhTitle2.Text = "          标题";
            this.clhTitle2.Width = 150;
            // 
            // clhContent2
            // 
            this.clhContent2.Text = "                    内容";
            this.clhContent2.Width = 350;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(507, 365);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "退出(&Q)";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnTow
            // 
            this.btnTow.Location = new System.Drawing.Point(507, 336);
            this.btnTow.Name = "btnTow";
            this.btnTow.Size = new System.Drawing.Size(75, 23);
            this.btnTow.TabIndex = 2;
            this.btnTow.Text = "应用(&S)";
            this.btnTow.UseVisualStyleBackColor = true;
            this.btnTow.Click += new System.EventHandler(this.btnTow_Click);
            // 
            // btnRevise
            // 
            this.btnRevise.Location = new System.Drawing.Point(507, 307);
            this.btnRevise.Name = "btnRevise";
            this.btnRevise.Size = new System.Drawing.Size(75, 23);
            this.btnRevise.TabIndex = 3;
            this.btnRevise.Text = "修改(&M)";
            this.btnRevise.UseVisualStyleBackColor = true;
            this.btnRevise.Click += new System.EventHandler(this.btnRevise_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(507, 278);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "新增(&A)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmInfoDiffusion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 396);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRevise);
            this.Controls.Add(this.btnTow);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbcBackstage);
            this.Name = "frmInfoDiffusion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客户端后台信息发布";
            this.Load += new System.EventHandler(this.frmInfoDiffusion_Load);
            this.tbcBackstage.ResumeLayout(false);
            this.tbpInformation.ResumeLayout(false);
            this.tbpInformation.PerformLayout();
            this.tapRules.ResumeLayout(false);
            this.tapAnnouncement.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcBackstage;
        private System.Windows.Forms.TabPage tbpInformation;
        private System.Windows.Forms.TabPage tapRules;
        private System.Windows.Forms.TabPage tapAnnouncement;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnTow;
        private System.Windows.Forms.Button btnRevise;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxInformation;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clhTitle;
        private System.Windows.Forms.ColumnHeader clhContent;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader clhTitle2;
        private System.Windows.Forms.ColumnHeader clhContent2;
    }
}