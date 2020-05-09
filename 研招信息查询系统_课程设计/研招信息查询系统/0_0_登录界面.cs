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
    public partial class 登录界面Form : Form
    {
        public 登录界面Form()
        {
            InitializeComponent();

        }
        private void 登录界面Form_Load(object sender, EventArgs e)
        {
            用户radioButton.Checked = true;
            //以下仅为调试用,最终清空这两个textBox即可（为了退出登录功能）
            //帐号textBox.Text = "guest";
            //密码textBox.Text = "guest";
            帐号textBox.Text = "";
            密码textBox.Text = "";
        }

        private void 进入button_Click(object sender, EventArgs e)
        {
            if (用户radioButton.Checked)
            {
                string Account = 帐号textBox.Text;
                string Password = 密码textBox.Text;
                string name;//用于储存姓名
                bool check_in = false;//用于判断是否成功登录
                if (Account == "" || Password == "")
                {
                    MessageBox.Show("请输入账号或密码", "登录失败");
                }
                else
                {
                    check_in = SqlHelper.CheckPassword("用户表", Account, Password);
                    name = SqlHelper.InquireItem("用户表", "昵称", string.Format("帐号='{0}'", Account));
                    if (check_in)
                    {
                        用户界面Form f = new 用户界面Form(Account, name);
                        this.Hide();
                        MessageBox.Show(String.Format("您好，用户:{0}！", name), "登录成功");
                        f.ShowDialog();
                        this.Show();//重新显示登录界面
                        登录界面Form_Load(null, null);//初始化登录界面
                    }
                    else
                    {
                        MessageBox.Show("账号或密码错误！", "登录失败");
                    }
                }
            }
            else
            {
                用户界面Form f = new 用户界面Form("", "");
                this.Hide();
                f.ShowDialog();
                this.Show();//重新显示登录界面
                登录界面Form_Load(null, null);//初始化登录界面
            }
        }

        private void 退出button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 游客radioButton_CheckedChanged(object sender, EventArgs e)
        {
            帐号Lable.Visible = !帐号Lable.Visible;
            帐号textBox.Visible = !帐号textBox.Visible;
            密码Lable.Visible = !密码Lable.Visible;
            密码textBox.Visible = !密码textBox.Visible;
            忘记密码linkLabel.Visible = !忘记密码linkLabel.Visible;
        }

        private void 注册帐号linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            注册界面Form f = new 注册界面Form();
            f.ShowDialog();
        }

        private void 忘记密码linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            忘记密码界面Form f = new 忘记密码界面Form();
            f.ShowDialog();
        }
    }
}
