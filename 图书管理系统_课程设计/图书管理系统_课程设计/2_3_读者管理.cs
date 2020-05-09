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

namespace 图书管理系统_课程设计
{
    public partial class 读者管理Form : Form
    {
        public 读者管理Form()
        {
            InitializeComponent();
            this.身份comboBox.Text = this.身份comboBox.Items[0].ToString();
            账号textBox.BackColor = System.Drawing.Color.SkyBlue;
            姓名textBox.BackColor = System.Drawing.Color.SkyBlue;
        }


        //-----------------------------------------------------------------------
        protected bool isR_account(string message)//判断账号格式是否正确的函数
        {
            if (message != "" && Regex.IsMatch(message, @"^\d{12}$"))//正则表达式判断
            {
                //成功
                return true;
            }
            else
                //失败
                return false;
        }

        protected bool isR_name(string message)//判断姓名格式是否正确的函数
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

        protected bool isR_phone(string message)//判断电话号格式是否正确的函数
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


        //-----------------------------------------------------------------------

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //查询后颜色复原
            账号textBox.BackColor = System.Drawing.Color.White;
            姓名textBox.BackColor = System.Drawing.Color.White;
            //添加后颜色复原
            账号textBox.BackColor = System.Drawing.Color.White;
            电话textBox.BackColor = System.Drawing.Color.White;
            邮箱textBox.BackColor = System.Drawing.Color.White;
            DataGridViewSelectedRowCollection myrows = dataGridView1.SelectedRows;
            foreach (DataGridViewRow myrow in myrows)
            {
                this.序号textBox.Text = myrow.Cells[0].Value.ToString();
                this.账号textBox.Text = myrow.Cells[1].Value.ToString();
                this.姓名textBox.Text = myrow.Cells[2].Value.ToString();
                this.电话textBox.Text = myrow.Cells[3].Value.ToString();
                this.邮箱textBox.Text = myrow.Cells[4].Value.ToString();
                this.身份comboBox.Text = myrow.Cells[5].Value.ToString();
                //this.textBox7.Text = myrow.Cells[6].Value.ToString();//密码

            }
        }

        private void button1_Click(object sender, EventArgs e)//将数据库里的信息显示到GridView里
        {      
            SqlHelper.ShowDataWithDataGirdView(dataGridView1, "SELECT R_id 读者序号, R_account 帐号, R_name 姓名, R_phone 电话, R_email 邮箱, R_condition 状态 FROM Reader; ");
            总人数textBox.Text = SqlHelper.SelectItem_OnlyMax("Reader", "COUNT(*)", "R_condition");//显示总人数
        }

        private void 更新button_Click(object sender, EventArgs e)//更新信息
        {
            // textBox1.ReadOnly = true;
            序号textBox.BackColor =System.Drawing.Color.DarkGray;
            //判断是否有不符合要求的输入
            bool bo = isR_account(账号textBox.Text) && isR_name(姓名textBox.Text) && isR_phone(电话textBox.Text) && isR_email(邮箱textBox.Text);
            if (序号textBox.Text == "" || 账号textBox.Text == "" || 姓名textBox.Text == "" || 电话textBox.Text == "" || 邮箱textBox.Text == "")
            {
                MessageBox.Show("信息不完整！");
            }

            else if (!bo)
            {
                MessageBox.Show("更新失败！\n帮助：请修改不合标准的项");
            }

            else 
            {
                int a1 = 0, a2 = 0, a3 = 0, a4 = 0, a5 = 0;
                int all;
                a1 = SqlHelper.UpdatetItem1("Reader", "R_account", 账号textBox.Text, "R_id", 序号textBox.Text);
                a2 = SqlHelper.UpdatetItem1("Reader", "R_name", 姓名textBox.Text, "R_id", 序号textBox.Text);
                a3 = SqlHelper.UpdatetItem1("Reader", "R_phone", 电话textBox.Text, "R_id", 序号textBox.Text);
                a4 = SqlHelper.UpdatetItem1("Reader", "R_email", 邮箱textBox.Text, "R_id", 序号textBox.Text);
                a5 = SqlHelper.UpdatetItem1("Reader", "R_condition", 身份comboBox.Text, "R_id", 序号textBox.Text);
                //a6 = SqlHelper.UpdatetItem1("Reader", "R_password", textBox7.Text, "R_id", textBox1.Text);密码
                all = a1 + a2 + a3 + a4 + a5;

                if (all == 5)
                {
                    MessageBox.Show("信息更新成功");
                    button1_Click( sender, e);
                }
                else
                    MessageBox.Show("信息更新失败！");
            }
        }

        private void 添加button_Click(object sender, EventArgs e)//添加信息
        {
            序号textBox.Text = SqlHelper.SelectItem_OnlyMax("Reader", "MAX(R_id)+1", "R_condition");//得到一个新的不重复的编号
            序号textBox.ReadOnly = true;
            序号textBox.BackColor = System.Drawing.Color.DarkGray;
            //判断是否有不符合要求的输入
            bool bo2 = isR_account(账号textBox.Text) && isR_name(姓名textBox.Text) && isR_phone(电话textBox.Text) && isR_email(邮箱textBox.Text);

            if (序号textBox.Text == "" || 账号textBox.Text == "" || 姓名textBox.Text == "" || 电话textBox.Text == "" || 邮箱textBox.Text == "" || 身份comboBox.Text == "")
            {
                MessageBox.Show("信息不完整！");
            }

            else if (!bo2)
            {
                MessageBox.Show("添加失败！\n帮助：请修改不合标准的项");
            }
            else
            {
                bool mark=true;
  
                //if (SqlHelper.SelectItem("Reader", "R_id", "R_id", 序号textBox.Text) != "Not Found!")//解决了添加读者时插入重复的BUG
                //{
                //    MessageBox.Show("添加序号重复!\n已为您默认生成！");
                //    序号textBox.Text = SqlHelper.SelectItem_OnlyMax("Reader", "MAX(R_id)+1", "R_condition");//得到一个新的不重复的编号
                //}

                if (SqlHelper.SelectItem("Reader", "R_account", "R_account", 账号textBox.Text) != "Not Found!" )
                {
                    mark = false;
                    账号textBox.BackColor = System.Drawing.Color.Red;  
                    //MessageBox.Show("账号已被注册！");
                    this.errorProvider1.SetError(this.账号textBox, "账号已被注册！");
                }
                else
                {
                    mark = true;
                    账号textBox.BackColor = System.Drawing.Color.White;
                    this.errorProvider1.SetError(this.账号textBox, "");
                }
               

                if( SqlHelper.SelectItem("Reader", "R_phone", "R_phone", 电话textBox.Text) != "Not Found!")
                {
                    mark = false;
                    电话textBox.BackColor = System.Drawing.Color.Red;
                    //MessageBox.Show("电话号码已被注册！");
                    this.errorProvider1.SetError(this.电话textBox, "电话已被注册！");
                }
                else
                {
                    mark = true;
                    电话textBox.BackColor = System.Drawing.Color.White;
                    this.errorProvider1.SetError(this.电话textBox, "");
                }
                
                if (SqlHelper.SelectItem("Reader", "R_email", "R_email", 邮箱textBox.Text) != "Not Found!")
                {
                    mark = false;
                    邮箱textBox.BackColor = System.Drawing.Color.Red;
                    //MessageBox.Show("邮箱已被注册！");
                    this.errorProvider1.SetError(this.邮箱textBox, "邮箱已被注册！");
                }
                else
                {
                    mark = true;
                    邮箱textBox.BackColor = System.Drawing.Color.White;
                    this.errorProvider1.SetError(this.邮箱textBox, "");
                }

                if (mark)
                {
                    SqlHelper.InsertItem("Reader(R_id,R_account,R_password,R_name,R_phone,R_email,R_condition)", String.Format("('{0}','{1}','{2}','{3}','{4}','{5}','{6}');", 序号textBox.Text, 账号textBox.Text, "123456", 姓名textBox.Text, 电话textBox.Text, 邮箱textBox.Text, 身份comboBox.Text));
                    button1_Click(sender, e);
                }
                //else
                //{
                //    MessageBox.Show("添加失败！");
                //}
            }
        }

        private void 删除button_Click(object sender, EventArgs e)
        {
            if (SqlHelper.SelectItem("History", "R_id", "R_id", 序号textBox.Text) != "Not Found!")
            {
                MessageBox.Show("此同学有书未还！");//这里逻辑
            }
            else
            {
                SqlHelper.DeleteItem1("Reader", "R_id", 序号textBox.Text);
                button1_Click(sender, e);
            }
        }

        private void 查询button_Click(object sender, EventArgs e)
        {
            账号textBox.BackColor = System.Drawing.Color.SkyBlue;
            姓名textBox.BackColor = System.Drawing.Color.SkyBlue;
            if (账号textBox.Text == "" && 姓名textBox.Text == "")
            {
                MessageBox.Show("请输入账号或姓名");
            }
            else if(账号textBox.Text != "" && 姓名textBox.Text == "")
            {
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, string.Format("SELECT R_id 读者序号, R_account 帐号, R_name 姓名, R_phone 电话, R_email 邮箱, R_condition 状态 FROM Reader WHERE R_account='{0}'; ", 账号textBox.Text));
            }

            else if (账号textBox.Text == "" && 姓名textBox.Text != "")
            {
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, string.Format("SELECT R_id 读者序号, R_account 帐号, R_name 姓名, R_phone 电话, R_email 邮箱, R_condition 状态 FROM Reader WHERE R_name='{0}'; ", 姓名textBox.Text));
            }
            else
            {
                string str1 = SqlHelper.SelectItem("Reader","R_account","R_account",账号textBox.Text);
                string str2 = SqlHelper.SelectItem("Reader", "R_account", "R_name", 姓名textBox.Text);
                if (str1 == str2 && str1 != "Not Found!")
                {
                    SqlHelper.ShowDataWithDataGirdView(dataGridView1, string.Format("SELECT R_id 读者序号, R_account 帐号, R_name 姓名, R_phone 电话, R_email 邮箱, R_condition 状态 FROM Reader WHERE R_account='{0}'; ", 账号textBox.Text));
                }
                else
                {
                    MessageBox.Show("姓名和账号不匹配！");
                }
            }
        }

        private void 序号textBox_MouseClick(object sender, MouseEventArgs e)
        {
            序号textBox.Text = SqlHelper.SelectItem_OnlyMax("Reader", "MAX(R_id)+1", "R_condition");//得到一个新的不重复的编号
            序号textBox.ReadOnly = true;
            序号textBox.BackColor = System.Drawing.Color.DarkGray;
            

        }

        private void 读者管理Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
        }

        private void 姓名textBox_Leave(object sender, EventArgs e)
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

        private void 电话textBox_Leave(object sender, EventArgs e)
        {
            this.errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;//一直闪烁
            bool s = isR_phone(电话textBox.Text);
            if (!s)
                this.errorProvider1.SetError(this.电话textBox, "请输入11位手机号");
            else
            {
                this.errorProvider1.SetError(this.电话textBox, "");
            }
        }

        private void 邮箱textBox_Leave(object sender, EventArgs e)
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

        private void 账号textBox_Leave(object sender, EventArgs e)
        {
            this.errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;//一直闪烁
            bool s = isR_account(账号textBox.Text);
            if (!s)
                this.errorProvider1.SetError(this.账号textBox, "请输入12位数字账号");
            else
            {
                this.errorProvider1.SetError(this.账号textBox, "");
            }
        }







      
  
    }
}

