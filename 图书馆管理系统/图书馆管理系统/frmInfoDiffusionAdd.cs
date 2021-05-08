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
    public partial class frmInfoDiffusionAdd : Form
    {
        public frmInfoDiffusionAdd()
        {
            InitializeComponent();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            //string Title, Content;
            //Title = txtTitle.Text;
            //Content = txtContent.Text;
            if (this.Text == "添加规章")
            {
                if (txtTitle.Text != "" && txtContent.Text != "")
                {
                    try
                    {
                        DBHelper.getCon();
                        DBHelper.getCmd();
                        string sql = "insert into Rules values ('" + txtTitle.Text + "','" + txtContent.Text + "')";
                        if (DBHelper.ExeInfochange(sql) == 1)
                        {

                            MessageBox.Show("规章信息添加成功！", "系统提示");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("规章信息添加失败！", "系统提示");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("标题和内容不能为空！", "系统提示");
                }
            }
            else
            {
                if (txtTitle.Text != "" && txtContent.Text != "")
                {
                    try
                    {
                        DBHelper.getCon();
                        DBHelper.getCmd();
                        string sql = "insert into Announcement values ('" + txtTitle.Text + "','" + txtContent.Text + "')";
                        if (DBHelper.ExeInfochange(sql) == 1)
                        {

                            MessageBox.Show("公告信息添加成功！", "系统提示");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("公告信息添加失败！", "系统提示");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else 
                {
                    MessageBox.Show("标题和内容不能为空！", "系统提示");
                }
            }
        }
    }
}
