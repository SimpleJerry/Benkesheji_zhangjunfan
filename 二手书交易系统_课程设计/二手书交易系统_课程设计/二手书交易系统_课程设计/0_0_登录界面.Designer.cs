namespace 二手书交易系统_课程设计
{
    partial class 登录界面Form
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
            this.帐号Lable = new System.Windows.Forms.Label();
            this.帐号textBox = new System.Windows.Forms.TextBox();
            this.密码Lable = new System.Windows.Forms.Label();
            this.密码textBox = new System.Windows.Forms.TextBox();
            this.管理员radioButton = new System.Windows.Forms.RadioButton();
            this.用户radioButton = new System.Windows.Forms.RadioButton();
            this.忘记密码linkLabel = new System.Windows.Forms.LinkLabel();
            this.注册帐号linkLabel = new System.Windows.Forms.LinkLabel();
            this.进入button = new System.Windows.Forms.Button();
            this.退出button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 帐号Lable
            // 
            this.帐号Lable.AutoSize = true;
            this.帐号Lable.BackColor = System.Drawing.Color.Transparent;
            this.帐号Lable.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.帐号Lable.ForeColor = System.Drawing.Color.Black;
            this.帐号Lable.Location = new System.Drawing.Point(180, 145);
            this.帐号Lable.Name = "帐号Lable";
            this.帐号Lable.Size = new System.Drawing.Size(56, 22);
            this.帐号Lable.TabIndex = 4;
            this.帐号Lable.Text = "帐号";
            // 
            // 帐号textBox
            // 
            this.帐号textBox.BackColor = System.Drawing.SystemColors.Window;
            this.帐号textBox.Location = new System.Drawing.Point(268, 133);
            this.帐号textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.帐号textBox.MaxLength = 16;
            this.帐号textBox.Name = "帐号textBox";
            this.帐号textBox.Size = new System.Drawing.Size(205, 28);
            this.帐号textBox.TabIndex = 2;
            // 
            // 密码Lable
            // 
            this.密码Lable.AutoSize = true;
            this.密码Lable.BackColor = System.Drawing.Color.Transparent;
            this.密码Lable.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.密码Lable.ForeColor = System.Drawing.Color.Black;
            this.密码Lable.Location = new System.Drawing.Point(181, 297);
            this.密码Lable.Name = "密码Lable";
            this.密码Lable.Size = new System.Drawing.Size(56, 22);
            this.密码Lable.TabIndex = 5;
            this.密码Lable.Text = "密码";
            // 
            // 密码textBox
            // 
            this.密码textBox.BackColor = System.Drawing.SystemColors.Window;
            this.密码textBox.Location = new System.Drawing.Point(269, 285);
            this.密码textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.密码textBox.MaxLength = 16;
            this.密码textBox.Name = "密码textBox";
            this.密码textBox.PasswordChar = '*';
            this.密码textBox.Size = new System.Drawing.Size(205, 28);
            this.密码textBox.TabIndex = 3;
            // 
            // 管理员radioButton
            // 
            this.管理员radioButton.AutoSize = true;
            this.管理员radioButton.BackColor = System.Drawing.Color.Transparent;
            this.管理员radioButton.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.管理员radioButton.ForeColor = System.Drawing.Color.Black;
            this.管理员radioButton.Location = new System.Drawing.Point(236, 362);
            this.管理员radioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.管理员radioButton.Name = "管理员radioButton";
            this.管理员radioButton.Size = new System.Drawing.Size(104, 26);
            this.管理员radioButton.TabIndex = 6;
            this.管理员radioButton.TabStop = true;
            this.管理员radioButton.Text = "管理员";
            this.管理员radioButton.UseVisualStyleBackColor = false;
            this.管理员radioButton.CheckedChanged += new System.EventHandler(this.管理员radioButton_CheckedChanged);
            // 
            // 用户radioButton
            // 
            this.用户radioButton.AutoSize = true;
            this.用户radioButton.BackColor = System.Drawing.Color.Transparent;
            this.用户radioButton.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.用户radioButton.ForeColor = System.Drawing.Color.Black;
            this.用户radioButton.Location = new System.Drawing.Point(393, 362);
            this.用户radioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.用户radioButton.Name = "用户radioButton";
            this.用户radioButton.Size = new System.Drawing.Size(81, 26);
            this.用户radioButton.TabIndex = 7;
            this.用户radioButton.TabStop = true;
            this.用户radioButton.Text = "用户";
            this.用户radioButton.UseVisualStyleBackColor = false;
            this.用户radioButton.CheckedChanged += new System.EventHandler(this.用户radioButton_CheckedChanged);
            // 
            // 忘记密码linkLabel
            // 
            this.忘记密码linkLabel.AutoSize = true;
            this.忘记密码linkLabel.BackColor = System.Drawing.Color.Transparent;
            this.忘记密码linkLabel.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.忘记密码linkLabel.ForeColor = System.Drawing.Color.Black;
            this.忘记密码linkLabel.LinkColor = System.Drawing.Color.Black;
            this.忘记密码linkLabel.Location = new System.Drawing.Point(537, 287);
            this.忘记密码linkLabel.Name = "忘记密码linkLabel";
            this.忘记密码linkLabel.Size = new System.Drawing.Size(125, 22);
            this.忘记密码linkLabel.TabIndex = 10;
            this.忘记密码linkLabel.TabStop = true;
            this.忘记密码linkLabel.Text = "忘记密码？";
            this.忘记密码linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.忘记密码linkLabel_LinkClicked);
            // 
            // 注册帐号linkLabel
            // 
            this.注册帐号linkLabel.AutoSize = true;
            this.注册帐号linkLabel.BackColor = System.Drawing.Color.Transparent;
            this.注册帐号linkLabel.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.注册帐号linkLabel.ForeColor = System.Drawing.Color.Black;
            this.注册帐号linkLabel.LinkColor = System.Drawing.Color.Black;
            this.注册帐号linkLabel.Location = new System.Drawing.Point(536, 145);
            this.注册帐号linkLabel.Name = "注册帐号linkLabel";
            this.注册帐号linkLabel.Size = new System.Drawing.Size(102, 22);
            this.注册帐号linkLabel.TabIndex = 11;
            this.注册帐号linkLabel.TabStop = true;
            this.注册帐号linkLabel.Text = "注册帐号";
            this.注册帐号linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.注册帐号linkLabel_LinkClicked);
            // 
            // 进入button
            // 
            this.进入button.Location = new System.Drawing.Point(219, 464);
            this.进入button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.进入button.Name = "进入button";
            this.进入button.Size = new System.Drawing.Size(90, 49);
            this.进入button.TabIndex = 8;
            this.进入button.Text = "进入";
            this.进入button.UseVisualStyleBackColor = true;
            this.进入button.Click += new System.EventHandler(this.进入button_Click);
            // 
            // 退出button
            // 
            this.退出button.BackColor = System.Drawing.Color.Transparent;
            this.退出button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.退出button.Location = new System.Drawing.Point(350, 464);
            this.退出button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.退出button.Name = "退出button";
            this.退出button.Size = new System.Drawing.Size(90, 49);
            this.退出button.TabIndex = 9;
            this.退出button.Text = "退出";
            this.退出button.UseVisualStyleBackColor = false;
            this.退出button.Click += new System.EventHandler(this.退出button_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::二手书交易系统_课程设计.Properties.Resources.登录界面;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.帐号Lable);
            this.panel1.Controls.Add(this.退出button);
            this.panel1.Controls.Add(this.进入button);
            this.panel1.Controls.Add(this.密码textBox);
            this.panel1.Controls.Add(this.帐号textBox);
            this.panel1.Controls.Add(this.忘记密码linkLabel);
            this.panel1.Controls.Add(this.密码Lable);
            this.panel1.Controls.Add(this.用户radioButton);
            this.panel1.Controls.Add(this.管理员radioButton);
            this.panel1.Controls.Add(this.注册帐号linkLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 599);
            this.panel1.TabIndex = 12;
            // 
            // 登录界面Form
            // 
            this.AcceptButton = this.进入button;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.退出button;
            this.ClientSize = new System.Drawing.Size(818, 599);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "登录界面Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎登录";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.登录界面Form_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label 帐号Lable;
        private System.Windows.Forms.TextBox 帐号textBox;
        private System.Windows.Forms.Label 密码Lable;
        private System.Windows.Forms.TextBox 密码textBox;
        private System.Windows.Forms.RadioButton 管理员radioButton;
        private System.Windows.Forms.RadioButton 用户radioButton;
        private System.Windows.Forms.LinkLabel 忘记密码linkLabel;
        private System.Windows.Forms.LinkLabel 注册帐号linkLabel;
        private System.Windows.Forms.Button 进入button;
        private System.Windows.Forms.Button 退出button;
        private System.Windows.Forms.Panel panel1;
    }
}