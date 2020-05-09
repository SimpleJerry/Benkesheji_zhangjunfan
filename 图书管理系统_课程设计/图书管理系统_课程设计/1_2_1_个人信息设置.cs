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
    public partial class 个人信息设置Form : Form
    {
        private string R_account;
        private string R_name;
        public 个人信息设置Form(string R_account, string R_name)
        {
            this.R_account = R_account;
            this.R_name = R_name;
            InitializeComponent();
        }

        private void 个人信息设置Form_Load(object sender, EventArgs e)
        {
            姓名textBox.Text = R_name;
            帐号textBox.Text = R_account;
            密码textBox.Text = SqlHelper.SelectItem("Reader", "R_password", "R_account", R_account);
            电话textBox.Text = SqlHelper.SelectItem("Reader", "R_phone", "R_account", R_account);
            邮箱textBox.Text = SqlHelper.SelectItem("Reader", "R_email", "R_account", R_account);
            帐号类型textBox.Text = SqlHelper.SelectItem("Reader", "R_condition", "R_account", R_account);
        }

        private void 密码button_Click(object sender, EventArgs e)
        {
            SqlHelper.UpdatetItem1("Reader", "R_password", 密码textBox.Text, "R_account", R_account);
            MessageBox.Show("已成功修改！");
        }

        private void 个人信息设置Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
        }
    }
}
