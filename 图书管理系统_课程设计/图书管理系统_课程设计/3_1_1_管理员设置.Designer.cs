namespace 图书管理系统_课程设计
{
    partial class 管理员设置Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(管理员设置Form));
            this.姓名textBox = new System.Windows.Forms.TextBox();
            this.帐号textBox = new System.Windows.Forms.TextBox();
            this.密码textBox = new System.Windows.Forms.TextBox();
            this.电话textBox = new System.Windows.Forms.TextBox();
            this.帐号label = new System.Windows.Forms.Label();
            this.密码label = new System.Windows.Forms.Label();
            this.姓名label = new System.Windows.Forms.Label();
            this.电话label = new System.Windows.Forms.Label();
            this.密码button = new System.Windows.Forms.Button();
            this.电话button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 姓名textBox
            // 
            this.姓名textBox.Location = new System.Drawing.Point(213, 49);
            this.姓名textBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.姓名textBox.Name = "姓名textBox";
            this.姓名textBox.ReadOnly = true;
            this.姓名textBox.Size = new System.Drawing.Size(115, 21);
            this.姓名textBox.TabIndex = 0;
            // 
            // 帐号textBox
            // 
            this.帐号textBox.Location = new System.Drawing.Point(213, 100);
            this.帐号textBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.帐号textBox.Name = "帐号textBox";
            this.帐号textBox.ReadOnly = true;
            this.帐号textBox.Size = new System.Drawing.Size(115, 21);
            this.帐号textBox.TabIndex = 1;
            // 
            // 密码textBox
            // 
            this.密码textBox.Location = new System.Drawing.Point(213, 151);
            this.密码textBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.密码textBox.Name = "密码textBox";
            this.密码textBox.PasswordChar = '*';
            this.密码textBox.Size = new System.Drawing.Size(115, 21);
            this.密码textBox.TabIndex = 2;
            // 
            // 电话textBox
            // 
            this.电话textBox.Location = new System.Drawing.Point(213, 200);
            this.电话textBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.电话textBox.Name = "电话textBox";
            this.电话textBox.Size = new System.Drawing.Size(115, 21);
            this.电话textBox.TabIndex = 3;
            // 
            // 帐号label
            // 
            this.帐号label.AutoSize = true;
            this.帐号label.BackColor = System.Drawing.Color.Transparent;
            this.帐号label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.帐号label.Location = new System.Drawing.Point(133, 101);
            this.帐号label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.帐号label.Name = "帐号label";
            this.帐号label.Size = new System.Drawing.Size(31, 12);
            this.帐号label.TabIndex = 4;
            this.帐号label.Text = "帐号";
            // 
            // 密码label
            // 
            this.密码label.AutoSize = true;
            this.密码label.BackColor = System.Drawing.Color.Transparent;
            this.密码label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.密码label.Location = new System.Drawing.Point(133, 153);
            this.密码label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.密码label.Name = "密码label";
            this.密码label.Size = new System.Drawing.Size(31, 12);
            this.密码label.TabIndex = 5;
            this.密码label.Text = "密码";
            // 
            // 姓名label
            // 
            this.姓名label.AutoSize = true;
            this.姓名label.BackColor = System.Drawing.Color.Transparent;
            this.姓名label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.姓名label.Location = new System.Drawing.Point(133, 52);
            this.姓名label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.姓名label.Name = "姓名label";
            this.姓名label.Size = new System.Drawing.Size(31, 12);
            this.姓名label.TabIndex = 6;
            this.姓名label.Text = "姓名";
            // 
            // 电话label
            // 
            this.电话label.AutoSize = true;
            this.电话label.BackColor = System.Drawing.Color.Transparent;
            this.电话label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.电话label.Location = new System.Drawing.Point(133, 201);
            this.电话label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.电话label.Name = "电话label";
            this.电话label.Size = new System.Drawing.Size(31, 12);
            this.电话label.TabIndex = 7;
            this.电话label.Text = "电话";
            // 
            // 密码button
            // 
            this.密码button.Location = new System.Drawing.Point(367, 151);
            this.密码button.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.密码button.Name = "密码button";
            this.密码button.Size = new System.Drawing.Size(60, 19);
            this.密码button.TabIndex = 8;
            this.密码button.Text = "修改";
            this.密码button.UseVisualStyleBackColor = true;
            this.密码button.Click += new System.EventHandler(this.密码button_Click);
            // 
            // 电话button
            // 
            this.电话button.Location = new System.Drawing.Point(367, 200);
            this.电话button.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.电话button.Name = "电话button";
            this.电话button.Size = new System.Drawing.Size(60, 19);
            this.电话button.TabIndex = 9;
            this.电话button.Text = "修改";
            this.电话button.UseVisualStyleBackColor = true;
            this.电话button.Click += new System.EventHandler(this.电话button_Click);
            // 
            // 管理员设置Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(519, 363);
            this.Controls.Add(this.电话button);
            this.Controls.Add(this.密码button);
            this.Controls.Add(this.电话label);
            this.Controls.Add(this.姓名label);
            this.Controls.Add(this.密码label);
            this.Controls.Add(this.帐号label);
            this.Controls.Add(this.电话textBox);
            this.Controls.Add(this.密码textBox);
            this.Controls.Add(this.帐号textBox);
            this.Controls.Add(this.姓名textBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.Name = "管理员设置Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员设置";
            this.Load += new System.EventHandler(this.管理员设置Form_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.管理员设置Form_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox 姓名textBox;
        private System.Windows.Forms.TextBox 帐号textBox;
        private System.Windows.Forms.TextBox 密码textBox;
        private System.Windows.Forms.TextBox 电话textBox;
        private System.Windows.Forms.Label 帐号label;
        private System.Windows.Forms.Label 密码label;
        private System.Windows.Forms.Label 姓名label;
        private System.Windows.Forms.Label 电话label;
        private System.Windows.Forms.Button 密码button;
        private System.Windows.Forms.Button 电话button;
    }
}