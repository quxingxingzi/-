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
    public partial class frmlogin : Form
    {
        private bool showing = true;
        Point p;
        bool flags = false;
        public frmlogin()
        {
            InitializeComponent();
            //窗体显示特效 7 　　
            Opacity = 0.0; //窗体透明度为0 8 　　
            fadeTimer.Start(); //计时开始
        }
        public static string userName;
        public static string passWord;
        public static string type;
        
        //取消按钮
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        //登陆按钮
        private void btnLogin_Click(object sender, EventArgs e)
        {
            userName = comboBoxUser.Text;
            passWord = txtPassword.Text;
            string SqlType = "select u_Type from Users where u_Name='" + comboBoxUser.Text + "'";
            DBHelper.openCon();
            DBHelper.query(SqlType);
            DBHelper.dr.Read();
            type = DBHelper.dr["u_Type"].ToString();
            DBHelper.closeCon();
            if (ValidateInput())
            {
                try
                {
                    DBHelper.openCon();
                    string sql = "select count(*) from Users where u_Name ='" + userName + "'and u_Pass ='" + passWord.Trim() + "'and u_Type='" + type + "'and u_Stopuser='否'";
                    sql = string.Format(sql, userName, passWord, type);
                    int count = (int)DBHelper.Scalar(sql);
                    if (count > 0)
                    {
                        DBHelper.closeCon();
                        this.Hide();
                        frmMain fm = new frmMain();
                        fm.Show();
                    }
                    else
                    {
                        MessageBox.Show("密码错误,请重新输入!", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comboBoxUser.Text = "";
                        txtPassword.Text = "";
                        txtPassword.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    DBHelper.closeCon(); // 关闭数据库连接
                }
            }
        }
        // 用户输入验证
        private bool ValidateInput()
        {
            // 验证用户输入
            if (comboBoxUser.Text.Trim() == "")
            {
                MessageBox.Show("请输入登录的用户名", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxUser.Focus();
                return false;
            }
            else if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
                return false;
            }
            return true;
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            DBHelper.getCon();
            DBHelper.getCmd();
            DBHelper.ShowInfoList("select * from Users where u_Stopuser='否'", "u_Name", comboBoxUser);
            this.AcceptButton = btnLogin;
        }

        private void btnOsk_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
            txtPassword.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmlogin_MouseDown(object sender, MouseEventArgs e)
        {
            p = new Point(e.X, e.Y);
            flags = true;
        }

        private void frmlogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (flags == true)
            {
                Point pp = Control.MousePosition;  //获取当前光标的坐标（相对于屏幕左上角）
                pp.Offset(-p.X, -p.Y);
                this.Location = pp;
            }
        }

        private void frmlogin_MouseUp(object sender, MouseEventArgs e)
        {
            flags = false;
        }

        private void fadeTimer_Tick(object sender, EventArgs e)
        {
            double d = 0.03;
            if (showing)
            {
                if (Opacity + d >= 1.0)
                {
                    Opacity = 1.0;
                    fadeTimer.Stop();
                }
                else
                {
                    Opacity += d;
                }
            }
            else
            {
                if (Opacity - d <= 0.0)
                {
                    Opacity = 0.0;
                    fadeTimer.Stop();
                }
                else
                {
                    Opacity -= d;
                }
            }
        }

    }
}
