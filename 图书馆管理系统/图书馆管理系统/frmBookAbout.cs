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
    public partial class frmBookAbout : Form
    {
        public frmBookAbout()
        {
            InitializeComponent();
        }
        //定义、实例化
        frmReserBroInfo frb = new frmReserBroInfo();
        frmSystemSet fss = new frmSystemSet();
        public string ReaderID, BookID;
        private string Sql = "select HandleNumber 操作编号,Handletype 操作类型,HandleUser 操作用户,BookName 图书名称,BookStrichcode 图书编号,ReaderID 读者编号,ReaderName 读者姓名,ReaderSex 读者性别,BookNumber 借书数量,BookPrice 图书价格,HandleDate 操作日期 from HandleNote";
        private void frmBookAbout_Load(object sender, EventArgs e)
        {
            DBHelper.getCon();
            DBHelper.getCmd();
            cmbCheckList.SelectedIndex = 0;
            dupBookNumber.SelectedIndex = 0;
            dupBroTime.SelectedIndex = 2;
            //txtReader.ReadOnly = true;
            //txtBookName.ReadOnly = true;
            //获得屏幕的大小,并设置窗体初始化时的大小
            Rectangle rect = System.Windows.Forms.SystemInformation.VirtualScreen;
            this.Width = rect.Width - 135;
            this.Height = rect.Height - 160;
            string timeload = DBHelper.GetTime(9);
            string sql = "" + Sql + " where HandleDate like '%" + timeload + "%'";
            DBHelper.fill(sql, "HandleDate");
            dgvHandleInfo.DataSource = DBHelper.ds.Tables["HandleDate"];
        }
        private void loaddata()
        {
            DBHelper.getCon();
            DBHelper.getCmd();
            string timeload = DBHelper.GetTime(9);
            string sql = "" + Sql + " where HandleDate like '%" + timeload + "%'";
            DBHelper.fill(sql, "HandleDate");
            dgvHandleInfo.DataSource = DBHelper.ds.Tables["HandleDate"];
        }

        private void butCheckReader_Click(object sender, EventArgs e)
        {
            //弹出选择读者对话框
            try
            {
                frmReaderCheck frc = new frmReaderCheck();
                frc.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtReader.Text = frmReaderCheck.ReaderName;
            this.labCardId.Text =frmReaderCheck.CardId;
            this.labReaderName.Text = frmReaderCheck.ReaderName;
            this.labReaderTypeID.Text = frmReaderCheck.ReaderType;
            this.labSatue.Text = frmReaderCheck.Statue;
            this.labBroNumber.Text = frmReaderCheck.Borrownumber;
            this.labSex.Text = frmReaderCheck.ReaderSex;
        }

        private void butCheckbook_Click(object sender, EventArgs e)
        {
            //弹出选择图书对话框
            if (this.Text == "归还图书" || this.Text == "续借图书")
            {
                label17.Text = "借阅数量";
                labQty.Text = "借阅数量";
                if (this.labCardId.Text != "读者卡号")
                {
                    try
                    {
                        frmReaderBorrow frb = new frmReaderBorrow();     //弹出当前读者借阅图书对话框
                        frb.ShowDialog();
                        txtBookName.Text = frmReaderBorrow.BookName;
                        this.labBookID.Text = frmReaderBorrow.BookID;
                        this.labBookName.Text = frmReaderBorrow.BookName;
                        this.labAuthor.Text = frmReaderBorrow.BookAuhor;
                        this.labPublisher.Text = frmReaderBorrow.BookPblisher;
                        this.labPrice.Text = frmReaderBorrow.BookPrice;
                        this.labQty.Text = frmReaderBorrow.BorrowNumber;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("请先输入要归还图书的读者信息！");
                }
            }
            else
            {
                try
                {
                    frmBookCheck fbc = new frmBookCheck();     //弹出选择图书对话框
                    fbc.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txtBookName.Text = frmBookCheck.BookName;
                this.labBookID.Text = frmBookCheck.BookID;
                this.labBookName.Text = frmBookCheck.BookName;
                this.labAuthor.Text = frmBookCheck.BookAuhor;
                this.labPublisher.Text = frmBookCheck.BookPblisher;
                this.labPrice.Text = frmBookCheck.BookPrice;
                this.labQty.Text = frmBookCheck.Qty;
            }
        }

        private void frmBookAbout_Resize(object sender, EventArgs e)
        {
            panel1.Width = this.Width - 28;
            panel1.Height = this.Height - 281;
            panel4.Width = this.Width - 164;
            panel4.Height = this.Height - 380;
            panel5.Height = this.Height - 380;
            dgvHandleInfo.Width = this.Width - 175;
            dgvHandleInfo.Height = this.Height - 390;
        }

        private void txtCondition_TextChanged(object sender, EventArgs e)
        {
            butSearch_Click(sender, e);
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region   实现借书
        private void Borrow(int Txtnumber)
        {
            try
            {
                string time = System.DateTime.Now.ToShortDateString();        //获得今天的时间
                string time1 = DBHelper.GetTime(3);
                //获得系统参数中的数据
                int BroNumber, BookStore;
                DBHelper.getCon();
                DBHelper.getCmd();
                DBHelper.openCon();
                string sql1 = "select BorrowNumber from Reader where CardID='" + labCardId.Text.Trim() + "'";
                string sql2 = "select Extant from Book where BookID='" + labBookID.Text.Trim() + "'";
                BroNumber = Convert.ToInt32(DBHelper.Scalar(sql1));         //获得读者表中已借的数量
                BookStore = Convert.ToInt32(DBHelper.Scalar(sql2));        //获得图书表中的可借出数量
                DBHelper.closeCon();

                int ReBookQty = BookStore - 1;     //更新图书表中的可出借数量
                int ReReaderQty = BroNumber + 1;      //更新读者已借阅图书的数量

                if (labSatue.Text.Trim() == "有效")
                {
                    if (BroNumber < Txtnumber)
                    {
                        if (BookStore > 1)
                        {
                            string sql = "select * from ReserBroInfo where r_bookid='" + labBookID.Text + "' and r_readerid='" + labCardId.Text + "'";
                            if (Convert.ToInt32(DBHelper.Scalar(sql)) > 0)
                            {
                                frb.MaximizeBox = false;
                                frb.MinimizeBox = false;
                                frb.Location = new Point(150, 150);
                                frb.ShowDialog();
                            }
                            else
                            {
                                //向借阅表中添加一条记录
                                string SqlMax = "select Max(Number) from Borrow";
                                DBHelper.openCon();
                                int Number1 = Convert.ToInt32(DBHelper.Scalar(SqlMax)) + 1;
                                DBHelper.ExeInfochange("insert into Borrow values (" + Number1 + ",'" + labCardId.Text.Trim() + "','" + labReaderName.Text.Trim() + "','" + labBookID.Text.Trim() + "','" + labBookName.Text.Trim() + "','" + labAuthor.Text.Trim() + "','" + labPublisher.Text.Trim() + "','" + labPrice.Text.Trim() + "','" + time1 + "','" + dupBookNumber.Text.Trim() + "','" + frmlogin.userName.Trim() + "','" + dupBroTime.Text.Trim() + "','否')");
                                //向借阅流水表中添加一条记录
                                string SqlMax2 = "select Max(HandleNumber) from HandleNote";
                                DBHelper.getCon();
                                DBHelper.getCmd();
                                int Number2 = Convert.ToInt32(DBHelper.Scalar(SqlMax2)) + 1;
                                DBHelper.ExeInfochange("insert into HandleNote values (" + Number2 + ",'" + this.Text.Trim() + "','" + frmlogin.userName.Trim() + "','" + labBookName.Text.Trim() + "','" + labBookID.Text.Trim() + "','" + labCardId.Text.Trim() + "','" + labReaderName.Text.Trim() + "','" + labSex.Text.Trim() + "','" + dupBookNumber.Text.Trim() + "','" + labPrice.Text.Trim() + "','" + time1 + "')");
                                //更新图书表中图书的可借数量
                                DBHelper.ExeInfochange("update Book set Extant=" + ReBookQty + " where BookID='" + labBookID.Text.Trim() + "'");
                                //更新读者表中已借图书的数量
                                DBHelper.ExeInfochange("update Reader set BorrowNumber=" + ReReaderQty + " where CardID='" + labCardId.Text.Trim() + "'");

                                //更新读者已借的图书数量和图书馆藏数量
                                labBroNumber.Text = Convert.ToString(ReReaderQty);
                                labQty.Text = Convert.ToString(ReBookQty);
                                MessageBox.Show("借书成功！", "提示");
                                loaddata();
                            }
                        }
                        else
                        {
                            MessageBox.Show("最后样书,不能出借！", "提示");
                        }
                    }
                    else
                    {
                        MessageBox.Show("已达到最大借书数量,无法继续借阅！", "提示");
                    }
                }
                else
                {
                    MessageBox.Show("借书证处于无效状态,无法出借图书！", "提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region   实现预借
        private void ReserBorrow(int TxtNumber)
        {
            try
            {
                string time = System.DateTime.Now.ToShortDateString();     //获得今天的时间
                string time1 = DBHelper.GetTime(3);
                //获得系统参数中的数据
                int BroNumber, BookStore;
                DBHelper.getCon();
                DBHelper.getCmd();
                DBHelper.openCon();
                string sql1 = "select BorrowNumber from Reader where CardID='" + labCardId.Text.Trim() + "'";
                string sql2 = "select Extant from Book where BookID='" + labBookID.Text.Trim() + "'";
                BroNumber = Convert.ToInt32(DBHelper.Scalar(sql1));         //获得读者表中已借的数量
                BookStore = Convert.ToInt32(DBHelper.Scalar(sql2));        //获得图书表中的可借出数量
                DBHelper.closeCon();

                int ReBookQty = BookStore - 1;     //更新图书表中的可出借数量
                int ReReaderQty = BroNumber + 1;      //更新读者已借阅图书的数量

                if (labSatue.Text.Trim() == "有效")
                {
                    if (BroNumber < TxtNumber)
                    {
                        if (BookStore > 1)
                        {
                            //向预借表中添加一条记录
                            string SqlMax = "select Max(r_Number) from ReserBroInfo";
                            DBHelper.openCon();
                            int Number1 = Convert.ToInt32(DBHelper.Scalar(SqlMax)) + 1;
                            DBHelper.ExeInfochange("insert into ReserBroInfo values (" + Number1 + ",'" + labBookID.Text.Trim() + "','" + labBookName.Text.Trim() + "','" + labAuthor.Text.Trim() + "','" + labCardId.Text.Trim() + "','" + labReaderName.Text.Trim() + "','" + labSex.Text.Trim() + "','" + dupBookNumber.Text.Trim() + "','" + labPrice.Text.Trim() + "','" + labPublisher.Text.Trim() + "','" + frmlogin.userName.Trim() + "','" + time1 + "')");
                            //向操作流水表中添加一条记录
                            string SqlMax2 = "select Max(HandleNumber) from HandleNote";
                            DBHelper.getCon();
                            DBHelper.getCmd();
                            int Number2 = Convert.ToInt32(DBHelper.Scalar(SqlMax2)) + 1;
                            DBHelper.ExeInfochange("insert into HandleNote values (" + Number2 + ",'" + this.Text.Trim() + "','" + frmlogin.userName.Trim() + "','" + labBookName.Text.Trim() + "','" + labBookID.Text.Trim() + "','" + labCardId.Text.Trim() + "','" + labReaderName.Text.Trim() + "','" + labSex.Text.Trim() + "','" + dupBookNumber.Text.Trim() + "','" + labPrice.Text.Trim() + "','" + time1 + "')");
                            //更新图书表中图书的可借数量
                            DBHelper.ExeInfochange("update Book set Extant=" + ReBookQty + " where BookID='" + labBookID.Text.Trim() + "'");
                            //更新读者表中已借图书的数量
                            DBHelper.ExeInfochange("update Reader set BorrowNumber=" + ReReaderQty + " where CardID='" + labCardId.Text.Trim() + "'");
                            //更新读者已借的图书数量和图书馆藏数量
                            labBroNumber.Text = Convert.ToString(ReReaderQty);
                            labQty.Text = Convert.ToString(ReBookQty);
                            MessageBox.Show("预借成功！", "提示");
                            loaddata();

                        }
                        else
                        {
                            MessageBox.Show("最后样书,不能预借！", "提示");
                        }
                    }
                    else
                    {
                        MessageBox.Show("已达到最大借书数量,无法继续预借！", "提示");
                    }
                }
                else
                {
                    MessageBox.Show("借书证处于无效状态,无法预借图书！", "提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        # region    实现续借
        private void Renew()
        {
            string time = System.DateTime.Now.ToShortDateString();         //获得今天的时间
            string time1 = DBHelper.GetTime(3);
            DataSet od = new DataSet();
            //获得是否超期
            string IsOver;
            DBHelper.getCon();
            DBHelper.getCmd();
            DBHelper.openCon();
            string sql3 = "select IsOverdue from Borrow where BookID='" + labBookID.Text.Trim() + "'and CardID='" + labCardId.Text.Trim() + "'";
            IsOver = Convert.ToString(DBHelper.Scalar(sql3));
            DBHelper.closeCon();
            //获得借阅表中的借书天数
            int Day;
            DBHelper.getCon();
            DBHelper.getCmd();
            DBHelper.openCon();
            string sql4 = "select BroTieme from Borrow where  CardID='" + labCardId.Text.Trim() + "' and BookID='" + labBookID.Text.Trim() + "'";
            Day = Convert.ToInt32(DBHelper.Scalar(sql4)); 
            DBHelper.closeCon();
            string RenewDay = Convert.ToString(Day + 30);

            if (labSatue.Text.Trim() == "有效")
            {
                if (IsOver == "否")
                {
                    //向借阅流水表中添加一条记录
                    string SqlMax = "select Max(HandleNumber) from HandleNote";
                    DBHelper.openCon();
                    int Number2 = Convert.ToInt32(DBHelper.Scalar(SqlMax)) + 1;
                    DBHelper.ExeInfochange("insert into HandleNote values (" + Number2 + ",'" + this.Text.Trim() + "','" + frmlogin.userName.Trim() + "','" + labBookName.Text.Trim() + "','" + labBookID.Text.Trim() + "','" + labCardId.Text.Trim() + "','" + labReaderName.Text.Trim() + "','" + labSex.Text.Trim() + "','" + dupBookNumber.Text.Trim() + "','" + labPrice.Text.Trim() + "','" + time1 + "')");
                    //更新借阅表中的可借天数
                    string sql = "update Borrow set BroTieme='" + RenewDay + "' where CardID='" + labCardId.Text.Trim() + "' and BookID='" + labBookID.Text.Trim() + "'";
                    if (DBHelper.ExeInfochange(sql) > 0)
                    {
                        MessageBox.Show("续借成功！", "提示");
                        loaddata();
                    }
                }
                else
                {
                    MessageBox.Show("图书已超期,不能续此书！", "提示");
                }
            }
            else
            {
                MessageBox.Show("借书证处于无效状态,无法续借图书！", "提示");
            }
        }
        #endregion

        #region  实现还书
        private void Reback()
        {
            //获得系统参数中的数据
            int BroNumber, BookStore;
            DBHelper.getCon();
            DBHelper.getCmd();
            DBHelper.openCon();
            string sql1 = "select BorrowNumber from Reader where CardID='" + labCardId.Text.Trim() + "'";
            string sql2 = "select Extant from Book where BookID='" + labBookID.Text.Trim() + "'";
            BroNumber = Convert.ToInt32(DBHelper.Scalar(sql1));         //获得读者表中已借的数量
            BookStore = Convert.ToInt32(DBHelper.Scalar(sql2));        //获得图书表中的可借出数量
            DBHelper.closeCon();

            string time1 = DBHelper.GetTime(3);   //获得现在时间
            string sql = "select * from Borrow where BookID='" + labBookID.Text.Trim() + "'and CardID='" + labCardId.Text.Trim() + "'";
            try
            {
                if (Convert.ToInt32(DBHelper.Scalar(sql)) > 0 && BroNumber > 0)
                {
                    //在借阅表中查询,是否超期
                    string YesNo;
                    DBHelper.getCon();
                    DBHelper.getCmd();
                    DBHelper.openCon();
                    string sql3 = "select IsOverdue from Borrow where BookID='" + labBookID.Text.Trim() + "'and CardID='" + labCardId.Text.Trim() + "'";
                    YesNo = Convert.ToString(DBHelper.Scalar(sql3));
                    DBHelper.closeCon();
                    //ds = DBHelper.GetDataset("select * from Borrow where BookID='" + labBookID.Text.Trim() + "'and CardID='" + labCardId.Text.Trim() + "'");
                    //string YesNo = Convert.ToString(ds.Tables[0].Rows[0][12]);
                    if (YesNo.Trim() == "否")
                    {
                        //删除借阅表中的记录
                        int Hang = DBHelper.ExeInfochange("delete from Borrow Where BookID='" + labBookID.Text.Trim() + "'and CardID='" + labCardId.Text.Trim() + "'");
                        dupBookNumber.Text = Convert.ToString(Hang);     //赋值给还书数量
                        //向借阅流水表中添加一条记录
                        string SqlMax = "select Max(HandleNumber) from HandleNote";
                        DBHelper.getCon();
                        DBHelper.getCmd();
                        DBHelper.openCon();
                        int Number2 = Convert.ToInt32(DBHelper.Scalar(SqlMax)) + 1;
                        DBHelper.ExeInfochange("insert into HandleNote values (" + Number2 + ",'" + this.Text.Trim() + "','" + frmlogin.userName.Trim() + "','" + labBookName.Text.Trim() + "','" + labBookID.Text.Trim() + "','" + labCardId.Text.Trim() + "','" + labReaderName.Text.Trim() + "','" + labSex.Text.Trim() + "','" + dupBookNumber.Text.Trim() + "','" + labPrice.Text.Trim() + "','" + time1 + "')");

                        int ReBookQty = BookStore + Hang;     //更新图书表中的可出借数量
                        int ReReaderQty = BroNumber - Hang;      //更新读者已借阅图书的数量
                        //更新图书表中图书的可借数量
                        DBHelper.ExeInfochange("update Book set Extant=" + ReBookQty + " where BookID='" + labBookID.Text.Trim() + "'");
                        //更新读者表中已借图书的数量
                        DBHelper.ExeInfochange("update Reader set BorrowNumber=" + ReReaderQty + " where CardID='" + labCardId.Text.Trim() + "'");
                        //更新读者已借的图书数量和图书馆藏数量
                        labBroNumber.Text = Convert.ToString(ReReaderQty);
                        labQty.Text = Convert.ToString(ReBookQty);
                        MessageBox.Show("还书成功！", "提示");
                        loaddata();
                    }
                    else
                    {
                        MessageBox.Show("此图书已超期", "提示");
                    }
                }
                else
                {
                    MessageBox.Show("该读者没有借阅过此图书或已经归还！", "提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void frmBookAbout_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                //DataSet Getinfo = new DataSet();

                //Getinfo = DBHelper.GetDataset("select * from Reader where CardID='" + frmReaderCheck.CardId + "'");
                //txtReader.Text = Getinfo.Tables[0].Rows[0][1].ToString();
                //this.labCardId.Text = Getinfo.Tables[0].Rows[0][0].ToString();
                //this.labReaderName.Text = Getinfo.Tables[0].Rows[0][2].ToString();
                //this.labReaderTypeID.Text = Getinfo.Tables[0].Rows[0][5].ToString();
                //this.labSatue.Text = Getinfo.Tables[0].Rows[0][6].ToString();
                //this.labBroNumber.Text = Getinfo.Tables[0].Rows[0][3].ToString();
                //this.labSex.Text = Getinfo.Tables[0].Rows[0][9].ToString();

                //Getinfo = DBHelper.GetDataset("select * from Book where BookID='" + frmBookCheck.BookID + "'");
                //txtBookName.Text = Getinfo.Tables[0].Rows[0][1].ToString();
                //this.labBookID.Text = Getinfo.Tables[0].Rows[0][0].ToString();
                //this.labBookName.Text = Getinfo.Tables[0].Rows[0][4].ToString();
                //this.labAuthor.Text = Getinfo.Tables[0].Rows[0][6].ToString();
                //this.labPublisher.Text = Getinfo.Tables[0].Rows[0][9].ToString();
                //this.labPrice.Text = Getinfo.Tables[0].Rows[0][14].ToString();
                //this.labQty.Text = Getinfo.Tables[0].Rows[0][17].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string timeload = DBHelper.GetTime(9);
            DBHelper.InfoShow("" + Sql + " where HandleDate like '%" + timeload + "%'", dgvHandleInfo);
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            string time = DBHelper.GetTime(9);
            if (cmbCheckList.Text.Trim() == "读者卡号")
            {
                DBHelper.InfoShow("" + Sql + " where HandleDate like '%" + time + "%'and ReaderID like '%" + txtCondition.Text + "%'", dgvHandleInfo);
            }
            if (cmbCheckList.Text.Trim() == "读者姓名")
            {
                DBHelper.InfoShow("" + Sql + " where HandleDate like '%" + time + "%'and ReaderName like '%" + txtCondition.Text + "%'", dgvHandleInfo);
            }
            if (cmbCheckList.Text.Trim() == "图书编号")
            {
                DBHelper.InfoShow("" + Sql + " where HandleDate like '%" + time + "%'and BookStrichcode like '%" + txtCondition.Text + "%'", dgvHandleInfo);
            }
            if (cmbCheckList.Text.Trim() == "图书名称")
            {
                DBHelper.InfoShow("" + Sql + " where HandleDate like '%" + time + "%'and BookName like '%" + txtCondition.Text + "%'", dgvHandleInfo);
            }
        }

        private void rdbBorrow_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBorrow.Checked == true)
            {
                this.Text = "借阅图书";
                dupBroTime.Visible = true;
                label3.Visible = true;
                dupBookNumber.Visible = true;
                label2.Visible = true;
            }
        }

        private void rdbReback_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbReback.Checked == true)
            {
                this.Text = "归还图书";
                dupBroTime.Visible = false;
                label3.Visible = false;
                dupBookNumber.Visible = true;
                label2.Visible = true;
            }
        }

        private void rdbContuine_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbContuine.Checked == true)
            {
                this.Text = "续借图书";
                dupBookNumber.Visible = false;
                label2.Visible = false;
                dupBroTime.Visible = true;
                label3.Visible = true;
            }
        }

        private void rdbForBorrow_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbForBorrow.Checked == true)
            {
                this.Text = "预借图书";
                dupBroTime.Visible = false;
                label3.Visible = false;
                dupBookNumber.Visible = true;
                label2.Visible = true;
            }
        }

        private void tsbOk_Click(object sender, EventArgs e)
        {
            int SetTeacherBroNumber, SetStudnetBroNumber;
            //DataSet ds = new DataSet();
            //ds = DBHelper.GetDataset("select * from SystemSet");
            string sql = "select num = TeaBroNumber,num1= StuBroNumber from SystemSet";
           // string sql = "select * from SystemSet";
            //DBHelper.fill(sql, "SystemSet");
            //int SetTeacherBroNumber = Convert.ToInt32(ds.Tables[0].Rows[0].ToString());       //获得教师可以借阅读书的数量
            //int SetStudnetBroNumber = Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString());       //获得学生等可以借阅图书的数量
            DBHelper.getCon();
            DBHelper.getCmd();
            DBHelper.openCon();
            
            SqlDataReader dr = DBHelper.query(sql);

            while (dr.Read())
            {
                SetTeacherBroNumber = Convert.ToInt32(dr["num"]);
                SetStudnetBroNumber = Convert.ToInt32(dr["num1"]);


                if (rdbBorrow.Checked == true)
                {
                    if (frmReaderCheck.ReaderType == "教师")
                    {
                        Borrow(SetTeacherBroNumber);
                    }
                    else
                    {
                        Borrow(SetStudnetBroNumber);
                    }
                }

                if (rdbReback.Checked == true)
                {
                    Reback();
                }
                if (rdbContuine.Checked == true)
                {
                    //判断是否有借阅要续借的图书
                    if (Convert.ToInt32(DBHelper.ExecuteSelect("select * from Borrow where CardID='" + labCardId.Text.Trim() + "' and BookID='" + labBookID.Text.Trim() + "'")) > 0)
                    {
                        Renew();
                    }
                    else
                    {
                        MessageBox.Show("该读者没有借阅过此图书或已经归还！", "提示");
                    }
                }
                if (rdbForBorrow.Checked == true)
                {
                    if (labReaderTypeID.Text.Trim() == "教师")
                    {
                        ReserBorrow(SetTeacherBroNumber);
                    }
                    else
                    {
                        ReserBorrow(SetStudnetBroNumber);
                    }
                }

            }
            DBHelper.closeCon();



            
        }
    }
}
