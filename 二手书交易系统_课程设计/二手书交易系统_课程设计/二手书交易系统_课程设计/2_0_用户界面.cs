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
    public partial class 用户界面Form : Form
    {
        private string U_account;
        private string U_name;
        public 用户界面Form(string U_account, string U_name, string tag)
        {
            InitializeComponent();
            this.U_account = U_account;
            this.U_name = U_name;
            toolStripStatusLabel1.Text = U_name + "，" + toolStripStatusLabel1.Text;
            toolStripStatusLabel2.Text = toolStripStatusLabel2.Text + "：" + tag;
        }

        private void 信息设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            用户设置Form f = new 用户设置Form(U_account, U_name);
            f.ShowDialog();
        }
        private void 购物车ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            购物车Form f = new 购物车Form(U_account);
            f.ShowDialog();
        }

        private void 商品查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            商品查询Form f = new 商品查询Form(U_account);
            f.ShowDialog();
        }

        private void 现存订单查询_买ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            现存订单查询_买Form f = new 现存订单查询_买Form(U_account);
            f.ShowDialog();
        }

        private void 历史订单查询_买ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            历史订单查询_买Form f = new 历史订单查询_买Form(U_account);
            f.ShowDialog();
        }

        private void 发布商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            发布商品Form f = new 发布商品Form(U_account);
            f.ShowDialog();
        }

        private void 管理商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            管理货品Form f = new 管理货品Form(U_account);
            f.ShowDialog();
        }

        private void 现存订单查询_卖ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            现存订单查询_卖Form f = new 现存订单查询_卖Form(U_account);
            f.ShowDialog();
        }

        private void 历史订单查询_卖ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            历史订单查询_卖Form f = new 历史订单查询_卖Form(U_account);
            f.ShowDialog();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 用户界面Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
        }

        private void 书目管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
