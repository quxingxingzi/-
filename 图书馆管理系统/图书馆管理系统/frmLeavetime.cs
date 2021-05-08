using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 图书馆管理系统
{
    public partial class frmLeavetime : Form
    {
        public frmLeavetime()
        {
            InitializeComponent();
        }

        private void frmLeavetime_Load(object sender, EventArgs e)
        {
            txtUsername.Text = frmlogin.userName;
        }

        public void CheckPass()
        {
            if (txtPass.Text == "")
            {
                MessageBox.Show("输入错误,密码不能为空！", "提示");
                txtPass.Focus();
            }
            else
            {
                if (txtPass.Text != frmlogin.passWord)
                {
                    MessageBox.Show("输入错误,密码验证失败！", "提示");
                    txtPass.Focus();
                    txtPass.SelectAll();
                }
                else
                {
                    if (txtPass.Text == frmlogin.passWord)
                    {
                        this.Close();
                    }
                }
            }
        }

        private void butOk_Click_1(object sender, EventArgs e)
        {
            CheckPass();
        }
    }
}
