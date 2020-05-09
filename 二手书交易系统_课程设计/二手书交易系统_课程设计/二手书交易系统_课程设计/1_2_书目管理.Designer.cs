namespace 二手书交易系统_课程设计
{
    partial class 书目管理Form
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
            this.清空button = new System.Windows.Forms.Button();
            this.禁止交易button = new System.Windows.Forms.Button();
            this.更新button = new System.Windows.Forms.Button();
            this.添加button = new System.Windows.Forms.Button();
            this.数量label = new System.Windows.Forms.Label();
            this.价格label = new System.Windows.Forms.Label();
            this.出版时间label = new System.Windows.Forms.Label();
            this.出版社label = new System.Windows.Forms.Label();
            this.作者label = new System.Windows.Forms.Label();
            this.书名label = new System.Windows.Forms.Label();
            this.ISBN码label = new System.Windows.Forms.Label();
            this.允许交易textBox = new System.Windows.Forms.TextBox();
            this.价格textBox = new System.Windows.Forms.TextBox();
            this.出版社textBox = new System.Windows.Forms.TextBox();
            this.作者textBox = new System.Windows.Forms.TextBox();
            this.书名textBox = new System.Windows.Forms.TextBox();
            this.ISBN码textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.查询textBox = new System.Windows.Forms.TextBox();
            this.查询button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.年comboBox = new System.Windows.Forms.ComboBox();
            this.月comboBox = new System.Windows.Forms.ComboBox();
            this.日comboBox = new System.Windows.Forms.ComboBox();
            this.允许交易button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 清空button
            // 
            this.清空button.BackColor = System.Drawing.Color.MistyRose;
            this.清空button.Location = new System.Drawing.Point(404, 272);
            this.清空button.Margin = new System.Windows.Forms.Padding(4);
            this.清空button.Name = "清空button";
            this.清空button.Size = new System.Drawing.Size(112, 34);
            this.清空button.TabIndex = 85;
            this.清空button.Text = "清空";
            this.清空button.UseVisualStyleBackColor = false;
            this.清空button.Click += new System.EventHandler(this.清空button_Click);
            // 
            // 禁止交易button
            // 
            this.禁止交易button.BackColor = System.Drawing.Color.MistyRose;
            this.禁止交易button.Location = new System.Drawing.Point(54, 272);
            this.禁止交易button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.禁止交易button.Name = "禁止交易button";
            this.禁止交易button.Size = new System.Drawing.Size(112, 33);
            this.禁止交易button.TabIndex = 84;
            this.禁止交易button.Text = "禁止交易";
            this.禁止交易button.UseVisualStyleBackColor = false;
            this.禁止交易button.Click += new System.EventHandler(this.禁止交易button_Click);
            // 
            // 更新button
            // 
            this.更新button.BackColor = System.Drawing.Color.MistyRose;
            this.更新button.Location = new System.Drawing.Point(234, 195);
            this.更新button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.更新button.Name = "更新button";
            this.更新button.Size = new System.Drawing.Size(112, 33);
            this.更新button.TabIndex = 83;
            this.更新button.Text = "更新";
            this.更新button.UseVisualStyleBackColor = false;
            this.更新button.Click += new System.EventHandler(this.更新button_Click);
            // 
            // 添加button
            // 
            this.添加button.BackColor = System.Drawing.Color.MistyRose;
            this.添加button.ForeColor = System.Drawing.Color.Black;
            this.添加button.Location = new System.Drawing.Point(54, 195);
            this.添加button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.添加button.Name = "添加button";
            this.添加button.Size = new System.Drawing.Size(112, 33);
            this.添加button.TabIndex = 82;
            this.添加button.Text = "添加";
            this.添加button.UseVisualStyleBackColor = false;
            this.添加button.Click += new System.EventHandler(this.添加button_Click);
            // 
            // 数量label
            // 
            this.数量label.AutoSize = true;
            this.数量label.BackColor = System.Drawing.Color.Transparent;
            this.数量label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.数量label.ForeColor = System.Drawing.Color.Black;
            this.数量label.Location = new System.Drawing.Point(630, 195);
            this.数量label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.数量label.Name = "数量label";
            this.数量label.Size = new System.Drawing.Size(84, 18);
            this.数量label.TabIndex = 81;
            this.数量label.Text = "允许交易";
            // 
            // 价格label
            // 
            this.价格label.AutoSize = true;
            this.价格label.BackColor = System.Drawing.Color.Transparent;
            this.价格label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.价格label.ForeColor = System.Drawing.Color.Black;
            this.价格label.Location = new System.Drawing.Point(630, 119);
            this.价格label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.价格label.Name = "价格label";
            this.价格label.Size = new System.Drawing.Size(46, 18);
            this.价格label.TabIndex = 80;
            this.价格label.Text = "价格";
            // 
            // 出版时间label
            // 
            this.出版时间label.AutoSize = true;
            this.出版时间label.BackColor = System.Drawing.Color.Transparent;
            this.出版时间label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.出版时间label.ForeColor = System.Drawing.Color.Black;
            this.出版时间label.Location = new System.Drawing.Point(294, 119);
            this.出版时间label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.出版时间label.Name = "出版时间label";
            this.出版时间label.Size = new System.Drawing.Size(84, 18);
            this.出版时间label.TabIndex = 79;
            this.出版时间label.Text = "出版时间";
            // 
            // 出版社label
            // 
            this.出版社label.AutoSize = true;
            this.出版社label.BackColor = System.Drawing.Color.Transparent;
            this.出版社label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.出版社label.ForeColor = System.Drawing.Color.Black;
            this.出版社label.Location = new System.Drawing.Point(42, 119);
            this.出版社label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.出版社label.Name = "出版社label";
            this.出版社label.Size = new System.Drawing.Size(65, 18);
            this.出版社label.TabIndex = 78;
            this.出版社label.Text = "出版社";
            // 
            // 作者label
            // 
            this.作者label.AutoSize = true;
            this.作者label.BackColor = System.Drawing.Color.Transparent;
            this.作者label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.作者label.ForeColor = System.Drawing.Color.Black;
            this.作者label.Location = new System.Drawing.Point(630, 41);
            this.作者label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.作者label.Name = "作者label";
            this.作者label.Size = new System.Drawing.Size(46, 18);
            this.作者label.TabIndex = 77;
            this.作者label.Text = "作者";
            // 
            // 书名label
            // 
            this.书名label.AutoSize = true;
            this.书名label.BackColor = System.Drawing.Color.Transparent;
            this.书名label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.书名label.ForeColor = System.Drawing.Color.Black;
            this.书名label.Location = new System.Drawing.Point(327, 41);
            this.书名label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.书名label.Name = "书名label";
            this.书名label.Size = new System.Drawing.Size(46, 18);
            this.书名label.TabIndex = 76;
            this.书名label.Text = "书名";
            // 
            // ISBN码label
            // 
            this.ISBN码label.AutoSize = true;
            this.ISBN码label.BackColor = System.Drawing.Color.Transparent;
            this.ISBN码label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ISBN码label.ForeColor = System.Drawing.Color.Black;
            this.ISBN码label.Location = new System.Drawing.Point(42, 41);
            this.ISBN码label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ISBN码label.Name = "ISBN码label";
            this.ISBN码label.Size = new System.Drawing.Size(67, 18);
            this.ISBN码label.TabIndex = 75;
            this.ISBN码label.Text = "ISBN码";
            // 
            // 允许交易textBox
            // 
            this.允许交易textBox.BackColor = System.Drawing.Color.AliceBlue;
            this.允许交易textBox.Location = new System.Drawing.Point(752, 195);
            this.允许交易textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.允许交易textBox.Name = "允许交易textBox";
            this.允许交易textBox.ReadOnly = true;
            this.允许交易textBox.Size = new System.Drawing.Size(86, 28);
            this.允许交易textBox.TabIndex = 74;
            // 
            // 价格textBox
            // 
            this.价格textBox.Location = new System.Drawing.Point(690, 113);
            this.价格textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.价格textBox.Name = "价格textBox";
            this.价格textBox.Size = new System.Drawing.Size(148, 28);
            this.价格textBox.TabIndex = 73;
            this.价格textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DOUBLE_KeyPress);
            // 
            // 出版社textBox
            // 
            this.出版社textBox.Location = new System.Drawing.Point(111, 113);
            this.出版社textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.出版社textBox.Name = "出版社textBox";
            this.出版社textBox.Size = new System.Drawing.Size(148, 28);
            this.出版社textBox.TabIndex = 71;
            // 
            // 作者textBox
            // 
            this.作者textBox.Location = new System.Drawing.Point(690, 29);
            this.作者textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.作者textBox.Name = "作者textBox";
            this.作者textBox.Size = new System.Drawing.Size(148, 28);
            this.作者textBox.TabIndex = 70;
            // 
            // 书名textBox
            // 
            this.书名textBox.Location = new System.Drawing.Point(384, 29);
            this.书名textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.书名textBox.Name = "书名textBox";
            this.书名textBox.Size = new System.Drawing.Size(234, 28);
            this.书名textBox.TabIndex = 69;
            // 
            // ISBN码textBox
            // 
            this.ISBN码textBox.Location = new System.Drawing.Point(112, 38);
            this.ISBN码textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ISBN码textBox.Name = "ISBN码textBox";
            this.ISBN码textBox.Size = new System.Drawing.Size(148, 28);
            this.ISBN码textBox.TabIndex = 68;
            this.ISBN码textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.INT_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(42, 727);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 18);
            this.label1.TabIndex = 67;
            this.label1.Text = "ISBN/书名/作者/出版社";
            // 
            // 查询textBox
            // 
            this.查询textBox.Location = new System.Drawing.Point(262, 722);
            this.查询textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.查询textBox.Name = "查询textBox";
            this.查询textBox.Size = new System.Drawing.Size(150, 28);
            this.查询textBox.TabIndex = 66;
            this.查询textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.查询textBox.Click += new System.EventHandler(this.查询textBox_Click);
            // 
            // 查询button
            // 
            this.查询button.Location = new System.Drawing.Point(452, 722);
            this.查询button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.查询button.Name = "查询button";
            this.查询button.Size = new System.Drawing.Size(105, 35);
            this.查询button.TabIndex = 65;
            this.查询button.Text = "查询";
            this.查询button.UseVisualStyleBackColor = true;
            this.查询button.Click += new System.EventHandler(this.查询button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 380);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1255, 315);
            this.dataGridView1.TabIndex = 64;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // 年comboBox
            // 
            this.年comboBox.BackColor = System.Drawing.Color.AliceBlue;
            this.年comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.年comboBox.FormattingEnabled = true;
            this.年comboBox.Items.AddRange(new object[] {
            "2018年",
            "2017年",
            "2016年",
            "2015年",
            "2014年",
            "2013年",
            "2012年",
            "2011年",
            "2010年",
            "2009年",
            "2008年",
            "2007年",
            "2006年",
            "2005年",
            "2004年",
            "2003年",
            "2002年",
            "2001年",
            "2000年",
            "1999年",
            "1998年",
            "1997年",
            "1996年",
            "1995年",
            "1994年",
            "1993年",
            "1992年",
            "1991年",
            "1990年",
            "1989年",
            "1988年",
            "1987年",
            "1986年",
            "1985年",
            "1984年",
            "1983年",
            "1982年",
            "1981年",
            "1980年",
            "1979年",
            "1978年",
            "1977年",
            "1976年",
            "1975年",
            "1974年",
            "1973年",
            "1972年",
            "1971年",
            "1970年",
            "1969年",
            "1968年",
            "1967年",
            "1966年",
            "1965年",
            "1964年",
            "1963年",
            "1962年",
            "1961年",
            "1960年",
            "1959年",
            "1958年",
            "1957年",
            "1956年",
            "1955年",
            "1954年",
            "1953年",
            "1952年",
            "1951年",
            "1950年",
            "1949年",
            "1948年",
            "1947年",
            "1946年",
            "1945年",
            "1944年",
            "1943年",
            "1942年",
            "1941年",
            "1940年",
            "1939年",
            "1938年",
            "1937年",
            "1936年",
            "1935年",
            "1934年",
            "1933年",
            "1932年",
            "1931年",
            "1930年",
            "1929年",
            "1928年",
            "1927年",
            "1926年",
            "1925年",
            "1924年",
            "1923年",
            "1922年",
            "1921年",
            "1920年",
            "1919年",
            "1918年",
            "1917年",
            "1916年",
            "1915年",
            "1914年",
            "1913年",
            "1912年",
            "1911年",
            "1910年",
            "1909年",
            "1908年",
            "1907年",
            "1906年",
            "1905年",
            "1904年",
            "1903年",
            "1902年",
            "1901年",
            "1900年",
            "1899年"});
            this.年comboBox.Location = new System.Drawing.Point(384, 113);
            this.年comboBox.Name = "年comboBox";
            this.年comboBox.Size = new System.Drawing.Size(91, 26);
            this.年comboBox.TabIndex = 86;
            this.年comboBox.SelectedIndexChanged += new System.EventHandler(this.年comboBox_SelectedIndexChanged);
            // 
            // 月comboBox
            // 
            this.月comboBox.BackColor = System.Drawing.Color.AliceBlue;
            this.月comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.月comboBox.FormattingEnabled = true;
            this.月comboBox.Items.AddRange(new object[] {
            "1月",
            "2月",
            "3月",
            "4月",
            "5月",
            "6月",
            "7月",
            "8月",
            "9月",
            "10月",
            "11月",
            "12月"});
            this.月comboBox.Location = new System.Drawing.Point(481, 113);
            this.月comboBox.Name = "月comboBox";
            this.月comboBox.Size = new System.Drawing.Size(66, 26);
            this.月comboBox.TabIndex = 87;
            this.月comboBox.SelectedIndexChanged += new System.EventHandler(this.月comboBox_SelectedIndexChanged);
            // 
            // 日comboBox
            // 
            this.日comboBox.BackColor = System.Drawing.Color.AliceBlue;
            this.日comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.日comboBox.FormattingEnabled = true;
            this.日comboBox.Location = new System.Drawing.Point(553, 113);
            this.日comboBox.Name = "日comboBox";
            this.日comboBox.Size = new System.Drawing.Size(65, 26);
            this.日comboBox.TabIndex = 88;
            // 
            // 允许交易button
            // 
            this.允许交易button.BackColor = System.Drawing.Color.MistyRose;
            this.允许交易button.Location = new System.Drawing.Point(234, 272);
            this.允许交易button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.允许交易button.Name = "允许交易button";
            this.允许交易button.Size = new System.Drawing.Size(112, 33);
            this.允许交易button.TabIndex = 89;
            this.允许交易button.Text = "允许交易";
            this.允许交易button.UseVisualStyleBackColor = false;
            this.允许交易button.Click += new System.EventHandler(this.允许交易button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImage = global::二手书交易系统_课程设计.Properties.Resources.书目管理;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.禁止交易button);
            this.panel1.Controls.Add(this.允许交易button);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.日comboBox);
            this.panel1.Controls.Add(this.查询button);
            this.panel1.Controls.Add(this.月comboBox);
            this.panel1.Controls.Add(this.查询textBox);
            this.panel1.Controls.Add(this.年comboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.清空button);
            this.panel1.Controls.Add(this.ISBN码textBox);
            this.panel1.Controls.Add(this.书名textBox);
            this.panel1.Controls.Add(this.更新button);
            this.panel1.Controls.Add(this.作者textBox);
            this.panel1.Controls.Add(this.添加button);
            this.panel1.Controls.Add(this.出版社textBox);
            this.panel1.Controls.Add(this.数量label);
            this.panel1.Controls.Add(this.价格textBox);
            this.panel1.Controls.Add(this.价格label);
            this.panel1.Controls.Add(this.允许交易textBox);
            this.panel1.Controls.Add(this.出版时间label);
            this.panel1.Controls.Add(this.ISBN码label);
            this.panel1.Controls.Add(this.出版社label);
            this.panel1.Controls.Add(this.书名label);
            this.panel1.Controls.Add(this.作者label);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 770);
            this.panel1.TabIndex = 90;
            // 
            // 书目管理Form
            // 
            this.AcceptButton = this.查询button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 769);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "书目管理Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "书目管理";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.书目管理Form_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button 清空button;
        private System.Windows.Forms.Button 禁止交易button;
        private System.Windows.Forms.Button 更新button;
        private System.Windows.Forms.Button 添加button;
        private System.Windows.Forms.Label 数量label;
        private System.Windows.Forms.Label 价格label;
        private System.Windows.Forms.Label 出版时间label;
        private System.Windows.Forms.Label 出版社label;
        private System.Windows.Forms.Label 作者label;
        private System.Windows.Forms.Label 书名label;
        private System.Windows.Forms.Label ISBN码label;
        private System.Windows.Forms.TextBox 允许交易textBox;
        private System.Windows.Forms.TextBox 价格textBox;
        private System.Windows.Forms.TextBox 出版社textBox;
        private System.Windows.Forms.TextBox 作者textBox;
        private System.Windows.Forms.TextBox 书名textBox;
        private System.Windows.Forms.TextBox ISBN码textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox 查询textBox;
        private System.Windows.Forms.Button 查询button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox 年comboBox;
        private System.Windows.Forms.ComboBox 月comboBox;
        private System.Windows.Forms.ComboBox 日comboBox;
        private System.Windows.Forms.Button 允许交易button;
        private System.Windows.Forms.Panel panel1;
    }
}