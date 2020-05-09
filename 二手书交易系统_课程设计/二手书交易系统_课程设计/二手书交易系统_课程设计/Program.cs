using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace 二手书交易系统_课程设计
{
    public static class SqlHelper
    {
        //获取数据库连接 返回连接对象
        public static SqlConnection GetConn()
        {
            return new SqlConnection("server=.;database=二手书交易系统;integrated security=SSPI");
        }

        // 执行sql语句，返回受影响行数
        public static int ExecuteNonQuery(string sql)
        {
            int rows = -1;
            using (SqlConnection conn = GetConn())
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                rows = cmd.ExecuteNonQuery();
            }
            return rows;
        }

        //传入账号和密码，查询“用户表”或“管理员表”中是否有对应的信息，用于登录模块
        public static bool CheckPassword(string Table, string Account, string Password)
        {
            using (SqlConnection conn = GetConn())
            {
                string sql = string.Format("SELECT COUNT(*) FROM {0} WHERE 帐号 ='{1}' AND 密码 ='{2}';", Table, Account, Password);
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                int obj = Convert.ToInt32(cmd.ExecuteScalar());
                if (obj > 0)
                    return true;
                else
                    return false;
            }
        }

        //查询指定表中是否有对应信息
        public static bool CheckExist(string Table, string Where)
        {
            using (SqlConnection conn = GetConn())
            {
                string sql = string.Format("SELECT COUNT(*) FROM {0} WHERE {1};", Table, Where);
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                int obj = Convert.ToInt32(cmd.ExecuteScalar());
                if (obj > 0)
                    return true;
                else
                    return false;
            }
        }

        //执行sql语句，并把查询结果用传入的dataGridView显示出来
        public static void ShowDataWithDataGirdView(DataGridView dataGridView, string sql)//定义函数
        {
            using (SqlConnection conn = GetConn())
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet(); //创建数据集
                conn.Open();
                da.Fill(ds);
                conn.Close();
                dataGridView.DataSource = ds.Tables[0].DefaultView;
            }
        }

        //执行sql语句，对指定的Table进行数据的插入操作
        public static void InsertItem(string Table, string Values)
        {
            using (SqlConnection conn = GetConn())
            {
                string sql = String.Format("INSERT INTO {0} VALUES {1}", Table, Values);
                SqlHelper.ExecuteNonQuery(sql);
            }
        }

        //执行sql语句，对指定的Table进行数据的删除操作
        public static bool DeleteItem(string Table, string Where)
        {
            using (SqlConnection conn = GetConn())
            {
                string sql = String.Format("DELETE FROM {0} WHERE {1};", Table, Where);
                int j = SqlHelper.ExecuteNonQuery(sql); //得到受影响的行数

                if (j == 1)
                    return true;
                else
                {
                    return false;
                }
            }
        }

        //执行sql语句，对指定的Table进行数据的更新操作
        public static bool UpdateItem(string Table, string Set, string Where)
        {
            using (SqlConnection conn = GetConn())
            {
                string sql = String.Format(" UPDATE {0} SET {1} WHERE {2};", Table, Set, Where);
                int i = SqlHelper.ExecuteNonQuery(sql);
                if (i == 1)
                    return true;
                else
                    return false;
            }
        }

        //执行sql语句，对指定Table的指定属性进行加或减操作，默认加减1
        public static void Updatet_ChangeNum(string Table, string Num_name, string Where, bool Increase, double number = 1)
        {
            using (SqlConnection conn = GetConn())
            {
                string sql;
                if (Increase == true)
                    sql = String.Format("UPDATE {0} SET {1}+={2} WHERE {3};", Table, Num_name, number, Where);
                else
                    sql = String.Format("UPDATE {0} SET {1}-={2} WHERE {3};", Table, Num_name, number, Where);
                SqlHelper.ExecuteNonQuery(sql);
            }
        }

        //执行sql语句，返回查询的第一个结果，若查询失败，返回字符串'Not Found!'
        public static string InquireItem(string Table, string Inquire_name, string Where)
        {
            using (SqlConnection conn = GetConn())
            {
                string sql = String.Format("SELECT {0} FROM {1} WHERE {2}", Inquire_name, Table, Where);
                DataSet ds = new DataSet(); //创建数据集
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(sql, conn);
                da.Fill(ds);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                string temp = "Not Found!";
                if (dr.Read())
                    temp = dr.GetValue(0).ToString();
                conn.Close();
                return temp;
            }
        }

        //执行sql语句，返回查询结果中的最大项，主要用于新注册用户时对其自动编号(即取相应的Id的最大值再加上一）
        public static int GetID(string Table, string item)
        {
            using (SqlConnection conn = GetConn())
            {
                string sql = String.Format("SELECT MAX({0}) FROM {1};", item, Table);
                DataSet ds = new DataSet(); //创建数据集
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(sql, conn);
                da.Fill(ds);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int Number_new = 1;
                    try
                    {
                        Number_new = Convert.ToInt32(dr.GetValue(0)) + 1;
                    }
                    catch { }//如果查不到就会报错，最终就会返回1
                    conn.Close();
                    return Number_new;
                }
                else
                {
                    conn.Close();
                    return 1;
                }
            }
        }
    }

    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new 登录界面Form());
            //Application.Run(new 管理员界面Form("admin", "张俊帆", "管理员"));
            Application.Run(new 用户界面Form("201610311104", "张俊帆", "用户"));
        }
    }
}