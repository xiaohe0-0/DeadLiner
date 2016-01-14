using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeadLiner
{
    public partial class Form_Cal : Form
    {
        private const int day_pay = 170;
        private const int start_pay = 800;
        public Form_Cal()
        {
            InitializeComponent();
        }
        public Form_Cal(int left, int top)
        {
            InitializeComponent();
            this.Left = left;
            this.Top = top;
        }

        private void Form_Cal_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.lab_res.Text = "";
            this.lab_tucao.Text = "";
        }

        //计算
        private void btn_cal_Click(object sender, EventArgs e)
        {
            double res = 0;
            string tucao = "交不上税，对不起国家对不起党 థฺథ ";
            try
            {
                double days = double.Parse(this.text_days.Text.ToString());
                if (days < 0)
                {
                    MessageBox.Show("请输入正确的天数");
                }
                else
                {
                    res = day_pay * days;
                    if (res >= start_pay)
                    {
                        res -= start_pay;
                        double reCheck = 0.8 * res;
                        res = start_pay + reCheck;
                        int t = (int)res / 1000;
                        switch (t)
                        {
                            case 0:
                                tucao = "月入不够4位数 >﹏< ";
                                break;
                            case 1:
                                tucao = "千元大户，开心一下 ʅ(‾◡◝)ʃ ";
                                break;
                            case 2:
                                tucao = "上个月也是蛮拼的～♪( ´θ｀)ノ";
                                break;
                            default:
                                tucao = "土豪,我们做朋友吧，我宿舍在525! (◕‿◕)";
                                break;
                        }
                    }
                    this.lab_res.Text = res.ToString();
                    this.lab_tucao.Text = tucao;
                }
            }
            catch(Exception ex) {
                MessageBox.Show("请输入正确的天数");
            }
        }


    }
}
