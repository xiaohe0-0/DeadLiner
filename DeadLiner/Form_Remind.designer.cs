﻿namespace DeadLiner
{
    partial class Form_Remind
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
            this.lab_line1 = new System.Windows.Forms.Label();
            this.lab_line2 = new System.Windows.Forms.Label();
            this.lab_line3 = new System.Windows.Forms.Label();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.pictureBox_clock = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clock)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_line1
            // 
            this.lab_line1.AutoSize = true;
            this.lab_line1.Location = new System.Drawing.Point(152, 52);
            this.lab_line1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_line1.Name = "lab_line1";
            this.lab_line1.Size = new System.Drawing.Size(44, 18);
            this.lab_line1.TabIndex = 0;
            this.lab_line1.Text = "Hi，";
            this.lab_line1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_line2
            // 
            this.lab_line2.AutoSize = true;
            this.lab_line2.Location = new System.Drawing.Point(152, 94);
            this.lab_line2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_line2.Name = "lab_line2";
            this.lab_line2.Size = new System.Drawing.Size(188, 18);
            this.lab_line2.TabIndex = 1;
            this.lab_line2.Text = "今天你有DeadLine哦。";
            this.lab_line2.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_line3
            // 
            this.lab_line3.AutoSize = true;
            this.lab_line3.Location = new System.Drawing.Point(152, 136);
            this.lab_line3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_line3.Name = "lab_line3";
            this.lab_line3.Size = new System.Drawing.Size(116, 18);
            this.lab_line3.TabIndex = 2;
            this.lab_line3.Text = "快去查看吧。";
            this.lab_line3.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.BackgroundImage = global::DeadLiner.Properties.Resources.btn_close;
            this.pictureBox_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_close.Location = new System.Drawing.Point(324, 3);
            this.pictureBox_close.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(40, 30);
            this.pictureBox_close.TabIndex = 5;
            this.pictureBox_close.TabStop = false;
            this.pictureBox_close.Click += new System.EventHandler(this.pictureBox_close_Click);
            // 
            // pictureBox_clock
            // 
            this.pictureBox_clock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_clock.Location = new System.Drawing.Point(13, 52);
            this.pictureBox_clock.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_clock.Name = "pictureBox_clock";
            this.pictureBox_clock.Size = new System.Drawing.Size(119, 113);
            this.pictureBox_clock.TabIndex = 6;
            this.pictureBox_clock.TabStop = false;
            this.pictureBox_clock.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form_Remind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeadLiner.Properties.Resources.remindBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(368, 194);
            this.Controls.Add(this.pictureBox_clock);
            this.Controls.Add(this.pictureBox_close);
            this.Controls.Add(this.lab_line3);
            this.Controls.Add(this.lab_line2);
            this.Controls.Add(this.lab_line1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Remind";
            this.Text = "提醒";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Remind_Show_FormClosing);
            this.Load += new System.EventHandler(this.Remind_Show_Load);
            this.Click += new System.EventHandler(this.label1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_line1;
        private System.Windows.Forms.Label lab_line2;
        private System.Windows.Forms.Label lab_line3;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.PictureBox pictureBox_clock;

    }
}