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
    public partial class frmMain : Form
    {
        private bool showing = true;
        public frmMain()
        {
            InitializeComponent();
            //窗体显示特效 7 　　
            Opacity = 0.0; //窗体透明度为0 8 　　
            fadeTimer.Start(); //计时开始
        }
        frmMemorandum fmr = new frmMemorandum();
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //导航栏的收\放
            if (palNavigation.Visible == true)
            {
                palNavigation.Visible = false;
                this.palNavigation.Width = 0;
            }
            else
            {
                palNavigation.Visible = true;
                this.palNavigation.Width = 117;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Dock = DockStyle.None;

            button1.Dock = DockStyle.Top;
            button5.SendToBack();
            button5.Dock = DockStyle.Bottom;
            button4.SendToBack();
            button4.Dock = DockStyle.Bottom;
            button3.SendToBack();
            button3.Dock = DockStyle.Bottom;
            button2.SendToBack();
            button2.Dock = DockStyle.Bottom;
            listView1.Clear();
            listView1.Items.Add("借阅管理","借阅管理", 0);
            listView1.Items.Add("借阅查询","借阅查询", 1);
            listView1.Items.Add("操作流水","操作流水", 2);
            listView1.Items.Add("预借详情","预借详情", 3);
            listView1.Items.Add("帐务管理","帐务管理", 4);
            listView1.Items.Add("备忘管理","备忘管理", 5);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Dock = DockStyle.None;

           // button5.SendToBack();    两排显示
            button5.Dock = DockStyle.Top;
            button1.SendToBack();
            button1.Dock = DockStyle.Top;

            button4.SendToBack();
            button4.Dock = DockStyle.Bottom;
            button3.SendToBack();
            button3.Dock = DockStyle.Bottom;
            button2.SendToBack();
            button2.Dock = DockStyle.Bottom;
            listView1.Dock = DockStyle.Bottom;
            listView1.Clear();
            listView1.Items.Add("书籍管理","书籍管理", 6);
            listView1.Items.Add("读者管理","读者管理", 7);
            listView1.Items.Add("添加读者","添加读者", 8);
            listView1.Items.Add("添加书籍","添加书籍", 9);
            listView1.Items.Add("出版社资料","出版社资料", 10);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Dock = DockStyle.None;

            //button4.SendToBack();
            button4.Dock = DockStyle.Top;
            button5.SendToBack();
            button5.Dock = DockStyle.Top;
            button1.SendToBack();
            button1.Dock = DockStyle.Top;

            button3.SendToBack();
            button3.Dock = DockStyle.Bottom;
            button2.SendToBack();
            button2.Dock = DockStyle.Bottom;
            listView1.Dock = DockStyle.Bottom;
            listView1.Clear();
            listView1.Items.Add("借阅查询","借阅查询", 12);
            listView1.Items.Add("预借查询","预借查询", 13);
            listView1.Items.Add("逾期查询","逾期查询", 14);
            listView1.Items.Add("罚款查询","罚款查询", 15);
            listView1.Items.Add("图书档案查询","图书档案查询", 16);
            listView1.Items.Add("读者档案查询","读者档案查询", 17);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Dock = DockStyle.None;

            //button3.SendToBack();
            button3.Dock = DockStyle.Top;
            button4.SendToBack();
            button4.Dock = DockStyle.Top;
            button5.SendToBack();
            button5.Dock = DockStyle.Top;
            button1.SendToBack();
            button1.Dock = DockStyle.Top;

            button2.SendToBack();
            button2.Dock = DockStyle.Bottom;
            listView1.Dock = DockStyle.Bottom;
            listView1.Clear();

            listView1.Items.Add("读者当前借阅","读者当前借阅", 18);
            listView1.Items.Add("读者借阅日志","读者借阅日志", 19);
            listView1.Items.Add("资料当前借阅","资料当前借阅", 20);
            listView1.Items.Add("资料借阅日志","资料借阅日志", 21);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Dock = DockStyle.None;

            //button2.SendToBack();
            button2.Dock = DockStyle.Top;
            button3.SendToBack();
            button3.Dock = DockStyle.Top;
            button4.SendToBack();
            button4.Dock = DockStyle.Top;
            button5.SendToBack();
            button5.Dock = DockStyle.Top;
            button1.SendToBack();
            button1.Dock = DockStyle.Top;
            listView1.Dock = DockStyle.Bottom;
            listView1.Clear();
            listView1.Items.Add("用户管理","用户管理", 22);
            listView1.Items.Add("切换用户","切换用户", 23);
            listView1.Items.Add("修改密码","修改密码", 24);
            listView1.Items.Add("系统参数","系统参数", 25);
            listView1.Items.Add("系统备份","系统备份", 26);
            listView1.Items.Add("系统还原","系统还原", 27);
            listView1.Items.Add("系统初始化","系统初始化", 28);
            listView1.Items.Add("暂时离开","暂时离开", 29);
            listView1.Items.Add("系统界面","系统界面", 30);
            
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void 暂时离开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLeavetime flt = new frmLeavetime();
            flt.ShowDialog();
        }

        private void 备份管理BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmbackup", "备份管理"))
            {
                frmBackup up = new frmBackup();
                up.Text = "数据备份";
                up.groupBox1.Text = "数据库备份";
                up.Show();
            }
        }

        private void 系统界面PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmbackup", "系统界面"))
            {
                frmSystemInterface fsi = new frmSystemInterface();
                fsi.Show();
            }
        }

        private void 系统参数YToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmSystemSet", "系统参数"))
            {
                frmSystemSet fss = new frmSystemSet();
                fss.ShowDialog();
            }
        }

        private void 切换用户LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmlogin fl = new frmlogin();
            fl.ShowDialog();
        }

        private void 修改密码MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmChangepass", "修改密码"))
            {
                frmChangepass fcp = new frmChangepass();
                fcp.ShowDialog();
            }
        }

        private void 用户管理UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsercontrol fuc = new frmUsercontrol();
            fuc.ShowDialog();
        }

        private void 系统初始化IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmDataDelete", "系统初始化"))
            {
                frmDataDelete fdd = new frmDataDelete();
                fdd.ShowDialog();
            }
        }

        private void 退出系统QToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 读者资料管理PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmReaderManage", "读者资料管理"))
            {
                frmReaderManage frm = new frmReaderManage();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void 帐务管理EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmMemorandum", "图书罚款"))
            {
                frmPenaltryInfo fpi = new frmPenaltryInfo();
                fpi.MdiParent = this;
                fpi.Show();
            }
        }

        private void 办卡管理CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmReaderAdd", "读者添加"))
            {
                frmReaderAdd fra = new frmReaderAdd();
                fra.MdiParent = this;
                fra.Show();
            }
        }

        private void 备忘管理RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmMemorandum", "备忘管理"))
            {
                frmMemorandum fm = new frmMemorandum();
                fm.MdiParent = this;
                fm.Show();
            }
        }

        private void 借阅查询BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmBorselect", "借阅查询"))
            {
                frmBorselect fbs = new frmBorselect();
                fbs.MdiParent = this;
                fbs.Show();
            }
        }

        private void 预借详情PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmReserBroInfo", "预借查询"))
            {
                frmReserBroInfo frb = new frmReserBroInfo();
                frb.MinimizeBox = true;
                frb.MaximizeBox = true;
                frb.StartPosition = FormStartPosition.Manual;
                frb.MdiParent = this;
                frb.Show();
            }
        }

        private void 操作流水HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            操作流水LToolStripMenuItem_Click(sender, e);
        }

        private void 逾期列表GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmReserBroInfo", "预借查询"))
            {
                frmOverdueInfo foi = new frmOverdueInfo();
                foi.MinimizeBox = true;
                foi.MaximizeBox = true;
                foi.StartPosition = FormStartPosition.Manual;
                foi.MdiParent = this;
                foi.Show();
            }
        }

        private void 统计分析TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("暂未实现！");
        }

        private void word文档ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WINWORD.EXE");   //调用系统Word 文档
        }

        private void 记事本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("EXCEL.EXE");// 调用系统Excel
        }

        private void 记事本ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");//调用系统记事本
        }

        private void 计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");// 调用系统计算器
        }

        private void 状态栏ZToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (statusStrip1.Visible)
            {
                statusStrip1.Visible = false;
                状态栏ZToolStripMenuItem1.Checked = false;
                listView1.Height = this.palNavigation.Height - 127;
            }
            else
            {
                statusStrip1.Visible = true;
                状态栏ZToolStripMenuItem1.Checked = true;
            }
            
        }

        private void 竖排窗口VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStrip1.Visible)
            {
                toolStrip1.Visible = false;
                竖排窗口VToolStripMenuItem.Checked = false;
                listView1.Height = this.palNavigation.Height - 127;
            }
            else
            {
                toolStrip1.Visible = true;
                竖排窗口VToolStripMenuItem.Checked = true;
            }
        }

        private void 横排窗口HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            竖排窗口VToolStripMenuItem.Checked = true;
            this.LayoutMdi(MdiLayout.TileVertical);
            横排窗口HToolStripMenuItem.Checked = false;
            层叠窗口CToolStripMenuItem.Checked = false;
        }

        private void 横排窗口CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            横排窗口HToolStripMenuItem.Checked = true;
            this.LayoutMdi(MdiLayout.TileHorizontal);
            层叠窗口CToolStripMenuItem.Checked = false;
            竖排窗口VToolStripMenuItem.Checked = false;
        }

        private void 层叠窗口CToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            层叠窗口CToolStripMenuItem.Checked = true;
            this.LayoutMdi(MdiLayout.Cascade);
            竖排窗口VToolStripMenuItem.Checked = false;
            横排窗口HToolStripMenuItem.Checked = false;
        }

        private void 关闭所有SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] frmList = this.MdiChildren;
            foreach (Form frm in frmList)
            {
                frm.Close();
            }  
        }

        private void 帮助HToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "帮助.doc");//调用帮助
        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmAbout", "关于"))
            {
                frmAbout fm = new frmAbout();
                fm.MdiParent = this;
                fm.Show();
            }
        }

        private void 导入数据RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmBackup", "数据还原"))
            {
                frmBackup up = new frmBackup();
                up.Text = "数据还原";
                up.groupBox1.Text = "数据库还原";
                up.MdiParent = this;
                up.Show();
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frmBookAbout fba = new frmBookAbout();
            fba.Text = "借阅图书";
            fba.rdbBorrow.Checked = true;
            fba.dupBroTime.Visible = true;
            fba.label3.Visible = true;
            fba.dupBookNumber.Visible = true;
            fba.label2.Visible = true;
            if (!OnlyOpen("frmBookAbout", "出借图书"))
            {
                fba.MdiParent = this;
                fba.Show();
            }
        }

        private void 归还图书RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookAbout fba = new frmBookAbout();
            fba.Text = "归还图书";
            fba.rdbReback.Checked = true;
            fba.dupBroTime.Visible = false;
            fba.label3.Visible = false;
            fba.dupBookNumber.Visible = true;
            fba.label2.Visible = true;
            if (!OnlyOpen("frmBookAbout", "归还图书"))
            {
                fba.MdiParent = this;
                fba.Show();
            }
        }

        private void 续借图书XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmBookAbout", "续借图书"))
            {
                frmBookAbout contuine = new frmBookAbout();
                contuine.Text = "续借图书";
                contuine.rdbContuine.Checked = true;
                contuine.MdiParent = this;
                contuine.Show();
            }
        }

        private void 预借图书PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmBookAbout", "预借图书"))
            {
                frmBookAbout fb = new frmBookAbout();
                fb.Text = "预借图书";
                fb.rdbForBorrow.Checked = true;
                fb.MdiParent = this;
                fb.Show();
            }
        }

        private void 操作流水LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmHandleNote", "操作流水"))
            {
                frmHandleNote fhn = new frmHandleNote();
                fhn.MdiParent = this;
                fhn.Show();
            }
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            DBHelper.getCon();
            DBHelper.getCmd();
            if (frmlogin.type != "系统管理员")
            {
                用户管理UToolStripMenuItem.Enabled = false;
            }
            //设置时间和日期
            tssl1.Text = "今天日期：" + DateTime.Now.ToLongDateString();
            tssl2.Text = "登录时间：" + DateTime.Now.ToLongTimeString();
            tsslLoginUser.Text = "当前用户：" + " " + frmlogin.userName;
            //系统启动时导航栏的状态
            listView1.Clear();
            listView1.LargeImageList = imageList1;
            listView1.Items.Add("借阅管理", "借阅管理", 0);
            listView1.Items.Add("借阅查询", "借阅查询", 1);
            listView1.Items.Add("操作流水", "操作流水", 2);
            listView1.Items.Add("预借详情", "预借详情", 3);
            listView1.Items.Add("帐务管理", "帐务管理", 4);
            listView1.Items.Add("备忘管理", "备忘管理", 5);
            //起始窗口布局
            层叠窗口CToolStripMenuItem.Checked = true;
            this.LayoutMdi(MdiLayout.Cascade);
            竖排窗口VToolStripMenuItem.Checked = false;
            横排窗口HToolStripMenuItem.Checked = false;
            toolStrip1.AutoSize = false;
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            notifyIcon1.Visible = false;
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            //Rectangle rect = System.Windows.Forms.SystemInformation.VirtualScreen;   //获得屏幕宽度
            tssl1.Width = this.Width / 5;
            tssl2.Width = this.Width / 5;
            tssl3.Width = this.Width / 5;
            tsslLoginUser.Width = this.Width / 5;
            //插入登录记录   
            string time = DBHelper.GetTime(3);
            string SqlMax = "select Max(Number) from Journal";
            DBHelper.openCon();
            int Number = Convert.ToInt32(DBHelper.ExecuteSelect(SqlMax)) + 1;
            DBHelper.ExeInfochange("insert into Journal values (" + Number + ",'" + frmlogin.userName + "','" + frmlogin.type + "','" + time + "')");
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)  //如果窗体当前是最小化   
            {
                this.ShowInTaskbar = true;
                this.notifyIcon1.Visible = true;
            }
            listView1.Height = this.palNavigation.Height - 124;
        }
        public bool OnlyOpen(string MdiChildrenClassName, string funtion)
        {
            //遍历每一个MDI子窗体实例
            foreach (Form childFrm in this.MdiChildren)
            {
                //若子窗体的类型与实参相同,则存在该类的实例
                if (childFrm.Name == MdiChildrenClassName)
                {
                    //若该窗体被最小化了,则显将其恢复到原来状态
                    if (childFrm.WindowState == FormWindowState.Minimized)
                    {
                        childFrm.WindowState = FormWindowState.Normal;
                    }
                    childFrm.Activate();
                    return true;
                }
            }
            return false;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("您将退出系统,是否继续？", "系统提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tssl3.Text = "现在时间：" + System.DateTime.Now.ToLongTimeString();
            string time = DBHelper.Remindtime();
            if (Convert.ToInt32(DBHelper.ExecuteSelect("select * from Remind where RemindTime='" + time + "'and IsRemind='是' and Statue='尚未提示'")) > 0)
            {
                DataSet ds = new DataSet();
                ds = DBHelper.GetDataset("select * from Remind where RemindTime='" + time + "'");
                string Reminid = Convert.ToString(ds.Tables[0].Rows[0][3]);         //获得备忘表中的备忘记录
                string type = Convert.ToString(ds.Tables[0].Rows[0][5]);
                if (type == "一次提醒")
                {
                    DBHelper.ExeInfochange("update Remind set Statue='已经提示' where RemindTime='" + time + "'");   //更改提示的状态

                }
                if (MessageBox.Show("\n 您有新的备忘：        \n \n" + "    " + Reminid + "    ", "备忘提示", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    fmr.Refresh();
                }
            }
        }
        #region  导航栏字体改变
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Font = new Font(button1.Font, button1.Font.Style | FontStyle.Bold);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Font = new Font(button1.Font, button1.Font.Style ^ FontStyle.Bold);
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {

            button5.Font = new Font(button5.Font, button5.Font.Style | FontStyle.Bold);
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.Font = new Font(button5.Font, button5.Font.Style ^ FontStyle.Bold);
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.Font = new Font(button4.Font, button4.Font.Style | FontStyle.Bold);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Font = new Font(button4.Font, button4.Font.Style ^ FontStyle.Bold);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Font = new Font(button3.Font, button3.Font.Style | FontStyle.Bold);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Font = new Font(button1.Font, button3.Font.Style ^ FontStyle.Bold);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Font = new Font(button2.Font, button2.Font.Style | FontStyle.Bold);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Font = new Font(button2.Font, button2.Font.Style ^ FontStyle.Bold);
        }
        #endregion

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (frmlogin.type == "系统管理员")
            {
                if (listView1.SelectedItems[0].Text == "用户管理")
                {
                    frmUsercontrol fuc = new frmUsercontrol();
                    fuc.Owner = this;
                    fuc.ShowDialog();
                }
            }
            else
            {
                ;
            }
            if (listView1.SelectedItems[0].Text == "切换用户")
            {
                切换用户LToolStripMenuItem_Click(sender,e);
            }
            if (listView1.SelectedItems[0].Text == "修改密码")
            {
                修改密码MToolStripMenuItem_Click(sender, e);
            }
            if (listView1.SelectedItems[0].Text == "系统备份")
            {
                备份管理BToolStripMenuItem_Click(sender, e);
            }
            if (listView1.SelectedItems[0].Text == "系统还原")
            {
                导入数据RToolStripMenuItem_Click(sender, e);
            }
            if (listView1.SelectedItems[0].Text == "读者管理")
            {
                读者资料管理PToolStripMenuItem_Click(sender, e);
            }
           if (listView1.SelectedItems[0].Text == "操作流水")
            {
                操作流水HToolStripMenuItem_Click(sender, e);
            }
            if (listView1.SelectedItems[0].Text == "借阅查询")
            {
                借阅查询BToolStripMenuItem_Click(sender,e);
            }
            if (listView1.SelectedItems[0].Text == "系统初始化")
            {
                系统初始化IToolStripMenuItem_Click(sender,e);
            }
            if (listView1.SelectedItems[0].Text == "借阅管理")
            {
                toolStripMenuItem8_Click(sender, e);
            }
            if (listView1.SelectedItems[0].Text == "预借查询")
            {
                预借详情PToolStripMenuItem_Click(sender, e);
            }
            if (listView1.SelectedItems[0].Text == "预借详情")
            {
                预借详情PToolStripMenuItem_Click(sender, e);
            }
            if (listView1.SelectedItems[0].Text == "书籍管理")
            {
                借阅资料管理LToolStripMenuItem_Click(sender, e);
            }
            if (listView1.SelectedItems[0].Text == "暂时离开")
            {
                 暂时离开OToolStripMenuItem_Click(sender, e);
            }

            if (listView1.SelectedItems[0].Text == "备忘管理")
            {
                  备忘管理RToolStripMenuItem_Click(sender,e);
            }
           
            if (listView1.SelectedItems[0].Text == "系统参数")
            {
                    frmSystemSet fss = new frmSystemSet();
                    fss.ShowDialog();
            }
            if (listView1.SelectedItems[0].Text == "帐务管理")
            {
                if (!OnlyOpen("frmMemorandum", "图书罚款"))
                {
                    frmPenaltryInfo fpi = new frmPenaltryInfo();
                    fpi.MdiParent = this;
                    fpi.Show();
                }
            }
            if (listView1.SelectedItems[0].Text == "添加读者")
            {
                新增读者ToolStripMenuItem_Click(sender, e);
            }
            if (listView1.SelectedItems[0].Text == "添加书籍")
            {
                新增书籍BToolStripMenuItem_Click(sender, e);
            }
            if (listView1.SelectedItems[0].Text == "出版社资料")
            {
                出版社ToolStripMenuItem_Click(sender, e);
            }
            if (listView1.SelectedItems[0].Text == "逾期查询")
            {
                逾期列表GToolStripMenuItem_Click(sender, e);
            }
            if (listView1.SelectedItems[0].Text == "罚款查询")
            {
                帐务管理EToolStripMenuItem_Click(sender, e);
            }
            if (listView1.SelectedItems[0].Text == "图书档案查询")
            {
                借阅资料管理LToolStripMenuItem_Click(sender, e);
            }
            if (listView1.SelectedItems[0].Text == "读者档案查询")
            {
                读者资料管理PToolStripMenuItem_Click(sender, e);
            }
        }

        private void 登录日志DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmLodingJournal", "查看登录日志"))
            {
                frmLodingJournal flj = new frmLodingJournal();
                flj.MdiParent = this;
                flj.Show();
            }
        }

        private void tsbQuery_Click(object sender, EventArgs e)
        {
            借阅查询BToolStripMenuItem_Click(sender, e);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1;
            if (Opacity == 1)
            {
                timer2.Dispose();
            }
        }

        private void 出版社ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmPublishing", "出版社"))
            {
                frmPublishing fps = new frmPublishing();
                fps.MdiParent = this;
                fps.Show();
            }
        }

        private void 借阅资料管理LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmBookManage", "借阅资料管理"))
            {
                frmBookManage fbm = new frmBookManage();
                fbm.MdiParent = this;
                fbm.Show();
            }
        }

        private void 新增书籍BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmBookCorA", "新增书籍"))
            {
                frmBookCorA fbca = new frmBookCorA();
                fbca.Text = "图书管理(添加)";
                fbca.ShowDialog();
            }
        }

        private void 新增读者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmReaderAdd", "新增读者"))
            {
                frmReaderAdd fra = new frmReaderAdd();
                fra.ShowDialog(this);
            }
        }

        private void tsbFine_Click(object sender, EventArgs e)
        {
            if (!OnlyOpen("frmPenaltryInfo", "图书罚款"))
            {
                frmPenaltryInfo fpi = new frmPenaltryInfo();
                fpi.MdiParent = this;
                fpi.Show();
            }
        }

        private void tsmBookBorrow_Click(object sender, EventArgs e)
        {
            toolStripMenuItem8_Click(sender, e);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            归还图书RToolStripMenuItem_Click(sender, e);
        }

        private void tsmTimeleave_Click(object sender, EventArgs e)
        {
            暂时离开OToolStripMenuItem_Click(sender, e);
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            //如果有子窗口,则关闭子窗体
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }

        private void 后台信息发布LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInfoDiffusion fid = new frmInfoDiffusion();
            fid.MdiParent = this;
            fid.Show();
        }

        private void fadeTimer_Tick(object sender, EventArgs e)
        {
            double d = 0.05;
            if (showing)
            {
                if (Opacity + d >= 1.0)
                {
                    Opacity = 1.0;
                    fadeTimer.Stop();
                }
                else
                {
                    Opacity += d;
                }
            }
            else
            {
                if (Opacity - d <= 0.0)
                {
                    Opacity = 0.0;
                    fadeTimer.Stop();
                }
                else
                {
                    Opacity -= d;
                }
            }
        }
    }
}
