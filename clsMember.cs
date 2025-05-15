using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace library
{
    public class clsMember
    {
        private string _id;
        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value.Length == 10)
                    _id = value;
            }
        }
        private string _firstname;
        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                if (value != "")
                    _firstname = value.ToLower();
            }
        }
        private string _lastname;
        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                if (value != "")
                    _lastname = value.ToLower();
            }
        }

        private string _nationalcode;
        public string NationalCode
        {
            get
            {
                return _nationalcode;
            }
            set
            {
                //if (clsPublicVariable.NationalCode_Check(value))
                //    _nationalcode = value;
                //else
                //    MessageBox.Show("کد ملی غلط می باشد");
                _nationalcode = value;
            }
        }

        private int _registrationyear;
        public int RegistrationYear
        {
            get
            {
                return _registrationyear;
            }
            set
            {
                if (value > 999 && value < 10000)
                    _registrationyear = value;

            }
        }
        private int _registrationmonth;
        public int RegistrationMonth
        {
            get
            {
                return _registrationmonth;
            }
            set
            {
                if (value >= 1 && value <= 12)
                    _registrationmonth = value;
            }
        }
        private int _registrationday;
        public int RegistrationDay
        {
            get
            {
                return _registrationday;
            }
            set
            {
                if (value >= 1 && value <= 31)
                    _registrationday = value;
            }
        }

        private int _birthyear;
        public int BirthYear
        {
            get
            {
                return _birthyear;
            }
            set
            {
                if (value > 999 && value < 10000)
                    _registrationyear = value;
            }
        }
        private int _birthmonth;
        public int BirthMonth
        {
            get
            {
                return _birthmonth;
            }
            set
            {
                if (value >= 1 && value <= 12)
                    _birthmonth = value;
            }
        }
        private int _birthday;
        public int BirthDay
        {
            get
            {
                return _birthday;
            }
            set
            {
                if (value >= 1 && value <= 31)
                    _birthday = value;
            }
        }

        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 8)
                    _age = value;
                else
                    MessageBox.Show("سن شما برای ثبت نام کم است");
            }
        }

        public static List<clsMember> members = new List<clsMember>();
    }
}
