using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 图书馆管理系统
{
    class DBHelper
    {
        public static string conStr = "Data Source=ZJZL-20210105OR\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True";
        public static SqlConnection con = null;
        public static SqlCommand cmd = null;
        public static SqlDataReader dr = null;
        public static SqlDataAdapter da = null;

        public static DataSet ds = new DataSet();

        //定义获取数据库连接对象的方法
        public static SqlConnection getCon()
        {
            con = new SqlConnection(conStr);
            return con;
        }
        //定义打开数据库连接对象的方法
        public static void openCon()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }
        //定义关闭数据库连接对象的方法
        public static void closeCon()
        {
            if (con != null)
                con.Close();
        }
        //定义获取数据库访问对象的方法
        public static SqlCommand getCmd()
        {
            cmd = new SqlCommand();
            cmd.Connection = con;
            return cmd;
        }
        //定义执行增删改sql语句的方法
        public static int nonQuery(string sql)
        {
            openCon();//调用openCon方法打开连接
            cmd.CommandText = sql;//告诉搬运工要执行的SQL语句

            //调用cmd对象的ExecuteNonQuery方法执行sql语句
            //执行完语句后返回受影响的行数保存在num变量上

            int num = cmd.ExecuteNonQuery();
            closeCon();//调用closeCon方法关闭连接
            return num;//返回受影响的行数
        }
        //定义执行查询语句的方法
        public static SqlDataReader query(string sql)
        {
            cmd.CommandText = sql;//告诉搬运工要执行的查询语句
            dr = cmd.ExecuteReader();
            return dr;
        }
        //定义从数据库取数据并填充到数据集里的方法
        //该方法接受两个参数，第一个参数就是要执行的sql语句，第二个参数是填充时指定的表名
        public static DataSet fill(string sql, string tableName)
        {
            //创建数据适配器对象
            da = new SqlDataAdapter(sql, con);
            //填充数据前先清空数据集
            if (ds.Tables[tableName] != null)//先判断数据集里是否有这个
                ds.Tables[tableName].Clear();

            //调用da对象的Fill方法执行语句并将查询结果填充到数据集，同时指定表名
            da.Fill(ds, tableName);
            return ds;//返回数据集
        }
        //定义执行查询语句的方法(ExecuteScalar)
        public static object Scalar(string sql)
        {
            openCon();
            cmd.CommandText = sql;//告诉搬运工要执行的查询语句
            object num = cmd.ExecuteScalar();
            closeCon();
            return num;
        }
        public static int ExeInfochange(string sql)
        {
            try
            {
                SqlConnection myConnection = getCon();
                SqlCommand myCommand = myConnection.CreateCommand();
                myCommand.CommandText = sql;
                myConnection.Open();
                int number = myCommand.ExecuteNonQuery();
                myConnection.Close();
                myConnection.Dispose();
                return number;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public static object ExecuteSelect(string sql)
        {
            try
            {
                SqlConnection myConnection = getCon();
                SqlCommand myCommand = myConnection.CreateCommand();
                myCommand.CommandText = sql;
                myConnection.Open();
                int number = Convert.ToInt32(myCommand.ExecuteScalar());
                myConnection.Close();
                myConnection.Dispose();
                return number;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        /// 获得时间字符串
        public static string GetTime(int Number)
        {
            DateTime Str = Convert.ToDateTime(DateTime.Now.ToString());
            string Mditime = Str.ToString("yyyy/MM/dd hh:mm:ss");
            // string Time = Str.ToString().Substring(0,Number);
            string Time = Mditime.Substring(0, Mditime.Length - Number);
            return Time;
        }
        
        // 获得备忘时间
        public static string Remindtime()
        {
            DateTime Str = Convert.ToDateTime(DateTime.Now.ToString());
            string RemindTime = Str.ToString();
            return RemindTime;
        }
        /// <summary>
        ///  下拉形式显示数据
        /// </summary>
        /// <param name="Sql">Sql 语句</param>
        /// <param name="field">字段名</param>
        /// <param name="name">ComboBox名称</param>
        public static void ShowInfoList(string Sql, string field, ComboBox name)
        {
            try
            {
                SqlConnection conn = new SqlConnection("server=(local);database =Library;integrated security=true");
                SqlDataAdapter da = new SqlDataAdapter(Sql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                name.DataSource = ds.Tables[0];      //以下拉的形式显示所有用户名
                name.DisplayMember = field;
                conn.Close();
            }
            catch (Exception)
            {
                ;
            }
        }
        /// <summary>
        /// 获取数据集
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>DataSet GetDataset</returns>
        public static DataSet GetDataset(string sql)
        {
            try
            {
                DataSet ds = new DataSet();
                string strConn = @"server=.\sql2008d;database =Library;integrated security=true";
                SqlConnection conn = new SqlConnection(strConn);
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                int i = adapter.Fill(ds);
                if (i == 0)
                    return null;
                else
                    return ds;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 获取数据集
        /// </summary>
        /// <param name="str1"></param>
        /// <returns>DataSet ds</returns>
        public static DataSet ds2(string str1)
        {
            string sql = str1;
            try
            {
                SqlConnection myConnection = getCon();
                SqlCommand myCommand = myConnection.CreateCommand();
                myCommand.CommandText = sql;
                myConnection.Open();
                SqlDataAdapter myDataReader = new SqlDataAdapter();
                myDataReader.SelectCommand = myCommand;
                DataSet ds = new DataSet();
                myDataReader.Fill(ds);
                myConnection.Close();
                myConnection.Dispose();
                return ds;

            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// 显示DGV数据
        /// </summary>
        /// <param name="str">sql 查询语句</param>
        /// <param name="dgv">DataGridView</param>
        public static void InfoShow(string str, DataGridView dgv)
        {
            try
            {
                DataSet dsNote;
                string strSql = str;
                dsNote =ds2(strSql);
                dgv.DataSource = dsNote;
                dgv.DataMember = dsNote.Tables[0].ToString();
            }
            catch (Exception)
            {
                ;
            }
        }
        /// <summary>
        /// 将DataGridView控件中数据导出到Excel
        /// </summary>
        /// <param name="gridView">DataGridView对象</param>
        /// <param name="isShowExcle">是否显示Excel界面</param>
        /// <returns></returns>
        public static bool ShowDgvInfo(DataGridView gridView, bool isShowExcle)
        {
            if (gridView.Rows.Count == 0)
                return false;
            //建立Excel对象

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            excel.Visible = isShowExcle;
            //生成字段名称
            for (int i = 0; i < gridView.ColumnCount; i++)
            {
                excel.Cells[1, i + 1] = gridView.Columns[i].HeaderText;
            }
            //填充数据
            try
            {
                for (int i = 0; i < gridView.RowCount; i++)
                {
                    for (int j = 0; j < gridView.ColumnCount; j++)
                    {
                        if (gridView[j, i].ValueType == typeof(string))
                        {
                            excel.Cells[i + 2, j + 1] = "'" + gridView[j, i].Value.ToString();
                        }
                        else
                        {
                            excel.Cells[i + 2, j + 1] = gridView[j, i].Value.ToString();
                        }
                    }
                }
            }
            catch (Exception )
            {
                ;
            }
            return true;
        }
    }
        
}
