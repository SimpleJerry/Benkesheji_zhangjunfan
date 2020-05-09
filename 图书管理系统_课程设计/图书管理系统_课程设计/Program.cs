using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;

using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace 图书管理系统_课程设计
{

    public static class SqlHelper
    {
        //获取数据库连接 返回连接对象
        public static SqlConnection GetConn()
        {
            return new SqlConnection("server=.;database=library;integrated security=SSPI");
        }

        // 执行sql语句，返回受影响行数 
        private static int ExecuteNonQuery(string sql)
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

        //传入账号和密码，查询“读者表”中是否有对应的信息，用于登录模块
        public static bool CheckReaderPassword(string Id, string Password)
        {
            bool passed = false;
            using (SqlConnection conn = GetConn())
            {
                string sql = "SELECT count(*) FROM Reader WHERE R_account =@Id AND R_password =@Password";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@Id", Id));
                cmd.Parameters.Add(new SqlParameter("@Password", Password));
                conn.Open();
                // 返回受影响的行数  
                int obj = Convert.ToInt32(cmd.ExecuteScalar());
                if (obj > 0)
                {
                    passed = true;
                }
            }
            return passed;
        }

        //传入账号和密码，查询“管理员表”中是否有对应的信息，用于登录模块
        public static bool CheckAdminPassword(string Id, string Password)
        {
            bool passed = false;
            using (SqlConnection conn = GetConn())
            {
                string sql = "SELECT count(*) FROM Admin WHERE A_account =@Id AND A_password =@Password";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@Id", Id));
                cmd.Parameters.Add(new SqlParameter("@Password", Password));
                conn.Open();
                int obj = Convert.ToInt32(cmd.ExecuteScalar());
                if (obj > 0)
                {
                    passed = true;
                }
            }
            return passed;
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
                string sql = String.Format("INSERT INTO {0} VALUES{1}", Table, Values);
                SqlCommand cmd = new SqlCommand(sql, conn);
                int i = SqlHelper.ExecuteNonQuery(sql);

                if (i == 1)
                {
                    MessageBox.Show("成功注册新用户");
                }
                else
                {
                    MessageBox.Show("操作失败,请联系管理员");
                }
            }
        }

        //执行sql语句，对指定的Table进行数据的删除操作
        public static void DeleteItem(string Table, string Attr, string Value)
        {
            using (SqlConnection conn = GetConn())
            {
                string sql = String.Format("DELETE FROM {0} WHERE  {1} = '{2}';", Table, Attr, Value);
                //得到受影响的行数
                int j = SqlHelper.ExecuteNonQuery(sql);

                if (j == 0)
                    MessageBox.Show("删除失败！");
                else
                    MessageBox.Show(j.ToString());
            }

        }

        //执行sql语句，对指定的Table进行数据的删除操作,用MessageBox提示删除成功或是失败
        public static void DeleteItem1(string Table, string Attr, string Value)
        {
            using (SqlConnection conn = GetConn())
            {
                string sql = String.Format("DELETE FROM {0} WHERE  {1} = '{2}';", Table, Attr, Value);
                int j = SqlHelper.ExecuteNonQuery(sql);

                if (j == 0)
                    MessageBox.Show("删除失败！");
                else
                    MessageBox.Show("删除成功");
            }

        }

        //执行sql语句，对指定的Table进行数据的更新操作,用MessageBox提示删除成功或是失败
        public static void UpdatetItem(string Table, string Set_name, string Set_values, string Where_name, string Where_values)
        {
            using (SqlConnection conn = GetConn())
            {
                string sql = String.Format(" UPDATE {0} SET {1}='{2}' WHERE {3}='{4}';", Table, Set_name, Set_values, Where_name, Where_values);
                SqlCommand cmd = new SqlCommand(sql, conn);
                int i = SqlHelper.ExecuteNonQuery(sql);

                if (i == 1)
                    MessageBox.Show("更新信息成功");
                else
                    MessageBox.Show("信息更新失败！");
            }
        }

        //执行sql语句，对指定的Table进行数据的更新操作,成功返回1，不成功返回0
        public static int UpdatetItem1(string Table, string Set_name, string Set_values, string Where_name, string Where_values)
        {
            using (SqlConnection conn = GetConn())
            {
                string sql = String.Format(" UPDATE {0} SET {1}='{2}' WHERE {3}='{4}';", Table, Set_name, Set_values, Where_name, Where_values);
                SqlCommand cmd = new SqlCommand(sql, conn);
                int i = SqlHelper.ExecuteNonQuery(sql);

                if (i == 1)
                    return 1;
                else
                    return 0;
            }
        }
        
        //执行sql语句，返回查询的第一个结果，若查询失败，返回字符串'Not Found!'
        public static string SelectItem(string Table, string Select_name, string Where_name, string Where_value)
        {
            using (SqlConnection conn = GetConn())
            {
                string sql = String.Format("SELECT {0} FROM {1} WHERE {2}='{3}'", Select_name, Table, Where_name, Where_value);
                DataSet ds = new DataSet(); //创建数据集
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(sql, conn);
                da.Fill(ds);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string temp = dr.GetValue(0).ToString();
                    conn.Close();
                    return temp;
                }
                else
                {
                    conn.Close();
                    return "Not Found!";
                }
            }
        }

        //执行sql语句，返回查询结果中的最大项，主要用于新注册用户时对其自动编号(即取相应的Id的最大值再加上一）
        public static string SelectItem_OnlyMax(string Table, string Select_name, string Where_name)
        {
            using (SqlConnection conn = GetConn())
            {
                string sql = String.Format("SELECT {0} FROM {1} WHERE {2} {3}", Select_name, Table, Where_name, "IS NOT NULL");
                DataSet ds = new DataSet(); //创建数据集
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(sql, conn);
                da.Fill(ds);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string temp = dr.GetValue(0).ToString();
                    conn.Close();
                    return temp;
                }
                else
                {
                    conn.Close();
                    return "Not Found!";
                }
            }
        }
    }

    //以下代码来自网络，特此说明
    public class ExcelHelper
    {
        /// <summary>  
        /// 将excel导入到datatable  
        /// </summary>  
        /// <param name="filePath">excel路径</param>  
        /// <param name="isColumnName">第一行是否是列名</param>  
        /// <returns>返回datatable</returns>  
        public static DataTable ExcelToDataTable(string filePath, bool isColumnName)
        {
            DataTable dataTable = null;
            FileStream fs = null;
            DataColumn column = null;
            DataRow dataRow = null;
            IWorkbook workbook = null;
            ISheet sheet = null;
            IRow row = null;
            ICell cell = null;
            int startRow = 0;
            try
            {
                using (fs = File.OpenRead(filePath))
                {
                    // 2007版本  
                    if (filePath.IndexOf(".xlsx") > 0)
                        workbook = new XSSFWorkbook(fs);
                    // 2003版本  
                    else if (filePath.IndexOf(".xls") > 0)
                        workbook = new HSSFWorkbook(fs);

                    if (workbook != null)
                    {
                        sheet = workbook.GetSheetAt(0);//读取第一个sheet，当然也可以循环读取每个sheet  
                        dataTable = new DataTable();
                        if (sheet != null)
                        {
                            int rowCount = sheet.LastRowNum;//总行数  
                            if (rowCount > 0)
                            {
                                IRow firstRow = sheet.GetRow(0);//第一行  
                                int cellCount = firstRow.LastCellNum;//列数  

                                //构建datatable的列  
                                if (isColumnName)
                                {
                                    startRow = 1;//如果第一行是列名，则从第二行开始读取  
                                    for (int i = firstRow.FirstCellNum; i < cellCount; ++i)
                                    {
                                        cell = firstRow.GetCell(i);
                                        if (cell != null)
                                        {
                                            if (cell.StringCellValue != null)
                                            {
                                                column = new DataColumn(cell.StringCellValue);
                                                dataTable.Columns.Add(column);
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    for (int i = firstRow.FirstCellNum; i < cellCount; ++i)
                                    {
                                        column = new DataColumn("column" + (i + 1));
                                        dataTable.Columns.Add(column);
                                    }
                                }

                                //填充行  
                                for (int i = startRow; i <= rowCount; ++i)
                                {
                                    row = sheet.GetRow(i);
                                    if (row == null) continue;

                                    dataRow = dataTable.NewRow();
                                    for (int j = row.FirstCellNum; j < cellCount; ++j)
                                    {
                                        cell = row.GetCell(j);
                                        if (cell == null)
                                        {
                                            dataRow[j] = "";
                                        }
                                        else
                                        {
                                            //CellType(Unknown = -1,Numeric = 0,String = 1,Formula = 2,Blank = 3,Boolean = 4,Error = 5,)  
                                            switch (cell.CellType)
                                            {
                                                case CellType.Blank:
                                                    dataRow[j] = "";
                                                    break;
                                                case CellType.Numeric:
                                                    short format = cell.CellStyle.DataFormat;
                                                    //对时间格式（2015.12.5、2015/12/5、2015-12-5等）的处理  
                                                    if (format == 14 || format == 31 || format == 57 || format == 58)
                                                        dataRow[j] = cell.DateCellValue;
                                                    else
                                                        dataRow[j] = cell.NumericCellValue;
                                                    break;
                                                case CellType.String:
                                                    dataRow[j] = cell.StringCellValue;
                                                    break;
                                            }
                                        }
                                    }
                                    dataTable.Rows.Add(dataRow);
                                }
                            }
                        }
                    }
                }
                return dataTable;
            }
            catch (Exception)
            {
                if (fs != null)
                {
                    fs.Close();
                }
                return null;
            }
        }


        public static bool DataTableToExcel(string filePath, DataTable dt)
        {
            bool result = false;
            IWorkbook workbook = null;
            FileStream fs = null;
            IRow row = null;
            ISheet sheet = null;
            ICell cell = null;
            try
            {
                if (dt != null && dt.Rows.Count > 0)
                {
                    workbook = new HSSFWorkbook();
                    sheet = workbook.CreateSheet("Sheet0");//创建一个名称为Sheet0的表  
                    int rowCount = dt.Rows.Count;//行数  
                    int columnCount = dt.Columns.Count;//列数  

                    //设置列头  
                    row = sheet.CreateRow(0);//excel第一行设为列头  
                    for (int c = 0; c < columnCount; c++)
                    {
                        cell = row.CreateCell(c);
                        cell.SetCellValue(dt.Columns[c].ColumnName);
                    }

                    //设置每行每列的单元格,  
                    for (int i = 0; i < rowCount; i++)
                    {
                        row = sheet.CreateRow(i + 1);
                        for (int j = 0; j < columnCount; j++)
                        {
                            cell = row.CreateCell(j);//excel第二行开始写入数据  
                            cell.SetCellValue(dt.Rows[i][j].ToString());
                        }
                    }
                    using (fs = File.OpenWrite(@filePath))
                    {
                        workbook.Write(fs);//向打开的这个xls文件中写入数据  
                        result = true;
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                if (fs != null)
                {
                    fs.Close();
                }
                return false;
            }
        }

        static public DataTable GetDgvToTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();
            for (int count = 0; count < dgv.Columns.Count; count++)
            {
                DataColumn dc = new DataColumn(dgv.Columns[count].Name.ToString());
                dt.Columns.Add(dc);
            }
            for (int count = 0; count < dgv.Rows.Count; count++)
            {
                DataRow dr = dt.NewRow();
                for (int countsub = 0; countsub < dgv.Columns.Count; countsub++)
                {
                    dr[countsub] = Convert.ToString(dgv.Rows[count].Cells[countsub].Value);
                }
                dt.Rows.Add(dr);
            }
            return dt;
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
            //Application.Run(new 管理员界面Form("admin", "张俊帆", "管理员"));
        }
    }



}
