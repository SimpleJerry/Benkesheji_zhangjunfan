namespace 图书管理系统_课程设计
{
    partial class 图书管理Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(图书管理Form));
            this.输入ISBN码textBox = new System.Windows.Forms.TextBox();
            this.查询button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.输入ISBN码label = new System.Windows.Forms.Label();
            this.库存编号textBox = new System.Windows.Forms.TextBox();
            this.书名textBox = new System.Windows.Forms.TextBox();
            this.作者textBox = new System.Windows.Forms.TextBox();
            this.库存编号label = new System.Windows.Forms.Label();
            this.书名label = new System.Windows.Forms.Label();
            this.作者label = new System.Windows.Forms.Label();
            this.馆藏地址label = new System.Windows.Forms.Label();
            this.在馆状态label = new System.Windows.Forms.Label();
            this.添加button = new System.Windows.Forms.Button();
            this.更新button = new System.Windows.Forms.Button();
            this.删除button = new System.Windows.Forms.Button();
            this.ISBN码textBox = new System.Windows.Forms.TextBox();
            this.ISBN码label = new System.Windows.Forms.Label();
            this.馆藏地址comboBox = new System.Windows.Forms.ComboBox();
            this.在馆状态textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // 输入ISBN码textBox
            // 
            this.输入ISBN码textBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.输入ISBN码textBox.Location = new System.Drawing.Point(533, 14);
            this.输入ISBN码textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.输入ISBN码textBox.Name = "输入ISBN码textBox";
            this.输入ISBN码textBox.Size = new System.Drawing.Size(100, 21);
            this.输入ISBN码textBox.TabIndex = 0;
            // 
            // 查询button
            // 
            this.查询button.Location = new System.Drawing.Point(639, 12);
            this.查询button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.查询button.Name = "查询button";
            this.查询button.Size = new System.Drawing.Size(65, 22);
            this.查询button.TabIndex = 1;
            this.查询button.Text = "查询";
            this.查询button.UseVisualStyleBackColor = true;
            this.查询button.Click += new System.EventHandler(this.查询button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, -2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(456, 498);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // 输入ISBN码label
            // 
            this.输入ISBN码label.AutoSize = true;
            this.输入ISBN码label.BackColor = System.Drawing.Color.Transparent;
            this.输入ISBN码label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.输入ISBN码label.ForeColor = System.Drawing.Color.Red;
            this.输入ISBN码label.Location = new System.Drawing.Point(462, 18);
            this.输入ISBN码label.Name = "输入ISBN码label";
            this.输入ISBN码label.Size = new System.Drawing.Size(72, 12);
            this.输入ISBN码label.TabIndex = 3;
            this.输入ISBN码label.Text = "输入ISBN码";
            // 
            // 库存编号textBox
            // 
            this.库存编号textBox.Location = new System.Drawing.Point(552, 74);
            this.库存编号textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.库存编号textBox.Name = "库存编号textBox";
            this.库存编号textBox.Size = new System.Drawing.Size(121, 21);
            this.库存编号textBox.TabIndex = 4;
            // 
            // 书名textBox
            // 
            this.书名textBox.Location = new System.Drawing.Point(552, 158);
            this.书名textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.书名textBox.Name = "书名textBox";
            this.书名textBox.Size = new System.Drawing.Size(121, 21);
            this.书名textBox.TabIndex = 5;
            // 
            // 作者textBox
            // 
            this.作者textBox.Location = new System.Drawing.Point(552, 202);
            this.作者textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.作者textBox.Name = "作者textBox";
            this.作者textBox.Size = new System.Drawing.Size(121, 21);
            this.作者textBox.TabIndex = 6;
            // 
            // 库存编号label
            // 
            this.库存编号label.AutoSize = true;
            this.库存编号label.BackColor = System.Drawing.Color.Transparent;
            this.库存编号label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.库存编号label.ForeColor = System.Drawing.Color.Red;
            this.库存编号label.Location = new System.Drawing.Point(482, 76);
            this.库存编号label.Name = "库存编号label";
            this.库存编号label.Size = new System.Drawing.Size(57, 12);
            this.库存编号label.TabIndex = 9;
            this.库存编号label.Text = "库存编号";
            // 
            // 书名label
            // 
            this.书名label.AutoSize = true;
            this.书名label.BackColor = System.Drawing.Color.Transparent;
            this.书名label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.书名label.ForeColor = System.Drawing.Color.Red;
            this.书名label.Location = new System.Drawing.Point(482, 160);
            this.书名label.Name = "书名label";
            this.书名label.Size = new System.Drawing.Size(52, 12);
            this.书名label.TabIndex = 10;
            this.书名label.Text = "书   名";
            // 
            // 作者label
            // 
            this.作者label.AutoSize = true;
            this.作者label.BackColor = System.Drawing.Color.Transparent;
            this.作者label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.作者label.ForeColor = System.Drawing.Color.Red;
            this.作者label.Location = new System.Drawing.Point(482, 206);
            this.作者label.Name = "作者label";
            this.作者label.Size = new System.Drawing.Size(52, 12);
            this.作者label.TabIndex = 11;
            this.作者label.Text = "作   者";
            // 
            // 馆藏地址label
            // 
            this.馆藏地址label.AutoSize = true;
            this.馆藏地址label.BackColor = System.Drawing.Color.Transparent;
            this.馆藏地址label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.馆藏地址label.ForeColor = System.Drawing.Color.Red;
            this.馆藏地址label.Location = new System.Drawing.Point(482, 250);
            this.馆藏地址label.Name = "馆藏地址label";
            this.馆藏地址label.Size = new System.Drawing.Size(57, 12);
            this.馆藏地址label.TabIndex = 12;
            this.馆藏地址label.Text = "馆藏地址";
            // 
            // 在馆状态label
            // 
            this.在馆状态label.AutoSize = true;
            this.在馆状态label.BackColor = System.Drawing.Color.Transparent;
            this.在馆状态label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.在馆状态label.ForeColor = System.Drawing.Color.Red;
            this.在馆状态label.Location = new System.Drawing.Point(482, 290);
            this.在馆状态label.Name = "在馆状态label";
            this.在馆状态label.Size = new System.Drawing.Size(57, 12);
            this.在馆状态label.TabIndex = 13;
            this.在馆状态label.Text = "在馆状态";
            // 
            // 添加button
            // 
            this.添加button.Location = new System.Drawing.Point(552, 334);
            this.添加button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.添加button.Name = "添加button";
            this.添加button.Size = new System.Drawing.Size(75, 22);
            this.添加button.TabIndex = 14;
            this.添加button.Text = "添加";
            this.添加button.UseVisualStyleBackColor = true;
            this.添加button.Click += new System.EventHandler(this.添加button_Click);
            // 
            // 更新button
            // 
            this.更新button.Location = new System.Drawing.Point(552, 382);
            this.更新button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.更新button.Name = "更新button";
            this.更新button.Size = new System.Drawing.Size(75, 22);
            this.更新button.TabIndex = 15;
            this.更新button.Text = "更新";
            this.更新button.UseVisualStyleBackColor = true;
            this.更新button.Click += new System.EventHandler(this.更新button_Click);
            // 
            // 删除button
            // 
            this.删除button.Location = new System.Drawing.Point(552, 430);
            this.删除button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.删除button.Name = "删除button";
            this.删除button.Size = new System.Drawing.Size(75, 22);
            this.删除button.TabIndex = 16;
            this.删除button.Text = "删除";
            this.删除button.UseVisualStyleBackColor = true;
            this.删除button.Click += new System.EventHandler(this.删除button_Click);
            // 
            // ISBN码textBox
            // 
            this.ISBN码textBox.Location = new System.Drawing.Point(552, 114);
            this.ISBN码textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ISBN码textBox.Name = "ISBN码textBox";
            this.ISBN码textBox.Size = new System.Drawing.Size(121, 21);
            this.ISBN码textBox.TabIndex = 17;
            // 
            // ISBN码label
            // 
            this.ISBN码label.AutoSize = true;
            this.ISBN码label.BackColor = System.Drawing.Color.Transparent;
            this.ISBN码label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ISBN码label.ForeColor = System.Drawing.Color.Red;
            this.ISBN码label.Location = new System.Drawing.Point(485, 118);
            this.ISBN码label.Name = "ISBN码label";
            this.ISBN码label.Size = new System.Drawing.Size(46, 12);
            this.ISBN码label.TabIndex = 18;
            this.ISBN码label.Text = "ISBN码";
            // 
            // 馆藏地址comboBox
            // 
            this.馆藏地址comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.馆藏地址comboBox.FormattingEnabled = true;
            this.馆藏地址comboBox.Items.AddRange(new object[] {
            "A105大书库",
            "二楼",
            "三楼",
            "四楼",
            "五楼",
            "六楼",
            "七楼"});
            this.馆藏地址comboBox.Location = new System.Drawing.Point(552, 246);
            this.馆藏地址comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.馆藏地址comboBox.Name = "馆藏地址comboBox";
            this.馆藏地址comboBox.Size = new System.Drawing.Size(121, 20);
            this.馆藏地址comboBox.TabIndex = 20;
            // 
            // 在馆状态textBox
            // 
            this.在馆状态textBox.Location = new System.Drawing.Point(552, 287);
            this.在馆状态textBox.Name = "在馆状态textBox";
            this.在馆状态textBox.ReadOnly = true;
            this.在馆状态textBox.Size = new System.Drawing.Size(121, 21);
            this.在馆状态textBox.TabIndex = 21;
            // 
            // 图书管理Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(705, 496);
            this.Controls.Add(this.在馆状态textBox);
            this.Controls.Add(this.馆藏地址comboBox);
            this.Controls.Add(this.ISBN码label);
            this.Controls.Add(this.ISBN码textBox);
            this.Controls.Add(this.删除button);
            this.Controls.Add(this.更新button);
            this.Controls.Add(this.添加button);
            this.Controls.Add(this.在馆状态label);
            this.Controls.Add(this.馆藏地址label);
            this.Controls.Add(this.作者label);
            this.Controls.Add(this.书名label);
            this.Controls.Add(this.库存编号label);
            this.Controls.Add(this.作者textBox);
            this.Controls.Add(this.书名textBox);
            this.Controls.Add(this.库存编号textBox);
            this.Controls.Add(this.输入ISBN码label);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.查询button);
            this.Controls.Add(this.输入ISBN码textBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "图书管理Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书管理";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.图书管理Form_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox 输入ISBN码textBox;
        private System.Windows.Forms.Button 查询button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label 输入ISBN码label;
        private System.Windows.Forms.TextBox 库存编号textBox;
        private System.Windows.Forms.TextBox 书名textBox;
        private System.Windows.Forms.TextBox 作者textBox;
        private System.Windows.Forms.Label 库存编号label;
        private System.Windows.Forms.Label 书名label;
        private System.Windows.Forms.Label 作者label;
        private System.Windows.Forms.Label 馆藏地址label;
        private System.Windows.Forms.Label 在馆状态label;
        private System.Windows.Forms.Button 添加button;
        private System.Windows.Forms.Button 更新button;
        private System.Windows.Forms.Button 删除button;
        private System.Windows.Forms.TextBox ISBN码textBox;
        private System.Windows.Forms.Label ISBN码label;
        private System.Windows.Forms.ComboBox 馆藏地址comboBox;
        private System.Windows.Forms.TextBox 在馆状态textBox;
    }
}