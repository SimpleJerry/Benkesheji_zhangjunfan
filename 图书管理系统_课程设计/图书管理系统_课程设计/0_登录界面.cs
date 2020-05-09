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
    public partial class 登录界面Form : Form
    {
        RadioButton Tag = new RadioButton();//用于标识管理员和读者
        public 登录界面Form()
        {
            InitializeComponent();
        }

        private void 退出button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 进入button_Click(object sender, EventArgs e)
        {
            string Account = 帐号textBox.Text.Trim();
            string Password = 密码textBox.Text.Trim();
            string tag = Tag.Text.Trim();//用于标识管理员和读者
            string name = "";//用于储存姓名
            if (Account == "" || Password == "")
            {
                MessageBox.Show("请输入账号或密码", "登录失败");
            }
            else
            {
                bool check_in = false;//用于判断是否成功登录
                if (tag == "管理员")
                {
                    check_in = SqlHelper.CheckAdminPassword(Account, Password);
                    name = SqlHelper.SelectItem("Admin", "A_name", "A_account", Account);
                }
                else if (tag == "读者")
                {
                    check_in = SqlHelper.CheckReaderPassword(Account, Password);
                    name = SqlHelper.SelectItem("Reader", "R_name", "R_account", Account);
                }
                else
                {
                    MessageBox.Show("请选定账户类型！", "登录失败");
                }

                if (check_in)
                {
                    if (tag == "管理员")
                    {
                        管理员界面Form f = new 管理员界面Form(Account, name, tag);
                        this.Hide();
                        MessageBox.Show(String.Format("你好，{0}:{1}！", tag, name), "登录成功");
                        f.ShowDialog();
                    }
                    else if (tag == "读者")
                    {
                        读者界面Form f = new 读者界面Form(Account, name, tag);
                        this.Hide();
                        MessageBox.Show(String.Format("你好，{0}:{1}！", tag, name), "登录成功");
                        f.ShowDialog();
                    }
                }
                else if (tag != "")
                {
                    MessageBox.Show("账号或密码错误！", "登录失败");
                }
            }
        }

        private void 管理员radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Tag = 管理员radioButton;
        }

        private void 读者radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Tag = 读者radioButton;
        }

        private void 注册帐号linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            注册界面Form f = new 注册界面Form();
            f.ShowDialog();
        }

        private void 登录界面Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
        }
    }
}