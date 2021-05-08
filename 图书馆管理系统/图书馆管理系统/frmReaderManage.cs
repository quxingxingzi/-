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
    public partial class frmReaderManage : Form
    {
        public frmReaderManage()
        {
            InitializeComponent();
        }

        private void frmReaderManage_Load(object sender, EventArgs e)
        {
            //获得屏幕的大小,并设置窗体初始化时的大小
            Rectangle rect = System.Windows.Forms.SystemInformation.VirtualScreen;
            this.Width = rect.Width - 135;
            this.Height = rect.Height - 157;
            ShowAll();
            GetInfo();
            dgvUserManage_Click(sender, e);

        }

        private void butOk_Click(object sender, EventArgs e)
        {
            if (txtConfident.Text.Length == 0)
            {
                MessageBox.Show("请输入要查询的内容!");
                return;
            }
            else
            {
                try
                {
                    DataSet dsm;
                    {
                        string strsql = "select Number 流水编号,CardID 借书证号,ReaderName 读者姓名,BorrowNumber 借阅数量,Strichcode 条形码,ReaderTypeID 读者类型,Mode 书证状态,RegistrationTime 登记日期,ValidTime 有效期至,Sex 性别,Dept 工作单位, Call 电话 FROM Reader WHERE(CardID LIKE '%" + txtConfident.Text.Trim() + "%') or(ReaderName LIKE '%" + txtConfident.Text.Trim() + "%') order by Number";
                        dsm = DBHelper.ds2(strsql);
                        dgvUserManage.DataSource = dsm;
                        dgvUserManage.DataMember = dsm.Tables[0].ToString();
                    }

                }
                catch (Exception)
                {
                    return;
                }

            }
        }

        private void butAll_Click(object sender, EventArgs e)
        {
            ShowAll();
        }
        public void ShowAll()     //实现刷新
        {
            DataSet dsUserManage;
            string strSql = "select Number 流水编号,CardID 借书证号,ReaderName 读者姓名,BorrowNumber 借阅数量,IDNumber 身份证号,ReaderTypeID 读者类型,Mode 书证状态,RegistrationTime 登记日期,ValidTime 有效期至,Sex 性别,Dept 工作单位, Call 电话 from Reader order by Number";
            dsUserManage = DBHelper.ds2(strSql);
            dgvUserManage.DataSource = dsUserManage;
            dgvUserManage.DataMember = dsUserManage.Tables[0].ToString();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbReaderAdd_Click(object sender, EventArgs e)
        {
            frmReaderAdd fra = new frmReaderAdd();
            fra.ShowDialog(this);
            ShowAll();
        }

        private void tsbReaderChange_Click(object sender, EventArgs e)
        {
            GetInfo();
            frmReaderChange frc = new frmReaderChange();
            frc.ShowDialog();
            ShowAll();
        }

        private void tsbReaderDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string name = dgvUserManage.SelectedCells[2].Value.ToString();   //获得读者的姓名   
                if (MessageBox.Show("是否当真删除用户名为'" + name.Trim() + "'的用户？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sql = "delete from Reader where ReaderName='" + name + "'";    //用获得的姓名去删除相应的记录
                    if (DBHelper.ExeInfochange(sql) == 1)
                    {
                        ShowAll();
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("用户信息删除失败！", "提示");
            }
        }

        private void tsbReaderCheck_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void tsbReaderReflesh_Click(object sender, EventArgs e)
        {
            ShowAll();
            dgvUserManage_Click(sender, e);
        }

        private void tsbReaderToExcel_Click(object sender, EventArgs e)
        {
                DBHelper.ShowDgvInfo(dgvUserManage, true);
                DBHelper.ShowDgvInfo(dgvBorInfo, true);
                DBHelper.ShowDgvInfo(dgvBorrowlist, true);
        }

        private void tsbReaderExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmReflesh_Click(object sender, EventArgs e)
        {
            ShowAll();
            dgvUserManage_Click(sender, e);
        }

        private void txmChange_Click(object sender, EventArgs e)
        {
            tsbReaderChange_Click(sender, e);
        }

        private void tsmAdd_Click(object sender, EventArgs e)
        {
            tsbReaderAdd_Click(sender, e);
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            tsbReaderDelete_Click(sender, e);
        }

        private void tsmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUserManage_Click(object sender, EventArgs e)
        {
            try
            {
                GetInfo();
                string CardId = dgvUserManage.SelectedCells[1].Value.ToString();     //获得读者卡的编号
                if (tabPage1.Text == "当前借阅状态")
                {
                    DataSet broinfo;
                    {
                        string strbro = "select Number 流水编号,CardID 借书证号,ReaderName 读者姓名,BookID 图书编号,BookName 图书名称,Author 图书作者,Publisher 出版社,Price 图书价格,BorrowDate 借书日期,BorrowNumber 借书数量,UserName 操作员,BroTieme 借阅时长,IsOverdue 是否超期 FROM Borrow WHERE CardID='" + CardId.Trim() + "'";       //用获得的读者卡号搜索相应的记录
                        broinfo = DBHelper.ds2(strbro);
                        dgvBorInfo.DataSource = broinfo;
                        dgvBorInfo.DataMember = broinfo.Tables[0].ToString();
                    }
                }
                if (tabPage2.Text == "借阅历史")
                {
                    string strSql = "select HandleNumber 操作编号,BookName 图书名称,BookStrichcode 图书编号,ReaderID 读者编号,ReaderName 读者姓名,ReaderSex 读者性别,BookNumber 借书数量,BookPrice 图书价格,HandleDate 操作日期 from HandleNote where  ReaderID='" + CardId.Trim() + "'";
                    DBHelper.InfoShow("" + strSql + "", dgvBorrowlist);
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        public static string ReaderCardID, ReaderName, ReaderType, ReaderStatue, ReaderEndtime, ReaderSex, ReaderWorkPlace, ReaderTelNumber, ReaderStrichcode;

        public void GetInfo()
        {
            #region 获得数据
            try
            {
                ReaderCardID = dgvUserManage.SelectedCells[1].Value.ToString();
                ReaderName = dgvUserManage.SelectedCells[2].Value.ToString();
                ReaderStrichcode = dgvUserManage.SelectedCells[4].Value.ToString();
                ReaderType = dgvUserManage.SelectedCells[5].Value.ToString();
                ReaderStatue = dgvUserManage.SelectedCells[6].Value.ToString();
                ReaderEndtime = dgvUserManage.SelectedCells[8].Value.ToString();
                ReaderSex = dgvUserManage.SelectedCells[9].Value.ToString();
                ReaderWorkPlace = dgvUserManage.SelectedCells[10].Value.ToString();
                ReaderTelNumber = dgvUserManage.SelectedCells[11].Value.ToString();
            }
            catch (Exception ex)
            {
                if (ex.Message != null)
                    MessageBox.Show("没有数数据！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            #endregion
        }

        private void txtConfident_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet dsm;
                {
                    string strsql = "select Number 流水编号,CardID 借书证号,ReaderName 读者姓名,BorrowNumber 借阅数量,Strichcode 条形码,ReaderTypeID 读者类型,Mode 书证状态,RegistrationTime 登记日期,ValidTime 有效期至,Sex 性别,Dept 工作单位, Call 电话 FROM Reader WHERE(CardID LIKE '%" + txtConfident.Text.Trim() + "%') or(ReaderName LIKE '%" + txtConfident.Text.Trim() + "%')";
                    dsm = DBHelper.ds2(strsql);
                    dgvUserManage.DataSource = dsm;
                    dgvUserManage.DataMember = dsm.Tables[0].ToString();
                }

            }
            catch (Exception)
            {
                return;
            }
        }

        private void frmReaderManage_Resize(object sender, EventArgs e)
        {
            //当窗体的大小变化时各个控件的大小也随着发生变化
            groupBox1.Width = this.Width - 20;
            groupBox2.Width = this.Width - 20;
            tabpage.Width = this.Width - 20;
            tabpage.Height = this.Height - 478;
            dgvUserManage.Width = this.Width - 33;
            dgvBorInfo.Width = this.Width - 33;
            dgvBorInfo.Height = this.Height - 505;
        }
    }
}
