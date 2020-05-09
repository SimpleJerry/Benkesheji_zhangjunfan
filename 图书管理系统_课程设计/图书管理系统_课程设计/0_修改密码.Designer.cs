namespace 图书管理系统_课程设计
{
    partial class 修改密码
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(修改密码));
            this.原密码textBox = new System.Windows.Forms.TextBox();
            this.新密码textBox = new System.Windows.Forms.TextBox();
            this.验证密码textBox = new System.Windows.Forms.TextBox();
            this.原密码label = new System.Windows.Forms.Label();
            this.新密码label = new System.Windows.Forms.Label();
            this.验证密码label = new System.Windows.Forms.Label();
            this.确认修改button = new System.Windows.Forms.Button();
            this.取消button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 原密码textBox
            // 
            this.原密码textBox.Location = new System.Drawing.Point(262, 67);
            this.原密码textBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.原密码textBox.Name = "原密码textBox";
            this.原密码textBox.Size = new System.Drawing.Size(99, 21);
            this.原密码textBox.TabIndex = 0;
            // 
            // 新密码textBox
            // 
            this.新密码textBox.Location = new System.Drawing.Point(262, 104);
            this.新密码textBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.新密码textBox.Name = "新密码textBox";
            this.新密码textBox.PasswordChar = '*';
            this.新密码textBox.Size = new System.Drawing.Size(99, 21);
            this.新密码textBox.TabIndex = 1;
            // 
            // 验证密码textBox
            // 
            this.验证密码textBox.Location = new System.Drawing.Point(262, 145);
            this.验证密码textBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.验证密码textBox.Name = "验证密码textBox";
            this.验证密码textBox.PasswordChar = '*';
            this.验证密码textBox.Size = new System.Drawing.Size(99, 21);
            this.验证密码textBox.TabIndex = 2;
            // 
            // 原密码label
            // 
            this.原密码label.AutoSize = true;
            this.原密码label.BackColor = System.Drawing.Color.Transparent;
            this.原密码label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.原密码label.Location = new System.Drawing.Point(151, 69);
            this.原密码label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.原密码label.Name = "原密码label";
            this.原密码label.Size = new System.Drawing.Size(96, 12);
            this.原密码label.TabIndex = 3;
            this.原密码label.Text = "请输入原密码：";
            // 
            // 新密码label
            // 
            this.新密码label.AutoSize = true;
            this.新密码label.BackColor = System.Drawing.Color.Transparent;
            this.新密码label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.新密码label.ForeColor = System.Drawing.Color.Black;
            this.新密码label.Location = new System.Drawing.Point(151, 111);
            this.新密码label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.新密码label.Name = "新密码label";
            this.新密码label.Size = new System.Drawing.Size(96, 12);
            this.新密码label.TabIndex = 4;
            this.新密码label.Text = "请输入新密码：";
            // 
            // 验证密码label
            // 
            this.验证密码label.AutoSize = true;
            this.验证密码label.BackColor = System.Drawing.Color.Transparent;
            this.验证密码label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.验证密码label.Location = new System.Drawing.Point(139, 153);
            this.验证密码label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.验证密码label.Name = "验证密码label";
            this.验证密码label.Size = new System.Drawing.Size(109, 12);
            this.验证密码label.TabIndex = 5;
            this.验证密码label.Text = "请再次输入密码：";
            // 
            // 确认修改button
            // 
            this.确认修改button.Location = new System.Drawing.Point(153, 196);
            this.确认修改button.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.确认修改button.Name = "确认修改button";
            this.确认修改button.Size = new System.Drawing.Size(90, 37);
            this.确认修改button.TabIndex = 6;
            this.确认修改button.Text = "确认修改";
            this.确认修改button.UseVisualStyleBackColor = true;
            // 
            // 取消button
            // 
            this.取消button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.取消button.Location = new System.Drawing.Point(280, 196);
            this.取消button.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.取消button.Name = "取消button";
            this.取消button.Size = new System.Drawing.Size(90, 37);
            this.取消button.TabIndex = 7;
            this.取消button.Text = "取消";
            this.取消button.UseVisualStyleBackColor = true;
            // 
            // 修改密码
            // 
            this.AcceptButton = this.确认修改button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.取消button;
            this.ClientSize = new System.Drawing.Size(519, 363);
            this.Controls.Add(this.取消button);
            this.Controls.Add(this.确认修改button);
            this.Controls.Add(this.验证密码label);
            this.Controls.Add(this.新密码label);
            this.Controls.Add(this.原密码label);
            this.Controls.Add(this.验证密码textBox);
            this.Controls.Add(this.新密码textBox);
            this.Controls.Add(this.原密码textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.Name = "修改密码";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.修改密码_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox 原密码textBox;
        private System.Windows.Forms.TextBox 新密码textBox;
        private System.Windows.Forms.TextBox 验证密码textBox;
        private System.Windows.Forms.Label 原密码label;
        private System.Windows.Forms.Label 新密码label;
        private System.Windows.Forms.Label 验证密码label;
        private System.Windows.Forms.Button 确认修改button;
        private System.Windows.Forms.Button 取消button;
    }
}