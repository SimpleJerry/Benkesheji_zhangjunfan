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
    public partial class 图书借阅Form : Form
    {
        public 图书借阅Form()
        {
            InitializeComponent();
            this.选择查询条件comboBox.Text = this.选择查询条件comboBox.Items[0].ToString();
            this.选择查询条件comboBox.DropDownStyle = ComboBoxStyle.DropDownList; 
        }

        private void button2_Click(object sender, EventArgs e)//借书办理
        {
            if (书籍序列号textBox.Text.Trim() == string.Empty) { MessageBox.Show("请选择所要借阅的图书！提示！"); return; }
            int row = this.图书查询结果dataGridView.CurrentCell.RowIndex;
            String str1 = 图书查询结果dataGridView.Rows[row].Cells["ISBN"].Value.ToString();//索书号
            String str2 = 图书查询结果dataGridView.Rows[row].Cells["在馆状态"].Value.ToString();//在馆状态分为借出和在馆和挂失
            if (str2 =="借出") 
            {
                MessageBox.Show( "当前无库存，不能借览！");
            }
            else 
            {
                if (用户IDtextBox.Text.Trim() == string.Empty) { MessageBox.Show("请输入读者账号！提示！"); return; }
                else
                {
                        if (已逾期图书textBox.Text!= "0") { MessageBox.Show("该读者有逾期图书！不得借阅！"); return; }
                        if (馆藏状态textBox.Text != "在馆") { MessageBox.Show("该图书不在馆！不得借阅！"); return; }
      //--------------------------------------------------------------------------------------------------------------------------------查看黑名单里是否有该用户
                        string black = SqlHelper.SelectItem("BlackList", "帐号", "帐号", 用户账号textBox.Text.Trim());
                        if (black == 用户账号textBox.Text.Trim()) { MessageBox.Show("该读者已被拉入黑名单！不得借阅！"); return; }
     //---------------------------------------------------------------------------------------------------------------------------------判断是否同一本书被同一个人同一天借
                        SqlConnection MyConnection = SqlHelper.GetConn();
                        int sn=Convert.ToInt16(SqlHelper.SelectItem("Storage", "S_no", "B_ISBN", str1));
                        int rid =Convert.ToInt16(用户IDtextBox.Text);
                        string sql4 = "SELECT S_no FROM History WHERE  S_no=" + sn + " AND R_id=" + rid + " AND H_BorrowDate='"+DateTime.Now.ToLocalTime()+"'";
                        MyConnection.Open();
                        SqlCommand MyCommand4 = new SqlCommand(sql4, MyConnection);
                        MyCommand4.ExecuteNonQuery();
                        int synonym =Convert.ToInt16(MyCommand4.ExecuteScalar());
                        MyConnection.Close();
                        if (sn == synonym) { MessageBox.Show("该读者刚还此书！今日不得借阅！"); return;}
     //--------------------------------------------------------------------------------------------------------------------------------办理借书
                        DialogResult dr=MessageBox.Show("是否借阅？"," 确认提交",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);
                        if (dr == DialogResult.OK)
                        {
                                int i = Convert.ToInt16(用户IDtextBox.Text);//用户IP
                                //SqlConnection MyConnection = SqlHelper.GetConn();
                                string Bno = 关键字textBox.Text.Trim();
                                string sno = SqlHelper.SelectItem("Storage", "S_no", "B_ISBN", str1);
                                String sql = "Update Storage SET S_condition='借出' where S_no='" + sno + "'";
                                String sq2 = "INSERT INTO Borrow_List(S_no,R_id,B_borrowdate,B_returndate) VALUES (" + Convert.ToInt16(sno) + "," + i + ",'" + DateTime.Now.ToLocalTime() + "','" + (DateTime.Now.AddDays(Convert.ToInt16(最长借阅时间textBox.Text))).ToString() + "')";
                                String sq3 = "INSERT INTO History(S_no,R_id,H_BorrowDate,H_ReturnDate) VALUES (" + Convert.ToInt16(sno) + "," + i + ",'" + DateTime.Now.ToLocalTime() + "',NULL)";
                                MyConnection.Open();
                                SqlCommand MyCommand1 = new SqlCommand(sql, MyConnection);
                                MyCommand1.ExecuteNonQuery();
                                SqlCommand MyCommand2 = new SqlCommand(sq2, MyConnection);
                                MyCommand2.ExecuteNonQuery();
                                SqlCommand MyCommand3 = new SqlCommand(sq3, MyConnection);
                                MyCommand3.ExecuteNonQuery();
                                MyConnection.Close();
                                //this.馆藏状态textBox.ReadOnly = false;
                                //this.馆藏状态textBox.Text = "借出";
                                //this.馆藏状态textBox.ReadOnly = true;
                                MessageBox.Show("提交成功");
                                查询button1_Click(sender, e);
                                button1_Click(sender, e);
                        }
                        else { return; }
                }
            }
        }
        private void 查询button1_Click(object sender, EventArgs e)//查询图书
        {
            //-------------------------------------------------------------------------------------每一次书籍查询就会清空一下图书查询结果dataGridView
            this.馆藏状态textBox.ReadOnly = false;
            this.图书馆藏地址textBox.ReadOnly = false;
            this.作者textBox.ReadOnly = false;
            this.书名_借书textBox.ReadOnly = false;
            this.书籍序列号textBox.ReadOnly = false;
            this.书籍序列号textBox.Text = string.Empty;
            this.书名_借书textBox.Text = string.Empty;
            this.作者textBox.Text = string.Empty;
            this.图书馆藏地址textBox.Text = string.Empty;
            this.馆藏状态textBox.Text = string.Empty;
            this.最长借阅时间textBox.ReadOnly = true;
            this.馆藏状态textBox.ReadOnly = true;
            this.作者textBox.ReadOnly = true;
            this.书名_借书textBox.ReadOnly = true;
            this.书籍序列号textBox.ReadOnly = true;
            this.图书馆藏地址textBox.ReadOnly = true;
            this.最长借阅时间textBox.ReadOnly = false;
            this.最长借阅时间textBox.Text = string.Empty;
            this.最长借阅时间textBox.ReadOnly = true;
         //---------------------------------------------------------------------------------------------------------------判断书籍查询条件
             if (选择查询条件comboBox.Text == "查找所有书籍")
                 SqlHelper.ShowDataWithDataGirdView(图书查询结果dataGridView, "SELECT * FROM Storage_View;");
            else if (关键字textBox.Text == string.Empty)
            {
                MessageBox.Show("请输入您要查询的图书信息的关键字!");
            }
            else
            {
                if (选择查询条件comboBox.Text == "按书名查找")
                {
                    string Bname=Convert.ToString(关键字textBox.Text.Trim());
                    string sql = "SELECT * FROM Storage_View WHERE 书名 LIKE '%" + Bname + "%'";
                    SqlHelper.ShowDataWithDataGirdView(图书查询结果dataGridView, string.Format(sql));
                }
                else if (选择查询条件comboBox.Text == "按ISBN查找")
                {
                    string ISBN = Convert.ToString(关键字textBox.Text.Trim());
                    string sql = "SELECT * FROM Storage_View WHERE ISBN LIKE '%" + ISBN + "%'";
                    SqlHelper.ShowDataWithDataGirdView(图书查询结果dataGridView, string.Format(sql));
                }
                else if (选择查询条件comboBox.Text == "按作者查找")
                {
                    string au = Convert.ToString(关键字textBox.Text.Trim());
                    string sql = "SELECT * FROM Storage_View WHERE ISBN LIKE '%" + au + "%'";
                    SqlHelper.ShowDataWithDataGirdView(图书查询结果dataGridView, string.Format(sql));
                }
                else
                { MessageBox.Show("请正确选择匹配模式！", "错误！"); }
                    //图书查询结果dataGridView.ReadOnly = true;
            }
                  
        }
      
        private void button1_Click(object sender, EventArgs e)//用户查询
        {
            string Raccount =Convert.ToString(用户账号textBox.Text.Trim());
            string sql = string.Empty;
            sql += "SELECT * FROM Reader_View WHERE 帐号='" + Raccount + "'";
            if (用户账号textBox.Text == string.Empty)
            {
                MessageBox.Show("请输入您要查询的读者账号!");
            }
            else
            {
                SqlConnection conn = SqlHelper.GetConn();
                DataSet ds = new DataSet(); //创建数据集
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(sql, conn);
                da.Fill(ds);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.用户IDtextBox.ReadOnly = false;
                    this.用户名textBox.ReadOnly = false;
                    this.读者类型textBox.ReadOnly = false;
                    this.用户IDtextBox.Text = dr["读者编号"].ToString().Trim();
                    this.读者类型textBox.Text = dr["类型"].ToString().Trim();
                    this.用户名textBox.Text = dr["姓名"].ToString().Trim();
                    this.读者类型textBox.ReadOnly = true;
                    this.用户IDtextBox.ReadOnly = true;
                    this.用户名textBox.ReadOnly = true;
                    this.最多可借textBox.ReadOnly = false;
                    if (Convert.ToString(dr["类型"]) == "学生") { this.最多可借textBox.Text = "25"; }
                    else if (Convert.ToString(dr["类型"]) == "研究生" ) { this.最多可借textBox.Text = "60"; }
                    else { this.最多可借textBox.Text = "100"; }
                    this.最多可借textBox.ReadOnly = true;
                    conn.Close();
                    string sql2 = "SELECT 书名,ISBN,借书日期,应还日期 FROM Borrow_View WHERE 读者帐号='" + Raccount + "'";
                    SqlHelper.ShowDataWithDataGirdView(用户借书单dataGridView, sql2);
                    用户借书单dataGridView.ReadOnly = true;
        //------------------------------------------------------------------------------------------------------------------------读者图书逾期缴费计算，每本书逾期一天缴费0.1元
                    int i = 用户借书单dataGridView.Rows.Count - 1; 
                    this.已借textBox.ReadOnly = false;
                    this.已借textBox.Text = Convert.ToString(i);
                    this.已借textBox.ReadOnly = true;
                    int num = 0;//逾期图书数量
                    double cost = 0;//欠费
                    if (i >= 1)
                    {
                        for (int j = 0; j <i; j++)
                        {
                            DateTime t1 = Convert.ToDateTime(用户借书单dataGridView.Rows[j].Cells[3].Value.ToString());
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
                        this.欠费textBox.Text = Convert.ToString(cost+"(元)");
                        this.欠费textBox.ReadOnly = true;
                        if (num != 0) { MessageBox.Show("该读者有逾期图书！提示！"); }
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
                else { MessageBox.Show("读者不存在！"); }
            }

        }
        private void button2_Click_1(object sender, EventArgs e)//还书办理
        {
            if (用户IDtextBox.Text.Trim() == string.Empty) { MessageBox.Show("请输入读者账号！提示！"); }
            else if (书名_还书textBox.Text.Trim() == string.Empty) { MessageBox.Show("未选择所还书籍！提示！"); }
            else
            {
                if (欠费textBox.Text.Trim() != "0(元)")
                {
                    DialogResult dr = MessageBox.Show("请收费" + this.本书欠费textBox.Text + "！    确认收费后即提交还书信息", " 确认缴费", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dr == DialogResult.OK)
                    {
                        int row = this.用户借书单dataGridView.CurrentCell.RowIndex;
                        String str1 = 用户借书单dataGridView.Rows[row].Cells["ISBN"].Value.ToString();//索书号
                        SqlConnection MyConnection = SqlHelper.GetConn();
                        String sql = "Update Storage SET S_condition='在馆' where B_ISBN='" + str1 + "'";
                        int sno = Convert.ToInt32(SqlHelper.SelectItem("Storage", "S_no", "B_ISBN", str1));
                        String sq2 = "DELETE FROM Borrow_List WHERE  S_no=" + sno;
                        String sq3 = "UPDATE History SET H_ReturnDate='" + DateTime.Now.ToLocalTime() + "' WHERE H_ReturnDate IS NULL AND S_no=" + sno;
                        MyConnection.Open();
                        SqlCommand MyCommand1 = new SqlCommand(sql, MyConnection);
                        MyCommand1.ExecuteNonQuery();
                        SqlCommand MyCommand2 = new SqlCommand(sq2, MyConnection);
                        MyCommand2.ExecuteNonQuery();
                        SqlCommand MyCommand3 = new SqlCommand(sq3, MyConnection);
                        MyCommand3.ExecuteNonQuery();
                        MyConnection.Close();
                        MessageBox.Show("还书成功！");
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("是否确认还书？确认后即提交还书信息", " 确认缴费", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dr == DialogResult.OK)
                    {
                        int row = this.用户借书单dataGridView.CurrentCell.RowIndex;
                        String str1 = 用户借书单dataGridView.Rows[row].Cells["ISBN"].Value.ToString();//索书号
                        SqlConnection MyConnection = SqlHelper.GetConn();
                        String sql = "Update Storage SET S_condition='在馆' where B_ISBN='" + str1 + "'";
                        int sno = Convert.ToInt32(SqlHelper.SelectItem("Storage", "S_no", "B_ISBN", str1));
                        String sq2 = "DELETE FROM Borrow_List WHERE  S_no=" + sno;
                        String sq3 = "UPDATE History SET H_ReturnDate='" + DateTime.Now.ToLocalTime() + "' WHERE H_ReturnDate IS NULL AND S_no=" + sno;
                        MyConnection.Open();
                        SqlCommand MyCommand1 = new SqlCommand(sql, MyConnection);
                        MyCommand1.ExecuteNonQuery();
                        SqlCommand MyCommand2 = new SqlCommand(sq2, MyConnection);
                        MyCommand2.ExecuteNonQuery();
                        SqlCommand MyCommand3 = new SqlCommand(sq3, MyConnection);
                        MyCommand3.ExecuteNonQuery();
                        MyConnection.Close();
                        MessageBox.Show("还书成功！");
                    }
                    else
                    {
                        return;
                    }
                }
                button1_Click(sender, e);
                if (图书查询结果dataGridView.Rows.Count != 0)
                {
                    查询button1_Click(sender, e);
                }
                //-----------------------------------------------------------------------------------------每次还书成功后对所选书籍的信息进行清除
                this.本书欠费textBox.ReadOnly = false;
                this.本书欠费textBox.Text = string.Empty;
                this.本书欠费textBox.ReadOnly = true;
                this.书名_还书textBox.ReadOnly = false;
                this.借阅日期textBox.ReadOnly = false;
                this.还书日期textBox.ReadOnly = false;
                this.索书号textBox.ReadOnly = false;
                this.书名_还书textBox.Text = string.Empty;
                this.借阅日期textBox.Text = string.Empty;
                this.还书日期textBox.Text = string.Empty;
                this.索书号textBox.Text = string.Empty;
                this.书名_还书textBox.ReadOnly = true;
                this.借阅日期textBox.ReadOnly = true;
                this.还书日期textBox.ReadOnly = true;
                this.索书号textBox.ReadOnly = true;
            }

        }
        //----------------------------------------------------------------------------------------------------------------读者借书单dataGridView1
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = this.用户借书单dataGridView.CurrentCell.RowIndex;
            double cost = 0;//本书欠费
            DateTime t1 = Convert.ToDateTime(用户借书单dataGridView.Rows[a].Cells[3].Value.ToString());
            DateTime t2 = DateTime.Now.ToLocalTime();
            cost = ((t2 - t1).Days + 1) * 0.1;
            this.本书欠费textBox.ReadOnly = false;
            if (cost > 0)
            {
                this.本书欠费textBox.Text = Convert.ToString(cost) + "(元)";
            }
            else
                this.本书欠费textBox.Text ="0(元)";
            this.本书欠费textBox.ReadOnly = true;
               


            this.书名_还书textBox.ReadOnly = false;
            this.借阅日期textBox.ReadOnly = false;
            this.还书日期textBox.ReadOnly = false;
            this.索书号textBox.ReadOnly = false;
            this.书名_还书textBox.Text = 用户借书单dataGridView.Rows[a].Cells["书名"].Value.ToString();
            this.借阅日期textBox.Text = 用户借书单dataGridView.Rows[a].Cells["借书日期"].Value.ToString();
            this.还书日期textBox.Text = 用户借书单dataGridView.Rows[a].Cells["应还日期"].Value.ToString();
            this.索书号textBox.Text = 用户借书单dataGridView.Rows[a].Cells["ISBN"].Value.ToString();
            this.书名_还书textBox.ReadOnly = true;
            this.借阅日期textBox.ReadOnly = true;
            this.还书日期textBox.ReadOnly = true;
            this.索书号textBox.ReadOnly = true;

        }

        private void 书籍显示dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int a = this.图书查询结果dataGridView.CurrentCell.RowIndex;
            this.馆藏状态textBox.ReadOnly = false;
            this.图书馆藏地址textBox.ReadOnly = false;
            this.作者textBox.ReadOnly = false;
            this.书名_借书textBox.ReadOnly = false;
            this.书籍序列号textBox.ReadOnly = false;
            this.书籍序列号textBox.Text = 图书查询结果dataGridView.Rows[a].Cells["ISBN"].Value.ToString();
            this.书名_借书textBox.Text = 图书查询结果dataGridView.Rows[a].Cells["书名"].Value.ToString();
            this.作者textBox.Text = 图书查询结果dataGridView.Rows[a].Cells["作者"].Value.ToString();
            this.图书馆藏地址textBox.Text = 图书查询结果dataGridView.Rows[a].Cells["馆藏地址"].Value.ToString();
            this.馆藏状态textBox.Text = 图书查询结果dataGridView.Rows[a].Cells["在馆状态"].Value.ToString();
            this.最长借阅时间textBox.ReadOnly = true;
            this.馆藏状态textBox.ReadOnly = true;
            this.作者textBox.ReadOnly = true;
            this.书名_借书textBox.ReadOnly = true;
            this.书籍序列号textBox.ReadOnly = true;
            this.图书馆藏地址textBox.ReadOnly = true;

            this.最长借阅时间textBox.ReadOnly = false;
            if (this.读者类型textBox.Text == "学生")
            {
                this.最长借阅时间textBox.Text = "30";
            }
            else if (this.读者类型textBox.Text == "研究生")
            {
                this.最长借阅时间textBox.Text ="60";
            }
            else
            {
                this.最长借阅时间textBox.Text = "90";
            }
            this.最长借阅时间textBox.ReadOnly = true;
            
        }

        private void 图书借阅Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
        }
    }
}
