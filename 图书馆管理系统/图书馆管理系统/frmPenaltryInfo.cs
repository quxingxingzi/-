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
    public partial class frmPenaltryInfo : Form
    {
        public frmPenaltryInfo()
        {
            InitializeComponent();
        }
        public string HandleType;
        public int number;
        frmReaderCheck frc = new frmReaderCheck();
        frmBookCheck fbc = new frmBookCheck();
        private void frmPenaltryInfo_Load(object sender, EventArgs e)
        {
            Reflseh();
            this.dgvPenaltryInfo.Columns[3].Width = 260;
            butOk.Enabled = false;
            butExit.Enabled = false;
            cmbType.SelectedIndex = 0;
            //获得屏幕的大小,并设置窗体初始化时的大小
            Rectangle rect = System.Windows.Forms.SystemInformation.VirtualScreen;
            this.Width = rect.Width - 130;
            this.Height = rect.Height - 160;
        }
        public void Reflseh()
        {
            DBHelper.InfoShow("select Number 罚款编号,CardID 读者编号,ReaderName 读者姓名,BookName 图书名称,BookID 图书编号,Type 罚款类型,PenaltyMoney 罚款金额,Paytime 交款时间,HandleUser 操作用户 from PenaltryInfo order by Number", dgvPenaltryInfo);
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            string time;
            time =dateTimePicker1 .Text .ToString ();
            if (HandleType == "添加")
            {
                DBHelper.getCon();
                DBHelper.getCmd();
                string SqlMax = "select max(Number) from PenaltryInfo";
                DBHelper.openCon();
                int Number = Convert.ToInt32(DBHelper.ExecuteSelect(SqlMax)) + 1;
                DBHelper.ExeInfochange("insert into PenaltryInfo values(" + Number + ",'" + txtReaderId.Text.Trim() + "','" + txtReaderName.Text.Trim() + "','" + txtBookName.Text.Trim() + "','" + txtBookId.Text.Trim() + "','" + cmbType.Text + "','" + txtPenaltyMoney.Text.Trim() + "','" + DBHelper.GetTime(3) + "','" + frmlogin.userName.Trim() + "')");
                MessageBox.Show("添加成功！", "提示");
                butOk.Enabled = false;
                butExit.Enabled = false;
                tsbAdd.Enabled = true;
                tsbChange.Enabled = true;
            }
            if (HandleType == "修改")
            {
                DBHelper.ExeInfochange("update PenaltryInfo set CardID='" + txtReaderId.Text.Trim() + "',ReaderName='" + txtReaderName.Text.Trim() + "',BookName='" + txtBookName.Text.Trim() + "',BookID='" + txtBookId.Text.Trim() + "',Type='" + cmbType.Text + "',PenaltyMoney='" + txtPenaltyMoney.Text.Trim() + "',Paytime='"+time+"',HandleUser='" + frmlogin.userName.Trim() + "' where Number='" + txtRemorandum.Text.Trim() + "'");
                
                MessageBox.Show("修改成功！", "提示");
                butOk.Enabled = false;
                butExit.Enabled = false;
                tsbAdd.Enabled = true;
                tsbChange.Enabled = true;
            }
            txtRemorandum.Clear();
            txtReaderId.Clear();
            txtReaderName.Clear();
            txtBookId.Clear();
            txtBookName.Clear();
            cmbType.SelectedIndex = 0;
            txtPenaltyMoney.Clear();
            Reflseh();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否当真删除编号为'" + number + "'的记录！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (DBHelper.ExeInfochange("delete from Remind where Number ='" + number + "'") > 0)
                {
                    MessageBox.Show("记录删除成功！", "提示");
                }
            }
            Reflseh();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            HandleType = "添加";
            butOk.Enabled = true;
            butExit.Enabled = true;
            butCheckReader.Enabled = true;
            butCheckBook.Enabled = true;
            cmbType.Enabled = true;
            txtPenaltyMoney.Enabled = true;
            tsbChange.Enabled = false;
            string SqlMax = "select Max(Number) from Remind";
            DBHelper.getCon();
            DBHelper.getCmd();
            DBHelper.openCon();
            int Nun = Convert.ToInt32(DBHelper.Scalar(SqlMax)) + 1;
            txtRemorandum.Text = Convert.ToString(Nun);
        }

        private void tsbChange_Click(object sender, EventArgs e)
        {
            HandleType = "修改";
            butOk.Enabled = true;
            butExit.Enabled = true;
            butCheckReader.Enabled = true;
            butCheckBook.Enabled = true;
            cmbType.Enabled = true;
            txtPenaltyMoney.Enabled = true;
            tsbAdd.Enabled = false;
            txtRemorandum.Text = Convert.ToString(number);
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butCheckReader_Click(object sender, EventArgs e)
        {
            frc.ShowDialog();
            this.txtReaderName.Text = frmReaderCheck.ReaderName;
            this.txtReaderId.Text = frmReaderCheck.CardId;
        }

        private void butCheckBook_Click(object sender, EventArgs e)
        {
            fbc.ShowDialog();
            this.txtBookId.Text = frmBookCheck.BookID;
            this.txtBookName.Text = frmBookCheck.BookName;
        }

        private void tsbToExcel_Click(object sender, EventArgs e)
        {
            DBHelper.ShowDgvInfo(dgvPenaltryInfo, true);
        }

        private void tsbReflesh_Click(object sender, EventArgs e)
        {
            Reflseh();
        }

        private void frmPenaltryInfo_Resize(object sender, EventArgs e)
        {
            dgvPenaltryInfo.Width = this.Width - 90;
            dgvPenaltryInfo.Height = this.Height - 70;
        }

        private void frmPenaltryInfo_Paint(object sender, PaintEventArgs e)
        {
            txtReaderId.Text = frmReaderCheck.ReaderName;
            txtReaderName.Text = frmReaderCheck.CardId;
            txtBookId.Text = frmBookCheck.BookID;
            txtBookName.Text = frmBookCheck.BookID;
        }

        private void dgvPenaltryInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            number = Convert.ToInt32(dgvPenaltryInfo.SelectedCells[0].Value.ToString());     //获得备忘编号
            txtRemorandum.Text = Convert.ToString(number);
            cmbType.Text = dgvPenaltryInfo.SelectedCells[5].Value.ToString();
            txtReaderId.Text = dgvPenaltryInfo.SelectedCells[1].Value.ToString();
            txtReaderName.Text = dgvPenaltryInfo.SelectedCells[2].Value.ToString();
            txtBookId.Text = dgvPenaltryInfo.SelectedCells[4].Value.ToString();
            txtBookName.Text = dgvPenaltryInfo.SelectedCells[3].Value.ToString();
            txtPenaltyMoney.Text = dgvPenaltryInfo.SelectedCells[6].Value.ToString();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
