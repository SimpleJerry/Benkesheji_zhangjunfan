using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace 二手书交易系统_课程设计
{
    public partial class 信息设置_管理员Form : Form
    {
        private string A_account;
        private string A_name;
        public 信息设置_管理员Form(string A_account, string A_name)
        {
            this.A_account = A_account;
            this.A_name = A_name;
            InitializeComponent();
        }

        private void 管理员设置Form_Load(object sender, EventArgs e)
        {
            姓名textBox.Text = A_name;
            帐号textBox.Text = A_account;
            密码textBox.Text = SqlHelper.InquireItem("管理员表", "密码", string.Format("帐号='{0}'", A_account));
            再次输入密码textBox.Text = 密码textBox.Text;
            手机textBox.Text = SqlHelper.InquireItem("管理员表", "手机", string.Format("帐号='{0}'", A_account));
            邮箱textBox.Text = SqlHelper.InquireItem("管理员表", "邮箱", string.Format("帐号='{0}'", A_account));
        }

        private void 修改密码button_Click(object sender, EventArgs e)
        {
            if (密码textBox.Text == 再次输入密码textBox.Text)
            {
                SqlHelper.UpdateItem("管理员表", string.Format("密码='{0}'", 密码textBox.Text), string.Format("帐号='0'", A_account));
                MessageBox.Show("已成功修改！");
            }
            else
            {
                MessageBox.Show("两次输入不一致！");
            }

        }

        protected bool IS_phone(string message)//判断手机号格式是否正确的函数
        {
            if (message != "" && Regex.IsMatch(message, @"^\d{11}$"))//正则表达式判断
                return true;
            else
                return false;
        }

        protected bool IS_email(string message)//判断邮箱格式是否正确的函数
        {
            if (message != "" && Regex.IsMatch(message, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))//正则表达式判断
                return true;
            else
                return false;
        }

        private void 修改信息button_Click(object sender, EventArgs e)
        {
            if (!IS_phone(手机textBox.Text))
                MessageBox.Show("请输入正确的手机号码！");
            else if(!IS_email(邮箱textBox.Text))
                MessageBox.Show("请输入正确的邮箱！");
            else
            {
                SqlHelper.UpdateItem("管理员表", string.Format("手机='{0}',邮箱='{1}'", 手机textBox.Text, 邮箱textBox.Text), string.Format("帐号='0'", A_account));
                MessageBox.Show("已成功修改！");
            }
        }

        private void 再次输入密码textBox_MouseLeave(object sender, EventArgs e)
        {
            this.errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;//一直闪烁
            if (密码textBox.Text != 再次输入密码textBox.Text)
                this.errorProvider1.SetError(this.再次输入密码textBox, "两次输入密码不一致");
            else
                this.errorProvider1.SetError(this.再次输入密码textBox, "");
        }

        private void 管理员设置Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
        }

        private void 手机textBox_MouseLeave(object sender, EventArgs e)
        {
            this.errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;//一直闪烁
            bool s = IS_phone(手机textBox.Text);
            if (!s)
                this.errorProvider1.SetError(this.手机textBox, "请输入11位手机号");
            else
                this.errorProvider1.SetError(this.手机textBox, "");
        }

        private void 邮箱textBox_MouseLeave(object sender, EventArgs e)
        {
            this.errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;//一直闪烁
            bool s = IS_email(邮箱textBox.Text);
            if (!s)
                this.errorProvider1.SetError(this.邮箱textBox, "请按正确格式输入邮箱");
            else
            {
                this.errorProvider1.SetError(this.邮箱textBox, "");
            }
        }

        private void INT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

    }
}
