namespace 图书管理系统_课程设计
{
    partial class 导入读者信息Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(导入读者信息Form));
            this.导入文件路径label = new System.Windows.Forms.Label();
            this.导入文件路径textBox = new System.Windows.Forms.TextBox();
            this.导入button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.选择路径button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // 导入文件路径label
            // 
            this.导入文件路径label.AutoSize = true;
            this.导入文件路径label.BackColor = System.Drawing.Color.Transparent;
            this.导入文件路径label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.导入文件路径label.Location = new System.Drawing.Point(21, 30);
            this.导入文件路径label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.导入文件路径label.Name = "导入文件路径label";
            this.导入文件路径label.Size = new System.Drawing.Size(83, 12);
            this.导入文件路径label.TabIndex = 2;
            this.导入文件路径label.Text = "导入文件路径";
            // 
            // 导入文件路径textBox
            // 
            this.导入文件路径textBox.Location = new System.Drawing.Point(125, 26);
            this.导入文件路径textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.导入文件路径textBox.Name = "导入文件路径textBox";
            this.导入文件路径textBox.ReadOnly = true;
            this.导入文件路径textBox.Size = new System.Drawing.Size(107, 21);
            this.导入文件路径textBox.TabIndex = 3;
            // 
            // 导入button
            // 
            this.导入button.Location = new System.Drawing.Point(256, 70);
            this.导入button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.导入button.Name = "导入button";
            this.导入button.Size = new System.Drawing.Size(69, 22);
            this.导入button.TabIndex = 4;
            this.导入button.Text = "导入";
            this.导入button.UseVisualStyleBackColor = true;
            this.导入button.Click += new System.EventHandler(this.导入button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 214);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(705, 282);
            this.dataGridView1.TabIndex = 5;
            // 
            // 选择路径button
            // 
            this.选择路径button.Location = new System.Drawing.Point(256, 26);
            this.选择路径button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.选择路径button.Name = "选择路径button";
            this.选择路径button.Size = new System.Drawing.Size(69, 21);
            this.选择路径button.TabIndex = 8;
            this.选择路径button.Text = "选择路径";
            this.选择路径button.UseVisualStyleBackColor = true;
            this.选择路径button.Click += new System.EventHandler(this.选择路径button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.NavajoWhite;
            this.trackBar1.Location = new System.Drawing.Point(141, 113);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(184, 45);
            this.trackBar1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "进度条";
            // 
            // 导入读者信息Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.选择路径button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.导入button);
            this.Controls.Add(this.导入文件路径textBox);
            this.Controls.Add(this.导入文件路径label);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "导入读者信息Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "导入读者信息";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.导入读者信息Form_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 导入文件路径label;
        private System.Windows.Forms.TextBox 导入文件路径textBox;
        private System.Windows.Forms.Button 导入button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button 选择路径button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
    }
}