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
    public partial class frmMemorandum : Form
    {
        public frmMemorandum()
        {
            InitializeComponent();
        }
        frmReaderCheck frc = new frmReaderCheck();
        public string HandleType;
        public int number;
        private void frmMemorandum_Load(object sender, EventArgs e)
        {
            Reflseh();
            this.dgvMemorandum.Columns[3].Width = 260;
            butOk.Enabled = false;
            butExit.Enabled = false;
            txtRemorandum.ReadOnly = true;
            cmbRemindWay.SelectedIndex = 0;
            //获得屏幕的大小,并设置窗体初始化时的大小
            Rectangle rect = System.Windows.Forms.SystemInformation.VirtualScreen;
            this.Width = rect.Width - 130;
            this.Height = rect.Height - 160;
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            string time;
            time = dateTimePicker1.Text.ToString() + " " + dateTimePicker2.Text.ToString();
            if (HandleType == "添加")
            {
                string SqlMax = "select max(Number) from Remind";
                DBHelper.getCon();
                DBHelper.getCmd();
                DBHelper.openCon();
                int Number = Convert.ToInt32(DBHelper.Scalar(SqlMax)) + 1;
                if (checkBox2.Checked == true)
                {
                    DBHelper.ExeInfochange("insert into Remind values(" + Number + ",'尚未提示','" + time + "','" + txtRemind.Text.Trim() + "','是','" + cmbRemindWay.Text + "','" + txtReaderName.Text.Trim() + "','" + DBHelper.GetTime(3) + "')");
                }
                if (checkBox2.Checked == false)
                {
                    DBHelper.ExeInfochange("insert into Remind values(" + Number + ",'尚未提示','" + time + "','" + txtRemind.Text.Trim() + "','否 ','" + cmbRemindWay.Text + "','" + txtReaderName.Text.Trim() + "','" + DBHelper.GetTime(3) + "')");
                }
                MessageBox.Show("添加成功！", "提示");
                butOk.Enabled = false;
                butExit.Enabled = false;
                tsbAdd.Enabled = true;
                tsbChange.Enabled = true;
            }
            if (HandleType == "修改")
            {
                if (checkBox2.Checked == true)
                {
                    DBHelper.ExeInfochange("update Remind set Statue='尚未提示',RemindTime='" + time + "',Content='" + txtRemind.Text.Trim() + "',IsRemind='是',Type='" + cmbRemindWay.Text + "',IsToReader='" + txtReaderName.Text.Trim() + "'where Number='" + txtRemorandum.Text.Trim() + "'");
                }
                if (checkBox2.Checked == false)
                {
                    DBHelper.ExeInfochange("update Remind set Statue='尚未提示',RemindTime='" + time + "',Content='" + txtRemind.Text.Trim() + "',IsRemind='否',Type='" + cmbRemindWay.Text + "',IsToReader='" + txtReaderName.Text.Trim() + "' where Number='" + txtRemorandum.Text.Trim() + "'");
                }
                MessageBox.Show("修改成功！", "提示");
                butOk.Enabled = false;
                butExit.Enabled = false;
                tsbAdd.Enabled = true;
                tsbChange.Enabled = true;
            }
            txtRemorandum.Clear();
            txtReaderName.Clear();
            txtRemind.Clear();
            Reflseh();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否当真删除编号为'" + number + "'的记录！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (DBHelper.ExeInfochange("delete from Remind where Number ='" + number + "'") > 0)
                {
                    MessageBox.Show("备忘删除成功！", "提示");
                }
            }
            Reflseh();
        }
        public void Reflseh()
        {
            DBHelper.InfoShow("select Number 备忘编号,Statue 当前状态,RemindTime 提醒时间,Content 备忘内容,IsRemind 是否提示,Type 提示方式,IsToReader 是否涉及读者,Addtime 备忘添加时间 from Remind order by Number", dgvMemorandum);
        }

        private void dgvMemorandum_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                number = Convert.ToInt32(dgvMemorandum.SelectedCells[0].Value.ToString());     //获得备忘编号
                txtRemorandum.Text = Convert.ToString(number);
                dateTimePicker1.Text = (dgvMemorandum.SelectedCells[2].Value.ToString()).Substring(0, (dgvMemorandum.SelectedCells[2].Value.ToString()).Length - 9);
                txtReaderName.Text = dgvMemorandum.SelectedCells[6].Value.ToString();
                txtRemind.Text = dgvMemorandum.SelectedCells[3].Value.ToString();
                dateTimePicker2.Text = (dgvMemorandum.SelectedCells[2].Value.ToString()).Substring((dgvMemorandum.SelectedCells[2].Value.ToString()).Length-8, 8);
                cmbRemindWay.Text = dgvMemorandum.SelectedCells[5].Value.ToString();
                if (dgvMemorandum.SelectedCells[4].Value.ToString() == "是")
                {
                    checkBox2.Checked = true;
                }
                else
                {
                    checkBox2.Checked = false;
                }
                if (dgvMemorandum.SelectedCells[6].Value.ToString() == "")
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                    txtReaderName.Text = dgvMemorandum.SelectedCells[6].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            HandleType = "添加";
            butOk.Enabled = true;
            butExit.Enabled = true;
            tsbChange.Enabled = false;
            string SqlMax = "select Max(Number) from Remind";
            DBHelper.getCon();
            DBHelper.getCmd();
            DBHelper.openCon();
            int Nun = Convert.ToInt32(DBHelper.Scalar(SqlMax))+1;
            txtRemorandum.Text = Convert.ToString(Nun);
        }

        private void tsbChange_Click(object sender, EventArgs e)
        {
            HandleType = "修改";
            butOk.Enabled = true;
            butExit.Enabled = true;
            tsbAdd.Enabled = false;
            txtRemorandum.Text = Convert.ToString(number);
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            txtRemorandum.Clear();
            txtReaderName.Clear();
            txtRemind.Clear();
            butOk.Enabled = false;
            butExit.Enabled = false;
            tsbAdd.Enabled = true;
            tsbChange.Enabled = true;
        }

        private void butCheck_Click(object sender, EventArgs e)
        {
            frc.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                txtReaderName.Enabled = false;
                butCheck.Enabled = false;
                txtReaderName.Clear();
            }
            else
            {
                txtReaderName.Enabled = true;
                butCheck.Enabled = true;
            }
        }

        private void frmMemorandum_Resize(object sender, EventArgs e)
        {
            dgvMemorandum.Width = this.Width - 170;
            dgvMemorandum.Height = this.Height - 70;
        }

        private void frmMemorandum_Paint(object sender, PaintEventArgs e)
        {
            txtReaderName.Text = frmReaderCheck.CardId;
        }

        private void tsbReflesh_Click(object sender, EventArgs e)
        {
            Reflseh();
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DBHelper.ShowDgvInfo(dgvMemorandum, true);
        }
    }
}
