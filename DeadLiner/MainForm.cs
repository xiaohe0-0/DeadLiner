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
    public partial class MainForm : Form
    {
        //变量
        private DataTable dt;
        private UserItem uItem;
        private List<UserItem> userList;//存放所有的UserItem
        private bool remindSign = false;
        private List<string> countdownList;
        private List<int> countdownID;
        private Form_Remind fr;
        private int curID;

        //常量
        public const String TABLENAME = "DeadLine";

        public MainForm()
        {
            InitializeComponent();
        }

        //初始化
        private void MainForm_Load(object sender, EventArgs e)
        {
            //设置窗体初始的位置
            double screenX = Screen.GetWorkingArea(this).Width;//得到屏幕整体宽度
            this.Left = int.Parse((screenX * 0.75).ToString());//设置窗体与左边的距离
            //double screenY = Screen.GetWorkingArea(this).Height;//得到屏幕整体高度
            //this.Top = int.Parse((screenY * 0.1).ToString());//设置窗体与上边的距离
            this.Top = 100;//设置窗体与上边的距离

            //初始化数据
            userList = new List<UserItem>();
            countdownList = new List<string>();
            countdownID = new List<int>();
            fr = null;

            //得到数据库数据
            GetDeadLineData();
            if (userList.Count > 0)
            {
                userList[0].SetBackColor(0);
                UserItem.setCurID(userList[0].UserID);
            }
            else {
                EmptyItem ei = new EmptyItem();
                pannelList.Controls.Add(ei);
            }

            //设置Utils的TOP&LEFT
            Utils.formTop = this.Top + this.Height / 3;
            Utils.formLeft = this.Left;
            Utils.formWidth = this.Width;

            //显示提醒
            timer_showAlert.Start();
        }

        private void GetDeadLineData()
        {
            //得到数据库中的数据
            Utils.dbs = new DBServer();
           // dbs = 
            dt = Utils.dbs.GetAllData(TABLENAME);
            //int cols = dt.Columns.Count;
            int rows = dt.Rows.Count;
            pannelList.RowCount = rows;
            string textTime = "";
            string textContent = "";
            int userID;
            var img = new Bitmap(Utils.getClock_blue()); 


            //获取系统时间
            DateTime systemNow = DateTime.Now.Date;
            //DateTime systemNow = DateTime.Now;
            countdownList.Clear();
            countdownID.Clear();

            for (int ri = 0; ri < rows; ri++)
            {
                userID = int.Parse(dt.Rows[ri][0].ToString());
                textTime = dt.Rows[ri][1].ToString();
                textContent = dt.Rows[ri][2].ToString();

                //根据时间设置图片
                DateTime dtFormat = Convert.ToDateTime(textTime.Substring(0, textTime.IndexOf(" ")+1) + "0:00:00");
                //DateTime dtFormat = Convert.ToDateTime(textTime);
            
                if (DateTime.Compare(dtFormat, systemNow) > 0)
                {
                    img = new Bitmap(Utils.getClock_blue());
                }
                else if (DateTime.Compare(dtFormat, systemNow) < 0)
                {
                    img = new Bitmap(Utils.getClock_red());
                }
                else
                {
                    img = new Bitmap(Utils.getClock_yellow());
                    remindSign = true;
                    String nowTime = System.DateTime.Now.ToString("HH:mm:ss");
                    String compareTime = DateTime.Parse(textTime.Substring(10)).ToString("HH:mm:ss");
                    if (compareTime.CompareTo(nowTime) > 0)
                    {
                        countdownList.Add(textTime.Substring(10));
                        countdownID.Add(userID);
                        if (!timer_countdown.Enabled)
                        {
                            timer_countdown.Start();
                        }
                    }
                    else {
                        img = new Bitmap(Utils.getClock_red());
                    }
                }

                uItem = new UserItem(this)
                {
                    Image = img,
                    UserID = userID,
                    TextTime = textTime,
                    TextContent = textContent
                };
                userList.Add(uItem);
                pannelList.Controls.Add(uItem);
            }
           
        }


        public void SetItemBG()
        {
            for (int i = 0; i < userList.Count;i++ )
            {
                if (userList[i].UserID != UserItem.GetCurID())
                {
                    userList[i].SetBackColor(1);//设置背景为SystemColor.Control
                }
                else
                {
                    userList[i].SetBackColor(0);//设置背景为选中色
                }
            }
        }


        //删除某条deadline
        private void btn_delete_Click(object sender, EventArgs e)
        {
            curID = UserItem.GetCurID();
            if (curID < 0)
            {
                MessageBox.Show("请选择需要删除的Deadline");
                return;
            }

            if (DialogResult.OK == MessageBox.Show("确定删除选中的DeadLine吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
            {
                for (int i = 0; i < userList.Count; i++)
                {
                    if (userList[i].UserID == curID)
                    {
                        userList.RemoveAt(i);
                        pannelList.Controls.RemoveAt(i);
                        pannelList.RowCount--;
                        if (pannelList.RowCount == 0)
                        {
                            EmptyItem ei = new EmptyItem();
                            pannelList.Controls.Clear();
                            pannelList.Controls.Add(ei);
                        }
                        try
                        {
                            if (!Utils.dbs.DeleteOneItem(TABLENAME, curID))
                            {
                                MessageBox.Show("删除失败");
                            }
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        break;
                    }
                }
            }
        }

        public void FreshItem(){
            pannelList.Controls.Clear();
            pannelList.RowCount = 0;
            userList.Clear();
            GetDeadLineData();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Form_ADD fa = new Form_ADD(Utils.formLeft, Utils.formTop);
            Utils.addSign = false;
            fa.ShowDialog();

            if (Utils.addSign)
            {
                FreshItem();
            }
        }

        private void MainForm_LocationChanged(object sender, EventArgs e)
        {
            Utils.formTop = this.Top + this.Height / 3;
            Utils.formLeft = this.Left;
            Utils.formWidth = this.Width;
        }

        private void timer_showAlert_Tick(object sender, EventArgs e)
        {
            timer_showAlert.Stop();
            if (remindSign)
            {
                fr = new Form_Remind();
                fr.Show();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Utils.settingSign = false;
            Form_Setting fs = new Form_Setting(Utils.formLeft,Utils.formTop);
            fs.ShowDialog();
            if(Utils.settingSign){
                FreshItem();
                if (fr != null)
                {
                    fr.setClock();
                }
            }
        }

        private void timer_countdown_Tick(object sender, EventArgs e)
        {
            if (countdownList.Count < 1)
            {
                timer_countdown.Stop();
            }
            String now = System.DateTime.Now.ToString("HH:mm:ss");
            //MessageBox.Show(now);
            for (int i = 0; i < countdownList.Count; i++)
            {
                String compareDate = DateTime.Parse(countdownList[i]).ToString("HH:mm:ss");
                if (compareDate.CompareTo(now) == 0) {
                    countdownList.RemoveAt(i);

                    Utils.myRemindState = (int)Utils.remindState.NoAction;
                    Form_Shaking fs = new Form_Shaking();
                    fs.ShowDialog();

                    //延迟一小时
                    if (Utils.myRemindState == (int)Utils.remindState.DelayOneHour) {
                        //生成新的时间 延迟一小时
                        DataTable oriTable = Utils.dbs.GetCon(countdownID[i]);
                        String oriDateTime = oriTable.Rows[0][1].ToString();
                        String[] oriDateSplit = oriDateTime.Split(' ');
                        String[] oriTimeSplit = oriDateSplit[1].Split(':');
                        int newHour = int.Parse(oriTimeSplit[0]);
                        newHour++;
                        if (newHour < 24) {
                            String newDateTime = oriDateSplit[0] + " " + newHour + ":" + oriTimeSplit[1] + ":" + oriTimeSplit[2];
              
                            try
                            {             
                                if (!Utils.dbs.UpdateOneTime(countdownID[i],newDateTime))
                                {
                                    MessageBox.Show("更改失败");
                                }
                            }
                            catch (System.Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }
                       
                    }

                    //延迟一天
                    if (Utils.myRemindState == (int)Utils.remindState.DelayOneDay) {
                        //生成新的时间 延迟一天
                        DataTable oriTable = Utils.dbs.GetCon(countdownID[i]);
                        String oriDateTime = oriTable.Rows[0][1].ToString();
                        String[] oriTimeSplit = oriDateTime.Split(' ');
                        String[] oriDateSplit = oriTimeSplit[0].Split('/');
                        int oriDay = int.Parse(oriDateSplit[2]);
                        oriDay++;
                        String newDateTime = oriDateSplit[0] + "/" + oriDateSplit[1] + "/" + oriDay + " " + oriTimeSplit[1];

                        //此处无日期的正确性验证
                        try
                        {
                            if (!Utils.dbs.UpdateOneTime(countdownID[i], newDateTime))
                            {
                                MessageBox.Show("更改失败");
                            }
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    FreshItem();
                    break;
                }
            }
        }

        //计算工资
        private void btn_cal_Click(object sender, EventArgs e)
        {
            Form_Cal fc = new Form_Cal(Utils.formLeft, Utils.formTop);
            fc.ShowDialog();
        }


    }
}