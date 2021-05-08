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
    public partial class frmOverdueInfo : Form
    {
        public frmOverdueInfo()
        {
            InitializeComponent();
        }
        string Sql = "select Number 编号,CardID 借书证号,ReaderName 读者姓名,BookID 图书编号,BookName 图书名,Author 作者,Publisher 出版社,Price 价格,BorrowDate 借书日期,BorrowNumber 借书数量,UserName 操作用户,SpilthDay 超期天数 from OverdueInfo";
        private void frmOverdueInfo_Load(object sender, EventArgs e)
        {
            //获得屏幕的大小,并设置窗体初始化时的大小
            Rectangle rect = System.Windows.Forms.SystemInformation.VirtualScreen;
            this.Width = rect.Width - 123;
            this.Height = rect.Height - 157;
            DBHelper.InfoShow(Sql, dgvOverdueInfo);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            string Number = dgvOverdueInfo.SelectedCells[0].Value.ToString();         //获得记录的流水编号 
            if (MessageBox.Show("是否当真删除编号为'" + Number + "'的信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string Strsql = "delete from OverdueInfo where Number='" + Number + "'";
                if (DBHelper.ExeInfochange(Strsql) == 1)
                {
                    DBHelper.InfoShow("" + Sql + "", dgvOverdueInfo);
                }
            }
        }

        private void tsbReflesh_Click(object sender, EventArgs e)
        {
            DBHelper.InfoShow("" + Sql + "", dgvOverdueInfo);
        }

        private void tsbToExcel_Click(object sender, EventArgs e)
        {
            DBHelper.ShowDgvInfo(dgvOverdueInfo, true);
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtReaderIDorName_TextChanged(object sender, EventArgs e)
        {
            DBHelper.InfoShow("" + Sql + " where ((CardID like '%" + txtReaderIDorName.Text + "%') or (ReaderName like '%" + txtReaderIDorName.Text + "%'))", dgvOverdueInfo);
        }

        private void txtBookIDorName_TextChanged(object sender, EventArgs e)
        {
            DBHelper.InfoShow("" + Sql + " where ((BookID like '%" + txtBookIDorName.Text.Trim() + "%') or (BookName like '%" + txtBookIDorName.Text.Trim() + "%'))", dgvOverdueInfo);
        }

        private void frmOverdueInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                tsbReflesh_Click(sender, e);
            }
        }

        private void frmOverdueInfo_Resize(object sender, EventArgs e)
        {
            //窗口大小变化
            groupBox1.Width = this.Width - 25;
            groupBox2.Width = this.Width - 25;
            groupBox2.Height = this.Height - 150;
            dgvOverdueInfo.Width = this.Width - 37;
            dgvOverdueInfo.Height = this.Height - 175;
        }
    }
}
