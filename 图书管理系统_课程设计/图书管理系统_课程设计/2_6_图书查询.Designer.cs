namespace 图书管理系统_课程设计
{
    partial class 图书查询Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(图书查询Form));
            this.关键字label = new System.Windows.Forms.Label();
            this.查询button = new System.Windows.Forms.Button();
            this.关键字textBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.相关图书信息label = new System.Windows.Forms.Label();
            this.书籍序列号textBox = new System.Windows.Forms.TextBox();
            this.书名textBox = new System.Windows.Forms.TextBox();
            this.作者textBox = new System.Windows.Forms.TextBox();
            this.图书馆藏地址textBox = new System.Windows.Forms.TextBox();
            this.在馆数量textBox = new System.Windows.Forms.TextBox();
            this.在馆数量label = new System.Windows.Forms.Label();
            this.图书馆藏地址label = new System.Windows.Forms.Label();
            this.作者label = new System.Windows.Forms.Label();
            this.书名label = new System.Windows.Forms.Label();
            this.书籍序列号label = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.选择查询条件label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // 关键字label
            // 
            this.关键字label.AutoSize = true;
            this.关键字label.BackColor = System.Drawing.Color.Transparent;
            this.关键字label.ForeColor = System.Drawing.Color.Cyan;
            this.关键字label.Location = new System.Drawing.Point(260, 41);
            this.关键字label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.关键字label.Name = "关键字label";
            this.关键字label.Size = new System.Drawing.Size(53, 12);
            this.关键字label.TabIndex = 19;
            this.关键字label.Text = "关键字：";
            this.关键字label.Click += new System.EventHandler(this.label6_Click);
            // 
            // 查询button
            // 
            this.查询button.Location = new System.Drawing.Point(524, 38);
            this.查询button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.查询button.Name = "查询button";
            this.查询button.Size = new System.Drawing.Size(56, 18);
            this.查询button.TabIndex = 20;
            this.查询button.Text = "查询";
            this.查询button.UseVisualStyleBackColor = true;
            this.查询button.Click += new System.EventHandler(this.查询button1_Click);
            // 
            // 关键字textBox
            // 
            this.关键字textBox.BackColor = System.Drawing.Color.OldLace;
            this.关键字textBox.Location = new System.Drawing.Point(305, 37);
            this.关键字textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.关键字textBox.Name = "关键字textBox";
            this.关键字textBox.Size = new System.Drawing.Size(205, 21);
            this.关键字textBox.TabIndex = 33;
            this.关键字textBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 194);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(661, 302);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 相关图书信息label
            // 
            this.相关图书信息label.AutoSize = true;
            this.相关图书信息label.BackColor = System.Drawing.Color.Transparent;
            this.相关图书信息label.ForeColor = System.Drawing.Color.LightPink;
            this.相关图书信息label.Location = new System.Drawing.Point(4, 177);
            this.相关图书信息label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.相关图书信息label.Name = "相关图书信息label";
            this.相关图书信息label.Size = new System.Drawing.Size(89, 12);
            this.相关图书信息label.TabIndex = 35;
            this.相关图书信息label.Text = "相关图书信息：";
            // 
            // 书籍序列号textBox
            // 
            this.书籍序列号textBox.BackColor = System.Drawing.Color.OldLace;
            this.书籍序列号textBox.Location = new System.Drawing.Point(127, 84);
            this.书籍序列号textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.书籍序列号textBox.Name = "书籍序列号textBox";
            this.书籍序列号textBox.Size = new System.Drawing.Size(158, 21);
            this.书籍序列号textBox.TabIndex = 59;
            this.书籍序列号textBox.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // 书名textBox
            // 
            this.书名textBox.BackColor = System.Drawing.Color.OldLace;
            this.书名textBox.Location = new System.Drawing.Point(127, 122);
            this.书名textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.书名textBox.Name = "书名textBox";
            this.书名textBox.Size = new System.Drawing.Size(158, 21);
            this.书名textBox.TabIndex = 58;
            this.书名textBox.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // 作者textBox
            // 
            this.作者textBox.BackColor = System.Drawing.Color.OldLace;
            this.作者textBox.Location = new System.Drawing.Point(127, 157);
            this.作者textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.作者textBox.Name = "作者textBox";
            this.作者textBox.Size = new System.Drawing.Size(158, 21);
            this.作者textBox.TabIndex = 57;
            this.作者textBox.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // 图书馆藏地址textBox
            // 
            this.图书馆藏地址textBox.BackColor = System.Drawing.Color.OldLace;
            this.图书馆藏地址textBox.Location = new System.Drawing.Point(412, 84);
            this.图书馆藏地址textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.图书馆藏地址textBox.Name = "图书馆藏地址textBox";
            this.图书馆藏地址textBox.Size = new System.Drawing.Size(148, 21);
            this.图书馆藏地址textBox.TabIndex = 56;
            this.图书馆藏地址textBox.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // 在馆数量textBox
            // 
            this.在馆数量textBox.BackColor = System.Drawing.Color.OldLace;
            this.在馆数量textBox.Location = new System.Drawing.Point(412, 122);
            this.在馆数量textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.在馆数量textBox.Name = "在馆数量textBox";
            this.在馆数量textBox.Size = new System.Drawing.Size(134, 21);
            this.在馆数量textBox.TabIndex = 55;
            this.在馆数量textBox.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // 在馆数量label
            // 
            this.在馆数量label.AutoSize = true;
            this.在馆数量label.BackColor = System.Drawing.Color.Transparent;
            this.在馆数量label.ForeColor = System.Drawing.Color.Cyan;
            this.在馆数量label.Location = new System.Drawing.Point(346, 128);
            this.在馆数量label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.在馆数量label.Name = "在馆数量label";
            this.在馆数量label.Size = new System.Drawing.Size(65, 12);
            this.在馆数量label.TabIndex = 54;
            this.在馆数量label.Text = "在馆数量：";
            // 
            // 图书馆藏地址label
            // 
            this.图书馆藏地址label.AutoSize = true;
            this.图书馆藏地址label.BackColor = System.Drawing.Color.Transparent;
            this.图书馆藏地址label.ForeColor = System.Drawing.Color.Cyan;
            this.图书馆藏地址label.Location = new System.Drawing.Point(327, 92);
            this.图书馆藏地址label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.图书馆藏地址label.Name = "图书馆藏地址label";
            this.图书馆藏地址label.Size = new System.Drawing.Size(89, 12);
            this.图书馆藏地址label.TabIndex = 52;
            this.图书馆藏地址label.Text = "图书馆藏地址：";
            // 
            // 作者label
            // 
            this.作者label.AutoSize = true;
            this.作者label.BackColor = System.Drawing.Color.Transparent;
            this.作者label.ForeColor = System.Drawing.Color.Cyan;
            this.作者label.Location = new System.Drawing.Point(86, 165);
            this.作者label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.作者label.Name = "作者label";
            this.作者label.Size = new System.Drawing.Size(41, 12);
            this.作者label.TabIndex = 50;
            this.作者label.Text = "作者：";
            // 
            // 书名label
            // 
            this.书名label.AutoSize = true;
            this.书名label.BackColor = System.Drawing.Color.Transparent;
            this.书名label.ForeColor = System.Drawing.Color.Cyan;
            this.书名label.Location = new System.Drawing.Point(86, 125);
            this.书名label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.书名label.Name = "书名label";
            this.书名label.Size = new System.Drawing.Size(41, 12);
            this.书名label.TabIndex = 49;
            this.书名label.Text = "书名：";
            // 
            // 书籍序列号label
            // 
            this.书籍序列号label.AutoSize = true;
            this.书籍序列号label.BackColor = System.Drawing.Color.Transparent;
            this.书籍序列号label.ForeColor = System.Drawing.Color.Cyan;
            this.书籍序列号label.Location = new System.Drawing.Point(58, 90);
            this.书籍序列号label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.书籍序列号label.Name = "书籍序列号label";
            this.书籍序列号label.Size = new System.Drawing.Size(77, 12);
            this.书籍序列号label.TabIndex = 48;
            this.书籍序列号label.Text = "书籍序列号：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(517, 2);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 21);
            this.dateTimePicker1.TabIndex = 60;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "查找所有书籍",
            "按书名查找",
            "按ISBN查找",
            "按作者查找",
            "按出版社查找"});
            this.comboBox1.Location = new System.Drawing.Point(127, 38);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 20);
            this.comboBox1.TabIndex = 61;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // 选择查询条件label
            // 
            this.选择查询条件label.AutoSize = true;
            this.选择查询条件label.BackColor = System.Drawing.Color.Transparent;
            this.选择查询条件label.ForeColor = System.Drawing.Color.Aqua;
            this.选择查询条件label.Location = new System.Drawing.Point(29, 45);
            this.选择查询条件label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.选择查询条件label.Name = "选择查询条件label";
            this.选择查询条件label.Size = new System.Drawing.Size(89, 12);
            this.选择查询条件label.TabIndex = 81;
            this.选择查询条件label.Text = "选择查询条件：";
            // 
            // 图书查询Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(670, 496);
            this.Controls.Add(this.选择查询条件label);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.书籍序列号textBox);
            this.Controls.Add(this.书名textBox);
            this.Controls.Add(this.作者textBox);
            this.Controls.Add(this.图书馆藏地址textBox);
            this.Controls.Add(this.在馆数量textBox);
            this.Controls.Add(this.在馆数量label);
            this.Controls.Add(this.图书馆藏地址label);
            this.Controls.Add(this.作者label);
            this.Controls.Add(this.书名label);
            this.Controls.Add(this.书籍序列号label);
            this.Controls.Add(this.相关图书信息label);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.关键字textBox);
            this.Controls.Add(this.查询button);
            this.Controls.Add(this.关键字label);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "图书查询Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书查询";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.图书查询Form_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 关键字label;
        private System.Windows.Forms.Button 查询button;
        private System.Windows.Forms.TextBox 关键字textBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label 相关图书信息label;
        private System.Windows.Forms.TextBox 书籍序列号textBox;
        private System.Windows.Forms.TextBox 书名textBox;
        private System.Windows.Forms.TextBox 作者textBox;
        private System.Windows.Forms.TextBox 图书馆藏地址textBox;
        private System.Windows.Forms.TextBox 在馆数量textBox;
        private System.Windows.Forms.Label 在馆数量label;
        private System.Windows.Forms.Label 图书馆藏地址label;
        private System.Windows.Forms.Label 作者label;
        private System.Windows.Forms.Label 书名label;
        private System.Windows.Forms.Label 书籍序列号label;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label 选择查询条件label;
    }
}