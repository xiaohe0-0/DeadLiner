namespace DeadLiner
{
    partial class Form_Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Setting));
            this.btn_cannel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radio_ma = new System.Windows.Forms.RadioButton();
            this.radio_default = new System.Windows.Forms.RadioButton();
            this.radio_tian = new System.Windows.Forms.RadioButton();
            this.radio_collection = new System.Windows.Forms.RadioButton();
            this.radio_leng = new System.Windows.Forms.RadioButton();
            this.radio_leader = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cannel
            // 
            this.btn_cannel.Location = new System.Drawing.Point(103, 239);
            this.btn_cannel.Name = "btn_cannel";
            this.btn_cannel.Size = new System.Drawing.Size(62, 23);
            this.btn_cannel.TabIndex = 25;
            this.btn_cannel.Text = "取消";
            this.btn_cannel.UseVisualStyleBackColor = true;
            this.btn_cannel.Click += new System.EventHandler(this.btn_cannel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(17, 239);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(62, 23);
            this.btn_ok.TabIndex = 24;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radio_ma);
            this.panel1.Controls.Add(this.radio_default);
            this.panel1.Controls.Add(this.radio_tian);
            this.panel1.Controls.Add(this.radio_collection);
            this.panel1.Controls.Add(this.radio_leng);
            this.panel1.Controls.Add(this.radio_leader);
            this.panel1.Location = new System.Drawing.Point(17, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 226);
            this.panel1.TabIndex = 29;
            // 
            // radio_ma
            // 
            this.radio_ma.AutoSize = true;
            this.radio_ma.Location = new System.Drawing.Point(16, 121);
            this.radio_ma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radio_ma.Name = "radio_ma";
            this.radio_ma.Size = new System.Drawing.Size(59, 16);
            this.radio_ma.TabIndex = 35;
            this.radio_ma.Text = "大马哥";
            this.radio_ma.UseVisualStyleBackColor = true;
            // 
            // radio_default
            // 
            this.radio_default.AutoSize = true;
            this.radio_default.Checked = true;
            this.radio_default.Location = new System.Drawing.Point(16, 15);
            this.radio_default.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radio_default.Name = "radio_default";
            this.radio_default.Size = new System.Drawing.Size(47, 16);
            this.radio_default.TabIndex = 32;
            this.radio_default.TabStop = true;
            this.radio_default.Text = "默认";
            this.radio_default.UseVisualStyleBackColor = true;
            // 
            // radio_tian
            // 
            this.radio_tian.AutoSize = true;
            this.radio_tian.Location = new System.Drawing.Point(16, 94);
            this.radio_tian.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radio_tian.Name = "radio_tian";
            this.radio_tian.Size = new System.Drawing.Size(47, 16);
            this.radio_tian.TabIndex = 36;
            this.radio_tian.Text = "公主";
            this.radio_tian.UseVisualStyleBackColor = true;
            // 
            // radio_collection
            // 
            this.radio_collection.AutoSize = true;
            this.radio_collection.Location = new System.Drawing.Point(16, 149);
            this.radio_collection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radio_collection.Name = "radio_collection";
            this.radio_collection.Size = new System.Drawing.Size(47, 16);
            this.radio_collection.TabIndex = 37;
            this.radio_collection.Text = "组合";
            this.radio_collection.UseVisualStyleBackColor = true;
            // 
            // radio_leng
            // 
            this.radio_leng.AutoSize = true;
            this.radio_leng.Location = new System.Drawing.Point(16, 68);
            this.radio_leng.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radio_leng.Name = "radio_leng";
            this.radio_leng.Size = new System.Drawing.Size(47, 16);
            this.radio_leng.TabIndex = 34;
            this.radio_leng.Text = "小冷";
            this.radio_leng.UseVisualStyleBackColor = true;
            // 
            // radio_leader
            // 
            this.radio_leader.AutoSize = true;
            this.radio_leader.Location = new System.Drawing.Point(16, 41);
            this.radio_leader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radio_leader.Name = "radio_leader";
            this.radio_leader.Size = new System.Drawing.Size(95, 16);
            this.radio_leader.TabIndex = 33;
            this.radio_leader.Text = "萌萌哒王学姐";
            this.radio_leader.UseVisualStyleBackColor = true;
            // 
            // Form_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 270);
            this.Controls.Add(this.btn_cannel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form_Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "主题";
            this.Load += new System.EventHandler(this.Form_Setting_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cannel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radio_ma;
        private System.Windows.Forms.RadioButton radio_default;
        private System.Windows.Forms.RadioButton radio_tian;
        private System.Windows.Forms.RadioButton radio_collection;
        private System.Windows.Forms.RadioButton radio_leng;
        private System.Windows.Forms.RadioButton radio_leader;
    }
}