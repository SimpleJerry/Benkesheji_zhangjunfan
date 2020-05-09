namespace 二手书交易系统_课程设计
{
    partial class 管理员界面Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.状态栏statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.书目管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.订单管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.现存订单管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.历史订单管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.菜单栏menuStrip = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.状态栏statusStrip.SuspendLayout();
            this.菜单栏menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // 状态栏statusStrip
            // 
            this.状态栏statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.状态栏statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.状态栏statusStrip.Location = new System.Drawing.Point(0, 635);
            this.状态栏statusStrip.Name = "状态栏statusStrip";
            this.状态栏statusStrip.Size = new System.Drawing.Size(1258, 29);
            this.状态栏statusStrip.TabIndex = 2;
            this.状态栏statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(226, 24);
            this.toolStripStatusLabel1.Text = "欢迎登录二手书交易系统！";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(46, 24);
            this.toolStripStatusLabel2.Text = "身份";
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.信息设置ToolStripMenuItem,
            this.系统信息ToolStripMenuItem});
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.系统设置ToolStripMenuItem.Text = "系统设置";
            // 
            // 信息设置ToolStripMenuItem
            // 
            this.信息设置ToolStripMenuItem.Name = "信息设置ToolStripMenuItem";
            this.信息设置ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.信息设置ToolStripMenuItem.Text = "信息设置";
            this.信息设置ToolStripMenuItem.Click += new System.EventHandler(this.信息设置ToolStripMenuItem_Click);
            // 
            // 系统信息ToolStripMenuItem
            // 
            this.系统信息ToolStripMenuItem.Name = "系统信息ToolStripMenuItem";
            this.系统信息ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.系统信息ToolStripMenuItem.Text = "系统信息";
            this.系统信息ToolStripMenuItem.Click += new System.EventHandler(this.系统信息ToolStripMenuItem_Click);
            // 
            // 书目管理ToolStripMenuItem
            // 
            this.书目管理ToolStripMenuItem.Name = "书目管理ToolStripMenuItem";
            this.书目管理ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.书目管理ToolStripMenuItem.Text = "书目管理";
            this.书目管理ToolStripMenuItem.Click += new System.EventHandler(this.书目管理ToolStripMenuItem_Click);
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            this.用户管理ToolStripMenuItem.Click += new System.EventHandler(this.用户管理ToolStripMenuItem_Click);
            // 
            // 订单管理ToolStripMenuItem
            // 
            this.订单管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.现存订单管理ToolStripMenuItem,
            this.历史订单管理ToolStripMenuItem});
            this.订单管理ToolStripMenuItem.Name = "订单管理ToolStripMenuItem";
            this.订单管理ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.订单管理ToolStripMenuItem.Text = "订单管理";
            // 
            // 现存订单管理ToolStripMenuItem
            // 
            this.现存订单管理ToolStripMenuItem.Name = "现存订单管理ToolStripMenuItem";
            this.现存订单管理ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.现存订单管理ToolStripMenuItem.Text = "现存订单管理";
            this.现存订单管理ToolStripMenuItem.Click += new System.EventHandler(this.现存订单查询ToolStripMenuItem_Click);
            // 
            // 历史订单管理ToolStripMenuItem
            // 
            this.历史订单管理ToolStripMenuItem.Name = "历史订单管理ToolStripMenuItem";
            this.历史订单管理ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.历史订单管理ToolStripMenuItem.Text = "历史订单管理";
            this.历史订单管理ToolStripMenuItem.Click += new System.EventHandler(this.历史订单查询ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // 菜单栏menuStrip
            // 
            this.菜单栏menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.菜单栏menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统设置ToolStripMenuItem,
            this.书目管理ToolStripMenuItem,
            this.用户管理ToolStripMenuItem,
            this.订单管理ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.菜单栏menuStrip.Location = new System.Drawing.Point(0, 0);
            this.菜单栏menuStrip.Name = "菜单栏menuStrip";
            this.菜单栏menuStrip.Size = new System.Drawing.Size(1258, 32);
            this.菜单栏menuStrip.TabIndex = 1;
            this.菜单栏menuStrip.Text = "菜单栏menuStrip";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::二手书交易系统_课程设计.Properties.Resources.管理员界面;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 603);
            this.panel1.TabIndex = 5;
            // 
            // 管理员界面Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.状态栏statusStrip);
            this.Controls.Add(this.菜单栏menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "管理员界面Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员界面";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.管理员界面Form_KeyPress);
            this.状态栏statusStrip.ResumeLayout(false);
            this.状态栏statusStrip.PerformLayout();
            this.菜单栏menuStrip.ResumeLayout(false);
            this.菜单栏menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip 状态栏statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 书目管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 订单管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 现存订单管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 历史订单管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip 菜单栏menuStrip;
        private System.Windows.Forms.Panel panel1;
    }
}