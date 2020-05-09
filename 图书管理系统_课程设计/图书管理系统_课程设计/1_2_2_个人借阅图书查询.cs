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

namespace 图书管理系统_课程设计
{
    public partial class 个人借阅图书查询Form : Form
    {
        private string R_account;
        public 个人借阅图书查询Form(string R_account)
        {
            this.R_account = R_account;
            InitializeComponent();
            个人历史借阅书籍panel.Visible = false;
        }
        private void 个人当前借阅图书查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            个人历史借阅书籍panel.Visible = false;
        }

        private void 历史借阅图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            个人历史借阅书籍panel.Visible = true;
        }

        private void 当前借阅书单dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     //-----------------------------------------------------------------------------------------------------------------------计算所选书籍的逾期费用
            int a = this.当前借阅书单dataGridView.CurrentCell.RowIndex;
            double cost = 0;//本书欠费
            DateTime t1 = Convert.ToDateTime(当前借阅书单dataGridView.Rows[a].Cells[3].Value.ToString());
            DateTime t2 = DateTime.Now.ToLocalTime();
            cost = ((t2 - t1).Days + 1) * 0.1;
            this.本书欠费textBox.ReadOnly = false;
            if (cost > 0)
            {
                this.本书欠费textBox.Text = Convert.ToString(cost) + "(元)";
            }
            else
                this.本书欠费textBox.Text = "0(元)";
            this.本书欠费textBox.ReadOnly = true;
//---------------------------------------------------------------------------------------------------------------------------显示所选书籍的信息
            this.书名_还书textBox.ReadOnly = false;
            this.借阅日期textBox.ReadOnly = false;
            this.还书日期textBox.ReadOnly = false;
            this.索书号textBox.ReadOnly = false;
            this.书名_还书textBox.Text = 当前借阅书单dataGridView.Rows[a].Cells["书名"].Value.ToString();
            this.借阅日期textBox.Text = 当前借阅书单dataGridView.Rows[a].Cells["借书日期"].Value.ToString();
            this.还书日期textBox.Text = 当前借阅书单dataGridView.Rows[a].Cells["应还日期"].Value.ToString();
            this.索书号textBox.Text = 当前借阅书单dataGridView.Rows[a].Cells["ISBN"].Value.ToString();
            this.书名_还书textBox.ReadOnly = true;
            this.借阅日期textBox.ReadOnly = true;
            this.还书日期textBox.ReadOnly = true;
            this.索书号textBox.ReadOnly = true;

        }

        private void 个人借阅图书查询Form_Load(object sender, EventArgs e)
        {
            //---------------------------------------------------------------------------------------------------------向个人借阅历史dataGridView和当前借阅书单dataGridView注入信息
            string Raccount = Convert.ToString(R_account);
            string Rtype = SqlHelper.SelectItem("Reader_View", "类型", "帐号", Raccount);
            this.最多可借textBox.ReadOnly = false;
            if (Rtype == "学生") { this.最多可借textBox.Text = "25"; }
            else if (Rtype == "研究生") { this.最多可借textBox.Text = "60"; }
            else { this.最多可借textBox.Text = "100"; }
            this.最多可借textBox.ReadOnly = true;
            string sql2 = "SELECT 书名,ISBN,借书日期,应还日期 FROM Borrow_View WHERE 读者帐号='" + Raccount + "'";
            SqlHelper.ShowDataWithDataGirdView(当前借阅书单dataGridView, sql2);
            string sql3 = "SELECT 书名,ISBN,借书日期,应还日期 as 实际还书日期 FROM History_View WHERE 读者帐号='" + Raccount + "'";
            SqlHelper.ShowDataWithDataGirdView(个人借阅历史dataGridView, sql3);
  //-------------------------------------------------------------------------------------------------------------------------------求逾期图书数量和逾期图书总费用
            int i = 当前借阅书单dataGridView.Rows.Count - 1;
            this.已借textBox.ReadOnly = false;
            this.已借textBox.Text = Convert.ToString(i);
            this.已借textBox.ReadOnly = true;
            int num = 0;//逾期图书数量
            double cost = 0;//欠费
            if (i >= 1)
            {
                for (int j = 0; j < i; j++)
                {
                    DateTime t1 = Convert.ToDateTime(当前借阅书单dataGridView.Rows[j].Cells[3].Value.ToString());
                    DateTime t2 = DateTime.Now.ToLocalTime();
                    int m = DateTime.Compare(t2, t1);

                    if (m >= 0)
                    {
                        num++;
                        cost += ((t2 - t1).Days + 1) * 0.1;//每本书逾期一天扣1角，不足一天按一天计算
                    }
                }
                this.已逾期图书textBox.ReadOnly = false;
                this.已逾期图书textBox.Text = Convert.ToString(num);
                this.已逾期图书textBox.ReadOnly = true;
                this.欠费textBox.ReadOnly = false;
                this.欠费textBox.Text = Convert.ToString(cost + "(元)");
                this.欠费textBox.ReadOnly = true;
            }
            else
            {
                this.已逾期图书textBox.ReadOnly = false;
                this.已逾期图书textBox.Text = Convert.ToString(0);
                this.已逾期图书textBox.ReadOnly = true;
                this.欠费textBox.ReadOnly = false;
                this.欠费textBox.Text = Convert.ToString("0");
                this.欠费textBox.ReadOnly = true;
            }
        }

        private void 个人历史借阅书籍panel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
}