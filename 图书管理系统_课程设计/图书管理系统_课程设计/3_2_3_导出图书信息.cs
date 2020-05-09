using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图书管理系统_课程设计
{
    public partial class 导出图书信息Form : Form
    {
        public 导出图书信息Form()
        {
            InitializeComponent();
            SqlHelper.ShowDataWithDataGirdView(dataGridView1, "SELECT B_ISBN ISBN,B_name 书名,B_author 作者,B_pubcom 出版社,B_pubtime 出版日期,B_price 价格 FROM Book_info;");
        }

        private void 导出button_Click(object sender, EventArgs e)
        {
            DataTable dt = ExcelHelper.GetDgvToTable(dataGridView1);
            if (导出文件路径textBox.Text == "")
            {
                MessageBox.Show("路径不可为空");
            }
            else
            {
                try
                {
                    ExcelHelper.DataTableToExcel(导出文件路径textBox.Text + "\\图书信息_导出文件.xls", dt);
                    MessageBox.Show("已成功导出！");
                }
                catch
                {
                    MessageBox.Show("产生错误！", "错误");
                }
            }
        }

        private void 选择路径button_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                导出文件路径textBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void 导出图书信息Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
        }
    }
}
