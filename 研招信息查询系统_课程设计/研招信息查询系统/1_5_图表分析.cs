using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 研招信息查询系统
{
    [System.Runtime.InteropServices.ComVisible(true)]
    public partial class 图表分析Form : Form
    {
        private string Account;
        private string Name;
        public static DirectoryInfo di = new DirectoryInfo(string.Format(@"{0}../../", Application.StartupPath));
        string str = di.FullName + "html";
        public 图表分析Form(string Account, string Name)
        {
            WebSetting.SetIE(WebSetting.IeVersion.强制ie10);
            InitializeComponent();
            this.Account = Account;
            this.Name = Name;
            this.initWebBrower();

        }

        private void 图表分析Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                return;
            }
        }
        private void initWebBrower()
        {
            
            //防止webbrowser控件打开拖放到他上面的文件
            图表显示webBrowser.AllowWebBrowserDrop = false;
            //防止web控件在用户右击他时显示其快捷菜单
            图表显示webBrowser.IsWebBrowserContextMenuEnabled = false;
            //防止web控件显示脚本代码问题的错误信息
            图表显示webBrowser.ScriptErrorsSuppressed = true;
            //通过这个属性，把winform中的变量传递到js中，供内嵌的网页使用；但设置到的类型必须是com可见，故设置system.runtime.interopservices.vomvisibleattribute(true)）
            图表显示webBrowser.ObjectForScripting = this;
        }
        private void 图表分析Form_Load(object sender, EventArgs e)
        {
        }

        private void 收藏夹1button1_Click(object sender, EventArgs e)
        {
            
            this.图表显示webBrowser.Url = new Uri(str + "\\favor1.html");
        }

        private void 收藏夹2button2_Click(object sender, EventArgs e)
        {
            string sqlstring = "select 专业代码 name ,dbo.major(专业代码) children "+
                                "from dbo.收藏表视图 "+
                                "group by 专业代码 "+
                                "for json auto";
            string sqlstring2 = "select * " +
                               "from dbo.收藏表视图 " +
                               "where 帐号='" + this.Account+
                               "' for json auto";
            string b = "data2";
            string JsonString = "{\"da\":";
            JsonString += SqlHelper.DataToString(sqlstring);
            JsonString += ",\"da2\":" + SqlHelper.DataToString(sqlstring2)+"}";
            SqlHelper.SaveFile(JsonString, b);
            this.图表显示webBrowser.Url = new Uri(str + "\\favor2.html");
        }

        private void 图表分析Form_Shown(object sender, EventArgs e)
        {
            System.Timers.Timer t = new System.Timers.Timer(10);
            t.Elapsed += new System.Timers.ElapsedEventHandler(LoadData); //到达时间的时候执行事件；   
            t.AutoReset = false;   //设置是执行一次（false）还是一直执行(true)；   
            t.Enabled = true;     //是否执行System.Timers.Timer.Elapsed事件；   

        }
        public void LoadData(object source, System.Timers.ElapsedEventArgs e)
        {
            string sqlstring = "select 所在地 name,count(所在地) value,dbo.gj(所在地) place,dbo.地区比例(所在地) ratio " +
                                "from 院校信息_所有 " +
                                "group by 所在地 " +
                                "for json path, root('da')";
            string b = "data1";
            string JsonString = SqlHelper.DataToString(sqlstring);
            SqlHelper.SaveFile(JsonString, b);
        }
    }
}
