namespace DeadLiner
{
    partial class Form_Shaking
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Shaking));
            this.timer_wait = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_shaking = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_shaking)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_wait
            // 
            this.timer_wait.Interval = 200;
            this.timer_wait.Tick += new System.EventHandler(this.timer_wait_Tick);
            // 
            // pictureBox_shaking
            // 
            this.pictureBox_shaking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_shaking.Location = new System.Drawing.Point(5, 8);
            this.pictureBox_shaking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_shaking.Name = "pictureBox_shaking";
            this.pictureBox_shaking.Size = new System.Drawing.Size(489, 536);
            this.pictureBox_shaking.TabIndex = 0;
            this.pictureBox_shaking.TabStop = false;
            // 
            // Form_Shaking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 559);
            this.Controls.Add(this.pictureBox_shaking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form_Shaking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "死期到了！";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Shaking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_shaking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_wait;
        private System.Windows.Forms.PictureBox pictureBox_shaking;
    }
}