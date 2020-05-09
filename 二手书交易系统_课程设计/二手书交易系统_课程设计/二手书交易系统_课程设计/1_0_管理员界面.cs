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
    public partial class 管理员界面Form : Form
    {
        private string A_account;//用于存储帐号
        private string A_name;
        public 管理员界面Form(string A_account, string A_name, string tag)
        {
            InitializeComponent();
            this.A_account = A_account;
            this.A_name = A_name;
            toolStripStatusLabel1.Text = A_name + "，" + toolStripStatusLabel1.Text;
            toolStripStatusLabel2.Text = toolStripStatusLabel2.Text + "：" + tag;
        }

        private void 信息设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            信息设置_管理员Form f = new 信息设置_管理员Form(A_account,A_name);
            f.ShowDialog();
        }

        private void 系统信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            待开发Form f = new 待开发Form();
            f.ShowDialog();
        }

        private void 书目管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            书目管理Form f = new 书目管理Form();
            f.ShowDialog();
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            用户管理Form f = new 用户管理Form();
            f.ShowDialog();
        }
        
        private void 现存订单查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            现存订单查询_管理员Form f = new 现存订单查询_管理员Form();
            f.ShowDialog();
        }

        private void 历史订单查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            历史订单查询_管理员Form f = new 历史订单查询_管理员Form();
            f.ShowDialog();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            待开发Form f = new 待开发Form();
            f.ShowDialog();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 管理员界面Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
        }
    }
}
