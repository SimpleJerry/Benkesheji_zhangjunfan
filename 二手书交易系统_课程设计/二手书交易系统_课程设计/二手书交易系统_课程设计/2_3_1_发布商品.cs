using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 二手书交易系统_课程设计
{
    public partial class 发布商品Form : Form
    {
        private string U_account;
        public 发布商品Form(string U_account)
        {
            this.U_account = U_account;
            InitializeComponent();
        }

        private void 查询button_Click(object sender, EventArgs e)
        {
            if (查询textBox.Text == "")
                //判断查询框类关键字是否为默认的“（全部）”或者“”，如果是，则显示全部信息。
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, "SELECT ISBN,书名,作者,出版社,出版时间,CAST (定价 AS DECIMAL(18,2)) 定价 FROM 书目表 WHERE 允许交易=1;");
            else
                //使用封装在SqlHelper类中ShowDataWithDataGirdView方法来显示数据，同时使用SQL语句实现模糊查询以及多类信息关键字查询。
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, String.Format("SELECT * FROM (SELECT ISBN,书名,作者,出版社,出版时间,CAST (定价 AS DECIMAL(18,2)) 定价 FROM 书目表 WHERE 允许交易=1) x WHERE ISBN LIKE '%{0}%' OR 书名 LIKE '%{0}%' OR 作者 LIKE '%{0}%' OR 出版社 LIKE '%{0}%' ; ", 查询textBox.Text));
        }

        private void 上架button_Click(object sender, EventArgs e)
        {
            if (ISBN码textBox.Text == "")
            {
                MessageBox.Show("请选定要发布的商品类型！");
            }
            else if (价格textBox.Text == "" || Convert.ToInt32(价格textBox.Text) == 0)
            {
                MessageBox.Show("请输入价格！");
            }
            else if (数量textBox.Text == "" || Convert.ToInt32(数量textBox.Text) == 0)
            {
                MessageBox.Show("请输入数量！");
            }
            else
            {
                string ISBN = ISBN码textBox.Text;
                int Price = Convert.ToInt32(价格textBox.Text);
                int Count = Convert.ToInt32(数量textBox.Text);

                DialogResult dr = MessageBox.Show(string.Format("请确认 ISBN：{0}\n价格：{1}  数量：{2}", ISBN, Price, Count), " 确定", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.OK)
                {
                    int Number_1 = SqlHelper.GetID("货品表", "货物编号");
                    int Number_2 = SqlHelper.GetID("现存订单表", "货物编号");
                    int Number_3 = SqlHelper.GetID("历史订单表", "货物编号");
                    int Number = Math.Max(Math.Max(Number_1, Number_2), Number_3);
                    int UID = Convert.ToInt32(SqlHelper.InquireItem("用户表", "UID", string.Format("帐号='{0}'", U_account)));

                    SqlHelper.InsertItem("货品表(货物编号,ISBN,卖家UID,价格,数量,已订数量)", string.Format("('{0}','{1}','{2}','{3}','{4}',0)", Number, ISBN, UID, Price, Count));

                    //清空文本框
                    价格textBox.Text = "0";
                    数量textBox.Text = "0";
                    MessageBox.Show("上架成功！");
                }
            }
        }

        private void 清空button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否清空文本框", " 清空", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                ISBN码textBox.Text = "";
                书名textBox.Text = "";
                作者textBox.Text = "";
                出版社textBox.Text = "";
                出版时间textBox.Text = "";
                定价textBox.Text = "";
                价格textBox.Text = "";
                数量textBox.Text = "";
            }
            else
            {
                return;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewSelectedRowCollection myrows = dataGridView1.SelectedRows;
                foreach (DataGridViewRow myrow in myrows)
                {
                    this.ISBN码textBox.Text = myrow.Cells[0].Value.ToString();
                    this.书名textBox.Text = myrow.Cells[1].Value.ToString();
                    this.作者textBox.Text = myrow.Cells[2].Value.ToString();
                    this.出版社textBox.Text = myrow.Cells[3].Value.ToString();
                    this.出版时间textBox.Text = myrow.Cells[4].Value.ToString();
                    this.定价textBox.Text = myrow.Cells[5].Value.ToString();
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellClick(sender, e);
            上架button_Click(sender, e);
        }

        private void 发布商品Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
        }

        private void 价格textBox_MouseLeave(object sender, EventArgs e)
        {
            if (价格textBox.Text == "")
                价格textBox.Text = "0";
        }

        private void 数量textBox_MouseLeave(object sender, EventArgs e)
        {
            if (数量textBox.Text == "")
                数量textBox.Text = "0";
        }

        private void INT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void DOUBLE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != '.' && !Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void 查询textBox_Click(object sender, EventArgs e)
        {
            查询textBox.Text = ""; 查询button_Click(sender, e);
        }
    }
}
