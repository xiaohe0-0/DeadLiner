namespace DeadLiner
{
    partial class Form_Cal
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
            this.text_days = new System.Windows.Forms.TextBox();
            this.lab_days = new System.Windows.Forms.Label();
            this.btn_cal = new System.Windows.Forms.Button();
            this.lab_res = new System.Windows.Forms.Label();
            this.lab_tucao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_days
            // 
            this.text_days.Location = new System.Drawing.Point(147, 36);
            this.text_days.Name = "text_days";
            this.text_days.Size = new System.Drawing.Size(152, 28);
            this.text_days.TabIndex = 0;
            // 
            // lab_days
            // 
            this.lab_days.AutoSize = true;
            this.lab_days.Location = new System.Drawing.Point(79, 39);
            this.lab_days.Name = "lab_days";
            this.lab_days.Size = new System.Drawing.Size(62, 18);
            this.lab_days.TabIndex = 1;
            this.lab_days.Text = "天数：";
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(116, 84);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(75, 43);
            this.btn_cal.TabIndex = 2;
            this.btn_cal.Text = "计算";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // lab_res
            // 
            this.lab_res.AutoSize = true;
            this.lab_res.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_res.ForeColor = System.Drawing.Color.Blue;
            this.lab_res.Location = new System.Drawing.Point(197, 93);
            this.lab_res.Name = "lab_res";
            this.lab_res.Size = new System.Drawing.Size(82, 21);
            this.lab_res.TabIndex = 3;
            this.lab_res.Text = "label1";
            // 
            // lab_tucao
            // 
            this.lab_tucao.AutoSize = true;
            this.lab_tucao.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_tucao.Location = new System.Drawing.Point(12, 140);
            this.lab_tucao.Name = "lab_tucao";
            this.lab_tucao.Size = new System.Drawing.Size(62, 18);
            this.lab_tucao.TabIndex = 4;
            this.lab_tucao.Text = "label1";
            // 
            // Form_Cal
            // 
            this.AcceptButton = this.btn_cal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 178);
            this.Controls.Add(this.lab_tucao);
            this.Controls.Add(this.lab_res);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.lab_days);
            this.Controls.Add(this.text_days);
            this.Name = "Form_Cal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "算账";
            this.Load += new System.EventHandler(this.Form_Cal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_days;
        private System.Windows.Forms.Label lab_days;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Label lab_res;
        private System.Windows.Forms.Label lab_tucao;
    }
}