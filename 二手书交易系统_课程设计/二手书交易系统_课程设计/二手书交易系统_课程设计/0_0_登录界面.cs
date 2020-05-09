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
    public partial class 登录界面Form : Form
    {
        RadioButton Tag = new RadioButton();//用于标识管理员和用户
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
            string Account = 帐号textBox.Text;
            string Password = 密码textBox.Text;
            string tag = Tag.Text;//用于标识管理员和用户
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
                    check_in = SqlHelper.CheckPassword("管理员表", Account, Password);
                    name = SqlHelper.InquireItem("管理员表", "姓名", string.Format("帐号='{0}'", Account));
                }
                else if (tag == "用户")
                {
                    check_in = SqlHelper.CheckPassword("用户表", Account, Password);
                    name = SqlHelper.InquireItem("用户表", "昵称", string.Format("帐号='{0}'", Account));
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
                    else if (tag == "用户")
                    {
                        string U_condition = SqlHelper.InquireItem("用户表", "状态", string.Format("帐号='{0}'", Account));
                        if (U_condition == "黑名单")
                        {
                            MessageBox.Show("您已被拉入黑名单，禁止登录！");
                        }
                        else
                        {
                            用户界面Form f = new 用户界面Form(Account, name, tag);
                            this.Hide();
                            MessageBox.Show(String.Format("你好，{0}:{1}！", tag, name), "登录成功");
                            f.ShowDialog();
                        }
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

        private void 用户radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Tag = 用户radioButton;
        }

        private void 注册帐号linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            注册界面Form f = new 注册界面Form();
            f.ShowDialog();
        }

        private void 忘记密码linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //忘记密码Form f = new 忘记密码Form();
            待开发Form f = new 待开发Form();
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
