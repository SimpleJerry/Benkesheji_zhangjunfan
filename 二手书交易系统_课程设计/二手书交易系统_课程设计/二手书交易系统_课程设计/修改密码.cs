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
    public partial class 修改密码Form : Form
    {
        public 修改密码Form()
        {
            InitializeComponent();
        }

        private void 确认修改button_Click(object sender, EventArgs e)
        {

        }

        private void 取消button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 修改密码Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
        }
    }
}
