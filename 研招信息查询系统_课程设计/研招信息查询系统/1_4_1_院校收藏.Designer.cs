namespace 研招信息查询系统
{
    partial class 院校收藏Form
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
            this.用户label = new System.Windows.Forms.Label();
            this.的收藏label = new System.Windows.Forms.Label();
            this.返回button = new System.Windows.Forms.Button();
            this.移除院校信息button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // 用户label
            // 
            this.用户label.AutoSize = true;
            this.用户label.Location = new System.Drawing.Point(57, 50);
            this.用户label.Name = "用户label";
            this.用户label.Size = new System.Drawing.Size(62, 18);
            this.用户label.TabIndex = 0;
            this.用户label.Text = "用户名";
            // 
            // 的收藏label
            // 
            this.的收藏label.AutoSize = true;
            this.的收藏label.Location = new System.Drawing.Point(157, 50);
            this.的收藏label.Name = "的收藏label";
            this.的收藏label.Size = new System.Drawing.Size(62, 18);
            this.的收藏label.TabIndex = 1;
            this.的收藏label.Text = "的收藏";
            this.的收藏label.UseWaitCursor = true;
            // 
            // 返回button
            // 
            this.返回button.Location = new System.Drawing.Point(1099, 503);
            this.返回button.Name = "返回button";
            this.返回button.Size = new System.Drawing.Size(122, 49);
            this.返回button.TabIndex = 4;
            this.返回button.Text = "返回";
            this.返回button.UseVisualStyleBackColor = true;
            this.返回button.Click += new System.EventHandler(this.返回button_Click);
            // 
            // 移除院校信息button
            // 
            this.移除院校信息button.Location = new System.Drawing.Point(1078, 391);
            this.移除院校信息button.Name = "移除院校信息button";
            this.移除院校信息button.Size = new System.Drawing.Size(128, 53);
            this.移除院校信息button.TabIndex = 6;
            this.移除院校信息button.Text = "移除院校信息";
            this.移除院校信息button.UseVisualStyleBackColor = true;
            this.移除院校信息button.Click += new System.EventHandler(this.移除院校信息button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 101);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(970, 380);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // 院校收藏Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1248, 564);
            this.Controls.Add(this.移除院校信息button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.返回button);
            this.Controls.Add(this.的收藏label);
            this.Controls.Add(this.用户label);
            this.KeyPreview = true;
            this.Name = "院校收藏Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "院校收藏";
            this.Load += new System.EventHandler(this.院校收藏Form_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.院校收藏Form_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 用户label;
        private System.Windows.Forms.Label 的收藏label;
        private System.Windows.Forms.Button 返回button;
        private System.Windows.Forms.Button 移除院校信息button;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}