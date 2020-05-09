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
    public partial class 现存订单查询_卖Form : Form
    {
        private string U_account;
        private int U_id;
        public 现存订单查询_卖Form(string U_account)
        {
            this.U_account = U_account;
            this.U_id = Convert.ToInt32(SqlHelper.InquireItem("用户表", "UID", string.Format("帐号='{0}'", U_account)));
            InitializeComponent();
            this.账户余额textBox.Text = SqlHelper.InquireItem("用户表", "余额", string.Format("帐号='{0}'", U_account));
        }

        private void 查询button_Click(object sender, EventArgs e)
        {
            if (查询textBox.Text == "")
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, string.Format("SELECT 订单号,货物编号,买家UID,买家昵称,价格,数量,交易时间,收货地址,快递单号,订单状态 FROM 现存订单视图 WHERE 卖家UID = {0}; ", U_id));
            else
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, string.Format("SELECT * FROM (SELECT 订单号,货物编号,买家UID,买家昵称,价格,数量,交易时间,收货地址,快递单号,订单状态 FROM 现存订单视图 WHERE 卖家UID = {0}) x WHERE 订单号 LIKE '%{1}%' OR 货物编号 LIKE '%{1}%'  OR 订单状态 LIKE '%{1}%'; ", U_id, 查询textBox.Text));

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

        private void 确认发货button_Click(object sender, EventArgs e)
        {
            if (订单号textBox.Text == "")
                MessageBox.Show("请选择订单！");
            else if (订单状态textBox.Text == "未付款")
                MessageBox.Show("买家尚未付款，请耐心等待！");
            else if (订单状态textBox.Text == "已发货")
                MessageBox.Show("您已发货，不可重复操作！");
            else if (快递单号textBox.Text == "")
                MessageBox.Show("快递编号不可为空！");
            else//已付款且填写了快递编号
            {
                DialogResult dr = MessageBox.Show("确定发货？", " 确定", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.OK)
                {
                    SqlHelper.UpdateItem("现存订单表", string.Format("快递单号='{0}',订单状态='已发货'", 快递单号textBox.Text), string.Format("订单号={0}", 订单号textBox.Text));
                    快递单号textBox.ReadOnly = true;//重新锁住
                    查询button_Click(sender, e);
                    MessageBox.Show("操作成功！");
                }
                else
                {
                    return;
                }
            }
        }

        private void 取消订单button_Click(object sender, EventArgs e)
        {
            if (订单号textBox.Text == "")
                MessageBox.Show("请选择订单！");
            else if (订单状态textBox.Text == "已发货")//已发货，不可退款
            {
                MessageBox.Show("已发货，不可取消！");
            }
            else
            {
                DialogResult dr = MessageBox.Show("请确认是否取消此订单？", " 确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.OK)
                {
                    //取消订单，计入到历史订单表中
                    SqlHelper.InsertItem("历史订单表(订单号,交易时间,货物编号,卖家UID,买家UID,价格,数量,收货地址,订单状态,快递单号)", string.Format("({0},'{1}','{2}',{3},{4},{5},{6},NULL,'卖方取消',NULL)", 订单号textBox.Text, System.DateTime.Now, 货物编号textBox.Text, this.U_id, 买家IDtextBox.Text, 价格textBox.Text, 数量textBox.Text));
                    int count_dingdan = Convert.ToInt32(数量textBox.Text);
                    //订单取消，将"已订数量"减回来
                    SqlHelper.Updatet_ChangeNum("货品表", "已订数量", string.Format("货物编号={0}", 货物编号textBox.Text), false, count_dingdan);

                    if (订单状态textBox.Text == "已付款")//已付款，则退回余额
                    {
                        double price = Convert.ToInt32(价格textBox.Text);
                        SqlHelper.Updatet_ChangeNum("用户表", "余额", string.Format("UID={0}", 买家IDtextBox.Text), true, price * count_dingdan);
                    }
                    SqlHelper.DeleteItem("现存订单表", string.Format("订单号={0}", 订单号textBox.Text));
                    查询button_Click(sender, e);
                    MessageBox.Show("已取消此订单！");
                }
                else
                {
                    return;
                }
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

                    快递单号textBox.ReadOnly = true;
                    if (订单状态textBox.Text == "未付款")
                        this.收货地址textBox.Text = "将在买方付款之后显示！";
                    else
                    {
                        if (订单状态textBox.Text == "已付款")
                            快递单号textBox.ReadOnly = false;//若为"已付款"状态则解锁
                        this.收货地址textBox.Text = SqlHelper.InquireItem("现存订单表", "收货地址", string.Format("订单号={0}", 订单号textBox.Text));
                    }

                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellClick(sender, e);
            确认发货button_Click(sender, e);
        }

        private void 订单查询Form_KeyPress(object sender, KeyPressEventArgs e)
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
