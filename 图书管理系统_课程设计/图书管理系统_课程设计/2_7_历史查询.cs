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
    public partial class 历史查询Form : Form
    {
        public 历史查询Form()
        {
            InitializeComponent();
        }

        private void 查询借阅历史button_Click(object sender, EventArgs e)
        {
            SqlHelper.ShowDataWithDataGirdView(dataGridView1, "SELECT * FROM History_View; ");
        }

        private void 历史查询Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
        }
    }
}
