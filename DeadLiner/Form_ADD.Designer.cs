﻿namespace DeadLiner
{
    partial class Form_ADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ADD));
            this.label1 = new System.Windows.Forms.Label();
            this.now_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textContent = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cannel = new System.Windows.Forms.Button();
            this.now_time = new System.Windows.Forms.DateTimePicker();
            this.status_time = new System.Windows.Forms.StatusStrip();
            this.strip_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer_clock = new System.Windows.Forms.Timer(this.components);
            this.status_time.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "日期：";
            // 
            // now_date
            // 
            this.now_date.Location = new System.Drawing.Point(136, 51);
            this.now_date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.now_date.Name = "now_date";
            this.now_date.Size = new System.Drawing.Size(234, 28);
            this.now_date.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "时间：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "提醒：";
            // 
            // textContent
            // 
            this.textContent.Location = new System.Drawing.Point(136, 158);
            this.textContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textContent.Name = "textContent";
            this.textContent.Size = new System.Drawing.Size(234, 28);
            this.textContent.TabIndex = 3;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(94, 222);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(93, 34);
            this.btn_ok.TabIndex = 10;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cannel
            // 
            this.btn_cannel.Location = new System.Drawing.Point(224, 222);
            this.btn_cannel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cannel.Name = "btn_cannel";
            this.btn_cannel.Size = new System.Drawing.Size(93, 34);
            this.btn_cannel.TabIndex = 11;
            this.btn_cannel.Text = "取消";
            this.btn_cannel.UseVisualStyleBackColor = true;
            this.btn_cannel.Click += new System.EventHandler(this.btn_cannel_Click);
            // 
            // now_time
            // 
            this.now_time.CustomFormat = "HH:mm:ss";
            this.now_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.now_time.Location = new System.Drawing.Point(135, 104);
            this.now_time.Name = "now_time";
            this.now_time.ShowUpDown = true;
            this.now_time.Size = new System.Drawing.Size(235, 28);
            this.now_time.TabIndex = 2;
            // 
            // status_time
            // 
            this.status_time.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strip_time});
            this.status_time.Location = new System.Drawing.Point(0, 266);
            this.status_time.Name = "status_time";
            this.status_time.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.status_time.Size = new System.Drawing.Size(452, 22);
            this.status_time.TabIndex = 13;
            this.status_time.Text = "statusStrip1";
            // 
            // strip_time
            // 
            this.strip_time.Name = "strip_time";
            this.strip_time.Size = new System.Drawing.Size(0, 17);
            // 
            // timer_clock
            // 
            this.timer_clock.Interval = 1000;
            this.timer_clock.Tick += new System.EventHandler(this.timer_clock_Tick);
            // 
            // Form_ADD
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 288);
            this.Controls.Add(this.status_time);
            this.Controls.Add(this.now_time);
            this.Controls.Add(this.btn_cannel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.textContent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.now_date);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form_ADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "新死期";
            this.Load += new System.EventHandler(this.Form_ADD_Load);
            this.status_time.ResumeLayout(false);
            this.status_time.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker now_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textContent;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cannel;
        private System.Windows.Forms.DateTimePicker now_time;
        private System.Windows.Forms.StatusStrip status_time;
        private System.Windows.Forms.ToolStripStatusLabel strip_time;
        private System.Windows.Forms.Timer timer_clock;
    }
}