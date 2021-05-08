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
    public partial class frmPublishing : Form
    {
        public frmPublishing()
        {
            InitializeComponent();
        }

        private void frmPublishing_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //显示所有出版社的信息
            DBHelper.InfoShow("select PulNumber 编号,PulName 出版社名称,PulAdress 地址,PulExplain 说明 from Publishing order by PulNumber", dgvPulb);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            //删除记录
            try
            {
                string Number = dgvPulb.SelectedCells[0].Value.ToString();   //获得记录的流水编号 
                if (MessageBox.Show("是否当真删除编号为'" + Number + "'记录？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sql = "delete from Publishing where PulNumber='" + Number + "'";    //用获得的编号去删除相应的记录
                    if (DBHelper.ExeInfochange(sql) == 1)
                    {
                        DBHelper.InfoShow("select PulNumber 编号,PulName 出版社名称,PulAdress 地址,PulExplain 说明 from Publishing order by PulNumber", dgvPulb);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("信息删除失败！", "提示");
            }
        }

        private void tsbToExcel_Click(object sender, EventArgs e)
        {
            DBHelper.ShowDgvInfo(dgvPulb, true);
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            //string AutoNumber = Convert.ToString(DBHelper.AutoNumber("select Max(PulNumber) from Publishing"));
            frmPubChange fpc = new frmPubChange();
            fpc.Text = "出版社信息(增加)";
            fpc.ShowDialog();
            tsbReflsh_Click(sender,e);
        }

        private void tsbChange_Click(object sender, EventArgs e)
        {
            //获得编号
            //string Number = dgvPulb.SelectedCells[0].Value.ToString();
            frmPubChange fpc = new frmPubChange();
            fpc.Text = "出版社信息(修改)";
            string PulNumber, PulName, PulAdress, PulExplain;
            PulNumber = dgvPulb.CurrentRow.Cells[0].Value.ToString();
            PulName = dgvPulb.CurrentRow.Cells[1].Value.ToString();
            PulAdress = dgvPulb.CurrentRow.Cells[2].Value.ToString();
            PulExplain = dgvPulb.CurrentRow.Cells[3].Value.ToString();
            fpc.txtNumber.Text = PulNumber;
            fpc.txtName.Text = PulName;
            fpc.txtAdress.Text = PulAdress;
            fpc.txtShuoming.Text = PulExplain;
            fpc.ShowDialog();
            tsbReflsh_Click(sender, e);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //利用获得的条件查询符合条件的数据
            DBHelper.InfoShow("select PulNumber 编号,PulName 出版社名称,PulAdress 地址,PulExplain 说明 from Publishing where PulName like '%" + txtName.Text.Trim() + "%' order by PulNumber", dgvPulb);
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            txtName_TextChanged(sender, e);
        }

        private void tsbReflsh_Click(object sender, EventArgs e)
        {
            //显示所有数据
            DBHelper.InfoShow("select PulNumber 编号,PulName 出版社名称,PulAdress 地址,PulExplain 说明 from Publishing order by PulNumber", dgvPulb);
        }

        private void frmPublishing_Paint(object sender, PaintEventArgs e)
        {
            tsbReflsh_Click(sender, e);
        }
        public string PulName;

        private void dgvPulb_DoubleClick(object sender, EventArgs e)
        {
            PulName = dgvPulb.SelectedCells[1].Value.ToString();
            this.Close();
        }
    }
}
