namespace DeadLiner
{
    partial class UserItem
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_time = new System.Windows.Forms.Label();
            this.lab_content = new System.Windows.Forms.Label();
            this.pictureBox_underLine = new System.Windows.Forms.PictureBox();
            this.pic_clock = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_underLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_clock)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_time
            // 
            this.lab_time.AutoSize = true;
            this.lab_time.Location = new System.Drawing.Point(114, 20);
            this.lab_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_time.Name = "lab_time";
            this.lab_time.Size = new System.Drawing.Size(62, 18);
            this.lab_time.TabIndex = 1;
            this.lab_time.Text = "label1";
            this.lab_time.Click += new System.EventHandler(this.lab_time_Click);
            this.lab_time.DoubleClick += new System.EventHandler(this.lab_time_DoubleClick);
            // 
            // lab_content
            // 
            this.lab_content.AutoSize = true;
            this.lab_content.Location = new System.Drawing.Point(114, 45);
            this.lab_content.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_content.Name = "lab_content";
            this.lab_content.Size = new System.Drawing.Size(62, 18);
            this.lab_content.TabIndex = 2;
            this.lab_content.Text = "label2";
            this.lab_content.Click += new System.EventHandler(this.lab_content_Click);
            this.lab_content.DoubleClick += new System.EventHandler(this.lab_content_DoubleClick);
            // 
            // pictureBox_underLine
            // 
            this.pictureBox_underLine.BackColor = System.Drawing.Color.White;
            this.pictureBox_underLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_underLine.Location = new System.Drawing.Point(86, 72);
            this.pictureBox_underLine.Name = "pictureBox_underLine";
            this.pictureBox_underLine.Size = new System.Drawing.Size(315, 3);
            this.pictureBox_underLine.TabIndex = 3;
            this.pictureBox_underLine.TabStop = false;
            // 
            // pic_clock
            // 
            this.pic_clock.BackgroundImage = global::DeadLiner.Properties.Resources.clock_blue;
            this.pic_clock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_clock.Location = new System.Drawing.Point(4, 4);
            this.pic_clock.Margin = new System.Windows.Forms.Padding(4);
            this.pic_clock.Name = "pic_clock";
            this.pic_clock.Size = new System.Drawing.Size(80, 75);
            this.pic_clock.TabIndex = 0;
            this.pic_clock.TabStop = false;
            this.pic_clock.Click += new System.EventHandler(this.pic_clock_Click);
            this.pic_clock.DoubleClick += new System.EventHandler(this.pic_clock_DoubleClick);
            // 
            // UserItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox_underLine);
            this.Controls.Add(this.lab_content);
            this.Controls.Add(this.lab_time);
            this.Controls.Add(this.pic_clock);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserItem";
            this.Size = new System.Drawing.Size(490, 84);
            this.Load += new System.EventHandler(this.UserItem_Load);
            this.Click += new System.EventHandler(this.UserItem_Click);
            this.DoubleClick += new System.EventHandler(this.UserItem_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_underLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_clock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_time;
        private System.Windows.Forms.Label lab_content;
        private System.Windows.Forms.PictureBox pic_clock;
        private System.Windows.Forms.PictureBox pictureBox_underLine;
    }
}
