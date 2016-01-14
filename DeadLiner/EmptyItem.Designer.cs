namespace DeadLiner
{
    partial class EmptyItem
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
            this.pictureBox_emptyBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_emptyBG)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_emptyBG
            // 
            this.pictureBox_emptyBG.BackgroundImage = global::DeadLiner.Properties.Resources.EmptyItem;
            this.pictureBox_emptyBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_emptyBG.Location = new System.Drawing.Point(49, 27);
            this.pictureBox_emptyBG.Name = "pictureBox_emptyBG";
            this.pictureBox_emptyBG.Size = new System.Drawing.Size(278, 255);
            this.pictureBox_emptyBG.TabIndex = 0;
            this.pictureBox_emptyBG.TabStop = false;
            // 
            // EmptyItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox_emptyBG);
            this.Name = "EmptyItem";
            this.Size = new System.Drawing.Size(398, 333);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_emptyBG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_emptyBG;
    }
}
