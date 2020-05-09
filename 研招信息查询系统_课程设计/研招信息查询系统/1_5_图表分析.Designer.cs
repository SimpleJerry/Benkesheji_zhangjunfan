namespace 研招信息查询系统
{
    partial class 图表分析Form
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
            this.收藏夹1button1 = new System.Windows.Forms.Button();
            this.收藏夹2button2 = new System.Windows.Forms.Button();
            this.图表分析panel1 = new System.Windows.Forms.Panel();
            this.图表显示webBrowser = new System.Windows.Forms.WebBrowser();
            this.图表分析panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 收藏夹1button1
            // 
            this.收藏夹1button1.Location = new System.Drawing.Point(26, 2);
            this.收藏夹1button1.Name = "收藏夹1button1";
            this.收藏夹1button1.Size = new System.Drawing.Size(175, 39);
            this.收藏夹1button1.TabIndex = 0;
            this.收藏夹1button1.Text = "收藏夹1button1";
            this.收藏夹1button1.UseVisualStyleBackColor = true;
            this.收藏夹1button1.Click += new System.EventHandler(this.收藏夹1button1_Click);
            // 
            // 收藏夹2button2
            // 
            this.收藏夹2button2.Location = new System.Drawing.Point(293, 2);
            this.收藏夹2button2.Name = "收藏夹2button2";
            this.收藏夹2button2.Size = new System.Drawing.Size(185, 39);
            this.收藏夹2button2.TabIndex = 1;
            this.收藏夹2button2.Text = "收藏夹2button2";
            this.收藏夹2button2.UseVisualStyleBackColor = true;
            this.收藏夹2button2.Click += new System.EventHandler(this.收藏夹2button2_Click);
            // 
            // 图表分析panel1
            // 
            this.图表分析panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.图表分析panel1.AutoSize = true;
            this.图表分析panel1.Controls.Add(this.图表显示webBrowser);
            this.图表分析panel1.Location = new System.Drawing.Point(0, 44);
            this.图表分析panel1.Name = "图表分析panel1";
            this.图表分析panel1.Size = new System.Drawing.Size(1203, 653);
            this.图表分析panel1.TabIndex = 2;
            // 
            // 图表显示webBrowser
            // 
            this.图表显示webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.图表显示webBrowser.Location = new System.Drawing.Point(0, 0);
            this.图表显示webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.图表显示webBrowser.Name = "图表显示webBrowser";
            this.图表显示webBrowser.Size = new System.Drawing.Size(1200, 650);
            this.图表显示webBrowser.TabIndex = 0;
            // 
            // 图表分析Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1178, 703);
            this.Controls.Add(this.图表分析panel1);
            this.Controls.Add(this.收藏夹2button2);
            this.Controls.Add(this.收藏夹1button1);
            this.Name = "图表分析Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图表分析";
            this.Load += new System.EventHandler(this.图表分析Form_Load);
            this.Shown += new System.EventHandler(this.图表分析Form_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.图表分析Form_KeyPress);
            this.图表分析panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 收藏夹1button1;
        private System.Windows.Forms.Button 收藏夹2button2;
        private System.Windows.Forms.Panel 图表分析panel1;
        private System.Windows.Forms.WebBrowser 图表显示webBrowser;
    }
}