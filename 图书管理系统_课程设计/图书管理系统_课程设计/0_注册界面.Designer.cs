namespace 图书管理系统_课程设计
{
    partial class 注册界面Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(注册界面Form));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.身份comboBox = new System.Windows.Forms.ComboBox();
            this.邮箱textBox = new System.Windows.Forms.TextBox();
            this.手机textBox = new System.Windows.Forms.TextBox();
            this.姓名textBox = new System.Windows.Forms.TextBox();
            this.再次输入密码textBox = new System.Windows.Forms.TextBox();
            this.密码textBox = new System.Windows.Forms.TextBox();
            this.账号textBox = new System.Windows.Forms.TextBox();
            this.账号label = new System.Windows.Forms.Label();
            this.密码label = new System.Windows.Forms.Label();
            this.再次输入密码label = new System.Windows.Forms.Label();
            this.姓名label = new System.Windows.Forms.Label();
            this.手机label = new System.Windows.Forms.Label();
            this.邮箱label = new System.Windows.Forms.Label();
            this.注册button = new System.Windows.Forms.Button();
            this.取消button = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.身份comboBox);
            this.groupBox1.Controls.Add(this.邮箱textBox);
            this.groupBox1.Controls.Add(this.手机textBox);
            this.groupBox1.Controls.Add(this.姓名textBox);
            this.groupBox1.Controls.Add(this.再次输入密码textBox);
            this.groupBox1.Controls.Add(this.密码textBox);
            this.groupBox1.Controls.Add(this.账号textBox);
            this.groupBox1.Location = new System.Drawing.Point(152, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(200, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // 身份comboBox
            // 
            this.身份comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.身份comboBox.FormattingEnabled = true;
            this.身份comboBox.Items.AddRange(new object[] {
            "学生",
            "研究生",
            "教师"});
            this.身份comboBox.Location = new System.Drawing.Point(46, 262);
            this.身份comboBox.Name = "身份comboBox";
            this.身份comboBox.Size = new System.Drawing.Size(122, 20);
            this.身份comboBox.TabIndex = 7;
            // 
            // 邮箱textBox
            // 
            this.邮箱textBox.Location = new System.Drawing.Point(46, 227);
            this.邮箱textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.邮箱textBox.Name = "邮箱textBox";
            this.邮箱textBox.Size = new System.Drawing.Size(122, 21);
            this.邮箱textBox.TabIndex = 6;
            this.邮箱textBox.MouseLeave += new System.EventHandler(this.邮箱textBox_MouseLeave);
            // 
            // 手机textBox
            // 
            this.手机textBox.Location = new System.Drawing.Point(46, 189);
            this.手机textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.手机textBox.Name = "手机textBox";
            this.手机textBox.Size = new System.Drawing.Size(122, 21);
            this.手机textBox.TabIndex = 5;
            this.手机textBox.MouseLeave += new System.EventHandler(this.手机textBox_MouseLeave);
            // 
            // 姓名textBox
            // 
            this.姓名textBox.Location = new System.Drawing.Point(46, 152);
            this.姓名textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.姓名textBox.Name = "姓名textBox";
            this.姓名textBox.Size = new System.Drawing.Size(122, 21);
            this.姓名textBox.TabIndex = 4;
            this.姓名textBox.MouseLeave += new System.EventHandler(this.姓名textBox_MouseLeave);
            // 
            // 再次输入密码textBox
            // 
            this.再次输入密码textBox.Location = new System.Drawing.Point(46, 110);
            this.再次输入密码textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.再次输入密码textBox.Name = "再次输入密码textBox";
            this.再次输入密码textBox.PasswordChar = '*';
            this.再次输入密码textBox.Size = new System.Drawing.Size(122, 21);
            this.再次输入密码textBox.TabIndex = 3;
            this.再次输入密码textBox.MouseLeave += new System.EventHandler(this.再次输入密码textBox_MouseLeave);
            // 
            // 密码textBox
            // 
            this.密码textBox.Location = new System.Drawing.Point(46, 72);
            this.密码textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.密码textBox.Name = "密码textBox";
            this.密码textBox.PasswordChar = '*';
            this.密码textBox.Size = new System.Drawing.Size(122, 21);
            this.密码textBox.TabIndex = 2;
            // 
            // 账号textBox
            // 
            this.账号textBox.Location = new System.Drawing.Point(46, 30);
            this.账号textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.账号textBox.Name = "账号textBox";
            this.账号textBox.Size = new System.Drawing.Size(122, 21);
            this.账号textBox.TabIndex = 1;
            // 
            // 账号label
            // 
            this.账号label.AutoSize = true;
            this.账号label.BackColor = System.Drawing.Color.Transparent;
            this.账号label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.账号label.Location = new System.Drawing.Point(58, 62);
            this.账号label.Name = "账号label";
            this.账号label.Size = new System.Drawing.Size(31, 12);
            this.账号label.TabIndex = 1;
            this.账号label.Text = "账号";
            // 
            // 密码label
            // 
            this.密码label.AutoSize = true;
            this.密码label.BackColor = System.Drawing.Color.Transparent;
            this.密码label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.密码label.Location = new System.Drawing.Point(58, 98);
            this.密码label.Name = "密码label";
            this.密码label.Size = new System.Drawing.Size(31, 12);
            this.密码label.TabIndex = 2;
            this.密码label.Text = "密码";
            // 
            // 再次输入密码label
            // 
            this.再次输入密码label.AutoSize = true;
            this.再次输入密码label.BackColor = System.Drawing.Color.Transparent;
            this.再次输入密码label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.再次输入密码label.ForeColor = System.Drawing.Color.Black;
            this.再次输入密码label.Location = new System.Drawing.Point(58, 137);
            this.再次输入密码label.Name = "再次输入密码label";
            this.再次输入密码label.Size = new System.Drawing.Size(83, 12);
            this.再次输入密码label.TabIndex = 3;
            this.再次输入密码label.Text = "再次输入密码";
            // 
            // 姓名label
            // 
            this.姓名label.AutoSize = true;
            this.姓名label.BackColor = System.Drawing.Color.Transparent;
            this.姓名label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.姓名label.ForeColor = System.Drawing.Color.Black;
            this.姓名label.Location = new System.Drawing.Point(58, 179);
            this.姓名label.Name = "姓名label";
            this.姓名label.Size = new System.Drawing.Size(31, 12);
            this.姓名label.TabIndex = 4;
            this.姓名label.Text = "姓名";
            // 
            // 手机label
            // 
            this.手机label.AutoSize = true;
            this.手机label.BackColor = System.Drawing.Color.Transparent;
            this.手机label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.手机label.Location = new System.Drawing.Point(58, 216);
            this.手机label.Name = "手机label";
            this.手机label.Size = new System.Drawing.Size(31, 12);
            this.手机label.TabIndex = 5;
            this.手机label.Text = "手机";
            // 
            // 邮箱label
            // 
            this.邮箱label.AutoSize = true;
            this.邮箱label.Location = new System.Drawing.Point(62, 250);
            this.邮箱label.Name = "邮箱label";
            this.邮箱label.Size = new System.Drawing.Size(0, 12);
            this.邮箱label.TabIndex = 6;
            // 
            // 注册button
            // 
            this.注册button.Location = new System.Drawing.Point(91, 336);
            this.注册button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.注册button.Name = "注册button";
            this.注册button.Size = new System.Drawing.Size(75, 22);
            this.注册button.TabIndex = 7;
            this.注册button.Text = "注册";
            this.注册button.UseVisualStyleBackColor = true;
            this.注册button.Click += new System.EventHandler(this.注册button_Click);
            // 
            // 取消button
            // 
            this.取消button.Location = new System.Drawing.Point(219, 336);
            this.取消button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.取消button.Name = "取消button";
            this.取消button.Size = new System.Drawing.Size(75, 22);
            this.取消button.TabIndex = 8;
            this.取消button.Text = "取消";
            this.取消button.UseVisualStyleBackColor = true;
            this.取消button.Click += new System.EventHandler(this.取消button_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(62, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "邮箱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(62, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "身份";
            // 
            // 注册界面Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(418, 370);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.取消button);
            this.Controls.Add(this.注册button);
            this.Controls.Add(this.邮箱label);
            this.Controls.Add(this.手机label);
            this.Controls.Add(this.姓名label);
            this.Controls.Add(this.再次输入密码label);
            this.Controls.Add(this.密码label);
            this.Controls.Add(this.账号label);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "注册界面Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册界面";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.注册界面Form_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox 邮箱textBox;
        private System.Windows.Forms.TextBox 手机textBox;
        private System.Windows.Forms.TextBox 姓名textBox;
        private System.Windows.Forms.TextBox 再次输入密码textBox;
        private System.Windows.Forms.TextBox 密码textBox;
        private System.Windows.Forms.TextBox 账号textBox;
        private System.Windows.Forms.Label 账号label;
        private System.Windows.Forms.Label 密码label;
        private System.Windows.Forms.Label 再次输入密码label;
        private System.Windows.Forms.Label 姓名label;
        private System.Windows.Forms.Label 手机label;
        private System.Windows.Forms.Label 邮箱label;
        private System.Windows.Forms.Button 注册button;
        private System.Windows.Forms.Button 取消button;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox 身份comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}