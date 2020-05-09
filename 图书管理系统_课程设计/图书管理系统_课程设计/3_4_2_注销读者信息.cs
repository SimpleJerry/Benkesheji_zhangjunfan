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
    public partial class 注销读者信息Form : Form
    {
        public 注销读者信息Form()
        {
            InitializeComponent();
            this.comboBox1.Text = this.comboBox1.Items[0].ToString();
        }

        private void 查询button_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "查询所有读者")
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, string.Format("SELECT * FROM Reader_View;", textBox1.Text));//已经在黑名单之中的不可见
            else if (comboBox1.Text == "按帐号查询")
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, string.Format("SELECT * FROM Reader_View WHERE 帐号='{0}';", textBox1.Text));
            else if (comboBox1.Text == "按姓名查询")
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, string.Format("SELECT * FROM Reader_View WHERE 姓名='{0}';", textBox1.Text));
            else if (comboBox1.Text == "按手机号查询")
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, string.Format("SELECT * FROM Reader_View WHERE 手机='{0}';", textBox1.Text));
            else if (comboBox1.Text == "按邮箱查询")
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, string.Format("SELECT * FROM Reader_View WHERE 邮箱='{0}';", textBox1.Text));
            else
                MessageBox.Show("请选择正确的匹配模式！", "错误！");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection myrows = dataGridView1.SelectedRows;
            foreach (DataGridViewRow myrow in myrows)
            {
                string R_id = myrow.Cells[0].Value.ToString();//读者编号

                //TODO:DELETE ITEM
                MessageBox.Show("已注销！");
                查询button_Click(null, null);//刷新状态，相当于再按了一遍Clickbutton
            }
        }

        private void 注销读者信息Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
        }
    }
}




