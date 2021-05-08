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
    public partial class frmSystemInterface : Form
    {
        public frmSystemInterface()
        {
            InitializeComponent();
        }

        private void btnPhotoWay_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();            //弹出打开对话框
            txtPhotoWay.Text = openFileDialog1.FileName; 
        }
    }
}
