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
            this.Close = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Label();
            this.End = new System.Windows.Forms.Label();
            this.StartPath = new System.Windows.Forms.TextBox();
            this.endPath = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.BackgroundImage = global::Main.Properties.Resources.Close;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Location = new System.Drawing.Point(452, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(36, 32);
            this.Close.TabIndex = 0;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.Start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Start.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Start.Location = new System.Drawing.Point(27, 78);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(60, 23);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start:";
            this.Start.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // End
            // 
            this.End.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.End.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.End.Location = new System.Drawing.Point(32, 130);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(55, 25);
            this.End.TabIndex = 2;
            this.End.Text = "End:";
            this.End.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StartPath
            // 
            this.StartPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartPath.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.StartPath.Location = new System.Drawing.Point(93, 80);
            this.StartPath.Name = "StartPath";
            this.StartPath.Size = new System.Drawing.Size(293, 30);
            this.StartPath.TabIndex = 3;
            // 
            // endPath
            // 
            this.endPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endPath.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.endPath.Location = new System.Drawing.Point(93, 130);
            this.endPath.Name = "endPath";
            this.endPath.Size = new System.Drawing.Size(293, 30);
            this.endPath.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Main.Properties.Resources.Add;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(392, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.AddStart_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Main.Properties.Resources.Add;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(392, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.AddEnd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("宋体", 18F);
            this.button1.Location = new System.Drawing.Point(125, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "Do♂it";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Doit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.endPath);
            this.Controls.Add(this.StartPath);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Junction";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.Label Start;
        private System.Windows.Forms.Label End;
        private System.Windows.Forms.TextBox StartPath;
        private System.Windows.Forms.TextBox endPath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}

