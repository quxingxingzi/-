using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 图书馆管理系统
{
    public partial class frmReaderCheck : Form
    {
        public frmReaderCheck()
        {
            InitializeComponent();
        }

        private void frmReaderCheck_Load(object sender, EventArgs e)
        {
            DBHelper.getCon();
            DBHelper.getCmd();
            //fba.Enabled = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //显示所有的读者的信息
            string sql = "select Number 读者编号,CardID 借书证号,ReaderName 读者姓名,BorrowNumber 已借阅图书数量,IDNumber 身份证号,ReaderTypeID 读者类型,Mode 书证状态,RegistrationTime 登记日期,ValidTime 有效期至,Sex 性别,Dept 工作单位, Call 电话 FROM Reader";
            DBHelper.fill(sql, "Reader");
            dgvCheckUser.DataSource = DBHelper.ds.Tables["Reader"];
        }
        public static string CardId, ReaderName, ReaderSex, ReaderType, Borrownumber, Statue;
        public void GetInfo()
        {
            CardId = dgvCheckUser.SelectedCells[1].Value.ToString();
            ReaderName = dgvCheckUser.SelectedCells[2].Value.ToString();
            ReaderType = dgvCheckUser.SelectedCells[5].Value.ToString();
            Borrownumber = dgvCheckUser.SelectedCells[3].Value.ToString();
            Statue = dgvCheckUser.SelectedCells[6].Value.ToString();
            ReaderSex = dgvCheckUser.SelectedCells[9].Value.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ShowInfo("select Number 读者编号,CardID 借书证号,ReaderName 读者姓名,BorrowNumber 已借阅图书数量,Strichcode 条形码,ReaderTypeID 读者类型,Mode 书证状态,RegistrationTime 登记日期,ValidTime 有效期至,Sex 性别,Dept 工作单位, Call 电话 FROM Reader WHERE(CardID LIKE '%" + textBox1.Text.Trim() + "%')");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ShowInfo("select Number 读者编号,CardID 借书证号,ReaderName 读者姓名,BorrowNumber 已借阅图书数量,Strichcode 条形码,ReaderTypeID 读者类型,Mode 书证状态,RegistrationTime 登记日期,ValidTime 有效期至,Sex 性别,Dept 工作单位, Call 电话 FROM Reader WHERE(ReaderName LIKE '%" + textBox2.Text.Trim() + "%')");
        }
        private void ShowInfo(string sql)
        {
            DataSet dsb;
            {
                dsb = DBHelper.ds2(sql);
                dgvCheckUser.DataSource = dsb;
                dgvCheckUser.DataMember = dsb.Tables[0].ToString();
            }
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            GetInfo();
            this.Close();
        }

        private void dgvCheckUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GetInfo();
            this.Close();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
