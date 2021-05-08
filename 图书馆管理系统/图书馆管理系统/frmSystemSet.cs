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
    public partial class frmSystemSet : Form
    {
        public frmSystemSet()
        {
            InitializeComponent();
        }

        private void frmSystemSet_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您将修改系统数据,是否继续？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dudCommonNuber.Text.Length == 0 || dudVipNumber.Text.Length == 0 || txtSetMoney.Text.Length == 0 || txtSetReserDay.Text.Length == 0)
                {
                    MessageBox.Show("数据不能为空,请重新填写！", "提示");
                }
                else
                {
                    if (radbtnyes.Checked==true)
                    {
                        //执行更新语句
                         string sql="update SystemSet set TeaBroNumber='" + dudVipNumber.Text.Trim() + "',StuBroNumber='" + dudCommonNuber.Text.Trim() + "',PayMoney='" + txtSetMoney.Text.Trim() + "',SetReserDay='" + txtSetReserDay.Text.Trim() + "',IsOpenOverdue='是'";
                         DBHelper.nonQuery(sql);
                    }
                    else
                    {
                        //执行更新语句
                        string sql="update SystemSet set TeaBroNumber='" + dudVipNumber.Text.Trim() + "',StuBroNumber='" + dudCommonNuber.Text.Trim() + "',PayMoney='" + txtSetMoney.Text.Trim() + "',SetReserDay='" + txtSetReserDay.Text.Trim() + "',IsOpenOverdue='否'";
                        DBHelper.nonQuery(sql);
                    }
                    this.dudCommonNuber.Text = dudCommonNuber.Text.Trim();
                    this.dudVipNumber.Text = dudVipNumber.Text.Trim();
                    this.txtSetMoney.Text = txtSetMoney.Text.Trim();
                    this.txtSetReserDay.Text = txtSetReserDay.Text.Trim();
                    this.radbtnyes.Checked = radbtnyes.Checked;
                    this.Close();
                }
            }
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
