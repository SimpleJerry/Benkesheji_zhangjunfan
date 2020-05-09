namespace 图书管理系统_课程设计
{
    partial class 导出图书信息Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(导出图书信息Form));
            this.导出文件路径label = new System.Windows.Forms.Label();
            this.导出文件路径textBox = new System.Windows.Forms.TextBox();
            this.导出button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.选择路径button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // 导出文件路径label
            // 
            this.导出文件路径label.AutoSize = true;
            this.导出文件路径label.BackColor = System.Drawing.Color.Transparent;
            this.导出文件路径label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.导出文件路径label.Location = new System.Drawing.Point(578, 139);
            this.导出文件路径label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.导出文件路径label.Name = "导出文件路径label";
            this.导出文件路径label.Size = new System.Drawing.Size(83, 12);
            this.导出文件路径label.TabIndex = 2;
            this.导出文件路径label.Text = "导出文件路径";
            // 
            // 导出文件路径textBox
            // 
            this.导出文件路径textBox.Location = new System.Drawing.Point(580, 175);
            this.导出文件路径textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.导出文件路径textBox.Name = "导出文件路径textBox";
            this.导出文件路径textBox.ReadOnly = true;
            this.导出文件路径textBox.Size = new System.Drawing.Size(107, 21);
            this.导出文件路径textBox.TabIndex = 3;
            // 
            // 导出button
            // 
            this.导出button.Location = new System.Drawing.Point(618, 263);
            this.导出button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.导出button.Name = "导出button";
            this.导出button.Size = new System.Drawing.Size(69, 24);
            this.导出button.TabIndex = 4;
            this.导出button.Text = "导出";
            this.导出button.UseVisualStyleBackColor = true;
            this.导出button.Click += new System.EventHandler(this.导出button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, -1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(548, 495);
            this.dataGridView1.TabIndex = 5;
            // 
            // 选择路径button
            // 
            this.选择路径button.Location = new System.Drawing.Point(618, 216);
            this.选择路径button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.选择路径button.Name = "选择路径button";
            this.选择路径button.Size = new System.Drawing.Size(69, 26);
            this.选择路径button.TabIndex = 6;
            this.选择路径button.Text = "选择路径";
            this.选择路径button.UseVisualStyleBackColor = true;
            this.选择路径button.Click += new System.EventHandler(this.选择路径button_Click);
            // 
            // 导出图书信息Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(705, 496);
            this.Controls.Add(this.选择路径button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.导出button);
            this.Controls.Add(this.导出文件路径textBox);
            this.Controls.Add(this.导出文件路径label);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "导出图书信息Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "导出图书信息";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.导出图书信息Form_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 导出文件路径label;
        private System.Windows.Forms.TextBox 导出文件路径textBox;
        private System.Windows.Forms.Button 导出button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button 选择路径button;
    }
}