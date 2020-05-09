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
    public partial class 现存订单查询_买Form : Form
    {
        private string U_account;
        private int U_id;
        public 现存订单查询_买Form(string U_account)
        {
            this.U_account = U_account;
            this.U_id = Convert.ToInt32(SqlHelper.InquireItem("用户表", "UID", string.Format("帐号='{0}'", U_account)));
            InitializeComponent();
            this.账户余额textBox.Text = SqlHelper.InquireItem("用户表", "余额", string.Format("帐号='{0}'", U_account));
        }

        private void 查询button_Click(object sender, EventArgs e)
        {
            if (查询textBox.Text == "")
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, string.Format("SELECT 订单号,货物编号,卖家UID,卖家昵称,价格,数量,交易时间,收货地址,快递单号,订单状态 FROM 现存订单视图 WHERE 买家UID = {0}; ", U_id));
            else
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, string.Format("SELECT * FROM (SELECT 订单号,货物编号,卖家UID,卖家昵称,价格,数量,交易时间,收货地址,快递单号,订单状态 FROM 现存订单视图 WHERE 买家UID = {0}) x WHERE 订单号 LIKE '%{1}%' OR 货物编号 LIKE '%{1}%'  OR 订单状态 LIKE '%{1}%'; ", U_id, 查询textBox.Text));

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

        private void 付款button_Click(object sender, EventArgs e)
        {
            double money = Convert.ToDouble(SqlHelper.InquireItem("用户表", "余额", string.Format("UID={0}", this.U_id)));
            if (订单号textBox.Text == "")
                MessageBox.Show("请选择订单！");
            else if (订单状态textBox.Text != "未付款")
                MessageBox.Show("请选择未付款的订单！");
            else
            {
                double price = Convert.ToDouble(价格textBox.Text);
                int count = Convert.ToInt32(数量textBox.Text);
                double total = price * count;
                if (money >= total)//足够支付
                {
                    DialogResult dr = MessageBox.Show(string.Format("订单号：{0}\n书名：{1}\n数量：{2}\t总计：￥{3}", 订单号textBox.Text, 书名textBox.Text, 数量textBox.Text, total), " 确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dr == DialogResult.OK)
                    {
                        SqlHelper.UpdateItem("用户表", string.Format("余额={0}", string.Format("{0}", money - total)), string.Format("帐号='{0}'", U_account));
                        SqlHelper.UpdateItem("现存订单表", "订单状态='已付款'", string.Format("订单号={0}", 订单号textBox.Text));
                        账户余额textBox.Text = SqlHelper.InquireItem("用户表", "余额", string.Format("帐号='{0}'", U_account));
                        查询button_Click(sender, e);
                        MessageBox.Show("付款成功！");
                    }
                    else
                    {
                        return;
                    }
                }
                else
                    MessageBox.Show("您的余额不足，请充值!");
            }
        }

        private void 确认收货button_Click(object sender, EventArgs e)
        {
            if (订单号textBox.Text == "")
                MessageBox.Show("请选择订单！");
            else if (订单状态textBox.Text != "已发货")
                MessageBox.Show("请选择已发货的订单！");
            else
            {
                DialogResult dr = MessageBox.Show("确认收货？", " 确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.OK)
                {
                    SqlHelper.InsertItem("历史订单表(订单号,交易时间,货物编号,卖家UID,买家UID,价格,数量,收货地址,快递单号,订单状态)", string.Format("({0},'{1}','{2}',{3},{4},{5},{6},'{7}','{8}','完成')", 订单号textBox.Text, System.DateTime.Now, 货物编号textBox.Text, 卖家IDtextBox.Text, this.U_id, 价格textBox.Text, 数量textBox.Text, 收货地址textBox.Text, 快递单号textBox.Text));
                    int seller_id = Convert.ToInt32(SqlHelper.InquireItem("现存订单表", "卖家UID", string.Format("订单号={0}", 订单号textBox.Text)));
                    double money = Convert.ToDouble(SqlHelper.InquireItem("用户表", "余额", string.Format("UID={0}", seller_id)));
                    double price = Convert.ToDouble(SqlHelper.InquireItem("现存订单表", "价格", string.Format("订单号={0}", 订单号textBox.Text)));
                    int count = Convert.ToInt32(SqlHelper.InquireItem("现存订单表", "数量", string.Format("订单号={0}", 订单号textBox.Text)));
                    money += price * count;//在原来基础上加上盈利
                    SqlHelper.DeleteItem("现存订单表", string.Format("订单号={0}", 订单号textBox.Text));
                    SqlHelper.UpdateItem("用户表", string.Format("余额={0}", money.ToString()), string.Format("UID={0}", seller_id));

                    int count_total = Convert.ToInt32(SqlHelper.InquireItem("货品表", "数量", string.Format("货物编号={0}", 货物编号textBox.Text)));
                    int count_ordered = Convert.ToInt32(SqlHelper.InquireItem("货品表", "已订数量", string.Format("货物编号={0}", 货物编号textBox.Text)));
                    int count_dingdan = Convert.ToInt32(数量textBox.Text);
                    //同时将已订数量和总数量减掉
                    SqlHelper.UpdateItem("货品表", string.Format("已订数量={0}", (count_ordered - count_dingdan).ToString()), string.Format("货物编号={0}", 货物编号textBox.Text));
                    SqlHelper.UpdateItem("货品表", string.Format("数量={0}", (count_total - count_dingdan).ToString()), string.Format("货物编号={0}", 货物编号textBox.Text));
                    查询button_Click(sender, e);
                    MessageBox.Show("已确认收货！");
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
                    //1.把将要取消订单，记录到历史订单表中
                    SqlHelper.InsertItem("历史订单表(订单号,交易时间,货物编号,卖家UID,买家UID,价格,数量,收货地址,快递单号,订单状态)", string.Format("({0},'{1}','{2}',{3},{4},{5},{6},'{7}',NULL,'买方取消')", 订单号textBox.Text, System.DateTime.Now, 货物编号textBox.Text, 卖家IDtextBox.Text, this.U_id, 价格textBox.Text, 数量textBox.Text, 收货地址textBox.Text));
                    int count_ordered = Convert.ToInt32(SqlHelper.InquireItem("货品表", "已订数量", string.Format("货物编号={0}", 货物编号textBox.Text)));
                    int count_dingdan = Convert.ToInt32(数量textBox.Text);
                    //2.将货品的"已订数量"减回来
                    SqlHelper.Updatet_ChangeNum("货品表", "已订数量", string.Format("货物编号={0}", 货物编号textBox.Text), false, count_dingdan);

                    if (订单状态textBox.Text == "已付款")//若已付款，则退回余额
                    {
                        double price = Convert.ToInt32(价格textBox.Text);
                        SqlHelper.Updatet_ChangeNum("用户表", "余额", string.Format("帐号='{0}'", U_account), true, price * count_dingdan);
                        账户余额textBox.Text = SqlHelper.InquireItem("用户表", "余额", string.Format("帐号='{0}'", U_account));
                    }
                    //3.从"现存订单表"中删除该订单
                    SqlHelper.DeleteItem("现存订单表", string.Format("订单号={0}", 订单号textBox.Text));
                    查询button_Click(sender, e);
                    清空textBox();
                    MessageBox.Show("已取消此订单！");
                }
                else
                {
                    return;
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellClick(sender, e);
            if (订单状态textBox.Text == "未付款")
                付款button_Click(sender, e);
            else if (订单状态textBox.Text == "已付款")
                取消订单button_Click(sender, e);
            else if (订单状态textBox.Text == "已发货")
                确认收货button_Click(sender, e);
            else
                MessageBox.Show("异常！！！");
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
                    this.卖家IDtextBox.Text = myrow.Cells[2].Value.ToString();
                    this.卖家昵称textBox.Text = myrow.Cells[3].Value.ToString();
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

        private void 清空textBox()
        {
            this.订单号textBox.Text = "";
            this.货物编号textBox.Text = "";
            this.卖家IDtextBox.Text = "";
            this.卖家昵称textBox.Text = "";
            this.书名textBox.Text = "";
            this.价格textBox.Text = "";
            this.数量textBox.Text = "";
            this.交易时间textBox.Text = "";
            this.收货地址textBox.Text = "";
            this.快递单号textBox.Text = "";
            this.订单状态textBox.Text = "";
        }

        private void 现存订单查询_买Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
        }

        private void 查询textBox_Click(object sender, EventArgs e)
        {
            查询textBox.Text = ""; 查询button_Click(sender, e);
        }
    }
}
