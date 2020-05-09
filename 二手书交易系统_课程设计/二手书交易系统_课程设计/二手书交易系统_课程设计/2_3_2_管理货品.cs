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
    public partial class 管理货品Form : Form
    {
        private string U_account;
        private int U_id;
        private int KuCun;
        public 管理货品Form(string U_account)
        {
            this.U_account = U_account;
            this.U_id = Convert.ToInt32(SqlHelper.InquireItem("用户表", "UID", string.Format("帐号='{0}'", U_account)));
            InitializeComponent();
        }

        private void 查询button_Click(object sender, EventArgs e)
        {
            if (查询textBox.Text == "")
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, string.Format("SELECT 货物编号,ISBN,书名,作者,出版社,出版时间,原价,价格,库存,允许交易 FROM 货品视图 WHERE 卖家ID = {0};", U_id));
            else
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, String.Format("SELECT * FROM(SELECT 货物编号,ISBN,书名,作者,出版社,出版时间,原价,价格,库存,允许交易 FROM 货品视图 WHERE 卖家ID = {0}) x WHERE ISBN LIKE '%{1}%' OR 书名 LIKE '%{1}%' OR 货物编号 LIKE '%{1}%'; ", U_id, 查询textBox.Text));


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int count = Convert.ToInt32(SqlHelper.InquireItem("现存订单表", "COUNT(*)", string.Format("订单状态!='未付款' AND 货物编号={0}", row.Cells[0].Value)));
                if (count != 0)//有订单的标蓝
                    row.DefaultCellStyle.BackColor = Color.DeepSkyBlue;
                if ((bool)row.Cells[9].Value == false)//禁售的货品标红
                    row.DefaultCellStyle.BackColor = Color.Red;
            }



        }

        private void 下架button_Click(object sender, EventArgs e)
        {
            if (货物编号textBox.Text == "")
            {
                MessageBox.Show("请指定货品种类！");
            }
            else
            {
                DialogResult dr = MessageBox.Show(string.Format("货物编号：{0}  商品名：{1}\n确认下架此商品？", 货物编号textBox.Text, 书名textBox.Text), " 确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.OK)
                {
                    //查询有没有'已付款'或者'已发货'的订单
                    int count = Convert.ToInt32(SqlHelper.InquireItem("现存订单表", "COUNT(*)", string.Format("订单状态!='未付款' AND 货物编号={0}", 货物编号textBox.Text)));
                    if (count != 0)
                    {
                        MessageBox.Show("有订单未被处理！请处理完毕再执行下架操作！");
                    }
                    else
                    {
                        //1.修改对应的"购物车(有效)"为false
                        SqlHelper.UpdateItem("购物车表", "有效=0", string.Format("货物编号={0}", 货物编号textBox.Text));
                        //2.把即将从"现存订单表"删除的未付款的订单，记录到"历史订单表"中，并将"订单状态"设置为"禁止交易"
                        SqlHelper.ExecuteNonQuery(string.Format("INSERT INTO 历史订单表(订单号,交易时间,货物编号,卖家UID,买家UID,价格,数量,订单状态) SELECT 订单号,交易时间,货物编号,卖家UID,买家UID,价格,数量,'卖方取消' 订单状态 FROM 现存订单表 WHERE 订单状态 =  '未付款' AND 货物编号 = {0}", 货物编号textBox.Text));
                        //3.从现存订单表删除对应的"订单属性"为"未付款"的项
                        SqlHelper.DeleteItem("现存订单表", string.Format("订单状态='未付款' AND 货物编号 = {0}", 货物编号textBox.Text));
                        //4.最终删除此货品
                        SqlHelper.DeleteItem("货品表", string.Format("货物编号='{0}'", 货物编号textBox.Text));
                        清空textbox();
                        查询button_Click(sender, e);
                        MessageBox.Show("下架成功！");
                    }
                }
                else
                    return;
            }
        }

        private void 清空textbox()
        {
            ISBN码textBox.Text = "";
            书名textBox.Text = "";
            作者textBox.Text = "";
            价格textBox.Text = "";
            出版社textBox.Text = "";
            出版时间textBox.Text = "";
            原价textBox.Text = "";
            库存textBox.Text = "";
            货物编号textBox.Text = "";
            允许交易textBox.Text = "";
        }

        private void 修改button_Click(object sender, EventArgs e)
        {
            if (货物编号textBox.Text == "")
            {
                MessageBox.Show("请指定货品种类！");
            }
            else if (价格textBox.Text == "0")
            {
                MessageBox.Show("价格不可以为0，你想免费送吗！");
            }
            else
            {
                if (允许交易textBox.Text == "✔")
                {
                    DialogResult dr = MessageBox.Show(string.Format("请确认 商品名：{0}\n价格：{1}  库存：{2}\n确认修改？", 书名textBox.Text, 价格textBox.Text, 库存textBox.Text), " 确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dr == DialogResult.OK)
                    {
                        SqlHelper.UpdateItem("货品表", string.Format("价格={0}", 价格textBox.Text), string.Format("货物编号={0}", 货物编号textBox.Text));
                        int KuCun_New = Convert.ToInt32(库存textBox.Text);
                        if (KuCun < KuCun_New)
                        {
                            int increase = KuCun_New - KuCun;
                            SqlHelper.Updatet_ChangeNum("货品表", "数量", string.Format("货物编号={0}", 货物编号textBox.Text), true, increase);
                        }
                        else if (KuCun > KuCun_New)
                        {
                            int decrease = KuCun - KuCun_New;
                            SqlHelper.Updatet_ChangeNum("货品表", "数量", string.Format("货物编号={0}", 货物编号textBox.Text), false, decrease);
                        }
                        KuCun = KuCun_New;
                        查询button_Click(sender, e);
                        MessageBox.Show("修改成功！");
                    }
                    else
                        return;
                }
                else
                    MessageBox.Show("该商品已被禁止交易，只允许下架！");
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
                    this.ISBN码textBox.Text = myrow.Cells[1].Value.ToString();
                    this.书名textBox.Text = myrow.Cells[2].Value.ToString();
                    this.作者textBox.Text = myrow.Cells[3].Value.ToString();
                    this.出版社textBox.Text = myrow.Cells[4].Value.ToString();
                    this.出版时间textBox.Text = myrow.Cells[5].Value.ToString();
                    this.原价textBox.Text = myrow.Cells[6].Value.ToString();
                    this.价格textBox.Text = myrow.Cells[7].Value.ToString();
                    this.库存textBox.Text = myrow.Cells[8].Value.ToString();
                    if ((bool)myrow.Cells[9].Value == true)
                        this.允许交易textBox.Text = "✔";
                    else
                        this.允许交易textBox.Text = "✖";
                    this.KuCun = Convert.ToInt32(库存textBox.Text);
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellClick(sender, e);
            下架button_Click(sender, e);
        }

        private void 价格textBox_MouseLeave(object sender, EventArgs e)
        {
            if (价格textBox.Text == "")
                价格textBox.Text = "0";
        }

        private void 库存textBox_MouseLeave(object sender, EventArgs e)
        {
            if (库存textBox.Text == "")
                库存textBox.Text = "0";
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

        private void 管理货品Form_KeyPress(object sender, KeyPressEventArgs e)
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
