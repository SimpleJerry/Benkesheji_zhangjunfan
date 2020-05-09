namespace 研招信息查询系统
{
    partial class 院校信息查询Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.添加到收藏button = new System.Windows.Forms.Button();
            this.水印label = new System.Windows.Forms.Label();
            this.招生单位textBox = new System.Windows.Forms.TextBox();
            this.招生单位label = new System.Windows.Forms.Label();
            this.查询button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.所在省市comboBox = new System.Windows.Forms.ComboBox();
            this.院校特性comboBox = new System.Windows.Forms.ComboBox();
            this.所在省市label = new System.Windows.Forms.Label();
            this.院校特性label = new System.Windows.Forms.Label();
            this.院校隶属label = new System.Windows.Forms.Label();
            this.院校隶属comboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::研招信息查询系统.Properties.Resources.院校信息;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.添加到收藏button);
            this.panel1.Controls.Add(this.水印label);
            this.panel1.Controls.Add(this.招生单位textBox);
            this.panel1.Controls.Add(this.招生单位label);
            this.panel1.Controls.Add(this.查询button);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.所在省市comboBox);
            this.panel1.Controls.Add(this.院校特性comboBox);
            this.panel1.Controls.Add(this.所在省市label);
            this.panel1.Controls.Add(this.院校特性label);
            this.panel1.Controls.Add(this.院校隶属label);
            this.panel1.Controls.Add(this.院校隶属comboBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 770);
            this.panel1.TabIndex = 122;
            // 
            // 添加到收藏button
            // 
            this.添加到收藏button.Location = new System.Drawing.Point(550, 171);
            this.添加到收藏button.Name = "添加到收藏button";
            this.添加到收藏button.Size = new System.Drawing.Size(139, 35);
            this.添加到收藏button.TabIndex = 128;
            this.添加到收藏button.Text = "添加到收藏";
            this.添加到收藏button.UseVisualStyleBackColor = true;
            this.添加到收藏button.Click += new System.EventHandler(this.添加到收藏button_Click);
            // 
            // 水印label
            // 
            this.水印label.AutoSize = true;
            this.水印label.BackColor = System.Drawing.SystemColors.Window;
            this.水印label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.水印label.Location = new System.Drawing.Point(514, 59);
            this.水印label.Name = "水印label";
            this.水印label.Size = new System.Drawing.Size(44, 18);
            this.水印label.TabIndex = 127;
            this.水印label.Text = "水印";
            this.水印label.Click += new System.EventHandler(this.水印label_Click);
            // 
            // 招生单位textBox
            // 
            this.招生单位textBox.Location = new System.Drawing.Point(515, 53);
            this.招生单位textBox.Name = "招生单位textBox";
            this.招生单位textBox.Size = new System.Drawing.Size(140, 28);
            this.招生单位textBox.TabIndex = 126;
            this.招生单位textBox.TextChanged += new System.EventHandler(this.招生单位textBox_TextChanged);
            // 
            // 招生单位label
            // 
            this.招生单位label.AutoSize = true;
            this.招生单位label.Location = new System.Drawing.Point(401, 56);
            this.招生单位label.Name = "招生单位label";
            this.招生单位label.Size = new System.Drawing.Size(80, 18);
            this.招生单位label.TabIndex = 125;
            this.招生单位label.Text = "招生单位";
            // 
            // 查询button
            // 
            this.查询button.Location = new System.Drawing.Point(417, 171);
            this.查询button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.查询button.Name = "查询button";
            this.查询button.Size = new System.Drawing.Size(105, 35);
            this.查询button.TabIndex = 123;
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
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 395);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1255, 315);
            this.dataGridView1.TabIndex = 122;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // 所在省市comboBox
            // 
            this.所在省市comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.所在省市comboBox.FormattingEnabled = true;
            this.所在省市comboBox.Items.AddRange(new object[] {
            "--选择省市--"});
            this.所在省市comboBox.Location = new System.Drawing.Point(217, 56);
            this.所在省市comboBox.Name = "所在省市comboBox";
            this.所在省市comboBox.Size = new System.Drawing.Size(140, 26);
            this.所在省市comboBox.TabIndex = 117;
            // 
            // 院校特性comboBox
            // 
            this.院校特性comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.院校特性comboBox.FormattingEnabled = true;
            this.院校特性comboBox.Items.AddRange(new object[] {
            "--选择院校特性--",
            "985",
            "211"});
            this.院校特性comboBox.Location = new System.Drawing.Point(217, 171);
            this.院校特性comboBox.Name = "院校特性comboBox";
            this.院校特性comboBox.Size = new System.Drawing.Size(140, 26);
            this.院校特性comboBox.TabIndex = 121;
            // 
            // 所在省市label
            // 
            this.所在省市label.AutoSize = true;
            this.所在省市label.Location = new System.Drawing.Point(84, 56);
            this.所在省市label.Name = "所在省市label";
            this.所在省市label.Size = new System.Drawing.Size(80, 18);
            this.所在省市label.TabIndex = 1;
            this.所在省市label.Text = "所在省市";
            // 
            // 院校特性label
            // 
            this.院校特性label.AutoSize = true;
            this.院校特性label.Location = new System.Drawing.Point(84, 174);
            this.院校特性label.Name = "院校特性label";
            this.院校特性label.Size = new System.Drawing.Size(80, 18);
            this.院校特性label.TabIndex = 120;
            this.院校特性label.Text = "院校特性";
            // 
            // 院校隶属label
            // 
            this.院校隶属label.AutoSize = true;
            this.院校隶属label.Location = new System.Drawing.Point(84, 115);
            this.院校隶属label.Name = "院校隶属label";
            this.院校隶属label.Size = new System.Drawing.Size(80, 18);
            this.院校隶属label.TabIndex = 118;
            this.院校隶属label.Text = "院校隶属";
            // 
            // 院校隶属comboBox
            // 
            this.院校隶属comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.院校隶属comboBox.FormattingEnabled = true;
            this.院校隶属comboBox.Items.AddRange(new object[] {
            "--选择隶属单位--",
            "教育部",
            "其他部委"});
            this.院校隶属comboBox.Location = new System.Drawing.Point(217, 112);
            this.院校隶属comboBox.Name = "院校隶属comboBox";
            this.院校隶属comboBox.Size = new System.Drawing.Size(140, 26);
            this.院校隶属comboBox.TabIndex = 119;
            // 
            // 院校信息查询Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1258, 769);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "院校信息查询Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "院校信息查询";
            this.Load += new System.EventHandler(this.院校信息查询Form_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.院校信息查询Form_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label 所在省市label;
        private System.Windows.Forms.ComboBox 所在省市comboBox;
        private System.Windows.Forms.Label 院校隶属label;
        private System.Windows.Forms.ComboBox 院校隶属comboBox;
        private System.Windows.Forms.Label 院校特性label;
        private System.Windows.Forms.ComboBox 院校特性comboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button 查询button;
        private System.Windows.Forms.Label 水印label;
        private System.Windows.Forms.TextBox 招生单位textBox;
        private System.Windows.Forms.Label 招生单位label;
        private System.Windows.Forms.Button 添加到收藏button;
    }
}