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
    public partial class 用户设置Form : Form
    {
        private string U_account;
        private string U_name;
        public 用户设置Form(string U_account, string U_name)
        {
            this.U_account = U_account;
            this.U_name = U_name;
            InitializeComponent();
        }

        private void 用户设置Form_Load(object sender, EventArgs e)
        {
            姓名textBox.Text = U_name;
            帐号textBox.Text = U_account;
            密码textBox.Text = SqlHelper.InquireItem("用户表", "密码", string.Format("帐号='{0}'", U_account));
            再次输入密码textBox.Text = 密码textBox.Text;
            手机textBox.Text = SqlHelper.InquireItem("用户表", "手机", string.Format("帐号='{0}'", U_account));
            邮箱textBox.Text = SqlHelper.InquireItem("用户表", "邮箱", string.Format("帐号='{0}'", U_account));
            专业textBox.Text = SqlHelper.InquireItem("用户表", "专业", string.Format("帐号='{0}'", U_account));
            年级comboBox.SelectedIndex = 年级comboBox.Items.IndexOf(SqlHelper.InquireItem("用户表", "年级", string.Format("帐号='{0}'", U_account)));
            收货地址textBox.Text = SqlHelper.InquireItem("用户表", "收货地址", string.Format("帐号='{0}'", U_account));
            余额textBox.Text = SqlHelper.InquireItem("用户表", "余额", string.Format("帐号='{0}'", U_account));
        }

        private void 修改密码button_Click(object sender, EventArgs e)
        {
            if (密码textBox.Text == 再次输入密码textBox.Text)
            {
                SqlHelper.UpdateItem("用户表", string.Format("密码='{0}'", 密码textBox.Text), string.Format("帐号='{0}'", U_account));
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
            {
                手机textBox.ForeColor = Color.Red;
                MessageBox.Show("请输入正确的手机号码！");
            }
            else if (!IS_email(邮箱textBox.Text))
            {
                邮箱textBox.ForeColor = Color.Red;
                MessageBox.Show("请输入正确的邮箱地址！");
            }
            else
            {
                SqlHelper.UpdateItem("用户表", string.Format("手机='{0}'", 手机textBox.Text), string.Format("帐号='{0}'", U_account));
                SqlHelper.UpdateItem("用户表", string.Format("邮箱='{0}'", 邮箱textBox.Text), string.Format("帐号='{0}'", U_account));
                SqlHelper.UpdateItem("用户表", string.Format("专业='{0}'", 专业textBox.Text), string.Format("帐号='{0}'", U_account));
                SqlHelper.UpdateItem("用户表", string.Format("年级='{0}'", 年级comboBox.Text), string.Format("帐号='{0}'", U_account));
                SqlHelper.UpdateItem("用户表", string.Format("收货地址='{0}'", 收货地址textBox.Text), string.Format("帐号='{0}'", U_account));
                MessageBox.Show("已成功修改！");
                手机textBox.ForeColor = Color.Black;
                邮箱textBox.ForeColor = Color.Black;
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

        private void 用户设置Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
        }

        private void INT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
                e.Handled = true;
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
                this.errorProvider1.SetError(this.邮箱textBox, "");
        }
    }
}
