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
    public partial class Form_Update : Form
    {
        private int userId = 0;
        public Form_Update()
        {
            InitializeComponent();
        }

        public Form_Update(int left,int top)
        {
            InitializeComponent();
            this.Left = left;
            this.Top = top;
        }

        private void Form_Update_Load(object sender, EventArgs e)
        {
            userId = UserItem.GetCurID();
            DataTable dt = Utils.dbs.GetCon(userId);
            string[] datetime = dt.Rows[0]["DateItem"].ToString().Split(' ');

            set_date.Value = DateTime.Parse(datetime[0]);
            set_time.Value = DateTime.Parse(datetime[1]);
            textContent.Text = dt.Rows[0]["ContentItem"].ToString();

            timer_clock.Start();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string setContent = this.textContent.Text.ToString().Trim();
            if (setContent == "")
            {
                MessageBox.Show("不能没有死期内容");
            }
            else if (setContent.Length > 20)
            {
                MessageBox.Show("死期内容超长");
            }
            else
            {
                try
                {
                    String setData = this.set_date.Value.ToString("yyyy/MM/dd ")
                        + this.set_time.Value.ToString("HH:mm:ss");
                    if (!Utils.dbs.UpdateOneItem(userId,setData, setContent))
                    {
                        MessageBox.Show("更改失败");
                    }
                    else
                    {
                        Utils.updateSign = true;
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
            this.strip_time.Text = now.Hour+":"+now.Minute+":"+now.Second;
        }
    }
}
