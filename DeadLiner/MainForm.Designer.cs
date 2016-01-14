namespace DeadLiner
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pannelList = new System.Windows.Forms.TableLayoutPanel();
            this.timer_showAlert = new System.Windows.Forms.Timer(this.components);
            this.timer_countdown = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btn_add = new System.Windows.Forms.ToolStripStatusLabel();
            this.split1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_delete = new System.Windows.Forms.ToolStripStatusLabel();
            this.split2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_update = new System.Windows.Forms.ToolStripStatusLabel();
            this.split3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_cal = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pannelList
            // 
            this.pannelList.AutoScroll = true;
            this.pannelList.ColumnCount = 1;
            this.pannelList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pannelList.Location = new System.Drawing.Point(4, 28);
            this.pannelList.Margin = new System.Windows.Forms.Padding(0);
            this.pannelList.Name = "pannelList";
            this.pannelList.RowCount = 1;
            this.pannelList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pannelList.Size = new System.Drawing.Size(448, 798);
            this.pannelList.TabIndex = 0;
            // 
            // timer_showAlert
            // 
            this.timer_showAlert.Tick += new System.EventHandler(this.timer_showAlert_Tick);
            // 
            // timer_countdown
            // 
            this.timer_countdown.Interval = 1000;
            this.timer_countdown.Tick += new System.EventHandler(this.timer_countdown_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_add,
            this.split1,
            this.btn_delete,
            this.split2,
            this.btn_update,
            this.split3,
            this.btn_cal});
            this.statusStrip1.Location = new System.Drawing.Point(0, 873);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(462, 29);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btn_add
            // 
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(46, 24);
            this.btn_add.Text = "添加";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // split1
            // 
            this.split1.Name = "split1";
            this.split1.Size = new System.Drawing.Size(15, 24);
            this.split1.Text = "|";
            // 
            // btn_delete
            // 
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(46, 24);
            this.btn_delete.Text = "删除";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // split2
            // 
            this.split2.Name = "split2";
            this.split2.Size = new System.Drawing.Size(15, 24);
            this.split2.Text = "|";
            // 
            // btn_update
            // 
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(46, 24);
            this.btn_update.Text = "主题";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // split3
            // 
            this.split3.Name = "split3";
            this.split3.Size = new System.Drawing.Size(15, 24);
            this.split3.Text = "|";
            // 
            // btn_cal
            // 
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(46, 24);
            this.btn_cal.Text = "收入";
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 902);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pannelList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DeadLiner";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pannelList;
        private System.Windows.Forms.Timer timer_showAlert;
        private System.Windows.Forms.Timer timer_countdown;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel btn_add;
        private System.Windows.Forms.ToolStripStatusLabel split1;
        private System.Windows.Forms.ToolStripStatusLabel btn_delete;
        private System.Windows.Forms.ToolStripStatusLabel split2;
        private System.Windows.Forms.ToolStripStatusLabel btn_update;
        private System.Windows.Forms.ToolStripStatusLabel split3;
        private System.Windows.Forms.ToolStripStatusLabel btn_cal;



    }
}

