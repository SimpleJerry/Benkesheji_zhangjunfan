using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 图书管理系统_课程设计
{
    public partial class 导入读者信息Form : Form
    {
        public 导入读者信息Form()
        {
            InitializeComponent();
        }

        private void 导入button_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = ExcelHelper.ExcelToDataTable(导入文件路径textBox.Text, true);
                int number = 0;//用于记录执行成功的sql语句条数
                using (SqlConnection conn = SqlHelper.GetConn())
                {
                    conn.Open();
                    //设置跟踪条
                    trackBar1.Maximum = dt.Rows.Count;
                    trackBar1.Minimum = 0;
                    trackBar1.TickFrequency = 100;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        trackBar1.Value = i;
                        string R_id = dt.Rows[i][0].ToString();
                        string R_account = dt.Rows[i][1].ToString();
                        string R_name = dt.Rows[i][2].ToString();
                        string R_phone = dt.Rows[i][3].ToString();
                        string R_email = dt.Rows[i][4].ToString();
                        string R_condition = dt.Rows[i][5].ToString();

                        string sql = string.Format("INSERT INTO Reader(R_id,R_account,R_password,R_name,R_phone,R_email,R_condition) VALUES('{0}','{1}','123456','{2}','{3}','{4}','{5}');", R_id, R_account, R_name, R_phone, R_email, R_condition);
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        try
                        {
                            number += cmd.ExecuteNonQuery();//即成功执行时number+=1
                        }
                        catch
                        {

                        }
                    }
                    conn.Close();
                }
                MessageBox.Show(string.Format("总计{0}条数据被插入", number.ToString()));
            }
            catch
            {
                MessageBox.Show("路径错误！","失败");
            }
        }

        private void 选择路径button_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                导入文件路径textBox.Text = openFileDialog1.FileName;
            }
        }

        private void 导入读者信息Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
        }
    }
}
