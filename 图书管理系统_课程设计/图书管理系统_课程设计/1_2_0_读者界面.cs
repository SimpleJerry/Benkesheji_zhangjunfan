using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图书管理系统_课程设计
{
    public partial class 读者界面Form : Form
    {
        private string Account;//用于存储帐号
        private string User_name;
        public 读者界面Form(string Account, string User_name, string tag)
        {
            InitializeComponent();
            this.Account = Account;
            this.User_name = User_name;
            toolStripStatusLabel1.Text = User_name + "，" + toolStripStatusLabel1.Text;
            toolStripStatusLabel2.Text = toolStripStatusLabel2.Text + "：" + tag;
        }

        private void 个人信息设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            个人信息设置Form f = new 个人信息设置Form(Account, User_name);
            f.ShowDialog();
        }

        private void 在借图书查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            个人借阅图书查询Form f = new 个人借阅图书查询Form(Account);
            f.ShowDialog();
        }

        private void 图书查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            图书查询Form f = new 图书查询Form();
            f.ShowDialog();
        }

        private void 读者界面Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
        }
    }
}
