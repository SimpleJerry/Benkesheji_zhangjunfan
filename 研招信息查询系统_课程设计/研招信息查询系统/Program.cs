using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Win32;
using System.IO;
using System.Text;

namespace 研招信息查询系统
{
    public static class SqlHelper
    {
        //获取数据库连接 返回连接对象
        public static SqlConnection GetConn()
        {
            return new SqlConnection("server=.;database=研招信息查询系统;integrated security=SSPI");
        }

        // 执行sql语句，返回受影响行数
        public static int ExecuteNonQuery(string sql)
        {
            int rows = -1;
            using (SqlConnection conn = GetConn())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    rows = cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("请不要输入非法字符集!");
                }

            }
            return rows;
        }

        //传入账号和密码，查询“用户表”中是否有对应的信息，用于登录模块
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

        //执行sql语序，将查询结果填充入comboBox中
        public static void AddInComboBox(ComboBox comboBox, string sql)
        {
            using (SqlConnection conn = GetConn())
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet(); //创建数据集
                conn.Open();
                da.Fill(ds);
                conn.Close();
                foreach (DataRow Row in ds.Tables[0].Rows)
                {
                    object item = Row.ItemArray[0];
                    //不存在才添加
                    if (!comboBox.Items.Contains(item))
                        comboBox.Items.Add(Row.ItemArray[0]);
                }
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
                string sql = String.Format("UPDATE {0} SET {1} WHERE {2};", Table, Set, Where);
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

        //---以下两个方法，由黄雅雯创建---
        //输入sql语句，数据信息string输出
        public static string DataToString(string str)
        {
            using (SqlConnection conn = GetConn())
            {
                string sql = str;
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet(); //创建数据集
                conn.Open();
                da.Fill(ds);
                conn.Dispose();
                conn.Close();
                int n = ds.Tables[0].Rows.Count;
                string a = "";
                for (int i = 0; i < n; i++)
                {
                    a += ds.Tables[0].Rows[i][0].ToString();
                }
                a = a.Replace("\\", "");
                a = a.Replace(":\"[", ":[");
                a = a.Replace("]\"}", "]}");
                a = a.Replace("]\",", "],");
                return a;
            }
        }

        //写入并保存json文件
        public static void SaveFile(string str1, string str2)
        {
            DirectoryInfo di = new DirectoryInfo(string.Format(@"{0}../../", Application.StartupPath));
            string file = di.FullName + "data/" + str2 + ".json";
            FileStream fs = new FileStream(file, FileMode.Create);
            StreamWriter wr = new StreamWriter(fs);
            wr.Write("dd(");
            wr.Write(str1);
            wr.Write(")");
            wr.Close();
        }
    }

    public static class WebSetting
    {
        /// <summary>
        /// 定义IE版本的枚举
        /// </summary>
        public enum IeVersion
        {
            强制ie10,//10001 (0x2711) Internet Explorer 10。网页以IE 10的标准模式展现，页面!DOCTYPE无效
            标准ie10,//10000 (0x02710) Internet Explorer 10。在IE 10标准模式中按照网页上!DOCTYPE指令来显示网页。Internet Explorer 10 默认值。
            强制ie9,//9999 (0x270F) Windows Internet Explorer 9. 强制IE9显示，忽略!DOCTYPE指令
            标准ie9,//9000 (0x2328) Internet Explorer 9. Internet Explorer 9默认值，在IE9标准模式中按照网页上!DOCTYPE指令来显示网页。
            强制ie8,//8888 (0x22B8) Internet Explorer 8，强制IE8标准模式显示，忽略!DOCTYPE指令
            标准ie8,//8000 (0x1F40) Internet Explorer 8默认设置，在IE8标准模式中按照网页上!DOCTYPE指令展示网页
            标准ie7//7000 (0x1B58) 使用WebBrowser Control控件的应用程序所使用的默认值，在IE7标准模式中按照网页上!DOCTYPE指令来展示网页
        }

        /// <summary>
        /// 设置WebBrowser的默认版本
        /// </summary>
        /// <param name="ver">IE版本</param>
        public static void SetIE(IeVersion ver)
        {
            string productName = AppDomain.CurrentDomain.SetupInformation.ApplicationName;//获取程序名称

            object version;
            switch (ver)
            {
                case IeVersion.标准ie7:
                    version = 0x1B58;
                    break;
                case IeVersion.标准ie8:
                    version = 0x1F40;
                    break;
                case IeVersion.强制ie8:
                    version = 0x22B8;
                    break;
                case IeVersion.标准ie9:
                    version = 0x2328;
                    break;
                case IeVersion.强制ie9:
                    version = 0x270F;
                    break;
                case IeVersion.标准ie10:
                    version = 0x02710;
                    break;
                case IeVersion.强制ie10:
                    version = 0x2711;
                    break;
                default:
                    version = 0x1F40;
                    break;
            }

            RegistryKey key = Registry.CurrentUser;
            RegistryKey software =
                key.CreateSubKey(
                    @"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION\" + productName);
            if (software != null)
            {
                software.Close();
                software.Dispose();
            }
            RegistryKey wwui =
                key.OpenSubKey(
                    @"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true);
            //该项必须已存在
            if (wwui != null) wwui.SetValue(productName, version, RegistryValueKind.DWord);
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
            Application.Run(new 登录界面Form());
        }
    }
}
