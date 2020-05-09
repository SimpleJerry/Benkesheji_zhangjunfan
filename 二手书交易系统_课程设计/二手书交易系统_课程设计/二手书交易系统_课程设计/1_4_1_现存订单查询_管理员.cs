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
    public partial class 现存订单查询_管理员Form : Form
    {
        public 现存订单查询_管理员Form()
        {
            InitializeComponent();
        }

        private void 查询button_Click(object sender, EventArgs e)
        {
            if (查询textBox.Text == "")
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, "SELECT 订单号,货物编号,买家UID,买家昵称,价格,数量,交易时间,收货地址,快递单号,订单状态 FROM 现存订单视图; ");
            else
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, string.Format("SELECT * FROM (SELECT 订单号,货物编号,买家UID,买家昵称,价格,数量,交易时间,收货地址,快递单号,订单状态 FROM 现存订单视图) x WHERE 订单号 LIKE '%{0}%' OR 货物编号 LIKE '%{0}%'  OR 订单状态 LIKE '%{0}%'; ",查询textBox.Text));
            
            //按订单状态标注颜色
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((string)row.Cells[9].Value == "未付款")
                    row.DefaultCellStyle.BackColor = Color.Pink;
                else if ((string)row.Cells[9].Value == "已付款")
                    row.DefaultCellStyle.BackColor = Color.Khaki;
                else if ((string)row.Cells[9].Value == "已发货")
                    row.DefaultCellStyle.BackColor = Color.SpringGreen;
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
                    this.书名textBox.Text = SqlHelper.InquireItem("货品视图", "书名", string.Format("货物编号={0}", 货物编号textBox.Text));
                    this.买家IDtextBox.Text = myrow.Cells[2].Value.ToString();
                    this.买家昵称textBox.Text = myrow.Cells[3].Value.ToString();
                    this.价格textBox.Text = myrow.Cells[4].Value.ToString();
                    this.数量textBox.Text = myrow.Cells[5].Value.ToString();
                    this.交易时间textBox.Text = myrow.Cells[6].Value.ToString();
                    this.收货地址textBox.Text = myrow.Cells[7].Value.ToString();
                    this.快递单号textBox.Text = myrow.Cells[8].Value.ToString();
                    this.订单状态textBox.Text = myrow.Cells[9].Value.ToString();
                }
            }
        }

        private void 订单情况查询Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
        }

        private void 查询textBox_Click(object sender, EventArgs e)
        {
            查询textBox.Text = "";查询button_Click(sender, e);
        }
    }
}
