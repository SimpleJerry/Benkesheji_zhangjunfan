namespace 图书管理系统_课程设计
{
    partial class 添加图书Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(添加图书Form));
            this.删除button = new System.Windows.Forms.Button();
            this.更新button = new System.Windows.Forms.Button();
            this.添加button = new System.Windows.Forms.Button();
            this.数量label = new System.Windows.Forms.Label();
            this.价格label = new System.Windows.Forms.Label();
            this.出版时间label = new System.Windows.Forms.Label();
            this.出版社label = new System.Windows.Forms.Label();
            this.作者label = new System.Windows.Forms.Label();
            this.书名label = new System.Windows.Forms.Label();
            this.ISBN码label = new System.Windows.Forms.Label();
            this.数量textBox = new System.Windows.Forms.TextBox();
            this.价格textBox = new System.Windows.Forms.TextBox();
            this.出版时间textBox = new System.Windows.Forms.TextBox();
            this.出版社textBox = new System.Windows.Forms.TextBox();
            this.作者textBox = new System.Windows.Forms.TextBox();
            this.书名textBox = new System.Windows.Forms.TextBox();
            this.ISBN码textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.查询textBox = new System.Windows.Forms.TextBox();
            this.查询button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.信息 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.清空button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // 删除button
            // 
            this.删除button.BackColor = System.Drawing.Color.MistyRose;
            this.删除button.Location = new System.Drawing.Point(440, 138);
            this.删除button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.删除button.Name = "删除button";
            this.删除button.Size = new System.Drawing.Size(75, 22);
            this.删除button.TabIndex = 62;
            this.删除button.Text = "删除";
            this.删除button.UseVisualStyleBackColor = false;
            this.删除button.Click += new System.EventHandler(this.删除button_Click);
            // 
            // 更新button
            // 
            this.更新button.BackColor = System.Drawing.Color.MistyRose;
            this.更新button.Location = new System.Drawing.Point(256, 138);
            this.更新button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.更新button.Name = "更新button";
            this.更新button.Size = new System.Drawing.Size(75, 22);
            this.更新button.TabIndex = 61;
            this.更新button.Text = "更新";
            this.更新button.UseVisualStyleBackColor = false;
            this.更新button.Click += new System.EventHandler(this.更新button_Click);
            // 
            // 添加button
            // 
            this.添加button.BackColor = System.Drawing.Color.MistyRose;
            this.添加button.ForeColor = System.Drawing.Color.Black;
            this.添加button.Location = new System.Drawing.Point(75, 138);
            this.添加button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.添加button.Name = "添加button";
            this.添加button.Size = new System.Drawing.Size(75, 22);
            this.添加button.TabIndex = 60;
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
            this.数量label.Location = new System.Drawing.Point(560, 82);
            this.数量label.Name = "数量label";
            this.数量label.Size = new System.Drawing.Size(31, 12);
            this.数量label.TabIndex = 59;
            this.数量label.Text = "数量";
            // 
            // 价格label
            // 
            this.价格label.AutoSize = true;
            this.价格label.BackColor = System.Drawing.Color.Transparent;
            this.价格label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.价格label.ForeColor = System.Drawing.Color.Black;
            this.价格label.Location = new System.Drawing.Point(393, 78);
            this.价格label.Name = "价格label";
            this.价格label.Size = new System.Drawing.Size(31, 12);
            this.价格label.TabIndex = 58;
            this.价格label.Text = "价格";
            // 
            // 出版时间label
            // 
            this.出版时间label.AutoSize = true;
            this.出版时间label.BackColor = System.Drawing.Color.Transparent;
            this.出版时间label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.出版时间label.ForeColor = System.Drawing.Color.Black;
            this.出版时间label.Location = new System.Drawing.Point(196, 78);
            this.出版时间label.Name = "出版时间label";
            this.出版时间label.Size = new System.Drawing.Size(57, 12);
            this.出版时间label.TabIndex = 57;
            this.出版时间label.Text = "出版时间";
            // 
            // 出版社label
            // 
            this.出版社label.AutoSize = true;
            this.出版社label.BackColor = System.Drawing.Color.Transparent;
            this.出版社label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.出版社label.ForeColor = System.Drawing.Color.Black;
            this.出版社label.Location = new System.Drawing.Point(28, 78);
            this.出版社label.Name = "出版社label";
            this.出版社label.Size = new System.Drawing.Size(44, 12);
            this.出版社label.TabIndex = 56;
            this.出版社label.Text = "出版社";
            // 
            // 作者label
            // 
            this.作者label.AutoSize = true;
            this.作者label.BackColor = System.Drawing.Color.Transparent;
            this.作者label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.作者label.ForeColor = System.Drawing.Color.Black;
            this.作者label.Location = new System.Drawing.Point(393, 26);
            this.作者label.Name = "作者label";
            this.作者label.Size = new System.Drawing.Size(31, 12);
            this.作者label.TabIndex = 55;
            this.作者label.Text = "作者";
            // 
            // 书名label
            // 
            this.书名label.AutoSize = true;
            this.书名label.BackColor = System.Drawing.Color.Transparent;
            this.书名label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.书名label.ForeColor = System.Drawing.Color.Black;
            this.书名label.Location = new System.Drawing.Point(218, 26);
            this.书名label.Name = "书名label";
            this.书名label.Size = new System.Drawing.Size(31, 12);
            this.书名label.TabIndex = 54;
            this.书名label.Text = "书名";
            // 
            // ISBN码label
            // 
            this.ISBN码label.AutoSize = true;
            this.ISBN码label.BackColor = System.Drawing.Color.Transparent;
            this.ISBN码label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ISBN码label.ForeColor = System.Drawing.Color.Black;
            this.ISBN码label.Location = new System.Drawing.Point(28, 26);
            this.ISBN码label.Name = "ISBN码label";
            this.ISBN码label.Size = new System.Drawing.Size(46, 12);
            this.ISBN码label.TabIndex = 53;
            this.ISBN码label.Text = "ISBN码";
            // 
            // 数量textBox
            // 
            this.数量textBox.Location = new System.Drawing.Point(595, 76);
            this.数量textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.数量textBox.Name = "数量textBox";
            this.数量textBox.ReadOnly = true;
            this.数量textBox.Size = new System.Drawing.Size(59, 21);
            this.数量textBox.TabIndex = 52;
            // 
            // 价格textBox
            // 
            this.价格textBox.Location = new System.Drawing.Point(440, 76);
            this.价格textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.价格textBox.Name = "价格textBox";
            this.价格textBox.Size = new System.Drawing.Size(100, 21);
            this.价格textBox.TabIndex = 51;
            // 
            // 出版时间textBox
            // 
            this.出版时间textBox.Location = new System.Drawing.Point(256, 76);
            this.出版时间textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.出版时间textBox.Name = "出版时间textBox";
            this.出版时间textBox.Size = new System.Drawing.Size(100, 21);
            this.出版时间textBox.TabIndex = 50;
            // 
            // 出版社textBox
            // 
            this.出版社textBox.Location = new System.Drawing.Point(74, 74);
            this.出版社textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.出版社textBox.Name = "出版社textBox";
            this.出版社textBox.Size = new System.Drawing.Size(100, 21);
            this.出版社textBox.TabIndex = 49;
            // 
            // 作者textBox
            // 
            this.作者textBox.Location = new System.Drawing.Point(440, 18);
            this.作者textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.作者textBox.Name = "作者textBox";
            this.作者textBox.Size = new System.Drawing.Size(100, 21);
            this.作者textBox.TabIndex = 48;
            // 
            // 书名textBox
            // 
            this.书名textBox.Location = new System.Drawing.Point(256, 18);
            this.书名textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.书名textBox.Name = "书名textBox";
            this.书名textBox.Size = new System.Drawing.Size(100, 21);
            this.书名textBox.TabIndex = 47;
            // 
            // ISBN码textBox
            // 
            this.ISBN码textBox.Location = new System.Drawing.Point(75, 24);
            this.ISBN码textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ISBN码textBox.Name = "ISBN码textBox";
            this.ISBN码textBox.Size = new System.Drawing.Size(100, 21);
            this.ISBN码textBox.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(28, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 12);
            this.label1.TabIndex = 45;
            this.label1.Text = "ISBN/书名/作者/出版社";
            // 
            // 查询textBox
            // 
            this.查询textBox.Location = new System.Drawing.Point(165, 456);
            this.查询textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.查询textBox.Name = "查询textBox";
            this.查询textBox.Size = new System.Drawing.Size(100, 21);
            this.查询textBox.TabIndex = 44;
            this.查询textBox.Text = "(全部)";
            // 
            // 查询button
            // 
            this.查询button.Location = new System.Drawing.Point(271, 454);
            this.查询button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.查询button.Name = "查询button";
            this.查询button.Size = new System.Drawing.Size(75, 22);
            this.查询button.TabIndex = 43;
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
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.信息});
            this.dataGridView1.Location = new System.Drawing.Point(2, 266);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(701, 174);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // 信息
            // 
            this.信息.HeaderText = "信息";
            this.信息.Name = "信息";
            this.信息.ReadOnly = true;
            this.信息.Text = "在馆信息";
            this.信息.UseColumnTextForButtonValue = true;
            // 
            // 清空button
            // 
            this.清空button.BackColor = System.Drawing.Color.MistyRose;
            this.清空button.Location = new System.Drawing.Point(579, 138);
            this.清空button.Name = "清空button";
            this.清空button.Size = new System.Drawing.Size(75, 23);
            this.清空button.TabIndex = 63;
            this.清空button.Text = "清空";
            this.清空button.UseVisualStyleBackColor = false;
            this.清空button.Click += new System.EventHandler(this.清空button_Click);
            // 
            // 添加图书Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 496);
            this.Controls.Add(this.清空button);
            this.Controls.Add(this.删除button);
            this.Controls.Add(this.更新button);
            this.Controls.Add(this.添加button);
            this.Controls.Add(this.数量label);
            this.Controls.Add(this.价格label);
            this.Controls.Add(this.出版时间label);
            this.Controls.Add(this.出版社label);
            this.Controls.Add(this.作者label);
            this.Controls.Add(this.书名label);
            this.Controls.Add(this.ISBN码label);
            this.Controls.Add(this.数量textBox);
            this.Controls.Add(this.价格textBox);
            this.Controls.Add(this.出版时间textBox);
            this.Controls.Add(this.出版社textBox);
            this.Controls.Add(this.作者textBox);
            this.Controls.Add(this.书名textBox);
            this.Controls.Add(this.ISBN码textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.查询textBox);
            this.Controls.Add(this.查询button);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "添加图书Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加图书";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.添加图书Form_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 删除button;
        private System.Windows.Forms.Button 更新button;
        private System.Windows.Forms.Button 添加button;
        private System.Windows.Forms.Label 数量label;
        private System.Windows.Forms.Label 价格label;
        private System.Windows.Forms.Label 出版社label;
        private System.Windows.Forms.Label 作者label;
        private System.Windows.Forms.Label 书名label;
        private System.Windows.Forms.Label ISBN码label;
        private System.Windows.Forms.TextBox 数量textBox;
        private System.Windows.Forms.TextBox 价格textBox;
        private System.Windows.Forms.TextBox 出版时间textBox;
        private System.Windows.Forms.TextBox 出版社textBox;
        private System.Windows.Forms.TextBox 作者textBox;
        private System.Windows.Forms.TextBox 书名textBox;
        private System.Windows.Forms.TextBox ISBN码textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox 查询textBox;
        private System.Windows.Forms.Button 查询button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn 信息;
        private System.Windows.Forms.Label 出版时间label;
        private System.Windows.Forms.Button 清空button;
    }
}