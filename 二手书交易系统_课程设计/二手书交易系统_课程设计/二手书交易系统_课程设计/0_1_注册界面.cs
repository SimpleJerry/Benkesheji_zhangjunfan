using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;//正则表达式的类
//添加一个errorProvider空间即可

namespace 二手书交易系统_课程设计
{
    public partial class 注册界面Form : Form
    {
        public 注册界面Form()
        {
            InitializeComponent();
        }

        private void 注册button_Click(object sender, EventArgs e)
        {
            int U_id = SqlHelper.GetID("用户表","UID");//得到一个新的不重复的编号
            string U_account = 帐号textBox.Text;
            string U_password = 密码textBox.Text;
            string U_password2 = 再次输入密码textBox.Text;
            string U_name = 姓名textBox.Text;
            string U_phone = 手机textBox.Text;
            string U_email = 邮箱textBox.Text;

            bool isEmpty = false;//判断是否有空项
            foreach (Control c in groupBox1.Controls)
            {
                if (c.Text == "")
                {
                    isEmpty = true;//确认有空项
                    break;
                }
            }

            bool isnum = IS_phone(U_phone); //判断手机号字符串是否为11位整数字符串
            bool isemail = IS_email(U_email);//判断邮箱格式是否正确

            if (isEmpty)
            {
                MessageBox.Show("有一项未输入!");
            }
            else
            {
                if ((U_password == U_password2) && isnum && isemail)
                {
                    try
                    {
                        SqlHelper.InsertItem("用户表(UID,帐号,密码,昵称,手机,邮箱,状态)", String.Format("('{0}','{1}','{2}','{3}','{4}','{5}','正常');", U_id, U_account, U_password, U_name, U_phone, U_email));
                        MessageBox.Show("新用户注册成功！");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("新增异常！\n注意：不能注册相同的个人基本信息");
                    }
                }
                else
                    MessageBox.Show("注册失败！\n帮助：请修改不合标准的项");
            }
        }

        protected bool IS_phone(string message)//判断手机号格式是否正确的函数
        {
            if (message != "" && Regex.IsMatch(message, @"^\d{11}$"))//正则表达式判断
            {
                //成功
                return true;
            }
            else
                //失败
                return false;
        }

        protected bool IS_email(string message)//判断邮箱格式是否正确的函数
        {
            if (message != "" && Regex.IsMatch(message, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))//正则表达式判断
            {
                //成功
                return true;
            }
            else
                //失败
                return false;
        }

        private void 再次输入密码textBox_MouseLeave(object sender, EventArgs e)
        {
            this.errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;//一直闪烁
            if (密码textBox.Text != 再次输入密码textBox.Text)
                this.errorProvider1.SetError(this.再次输入密码textBox, "两次输入密码不一致");
            else
                this.errorProvider1.SetError(this.再次输入密码textBox, "");
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

        private void 取消button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 注册界面Form_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}

