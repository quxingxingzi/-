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
    public partial class frmBookCorA : Form
    {
        public frmBookCorA()
        {
            InitializeComponent();
        }
        frmPublishing fpl = new frmPublishing();

        private void butSure_Click(object sender, EventArgs e)
        {
            if (txtBookID.Text.Length == 0 || txtBookName.Text.Length == 0 || txtBookAhour.Text.Length == 0)
            {
                MessageBox.Show("图书编号、图书名称、图书作者均不能为空！", "提示");
            }
            else
            {
                try
                {
                    // DateTime time = Convert.ToDateTime(DateTime.Now.ToString());
                    if (this.Text == "图书管理(修改)")
                    {
                        txtBookID.ReadOnly = true;
                        if (MessageBox.Show("您将修改图书编号为：'" + txtBookID.Text.Trim() + "'的信息,是否继续？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (DBHelper.ExeInfochange("update Book set BookID='" + txtBookID.Text.Trim() + "',Strichcode='" + txtBookCode.Text.Trim() + "',SlassificationID='" + txtSlassificationID.Text.Trim() + "',BookName='" + txtBookName.Text.Trim() + "',Type1='" + cmbBookType.Text.Trim() + "',Author='" + txtBookAhour.Text.Trim() + "',Translator='" + txtTranslator.Text.Trim() + "',ISBN='" + txtISBN.Text.Trim() + "',Publisher='" + txtBookPublisher.Text.Trim() + "',Revision='" + cmbRevision.Text.Trim() + "',Format='" + cmbFormat.Text.Trim() + "',Word='" + txtBookWord.Text.Trim() + "',Page='" + txtBookPage.Text.Trim() + "',Price='" + txtBookPrice.Text.Trim() + "',EnterTime ='" + dateTimePicker1.Text.Trim() + "',Qty='" + txtQty.Text.Trim() + "',Extant='" + txtBookExtant.Text.Trim() + "',Circulate='" + cmbCirculate.Text.Trim() + "' where BookID='" + txtBookID.Text.Trim() + "'") == 1)
                            {
                                DBHelper.ExeInfochange("update Borrow set BookName='" + txtBookName.Text.Trim() + "',Author='" + txtBookAhour.Text.Trim() + "',Publisher='" + txtBookPublisher.Text.Trim() + "',Price=" + txtBookPrice.Text.Trim() + " where BookID='" + txtBookID.Text.Trim() + "'");
                                DBHelper.ExeInfochange("update OverdueInfo set BookName='" + txtBookName.Text.Trim() + "',Author='" + txtBookAhour.Text.Trim() + "',Publisher='" + txtBookPublisher.Text.Trim() + "',Price=" + txtBookPrice.Text.Trim() + " where BookID='" + txtBookID.Text.Trim() + "'");
                                DBHelper.ExeInfochange("update HandleNote set BookName='" + txtBookName.Text.Trim() + "',Price=" + txtBookPrice.Text.Trim() + " where BookStrichcode='" + txtBookID.Text.Trim() + "'");
                                DBHelper.ExeInfochange("update ReserBroInfo set r_BookType='" + cmbBookType.Text.Trim() + "',r_BookName='" + txtBookName.Text.Trim() + "',r_BookAuthor='" + txtBookAhour.Text.Trim() + "',r_BookPrice=" + txtBookPrice.Text.Trim() + " where r_BookId='" + txtBookID.Text.Trim() + "'");
                                DBHelper.ExeInfochange("update Borrow set BookName='" + txtBookName.Text.Trim() + "' where BookID='" + txtBookID.Text.Trim() + "'");
                                DBHelper.ExeInfochange("update RenewNote set BookName='" + txtBookName.Text.Trim() + "',Author='" + txtBookAhour.Text.Trim() + "',Publisher='" + txtBookPublisher.Text.Trim() + "',Price=" + txtBookPrice.Text.Trim() + " where BookID='" + txtBookID.Text.Trim() + "'");

                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("数据格式不合法,图书修改失败!", "提示");
                            }
                        }
                    }
                    if (this.Text == "图书管理(添加)")
                    {
                        if (MessageBox.Show("您将添加图书名为：'" + txtBookName.Text.Trim() + "'的信息,是否继续？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            DBHelper.getCon();
                            DBHelper.getCmd();
                            string SqlMax = "select max(Number) from Book";
                            DBHelper.openCon();
                            int number = Convert.ToInt32(DBHelper.Scalar(SqlMax)) + 1;
                            if (DBHelper.ExeInfochange("insert into Book values(" + number + ",'" + txtBookID.Text.Trim() + "','" + txtBookCode.Text.Trim() + "','" + txtSlassificationID.Text.Trim() + "','" + txtBookName.Text.Trim() + "','" + cmbBookType.Text.Trim() + "','" + txtBookAhour.Text.Trim() + "','" + txtTranslator.Text.Trim() + "','" + txtISBN.Text.Trim() + "','" + txtBookPublisher.Text.Trim() + "','" + cmbRevision.Text.Trim() + "','" + cmbFormat.Text.Trim() + "','" + txtBookWord.Text.Trim() + "','" + txtBookPage.Text.Trim() + "','" + txtBookPrice.Text.Trim() + "','" + dateTimePicker1.Text.Trim() + "','" + txtQty.Text.Trim() + "','" + txtBookExtant.Text.Trim() + "','" + cmbCirculate.Text.Trim() + "')") == 1)
                            {
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("此图书已存在或数据不合法,添加失败!", "提示");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void frmBookCorA_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            cmbCirculate.SelectedIndex = 0;
            if (this.Text == "图书管理(修改)")
            {
                txtBookID.ReadOnly = true;
                groupBox1.Text = "修改图书";
                #region 获取数值
                this.txtBookID.Text = frmBookManage.BookID1;
                this.txtBookName.Text = frmBookManage.BookName;
                this.txtBookAhour.Text = frmBookManage.Author;
                this.txtBookCode.Text = frmBookManage.Strichcode;
                this.txtSlassificationID.Text = frmBookManage.SlassificationID;
                this.cmbBookType.Text = frmBookManage.Type1;
                this.txtBookPublisher.Text = frmBookManage.Publisher;
                this.txtTranslator.Text = frmBookManage.Translator;
                this.txtISBN.Text = frmBookManage.ISBN;
                this.cmbRevision.Text = frmBookManage.Revision;
                this.cmbFormat.Text = frmBookManage.Format;
                this.txtBookWord.Text = frmBookManage.Word;
                this.txtBookPage.Text = frmBookManage.Page;
                this.txtBookPrice.Text = frmBookManage.Price;
                this.dateTimePicker1.Text = frmBookManage.EnterTime;
                this.txtQty.Text = frmBookManage.Qty;
                this.txtBookExtant.Text = frmBookManage.Extant;
                //this.txtBookCirculate.Text = frmBookManage.Circulate;
                #endregion
            }
            if (this.Text == "图书管理(添加)")
            {
                groupBox1.Text = "添加图书";
            }
            if (frmBookManage.Circulate == "True")
            {
                cmbCirculate.Text = "1";
            }
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butPublishing_Click(object sender, EventArgs e)
        {
            fpl.ShowDialog();
            txtBookPublisher.Text = fpl.PulName;
        }
    }
}
