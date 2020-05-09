namespace 图书管理系统_课程设计
{
    partial class 读者界面Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(读者界面Form));
            this.状态栏statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.菜单栏menuStrip = new System.Windows.Forms.MenuStrip();
            this.个人信息设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.在借图书查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.欢迎label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.状态栏statusStrip.Location = new System.Drawing.Point(0, 477);
            this.状态栏statusStrip.Name = "状态栏statusStrip";
            this.状态栏statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.状态栏statusStrip.Size = new System.Drawing.Size(913, 22);
            this.状态栏statusStrip.TabIndex = 10;
            this.状态栏statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(128, 17);
            this.toolStripStatusLabel1.Text = "欢迎登录图书管理系统";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel2.Text = "账户类型";
            // 
            // 菜单栏menuStrip
            // 
            this.菜单栏menuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.菜单栏menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.菜单栏menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个人信息设置ToolStripMenuItem,
            this.在借图书查询ToolStripMenuItem,
            this.图书查询ToolStripMenuItem});
            this.菜单栏menuStrip.Location = new System.Drawing.Point(0, 0);
            this.菜单栏menuStrip.Name = "菜单栏menuStrip";
            this.菜单栏menuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.菜单栏menuStrip.Size = new System.Drawing.Size(913, 28);
            this.菜单栏menuStrip.TabIndex = 11;
            this.菜单栏menuStrip.Text = "menuStrip1";
            // 
            // 个人信息设置ToolStripMenuItem
            // 
            this.个人信息设置ToolStripMenuItem.BackColor = System.Drawing.Color.SaddleBrown;
            this.个人信息设置ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.个人信息设置ToolStripMenuItem.Name = "个人信息设置ToolStripMenuItem";
            this.个人信息设置ToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.个人信息设置ToolStripMenuItem.Text = "个人信息设置";
            this.个人信息设置ToolStripMenuItem.Click += new System.EventHandler(this.个人信息设置ToolStripMenuItem_Click);
            // 
            // 在借图书查询ToolStripMenuItem
            // 
            this.在借图书查询ToolStripMenuItem.BackColor = System.Drawing.Color.Chocolate;
            this.在借图书查询ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.在借图书查询ToolStripMenuItem.Name = "在借图书查询ToolStripMenuItem";
            this.在借图书查询ToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.在借图书查询ToolStripMenuItem.Text = "个人借阅图书查询";
            this.在借图书查询ToolStripMenuItem.Click += new System.EventHandler(this.在借图书查询ToolStripMenuItem_Click);
            // 
            // 图书查询ToolStripMenuItem
            // 
            this.图书查询ToolStripMenuItem.BackColor = System.Drawing.Color.SaddleBrown;
            this.图书查询ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.图书查询ToolStripMenuItem.Name = "图书查询ToolStripMenuItem";
            this.图书查询ToolStripMenuItem.Size = new System.Drawing.Size(86, 26);
            this.图书查询ToolStripMenuItem.Text = "图书查询";
            this.图书查询ToolStripMenuItem.Click += new System.EventHandler(this.图书查询ToolStripMenuItem_Click);
            // 
            // 欢迎label
            // 
            this.欢迎label.AutoSize = true;
            this.欢迎label.BackColor = System.Drawing.Color.Transparent;
            this.欢迎label.Font = new System.Drawing.Font("华文新魏", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.欢迎label.ForeColor = System.Drawing.Color.Gray;
            this.欢迎label.Location = new System.Drawing.Point(565, 345);
            this.欢迎label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.欢迎label.Name = "欢迎label";
            this.欢迎label.Size = new System.Drawing.Size(137, 30);
            this.欢迎label.TabIndex = 12;
            this.欢迎label.Text = "欢迎进入";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文新魏", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(585, 405);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "波涛扬帆";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文新魏", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(583, 460);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "图书馆";
            // 
            // 读者界面Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(913, 499);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.欢迎label);
            this.Controls.Add(this.状态栏statusStrip);
            this.Controls.Add(this.菜单栏menuStrip);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.菜单栏menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.Name = "读者界面Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.读者界面Form_KeyPress);
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
        private System.Windows.Forms.MenuStrip 菜单栏menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 个人信息设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 在借图书查询ToolStripMenuItem;
        private System.Windows.Forms.Label 欢迎label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem 图书查询ToolStripMenuItem;
    }
}