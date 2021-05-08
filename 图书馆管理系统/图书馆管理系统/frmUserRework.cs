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
    public partial class frmUserRework : Form
    {
        public frmUserRework()
        {
            InitializeComponent();
        }

        private void frmUserRework_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            cmbStatue.SelectedIndex = 0;
            cmbType.SelectedIndex = 1;
            this.txtUsername.Text = frmUsercontrol.User;
            this.txtPassWord.Text = frmUsercontrol.Pass;
            this.cmbType.Text = frmUsercontrol.Type;
            this.cmbStatue.Text = frmUsercontrol.Statue;
            this.txtRepass.Text = frmUsercontrol.Pass;
        }

        private void butRework_Click(object sender, EventArgs e)
        {
            if (txtPassWord.Text.Trim() == txtRepass.Text.Trim())
            {
                if (txtUsername.Text.Length > 5 && txtUsername.Text.Length < 20 || txtPassWord.Text.Length < 16 && txtPassWord.Text.Length > 5)
                {
                    try
                    {
                        //修改用户信息
                        if (MessageBox.Show("您将修改用户'" + frmUsercontrol.User + "'的信息,是否继续？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            frmlogin.passWord = txtPassWord.Text.Trim();
                            DBHelper.ExeInfochange("update Users set u_Name='" + txtUsername.Text.Trim() + "',u_Pass='" + txtPassWord.Text.Trim() + "',u_Type='" + cmbType.Text.Trim() + "',u_Stopuser='" + cmbStatue.Text.Trim() + "'where u_Name='" + frmUsercontrol.User + "'");
                            DBHelper.ExeInfochange("update Borrow set UserName='" + txtUsername.Text.Trim() + "' where UserName='" + frmUsercontrol.User + "'");
                            DBHelper.ExeInfochange("update OverdueInfo set UserName='" + txtUsername.Text.Trim() + "' where UserName='" + frmUsercontrol.User + "'");
                            DBHelper.ExeInfochange("update Backupinfo set lodUser='" + txtUsername.Text.Trim() + "' where UserName='" + frmUsercontrol.User + "'");
                            DBHelper.ExeInfochange("update HandleNote set HandleUser='" + txtUsername.Text.Trim() + "' where UserName='" + frmUsercontrol.User + "'");
                            DBHelper.ExeInfochange("update ReserBroInfo set r_HandleUsr='" + txtUsername.Text.Trim() + "' where UserName='" + frmUsercontrol.User + "'");
                            DBHelper.ExeInfochange("update PenaltryInfo set HandleUser='" + txtUsername.Text.Trim() + "' where UserName='" + frmUsercontrol.User + "'");
                            DBHelper.ExeInfochange("update RenewNote set UserName='" + txtUsername.Text.Trim() + "' where UserName='" + frmUsercontrol.User + "'");

                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("密码长度不符合要求,请重新输入！", "提示");
                }
            }
            else
            {
                MessageBox.Show("两次密码不一致,请重新输入！", "提示");
            }
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
