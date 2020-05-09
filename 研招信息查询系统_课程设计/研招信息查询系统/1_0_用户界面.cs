using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 研招信息查询系统
{
    public partial class 用户界面Form : Form
    {
        private string Account;
        private string Name;
        private string Tag;
        public 用户界面Form(string Account, string Name)
        {
            InitializeComponent();
            this.Account = Account;
            this.Name = Name;
            if (Account == "" && Name == "")
                this.Tag = "游客";
            else
                this.Tag = "用户";

            toolStripStatusLabel1.Text = Name + "，" + toolStripStatusLabel1.Text;
            toolStripStatusLabel2.Text = toolStripStatusLabel2.Text + "：" + this.Tag;
        }

        private void 信息设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Tag == "用户")
            {
                信息设置Form f = new 信息设置Form(Account, Name);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("您不是注册用户！","错误");
            }

        }
        private void 院校信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            院校信息查询Form f = new 院校信息查询Form(Account, Name);
            f.ShowDialog();
        }

        private void 硕士专业目录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            硕士专业目录Form f = new 硕士专业目录Form(Account, Name);
            f.ShowDialog();
        }
        private void 院校收藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Tag == "用户")
            {
                院校收藏Form f = new 院校收藏Form(Account, Name);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("您不是注册用户！", "错误");
            }
        }

        private void 专业收藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Tag == "用户")
            {
                专业收藏Form f = new 专业收藏Form(Account, Name);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("您不是注册用户！", "错误");
            }
        }

        private void 图表分析ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Tag == "用户")
            {
                图表分析Form f = new 图表分析Form(Account, Name);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("您不是注册用户！","错误");
            }
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

        
    }
}