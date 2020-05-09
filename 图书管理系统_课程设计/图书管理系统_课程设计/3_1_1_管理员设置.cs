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
    public partial class 管理员设置Form : Form
    {
        private string A_account;
        private string A_name;
        public 管理员设置Form(string A_account,string A_name)
        {
            this.A_account = A_account;
            this.A_name = A_name;
            InitializeComponent();
        }

        private void 管理员设置Form_Load(object sender, EventArgs e)
        {
            姓名textBox.Text = A_name;
            帐号textBox.Text = A_account;
            密码textBox.Text = SqlHelper.SelectItem("Admin", "A_password", "A_account", A_account);
            电话textBox.Text = SqlHelper.SelectItem("Admin", "A_phone", "A_account", A_account);
        }

        private void 密码button_Click(object sender, EventArgs e)
        {
            SqlHelper.UpdatetItem1("Admin", "A_password", 密码textBox.Text, "A_account", A_account);
            MessageBox.Show("已成功修改！");
        }

        private void 电话button_Click(object sender, EventArgs e)
        {
            SqlHelper.UpdatetItem1("Admin", "A_phone", 电话textBox.Text, "A_account", A_account);
            MessageBox.Show("已成功修改！");
        }

        private void 管理员设置Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
        }
    }
}
