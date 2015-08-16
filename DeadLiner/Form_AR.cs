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
    public partial class Form_AR : Form
    {
        private int count = 0;
        public Form_AR()
        {
            InitializeComponent();
        }

        private void Form_AR_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.ControlBox = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count > 3)
            {
                timer1.Stop();
                this.Close();
                Utils.arSign = false;
            }
            count++;
        }

        private void Form_AR_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
