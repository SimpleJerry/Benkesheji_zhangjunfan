namespace 二手书交易系统_课程设计
{
    partial class 历史订单查询_卖Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.查询textBox = new System.Windows.Forms.TextBox();
            this.查询button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.快递单号textBox = new System.Windows.Forms.TextBox();
            this.快递单号label = new System.Windows.Forms.Label();
            this.收货地址textBox = new System.Windows.Forms.TextBox();
            this.收货地址label = new System.Windows.Forms.Label();
            this.账户余额textBox = new System.Windows.Forms.TextBox();
            this.账户余额label = new System.Windows.Forms.Label();
            this.买家IDtextBox = new System.Windows.Forms.TextBox();
            this.买家IDlabel = new System.Windows.Forms.Label();
            this.买家昵称textBox = new System.Windows.Forms.TextBox();
            this.买家昵称label = new System.Windows.Forms.Label();
            this.订单状态textBox = new System.Windows.Forms.TextBox();
            this.订单状态label = new System.Windows.Forms.Label();
            this.价格textBox = new System.Windows.Forms.TextBox();
            this.价格label = new System.Windows.Forms.Label();
            this.交易时间textBox = new System.Windows.Forms.TextBox();
            this.数量label = new System.Windows.Forms.Label();
            this.交易时间label = new System.Windows.Forms.Label();
            this.货物编号label = new System.Windows.Forms.Label();
            this.书名label = new System.Windows.Forms.Label();
            this.订单号label = new System.Windows.Forms.Label();
            this.数量textBox = new System.Windows.Forms.TextBox();
            this.货物编号textBox = new System.Windows.Forms.TextBox();
            this.书名textBox = new System.Windows.Forms.TextBox();
            this.订单号textBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(57, 730);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 18);
            this.label1.TabIndex = 268;
            this.label1.Text = "订单号/货物编号/订单状态";
            // 
            // 查询textBox
            // 
            this.查询textBox.Location = new System.Drawing.Point(352, 725);
            this.查询textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.查询textBox.Name = "查询textBox";
            this.查询textBox.Size = new System.Drawing.Size(150, 28);
            this.查询textBox.TabIndex = 267;
            this.查询textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.查询textBox.Click += new System.EventHandler(this.查询textBox_Click);
            // 
            // 查询button
            // 
            this.查询button.Location = new System.Drawing.Point(542, 725);
            this.查询button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.查询button.Name = "查询button";
            this.查询button.Size = new System.Drawing.Size(105, 35);
            this.查询button.TabIndex = 266;
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
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 380);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1255, 315);
            this.dataGridView1.TabIndex = 265;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // 快递单号textBox
            // 
            this.快递单号textBox.BackColor = System.Drawing.Color.AliceBlue;
            this.快递单号textBox.Location = new System.Drawing.Point(161, 184);
            this.快递单号textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.快递单号textBox.Name = "快递单号textBox";
            this.快递单号textBox.ReadOnly = true;
            this.快递单号textBox.Size = new System.Drawing.Size(150, 28);
            this.快递单号textBox.TabIndex = 337;
            // 
            // 快递单号label
            // 
            this.快递单号label.AutoSize = true;
            this.快递单号label.BackColor = System.Drawing.Color.Transparent;
            this.快递单号label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.快递单号label.ForeColor = System.Drawing.Color.Black;
            this.快递单号label.Location = new System.Drawing.Point(57, 194);
            this.快递单号label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.快递单号label.Name = "快递单号label";
            this.快递单号label.Size = new System.Drawing.Size(84, 18);
            this.快递单号label.TabIndex = 336;
            this.快递单号label.Text = "快递单号";
            // 
            // 收货地址textBox
            // 
            this.收货地址textBox.BackColor = System.Drawing.Color.AliceBlue;
            this.收货地址textBox.Location = new System.Drawing.Point(445, 254);
            this.收货地址textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.收货地址textBox.Name = "收货地址textBox";
            this.收货地址textBox.ReadOnly = true;
            this.收货地址textBox.Size = new System.Drawing.Size(205, 28);
            this.收货地址textBox.TabIndex = 335;
            // 
            // 收货地址label
            // 
            this.收货地址label.AutoSize = true;
            this.收货地址label.BackColor = System.Drawing.Color.Transparent;
            this.收货地址label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.收货地址label.ForeColor = System.Drawing.Color.Black;
            this.收货地址label.Location = new System.Drawing.Point(350, 264);
            this.收货地址label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.收货地址label.Name = "收货地址label";
            this.收货地址label.Size = new System.Drawing.Size(84, 18);
            this.收货地址label.TabIndex = 334;
            this.收货地址label.Text = "收货地址";
            // 
            // 账户余额textBox
            // 
            this.账户余额textBox.BackColor = System.Drawing.Color.AliceBlue;
            this.账户余额textBox.Location = new System.Drawing.Point(796, 114);
            this.账户余额textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.账户余额textBox.Name = "账户余额textBox";
            this.账户余额textBox.ReadOnly = true;
            this.账户余额textBox.Size = new System.Drawing.Size(135, 28);
            this.账户余额textBox.TabIndex = 333;
            // 
            // 账户余额label
            // 
            this.账户余额label.AutoSize = true;
            this.账户余额label.BackColor = System.Drawing.Color.Transparent;
            this.账户余额label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.账户余额label.ForeColor = System.Drawing.Color.Black;
            this.账户余额label.Location = new System.Drawing.Point(690, 124);
            this.账户余额label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.账户余额label.Name = "账户余额label";
            this.账户余额label.Size = new System.Drawing.Size(84, 18);
            this.账户余额label.TabIndex = 332;
            this.账户余额label.Text = "账户余额";
            // 
            // 买家IDtextBox
            // 
            this.买家IDtextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.买家IDtextBox.Location = new System.Drawing.Point(445, 39);
            this.买家IDtextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.买家IDtextBox.Name = "买家IDtextBox";
            this.买家IDtextBox.ReadOnly = true;
            this.买家IDtextBox.Size = new System.Drawing.Size(205, 28);
            this.买家IDtextBox.TabIndex = 331;
            // 
            // 买家IDlabel
            // 
            this.买家IDlabel.AutoSize = true;
            this.买家IDlabel.BackColor = System.Drawing.Color.Transparent;
            this.买家IDlabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.买家IDlabel.ForeColor = System.Drawing.Color.Black;
            this.买家IDlabel.Location = new System.Drawing.Point(350, 49);
            this.买家IDlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.买家IDlabel.Name = "买家IDlabel";
            this.买家IDlabel.Size = new System.Drawing.Size(66, 18);
            this.买家IDlabel.TabIndex = 330;
            this.买家IDlabel.Text = "买家ID";
            // 
            // 买家昵称textBox
            // 
            this.买家昵称textBox.BackColor = System.Drawing.Color.AliceBlue;
            this.买家昵称textBox.Location = new System.Drawing.Point(796, 39);
            this.买家昵称textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.买家昵称textBox.Name = "买家昵称textBox";
            this.买家昵称textBox.ReadOnly = true;
            this.买家昵称textBox.Size = new System.Drawing.Size(135, 28);
            this.买家昵称textBox.TabIndex = 329;
            // 
            // 买家昵称label
            // 
            this.买家昵称label.AutoSize = true;
            this.买家昵称label.BackColor = System.Drawing.Color.Transparent;
            this.买家昵称label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.买家昵称label.ForeColor = System.Drawing.Color.Black;
            this.买家昵称label.Location = new System.Drawing.Point(690, 49);
            this.买家昵称label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.买家昵称label.Name = "买家昵称label";
            this.买家昵称label.Size = new System.Drawing.Size(84, 18);
            this.买家昵称label.TabIndex = 328;
            this.买家昵称label.Text = "买家昵称";
            // 
            // 订单状态textBox
            // 
            this.订单状态textBox.BackColor = System.Drawing.Color.AliceBlue;
            this.订单状态textBox.Location = new System.Drawing.Point(161, 254);
            this.订单状态textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.订单状态textBox.Name = "订单状态textBox";
            this.订单状态textBox.ReadOnly = true;
            this.订单状态textBox.Size = new System.Drawing.Size(150, 28);
            this.订单状态textBox.TabIndex = 327;
            // 
            // 订单状态label
            // 
            this.订单状态label.AutoSize = true;
            this.订单状态label.BackColor = System.Drawing.Color.Transparent;
            this.订单状态label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.订单状态label.ForeColor = System.Drawing.Color.Black;
            this.订单状态label.Location = new System.Drawing.Point(57, 264);
            this.订单状态label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.订单状态label.Name = "订单状态label";
            this.订单状态label.Size = new System.Drawing.Size(84, 18);
            this.订单状态label.TabIndex = 326;
            this.订单状态label.Text = "订单状态";
            // 
            // 价格textBox
            // 
            this.价格textBox.BackColor = System.Drawing.Color.AliceBlue;
            this.价格textBox.Location = new System.Drawing.Point(796, 186);
            this.价格textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.价格textBox.Name = "价格textBox";
            this.价格textBox.ReadOnly = true;
            this.价格textBox.Size = new System.Drawing.Size(135, 28);
            this.价格textBox.TabIndex = 325;
            // 
            // 价格label
            // 
            this.价格label.AutoSize = true;
            this.价格label.BackColor = System.Drawing.Color.Transparent;
            this.价格label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.价格label.ForeColor = System.Drawing.Color.Black;
            this.价格label.Location = new System.Drawing.Point(690, 194);
            this.价格label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.价格label.Name = "价格label";
            this.价格label.Size = new System.Drawing.Size(46, 18);
            this.价格label.TabIndex = 324;
            this.价格label.Text = "价格";
            // 
            // 交易时间textBox
            // 
            this.交易时间textBox.BackColor = System.Drawing.Color.AliceBlue;
            this.交易时间textBox.Location = new System.Drawing.Point(445, 184);
            this.交易时间textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.交易时间textBox.Name = "交易时间textBox";
            this.交易时间textBox.ReadOnly = true;
            this.交易时间textBox.Size = new System.Drawing.Size(205, 28);
            this.交易时间textBox.TabIndex = 323;
            // 
            // 数量label
            // 
            this.数量label.AutoSize = true;
            this.数量label.BackColor = System.Drawing.Color.Transparent;
            this.数量label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.数量label.ForeColor = System.Drawing.Color.Black;
            this.数量label.Location = new System.Drawing.Point(690, 264);
            this.数量label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.数量label.Name = "数量label";
            this.数量label.Size = new System.Drawing.Size(46, 18);
            this.数量label.TabIndex = 322;
            this.数量label.Text = "数量";
            // 
            // 交易时间label
            // 
            this.交易时间label.AutoSize = true;
            this.交易时间label.BackColor = System.Drawing.Color.Transparent;
            this.交易时间label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.交易时间label.ForeColor = System.Drawing.Color.Black;
            this.交易时间label.Location = new System.Drawing.Point(350, 194);
            this.交易时间label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.交易时间label.Name = "交易时间label";
            this.交易时间label.Size = new System.Drawing.Size(84, 18);
            this.交易时间label.TabIndex = 321;
            this.交易时间label.Text = "交易时间";
            // 
            // 货物编号label
            // 
            this.货物编号label.AutoSize = true;
            this.货物编号label.BackColor = System.Drawing.Color.Transparent;
            this.货物编号label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.货物编号label.ForeColor = System.Drawing.Color.Black;
            this.货物编号label.Location = new System.Drawing.Point(57, 124);
            this.货物编号label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.货物编号label.Name = "货物编号label";
            this.货物编号label.Size = new System.Drawing.Size(84, 18);
            this.货物编号label.TabIndex = 320;
            this.货物编号label.Text = "货物编号";
            // 
            // 书名label
            // 
            this.书名label.AutoSize = true;
            this.书名label.BackColor = System.Drawing.Color.Transparent;
            this.书名label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.书名label.ForeColor = System.Drawing.Color.Black;
            this.书名label.Location = new System.Drawing.Point(350, 124);
            this.书名label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.书名label.Name = "书名label";
            this.书名label.Size = new System.Drawing.Size(46, 18);
            this.书名label.TabIndex = 319;
            this.书名label.Text = "书名";
            // 
            // 订单号label
            // 
            this.订单号label.AutoSize = true;
            this.订单号label.BackColor = System.Drawing.Color.Transparent;
            this.订单号label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.订单号label.ForeColor = System.Drawing.Color.Black;
            this.订单号label.Location = new System.Drawing.Point(57, 49);
            this.订单号label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.订单号label.Name = "订单号label";
            this.订单号label.Size = new System.Drawing.Size(65, 18);
            this.订单号label.TabIndex = 318;
            this.订单号label.Text = "订单号";
            // 
            // 数量textBox
            // 
            this.数量textBox.BackColor = System.Drawing.Color.AliceBlue;
            this.数量textBox.Location = new System.Drawing.Point(796, 254);
            this.数量textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.数量textBox.Name = "数量textBox";
            this.数量textBox.ReadOnly = true;
            this.数量textBox.Size = new System.Drawing.Size(135, 28);
            this.数量textBox.TabIndex = 317;
            // 
            // 货物编号textBox
            // 
            this.货物编号textBox.BackColor = System.Drawing.Color.AliceBlue;
            this.货物编号textBox.Location = new System.Drawing.Point(161, 114);
            this.货物编号textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.货物编号textBox.Name = "货物编号textBox";
            this.货物编号textBox.ReadOnly = true;
            this.货物编号textBox.Size = new System.Drawing.Size(150, 28);
            this.货物编号textBox.TabIndex = 316;
            // 
            // 书名textBox
            // 
            this.书名textBox.BackColor = System.Drawing.Color.AliceBlue;
            this.书名textBox.Location = new System.Drawing.Point(445, 114);
            this.书名textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.书名textBox.Name = "书名textBox";
            this.书名textBox.ReadOnly = true;
            this.书名textBox.Size = new System.Drawing.Size(205, 28);
            this.书名textBox.TabIndex = 315;
            // 
            // 订单号textBox
            // 
            this.订单号textBox.BackColor = System.Drawing.Color.AliceBlue;
            this.订单号textBox.Location = new System.Drawing.Point(161, 39);
            this.订单号textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.订单号textBox.Name = "订单号textBox";
            this.订单号textBox.ReadOnly = true;
            this.订单号textBox.Size = new System.Drawing.Size(150, 28);
            this.订单号textBox.TabIndex = 314;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::二手书交易系统_课程设计.Properties.Resources.历史订单_用户;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.订单号label);
            this.panel1.Controls.Add(this.快递单号textBox);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.快递单号label);
            this.panel1.Controls.Add(this.查询button);
            this.panel1.Controls.Add(this.收货地址textBox);
            this.panel1.Controls.Add(this.查询textBox);
            this.panel1.Controls.Add(this.收货地址label);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.账户余额textBox);
            this.panel1.Controls.Add(this.订单号textBox);
            this.panel1.Controls.Add(this.账户余额label);
            this.panel1.Controls.Add(this.书名textBox);
            this.panel1.Controls.Add(this.买家IDtextBox);
            this.panel1.Controls.Add(this.货物编号textBox);
            this.panel1.Controls.Add(this.买家IDlabel);
            this.panel1.Controls.Add(this.数量textBox);
            this.panel1.Controls.Add(this.买家昵称textBox);
            this.panel1.Controls.Add(this.书名label);
            this.panel1.Controls.Add(this.买家昵称label);
            this.panel1.Controls.Add(this.货物编号label);
            this.panel1.Controls.Add(this.订单状态textBox);
            this.panel1.Controls.Add(this.交易时间label);
            this.panel1.Controls.Add(this.订单状态label);
            this.panel1.Controls.Add(this.数量label);
            this.panel1.Controls.Add(this.价格textBox);
            this.panel1.Controls.Add(this.交易时间textBox);
            this.panel1.Controls.Add(this.价格label);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 770);
            this.panel1.TabIndex = 338;
            // 
            // 历史订单查询_卖Form
            // 
            this.AcceptButton = this.查询button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 769);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "历史订单查询_卖Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "历史订单查询";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.历史订单查询_卖Form_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox 查询textBox;
        private System.Windows.Forms.Button 查询button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox 快递单号textBox;
        private System.Windows.Forms.Label 快递单号label;
        private System.Windows.Forms.TextBox 收货地址textBox;
        private System.Windows.Forms.Label 收货地址label;
        private System.Windows.Forms.TextBox 账户余额textBox;
        private System.Windows.Forms.Label 账户余额label;
        private System.Windows.Forms.TextBox 买家IDtextBox;
        private System.Windows.Forms.Label 买家IDlabel;
        private System.Windows.Forms.TextBox 买家昵称textBox;
        private System.Windows.Forms.Label 买家昵称label;
        private System.Windows.Forms.TextBox 订单状态textBox;
        private System.Windows.Forms.Label 订单状态label;
        private System.Windows.Forms.TextBox 价格textBox;
        private System.Windows.Forms.Label 价格label;
        private System.Windows.Forms.TextBox 交易时间textBox;
        private System.Windows.Forms.Label 数量label;
        private System.Windows.Forms.Label 交易时间label;
        private System.Windows.Forms.Label 货物编号label;
        private System.Windows.Forms.Label 书名label;
        private System.Windows.Forms.Label 订单号label;
        private System.Windows.Forms.TextBox 数量textBox;
        private System.Windows.Forms.TextBox 货物编号textBox;
        private System.Windows.Forms.TextBox 书名textBox;
        private System.Windows.Forms.TextBox 订单号textBox;
        private System.Windows.Forms.Panel panel1;
    }
}