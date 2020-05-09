namespace 图书管理系统_课程设计
{
    partial class 读者管理Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(读者管理Form));
            this.身份label = new System.Windows.Forms.Label();
            this.邮箱label = new System.Windows.Forms.Label();
            this.电话label = new System.Windows.Forms.Label();
            this.姓名label = new System.Windows.Forms.Label();
            this.账号label = new System.Windows.Forms.Label();
            this.序号label = new System.Windows.Forms.Label();
            this.邮箱textBox = new System.Windows.Forms.TextBox();
            this.电话textBox = new System.Windows.Forms.TextBox();
            this.姓名textBox = new System.Windows.Forms.TextBox();
            this.账号textBox = new System.Windows.Forms.TextBox();
            this.序号textBox = new System.Windows.Forms.TextBox();
            this.查询所有读者button = new System.Windows.Forms.Button();
            this.更新button = new System.Windows.Forms.Button();
            this.添加button = new System.Windows.Forms.Button();
            this.删除button = new System.Windows.Forms.Button();
            this.身份comboBox = new System.Windows.Forms.ComboBox();
            this.查询button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.总人数textBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // 身份label
            // 
            this.身份label.AutoSize = true;
            this.身份label.BackColor = System.Drawing.Color.Transparent;
            this.身份label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.身份label.ForeColor = System.Drawing.Color.Black;
            this.身份label.Location = new System.Drawing.Point(428, 106);
            this.身份label.Name = "身份label";
            this.身份label.Size = new System.Drawing.Size(31, 12);
            this.身份label.TabIndex = 30;
            this.身份label.Text = "身份";
            // 
            // 邮箱label
            // 
            this.邮箱label.AutoSize = true;
            this.邮箱label.BackColor = System.Drawing.Color.Transparent;
            this.邮箱label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.邮箱label.ForeColor = System.Drawing.Color.Black;
            this.邮箱label.Location = new System.Drawing.Point(244, 106);
            this.邮箱label.Name = "邮箱label";
            this.邮箱label.Size = new System.Drawing.Size(31, 12);
            this.邮箱label.TabIndex = 29;
            this.邮箱label.Text = "邮箱";
            // 
            // 电话label
            // 
            this.电话label.AutoSize = true;
            this.电话label.BackColor = System.Drawing.Color.Transparent;
            this.电话label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.电话label.ForeColor = System.Drawing.Color.Black;
            this.电话label.Location = new System.Drawing.Point(80, 106);
            this.电话label.Name = "电话label";
            this.电话label.Size = new System.Drawing.Size(31, 12);
            this.电话label.TabIndex = 28;
            this.电话label.Text = "电话";
            // 
            // 姓名label
            // 
            this.姓名label.AutoSize = true;
            this.姓名label.BackColor = System.Drawing.Color.Transparent;
            this.姓名label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.姓名label.ForeColor = System.Drawing.Color.Black;
            this.姓名label.Location = new System.Drawing.Point(427, 56);
            this.姓名label.Name = "姓名label";
            this.姓名label.Size = new System.Drawing.Size(31, 12);
            this.姓名label.TabIndex = 27;
            this.姓名label.Text = "姓名";
            // 
            // 账号label
            // 
            this.账号label.AutoSize = true;
            this.账号label.BackColor = System.Drawing.Color.Transparent;
            this.账号label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.账号label.ForeColor = System.Drawing.Color.Black;
            this.账号label.Location = new System.Drawing.Point(244, 56);
            this.账号label.Name = "账号label";
            this.账号label.Size = new System.Drawing.Size(31, 12);
            this.账号label.TabIndex = 25;
            this.账号label.Text = "账号";
            // 
            // 序号label
            // 
            this.序号label.AutoSize = true;
            this.序号label.BackColor = System.Drawing.Color.Transparent;
            this.序号label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.序号label.ForeColor = System.Drawing.Color.Black;
            this.序号label.Location = new System.Drawing.Point(80, 56);
            this.序号label.Name = "序号label";
            this.序号label.Size = new System.Drawing.Size(31, 12);
            this.序号label.TabIndex = 24;
            this.序号label.Text = "序号";
            // 
            // 邮箱textBox
            // 
            this.邮箱textBox.BackColor = System.Drawing.SystemColors.Window;
            this.邮箱textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.邮箱textBox.Location = new System.Drawing.Point(290, 102);
            this.邮箱textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.邮箱textBox.Name = "邮箱textBox";
            this.邮箱textBox.Size = new System.Drawing.Size(100, 21);
            this.邮箱textBox.TabIndex = 22;
            this.邮箱textBox.Leave += new System.EventHandler(this.邮箱textBox_Leave);
            // 
            // 电话textBox
            // 
            this.电话textBox.BackColor = System.Drawing.SystemColors.Window;
            this.电话textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.电话textBox.Location = new System.Drawing.Point(118, 102);
            this.电话textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.电话textBox.Name = "电话textBox";
            this.电话textBox.Size = new System.Drawing.Size(100, 21);
            this.电话textBox.TabIndex = 21;
            this.电话textBox.Leave += new System.EventHandler(this.电话textBox_Leave);
            // 
            // 姓名textBox
            // 
            this.姓名textBox.BackColor = System.Drawing.SystemColors.Window;
            this.姓名textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.姓名textBox.Location = new System.Drawing.Point(461, 54);
            this.姓名textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.姓名textBox.Name = "姓名textBox";
            this.姓名textBox.Size = new System.Drawing.Size(93, 21);
            this.姓名textBox.TabIndex = 20;
            this.姓名textBox.Leave += new System.EventHandler(this.姓名textBox_Leave);
            // 
            // 账号textBox
            // 
            this.账号textBox.BackColor = System.Drawing.SystemColors.Window;
            this.账号textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.账号textBox.Location = new System.Drawing.Point(290, 54);
            this.账号textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.账号textBox.Name = "账号textBox";
            this.账号textBox.Size = new System.Drawing.Size(100, 21);
            this.账号textBox.TabIndex = 19;
            this.账号textBox.Leave += new System.EventHandler(this.账号textBox_Leave);
            // 
            // 序号textBox
            // 
            this.序号textBox.BackColor = System.Drawing.SystemColors.Window;
            this.序号textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.序号textBox.Location = new System.Drawing.Point(115, 54);
            this.序号textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.序号textBox.Name = "序号textBox";
            this.序号textBox.ReadOnly = true;
            this.序号textBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.序号textBox.Size = new System.Drawing.Size(100, 21);
            this.序号textBox.TabIndex = 18;
            this.序号textBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.序号textBox_MouseClick);
            // 
            // 查询所有读者button
            // 
            this.查询所有读者button.BackColor = System.Drawing.Color.MistyRose;
            this.查询所有读者button.Location = new System.Drawing.Point(660, 244);
            this.查询所有读者button.Margin = new System.Windows.Forms.Padding(2);
            this.查询所有读者button.Name = "查询所有读者button";
            this.查询所有读者button.Size = new System.Drawing.Size(122, 44);
            this.查询所有读者button.TabIndex = 16;
            this.查询所有读者button.Text = "查询所有读者";
            this.查询所有读者button.UseVisualStyleBackColor = false;
            this.查询所有读者button.Click += new System.EventHandler(this.button1_Click);
            // 
            // 更新button
            // 
            this.更新button.BackColor = System.Drawing.Color.MistyRose;
            this.更新button.Location = new System.Drawing.Point(118, 162);
            this.更新button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.更新button.Name = "更新button";
            this.更新button.Size = new System.Drawing.Size(75, 22);
            this.更新button.TabIndex = 31;
            this.更新button.Text = "更新";
            this.更新button.UseVisualStyleBackColor = false;
            this.更新button.Click += new System.EventHandler(this.更新button_Click);
            // 
            // 添加button
            // 
            this.添加button.BackColor = System.Drawing.Color.MistyRose;
            this.添加button.Location = new System.Drawing.Point(233, 162);
            this.添加button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.添加button.Name = "添加button";
            this.添加button.Size = new System.Drawing.Size(75, 22);
            this.添加button.TabIndex = 32;
            this.添加button.Text = "添加";
            this.添加button.UseVisualStyleBackColor = false;
            this.添加button.Click += new System.EventHandler(this.添加button_Click);
            // 
            // 删除button
            // 
            this.删除button.BackColor = System.Drawing.Color.MistyRose;
            this.删除button.Location = new System.Drawing.Point(342, 162);
            this.删除button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.删除button.Name = "删除button";
            this.删除button.Size = new System.Drawing.Size(75, 22);
            this.删除button.TabIndex = 33;
            this.删除button.Text = "删除";
            this.删除button.UseVisualStyleBackColor = false;
            this.删除button.Click += new System.EventHandler(this.删除button_Click);
            // 
            // 身份comboBox
            // 
            this.身份comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.身份comboBox.FormattingEnabled = true;
            this.身份comboBox.Items.AddRange(new object[] {
            "学生",
            "研究生",
            "教师",
            "黑名单"});
            this.身份comboBox.Location = new System.Drawing.Point(462, 102);
            this.身份comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.身份comboBox.Name = "身份comboBox";
            this.身份comboBox.Size = new System.Drawing.Size(93, 20);
            this.身份comboBox.TabIndex = 34;
            // 
            // 查询button
            // 
            this.查询button.BackColor = System.Drawing.Color.SkyBlue;
            this.查询button.Location = new System.Drawing.Point(461, 162);
            this.查询button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.查询button.Name = "查询button";
            this.查询button.Size = new System.Drawing.Size(75, 22);
            this.查询button.TabIndex = 35;
            this.查询button.Text = "查询";
            this.查询button.UseVisualStyleBackColor = false;
            this.查询button.Click += new System.EventHandler(this.查询button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(638, 278);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(581, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 40;
            this.label1.Text = "总人数";
            // 
            // 总人数textBox
            // 
            this.总人数textBox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.总人数textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.总人数textBox.Location = new System.Drawing.Point(631, 101);
            this.总人数textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.总人数textBox.Name = "总人数textBox";
            this.总人数textBox.ReadOnly = true;
            this.总人数textBox.Size = new System.Drawing.Size(39, 21);
            this.总人数textBox.TabIndex = 39;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // 读者管理Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.总人数textBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.查询button);
            this.Controls.Add(this.身份comboBox);
            this.Controls.Add(this.删除button);
            this.Controls.Add(this.添加button);
            this.Controls.Add(this.更新button);
            this.Controls.Add(this.身份label);
            this.Controls.Add(this.邮箱label);
            this.Controls.Add(this.电话label);
            this.Controls.Add(this.姓名label);
            this.Controls.Add(this.账号label);
            this.Controls.Add(this.序号label);
            this.Controls.Add(this.邮箱textBox);
            this.Controls.Add(this.电话textBox);
            this.Controls.Add(this.姓名textBox);
            this.Controls.Add(this.账号textBox);
            this.Controls.Add(this.序号textBox);
            this.Controls.Add(this.查询所有读者button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "读者管理Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "读者管理";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.读者管理Form_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 身份label;
        private System.Windows.Forms.Label 邮箱label;
        private System.Windows.Forms.Label 电话label;
        private System.Windows.Forms.Label 姓名label;
        private System.Windows.Forms.Label 账号label;
        private System.Windows.Forms.Label 序号label;
        private System.Windows.Forms.TextBox 邮箱textBox;
        private System.Windows.Forms.TextBox 电话textBox;
        private System.Windows.Forms.TextBox 姓名textBox;
        private System.Windows.Forms.TextBox 账号textBox;
        private System.Windows.Forms.TextBox 序号textBox;
        private System.Windows.Forms.Button 查询所有读者button;
        private System.Windows.Forms.Button 更新button;
        private System.Windows.Forms.Button 添加button;
        private System.Windows.Forms.Button 删除button;
        private System.Windows.Forms.ComboBox 身份comboBox;
        private System.Windows.Forms.Button 查询button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox 总人数textBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}