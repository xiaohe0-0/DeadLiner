using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL;

namespace DeadLiner
{
    public class Utils
    {

        public static int formLeft = 0;
        public static int formTop = 0;
        public static int formWidth = 0;
        public static bool addSign = false;
        public static DBServer dbs;//BLL调用
        public static bool updateSign = false;
        public static bool settingSign = false;
        public static string theme = "default";
        public static string picPath = "res_default";
        public static string clock_blue= "Images/"+picPath+"/clock_blue.png";
        public static string clock_red = "Images/" + picPath + "/clock_red.png";
        public static string clock_yellow = "Images/" + picPath + "/clock_yellow.png";
        public static string shakeBG = "Images/" + picPath + "/shakeBG.png";
        public static string remindBG = "Images/" + picPath + "/remind_clock.png";
        public static bool arSign = false;
        public static string getShakeBG()
        {
            return "Images/" + picPath + "/shakeBG.png";
        }

        public static string getClock_red()
        {
            return "Images/" + picPath + "/clock_red.png";
        }

        public static string getClock_blue()
        {
            return "Images/" + picPath + "/clock_blue.png";
        }

        public static string getClock_yellow()
        {
            return "Images/" + picPath + "/clock_yellow.png";
        }

        public static string getRemindBG() {
            return "Images/" + picPath + "/remind_clock.png"; 
        }
    }
}
