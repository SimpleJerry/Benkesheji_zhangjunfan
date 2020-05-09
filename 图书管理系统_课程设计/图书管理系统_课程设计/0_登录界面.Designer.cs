namespace 图书管理系统_课程设计
{
    partial class 登录界面Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(登录界面Form));
            this.帐号textBox = new System.Windows.Forms.TextBox();
            this.密码textBox = new System.Windows.Forms.TextBox();
            this.帐号Lable = new System.Windows.Forms.Label();
            this.密码Lable = new System.Windows.Forms.Label();
            this.管理员radioButton = new System.Windows.Forms.RadioButton();
            this.读者radioButton = new System.Windows.Forms.RadioButton();
            this.进入button = new System.Windows.Forms.Button();
            this.退出button = new System.Windows.Forms.Button();
            this.忘记密码linkLabel = new System.Windows.Forms.LinkLabel();
            this.注册帐号linkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // 帐号textBox
            // 
            this.帐号textBox.BackColor = System.Drawing.Color.DarkGray;
            this.帐号textBox.Location = new System.Drawing.Point(188, 91);
            this.帐号textBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.帐号textBox.MaxLength = 16;
            this.帐号textBox.Name = "帐号textBox";
            this.帐号textBox.Size = new System.Drawing.Size(138, 21);
            this.帐号textBox.TabIndex = 2;
            // 
            // 密码textBox
            // 
            this.密码textBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.密码textBox.Location = new System.Drawing.Point(188, 157);
            this.密码textBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.密码textBox.MaxLength = 16;
            this.密码textBox.Name = "密码textBox";
            this.密码textBox.PasswordChar = '*';
            this.密码textBox.Size = new System.Drawing.Size(138, 21);
            this.密码textBox.TabIndex = 3;
            // 
            // 帐号Lable
            // 
            this.帐号Lable.AutoSize = true;
            this.帐号Lable.BackColor = System.Drawing.Color.Transparent;
            this.帐号Lable.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.帐号Lable.ForeColor = System.Drawing.Color.Black;
            this.帐号Lable.Location = new System.Drawing.Point(129, 99);
            this.帐号Lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.帐号Lable.Name = "帐号Lable";
            this.帐号Lable.Size = new System.Drawing.Size(39, 15);
            this.帐号Lable.TabIndex = 4;
            this.帐号Lable.Text = "帐号";
            // 
            // 密码Lable
            // 
            this.密码Lable.AutoSize = true;
            this.密码Lable.BackColor = System.Drawing.Color.Transparent;
            this.密码Lable.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.密码Lable.ForeColor = System.Drawing.Color.Black;
            this.密码Lable.Location = new System.Drawing.Point(129, 165);
            this.密码Lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.密码Lable.Name = "密码Lable";
            this.密码Lable.Size = new System.Drawing.Size(39, 15);
            this.密码Lable.TabIndex = 5;
            this.密码Lable.Text = "密码";
            // 
            // 管理员radioButton
            // 
            this.管理员radioButton.AutoSize = true;
            this.管理员radioButton.BackColor = System.Drawing.Color.Transparent;
            this.管理员radioButton.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.管理员radioButton.ForeColor = System.Drawing.Color.Black;
            this.管理员radioButton.Location = new System.Drawing.Point(166, 205);
            this.管理员radioButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.管理员radioButton.Name = "管理员radioButton";
            this.管理员radioButton.Size = new System.Drawing.Size(73, 19);
            this.管理员radioButton.TabIndex = 6;
            this.管理员radioButton.TabStop = true;
            this.管理员radioButton.Text = "管理员";
            this.管理员radioButton.UseVisualStyleBackColor = false;
            this.管理员radioButton.CheckedChanged += new System.EventHandler(this.管理员radioButton_CheckedChanged);
            // 
            // 读者radioButton
            // 
            this.读者radioButton.AutoSize = true;
            this.读者radioButton.BackColor = System.Drawing.Color.Transparent;
            this.读者radioButton.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.读者radioButton.ForeColor = System.Drawing.Color.Black;
            this.读者radioButton.Location = new System.Drawing.Point(282, 205);
            this.读者radioButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.读者radioButton.Name = "读者radioButton";
            this.读者radioButton.Size = new System.Drawing.Size(57, 19);
            this.读者radioButton.TabIndex = 7;
            this.读者radioButton.TabStop = true;
            this.读者radioButton.Text = "读者";
            this.读者radioButton.UseVisualStyleBackColor = false;
            this.读者radioButton.CheckedChanged += new System.EventHandler(this.读者radioButton_CheckedChanged);
            // 
            // 进入button
            // 
            this.进入button.Location = new System.Drawing.Point(127, 243);
            this.进入button.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.进入button.Name = "进入button";
            this.进入button.Size = new System.Drawing.Size(93, 33);
            this.进入button.TabIndex = 8;
            this.进入button.Text = "进入";
            this.进入button.UseVisualStyleBackColor = true;
            this.进入button.Click += new System.EventHandler(this.进入button_Click);
            // 
            // 退出button
            // 
            this.退出button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.退出button.Location = new System.Drawing.Point(282, 243);
            this.退出button.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.退出button.Name = "退出button";
            this.退出button.Size = new System.Drawing.Size(93, 33);
            this.退出button.TabIndex = 9;
            this.退出button.Text = "退出";
            this.退出button.UseVisualStyleBackColor = true;
            this.退出button.Click += new System.EventHandler(this.退出button_Click);
            // 
            // 忘记密码linkLabel
            // 
            this.忘记密码linkLabel.AutoSize = true;
            this.忘记密码linkLabel.BackColor = System.Drawing.Color.Transparent;
            this.忘记密码linkLabel.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.忘记密码linkLabel.ForeColor = System.Drawing.Color.Black;
            this.忘记密码linkLabel.LinkColor = System.Drawing.Color.Black;
            this.忘记密码linkLabel.Location = new System.Drawing.Point(367, 159);
            this.忘记密码linkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.忘记密码linkLabel.Name = "忘记密码linkLabel";
            this.忘记密码linkLabel.Size = new System.Drawing.Size(87, 15);
            this.忘记密码linkLabel.TabIndex = 10;
            this.忘记密码linkLabel.TabStop = true;
            this.忘记密码linkLabel.Text = "忘记密码？";
            // 
            // 注册帐号linkLabel
            // 
            this.注册帐号linkLabel.AutoSize = true;
            this.注册帐号linkLabel.BackColor = System.Drawing.Color.Transparent;
            this.注册帐号linkLabel.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.注册帐号linkLabel.ForeColor = System.Drawing.Color.Black;
            this.注册帐号linkLabel.LinkColor = System.Drawing.Color.Black;
            this.注册帐号linkLabel.Location = new System.Drawing.Point(367, 99);
            this.注册帐号linkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.注册帐号linkLabel.Name = "注册帐号linkLabel";
            this.注册帐号linkLabel.Size = new System.Drawing.Size(71, 15);
            this.注册帐号linkLabel.TabIndex = 11;
            this.注册帐号linkLabel.TabStop = true;
            this.注册帐号linkLabel.Text = "注册帐号";
            this.注册帐号linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.注册帐号linkLabel_LinkClicked);
            // 
            // 登录界面Form
            // 
            this.AcceptButton = this.进入button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.退出button;
            this.ClientSize = new System.Drawing.Size(519, 363);
            this.Controls.Add(this.注册帐号linkLabel);
            this.Controls.Add(this.忘记密码linkLabel);
            this.Controls.Add(this.退出button);
            this.Controls.Add(this.进入button);
            this.Controls.Add(this.读者radioButton);
            this.Controls.Add(this.管理员radioButton);
            this.Controls.Add(this.密码Lable);
            this.Controls.Add(this.帐号Lable);
            this.Controls.Add(this.密码textBox);
            this.Controls.Add(this.帐号textBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.Name = "登录界面Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎登录";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.登录界面Form_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox 帐号textBox;
        private System.Windows.Forms.TextBox 密码textBox;
        private System.Windows.Forms.Label 帐号Lable;
        private System.Windows.Forms.Label 密码Lable;
        private System.Windows.Forms.RadioButton 管理员radioButton;
        private System.Windows.Forms.RadioButton 读者radioButton;
        private System.Windows.Forms.Button 进入button;
        private System.Windows.Forms.Button 退出button;
        private System.Windows.Forms.LinkLabel 忘记密码linkLabel;
        private System.Windows.Forms.LinkLabel 注册帐号linkLabel;
    }
}

