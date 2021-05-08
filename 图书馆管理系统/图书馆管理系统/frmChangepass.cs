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
    public partial class frmChangepass : Form
    {
        public frmChangepass()
        {
            InitializeComponent();
        }

        private void frmChangepass_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            txtOldpass.Focus();
            txtOldpass.SelectAll();
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            if (txtOldpass.Text == "" || txtNewpass.Text == "" || txtRepass.Text == "")
            {
                MessageBox.Show("输入信息不能为空!", "修改提示");
                txtOldpass.Focus();
                txtOldpass.SelectAll();
            }
            else
            {
                if (txtOldpass.Text != frmlogin.passWord)
                {
                    MessageBox.Show("您输入的旧密码不正确!", "修改提示");
                    txtOldpass.Focus();
                    txtOldpass.SelectAll();
                }
                else
                {
                    if (txtNewpass.Text != txtRepass.Text)
                    {
                        MessageBox.Show("两次输入的新密码不一致!", "修改提示");
                        txtNewpass.Focus();
                        txtNewpass.SelectAll();
                    }
                    else
                    {
                        if (txtNewpass.Text.Length < 5 || txtNewpass.Text.Length > 16)
                        {
                            MessageBox.Show("密码长度不符合规定,请重新输入!", "修改提示");
                            txtNewpass.Focus();
                            txtNewpass.SelectAll();
                        }
                        else
                        {
                            string Strsql = "update Users set u_Pass='" + txtNewpass.Text + "'where u_Name='" + frmlogin.userName + "'";
                            int number = DBHelper.ExeInfochange(Strsql);
                            if (number > 0)
                            {
                                frmlogin.passWord = txtNewpass.Text.Trim();
                                MessageBox.Show("密码修改成功!", "修改提示");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("密码修改失败!", "修改提示");
                                this.Close();
                            }
                        }
                    }
                }
            }
        }
    }
}
