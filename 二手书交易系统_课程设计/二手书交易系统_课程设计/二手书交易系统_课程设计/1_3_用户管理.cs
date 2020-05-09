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
    public partial class 用户管理Form : Form
    {
        public 用户管理Form()
        {
            InitializeComponent();
        }

        private void 用户信息管理Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
        }

        private void 清空button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否清空文本框", " 清空", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)//确认添加
            {
                IDtextBox.Text = "";
                帐号textBox.Text = "";
                昵称textBox.Text = "";
                年级textBox.Text = "";
                专业textBox.Text = "";
                电话textBox.Text = "";
                邮箱textBox.Text = "";
                状态textBox.Text = "";
                余额textBox.Text = "";
                收货地址textBox.Text = "";
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
                //判断查询框类关键字是否为默认的“（全部）”或者“”，如果是，则显示全部信息。
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, "SELECT UID,帐号,昵称,年级,专业,邮箱,手机,余额,收货地址,状态 FROM 用户表;");
            }
            else
            {
                //使用封装在SqlHelper类中ShowDataWithDataGirdView方法来显示数据，同时使用SQL语句实现模糊查询以及多类信息关键字查询。
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, String.Format("SELECT UID,帐号,昵称,年级,专业,邮箱,手机,余额,收货地址,状态 FROM 用户表 WHERE UID LIKE '%{0}%' OR 昵称 LIKE '%{0}%'OR 年级 LIKE '%{0}%'OR 专业 LIKE '%{0}%' ; ", 查询textBox.Text));
            }

            //按订单状态标注颜色
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((string)row.Cells[9].Value == "黑名单")
                    row.DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void 查看黑名单button_Click(object sender, EventArgs e)
        {
            SqlHelper.ShowDataWithDataGirdView(dataGridView1, "SELECT UID,帐号,昵称,年级,专业,邮箱,手机,余额,收货地址,状态 FROM 用户表 WHERE 状态='黑名单';");
        }

        private void 吊销button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否吊销此用户？", " 确定", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                if (IDtextBox.Text != "")
                {
                    if (SqlHelper.InquireItem("用户表", "状态", string.Format("UID={0}", IDtextBox.Text)) == "正常")
                        SqlHelper.UpdateItem("用户表", "状态='黑名单'", string.Format("UID={0}", IDtextBox.Text));
                    else
                        MessageBox.Show("操作失败！此用户已处于黑名单！");
                }
                查询button_Click(null, null);
            }
        }

        private void 解禁button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否解禁此用户？", " 确定", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                if (IDtextBox.Text != "")
                {
                    if (SqlHelper.InquireItem("用户表", "状态", string.Format("UID={0}", IDtextBox.Text)) == "黑名单")
                        SqlHelper.UpdateItem("用户表", "状态='正常'", string.Format("UID={0}", IDtextBox.Text));
                    else
                        MessageBox.Show("操作失败！此用户状态正常，无需解禁！");
                }
                查询button_Click(null, null);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewSelectedRowCollection myrows = dataGridView1.SelectedRows;
                foreach (DataGridViewRow myrow in myrows)
                {

                    this.IDtextBox.Text = myrow.Cells[0].Value.ToString();
                    this.帐号textBox.Text = myrow.Cells[1].Value.ToString();
                    this.昵称textBox.Text = myrow.Cells[2].Value.ToString();
                    this.年级textBox.Text = myrow.Cells[3].Value.ToString();
                    this.专业textBox.Text = myrow.Cells[4].Value.ToString();
                    this.邮箱textBox.Text = myrow.Cells[5].Value.ToString();
                    this.电话textBox.Text = myrow.Cells[6].Value.ToString();
                    this.余额textBox.Text = myrow.Cells[7].Value.ToString();
                    this.收货地址textBox.Text = myrow.Cells[8].Value.ToString();
                    this.状态textBox.Text = myrow.Cells[9].Value.ToString();
                    if (this.状态textBox.Text == "黑名单")
                        this.状态textBox.ForeColor = Color.Red;
                    else
                        this.状态textBox.ForeColor = Color.Black;
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellClick(sender, e);
            string condition = 状态textBox.Text;
            if (condition == "正常")
                吊销button_Click(sender, e);
            else
                解禁button_Click(sender, e);
        }

        private void 查询textBox_Click(object sender, EventArgs e)
        {
            查询textBox.Text = "";查询button_Click(sender, e);
        }
    }
}
