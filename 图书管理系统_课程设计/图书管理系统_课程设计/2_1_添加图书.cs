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

    public partial class 添加图书Form : Form
    {
        public 添加图书Form()
        {
            InitializeComponent();
        }

        private void 查询button_Click(object sender, EventArgs e)
        {
            if (查询textBox.Text == "(全部)" || 查询textBox.Text == "")
            {
                //判断查询框类关键字是否为默认的“（全部）”或者“”，如果是，则显示全部信息。
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, "SELECT B_ISBN ISBN码, B_name 书名, B_author 作者,  B_pubcom 出版社,B_pubtime 出版时间, B_price 价格 FROM Book_info; ");//去掉了库存 --,B_remain 库存--
            }
            else
            {
                //使用封装在SqlHelper类中ShowDataWithDataGirdView方法来显示数据，同时使用SQL语句实现模糊查询以及多类信息关键字查询。
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, String.Format("SELECT B_ISBN ISBN码, B_name 书名, B_author 作者,  B_pubcom 出版社,B_pubtime 出版时间, B_price 价格,B_remain 库存 FROM Book_info WHERE {0} LIKE '%{1}%' OR {2} LIKE '%{3}%'OR {4} LIKE '%{5}%'OR {6} LIKE '%{7}%' ; ", "B_ISBN", 查询textBox.Text, "B_name", 查询textBox.Text, "B_author", 查询textBox.Text, "B_pubcom", 查询textBox.Text));
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
                if (column is DataGridViewButtonColumn)//判断是不是点击了button的单元格
                {
                    图书管理Form f = new 图书管理Form();
                    DataGridViewSelectedRowCollection myrows = dataGridView1.SelectedRows;
                    foreach (DataGridViewRow myrow in myrows)
                    {
                        f.information = myrow.Cells[1].Value.ToString();//这三句将ISBN码传到子窗口-图书管理Form
                        f.book_name = myrow.Cells[2].Value.ToString();
                        f.book_author = myrow.Cells[3].Value.ToString();
                        //在单击“在馆信息”的时候提取数据库中的信息到textBox控件，由此判断库存是否为空
                        this.ISBN码textBox.Text = myrow.Cells[1].Value.ToString();
                        this.书名textBox.Text = myrow.Cells[2].Value.ToString();
                        this.作者textBox.Text = myrow.Cells[3].Value.ToString();
                        this.出版社textBox.Text = myrow.Cells[4].Value.ToString();
                        this.出版时间textBox.Text = myrow.Cells[5].Value.ToString();
                        this.价格textBox.Text = myrow.Cells[6].Value.ToString();
                        //计算某本书的库存量，并显示到数量文本框中。
                        string str = SqlHelper.SelectItem("Storage", "COUNT(*)", "B_ISBN", myrow.Cells[1].Value.ToString());
                        this.数量textBox.Text = str.ToString();
                    }
                    if (数量textBox.Text == "0")
                    {
                        DialogResult dr = MessageBox.Show("库存为空，是否添加？", " 添加库存信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                        if (dr == DialogResult.OK)//确认添加
                        {
                            f.查询button_Click(sender, e);
                            f.ShowDialog();
                        }
                        else//点击取消
                        {
                            return;
                        }
                    }
                    else
                    {
                        f.查询button_Click(sender, e);
                        f.ShowDialog();
                    }             
                }
                else
                {
                    DataGridViewSelectedRowCollection myrows = dataGridView1.SelectedRows;
                    foreach (DataGridViewRow myrow in myrows)
                    {
                        this.ISBN码textBox.Text = myrow.Cells[1].Value.ToString();
                        this.书名textBox.Text = myrow.Cells[2].Value.ToString();
                        this.作者textBox.Text = myrow.Cells[3].Value.ToString();
                        this.出版社textBox.Text = myrow.Cells[4].Value.ToString();
                        this.出版时间textBox.Text = myrow.Cells[5].Value.ToString();
                        this.价格textBox.Text = myrow.Cells[6].Value.ToString();
                       // this.数量textBox.Text = myrow.Cells[7].Value.ToString();
                       //将库存数量更正为count（B_ISBN）FROM Storage;
                        string str = SqlHelper.SelectItem("Storage", "COUNT(*)", "B_ISBN", myrow.Cells[1].Value.ToString());
                        this.数量textBox.Text =  str.ToString();
                       
                    }
                }
            }
        }

        private void 添加button_Click(object sender, EventArgs e)
        {
            if (ISBN码textBox.Text == "" || 书名textBox.Text == "" || 作者textBox.Text == "" || 出版社textBox.Text == "" || 出版时间textBox.Text == "" || 价格textBox.Text == "" )
            {
                //除数量文本框以外，若有文本框为空，则显示提示信息。信息不完整不能添加。
                MessageBox.Show("信息不完整！");
            }

            else if (SqlHelper.SelectItem("Book_info", "B_ISBN", "B_ISBN", ISBN码textBox.Text) != "Not Found!")//解决了添加图书时的BUG
            {
                //如果信息完整，再用SqlHelper中的SelectItem方法查询待插入书籍的ISBN码在数据库中是否已经存在，若返回值不为Not Found!则表示ISBN码重复，拒绝插入。
                MessageBox.Show("插入书籍重复!");
            }
            else
                SqlHelper.InsertItem("Book_info(B_ISBN , B_name , B_author ,  B_pubcom ,B_pubtime , B_price ,B_remain)", String.Format("('{0}','{1}','{2}','{3}','{4}','{5}',{6});", ISBN码textBox.Text, 书名textBox.Text, 作者textBox.Text, 出版社textBox.Text, 出版时间textBox.Text, 价格textBox.Text, "0"));
        }

        private void 更新button_Click(object sender, EventArgs e)
        {

            if (ISBN码textBox.Text == "" || 书名textBox.Text == "" || 作者textBox.Text == "" || 出版社textBox.Text == "" || 出版时间textBox.Text == "" || 价格textBox.Text == "" )
            {
                MessageBox.Show("信息不完整！");
            }
            else
            {
                //定义可表示插入情况的标识a1~a6
                int a1 = 0, a2 = 0, a3 = 0, a4 = 0, a5 = 0, a6 = 0;
                int all;
                //使用封装在SqlHelper中的UpdatetItem1方法进行更新信息操作，如果插入成功，返回1；不成功则返回0
                a1 = SqlHelper.UpdatetItem1("Book_info", "B_ISBN", ISBN码textBox.Text, "B_ISBN", ISBN码textBox.Text);
                a2 = SqlHelper.UpdatetItem1("Book_info", "B_name", 书名textBox.Text, "B_ISBN", ISBN码textBox.Text);
                a3 = SqlHelper.UpdatetItem1("Book_info", "B_author", 作者textBox.Text, "B_ISBN", ISBN码textBox.Text);
                a4 = SqlHelper.UpdatetItem1("Book_info", "B_pubcom", 出版社textBox.Text, "B_ISBN", ISBN码textBox.Text);
                a5 = SqlHelper.UpdatetItem1("Book_info", "B_pubtime", 出版时间textBox.Text, "B_ISBN", ISBN码textBox.Text);
                a6 = SqlHelper.UpdatetItem1("Book_info", "B_price", 价格textBox.Text, "B_ISBN", ISBN码textBox.Text);
                //用all反映各个更新操作的执行情况
                all = a1 + a2 + a3 + a4 + a5 + a6;
                
                if (all == 6)
                {
                    //如果每个更新操作都成功，则提示信息更新成功，并刷新信心显示框。
                    MessageBox.Show("信息更新成功");
                    查询button_Click(sender, e);
                }
                else
                    MessageBox.Show("信息更新失败！");
            }
        }

        private void 删除button_Click(object sender, EventArgs e)
        {
            //问题：在选中某本书，点击“删除”时，若这本书库存不为零，则会报错，程序运行终止。

            //之根据ISBN码判断是否删除
            //if (ISBN码textBox.Text == "" || 书名textBox.Text == "" || 作者textBox.Text == "" || 出版社textBox.Text == "" || 出版时间textBox.Text == "" || 价格textBox.Text == "" || 数量textBox.Text == "")
            if (ISBN码textBox.Text == "")
            {
                //排除因未输入信息而点击删除按钮引起的程序执行中断。
                MessageBox.Show("无可删除信息！");
            }
            else
            {
                //使用封装在SqlHelper中的SelectItem语句，查询欲删除的书目是否有库存，若无有库存则能直接删除；若还有库存则不能直接删除，要先去图书管理界面清空库存。
                if (SqlHelper.SelectItem("Storage", "COUNT(*)", "B_ISBN", ISBN码textBox.Text) != "0")//判断有没有库存
                    MessageBox.Show("请先清理库存！");
                else
                {
                    DialogResult dr = MessageBox.Show("确认删除？", " 删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dr == DialogResult.OK)//确认添加
                    {
                        SqlHelper.DeleteItem1("Book_info", "B_ISBN", ISBN码textBox.Text);
                        查询button_Click(sender, e);
                    }
                    else//点击取消
                    {
                        return;
                    }
                   
                }
            }
        }

        private void 清空button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否清空文本框", " 清空", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)//确认添加
            {
                ISBN码textBox.Text = "";
                书名textBox.Text = "";
                作者textBox.Text = "";
                出版社textBox.Text = "";
                出版时间textBox.Text = "";
                价格textBox.Text = "";
                数量textBox.Text = "";
            }
            else//点击取消
            {
                return;
            }
            
        }

        private void 添加图书Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
        }
    }
}
