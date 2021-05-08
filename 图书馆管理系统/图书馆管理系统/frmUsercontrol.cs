using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 图书馆管理系统
{
    public partial class frmUsercontrol : Form
    {
        public frmUsercontrol()
        {
            InitializeComponent();
        }
        string name;
        private void frmUsercontrol_Load(object sender, EventArgs e)
        {
            DBHelper.getCon();
            DBHelper.getCmd();
            //控件的可用性的设置
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            txtUsername.Enabled = false;
            txtPass.Enabled = false;
            txtRepass.Enabled = false;
            comboxUsertype.Enabled = false;
            comboxUsertype.SelectedIndex = 0;
            butSuerAdd.Enabled = false;
            butCancel.Enabled = false;
            Reflesh();
        }
        public void Reflesh()   //刷新数据
        {
            //调用DBHelper类的fill方法查询取数据填充到数据集里
            DBHelper.fill("select * from Users", "Users");
            //将数据集的表绑定显示在dgvUserselect上
            dgvUserselect.DataSource = DBHelper.ds.Tables["Users"];
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            try
            {
                name = dgvUserselect.SelectedCells[0].Value.ToString();
                //如果选中的是自己,那么提示不能删除
                if (frmlogin.userName == name)
                {
                    MessageBox.Show("删除错误,不能删除自己!", "提示");
                }
                else
                {
                    if (MessageBox.Show("您将删除'" + name + "'用户,是否继续？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string Sql = "delete from Users where u_Name='" + name + "'";
                        DBHelper.nonQuery(Sql);
                        //刷新数据
                        Reflesh();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butSuerAdd_Click(object sender, EventArgs e)
        {
            //控件的可用性的设置
            comboxUsertype.SelectedIndex = 0;
            butSuerAdd.Enabled = false;
            butAdd.Enabled = true;
            txtUsername.Enabled = false;
            txtPass.Enabled = false;
            txtRepass.Enabled = false;
            comboxUsertype.Enabled = false;
            butCancel.Enabled = false;
            if (txtUsername.Text.Length < 0 || txtUsername.Text.Length > 20 || txtPass.Text.Length < 5 || txtPass.Text.Length > 16 || txtPass.Text.Length == 0 || txtRepass.Text.Length < 5 || txtRepass.Text.Length > 16 || txtRepass.Text.Length == 0)
            {
                MessageBox.Show("密码长度不符合规定,请重新输入!", "提示");
                txtUsername.Clear();
                txtPass.Clear();
                txtRepass.Clear();
            }
            else
            {
                if (txtPass.Text != txtRepass.Text)
                {
                    MessageBox.Show("两次输入的密码不一致,请重新输入!", "提示");
                    //txtPass.Focus();
                    txtUsername.Clear();
                    txtPass.Clear();
                    txtRepass.Clear();
                }
                else
                {
                    try
                    {
                        if (MessageBox.Show("您将添加用户'" + txtUsername.Text.Trim() + "',是否继续？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SqlConnection Strconn1 = DBHelper.getCon();            
                            Strconn1.Open();                              //打开连接
                            string sqlName1 = "insert into Users values ('" + txtUsername.Text + "','" + txtPass.Text + "','" + comboxUsertype.Text + "','" + "否" + "')";
                            SqlCommand scomd1 = new SqlCommand(sqlName1, Strconn1);
                            scomd1.ExecuteNonQuery();
                            Strconn1.Close();
                            Reflesh(); //刷新数据  
                            txtUsername.Clear();
                            txtPass.Clear();
                            txtRepass.Clear();                                            
                            
                        }

                    }

                    catch (Exception c)
                    {
                        MessageBox.Show(c.Message);
                    }
                }
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            //控件的可用性的设置
            butCancel.Enabled = false;
            txtUsername.Enabled = false;
            txtPass.Enabled = false;
            txtRepass.Enabled = false;
            comboxUsertype.Enabled = false;
            comboxUsertype.SelectedIndex = 0;
            butSuerAdd.Enabled = false;
            butAdd.Enabled = true;
            txtUsername.Clear();
            txtPass.Clear();
            txtRepass.Clear();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            //控件的可用性的设置
            txtUsername.Enabled = true;
            txtPass.Enabled = true;
            txtRepass.Enabled = true;
            comboxUsertype.Enabled = true;
            butSuerAdd.Enabled = true;
            butAdd.Enabled = false;
            butCancel.Enabled = true;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
             SqlConnection Strconn = DBHelper.getCon();
              Strconn.Open();//打开连接
            try
            {
               
                string sqlName = "select u_Name from Users";
                SqlCommand com = new SqlCommand(sqlName, Strconn);
                com.ExecuteNonQuery();
                SqlDataReader sDR = com.ExecuteReader();
                while (sDR.Read())
                {
                    string name = sDR["u_Name"].ToString();
                    if (txtUsername.Text == name)
                    {
                        MessageBox.Show("用户名'" + txtUsername.Text.Trim() + "'已存在,请重新选择用户名!", "提示");
                        txtUsername.Focus();
                        txtUsername.SelectAll();
                        break;
                    }
                }
            }
            catch (Exception j)
            {
                MessageBox.Show(j.Message);
            }
            finally
            {
                if (Strconn != null)
                    Strconn.Close();
            }
        }
        public static string User, Pass, Type, Statue;

        private void dgvUserselect_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            User = dgvUserselect.SelectedCells[0].Value.ToString();
            Pass = dgvUserselect.SelectedCells[1].Value.ToString();
            Type = dgvUserselect.SelectedCells[2].Value.ToString();
            Statue = dgvUserselect.SelectedCells[3].Value.ToString();
            frmUserRework fur = new frmUserRework();
            fur.ShowDialog();
        }

        private void frmUsercontrol_Paint(object sender, PaintEventArgs e)
        {
            Reflesh();
        }

    }
}
