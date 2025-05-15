using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class clsUser
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
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 20)
                    _age = value;
                else
                    MessageBox.Show("سن شما کمتر از 20 سال است");
            }
        }
        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (clsPublicVariable.SignIn_Password_Check(value))
                    _password = value;
                else
                {
                    MessageBox.Show("رمز شما قابل قبول نیست");
                }
            }
        }

        public static List<clsUser> users = new List<clsUser>();

    }
}
