namespace 二手书交易系统_课程设计
{
    partial class 修改密码Form
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
            this.原密码label = new System.Windows.Forms.Label();
            this.原密码textBox = new System.Windows.Forms.TextBox();
            this.新密码label = new System.Windows.Forms.Label();
            this.新密码textBox = new System.Windows.Forms.TextBox();
            this.验证密码label = new System.Windows.Forms.Label();
            this.验证密码textBox = new System.Windows.Forms.TextBox();
            this.取消button = new System.Windows.Forms.Button();
            this.确认修改button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 原密码label
            // 
            this.原密码label.AutoSize = true;
            this.原密码label.BackColor = System.Drawing.Color.Transparent;
            this.原密码label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.原密码label.Location = new System.Drawing.Point(226, 104);
            this.原密码label.Name = "原密码label";
            this.原密码label.Size = new System.Drawing.Size(141, 18);
            this.原密码label.TabIndex = 3;
            this.原密码label.Text = "请输入原密码：";
            // 
            // 原密码textBox
            // 
            this.原密码textBox.Location = new System.Drawing.Point(393, 100);
            this.原密码textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.原密码textBox.Name = "原密码textBox";
            this.原密码textBox.Size = new System.Drawing.Size(146, 28);
            this.原密码textBox.TabIndex = 0;
            // 
            // 新密码label
            // 
            this.新密码label.AutoSize = true;
            this.新密码label.BackColor = System.Drawing.Color.Transparent;
            this.新密码label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.新密码label.ForeColor = System.Drawing.Color.Black;
            this.新密码label.Location = new System.Drawing.Point(226, 166);
            this.新密码label.Name = "新密码label";
            this.新密码label.Size = new System.Drawing.Size(141, 18);
            this.新密码label.TabIndex = 4;
            this.新密码label.Text = "请输入新密码：";
            // 
            // 新密码textBox
            // 
            this.新密码textBox.Location = new System.Drawing.Point(393, 156);
            this.新密码textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.新密码textBox.Name = "新密码textBox";
            this.新密码textBox.PasswordChar = '*';
            this.新密码textBox.Size = new System.Drawing.Size(146, 28);
            this.新密码textBox.TabIndex = 1;
            // 
            // 验证密码label
            // 
            this.验证密码label.AutoSize = true;
            this.验证密码label.BackColor = System.Drawing.Color.Transparent;
            this.验证密码label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.验证密码label.Location = new System.Drawing.Point(208, 230);
            this.验证密码label.Name = "验证密码label";
            this.验证密码label.Size = new System.Drawing.Size(160, 18);
            this.验证密码label.TabIndex = 5;
            this.验证密码label.Text = "请再次输入密码：";
            // 
            // 验证密码textBox
            // 
            this.验证密码textBox.Location = new System.Drawing.Point(393, 218);
            this.验证密码textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.验证密码textBox.Name = "验证密码textBox";
            this.验证密码textBox.PasswordChar = '*';
            this.验证密码textBox.Size = new System.Drawing.Size(146, 28);
            this.验证密码textBox.TabIndex = 2;
            // 
            // 取消button
            // 
            this.取消button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.取消button.Location = new System.Drawing.Point(420, 294);
            this.取消button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.取消button.Name = "取消button";
            this.取消button.Size = new System.Drawing.Size(135, 56);
            this.取消button.TabIndex = 7;
            this.取消button.Text = "取消";
            this.取消button.UseVisualStyleBackColor = true;
            this.取消button.Click += new System.EventHandler(this.取消button_Click);
            // 
            // 确认修改button
            // 
            this.确认修改button.Location = new System.Drawing.Point(230, 294);
            this.确认修改button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.确认修改button.Name = "确认修改button";
            this.确认修改button.Size = new System.Drawing.Size(135, 56);
            this.确认修改button.TabIndex = 6;
            this.确认修改button.Text = "确认修改";
            this.确认修改button.UseVisualStyleBackColor = true;
            this.确认修改button.Click += new System.EventHandler(this.确认修改button_Click);
            // 
            // 修改密码Form
            // 
            this.AcceptButton = this.确认修改button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.取消button;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.取消button);
            this.Controls.Add(this.确认修改button);
            this.Controls.Add(this.验证密码textBox);
            this.Controls.Add(this.验证密码label);
            this.Controls.Add(this.新密码textBox);
            this.Controls.Add(this.新密码label);
            this.Controls.Add(this.原密码textBox);
            this.Controls.Add(this.原密码label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "修改密码Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.修改密码Form_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 原密码label;
        private System.Windows.Forms.TextBox 原密码textBox;
        private System.Windows.Forms.Label 新密码label;
        private System.Windows.Forms.TextBox 新密码textBox;
        private System.Windows.Forms.Label 验证密码label;
        private System.Windows.Forms.TextBox 验证密码textBox;
        private System.Windows.Forms.Button 取消button;
        private System.Windows.Forms.Button 确认修改button;
    }
}