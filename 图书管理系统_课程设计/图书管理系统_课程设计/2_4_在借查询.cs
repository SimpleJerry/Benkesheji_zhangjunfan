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
    public partial class 在借查询Form : Form
    {
        public 在借查询Form()
        {
            InitializeComponent();
        }

        private void 查询在借书籍button_Click(object sender, EventArgs e)
        {
            if (查询在借书籍textBox.Text == "(全部)" || 查询在借书籍textBox.Text == "")
            {
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, "SELECT * FROM Borrow_View; ");
            }
            else
            {
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, String.Format("SELECT * FROM Borrow_View WHERE {0} LIKE '%{1}%' OR {2} LIKE '%{3}%'OR {4} LIKE '%{5}%' OR {6} LIKE '%{7}%' ; ", "书名", 查询在借书籍textBox.Text, "ISBN", 查询在借书籍textBox.Text, "读者姓名", 查询在借书籍textBox.Text, "读者帐号", 查询在借书籍textBox.Text));
            }

            
        }

        private void 在借查询Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
        }
    }
}
