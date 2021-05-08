using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 图书馆管理系统
{
    public partial class frmBookManage : Form
    {
        public frmBookManage()
        {
            InitializeComponent();
        }

        private void frmBookManage_Load(object sender, EventArgs e)
        {
            //获得屏幕的大小,并设置窗体初始化时的大小
            Rectangle rect = System.Windows.Forms.SystemInformation.VirtualScreen;
            this.Width = rect.Width - 135;
            this.Height = rect.Height - 157;
            cmbSelect.SelectedIndex = 0;
            ShowAll();
            GetInfo();
            dgvBookManger_Click(sender, e);
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ShowAll()     //实现刷新
        {
            DataSet dsBookManage;
            string strSql = "SELECT Number 流水编号,BookID 图书编号,Strichcode 条形码,SlassificationID 图书分类,BookName 图书名称,Type1 图书类型,Author 图书作者,Translator 图书译者,ISBN ISBN码,Publisher 出版社,Revision 图书版次,Format 图书开本,Word 图书字数,Page 图书页码,Price 图书价格,EnterTime 入馆时间,Qty 库存数目,Extant 可借数量,Circulate 是否流通 FROM Book order by Number";
            dsBookManage = DBHelper.ds2(strSql);
            dgvBookManger.DataSource = dsBookManage;
            dgvBookManger.DataMember = dsBookManage.Tables[0].ToString();
        }
        public static string BookID1, Strichcode, SlassificationID, BookName, Type1, Author, Translator, ISBN, Publisher, Revision, Format, Word, Page, Price, EnterTime, Qty, Extant, Circulate;
        public void GetInfo()    //获得数据
        {
            #region  获得数据
            try
            {
                BookID1 = dgvBookManger.SelectedCells[1].Value.ToString();
                Strichcode = dgvBookManger.SelectedCells[2].Value.ToString();
                SlassificationID = dgvBookManger.SelectedCells[3].Value.ToString();
                BookName = dgvBookManger.SelectedCells[4].Value.ToString();
                Type1 = dgvBookManger.SelectedCells[5].Value.ToString();
                Author = dgvBookManger.SelectedCells[6].Value.ToString();
                Translator = dgvBookManger.SelectedCells[6].Value.ToString();
                ISBN = dgvBookManger.SelectedCells[8].Value.ToString();
                Publisher = dgvBookManger.SelectedCells[9].Value.ToString();
                Revision = dgvBookManger.SelectedCells[10].Value.ToString();
                Format = dgvBookManger.SelectedCells[11].Value.ToString();
                Word = dgvBookManger.SelectedCells[12].Value.ToString();
                Page = dgvBookManger.SelectedCells[13].Value.ToString();
                Price = dgvBookManger.SelectedCells[14].Value.ToString();
                EnterTime = dgvBookManger.SelectedCells[15].Value.ToString();
                Qty = dgvBookManger.SelectedCells[16].Value.ToString();
                Extant = dgvBookManger.SelectedCells[17].Value.ToString();
                Circulate = dgvBookManger.SelectedCells[18].Value.ToString();
            }
            catch (Exception ex)
            {
                if (ex.Message != null)
                    MessageBox.Show("没有数数据！","系统提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            #endregion
        }

        private void txtSelectOrder_TextChanged(object sender, EventArgs e)
        {
            try
            {
                {
                    DataSet dsm;
                    {
                        string strsql = "SELECT Number 流水编号,BookID 图书编号,Strichcode 条形码,SlassificationID 图书分类,BookName 图书名称,Type1 图书类型,Author 图书作者,Translator 图书译者,ISBN ISBN码,Publisher 出版社,Revision 图书版次,Format 图书开本,Word 图书字数,Page 图书页码,Price 图书价格,EnterTime 入馆时间,Qty 库存数目,Extant 可借数量,Circulate 是否流通 FROM Book WHERE(BookName LIKE '%" + txtSelectOrder.Text.Trim() + "%') or(Author LIKE '%" + txtSelectOrder.Text.Trim() + "%')or(ISBN LIKE '%" + txtSelectOrder.Text.Trim() + "%') order by Number";
                        dsm = DBHelper.ds2(strsql);
                        dgvBookManger.DataSource = dsm;
                        dgvBookManger.DataMember = dsm.Tables[0].ToString();
                    }
                }

            }
            catch (Exception)
            {
                return;
            }
        }

        private void dgvBookManger_Click(object sender, EventArgs e)
        {
            try
            {
                string BookID = dgvBookManger.SelectedCells[1].Value.ToString();     //获得图书的编号
                if (tabPage1.Text == "当前借阅状态")
                {
                    DataSet bookinfo;
                    {
                        string strbook = "select Number 流水编号,CardID 借书证号,ReaderName 读者姓名,BookID 图书编号,BookName 图书名称,Author 图书作者,Publisher 出版社,Price 图书价格,BorrowDate 借书日期,BorrowNumber 借书数量,UserName 操作员,BroTieme 借阅时长,IsOverdue 是否超期 FROM Borrow WHERE BookID ='" + BookID.Trim() + "'";       //用获得的图书编号搜索相应的记录
                        bookinfo = DBHelper.ds2(strbook);
                        dgvBookStatue.DataSource = bookinfo;
                        dgvBookStatue.DataMember = bookinfo.Tables[0].ToString();
                    }
                }
                if (tabPage2.Text == "借阅历史")
                {
                    string strSql = "select HandleNumber 操作编号,BookName 图书名称,BookStrichcode 图书编号,ReaderID 读者编号,ReaderName 读者姓名,ReaderSex 读者性别,BookNumber 借书数量,BookPrice 图书价格,HandleDate 操作日期 from HandleNote where BookStrichcode='" + BookID.Trim() + "'";
                    DBHelper.InfoShow("" + strSql + "", dgvBorrowList);
                }
            }
            catch (Exception)
            {
                return;
            }
            GetInfo();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string BookID = dgvBookManger.SelectedCells[1].Value.ToString();   //获得图书的编号  
                if (MessageBox.Show("当真删除编号为'" + BookID.Trim() + "'的记录？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sql = "delete from Book where BookID='" + BookID.Trim() + "'";    //用获得的姓名去删除相应的记录
                    if (DBHelper.ExeInfochange(sql) == 1)
                    {
                        ShowAll();
                    }
                    else
                    {
                        MessageBox.Show("图书信息删除失败,请重试！", "提示");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("图书信息删除失败！", "提示");
            }
        }

        private void tsbReflsh_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void tsbToexcel_Click(object sender, EventArgs e)
        {
                DBHelper.ShowDgvInfo(dgvBookManger, true);
                DBHelper.ShowDgvInfo(dgvBookStatue, true);
                DBHelper.ShowDgvInfo(dgvBorrowList, true);
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            frmBookCorA fbca = new frmBookCorA();
            fbca.Text = "图书管理(添加)";
            fbca.ShowDialog();
            ShowAll();
        }

        private void tsbChange_Click(object sender, EventArgs e)
        {
            frmBookCorA fbca = new frmBookCorA();
            fbca.Text = "图书管理(修改)";
            fbca.ShowDialog();
            ShowAll();
        }

        private void dgvBookManger_DoubleClick(object sender, EventArgs e)
        {
            frmBookCorA fbca = new frmBookCorA();
            fbca.Text = "图书管理(修改)";
            fbca.ShowDialog();
        }

        private void dgvBookManger_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(97))
            {
                ShowAll();
            }
        }

        private void tsbReflshe_Click(object sender, EventArgs e)
        {
            ShowAll();
            dgvBookManger_Click(sender, e);
        }

        private void tsmChange_Click(object sender, EventArgs e)
        {
            tsbChange_Click(sender, e);
        }

        private void tsmAdd_Click(object sender, EventArgs e)
        {
            tsbAdd_Click(sender, e);
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            tsbDelete_Click(sender, e);
        }

        private void tsbExitform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBookManage_Resize(object sender, EventArgs e)
        {
            groupBox1.Width = this.Width - 20;
            groupBox2.Width = this.Width - 20;
            //groupBox2.Height = this.Height - 350;
            tabControl1.Width = this.Width - 20;
            tabControl1.Height = this.Height - 455;
            dgvBookManger.Width = this.Width - 33;
            dgvBookStatue.Width = this.Width - 37;
            dgvBookStatue.Height = this.Height - 487;
        }

        private void butSelect_Click(object sender, EventArgs e)
        {
            if (cmbSelect.Text=="全部图书")
            {
                ShowAll();
            }
            if (cmbSelect.Text=="已借完的图书")
            {
                DataSet dsBookManage;
                string strSql = "SELECT Number 流水编号,BookID 图书编号,Strichcode 条形码,SlassificationID 图书分类,BookName 图书名称,Type1 图书类型,Author 图书作者,Translator 图书译者,ISBN ISBN码,Publisher 出版社,Revision 图书版次,Format 图书开本,Word 图书字数,Page 图书页码,Price 图书价格,EnterTime 入馆时间,Qty 库存数目,Extant 可借数量,Circulate 是否流通 FROM Book where Extant=0";
                dsBookManage = DBHelper.ds2(strSql);
                dgvBookManger.DataSource = dsBookManage;
                dgvBookManger.DataMember = dsBookManage.Tables[0].ToString();
            }
            if (cmbSelect.Text=="已被预借的图书")
            {
                DataSet dsBookManage;
                string strSql = "SELECT Number 流水编号,BookID 图书编号,Strichcode 条形码,SlassificationID 图书分类,BookName 图书名称,Type1 图书类型,Author 图书作者,Translator 图书译者,ISBN ISBN码,Publisher 出版社,Revision 图书版次,Format 图书开本,Word 图书字数,Page 图书页码,Price 图书价格,EnterTime 入馆时间,Qty 库存数目,Extant 可借数量,Circulate 是否流通 FROM Book where Extant=0";
                dsBookManage = DBHelper.ds2(strSql);
                dgvBookManger.DataSource = dsBookManage;
                dgvBookManger.DataMember = dsBookManage.Tables[0].ToString();
            }
            if (cmbSelect.Text=="已出借且超期的图书")
            {
                ShowAll();
            }
        }
    }
}
