using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;//使用IList
using System.Data.SqlClient;

namespace 二手书交易系统_课程设计
{
    public partial class 书目管理Form : Form
    {
        public 书目管理Form()
        {
            InitializeComponent();
            年comboBox.SelectedIndex = 年comboBox.Items.IndexOf("2018年");
            月comboBox.SelectedIndex = 月comboBox.Items.IndexOf("1月");
            日comboBox_Change();//生成日期列表
            日comboBox.SelectedIndex = 日comboBox.Items.IndexOf("1日");
        }

        private void 添加button_Click(object sender, EventArgs e)
        {
            string 出版时间 = string.Format("{0}-{1}-{2}", 年comboBox.Text.Substring(0, 年comboBox.Text.Length - 1), 月comboBox.Text.Substring(0, 月comboBox.Text.Length - 1), 日comboBox.Text.Substring(0, 日comboBox.Text.Length - 1));
            if (ISBN码textBox.Text == "" || 书名textBox.Text == "" || 作者textBox.Text == "" || 出版社textBox.Text == "" || 出版时间 == "" || 价格textBox.Text == "")
            {
                //若有文本框为空，则显示提示信息。信息不完整，不能添加。
                MessageBox.Show("信息不完整！");
            }
            else if (ISBN码textBox.Text.Length != 10 && ISBN码textBox.Text.Length != 13)
            {
                MessageBox.Show("ISBN码必须为10位或13位");
            }
            else if (SqlHelper.InquireItem("书目表", "ISBN", string.Format("ISBN={0}", ISBN码textBox.Text)) != "Not Found!")
            {
                //查询待插入书籍的ISBN码在数据库中是否已经存在，若返回值不为Not Found!则表示ISBN码重复，拒绝插入。
                MessageBox.Show("插入书籍重复!");
            }
            else
            {
                SqlHelper.InsertItem("书目表(ISBN,书名,作者,出版社,出版时间,定价,允许交易)", String.Format("('{0}','{1}','{2}','{3}','{4}','{5}',1);", ISBN码textBox.Text, 书名textBox.Text, 作者textBox.Text, 出版社textBox.Text, 出版时间, 价格textBox.Text));
                MessageBox.Show("添加成功！");
                查询button_Click(sender, e);//刷新
            }
        }

        private void 更新button_Click(object sender, EventArgs e)
        {
            string 出版时间 = string.Format("{0}-{1}-{2}", 年comboBox.Text.Substring(0, 年comboBox.Text.Length - 1), 月comboBox.Text.Substring(0, 月comboBox.Text.Length - 1), 日comboBox.Text.Substring(0, 日comboBox.Text.Length - 1));
            if (ISBN码textBox.Text == "" || 书名textBox.Text == "" || 作者textBox.Text == "" || 出版社textBox.Text == "" || 出版时间 == "" || 价格textBox.Text == "")
            {
                MessageBox.Show("信息不完整！");
            }
            else if (ISBN码textBox.Text.Length != 10 && ISBN码textBox.Text.Length != 13)
            {
                MessageBox.Show("ISBN码必须为10位或13位");
            }
            else if (SqlHelper.InquireItem("书目表", "ISBN", string.Format("ISBN={0}", ISBN码textBox.Text)) == "Not Found!")
            {
                MessageBox.Show("此ISBN对应的书籍不存在!");
            }
            else
            {
                //定义可表示插入情况的标识a1~a5
                bool a1, a2, a3, a4, a5;
                //使用封装在SqlHelper中的UpdateItem1方法进行更新信息操作，如果插入成功，返回1；不成功则返回0
                a1 = SqlHelper.UpdateItem("书目表", string.Format("书名='{0}'", 书名textBox.Text), string.Format("ISBN={0}", ISBN码textBox.Text));
                a2 = SqlHelper.UpdateItem("书目表", string.Format("作者='{0}'", 作者textBox.Text), string.Format("ISBN={0}", ISBN码textBox.Text));
                a3 = SqlHelper.UpdateItem("书目表", string.Format("出版社='{0}'", 出版社textBox.Text), string.Format("ISBN={0}", ISBN码textBox.Text));
                a4 = SqlHelper.UpdateItem("书目表", string.Format("出版时间='{0}'", 出版时间), string.Format("ISBN={0}", ISBN码textBox.Text));
                a5 = SqlHelper.UpdateItem("书目表", string.Format("定价={0}", 价格textBox.Text), string.Format("ISBN={0}", ISBN码textBox.Text));

                if (a1 && a2 && a3 && a4 && a5)
                {
                    //如果每个更新操作都成功，则提示信息更新成功，并刷新信息显示框。
                    MessageBox.Show("信息更新成功");
                    查询button_Click(sender, e);
                }
                else
                    MessageBox.Show("信息更新失败！");
            }
        }

        private void 禁止交易button_Click(object sender, EventArgs e)
        {
            if (ISBN码textBox.Text == "")
            {
                MessageBox.Show("请指定书籍！");
            }
            else if (ISBN码textBox.Text.Length != 10 && ISBN码textBox.Text.Length != 13)
            {
                MessageBox.Show("ISBN码必须为10位或13位");
            }
            else if (允许交易textBox.Text == "✖")
            {
                MessageBox.Show("该书已被禁止交易！");
            }
            else
            {
                DialogResult dr = MessageBox.Show("确认禁止其交易？", " 确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.OK)//确认删除
                {
                    //1.修改对应的"书目表(允许交易)"为false
                    SqlHelper.UpdateItem("书目表", "允许交易=0", string.Format("ISBN={0}", ISBN码textBox.Text));
                    //2.修改对应的"购物车(有效)"为false
                    SqlHelper.UpdateItem("购物车表", "有效=0", string.Format("货物编号 IN (SELECT 购物车表.货物编号 FROM 购物车表,货品表 WHERE 购物车表.货物编号 = 货品表.货物编号 AND ISBN={0})", ISBN码textBox.Text));

                    //3.将已付的款项，返还给买方
                    using (SqlConnection conn = SqlHelper.GetConn())
                    {
                        conn.Open();
                        //得到 买家UID,要退回款项
                        string sql = string.Format("SELECT UID 买家UID,现存订单视图.价格*现存订单视图.数量 要退回款项 FROM 用户表,现存订单视图,货品表 WHERE 现存订单视图.货物编号 = 货品表.货物编号 AND UID = 买家UID AND 订单状态 = '已付款' AND ISBN = '{0}'", ISBN码textBox.Text);
                        using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            foreach (DataRow dataRow in dt.Rows)
                            {
                                int buyer_UID = (int)dataRow["买家UID"];
                                double money_to_return = (double)dataRow["要退回款项"];
                                SqlHelper.Updatet_ChangeNum("用户表", "余额", string.Format("UID={0}", buyer_UID), true, money_to_return);
                            }
                        }
                        conn.Close();
                    }

                    //4.由于要删除订单，所以要回退货品表的"已订数量"属性，并使"数量"为"已订数量"。
                    //注：这是为了使被下架的货品库存为0，这样就不会被查询到
                    using (SqlConnection conn = SqlHelper.GetConn())
                    {
                        conn.Open();
                        //得到 货物编号,数量
                        string sql = string.Format("SELECT 现存订单视图.货物编号, 现存订单视图.数量 FROM 现存订单视图, 货品表, 书目表 WHERE 现存订单视图.货物编号 = 货品表.货物编号 AND 货品表.ISBN = 书目表.ISBN AND 允许交易 = 0 AND 订单状态 != '已发货' AND 货品表.ISBN = '{0}';", ISBN码textBox.Text);
                        using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            foreach (DataRow dataRow in dt.Rows)
                            {
                                int ID = (int)dataRow["货物编号"];
                                int count_ordered = (int)dataRow["数量"];
                                //回退货品表的"已订数量"属性
                                SqlHelper.Updatet_ChangeNum("货品表", "已订数量", string.Format("货物编号={0}", ID), false, count_ordered);
                            }
                            //使"数量"为"已订数量"
                            SqlHelper.UpdateItem("货品表", "数量=已订数量", "货物编号 IN (SELECT 货物编号 FROM 货品视图 WHERE 允许交易 = 0)");
                        }
                        conn.Close();
                    }

                    //5.将即将从"订单表"删除的项，记录到"历史订单表"中，并将"订单状态"设置为"禁止交易"
                    SqlHelper.ExecuteNonQuery(string.Format("INSERT INTO 历史订单表(订单号,交易时间,货物编号,卖家UID,买家UID,价格,数量,收货地址,订单状态) SELECT 订单号,交易时间,货物编号,卖家UID,买家UID,价格,数量,NULL 收货地址,'禁止销售' 订单状态 FROM 现存订单表 WHERE 订单状态 != '已发货' AND 货物编号 IN( SELECT 货物编号 FROM 货品表 WHERE ISBN = {0})", ISBN码textBox.Text));
                    //6.从订单表删除对应的"订单属性"不为"已发货"的项
                    SqlHelper.DeleteItem("现存订单表", string.Format("订单状态!='已发货' AND 货物编号 IN(SELECT 货物编号 FROM 货品表 WHERE ISBN = {0})", ISBN码textBox.Text));
                    //7.库存为0的货品将直接被删除
                    //注：不为0的继续保留，是因为那个货品有已发货的订单
                    SqlHelper.DeleteItem("货品表", string.Format("已订数量=0 AND ISBN='{0}'", ISBN码textBox.Text));
                    查询button_Click(sender, e);//刷新
                }
                else//点击取消
                {
                    return;
                }
            }
        }

        private void 允许交易button_Click(object sender, EventArgs e)
        {
            if (ISBN码textBox.Text == "")
            {
                MessageBox.Show("请指定书籍！");
            }
            else if (ISBN码textBox.Text.Length != 10 && ISBN码textBox.Text.Length != 13)
            {
                MessageBox.Show("ISBN码必须为10位或13位");
            }
            else if (允许交易textBox.Text == "✔")
            {
                MessageBox.Show("该书已被允许交易！");
            }
            else
            {
                DialogResult dr = MessageBox.Show("确认允许其交易？", " 确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.OK)//确认删除
                {
                    //1.修改对应的"书目表(允许交易)"为true
                    SqlHelper.UpdateItem("书目表", "允许交易=1", string.Format("ISBN={0}", ISBN码textBox.Text));
                    //2.若ISBN对应的商品还存在，修改对应的"购物车(有效)"为true
                    SqlHelper.UpdateItem("购物车表", "有效=1", string.Format("货物编号 IN (SELECT 购物车表.货物编号 FROM 购物车表,货品表 WHERE 购物车表.货物编号 = 货品表.货物编号 AND ISBN={0})", ISBN码textBox.Text));

                    查询button_Click(sender, e);//刷新
                }
                else//点击取消
                {
                    return;
                }
            }
        }

        private void 清空button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否清空文本框", " 清空", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)//确认添加
            {
                ISBN码textBox.Text = "";
                书名textBox.Text = "";
                作者textBox.Text = "";
                出版社textBox.Text = "";
                价格textBox.Text = "";
                允许交易textBox.Text = "";

                年comboBox.SelectedIndex = 年comboBox.Items.IndexOf("2018年");
                月comboBox.SelectedIndex = 月comboBox.Items.IndexOf("1月");
                日comboBox_Change();//生成日期列表
                日comboBox.SelectedIndex = 日comboBox.Items.IndexOf("1日");
            }
            else//点击取消
            {
                return;
            }
        }

        private void 查询button_Click(object sender, EventArgs e)
        {
            if (查询textBox.Text == "")
            {
                //判断查询框类关键字是否为默认的“”，如果是，则显示全部信息。
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, "SELECT ISBN,书名,作者,出版社,出版时间,CAST (定价 AS DECIMAL(18,2)) 定价,允许交易 FROM 书目表;");
            }
            else
            {
                //使用封装在SqlHelper类中ShowDataWithDataGirdView方法来显示数据，同时使用SQL语句实现模糊查询以及多类信息关键字查询。
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, String.Format("SELECT ISBN,书名,作者,出版社,出版时间,CAST (定价 AS DECIMAL(18,2)) 定价,允许交易 FROM 书目表 WHERE ISBN LIKE '%{0}%' OR 书名 LIKE '%{0}%' OR 作者 LIKE '%{0}%' OR 出版社 LIKE '%{0}%' ; ", 查询textBox.Text));
            }

            //按订单状态标注颜色
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((bool)row.Cells[6].Value == false)
                    row.DefaultCellStyle.BackColor = Color.Pink;
            }
        }

        private void 日comboBox_Change()
        {
            日comboBox.Items.Clear();//清空
            int year = Convert.ToInt32(年comboBox.Text.Substring(0, 年comboBox.Text.Length - 1));
            int month = Convert.ToInt32(月comboBox.Text.Substring(0, 月comboBox.Text.Length - 1));
            int[] big_month = { 1, 3, 5, 7, 8, 10, 12 };//大月
            int[] small_month = { 4, 6, 9, 11 };//小月
            if (((IList)big_month).Contains(month))//属于大月
            {
                for (int day = 1; day <= 31; day++)
                    日comboBox.Items.Add(day + "日");
            }
            else if (((IList)small_month).Contains(month))//属于小月
            {
                for (int day = 1; day <= 30; day++)
                    日comboBox.Items.Add(day + "日");
            }
            else//二月
            {
                if (year % 4 == 0 && year % 100 != 0)//闰月
                {
                    for (int day = 1; day <= 29; day++)
                        日comboBox.Items.Add(day + "日");
                }
                else//平月
                {
                    for (int day = 1; day <= 28; day++)
                        日comboBox.Items.Add(day + "日");
                }
            }
            日comboBox.SelectedIndex = 日comboBox.Items.IndexOf("1日");//置为"1日"
        }

        private void 年comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (年comboBox.Text != "" && 月comboBox.Text != "")
                日comboBox_Change();
        }

        private void 月comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (年comboBox.Text != "" && 月comboBox.Text != "")
                日comboBox_Change();
        }

        private void 书目管理Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
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

                    DateTime 出版时间 = (DateTime)myrow.Cells[4].Value;
                    年comboBox.SelectedIndex = 年comboBox.Items.IndexOf(string.Format("{0}年", 出版时间.Date.Year));
                    月comboBox.SelectedIndex = 月comboBox.Items.IndexOf(string.Format("{0}月", 出版时间.Date.Month));
                    日comboBox.SelectedIndex = 日comboBox.Items.IndexOf(string.Format("{0}日", 出版时间.Date.Day));

                    this.价格textBox.Text = myrow.Cells[5].Value.ToString();
                    if ((bool)myrow.Cells[6].Value == true)
                        this.允许交易textBox.Text = "✔";
                    else
                        this.允许交易textBox.Text = "✖";
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellClick(sender, e);
            if (允许交易textBox.Text == "✔")
                禁止交易button_Click(sender, e);
            else if (允许交易textBox.Text == "✖")
                允许交易button_Click(sender, e);
            else
                MessageBox.Show("异常！！！");
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
            查询textBox.Text = "";
            查询button_Click(sender, e);
        }
    }
}
