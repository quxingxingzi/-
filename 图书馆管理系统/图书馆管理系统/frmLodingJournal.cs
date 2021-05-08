using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 图书馆管理系统
{
    public partial class frmLodingJournal : Form
    {
        public frmLodingJournal()
        {
            InitializeComponent();
        }

        private void tsbReflesh_Click(object sender, EventArgs e)
        {
            InfoShow("select Number 登录编号,JournalName 登录名,Status 登录身份,EnterTime 登录时间 FROM Journal where JournalName='" + cmbUser.Text.Trim() + "' order by Number");
        }
        public void InfoShow(string Sql)     //实现刷新
        {
            DBHelper.InfoShow(Sql, dgvJournal);
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLodingJournal_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            DBHelper.ShowInfoList("select * from Users", "u_Name", cmbUser);                          //以下拉的形式显示所有用户名
            InfoShow("select Number 登录编号,JournalName 登录名,Status 登录身份,EnterTime 登录时间 FROM Journal where JournalName='" + cmbUser.Text.Trim() + "' order by Number");
            dgvJournal_Click(sender, e);
        }

        private void cmbUser_TextChanged(object sender, EventArgs e)
        {
            InfoShow("select Number 登录编号,JournalName 登录名,Status 登录身份,EnterTime 登录时间 from Journal where JournalName='" + cmbUser.Text.Trim() + "'order by Number");
        }

        private void dgvJournal_Click(object sender, EventArgs e)
        {
            try
            {
                string EnterTime = dgvJournal.SelectedCells[3].Value.ToString();     //获得进入系统的时间
                txtTime.Text = EnterTime;
            }
            catch
            {
                txtTime.Text = null;
            }
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbUser_TextChanged(sender, e);
        }
    }
}
