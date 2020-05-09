namespace 图书管理系统_课程设计
{
    partial class 在借查询Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(在借查询Form));
            this.查询在借书籍button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.查询在借书籍textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // 查询在借书籍button
            // 
            this.查询在借书籍button.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.查询在借书籍button.Location = new System.Drawing.Point(587, 435);
            this.查询在借书籍button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.查询在借书籍button.Name = "查询在借书籍button";
            this.查询在借书籍button.Size = new System.Drawing.Size(107, 33);
            this.查询在借书籍button.TabIndex = 1;
            this.查询在借书籍button.Text = "查询在借书籍";
            this.查询在借书籍button.UseVisualStyleBackColor = true;
            this.查询在借书籍button.Click += new System.EventHandler(this.查询在借书籍button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(702, 364);
            this.dataGridView1.TabIndex = 2;
            // 
            // 查询在借书籍textBox
            // 
            this.查询在借书籍textBox.Location = new System.Drawing.Point(429, 442);
            this.查询在借书籍textBox.Name = "查询在借书籍textBox";
            this.查询在借书籍textBox.Size = new System.Drawing.Size(141, 21);
            this.查询在借书籍textBox.TabIndex = 3;
            this.查询在借书籍textBox.Text = "(全部)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "书名/ISBN/读者姓名/读者账号";
            // 
            // 在借查询Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.查询在借书籍textBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.查询在借书籍button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "在借查询Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "在借查询";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.在借查询Form_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 查询在借书籍button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox 查询在借书籍textBox;
        private System.Windows.Forms.Label label1;
    }
}