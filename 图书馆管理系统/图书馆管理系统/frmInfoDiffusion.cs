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
    public partial class frmInfoDiffusion : Form
    {
        public frmInfoDiffusion()
        {
            InitializeComponent();
        }

        private void frmInfoDiffusion_Load(object sender, EventArgs e)
        {
            btnAdd.Visible = false;
            btnRevise.Visible = false;
            DBHelper.getCon();
            DBHelper.getCmd();
            string sql = "select Information from Information";
            string Information = Convert.ToString(DBHelper.Scalar(sql));
            tbxInformation.Text = Information;
        }
        public void loadRulesData()
        {
            DBHelper.getCon();
            DBHelper.getCmd();
            DBHelper.openCon();
            //加载数据到列表视图listView前先把之前的数据清空
            listView1.Items.Clear();
            try
            {
                DBHelper.cmd.CommandText = "select * from Rules";
                SqlDataReader dr = null;
                //ExecuteReader方法执行查询语句，返回一个数据读取对象
                dr = DBHelper.cmd.ExecuteReader(); ;

                //定义变量保存数据库取出的每列数据
                string RulesTitle, RulesContent;
                int i = 0;
                //循环读取每行数据
                while (dr.Read())
                {
                    RulesTitle = dr["RulesTitle"].ToString();
                    RulesContent = dr["RulesContent"].ToString();

                    //构建字符串数组，保存表里各列的数据
                    string[] str = { RulesTitle, RulesContent};

                    //根据字符串数组构建ListViewItem
                    ListViewItem lvi = new ListViewItem(str, i++);

                    //将ListViewItem添加到listView上
                    listView1.Items.Add(lvi);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.closeCon();
            }
            
        }

        public void loadMessageData()
        {
            DBHelper.getCon();
            DBHelper.getCmd();
            DBHelper.openCon();
            //加载数据到列表视图listView前先把之前的数据清空
            listView2.Items.Clear();
            try
            {
                DBHelper.cmd.CommandText = "select * from Announcement";
                SqlDataReader dr = null;
                //ExecuteReader方法执行查询语句，返回一个数据读取对象
                dr = DBHelper.cmd.ExecuteReader(); ;

                //定义变量保存数据库取出的每列数据
                string AnnouncementTitle, AnnouncementContent;
                int i = 0;
                //循环读取每行数据
                while (dr.Read())
                {
                    AnnouncementTitle = dr["AnnouncementTitle"].ToString();
                    AnnouncementContent = dr["AnnouncementContent"].ToString();

                    //构建字符串数组，保存表里各列的数据
                    string[] str = { AnnouncementTitle, AnnouncementContent };

                    //根据字符串数组构建ListViewItem
                    ListViewItem lvi = new ListViewItem(str, i++);

                    //将ListViewItem添加到listView上
                    listView2.Items.Add(lvi);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.closeCon();
            }

        }

        private void tbcBackstage_Click(object sender, EventArgs e)
        {
            if (tbcBackstage.SelectedIndex == 1 || tbcBackstage.SelectedIndex == 2)
            {
                btnAdd.Visible = true;
                btnRevise.Visible = true;
                btnTow.Text = "删除(&D)";
            }
            if (tbcBackstage.SelectedIndex == 0)
            {
                btnAdd.Visible = false;
                btnRevise.Visible = false;
                btnTow.Text = "应用(&S)";
            }
            if (tbcBackstage.SelectedIndex == 1)
            {
                loadRulesData();
            }
            if (tbcBackstage.SelectedIndex == 2)
            {
                loadMessageData();
            }
        }

        private void btnTow_Click(object sender, EventArgs e)
        {
            if (btnTow.Text == "应用(&S)")
            {
                int number = DBHelper.ExeInfochange("update Information set Information='" + tbxInformation.Text + "'");
                if (number > 0)
                {
                    MessageBox.Show("信息应用成功!", "应用提示");
                }
                else
                {
                    MessageBox.Show("信息应用失败!", "应用提示");
                }
            }
            else
            {
                ;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbcBackstage.SelectedIndex == 1)
            {
                frmInfoDiffusionAdd fida = new frmInfoDiffusionAdd();
                fida.Text = "添加规章";
                fida.Show();
            }
            if (tbcBackstage.SelectedIndex == 2)
            {
                frmInfoDiffusionAdd fida = new frmInfoDiffusionAdd();
                fida.Text = "添加公告";
                fida.Show();
            }
        }

        private void btnRevise_Click(object sender, EventArgs e)
        {
            if (tbcBackstage.SelectedIndex == 1)
            {
                frmInfoDiffusionAdd fida = new frmInfoDiffusionAdd();
                fida.Text = "修改规章";
                fida.Show();
            }
            if (tbcBackstage.SelectedIndex == 2)
            {
                frmInfoDiffusionAdd fida = new frmInfoDiffusionAdd();
                fida.Text = "修改公告";
                fida.Show();
            }
        }
    }
}
