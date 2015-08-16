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
    public partial class Form_Setting : Form
    {
        public Form_Setting()
        {
            InitializeComponent();
        }

        public Form_Setting(int left,int top)
        {
            InitializeComponent();
            this.Left = left+(Utils.formWidth - this.Width)/2;
            this.Top = top;
        }

        private void btn_cannel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Setting_Load(object sender, EventArgs e)
        {
            switch(Utils.theme)
            {
                case "default":
                    this.radio_default.Checked = true;
                    break;
                case "leader":
                    this.radio_leader.Checked = true;
                    break;
                case "leng":
                    this.radio_leng.Checked = true;
                    break;
                case "ma":
                    this.radio_ma.Checked = true;
                    break;
                case "tian":
                    this.radio_tian.Checked = true;
                    break;
                case "collection":
                    this.radio_collection.Checked = true;
                    break;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Utils.settingSign = true;
            if (radio_default.Checked) {
                Utils.picPath = "res_default";
                Utils.theme = "default";
            }
            else if(radio_leader.Checked){
                Utils.picPath = "res_leader";
                Utils.theme = "leader";
            }
            else if (radio_leng.Checked) {
                Utils.picPath = "res_leng";
                Utils.theme = "leng";
            }
            else if (radio_ma.Checked) {
                Utils.picPath = "res_ma";
                Utils.theme = "ma";
                Utils.arSign = true;
            }
            else if (radio_tian.Checked)
            {
                Utils.picPath = "res_tian";
                Utils.theme = "tian";
            }
            else if (radio_collection.Checked)
            {
                Utils.picPath = "res_collection";
                Utils.theme = "collection";
            }
            this.Close();
        }
    }
}
