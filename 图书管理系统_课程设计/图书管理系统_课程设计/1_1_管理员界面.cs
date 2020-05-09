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
    public partial class 管理员界面Form : Form
    {
        private string Account;//用于存储帐号
        private string User_name;
        public 管理员界面Form(string Account,string User_name,string tag)
        {
            InitializeComponent();
            this.Account = Account;
            this.User_name = User_name;
            toolStripStatusLabel1.Text = User_name+"，"+ toolStripStatusLabel1.Text;
            toolStripStatusLabel2.Text = toolStripStatusLabel2.Text+"："+ tag;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            添加图书Form f = new 添加图书Form();
            f.ShowDialog();
        }//添加图书

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            图书借阅Form f = new 图书借阅Form();
            f.ShowDialog();
        }//图书借阅

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            读者管理Form f = new 读者管理Form();
            f.ShowDialog();
        }//读者管理

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            在借查询Form f = new 在借查询Form();
            f.ShowDialog();
        }//借阅查询

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            图书管理Form f = new 图书管理Form();
            f.ShowDialog();
        }//图书管理

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            图书查询Form f = new 图书查询Form();
            f.ShowDialog();
        }//图书查询

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            历史查询Form f = new 历史查询Form();
            f.ShowDialog();
        }//历史查询

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            this.Close();
        }//退出系统

        private void 管理员设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            管理员设置Form f = new 管理员设置Form(Account,User_name);
            f.ShowDialog();
        }

        private void 系统信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            系统信息Form f = new 系统信息Form();
            f.ShowDialog();
        }

        private void 图书挂失ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            图书挂失Form f = new 图书挂失Form();
            f.ShowDialog();
        }

        private void 图书解挂ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            图书解挂Form f = new 图书解挂Form();
            f.ShowDialog();
        }

        private void 导入图书信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            导入图书信息Form f = new 导入图书信息Form();
            f.ShowDialog();
        }

        private void 导出图书信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            导出图书信息Form f = new 导出图书信息Form();
            f.ShowDialog();
        }

        private void 注销读者信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            注销读者信息Form f = new 注销读者信息Form();
            f.ShowDialog();
        }
        private void 吊销读者帐号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            吊销读者帐号Form f = new 吊销读者帐号Form();
            f.ShowDialog();
        }

        private void 黑名单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            黑名单Form f = new 黑名单Form();
            f.ShowDialog();
        }
        private void 导入读者信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            导入读者信息Form f = new 导入读者信息Form();
            f.ShowDialog();
        }

        private void 导出读者信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            导出读者信息Form f = new 导出读者信息Form();
            f.ShowDialog();
        }
        private void 读者档案查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            读者档案查询Form f = new 读者档案查询Form();
            f.ShowDialog();
        }

        private void 系统计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            系统计算器Form f = new 系统计算器Form();
            f.ShowDialog();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            关于Form f = new 关于Form();
            f.ShowDialog();
        }

        private void 日历信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            日历信息Form f = new 日历信息Form();
            f.ShowDialog();
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
