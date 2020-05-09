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


namespace 研招信息查询系统
{
    public partial class 专业收藏Form : Form
    {
        private string Account;
        private string Name;
        private string UID;
        public 专业收藏Form(string Account, string Name)
        {
            InitializeComponent();
            this.Account = Account;
            this.Name = Name;
            this.UID = SqlHelper.InquireItem("用户表", "UID", string.Format("帐号='{0}'", Account));
        }

        private void 专业收藏Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
        }

        private void 返回button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 专业收藏Form_Load(object sender, EventArgs e)
        {
            用户label.Text = Name;
            SqlHelper.ShowDataWithDataGirdView(dataGridView1, string.Format("SELECT ID,招生单位,考试方式,院系所,专业代码,学习方式,研究方向,指导老师,专业名称,拟招人数,备注,政治,外语,业务课一,业务课二,收藏时间 FROM 收藏表视图 WHERE 帐号 = '{0}' ORDER BY 收藏时间 DESC", this.Account));
        }
        private void 移除研招信息button_Click(object sender, EventArgs e)
        {
            string ID = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID"].Value.ToString();
            SqlHelper.DeleteItem("收藏表", string.Format("ID = '{0}' AND UID='{1}'", ID, this.UID));
            专业收藏Form_Load(null, null);

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否取消此收藏？", " 确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
                移除研招信息button_Click(null, null);
        }
    }
}
