using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图书管理系统_课程设计
{
    public partial class 图书查询Form : Form
    {
        public 图书查询Form()
        {
            InitializeComponent();
            this.comboBox1.Text = this.comboBox1.Items[0].ToString();
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList; 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void 查询button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "查找所有书籍")
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, "SELECT * FROM Storage_View;");
           
            else 
            {
                if (关键字textBox.Text == string.Empty)
                {
                    MessageBox.Show("请输入您要查询的图书信息的关键字!");
                }
                else if (comboBox1.Text == "按书名查找")
                {
                    string Bname=Convert.ToString(关键字textBox.Text.Trim());
                    string sql = "SELECT * FROM Storage_View WHERE 书名 LIKE '%" + Bname + "%'";
                    SqlHelper.ShowDataWithDataGirdView(dataGridView1, string.Format(sql));
                }
                else if (comboBox1.Text == "按ISBN查找")
                {
                    string ISBN = Convert.ToString(关键字textBox.Text.Trim());
                    string sql = "SELECT * FROM Storage_View WHERE ISBN LIKE '%" + ISBN + "%'";
                    SqlHelper.ShowDataWithDataGirdView(dataGridView1, string.Format(sql));
                }
                else if (comboBox1.Text == "按作者查找")
                {
                    string au = Convert.ToString(关键字textBox.Text.Trim());
                    string sql = "SELECT * FROM Storage_View WHERE ISBN LIKE '%" + au + "%'";
                    SqlHelper.ShowDataWithDataGirdView(dataGridView1, string.Format(sql));
                }
            dataGridView1.ReadOnly = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int a = this.dataGridView1.CurrentCell.RowIndex;
            this.在馆数量textBox.ReadOnly = false;
            this.图书馆藏地址textBox.ReadOnly = false;
            this.作者textBox.ReadOnly = false;
            this.书名textBox.ReadOnly = false;
            this.书籍序列号textBox.ReadOnly = false;
            this.书籍序列号textBox.Text = dataGridView1.Rows[a].Cells["ISBN"].Value.ToString();
            this.书名textBox.Text = dataGridView1.Rows[a].Cells["书名"].Value.ToString();
            this.作者textBox.Text = dataGridView1.Rows[a].Cells["作者"].Value.ToString();
            this.图书馆藏地址textBox.Text = dataGridView1.Rows[a].Cells["馆藏地址"].Value.ToString();
            this.在馆数量textBox.Text = dataGridView1.Rows[a].Cells["在馆状态"].Value.ToString();
            this.在馆数量textBox.ReadOnly = true;
            this.图书馆藏地址textBox.ReadOnly = true;
            this.作者textBox.ReadOnly = true;
            this.书名textBox.ReadOnly = true;
            this.书籍序列号textBox.ReadOnly = true;
            
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //int row = this.dataGridView1.CurrentCell.RowIndex;//dataGridView 选中单元格如何获取行号
        //    //if (MessageBox.Show("书否确认提交?", "订阅确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) == DialogResult.OK)
        //    //{
        //    //     B_isbn = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0];
        //    //    string sql = "SELECT * FROM Book_info WHERE B_name LIKE '%";

        //    //}
            
  
        //}

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void 图书查询Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
        }
    }
}
