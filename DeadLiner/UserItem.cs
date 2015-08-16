using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeadLiner
{
    public partial class UserItem : UserControl
    {
        private static int userHeight = 56;
        private int userID;
        private static int curID = -1;
        private MainForm mainForm;


        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public UserItem()
        {
            InitializeComponent();
        }
        public UserItem(MainForm mf)
        {
            this.mainForm = mf;
            InitializeComponent();
        }

        public Image Image
        {
            get { return pic_clock.BackgroundImage; }
            set { pic_clock.BackgroundImage = value; }
        }

        public string TextTime
        {
            get { return lab_time.Text; }
            set { lab_time.Text = value; }
        }

        public string TextContent
        {
            get { return lab_content.Text; }
            set { lab_content.Text = value; }
        }

        static public int GetUserHeight()
        {
            return userHeight;
        }

        private void UserItem_Load(object sender, EventArgs e)
        {
            this.pic_clock.BackgroundImageLayout = ImageLayout.Zoom;
        }

        public void SetBackColor(int sign)
        {
            if (0 == sign)
            {
                this.BackColor = Color.Gray;
            } 
            else
            {
                this.BackColor = SystemColors.Control;
            }
        }

        public void clickEvent()
        {
            curID = userID;
            this.mainForm.SetItemBG();
        }

        private void UserItem_Click(object sender, EventArgs e)
        {
            clickEvent();
        }


        private void lab_time_Click(object sender, EventArgs e)
        {
            clickEvent();
        }


        private void pic_clock_Click(object sender, EventArgs e)
        {
            clickEvent();
        }

        private void lab_content_Click(object sender, EventArgs e)
        {
            clickEvent();
        }

        static public int GetCurID()
        {
            return curID;
        }
        static public void setCurID(int id)
        {
            curID = id;
        }

        private void doubleClickEvent()
        {
            Utils.updateSign = false;
            Form_Update fp = new Form_Update(Utils.formLeft, Utils.formTop);
            fp.ShowDialog();

            if (Utils.updateSign)
            {
                this.mainForm.FreshItem();
            }
        }
        private void UserItem_DoubleClick(object sender, EventArgs e)
        {
            doubleClickEvent();
        }

        private void lab_time_DoubleClick(object sender, EventArgs e)
        {
            doubleClickEvent();
        }

        private void lab_content_DoubleClick(object sender, EventArgs e)
        {
            doubleClickEvent();
        }

        private void pic_clock_DoubleClick(object sender, EventArgs e)
        {
            doubleClickEvent();
        }


    }
}
