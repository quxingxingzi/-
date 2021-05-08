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
    public partial class frmPubChange : Form
    {
        public frmPubChange()
        {
            InitializeComponent();
        }
        private void frmPubChange_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            txtNumber.ReadOnly = true;

            if (this.Text == "出版社信息(增加)")
            {
                DBHelper.getCon();
                DBHelper.getCmd();
                string SqlMax = "select Max(PulNumber) from Publishing";
                DBHelper.openCon();
                int Number = Convert.ToInt32(DBHelper.ExecuteSelect(SqlMax)) + 1;
                txtNumber.Text =Convert.ToString(Number);
                DBHelper.closeCon();
            }
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Length == 0)
                {
                    MessageBox.Show("出版社名称不能为空,请重新输入！", "提示");
                }
                else
                {
                    if (this.Text == "出版社信息(增加)")
                    {
                        DBHelper.ExeInfochange("insert into Publishing values ('" + txtNumber.Text.Trim() + "','" + txtName.Text.Trim() + "','" + txtAdress.Text.Trim() + "','" + txtShuoming.Text.Trim() + "')");
                        MessageBox.Show("'" + txtName.Text.Trim() + "'信息增加成功！", "提示");
                    }
                    if (this.Text == "出版社信息(修改)")
                    {
                        DBHelper.ExeInfochange("update Publishing set PulName='" + txtName.Text.Trim() + "',PulAdress='" + txtAdress.Text.Trim() + "',PulExplain='" + txtShuoming.Text.Trim() + "'where PulNumber='" + txtNumber.Text.Trim() + "'");
                        MessageBox.Show("'" + txtName.Text.Trim() + "'信息修改成功！", "提示");
                    }
                }
            }
            catch
            {
                MessageBox.Show("添加失败,据长度过长,请重新输入！", "提示");
            }
            this.Close();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
