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
    public partial class frmDataDelete : Form
    {
        public frmDataDelete()
        {
            InitializeComponent();
        }

        private void frmDataDelete_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void rdbCheckAll_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
            checkBox5.Checked = true;
            checkBox6.Checked = true;
            checkBox7.Checked = true;
            checkBox8.Checked = true;
            checkBox9.Checked = true;
            checkBox10.Checked = true;
            checkBox11.Checked = true;
            checkBox12.Checked = true;
            checkBox13.Checked = true;
        }

        private void rbdCheckNone_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
        }

        private void rbdCheckObv_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = !checkBox1.Checked;
            checkBox2.Checked = !checkBox2.Checked;
            checkBox3.Checked = !checkBox3.Checked;
            checkBox4.Checked = !checkBox4.Checked;
            checkBox5.Checked = !checkBox5.Checked;
            checkBox6.Checked = !checkBox6.Checked;
            checkBox7.Checked = !checkBox7.Checked;
            checkBox8.Checked = !checkBox8.Checked;
            checkBox9.Checked = !checkBox9.Checked;
            checkBox10.Checked = !checkBox10.Checked;
            checkBox11.Checked = !checkBox11.Checked;
            checkBox12.Checked = !checkBox12.Checked;
            checkBox13.Checked = !checkBox13.Checked;
        }

        private void tsbOk_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您在对数据进行初始化,是否继续？", "敬告", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int number = 0;   //记录所选表的个数
                string Str = null;

                #region  判断是否选中表格 有则删除选中表的信息

                if (checkBox1.Checked  == true)
                {
                    DBHelper.ExeInfochange("delete from Book");
                    number++;
                    Str = Str + " 图书表";
                }
                if (checkBox2.Checked == true)
                {
                    DBHelper.ExeInfochange("delete from Reader");
                    number++;
                    Str = Str + " 读者表";
                }
                if (checkBox3.Checked == true)
                {
                    DBHelper.ExeInfochange("delete from Borrow");
                    number++;
                    Str = Str + " 借阅表";
                }
                if (checkBox4.Checked == true)
                {
                    DBHelper.ExeInfochange("delete from Users");
                    number++;
                    Str = Str + " 用户表";
                }
                if (checkBox5.Checked == true)
                {
                    DBHelper.ExeInfochange("delete from OverdueInfo");
                    number++;
                    Str = Str + " 超期表";
                }
                if (checkBox6.Checked == true)
                {
                    DBHelper.ExeInfochange("delete from RenewNote");
                    number++;
                    Str = Str + " 续借表";
                }
                if (checkBox7.Checked == true)
                {
                    DBHelper.ExeInfochange("delete from ReserBroInfo");
                    number++;
                    Str = Str + " 预借表";
                }
                if (checkBox8.Checked == true)
                {
                    DBHelper.ExeInfochange("delete from Publishing");
                    number++;
                    Str = Str + " 出版社表";
                }
                if (checkBox9.Checked == true)
                {
                    DBHelper.ExeInfochange("delete from HandleNote");
                    number++;
                    Str = Str + " 操作日志表";
                }
                if (checkBox10.Checked == true)
                {
                    DBHelper.ExeInfochange("delete from PenaltryInfo");
                    number++;
                    Str = Str + " 罚款表";
                }
                if (checkBox11.Checked == true)
                {
                    DBHelper.ExeInfochange("delete from Backupinfo");
                    number++;
                    Str = Str + " 备份信息表";
                }
                if (checkBox12.Checked == true)
                {
                    DBHelper.ExeInfochange("delete from Journal");
                    number++;
                    Str = Str + " 登录信息表";
                }
                if (checkBox13.Checked == true)
                {
                    DBHelper.ExeInfochange("delete from Remind");
                    number++;
                    Str = Str + " 备忘表";
                }

                #endregion

                if (number == 0)
                {
                    MessageBox.Show("请先选择表,再进行初始化！", "提示");
                }
                else
                {
                    MessageBox.Show("您已成功删除了 " + Str + " \n\n" +number+" 个表的所有数据！", "提示");
                }
            }
            this.Close();
        }
    }
}
