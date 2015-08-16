using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace DeadLiner
{
    public partial class Form_Shaking : Form
    {
        public Form_Shaking()
        {
            InitializeComponent();
        }

        private void Form_Shaking_Load(object sender, EventArgs e)
        {
            timer_wait.Start();
            this.pictureBox_shaking.BackgroundImage = new Bitmap(Utils.getShakeBG());
        }

        private void formShake()
        {
            //记录窗体的初始位置

            Point p = new Point(this.Location.X, this.Location.Y);

            //初始化Random对象

            Random r = new Random();

            //循环移动窗体位置,可以自己修改循环次数,次数越多,抖动时间越长

            for (int i = 0; i <= 2; i++)
            {

                //在窗体原来的位置的基础上随机改变窗体的坐标位置,其中的随机数区间可以随意修改,数值越大,抖动幅度越大,最好正负成对

                this.Location = new Point(p.X + r.Next(-50, 50), p.Y + r.Next(-50, 50));

                //主线程休息50ms,可以自行修改,数值越大,抖动越慢

                Thread.Sleep(10);

                //让窗体回到初始位置

                this.Location = p;

                //主线程休息50ms,可以自行修改,数值越大,抖动越慢

                Thread.Sleep(10);

            }

        }

        private void timer_wait_Tick(object sender, EventArgs e)
        {
            formShake();
            timer_wait.Stop();
        }
    }
}
