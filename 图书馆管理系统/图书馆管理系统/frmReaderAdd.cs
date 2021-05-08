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
    public partial class frmReaderAdd : Form
    {
        public frmReaderAdd()
        {
            InitializeComponent();
        }
        private void frmReaderAdd_Load(object sender, EventArgs e)
        {
            cmbReadertype.SelectedIndex = 0;
            cmbStatu.SelectedIndex = 0;
            rbtMan.Checked = true;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length == 0 || txtName.Text.Length == 0)
            {
                MessageBox.Show("借书证号和读者姓名为必填项！", "提示");   //借书证号和姓名为必填项
                txtNumber.Focus();
                txtNumber.SelectAll();
            }
            else
            {
                if (MessageBox.Show("您将添加一位读者,是否继续？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {

                        DBHelper.getCon();
                        DBHelper.getCmd();
                        string SqlMax = "select Max(Number) from Reader";
                        DBHelper.openCon();
                        int Number = Convert.ToInt32(DBHelper.Scalar(SqlMax)) + 1;
                        string sex;
                        if (rbtMan.Checked == true)
                        {
                            sex = "男";
                        }
                        else
                        {
                            sex = "女";
                        }
                        // 添加读者的信息
                        string sql = "insert into Reader values (" + Number + ",'" + txtNumber.Text.Trim() + "','" + txtName.Text.Trim() + "','0','" + txtIDNumber.Text.Trim() + "','" + cmbReadertype.Text.Trim() + "','" + cmbStatu.Text.Trim() + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + sex + "','" + txtWorkshop.Text.Trim() + "','" + txtPhoneNumber.Text + "')";
                        if (DBHelper.ExeInfochange(sql) == 1)
                        {

                            MessageBox.Show("读者信息添加成功！", "提示");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("数据长度不符合要求,读者信息添加失败！", "提示");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
