using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;//正则表达式的类

namespace 研招信息查询系统
{
    public partial class 院校信息查询Form : Form
    {
        private string Account;
        private string Name;
        private string UID;
        public 院校信息查询Form(string Account, string Name)
        {
            InitializeComponent();
            this.Account = Account;
            this.Name = Name;
            this.UID = SqlHelper.InquireItem("用户表", "UID", string.Format("帐号='{0}'", Account));
            所在省市comboBox.Text = "--选择省市--";
            院校隶属comboBox.Text = "--选择隶属单位--";
            院校特性comboBox.Text = "--选择院校特性--";
            水印label.Text = "输入招生单位名称"; ;
            SqlHelper.ShowDataWithDataGirdView(dataGridView1, "SELECT * FROM 院校信息_所有;");

            foreach (DataGridViewColumn c in dataGridView1.Columns)
                c.ReadOnly = true;
            dataGridView1.Columns["url"].ReadOnly = false;
        }

        private void 院校信息查询Form_Load(object sender, EventArgs e)
        {
            SqlHelper.AddInComboBox(所在省市comboBox, "SELECT 省市选项 FROM 省市选项;");
        }
        private void 院校信息查询Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
        }
        private void 招生单位textBox_TextChanged(object sender, EventArgs e)
        {
            if (招生单位textBox.Text == "")
                水印label.Text = "输入招生单位名称";
            else
                水印label.Text = "";
        }

        private void 水印label_Click(object sender, EventArgs e)
        {
            水印label.Text = "";
        }

        private void 查询button_Click(object sender, EventArgs e)
        {
            string 所在地 = "";
            if (所在省市comboBox.Text != "--选择省市--")
            {
                所在地 = Regex.Split(所在省市comboBox.Text, "[)]")[1];
                所在地 = 所在地.Substring(0, 2);//提取前两个字符
            }
            if (所在地 == "黑龙")
                所在地 = "黑龙江";
            if (所在地 == "内蒙")
                所在地 = "内蒙古";

            string 院校特性 = "";
            if (院校特性comboBox.Text == "985" || 院校特性comboBox.Text == "211")
                院校特性 = 院校特性comboBox.Text;

            string sql = "";
            if (院校隶属comboBox.Text == "教育部")
                sql = string.Format("SELECT * FROM 院校信息_所有 WHERE 院校名称 LIKE '%{0}%' AND 所在地 LIKE '%{1}%' AND 院校隶属 = '教育部' AND 院校特性 LIKE '{2}%';", 招生单位textBox.Text, 所在地, 院校特性);
            else if (院校隶属comboBox.Text == "其他部委")
                sql = string.Format("SELECT * FROM 院校信息_所有 WHERE 院校名称 LIKE '%{0}%' AND 所在地 LIKE '%{1}%' AND 院校隶属 != '教育部' AND 院校特性 LIKE '{2}%';", 招生单位textBox.Text, 所在地, 院校特性);
            else//院校隶属comboBox.Text == "--选择隶属单位--"
                sql = string.Format("SELECT * FROM 院校信息_所有 WHERE 院校名称 LIKE '%{0}%' AND 所在地 LIKE '%{1}%' AND 院校特性 LIKE '{2}%';", 招生单位textBox.Text, 所在地, 院校特性);

            SqlHelper.ShowDataWithDataGirdView(dataGridView1, sql);
        }

        private void 添加到收藏button_Click(object sender, EventArgs e)
        {
            if (Account == "" && Name == "")
            {
                MessageBox.Show("您不是注册用户！");
            }
            else
            {
                DateTime date = System.DateTime.Today;  //时间
                string ID = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID"].Value.ToString();
                try
                {
                    SqlHelper.InsertItem("收藏表_院校(ID,UID,收藏时间)", string.Format("('{0}','{1}','{2}')", ID, this.UID, date));
                    MessageBox.Show("收藏成功");
                }
                catch
                {
                    MessageBox.Show("请勿重复收藏!", "错误");
                }
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            添加到收藏button_Click(null, null);
        }
    }
}
