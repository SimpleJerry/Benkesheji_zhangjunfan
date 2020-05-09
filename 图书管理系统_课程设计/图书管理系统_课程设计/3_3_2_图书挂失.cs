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
    public partial class 图书挂失Form : Form
    {
        public 图书挂失Form()
        {
            InitializeComponent();
            this.comboBox1.Text = this.comboBox1.Items[0].ToString();
        }

        private void 查询button_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "查找所有书籍")
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, "SELECT * FROM Storage_View WHERE 在馆状态='在馆';");
            else if (comboBox1.Text == "按书名查找")
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, string.Format("SELECT * FROM Storage_View WHERE 书名='{0}' AND 在馆状态='在馆';", textBox1.Text));
            else if (comboBox1.Text == "按ISBN查找")
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, string.Format("SELECT * FROM Storage_View WHERE ISBN='{0}' AND 在馆状态='在馆';", textBox1.Text));
            else if (comboBox1.Text == "按作者查找")
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, string.Format("SELECT * FROM Storage_View WHERE 作者 LIKE '%{0}%' AND 在馆状态='在馆';", textBox1.Text));
            else
                MessageBox.Show("请正确选择匹配模式！", "错误！");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection myrows = dataGridView1.SelectedRows;
            foreach(DataGridViewRow myrow in myrows)
            {
                string S_no = myrow.Cells[0].Value.ToString();//库存编号
                string S_condition = myrow.Cells[5].Value.ToString();//在馆状态

                if (S_condition == "挂失")
                {
                    MessageBox.Show("此书目前已处于挂失状态！","错误！");
                }
                else
                {
                    SqlHelper.UpdatetItem1("Storage", "S_condition", "挂失", "S_no", S_no);
                    MessageBox.Show("已挂失！");
                    查询button_Click(null,null);//刷新状态，相当于再按了一遍Clickbutton
                }
            }
        }

        private void 图书挂失Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
        }
    }
}
