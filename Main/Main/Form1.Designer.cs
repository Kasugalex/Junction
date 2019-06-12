namespace Main
{
    partial class Form1
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
            this.AddPath = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Continer = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.PictureBox();
            this.deleteAllPath = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPath
            // 
            this.AddPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPath.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.AddPath.Location = new System.Drawing.Point(28, 12);
            this.AddPath.Name = "AddPath";
            this.AddPath.Size = new System.Drawing.Size(86, 23);
            this.AddPath.TabIndex = 7;
            this.AddPath.Text = "添加路径";
            this.AddPath.Click += new System.EventHandler(this.GeneratePathUI);
            // 
            // Generate
            // 
            this.Generate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Generate.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.Generate.Location = new System.Drawing.Point(247, 12);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(84, 23);
            this.Generate.TabIndex = 8;
            this.Generate.Text = "链接路径";
            this.Generate.Click += new System.EventHandler(this.Junction);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(32, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 1);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(113, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 20);
            this.panel2.TabIndex = 10;
            // 
            // Continer
            // 
            this.Continer.AutoScroll = true;
            this.Continer.Location = new System.Drawing.Point(32, 55);
            this.Continer.Name = "Continer";
            this.Continer.Size = new System.Drawing.Size(859, 475);
            this.Continer.TabIndex = 11;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.BackgroundImage = global::Main.Properties.Resources.Close;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Location = new System.Drawing.Point(855, 7);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(36, 32);
            this.Close.TabIndex = 0;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // deleteAllPath
            // 
            this.deleteAllPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteAllPath.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.deleteAllPath.Location = new System.Drawing.Point(120, 13);
            this.deleteAllPath.Name = "deleteAllPath";
            this.deleteAllPath.Size = new System.Drawing.Size(121, 23);
            this.deleteAllPath.TabIndex = 12;
            this.deleteAllPath.Text = "删除所有路径";
            this.deleteAllPath.Click += new System.EventHandler(this.DeleteAllPath);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(240, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 20);
            this.panel3.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(903, 542);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Continer);
            this.Controls.Add(this.deleteAllPath);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.AddPath);
            this.Controls.Add(this.Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Junction";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.Label AddPath;
        private System.Windows.Forms.Label Generate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Continer;
        private System.Windows.Forms.Label deleteAllPath;
        private System.Windows.Forms.Panel panel3;
    }
}

