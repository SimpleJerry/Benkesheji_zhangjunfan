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
    public partial class 硕士专业目录Form : Form
    {
        private string Account;
        private string Name;
        private string UID;
        public 硕士专业目录Form(string Account, string Name)
        {
            InitializeComponent();
            this.Account = Account;
            this.Name = Name;
            this.UID = SqlHelper.InquireItem("用户表", "UID", string.Format("帐号='{0}'", Account));
            所在省市comboBox.Text = "--选择省市--";
            门类类别comboBox.Text = "--选择门类--";
            专业名称comboBox.Text = "--选择专业--";
            院校特性comboBox.Text = "--选择院校特性--";
            学科类别comboBox.Text = "--选择学科类别--";
            学习方式comboBox.Text = "--选择学习方式--";
            水印label.Text = "输入招生单位名称";
            政治comboBox.Text = "--政治--";
            外语comboBox.Text = "--外语--";
            业务课一comboBox.Text = "--业务课一--";
            业务课二comboBox.Text = "--业务课二--";
            //显示一定量信息
            SqlHelper.ShowDataWithDataGirdView(dataGridView1, "SELECT TOP (1000) * FROM 研招信息_所有");
        }

        private void 硕士专业目录Form_Load(object sender, EventArgs e)
        {
            SqlHelper.AddInComboBox(所在省市comboBox, "SELECT 省市选项 FROM 省市选项;");
            SqlHelper.AddInComboBox(门类类别comboBox, "SELECT DISTINCT 门类类别 FROM 门类学科专业选项 ORDER BY 门类类别;");
            SqlHelper.AddInComboBox(学科类别comboBox, "SELECT DISTINCT 学科类别 FROM 门类学科专业选项 ORDER BY 学科类别;");
            学科类别comboBox.Items.Remove("--选择专业领域--");
            SqlHelper.AddInComboBox(政治comboBox, "SELECT DISTINCT 政治 FROM 研招信息_所有 ORDER BY 政治;");
            SqlHelper.AddInComboBox(外语comboBox, "SELECT DISTINCT 外语 FROM 研招信息_所有 ORDER BY 外语;");
            SqlHelper.AddInComboBox(业务课一comboBox, "SELECT DISTINCT 业务课一 FROM 研招信息_所有 ORDER BY 业务课一; ");
            SqlHelper.AddInComboBox(业务课二comboBox, "SELECT DISTINCT 业务课二 FROM 研招信息_所有 ORDER BY 业务课二;");
        }

        private void 硕士专业目录Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
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

            string 学习方式 = "%";
            if (学习方式comboBox.Text == "全日制" || 学习方式comboBox.Text == "非全日制")
                学习方式 = 学习方式comboBox.Text;

            string 政治 = "%";
            if (政治comboBox.Text != "--政治--")
                政治 = 政治comboBox.Text;

            string 外语 = "%";
            if (外语comboBox.Text != "--外语--")
                外语 = 外语comboBox.Text;

            string 业务课一 = "%";
            if (业务课一comboBox.Text != "--业务课一--")
                业务课一 = 业务课一comboBox.Text;

            string 业务课二 = "%";
            if (业务课二comboBox.Text != "--业务课二--")
                业务课二 = 业务课二comboBox.Text;

            //门类类别 -> 学科类别 -> 专业名称
            //学科类别为必选项，可以进一步选定专业名称
            if (学科类别comboBox.Text != "--选择学科类别--" && 学科类别comboBox.Text != "--选择专业领域--")
            {
                string 专业代码 = Regex.Split(学科类别comboBox.Text, "[(,)]")[1];
                string sql = "";
                if (专业名称comboBox.Text != "--选择专业--")
                {
                    //1.限制搜索条件、专业代码有了才能搜索3.修改sql语句
                    sql = String.Format("SELECT * FROM 研招信息_所有 " +
                        "WHERE 专业名称 LIKE '%{0}' AND 招生单位 LIKE '%{1}%'  AND 学习方式 LIKE '{2}' AND 招生单位 IN(" +
                        " SELECT 院校名称 FROM 院校信息_所有 WHERE 所在地 LIKE '%{3}%' AND 院校特性 LIKE '%{4}%'" +
                        " AND 政治 LIKE '{5}' AND 外语 LIKE '{6}' AND 业务课一 LIKE '{7}' AND 业务课二 LIKE '{8}'); "
                        , 专业名称comboBox.Text, 招生单位textBox.Text, 学习方式, 所在地, 院校特性, 政治, 外语, 业务课一, 业务课二);
                }
                else
                {
                    sql = String.Format("SELECT * FROM 研招信息_所有 " +
                        "WHERE 专业代码 LIKE '{0}%' AND 招生单位 LIKE '%{1}%'  AND 学习方式 LIKE '{2}' AND 招生单位 IN(" +
                        " SELECT 院校名称 FROM 院校信息_所有 WHERE 所在地 LIKE '%{3}%' AND 院校特性 LIKE '%{4}%'" +
                        " AND 政治 LIKE '{5}' AND 外语 LIKE '{6}' AND 业务课一 LIKE '{7}' AND 业务课二 LIKE '{8}'); "
                        , 专业代码, 招生单位textBox.Text, 学习方式, 所在地, 院校特性, 政治, 外语, 业务课一, 业务课二);
                }
                SqlHelper.ShowDataWithDataGirdView(dataGridView1, sql);
            }
            else
            {
                MessageBox.Show("学科类别为必选项，其他至少填写一项。");
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

        private void 门类类别comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            学科类别comboBox.Items.Clear();
            if (门类类别comboBox.Text == "专业学位")
            {
                学科类别label.Text = "专业领域";
                学科类别comboBox.Items.Add("--选择专业领域--");
            }
            else
            {
                学科类别comboBox.Items.Add("--选择学科类别--");
            }
            学科类别comboBox.SelectedIndex = 0;
            SqlHelper.AddInComboBox(学科类别comboBox, string.Format("SELECT DISTINCT 学科类别 FROM 门类学科专业选项 WHERE 门类类别='{0}' ORDER BY 学科类别;", 门类类别comboBox.Text));
        }

        private void 学科类别comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            专业名称comboBox.Items.Clear();
            专业名称comboBox.Items.Add("--选择专业--");
            专业名称comboBox.SelectedIndex = 0;
            SqlHelper.AddInComboBox(专业名称comboBox, string.Format("SELECT DISTINCT 专业名称 FROM 门类学科专业选项 WHERE 门类类别='{0}' AND 学科类别='{1}' ORDER BY 专业名称;", 门类类别comboBox.Text, 学科类别comboBox.Text));

            政治comboBox.Items.Clear();
            外语comboBox.Items.Clear();
            业务课一comboBox.Items.Clear();
            业务课二comboBox.Items.Clear();
            政治comboBox.Items.Add("--政治--");
            外语comboBox.Items.Add("--外语--");
            业务课一comboBox.Items.Add("--业务课一--");
            业务课二comboBox.Items.Add("--业务课二--");
            政治comboBox.SelectedIndex = 0;
            外语comboBox.SelectedIndex = 0;
            业务课一comboBox.SelectedIndex = 0;
            业务课二comboBox.SelectedIndex = 0;
            if (学科类别comboBox.Text != "--选择学科类别--")
            {
                string 专业代码 = Regex.Split(学科类别comboBox.Text, "[(,)]")[1];
                SqlHelper.AddInComboBox(政治comboBox, string.Format("SELECT DISTINCT 政治 FROM 研招信息_所有 WHERE 专业代码='{0}' ORDER BY 政治;", 专业代码));
                SqlHelper.AddInComboBox(外语comboBox, string.Format("SELECT DISTINCT 外语 FROM 研招信息_所有 WHERE 专业代码='{0}' ORDER BY 外语;", 专业代码));
                SqlHelper.AddInComboBox(业务课一comboBox, string.Format("SELECT DISTINCT 业务课一 FROM 研招信息_所有 WHERE 专业代码='{0}' ORDER BY 业务课一;", 专业代码));
                SqlHelper.AddInComboBox(业务课二comboBox, string.Format("SELECT DISTINCT 业务课二 FROM 研招信息_所有 WHERE 专业代码='{0}' ORDER BY 业务课二;", 专业代码));
            }
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
                    SqlHelper.InsertItem("收藏表(ID,UID,收藏时间)", string.Format("('{0}','{1}','{2}')", ID, this.UID, date));
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