using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class frmNewMember : Form
    {
        public frmNewMember()
        {
            InitializeComponent();
        }

        private void lblLibraryName_Click(object sender, EventArgs e)
        {

        }

        private void frmNewMember_Load(object sender, EventArgs e)
        {
            tmrMain_Tick(null, null);
            this.Text = clsPublicVariable.Library_Name;
            lblLibraryName.Text = clsPublicVariable.Library_Name;
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            clsPublicVariable.Now = DateTime.Now;
            clsPublicVariable.hour = clsPublicVariable.Now.Hour;
            clsPublicVariable.minute = clsPublicVariable.Now.Minute;
            clsPublicVariable.second = clsPublicVariable.Now.Second;
            lblClock.Text = clsPublicVariable.hour + " : " + clsPublicVariable.minute + " : " + clsPublicVariable.second;
            int PersianYear = clsPublicVariable.prsdate.GetYear(clsPublicVariable.Now);
            int PersianMonthNumber = clsPublicVariable.prsdate.GetMonth(clsPublicVariable.Now);
            int persianday = clsPublicVariable.prsdate.GetDayOfMonth(clsPublicVariable.Now);
            string PersianMonthName;
            string PersianDayName;
            switch (PersianMonthNumber)
            {
                case 1:
                    {
                        PersianMonthName = "فروردین";
                        break;
                    }
                case 2:
                    {
                        PersianMonthName = "اردیبهشت";
                        break;
                    }
                case 3:
                    {
                        PersianMonthName = "خرداد";
                        break;
                    }
                case 4:
                    {
                        PersianMonthName = "تیر";
                        break;
                    }
                case 5:
                    {
                        PersianMonthName = "مرداد";
                        break;
                    }
                case 6:
                    {
                        PersianMonthName = "شهریور";
                        break;
                    }
                case 7:
                    {
                        PersianMonthName = "مهر";
                        break;
                    }
                case 8:
                    {
                        PersianMonthName = "آبان";
                        break;
                    }
                case 9:
                    {
                        PersianMonthName = "آذر";
                        break;
                    }
                case 10:
                    {
                        PersianMonthName = "دی";
                        break;
                    }
                case 11:
                    {
                        PersianMonthName = "بهمن";
                        break;
                    }
                case 12:
                    {
                        PersianMonthName = "اسفند";
                        break;
                    }
                default:
                    {
                        PersianMonthName = "";
                        break;
                    }
            }
            switch (clsPublicVariable.Now.DayOfWeek)
            {
                case (DayOfWeek)clsPublicVariable.week.shanbe:
                    {
                        PersianDayName = "شنبه";
                        break;
                    }
                case (DayOfWeek)clsPublicVariable.week.yekshanbe:
                    {
                        PersianDayName = "یک شنبه";
                        break;
                    }
                case (DayOfWeek)clsPublicVariable.week.doshanbe:
                    {
                        PersianDayName = "دوشنبه";
                        break;
                    }
                case (DayOfWeek)clsPublicVariable.week.seshanbe:
                    {
                        PersianDayName = "سه شنبه";
                        break;
                    }
                case (DayOfWeek)clsPublicVariable.week.chaharshanbe:
                    {
                        PersianDayName = "چهارشنبه";
                        break;
                    }
                case (DayOfWeek)clsPublicVariable.week.panjshanbe:
                    {
                        PersianDayName = "پنج شنبه";
                        break;
                    }
                case (DayOfWeek)clsPublicVariable.week.jome:
                    {
                        PersianDayName = "جمعه";
                        break;
                    }
                default:
                    {
                        PersianDayName = "";
                        break;
                    }
            }
            lblDate.Text = string.Format("امروز {0} {1} {2} {3}", PersianDayName, persianday, PersianMonthName, PersianYear);

        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            try
            {
                string firstname = txtFirstName.Text;
                string lastname = txtLastName.Text;
                string nationalcode = txtNationalCode.Text;
                int birthyear = Convert.ToInt32(txtBirthYear.Text);
                int birthmonth = Convert.ToInt32(txtBirthMonth.Text);
                int birthday = Convert.ToInt32(txtBirthday.Text);
                bool proccess = clsPublicVariable.Member_Regisrtation(firstname, lastname, birthyear, birthmonth, birthday, nationalcode);
                if (proccess)
                {
                    MessageBox.Show("ثبت نام انجام شد");
                }
                else
                {
                    MessageBox.Show("عملیات به درستی انجام نشد");
                }
            }
            catch
            {
                MessageBox.Show("لطفا تمام قسمت ها را به دقت پر کنید");
            }
        }
    }
}
