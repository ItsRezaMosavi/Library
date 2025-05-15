using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class clsPublicVariable
    {
        public static DateTime dt = new DateTime();
        public static PersianCalendar pr = new PersianCalendar();
        public static View_Employee User { get; set; }
        public static string nowDate()
        {
            dt = DateTime.Now;
            string now = pr.GetYear(dt) + "/";
            string month = pr.GetMonth(dt) + "/";
            if (month.Length == 1)
                month = "0" + month;
            string day = pr.GetDayOfMonth(dt) + "";
            if (day.Length == 1)
                day = "0" + day;
            now += month + day;
            return now;
        }
        public static string nowday()
        {
            dt = DateTime.Now;
            string day = pr.GetDayOfMonth(dt) + "";
            if (day.Length == 1)
                day = "0" + day;
            return day;
        }
        public static string nowMonth()
        {
            dt = DateTime.Now;
            string Month = pr.GetMonth(dt) + "";
            if (Month.Length == 1)
                Month = "0" + Month;
            return Month;
        }
        public static string nowyear()
        {
            dt = DateTime.Now;
            return pr.GetYear(dt) + "";
        }
        public static string dayofweek()
        {
            dt = DateTime.Now;
            string dayofweek = "";
            int daynum = Convert.ToInt32(dt.DayOfWeek);
            switch (daynum)
            {
                case 0:
                    dayofweek = "یکشنبه";
                    break;
                case 1:
                    dayofweek = "دوشنبه";
                    break;
                case 2:
                    dayofweek = "سه شنبه";
                    break;
                case 3:
                    dayofweek = "چهار شنبه";
                    break;
                case 4:
                    dayofweek = "پنج شنبه";
                    break;
                case 5:
                    dayofweek = "جمعه";
                    break;
                case 6:
                    dayofweek = "شنبه";
                    break;
                default:
                    break;
            }
            return dayofweek;
        }
    }
}
