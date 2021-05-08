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
    public partial class frmReaderBorrow : Form
    {
        public frmReaderBorrow()
        {
            InitializeComponent();
        }
        private void frmReaderBorrow_Load(object sender, EventArgs e)
        {
            DBHelper.getCon();
            DBHelper.getCmd();
            string ReaderName = frmReaderCheck.ReaderName;     //获得读者卡的编号
            string sql = "select Number 流水编号,CardID 借书证号,ReaderName 读者姓名,BookID 图书编号,BookName 图书名称,Author 图书作者,Publisher 出版社,Price 图书价格,BorrowDate 借书日期,BorrowNumber 借书数量,UserName 操作员,BroTieme 借阅时长,IsOverdue 是否超期 FROM Borrow WHERE ReaderName='" + ReaderName + "'";       //用获得的读者卡号搜索相应的记录
            DBHelper.fill(sql, "Borrow");
            dgvBorInfo.DataSource = DBHelper.ds.Tables["Borrow"];
        }
        public static string BookID, BookName, BookAuhor, BookPblisher, BookPrice, BorrowNumber;
        private void butOk_Click(object sender, EventArgs e)
        {
            BookID=dgvBorInfo.SelectedCells[3].Value.ToString();
            BookName=dgvBorInfo.SelectedCells[4].Value.ToString();
            BookAuhor=dgvBorInfo.SelectedCells[5].Value.ToString();
            BookPblisher=dgvBorInfo.SelectedCells[6].Value.ToString();
            BookPrice=dgvBorInfo.SelectedCells[7].Value.ToString();
            BorrowNumber = dgvBorInfo.SelectedCells[9].Value.ToString();
            this.Close();
        }

        private void dgvBorInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            butOk_Click(sender, e);
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ShowInfo("select Number 流水编号,CardID 借书证号,ReaderName 读者姓名,BookID 图书编号,BookName 图书名称,Author 图书作者,Publisher 出版社,Price 图书价格,BorrowDate 借书日期,BorrowNumber 借书数量,UserName 操作员,BroTieme 借阅时长,IsOverdue 是否超期 FROM Borrow WHERE(BookName LIKE '%" + textBox1.Text.Trim() + "%')");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ShowInfo("select Number 流水编号,CardID 借书证号,ReaderName 读者姓名,BookID 图书编号,BookName 图书名称,Author 图书作者,Publisher 出版社,Price 图书价格,BorrowDate 借书日期,BorrowNumber 借书数量,UserName 操作员,BroTieme 借阅时长,IsOverdue 是否超期 FROM Borrow WHERE(BookID LIKE '%" + textBox2.Text.Trim() + "%')");
        }
        private void ShowInfo(string sql)
        {
            DataSet dsb;
            {
                dsb = DBHelper.ds2(sql);
                dgvBorInfo.DataSource = dsb;
                dgvBorInfo.DataMember = dsb.Tables[0].ToString();
            }
        }
    }
}
