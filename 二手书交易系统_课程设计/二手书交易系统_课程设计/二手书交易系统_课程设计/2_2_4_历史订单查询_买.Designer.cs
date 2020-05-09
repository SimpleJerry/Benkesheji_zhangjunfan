namespace 二手书交易系统_课程设计
{
    partial class 历史订单查询_买Form
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
            this.卖家IDtextBox = new System.Windows.Forms.TextBox();
            this.卖家IDlabel = new System.Windows.Forms.Label();
            this.卖家昵称textBox = new System.Windows.Forms.TextBox();
            this.卖家昵称label = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(60, 731);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 18);
            this.label1.TabIndex = 237;
            this.label1.Text = "订单号/货物编号/订单状态";
            // 
            // 查询textBox
            // 
            this.查询textBox.Location = new System.Drawing.Point(357, 726);
            this.查询textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.查询textBox.Name = "查询textBox";
            this.查询textBox.Size = new System.Drawing.Size(150, 28);
            this.查询textBox.TabIndex = 236;
            this.查询textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.查询textBox.Click += new System.EventHandler(this.查询textBox_Click);
            // 
            // 查询button
            // 
            this.查询button.Location = new System.Drawing.Point(547, 726);
            this.查询button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.查询button.Name = "查询button";
            this.查询button.Size = new System.Drawing.Size(105, 35);
            this.查询button.TabIndex = 235;
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 381);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1255, 315);
            this.dataGridView1.TabIndex = 234;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // 快递单号textBox
            // 
            this.快递单号textBox.BackColor = System.Drawing.Color.AliceBlue;
            this.快递单号textBox.Location = new System.Drawing.Point(164, 185);
            this.快递单号textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.快递单号textBox.Name = "快递单号textBox";
            this.快递单号textBox.ReadOnly = true;
            this.快递单号textBox.Size = new System.Drawing.Size(150, 28);
            this.快递单号textBox.TabIndex = 289;
            // 
            // 快递单号label
            // 
            this.快递单号label.AutoSize = true;
            this.快递单号label.BackColor = System.Drawing.Color.Transparent;
            this.快递单号label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.快递单号label.ForeColor = System.Drawing.Color.Black;
            this.快递单号label.Location = new System.Drawing.Point(60, 195);
            this.快递单号label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.快递单号label.Name = "快递单号label";
            this.快递单号label.Size = new System.Drawing.Size(84, 18);
            this.快递单号label.TabIndex = 288;
            this.快递单号label.Text = "快递单号";
            // 
            // 收货地址textBox
            // 
            this.收货地址textBox.BackColor = System.Drawing.Color.AliceBlue;
            this.收货地址textBox.Location = new System.Drawing.Point(448, 255);
            this.收货地址textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.收货地址textBox.Name = "收货地址textBox";
            this.收货地址textBox.ReadOnly = true;
            this.收货地址textBox.Size = new System.Drawing.Size(205, 28);
            this.收货地址textBox.TabIndex = 287;
            // 
            // 收货地址label
            // 
            this.收货地址label.AutoSize = true;
            this.收货地址label.BackColor = System.Drawing.Color.Transparent;
            this.收货地址label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.收货地址label.ForeColor = System.Drawing.Color.Black;
            this.收货地址label.Location = new System.Drawing.Point(353, 265);
            this.收货地址label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.收货地址label.Name = "收货地址label";
            this.收货地址label.Size = new System.Drawing.Size(84, 18);
            this.收货地址label.TabIndex = 286;
            this.收货地址label.Text = "收货地址";
            // 
            // 账户余额textBox
            // 
            this.账户余额textBox.BackColor = System.Drawing.Color.AliceBlue;
            this.账户余额textBox.Location = new System.Drawing.Point(799, 115);
            this.账户余额textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.账户余额textBox.Name = "账户余额textBox";
            this.账户余额textBox.ReadOnly = true;
            this.账户余额textBox.Size = new System.Drawing.Size(135, 28);
            this.账户余额textBox.TabIndex = 285;
            // 
            // 账户余额label
            // 
            this.账户余额label.AutoSize = true;
            this.账户余额label.BackColor = System.Drawing.Color.Transparent;
            this.账户余额label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.账户余额label.ForeColor = System.Drawing.Color.Black;
            this.账户余额label.Location = new System.Drawing.Point(693, 125);
            this.账户余额label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.账户余额label.Name = "账户余额label";
            this.账户余额label.Size = new System.Drawing.Size(84, 18);
            this.账户余额label.TabIndex = 284;
            this.账户余额label.Text = "账户余额";
            // 
            // 卖家IDtextBox
            // 
            this.卖家IDtextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.卖家IDtextBox.Location = new System.Drawing.Point(448, 40);
            this.卖家IDtextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.卖家IDtextBox.Name = "卖家IDtextBox";
            this.卖家IDtextBox.ReadOnly = true;
            this.卖家IDtextBox.Size = new System.Drawing.Size(205, 28);
            this.卖家IDtextBox.TabIndex = 283;
            // 
            // 卖家IDlabel
            // 
            this.卖家IDlabel.AutoSize = true;
            this.卖家IDlabel.BackColor = System.Drawing.Color.Transparent;
            this.卖家IDlabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.卖家IDlabel.ForeColor = System.Drawing.Color.Black;
            this.卖家IDlabel.Location = new System.Drawing.Point(353, 50);
            this.卖家IDlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.卖家IDlabel.Name = "卖家IDlabel";
            this.卖家IDlabel.Size = new System.Drawing.Size(66, 18);
            this.卖家IDlabel.TabIndex = 282;
            this.卖家IDlabel.Text = "卖家ID";
            // 
            // 卖家昵称textBox
            // 
            this.卖家昵称textBox.BackColor = System.Drawing.Color.AliceBlue;
            this.卖家昵称textBox.Location = new System.Drawing.Point(799, 40);
            this.卖家昵称textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.卖家昵称textBox.Name = "卖家昵称textBox";
            this.卖家昵称textBox.ReadOnly = true;
            this.卖家昵称textBox.Size = new System.Drawing.Size(135, 28);
            this.卖家昵称textBox.TabIndex = 281;
            // 
            // 卖家昵称label
            // 
            this.卖家昵称label.AutoSize = true;
            this.卖家昵称label.BackColor = System.Drawing.Color.Transparent;
            this.卖家昵称label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.卖家昵称label.ForeColor = System.Drawing.Color.Black;
            this.卖家昵称label.Location = new System.Drawing.Point(693, 50);
            this.卖家昵称label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.卖家昵称label.Name = "卖家昵称label";
            this.卖家昵称label.Size = new System.Drawing.Size(84, 18);
            this.卖家昵称label.TabIndex = 280;
            this.卖家昵称label.Text = "卖家昵称";
            // 
            // 订单状态textBox
            // 
            this.订单状态textBox.BackColor = System.Drawing.Color.AliceBlue;
            this.订单状态textBox.Location = new System.Drawing.Point(164, 255);
            this.订单状态textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.订单状态textBox.Name = "订单状态textBox";
            this.订单状态textBox.ReadOnly = true;
            this.订单状态textBox.Size = new System.Drawing.Size(150, 28);
            this.订单状态textBox.TabIndex = 279;
            // 
            // 订单状态label
            // 
            this.订单状态label.AutoSize = true;
            this.订单状态label.BackColor = System.Drawing.Color.Transparent;
            this.订单状态label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.订单状态label.ForeColor = System.Drawing.Color.Black;
            this.订单状态label.Location = new System.Drawing.Point(60, 265);
            this.订单状态label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.订单状态label.Name = "订单状态label";
            this.订单状态label.Size = new System.Drawing.Size(84, 18);
            this.订单状态label.TabIndex = 278;
            this.订单状态label.Text = "订单状态";
            // 
            // 价格textBox
            // 
            this.价格textBox.BackColor = System.Drawing.Color.AliceBlue;
            this.价格textBox.Location = new System.Drawing.Point(799, 187);
            this.价格textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.价格textBox.Name = "价格textBox";
            this.价格textBox.ReadOnly = true;
            this.价格textBox.Size = new System.Drawing.Size(135, 28);
            this.价格textBox.TabIndex = 277;
            // 
            // 价格label
            // 
            this.价格label.AutoSize = true;
            this.价格label.BackColor = System.Drawing.Color.Transparent;
            this.价格label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.价格label.ForeColor = System.Drawing.Color.Black;
            this.价格label.Location = new System.Drawing.Point(693, 195);
            this.价格label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.价格label.Name = "价格label";
            this.价格label.Size = new System.Drawing.Size(46, 18);
            this.价格label.TabIndex = 276;
            this.价格label.Text = "价格";
            // 
            // 交易时间textBox
            // 
            this.交易时间textBox.BackColor = System.Drawing.Color.AliceBlue;
            this.交易时间textBox.Location = new System.Drawing.Point(448, 185);
            this.交易时间textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.交易时间textBox.Name = "交易时间textBox";
            this.交易时间textBox.ReadOnly = true;
            this.交易时间textBox.Size = new System.Drawing.Size(205, 28);
            this.交易时间textBox.TabIndex = 275;
            // 
            // 数量label
            // 
            this.数量label.AutoSize = true;
            this.数量label.BackColor = System.Drawing.Color.Transparent;
            this.数量label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.数量label.ForeColor = System.Drawing.Color.Black;
            this.数量label.Location = new System.Drawing.Point(693, 265);
            this.数量label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.数量label.Name = "数量label";
            this.数量label.Size = new System.Drawing.Size(46, 18);
            this.数量label.TabIndex = 274;
            this.数量label.Text = "数量";
            // 
            // 交易时间label
            // 
            this.交易时间label.AutoSize = true;
            this.交易时间label.BackColor = System.Drawing.Color.Transparent;
            this.交易时间label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.交易时间label.ForeColor = System.Drawing.Color.Black;
            this.交易时间label.Location = new System.Drawing.Point(353, 195);
            this.交易时间label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.交易时间label.Name = "交易时间label";
            this.交易时间label.Size = new System.Drawing.Size(84, 18);
            this.交易时间label.TabIndex = 273;
            this.交易时间label.Text = "交易时间";
            // 
            // 货物编号label
            // 
            this.货物编号label.AutoSize = true;
            this.货物编号label.BackColor = System.Drawing.Color.Transparent;
            this.货物编号label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.货物编号label.ForeColor = System.Drawing.Color.Black;
            this.货物编号label.Location = new System.Drawing.Point(60, 125);
            this.货物编号label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.货物编号label.Name = "货物编号label";
            this.货物编号label.Size = new System.Drawing.Size(84, 18);
            this.货物编号label.TabIndex = 272;
            this.货物编号label.Text = "货物编号";
            // 
            // 书名label
            // 
            this.书名label.AutoSize = true;
            this.书名label.BackColor = System.Drawing.Color.Transparent;
            this.书名label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.书名label.ForeColor = System.Drawing.Color.Black;
            this.书名label.Location = new System.Drawing.Point(353, 125);
            this.书名label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.书名label.Name = "书名label";
            this.书名label.Size = new System.Drawing.Size(46, 18);
            this.书名label.TabIndex = 271;
            this.书名label.Text = "书名";
            // 
            // 订单号label
            // 
            this.订单号label.AutoSize = true;
            this.订单号label.BackColor = System.Drawing.Color.Transparent;
            this.订单号label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.订单号label.ForeColor = System.Drawing.Color.Black;
            this.订单号label.Location = new System.Drawing.Point(60, 50);
            this.订单号label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.订单号label.Name = "订单号label";
            this.订单号label.Size = new System.Drawing.Size(65, 18);
            this.订单号label.TabIndex = 270;
            this.订单号label.Text = "订单号";
            // 
            // 数量textBox
            // 
            this.数量textBox.BackColor = System.Drawing.Color.AliceBlue;
            this.数量textBox.Location = new System.Drawing.Point(799, 255);
            this.数量textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.数量textBox.Name = "数量textBox";
            this.数量textBox.ReadOnly = true;
            this.数量textBox.Size = new System.Drawing.Size(135, 28);
            this.数量textBox.TabIndex = 269;
            // 
            // 货物编号textBox
            // 
            this.货物编号textBox.BackColor = System.Drawing.Color.AliceBlue;
            this.货物编号textBox.Location = new System.Drawing.Point(164, 115);
            this.货物编号textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.货物编号textBox.Name = "货物编号textBox";
            this.货物编号textBox.ReadOnly = true;
            this.货物编号textBox.Size = new System.Drawing.Size(150, 28);
            this.货物编号textBox.TabIndex = 268;
            // 
            // 书名textBox
            // 
            this.书名textBox.BackColor = System.Drawing.Color.AliceBlue;
            this.书名textBox.Location = new System.Drawing.Point(448, 115);
            this.书名textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.书名textBox.Name = "书名textBox";
            this.书名textBox.ReadOnly = true;
            this.书名textBox.Size = new System.Drawing.Size(205, 28);
            this.书名textBox.TabIndex = 267;
            // 
            // 订单号textBox
            // 
            this.订单号textBox.BackColor = System.Drawing.Color.AliceBlue;
            this.订单号textBox.Location = new System.Drawing.Point(164, 40);
            this.订单号textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.订单号textBox.Name = "订单号textBox";
            this.订单号textBox.ReadOnly = true;
            this.订单号textBox.Size = new System.Drawing.Size(150, 28);
            this.订单号textBox.TabIndex = 266;
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
            this.panel1.Controls.Add(this.卖家IDtextBox);
            this.panel1.Controls.Add(this.货物编号textBox);
            this.panel1.Controls.Add(this.卖家IDlabel);
            this.panel1.Controls.Add(this.数量textBox);
            this.panel1.Controls.Add(this.卖家昵称textBox);
            this.panel1.Controls.Add(this.书名label);
            this.panel1.Controls.Add(this.卖家昵称label);
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
            this.panel1.TabIndex = 290;
            // 
            // 历史订单查询_买Form
            // 
            this.AcceptButton = this.查询button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1258, 769);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "历史订单查询_买Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "历史订单查询";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.历史订单查询_买Form_KeyPress);
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
        private System.Windows.Forms.TextBox 卖家IDtextBox;
        private System.Windows.Forms.Label 卖家IDlabel;
        private System.Windows.Forms.TextBox 卖家昵称textBox;
        private System.Windows.Forms.Label 卖家昵称label;
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