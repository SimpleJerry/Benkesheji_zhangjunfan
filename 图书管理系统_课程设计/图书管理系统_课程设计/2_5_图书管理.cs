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
   
    public partial class 图书管理Form : Form
    {
        public string information="";//从父窗口传入的信息1
        public string book_name;//从父窗口传入的信息2
        public string book_author;//从父窗口传入的信息3


        public 图书管理Form()
        {
            InitializeComponent();
            库存编号textBox.ReadOnly = true;
            ISBN码textBox.ReadOnly = true;
            书名textBox.ReadOnly = true;
            作者textBox.ReadOnly = true;
            this.馆藏地址comboBox.Text = this.馆藏地址comboBox.Items[0].ToString();
        }
        
        public void 查询button_Click(object sender, EventArgs e)
        {
            if (information != "")//有信息从添加图书界面传入,即通过添加图书界面打开。
            {
                输入ISBN码textBox.Text = information;
                if (SqlHelper.SelectItem("Storage", "S_no", "B_ISBN", 输入ISBN码textBox.Text) != "Not Found!")//判断storage表里面有没有这个信息
                    SqlHelper.ShowDataWithDataGirdView(dataGridView1, String.Format("SELECT 库存编号,ISBN ISBN码, 书名,作者,馆藏地址,在馆状态 FROM Storage_View WHERE {0}='{1}'; ", "ISBN", 输入ISBN码textBox.Text));
                else//表示storage里面还没有这个书记的库存信息
                      {
                       ISBN码textBox.Text = information;
                       书名textBox.Text = book_name;
                       作者textBox.Text = book_author;
                       库存编号textBox.Text = "不用输入，会生成。";
                      }
            }
            else//无信息从添加图书界面传入,即直接打开图书管理界面。
            {
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, String.Format("SELECT 库存编号,ISBN ISBN码, 书名,作者,馆藏地址,在馆状态 FROM Storage_View WHERE {0}='{1}'; ", "ISBN", 输入ISBN码textBox.Text));

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection myrows = dataGridView1.SelectedRows;
            foreach (DataGridViewRow myrow in myrows)
            {
                this.库存编号textBox.Text = myrow.Cells[0].Value.ToString();
                this.ISBN码textBox.Text = myrow.Cells[1].Value.ToString();
                this.书名textBox.Text = myrow.Cells[2].Value.ToString();
                this.作者textBox.Text = myrow.Cells[3].Value.ToString();
                this.馆藏地址comboBox.Text = myrow.Cells[4].Value.ToString();
                this.在馆状态textBox.Text = myrow.Cells[5].Value.ToString();
            }
        }

        private void 添加button_Click(object sender, EventArgs e)
        {
            //String[]a = {"在馆"};//用数据源的方法设置只能选“在馆”
            //在馆状态textBox.DataSource = a;
            在馆状态textBox.Text = "在馆";

            ISBN码textBox.ReadOnly = true;
            书名textBox.ReadOnly = true;
            作者textBox.ReadOnly = true;
            库存编号textBox.Text = SqlHelper.SelectItem("Storage_View", "MAX(库存编号)+1", "在馆状态", "在馆");//得到一个库存编号


            if (库存编号textBox.Text == "" ||ISBN码textBox.Text==""|| 馆藏地址comboBox.Text == "" || 在馆状态textBox.Text == "")
            {
                MessageBox.Show("信息不完整！");
            }
            else if (SqlHelper.SelectItem("Storage", "S_no", "S_no", 库存编号textBox.Text) != "Not Found!")//解决了添加图书时的BUG
            {
                MessageBox.Show("插入书籍重复!");
            }
            else
                SqlHelper.InsertItem("Storage(S_no , B_ISBN , S_address , S_condition)", String.Format("('{0}','{1}','{2}','{3}');", 库存编号textBox.Text, ISBN码textBox.Text, 馆藏地址comboBox.Text, 在馆状态textBox.Text));
                //用新增的库存更新Bool_Info表中的B_Remain
                string str = SqlHelper.SelectItem("Storage", "COUNT(*)", "B_ISBN", ISBN码textBox.Text);
                SqlHelper.UpdatetItem("Book_Info", "B_Remain", str, "B_ISBN", ISBN码textBox.Text);
                查询button_Click(sender, e);
        }

        private void 更新button_Click(object sender, EventArgs e)
        {

            //在馆状态comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            //String[] a = { "在馆" ,"借出","挂失"};
            //在馆状态comboBox.DataSource = a;

            在馆状态textBox.Text = "在馆";

            if (馆藏地址comboBox.Text == "" || 在馆状态textBox.Text == "")
            {
                MessageBox.Show("信息不完整！");
            }
            else
            {
                //B_ISBN ISBN码, B_name 书名, B_author 作者,  B_pubcom 出版社,B_pubtime 出版时间, B_price 价格,B_remain 库存 
                int a1 = 0, a2 = 0;
                int all;
                a2 = SqlHelper.UpdatetItem1("Storage", "S_condition", 在馆状态textBox.Text, "S_no", 库存编号textBox.Text);
                a1 = SqlHelper.UpdatetItem1("Storage", "S_address", 馆藏地址comboBox.Text, "S_no", 库存编号textBox.Text);
               
                all = a1 + a2;

                if (all ==2)
                {
                    
                    查询button_Click(sender, e);
                }
                else
                    MessageBox.Show("信息更新失败！");
            }
        }

        private void 删除button_Click(object sender, EventArgs e)
        {

            if (在馆状态textBox.Text == "借出" || 在馆状态textBox.Text == "挂失")
            {
                MessageBox.Show("借出或者已挂失\n  暂不能删除！");
            }
            else
            {
                if (库存编号textBox.Text == "不用输入，会生成。" || SqlHelper.SelectItem("Storage", "S_no", "S_no", 库存编号textBox.Text) == "Not Found!")
                {
                    MessageBox.Show("请选择欲删除的书籍！");
                }
                else
                {
                SqlHelper.DeleteItem1("Storage", "S_no", 库存编号textBox.Text);
                //重新显示，清空dataGridView
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, String.Format("SELECT 库存编号,ISBN ISBN码, 书名,作者,馆藏地址,在馆状态 FROM Storage_View WHERE {0}='{1}'; ", "ISBN", 输入ISBN码textBox.Text));
                查询button_Click(sender, e);
                }
            }
        }

        private void 图书管理Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
        }
    }
}

