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
            this.btn_delay1day = new System.Windows.Forms.Button();
            this.btn_delay1hour = new System.Windows.Forms.Button();
            this.panel_special = new System.Windows.Forms.Panel();
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
            this.pictureBox_shaking.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_shaking.Name = "pictureBox_shaking";
            this.pictureBox_shaking.Size = new System.Drawing.Size(771, 843);
            this.pictureBox_shaking.TabIndex = 0;
            this.pictureBox_shaking.TabStop = false;
            this.pictureBox_shaking.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_shaking_MouseMove);
            // 
            // btn_delay1day
            // 
            this.btn_delay1day.BackColor = System.Drawing.Color.Transparent;
            this.btn_delay1day.BackgroundImage = global::DeadLiner.Properties.Resources.btn_delay_oneday;
            this.btn_delay1day.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delay1day.FlatAppearance.BorderSize = 0;
            this.btn_delay1day.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_delay1day.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_delay1day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delay1day.Location = new System.Drawing.Point(432, 789);
            this.btn_delay1day.Name = "btn_delay1day";
            this.btn_delay1day.Size = new System.Drawing.Size(120, 50);
            this.btn_delay1day.TabIndex = 2;
            this.btn_delay1day.UseVisualStyleBackColor = false;
            this.btn_delay1day.Click += new System.EventHandler(this.btn_delay1day_Click);
            // 
            // btn_delay1hour
            // 
            this.btn_delay1hour.BackColor = System.Drawing.Color.Transparent;
            this.btn_delay1hour.BackgroundImage = global::DeadLiner.Properties.Resources.btn_delay_onehour;
            this.btn_delay1hour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delay1hour.FlatAppearance.BorderSize = 0;
            this.btn_delay1hour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delay1hour.Location = new System.Drawing.Point(257, 789);
            this.btn_delay1hour.Name = "btn_delay1hour";
            this.btn_delay1hour.Size = new System.Drawing.Size(120, 50);
            this.btn_delay1hour.TabIndex = 1;
            this.btn_delay1hour.UseVisualStyleBackColor = false;
            this.btn_delay1hour.Click += new System.EventHandler(this.btn_delay1hour_Click);
            // 
            // panel_special
            // 
            this.panel_special.BackColor = System.Drawing.Color.Transparent;
            this.panel_special.Location = new System.Drawing.Point(224, 679);
            this.panel_special.Name = "panel_special";
            this.panel_special.Size = new System.Drawing.Size(382, 100);
            this.panel_special.TabIndex = 3;
    
            // 
            // Form_Shaking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 867);
            this.Controls.Add(this.btn_delay1hour);
            this.Controls.Add(this.btn_delay1day);
            this.Controls.Add(this.pictureBox_shaking);
            this.Controls.Add(this.panel_special);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btn_delay1day;
        private System.Windows.Forms.Button btn_delay1hour;
        private System.Windows.Forms.Panel panel_special;
    }
}