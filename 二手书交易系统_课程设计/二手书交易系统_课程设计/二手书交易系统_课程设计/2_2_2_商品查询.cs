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
    public partial class 商品查询Form : Form
    {
        private string U_account;
        private int U_id;
        public 商品查询Form(string U_account)
        {
            this.U_account = U_account;
            this.U_id = Convert.ToInt32(SqlHelper.InquireItem("用户表", "UID", string.Format("帐号='{0}'", U_account)));
            InitializeComponent();
        }

        private void 查询button_Click(object sender, EventArgs e)
        {
            if (查询textBox.Text == "")
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, string.Format("SELECT 货物编号,书名,作者,ISBN,出版社,出版时间,卖家昵称,卖家ID,原价,价格,库存 FROM 货品视图 WHERE 库存!=0 AND 允许交易=1 AND 卖家ID!={0};", U_id));
            else
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, string.Format("SELECT * FROM (SELECT 货物编号,书名,作者,ISBN,出版社,出版时间,卖家昵称,卖家ID,原价,价格,库存 FROM 货品视图 WHERE 库存!=0 AND 允许交易=1 AND 卖家ID!={0}) x WHERE ISBN LIKE '%{1}%' OR 书名 LIKE '%{1}%' OR 作者 LIKE '%{1}%' OR 出版社 LIKE '%{1}%';", U_id, 查询textBox.Text));
        }

        private void 加入购物车button_Click(object sender, EventArgs e)
        {
            if (货物编号textBox.Text == "")
            {
                MessageBox.Show("请选择货品！");
            }
            else
            {
                bool exist = SqlHelper.CheckExist("购物车表", string.Format("货物编号='{0}' AND UID={1}", 货物编号textBox.Text, this.U_id));

                if (exist)//若已存在，更新
                    SqlHelper.Updatet_ChangeNum("购物车表", "数量", string.Format("货物编号='{0}' AND UID={1}", 货物编号textBox.Text, this.U_id), true);
                else//若不存在，插入
                    SqlHelper.InsertItem("购物车表(货物编号, UID, 数量,有效)", String.Format("({0},{1},{2},1);", 货物编号textBox.Text, this.U_id, 1));

                MessageBox.Show("已添加到购物车！");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewSelectedRowCollection myrows = dataGridView1.SelectedRows;
                foreach (DataGridViewRow myrow in myrows)
                {
                    this.货物编号textBox.Text = myrow.Cells[0].Value.ToString();
                    this.书名textBox.Text = myrow.Cells[1].Value.ToString();
                    this.作者textBox.Text = myrow.Cells[2].Value.ToString();
                    this.ISBN码textBox.Text = myrow.Cells[3].Value.ToString();
                    this.出版社textBox.Text = myrow.Cells[4].Value.ToString();
                    this.出版时间textBox.Text = myrow.Cells[5].Value.ToString();
                    this.卖家昵称textBox.Text = myrow.Cells[6].Value.ToString();
                    this.卖家IDtextBox.Text = myrow.Cells[7].Value.ToString();
                    this.原价textBox.Text = myrow.Cells[8].Value.ToString();
                    this.价格textBox.Text = myrow.Cells[9].Value.ToString();
                    this.库存textBox.Text = myrow.Cells[10].Value.ToString();
                    this.数量textBox.Text = "0";
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellClick(sender, e);
            加入购物车button_Click(sender, e);
        }

        private void 商品查询Form_KeyPress(object sender, KeyPressEventArgs e)
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

        private void INT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void 购买button_Click(object sender, EventArgs e)
        {
            if (货物编号textBox.Text == "")
            {
                MessageBox.Show("请选定欲购买的商品！");
            }
            else
            {
                string address = SqlHelper.InquireItem("用户表", "收货地址", string.Format("帐号='{0}'", U_account));
                if (address == "")
                {
                    MessageBox.Show("请先前往设置收货地址！");
                }
                else if (数量textBox.Text == "0")
                {
                    MessageBox.Show("数量不能为0！");
                }
                else if (Convert.ToInt32(数量textBox.Text) > Convert.ToInt32(库存textBox.Text))
                {
                    MessageBox.Show("数量不可超过库存！");
                }
                else
                {
                    double price_total = Convert.ToDouble(价格textBox.Text) * Convert.ToInt32(数量textBox.Text);
                    DialogResult dr = MessageBox.Show(string.Format("书名：{0}\n数量：{1}\t总价：￥{2}\n确定购买？", 书名textBox.Text, 数量textBox.Text, price_total), " 确定", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dr == DialogResult.OK)
                    {
                        int id_1 = SqlHelper.GetID("现存订单表", "订单号");
                        int id_2 = SqlHelper.GetID("历史订单表", "订单号");
                        int id = Math.Max(id_1, id_2);//取二者中更大者，否则会产生冲突

                        //向现存订单表添加信息
                        SqlHelper.InsertItem("现存订单表(订单号,交易时间,货物编号,卖家UID,买家UID,价格,数量,收货地址,订单状态,快递单号)", string.Format("({0},'{1}','{2}',{3},{4},{5},{6},'{7}','未付款',NULL)", id, System.DateTime.Now, 货物编号textBox.Text, 卖家IDtextBox.Text, this.U_id, 价格textBox.Text, 数量textBox.Text, address));
                        //增加货品表中的已订数量
                        int count_ordered = Convert.ToInt32(SqlHelper.InquireItem("货品表", "已订数量", string.Format("货物编号={0}", 货物编号textBox.Text)));
                        int count_dingdan = Convert.ToInt32(数量textBox.Text);
                        SqlHelper.Updatet_ChangeNum("货品表", "已订数量", string.Format("货物编号={0}", 货物编号textBox.Text), true, count_dingdan);
                        //减少购物车表中的数量
                        SqlHelper.Updatet_ChangeNum("购物车表", "数量", string.Format("货物编号={0} AND UID={1}", 货物编号textBox.Text, this.U_id), false, count_dingdan);
                        MessageBox.Show("已生成订单，请前往付款！");
                        清空textBox();
                        查询button_Click(sender, e);
                    }
                }
            }
        }

        private void 清空textBox()
        {
            this.货物编号textBox.Text = "";
            this.ISBN码textBox.Text = "";
            this.书名textBox.Text = "";
            this.作者textBox.Text = "";
            this.出版社textBox.Text = "";
            this.出版时间textBox.Text = "";
            this.卖家昵称textBox.Text = "";
            this.卖家IDtextBox.Text = "";
            this.原价textBox.Text = "";
            this.价格textBox.Text = "";
            this.数量textBox.Text = "";
            this.库存textBox.Text = "";
        }
    }
}