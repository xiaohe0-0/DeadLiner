using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace DeadLiner
{
    public partial class Form_ADD : Form
    {
        public Form_ADD()
        {
            InitializeComponent();
        }

        public Form_ADD(int left,int top)
        {
            InitializeComponent();
            this.Left = left;
            this.Top = top;
        }

        private void Form_ADD_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            timer_clock.Start();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string addContent = this.textContent.Text.Trim().ToString();
            if (addContent == "")
            {
                MessageBox.Show("不能没有死期内容");
            }
            else if (addContent.Length > 20)
            {
                MessageBox.Show("死期内容超长");
            }
            else
            {
                try
                {
                    String addData = this.now_date.Value.ToString("yyyy/MM/dd ")
                        +this.now_time.Value.ToString("HH:mm:ss");
                    if (!Utils.dbs.AddOneItem(addData, addContent))
                    {
                        MessageBox.Show("添加失败");
                    }
                    else
                    {
                        Utils.addSign = true;
                        this.Close();
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btn_cannel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer_clock_Tick(object sender, EventArgs e)
        {
            DateTime now = System.DateTime.Now;
            this.strip_time.Text = now.Hour + ":" + now.Minute + ":" + now.Second;
        }

    }
}
