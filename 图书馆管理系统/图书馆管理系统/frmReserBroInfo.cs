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
    public partial class frmReserBroInfo : Form
    {
        public frmReserBroInfo()
        {
            InitializeComponent();
        }
        string Sql = "select r_Number 编号,r_BookId 图书编号,r_BookName 图书名称,r_BookAuthor 图书作者,r_ReaderId 读者编号,r_ReaderName 读者姓名,r_ReaderSex 读者性别,r_BookNumber 预借数量,r_BookPrice 图书价格,r_Publisher 出版社,r_HandleUsr 操作用户,r_ReadyTime 预借时间 from ReserBroInfo";

        private void frmReserBroInfo_Load(object sender, EventArgs e)
        {
            //获得屏幕的大小,并设置窗体初始化时的大小
            Rectangle rect = System.Windows.Forms.SystemInformation.VirtualScreen;
            this.Width = rect.Width - 123;
            this.Height = rect.Height - 157;
            cmbCheckList.SelectedIndex = 0;
            DBHelper.InfoShow(Sql, dgvReserBroInfo);
        }

        private void tsbReflesh_Click(object sender, EventArgs e)
        {
            string time = DBHelper.GetTime(9);
            if (cmbCheckList.Text.Trim() == "所有预借记录")
            {
                DBHelper.InfoShow("" + Sql + "", dgvReserBroInfo);
            }
            if (cmbCheckList.Text.Trim() == "今天预借记录")
            {
                DBHelper.InfoShow("" + Sql + " where r_ReadyTime like'%" + time + "%'", dgvReserBroInfo);
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            string time1 = DBHelper.GetTime(3);   //获得现在时间
            string Number, BookID, BookName, CardId,ReaderName;        
            Number = dgvReserBroInfo.SelectedCells[0].Value.ToString();         //获得记录的流水编号 
            BookID= dgvReserBroInfo.SelectedCells[1].Value.ToString(); 
            BookName= dgvReserBroInfo.SelectedCells[2].Value.ToString();
            CardId = dgvReserBroInfo.SelectedCells[4].Value.ToString();
            ReaderName = dgvReserBroInfo.SelectedCells[5].Value.ToString();
            //获得系统参数中的数据
            int BroNumber, BookStore;
            DBHelper.getCon();
            DBHelper.getCmd();
            DBHelper.openCon();
            string sql1 = "select BorrowNumber from Reader where CardID='" + CardId + "'";
            string sql2 = "select Extant from Book where BookID='" + BookID + "'";
            BroNumber = Convert.ToInt32(DBHelper.Scalar(sql1));         //获得读者表中已借的数量
            BookStore = Convert.ToInt32(DBHelper.Scalar(sql2));        //获得图书表中的可借出数量
            DBHelper.closeCon();
            if (MessageBox.Show("是否当真取消编号为'" + Number + "'的预借？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string Strsql = "delete from ReserBroInfo where r_Number='" + Number + "'";
                if (DBHelper.ExeInfochange(Strsql) == 1)
                {
                    DBHelper.InfoShow("" + Sql + "", dgvReserBroInfo);
                }
                //删除借阅表中的记录
                int Hang = DBHelper.ExeInfochange("delete from Borrow Where BookID='" + BookID + "'and CardID='" + CardId + "'");
                //向借阅流水表中添加一条记录
                string SqlMax = "select Max(HandleNumber) from HandleNote";
                DBHelper.getCon();
                DBHelper.getCmd();
                DBHelper.openCon();
                int Number2 = Convert.ToInt32(DBHelper.Scalar(SqlMax)) + 1;
                DBHelper.ExeInfochange("insert into HandleNote values (" + Number2 + ",'取消预借','" + frmlogin.userName.Trim() + "','" + BookName + "','" + BookID + "','" + CardId + "','" + ReaderName + "','" + time1 + "')");

                int ReBookQty = BookStore + Hang;     //更新图书表中的可出借数量
                int ReReaderQty = BroNumber - Hang;      //更新读者已借阅图书的数量
                //更新图书表中图书的可借数量
                DBHelper.ExeInfochange("update Book set Extant=" + ReBookQty + " where BookID='" + BookID + "'");
                //更新读者表中已借图书的数量
                DBHelper.ExeInfochange("update Reader set BorrowNumber=" + ReReaderQty + " where CardID='" + CardId + "'");
                //更新读者已借的图书数量和图书馆藏数量
                MessageBox.Show("取消成功！", "提示");
            }
        }

        private void cmbCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            tsbReflesh_Click(sender, e);
        }

        private void tsbToExcel_Click(object sender, EventArgs e)
        {
            DBHelper.ShowDgvInfo(dgvReserBroInfo, true);
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtReaderIDorName_TextChanged(object sender, EventArgs e)
        {
            string time = DBHelper.GetTime(9);
            if (cmbCheckList.Text.Trim() == "今天预借记录")
            {
                DBHelper.InfoShow("" + Sql + " where ((r_ReaderId like '%" + txtReaderIDorName.Text + "%') or (r_ReaderName like '%" + txtReaderIDorName.Text + "%')) and  r_ReadyTime like '%" + time + "%'", dgvReserBroInfo);
            }
            if (cmbCheckList.Text.Trim() == "所有预借记录")
            {
                DBHelper.InfoShow("" + Sql + " where ((r_ReaderId like '%" + txtReaderIDorName.Text + "%') or (r_ReaderName like '%" + txtReaderIDorName.Text + "%'))", dgvReserBroInfo);
            }
        }

        private void txtBookIDorName_TextChanged(object sender, EventArgs e)
        {
            string time = DBHelper.GetTime(9);
            if (cmbCheckList.Text.Trim() == "今天预借记录")
            {
                DBHelper.InfoShow("" + Sql + "  where ((r_BookName like '%" + txtBookIDorName.Text.Trim() + "%') or (r_BookId like '%" + txtBookIDorName.Text.Trim() + "%'))and r_ReadyTime like '" + time + "%' order by r_Number", dgvReserBroInfo);
            }
            if (cmbCheckList.Text.Trim() == "所有预借记录")
            {
                DBHelper.InfoShow("" + Sql + " where ((r_BookName like '%" + txtBookIDorName.Text.Trim() + "%') or (r_BookId like '%" + txtBookIDorName.Text.Trim() + "%'))", dgvReserBroInfo);
            }
        }

        private void frmReserBroInfo_Resize(object sender, EventArgs e)
        {
            //窗口大小变化
            groupBox1.Width = this.Width - 25;
            groupBox2.Width = this.Width - 25;
            groupBox2.Height = this.Height - 150;
            dgvReserBroInfo.Width = this.Width - 37;
            dgvReserBroInfo.Height = this.Height - 175;
        }

        private void frmReserBroInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                tsbReflesh_Click(sender, e);
            }
        }

        private void tsbToBorrow_Click(object sender, EventArgs e)
        {
            string Number = dgvReserBroInfo.SelectedCells[0].Value.ToString();         //获得记录的流水编号 
            if (MessageBox.Show("是否借出编号为'" + Number + "'的信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string Strsql = "delete from ReserBroInfo where r_Number='" + Number + "'";
                if (DBHelper.ExeInfochange(Strsql) == 1)
                {
                    DBHelper.InfoShow("" + Sql + "", dgvReserBroInfo);
                }
                MessageBox.Show("图书已借出！");
            }
        }
    }
}
