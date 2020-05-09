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

namespace 图书管理系统_课程设计
{
    public partial class 注册界面Form : Form
    {
        public 注册界面Form()
        {
            InitializeComponent();
        }

        private void 注册button_Click(object sender, EventArgs e)
        {
            SqlConnection conn = SqlHelper.GetConn();
            SqlCommand cmd = new SqlCommand("SELECT count(*) FROM Reader", conn);
            conn.Open();
            //int obj = Convert.ToInt32(cmd.ExecuteScalar());

            string obj = SqlHelper.SelectItem_OnlyMax("Reader", "MAX(R_id)+1", "R_condition");//得到一个新的不重复的编号

            string R_id = (obj + 1).ToString();
            string R_account = 账号textBox.Text;
            string R_password = 密码textBox.Text;
            string R_password2 = 再次输入密码textBox.Text;
            string R_name = 姓名textBox.Text;
            string R_phone = 手机textBox.Text;
            string R_email = 邮箱textBox.Text;
            string R_condition = 身份comboBox.Text;

            bool isEmpty = false;//判断是否有空项
            foreach (Control c in groupBox1.Controls)
            {
                if (c.Text == "")
                {
                    isEmpty = true;//确认有空项
                    break;
                }
            }

            bool isnum = isR_phone(R_phone); //判断手机号字符串是否为11为整数字符串
            bool isemail = isR_email(R_email);//判断邮箱格式是否正确
            bool isname = isR_name(R_name);//判断名字格式是否正确



            if (isEmpty)
            {
                MessageBox.Show("有一项未输入!");
            }
            else
            {
                if ((R_password == R_password2) && isnum && isemail && isname)
                {
                    try
                    {
                        SqlHelper.InsertItem("Reader(R_id,R_account,R_password,R_name,R_phone,R_email,R_condition)", String.Format("('{0}','{1}','{2}','{3}','{4}','{5}','{6}');", R_id, R_account, R_password, R_name, R_phone, R_email, R_condition));
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

        protected bool isR_phone(string message)//判断手机号格式是否正确的函数
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

        protected bool isR_email(string message)//判断邮箱格式是否正确的函数
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

        protected bool isR_name(string message)
        {
            bool mark = false;
            char[] c = message.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if ((c[i] >= 65 && c[i] <= 90) || (c[i] >= 97 && c[i] <= 122) || c[i] > 127 || c[i] == 32)
                    mark = true;
                else
                    mark = false;
            }
            return mark;
        }

        private void 再次输入密码textBox_MouseLeave(object sender, EventArgs e)
        {
            this.errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;//一直闪烁
            if (密码textBox.Text != 再次输入密码textBox.Text)
                this.errorProvider1.SetError(this.再次输入密码textBox, "两次输入密码不一致");
            else
            {
                this.errorProvider1.SetError(this.再次输入密码textBox, "");
            }

        }

        private void 手机textBox_MouseLeave(object sender, EventArgs e)
        {
            this.errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;//一直闪烁
            bool s = isR_phone(手机textBox.Text);
            if (!s)
                this.errorProvider1.SetError(this.手机textBox, "请输入11位手机号");
            else
            {
                this.errorProvider1.SetError(this.手机textBox, "");
            }
        }

        private void 邮箱textBox_MouseLeave(object sender, EventArgs e)
        {
            this.errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;//一直闪烁
            bool s = isR_email(邮箱textBox.Text);
            if (!s)
                this.errorProvider1.SetError(this.邮箱textBox, "请按正确格式输入邮箱");
            else
            {
                this.errorProvider1.SetError(this.邮箱textBox, "");
            }
        }

        private void 姓名textBox_MouseLeave(object sender, EventArgs e)
        {
            this.errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;//一直闪烁
            bool s = isR_name(姓名textBox.Text);
            if (!s)
                this.errorProvider1.SetError(this.姓名textBox, "只允许输入汉字、字母及空格");
            else
            {
                this.errorProvider1.SetError(this.姓名textBox, "");
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
    }
}

