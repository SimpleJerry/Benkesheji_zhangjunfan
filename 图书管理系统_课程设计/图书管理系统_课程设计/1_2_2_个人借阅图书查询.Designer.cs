namespace 图书管理系统_课程设计
{
    partial class 个人借阅图书查询Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(个人借阅图书查询Form));
            this.当前借阅书单dataGridView = new System.Windows.Forms.DataGridView();
            this.菜单栏menuStrip = new System.Windows.Forms.MenuStrip();
            this.个人当前借阅图书查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人历史借阅图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.欠费textBox = new System.Windows.Forms.TextBox();
            this.欠费label = new System.Windows.Forms.Label();
            this.已到期图书_本label = new System.Windows.Forms.Label();
            this.已逾期图书textBox = new System.Windows.Forms.TextBox();
            this.已到期图书label = new System.Windows.Forms.Label();
            this.最多可借_本label = new System.Windows.Forms.Label();
            this.最多可借textBox = new System.Windows.Forms.TextBox();
            this.最多可借label = new System.Windows.Forms.Label();
            this.已借textBox = new System.Windows.Forms.TextBox();
            this.已借_本label = new System.Windows.Forms.Label();
            this.已借label = new System.Windows.Forms.Label();
            this.横线分割label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.本书欠费textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.索书号textBox = new System.Windows.Forms.TextBox();
            this.索书号label = new System.Windows.Forms.Label();
            this.还书日期label = new System.Windows.Forms.Label();
            this.还书日期textBox = new System.Windows.Forms.TextBox();
            this.借阅日期label = new System.Windows.Forms.Label();
            this.借阅日期textBox = new System.Windows.Forms.TextBox();
            this.书名_还书textBox = new System.Windows.Forms.TextBox();
            this.书名_还书label = new System.Windows.Forms.Label();
            this.用户借书单label = new System.Windows.Forms.Label();
            this.个人历史借阅书籍panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.用户账号label = new System.Windows.Forms.Label();
            this.个人借阅历史dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.当前借阅书单dataGridView)).BeginInit();
            this.菜单栏menuStrip.SuspendLayout();
            this.个人历史借阅书籍panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.个人借阅历史dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 当前借阅书单dataGridView
            // 
            this.当前借阅书单dataGridView.BackgroundColor = System.Drawing.Color.Khaki;
            this.当前借阅书单dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.当前借阅书单dataGridView.Location = new System.Drawing.Point(85, 243);
            this.当前借阅书单dataGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.当前借阅书单dataGridView.Name = "当前借阅书单dataGridView";
            this.当前借阅书单dataGridView.ReadOnly = true;
            this.当前借阅书单dataGridView.RowTemplate.Height = 27;
            this.当前借阅书单dataGridView.Size = new System.Drawing.Size(444, 260);
            this.当前借阅书单dataGridView.TabIndex = 0;
            this.当前借阅书单dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.当前借阅书单dataGridView_CellContentClick);
            // 
            // 菜单栏menuStrip
            // 
            this.菜单栏menuStrip.BackColor = System.Drawing.Color.DarkKhaki;
            this.菜单栏menuStrip.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.菜单栏menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个人当前借阅图书查询ToolStripMenuItem,
            this.个人历史借阅图书ToolStripMenuItem});
            this.菜单栏menuStrip.Location = new System.Drawing.Point(0, 0);
            this.菜单栏menuStrip.Name = "菜单栏menuStrip";
            this.菜单栏menuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.菜单栏menuStrip.Size = new System.Drawing.Size(708, 26);
            this.菜单栏menuStrip.TabIndex = 12;
            this.菜单栏menuStrip.Text = "menuStrip1";
            // 
            // 个人当前借阅图书查询ToolStripMenuItem
            // 
            this.个人当前借阅图书查询ToolStripMenuItem.BackColor = System.Drawing.Color.RosyBrown;
            this.个人当前借阅图书查询ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.个人当前借阅图书查询ToolStripMenuItem.Name = "个人当前借阅图书查询ToolStripMenuItem";
            this.个人当前借阅图书查询ToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.个人当前借阅图书查询ToolStripMenuItem.Text = "个人当前借阅图书";
            this.个人当前借阅图书查询ToolStripMenuItem.Click += new System.EventHandler(this.个人当前借阅图书查询ToolStripMenuItem_Click);
            // 
            // 个人历史借阅图书ToolStripMenuItem
            // 
            this.个人历史借阅图书ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.个人历史借阅图书ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.个人历史借阅图书ToolStripMenuItem.Name = "个人历史借阅图书ToolStripMenuItem";
            this.个人历史借阅图书ToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.个人历史借阅图书ToolStripMenuItem.Text = "个人历史借阅图书";
            this.个人历史借阅图书ToolStripMenuItem.Click += new System.EventHandler(this.历史借阅图书ToolStripMenuItem_Click);
            // 
            // 欠费textBox
            // 
            this.欠费textBox.BackColor = System.Drawing.Color.LightCoral;
            this.欠费textBox.Location = new System.Drawing.Point(616, 47);
            this.欠费textBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.欠费textBox.Name = "欠费textBox";
            this.欠费textBox.ReadOnly = true;
            this.欠费textBox.Size = new System.Drawing.Size(76, 21);
            this.欠费textBox.TabIndex = 85;
            // 
            // 欠费label
            // 
            this.欠费label.AutoSize = true;
            this.欠费label.BackColor = System.Drawing.Color.Transparent;
            this.欠费label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.欠费label.ForeColor = System.Drawing.Color.Black;
            this.欠费label.Location = new System.Drawing.Point(558, 52);
            this.欠费label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.欠费label.Name = "欠费label";
            this.欠费label.Size = new System.Drawing.Size(57, 12);
            this.欠费label.TabIndex = 84;
            this.欠费label.Text = "总欠费：";
            // 
            // 已到期图书_本label
            // 
            this.已到期图书_本label.AutoSize = true;
            this.已到期图书_本label.BackColor = System.Drawing.Color.Transparent;
            this.已到期图书_本label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.已到期图书_本label.ForeColor = System.Drawing.Color.Black;
            this.已到期图书_本label.Location = new System.Drawing.Point(516, 52);
            this.已到期图书_本label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.已到期图书_本label.Name = "已到期图书_本label";
            this.已到期图书_本label.Size = new System.Drawing.Size(18, 12);
            this.已到期图书_本label.TabIndex = 83;
            this.已到期图书_本label.Text = "本";
            // 
            // 已逾期图书textBox
            // 
            this.已逾期图书textBox.BackColor = System.Drawing.Color.LightCoral;
            this.已逾期图书textBox.Location = new System.Drawing.Point(475, 44);
            this.已逾期图书textBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.已逾期图书textBox.Name = "已逾期图书textBox";
            this.已逾期图书textBox.ReadOnly = true;
            this.已逾期图书textBox.Size = new System.Drawing.Size(30, 21);
            this.已逾期图书textBox.TabIndex = 82;
            // 
            // 已到期图书label
            // 
            this.已到期图书label.AutoSize = true;
            this.已到期图书label.BackColor = System.Drawing.Color.Transparent;
            this.已到期图书label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.已到期图书label.ForeColor = System.Drawing.Color.Black;
            this.已到期图书label.Location = new System.Drawing.Point(397, 52);
            this.已到期图书label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.已到期图书label.Name = "已到期图书label";
            this.已到期图书label.Size = new System.Drawing.Size(83, 12);
            this.已到期图书label.TabIndex = 81;
            this.已到期图书label.Text = "逾期图书数：";
            // 
            // 最多可借_本label
            // 
            this.最多可借_本label.AutoSize = true;
            this.最多可借_本label.BackColor = System.Drawing.Color.Transparent;
            this.最多可借_本label.ForeColor = System.Drawing.Color.Black;
            this.最多可借_本label.Location = new System.Drawing.Point(365, 55);
            this.最多可借_本label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.最多可借_本label.Name = "最多可借_本label";
            this.最多可借_本label.Size = new System.Drawing.Size(17, 12);
            this.最多可借_本label.TabIndex = 80;
            this.最多可借_本label.Text = "本";
            // 
            // 最多可借textBox
            // 
            this.最多可借textBox.Location = new System.Drawing.Point(275, 47);
            this.最多可借textBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.最多可借textBox.Name = "最多可借textBox";
            this.最多可借textBox.ReadOnly = true;
            this.最多可借textBox.Size = new System.Drawing.Size(87, 21);
            this.最多可借textBox.TabIndex = 79;
            // 
            // 最多可借label
            // 
            this.最多可借label.AutoSize = true;
            this.最多可借label.BackColor = System.Drawing.Color.Transparent;
            this.最多可借label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.最多可借label.ForeColor = System.Drawing.Color.Black;
            this.最多可借label.Location = new System.Drawing.Point(213, 52);
            this.最多可借label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.最多可借label.Name = "最多可借label";
            this.最多可借label.Size = new System.Drawing.Size(70, 12);
            this.最多可借label.TabIndex = 78;
            this.最多可借label.Text = "最多可借：";
            // 
            // 已借textBox
            // 
            this.已借textBox.Location = new System.Drawing.Point(83, 47);
            this.已借textBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.已借textBox.Name = "已借textBox";
            this.已借textBox.ReadOnly = true;
            this.已借textBox.Size = new System.Drawing.Size(81, 21);
            this.已借textBox.TabIndex = 77;
            // 
            // 已借_本label
            // 
            this.已借_本label.AutoSize = true;
            this.已借_本label.BackColor = System.Drawing.Color.Transparent;
            this.已借_本label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.已借_本label.ForeColor = System.Drawing.Color.Black;
            this.已借_本label.Location = new System.Drawing.Point(175, 55);
            this.已借_本label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.已借_本label.Name = "已借_本label";
            this.已借_本label.Size = new System.Drawing.Size(18, 12);
            this.已借_本label.TabIndex = 76;
            this.已借_本label.Text = "本";
            // 
            // 已借label
            // 
            this.已借label.AutoSize = true;
            this.已借label.BackColor = System.Drawing.Color.Transparent;
            this.已借label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.已借label.ForeColor = System.Drawing.Color.Black;
            this.已借label.Location = new System.Drawing.Point(37, 55);
            this.已借label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.已借label.Name = "已借label";
            this.已借label.Size = new System.Drawing.Size(44, 12);
            this.已借label.TabIndex = 75;
            this.已借label.Text = "已借：";
            // 
            // 横线分割label
            // 
            this.横线分割label.BackColor = System.Drawing.Color.Black;
            this.横线分割label.Location = new System.Drawing.Point(6, 31);
            this.横线分割label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.横线分割label.Name = "横线分割label";
            this.横线分割label.Size = new System.Drawing.Size(675, 1);
            this.横线分割label.TabIndex = 86;
            this.横线分割label.Text = "|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||" +
    "||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||" +
    "||||||||||||||||||||||||||||||||、";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 1);
            this.label1.TabIndex = 87;
            this.label1.Text = "|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||" +
    "||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||" +
    "||||||||||||||||||||||||||||||||、";
            // 
            // 本书欠费textBox
            // 
            this.本书欠费textBox.BackColor = System.Drawing.Color.LightCoral;
            this.本书欠费textBox.Location = new System.Drawing.Point(367, 103);
            this.本书欠费textBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.本书欠费textBox.Name = "本书欠费textBox";
            this.本书欠费textBox.Size = new System.Drawing.Size(45, 21);
            this.本书欠费textBox.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(297, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 12);
            this.label2.TabIndex = 96;
            this.label2.Text = "本书欠费：";
            // 
            // 索书号textBox
            // 
            this.索书号textBox.Location = new System.Drawing.Point(85, 147);
            this.索书号textBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.索书号textBox.Name = "索书号textBox";
            this.索书号textBox.ReadOnly = true;
            this.索书号textBox.Size = new System.Drawing.Size(201, 21);
            this.索书号textBox.TabIndex = 95;
            // 
            // 索书号label
            // 
            this.索书号label.AutoSize = true;
            this.索书号label.BackColor = System.Drawing.Color.Transparent;
            this.索书号label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.索书号label.ForeColor = System.Drawing.Color.Black;
            this.索书号label.Location = new System.Drawing.Point(31, 155);
            this.索书号label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.索书号label.Name = "索书号label";
            this.索书号label.Size = new System.Drawing.Size(57, 12);
            this.索书号label.TabIndex = 94;
            this.索书号label.Text = "索书号：";
            // 
            // 还书日期label
            // 
            this.还书日期label.AutoSize = true;
            this.还书日期label.BackColor = System.Drawing.Color.Transparent;
            this.还书日期label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.还书日期label.ForeColor = System.Drawing.Color.Black;
            this.还书日期label.Location = new System.Drawing.Point(205, 189);
            this.还书日期label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.还书日期label.Name = "还书日期label";
            this.还书日期label.Size = new System.Drawing.Size(70, 12);
            this.还书日期label.TabIndex = 93;
            this.还书日期label.Text = "还书日期：";
            // 
            // 还书日期textBox
            // 
            this.还书日期textBox.Location = new System.Drawing.Point(275, 181);
            this.还书日期textBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.还书日期textBox.Name = "还书日期textBox";
            this.还书日期textBox.ReadOnly = true;
            this.还书日期textBox.Size = new System.Drawing.Size(113, 21);
            this.还书日期textBox.TabIndex = 92;
            // 
            // 借阅日期label
            // 
            this.借阅日期label.AutoSize = true;
            this.借阅日期label.BackColor = System.Drawing.Color.Transparent;
            this.借阅日期label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.借阅日期label.ForeColor = System.Drawing.Color.Black;
            this.借阅日期label.Location = new System.Drawing.Point(13, 189);
            this.借阅日期label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.借阅日期label.Name = "借阅日期label";
            this.借阅日期label.Size = new System.Drawing.Size(70, 12);
            this.借阅日期label.TabIndex = 91;
            this.借阅日期label.Text = "借阅日期：";
            // 
            // 借阅日期textBox
            // 
            this.借阅日期textBox.Location = new System.Drawing.Point(83, 181);
            this.借阅日期textBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.借阅日期textBox.Name = "借阅日期textBox";
            this.借阅日期textBox.ReadOnly = true;
            this.借阅日期textBox.Size = new System.Drawing.Size(113, 21);
            this.借阅日期textBox.TabIndex = 90;
            // 
            // 书名_还书textBox
            // 
            this.书名_还书textBox.Location = new System.Drawing.Point(85, 103);
            this.书名_还书textBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.书名_还书textBox.Name = "书名_还书textBox";
            this.书名_还书textBox.ReadOnly = true;
            this.书名_还书textBox.Size = new System.Drawing.Size(201, 21);
            this.书名_还书textBox.TabIndex = 89;
            // 
            // 书名_还书label
            // 
            this.书名_还书label.AutoSize = true;
            this.书名_还书label.BackColor = System.Drawing.Color.Transparent;
            this.书名_还书label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.书名_还书label.ForeColor = System.Drawing.Color.Black;
            this.书名_还书label.Location = new System.Drawing.Point(42, 111);
            this.书名_还书label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.书名_还书label.Name = "书名_还书label";
            this.书名_还书label.Size = new System.Drawing.Size(44, 12);
            this.书名_还书label.TabIndex = 88;
            this.书名_还书label.Text = "书名：";
            // 
            // 用户借书单label
            // 
            this.用户借书单label.AutoSize = true;
            this.用户借书单label.BackColor = System.Drawing.Color.Transparent;
            this.用户借书单label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.用户借书单label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.用户借书单label.Location = new System.Drawing.Point(13, 229);
            this.用户借书单label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.用户借书单label.Name = "用户借书单label";
            this.用户借书单label.Size = new System.Drawing.Size(83, 12);
            this.用户借书单label.TabIndex = 98;
            this.用户借书单label.Text = "我的借书单：";
            // 
            // 个人历史借阅书籍panel
            // 
            this.个人历史借阅书籍panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("个人历史借阅书籍panel.BackgroundImage")));
            this.个人历史借阅书籍panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.个人历史借阅书籍panel.Controls.Add(this.label3);
            this.个人历史借阅书籍panel.Controls.Add(this.用户账号label);
            this.个人历史借阅书籍panel.Controls.Add(this.个人借阅历史dataGridView);
            this.个人历史借阅书籍panel.Location = new System.Drawing.Point(0, 27);
            this.个人历史借阅书籍panel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.个人历史借阅书籍panel.Name = "个人历史借阅书籍panel";
            this.个人历史借阅书籍panel.Size = new System.Drawing.Size(708, 489);
            this.个人历史借阅书籍panel.TabIndex = 99;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(96, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(513, 60);
            this.label3.TabIndex = 29;
            this.label3.Text = "好书如友，散发着岁月的芬芳，读着读着，醉了心房。\r\n每字每句，镌刻着友情的清香，品着品着，填满心扉。\r\n愿你与书为伴，继续幸福翱翔！";
            // 
            // 用户账号label
            // 
            this.用户账号label.AutoSize = true;
            this.用户账号label.BackColor = System.Drawing.Color.Transparent;
            this.用户账号label.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.用户账号label.ForeColor = System.Drawing.Color.Black;
            this.用户账号label.Location = new System.Drawing.Point(13, 121);
            this.用户账号label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.用户账号label.Name = "用户账号label";
            this.用户账号label.Size = new System.Drawing.Size(119, 15);
            this.用户账号label.TabIndex = 28;
            this.用户账号label.Text = "您的读书点滴：";
            // 
            // 个人借阅历史dataGridView
            // 
            this.个人借阅历史dataGridView.BackgroundColor = System.Drawing.Color.Olive;
            this.个人借阅历史dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.个人借阅历史dataGridView.Location = new System.Drawing.Point(138, 111);
            this.个人借阅历史dataGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.个人借阅历史dataGridView.Name = "个人借阅历史dataGridView";
            this.个人借阅历史dataGridView.ReadOnly = true;
            this.个人借阅历史dataGridView.RowTemplate.Height = 27;
            this.个人借阅历史dataGridView.Size = new System.Drawing.Size(475, 367);
            this.个人借阅历史dataGridView.TabIndex = 0;
            // 
            // 个人借阅图书查询Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(708, 499);
            this.Controls.Add(this.个人历史借阅书籍panel);
            this.Controls.Add(this.用户借书单label);
            this.Controls.Add(this.本书欠费textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.索书号textBox);
            this.Controls.Add(this.索书号label);
            this.Controls.Add(this.还书日期label);
            this.Controls.Add(this.还书日期textBox);
            this.Controls.Add(this.借阅日期label);
            this.Controls.Add(this.借阅日期textBox);
            this.Controls.Add(this.书名_还书textBox);
            this.Controls.Add(this.书名_还书label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.横线分割label);
            this.Controls.Add(this.欠费textBox);
            this.Controls.Add(this.欠费label);
            this.Controls.Add(this.已到期图书_本label);
            this.Controls.Add(this.已逾期图书textBox);
            this.Controls.Add(this.已到期图书label);
            this.Controls.Add(this.最多可借_本label);
            this.Controls.Add(this.最多可借textBox);
            this.Controls.Add(this.最多可借label);
            this.Controls.Add(this.已借textBox);
            this.Controls.Add(this.已借_本label);
            this.Controls.Add(this.已借label);
            this.Controls.Add(this.菜单栏menuStrip);
            this.Controls.Add(this.当前借阅书单dataGridView);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MinimizeBox = false;
            this.Name = "个人借阅图书查询Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "个人借阅图书查询";
            this.Load += new System.EventHandler(this.个人借阅图书查询Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.当前借阅书单dataGridView)).EndInit();
            this.菜单栏menuStrip.ResumeLayout(false);
            this.菜单栏menuStrip.PerformLayout();
            this.个人历史借阅书籍panel.ResumeLayout(false);
            this.个人历史借阅书籍panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.个人借阅历史dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView 当前借阅书单dataGridView;
        private System.Windows.Forms.MenuStrip 菜单栏menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 个人当前借阅图书查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人历史借阅图书ToolStripMenuItem;
        private System.Windows.Forms.TextBox 欠费textBox;
        private System.Windows.Forms.Label 欠费label;
        private System.Windows.Forms.Label 已到期图书_本label;
        private System.Windows.Forms.TextBox 已逾期图书textBox;
        private System.Windows.Forms.Label 已到期图书label;
        private System.Windows.Forms.Label 最多可借_本label;
        private System.Windows.Forms.TextBox 最多可借textBox;
        private System.Windows.Forms.Label 最多可借label;
        private System.Windows.Forms.TextBox 已借textBox;
        private System.Windows.Forms.Label 已借_本label;
        private System.Windows.Forms.Label 已借label;
        private System.Windows.Forms.Label 横线分割label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox 本书欠费textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox 索书号textBox;
        private System.Windows.Forms.Label 索书号label;
        private System.Windows.Forms.Label 还书日期label;
        private System.Windows.Forms.TextBox 还书日期textBox;
        private System.Windows.Forms.Label 借阅日期label;
        private System.Windows.Forms.TextBox 借阅日期textBox;
        private System.Windows.Forms.TextBox 书名_还书textBox;
        private System.Windows.Forms.Label 书名_还书label;
        private System.Windows.Forms.Label 用户借书单label;
        private System.Windows.Forms.Panel 个人历史借阅书籍panel;
        private System.Windows.Forms.DataGridView 个人借阅历史dataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label 用户账号label;
    }
}