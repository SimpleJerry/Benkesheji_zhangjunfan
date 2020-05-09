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
    public partial class 历史订单查询_卖Form : Form
    {
        private string U_account;
        private int U_id;
        public 历史订单查询_卖Form(string U_account)
        {
            this.U_account = U_account;
            this.U_id = Convert.ToInt32(SqlHelper.InquireItem("用户表", "UID", string.Format("帐号='{0}'", U_account)));
            InitializeComponent();
            this.账户余额textBox.Text = SqlHelper.InquireItem("用户表", "余额", string.Format("帐号='{0}'", U_account));
        }

        private void 查询button_Click(object sender, EventArgs e)
        {
            if (查询textBox.Text == "")
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, string.Format("SELECT 订单号,货物编号,买家UID,买家昵称,价格,数量,交易时间,收货地址,快递单号,订单状态 FROM 历史订单视图 WHERE 卖家UID = {0}; ", U_id));
            else
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, string.Format("SELECT * FROM (SELECT 订单号,货物编号,买家UID,买家昵称,价格,数量,交易时间,收货地址,快递单号,订单状态 FROM 历史订单视图 WHERE 卖家UID = {0}) x WHERE 订单号 LIKE '%{1}%' OR 货物编号 LIKE '%{1}%' OR 订单状态 LIKE '%{1}%'; ", U_id, 查询textBox.Text));

            //按订单状态标注颜色
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((string)row.Cells[9].Value == "完成")
                    row.DefaultCellStyle.BackColor = Color.White;
                else if ((string)row.Cells[9].Value == "买方取消")
                    row.DefaultCellStyle.BackColor = Color.Khaki;
                else if ((string)row.Cells[9].Value == "卖方取消")
                    row.DefaultCellStyle.BackColor = Color.Khaki;
                else if ((string)row.Cells[9].Value == "禁止销售")
                    row.DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewSelectedRowCollection myrows = dataGridView1.SelectedRows;
                foreach (DataGridViewRow myrow in myrows)
                {
                    this.订单号textBox.Text = myrow.Cells[0].Value.ToString();
                    this.货物编号textBox.Text = myrow.Cells[1].Value.ToString();
                    this.买家IDtextBox.Text = myrow.Cells[2].Value.ToString();
                    this.买家昵称textBox.Text = myrow.Cells[3].Value.ToString();
                    this.价格textBox.Text = myrow.Cells[4].Value.ToString();
                    this.数量textBox.Text = myrow.Cells[5].Value.ToString();
                    this.交易时间textBox.Text = myrow.Cells[6].Value.ToString();
                    this.收货地址textBox.Text = myrow.Cells[7].Value.ToString();
                    this.快递单号textBox.Text = myrow.Cells[8].Value.ToString();
                    this.订单状态textBox.Text = myrow.Cells[9].Value.ToString();

                    string Book_name = SqlHelper.InquireItem("货品视图", "书名", string.Format("货物编号={0}", 货物编号textBox.Text));
                    if (Book_name == "")//即由于货品被下架，找不到时
                    {
                        this.书名textBox.ForeColor = Color.Red;
                        this.书名textBox.Text = "该商品已被下架";
                    }
                    else
                    {
                        this.书名textBox.ForeColor = Color.Black;
                        this.书名textBox.Text = Book_name;
                    }
                }
            }
        }

        private void 历史订单查询_卖Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
        }

        private void 查询textBox_Click(object sender, EventArgs e)
        {
            查询textBox.Text = "";
            查询button_Click(sender, e);
        }
    }
}
