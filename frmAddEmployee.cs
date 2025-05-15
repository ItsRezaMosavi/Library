using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class frmAddEmployee : Form
    {
        Random rnd = new Random();
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            clsPublicVariable.dt = DateTime.Now;
            lblClock.Text = string.Format("{2} : {1} : {0}", clsPublicVariable.dt.Hour, clsPublicVariable.dt.Minute, clsPublicVariable.dt.Second);
            lblDate.Text = string.Format(" {0}  {1} / {2} / {3}", clsPublicVariable.dayofweek(), clsPublicVariable.nowday(), clsPublicVariable.nowMonth(), clsPublicVariable.nowyear());
        }

        private void frmAddEmploee_Load(object sender, EventArgs e)
        {
            tmrClock_Tick(null, null);
            pnlLogIn.Visible = false;
            for (int i = 1300; i <= Convert.ToInt32(clsPublicVariable.nowyear()) - 8; i++)
                cmbBirthYear.Items.Add(i.ToString());
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Library_DBEntities db = new Library_DBEntities();
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtNationalCode.Text == "" || cmbGender.Text == "" ||
                cmbBirthDay.Text == "" || cmbBirthMonth.Text == "" || cmbBirthYear.Text == "")
            {
                pnlIdentity.BackColor = Color.Red;
                MessageBox.Show("کادر های الزامی را پر کنید");
                return;
            }

            if (db.tblEmployees.Any(u => u.NationalCode == txtNationalCode.Text))
            {
                MessageBox.Show("این کد ملی قبلا ثبت نام کرده است", "اخطار");
                return;
            }

            int month = Convert.ToInt32(cmbBirthMonth.Text);
            int day = Convert.ToInt32(cmbBirthDay.Text);
            int year = Convert.ToInt32(cmbBirthYear.Text);

            if (year > Convert.ToInt32(clsPublicVariable.nowyear()) - 20)
            {
                MessageBox.Show("حداقل سن لازم برای استخدام 20 سال است");
                pnlIdentity.BackColor = Color.Red;
                return;
            }
            if (year % 4 == 3 && month > 6 && day == 31)
            {
                pnlIdentity.BackColor = Color.Red;
                MessageBox.Show("تاریخ تولد را به درستی وارد کنید");
                return;
            }
            if (year % 4 != 3 && month > 6)
            {
                if (day == 31)
                {
                    pnlIdentity.BackColor = Color.Red;
                    MessageBox.Show("تاریخ تولد را به درستی وارد کنید");
                    return;
                }
                if (month == 12 && day == 30)
                {
                    pnlIdentity.BackColor = Color.Red;
                    MessageBox.Show("تاریخ تولد را به درستی وارد کنید");
                    return;
                }
            }
            pnlIdentity.BackColor = SystemColors.Control;

            if (txtFatherName.Text == "" || txtMotherName.Text == "")
            {
                pnlParentsName.BackColor = Color.Red;
                MessageBox.Show("کادر های الزامی را پر کنید");
                return;
            }
            pnlParentsName.BackColor = SystemColors.Control;
            if (txtAddress.Text == "" || txtCity.Text == "" || txtProvince.Text == "")
            {
                pnlAddress.BackColor = Color.Red;
                MessageBox.Show("کادر های الزامی را پر کنید");
                return;
            }
            pnlAddress.BackColor = SystemColors.Control;
            if (txtPhoneNumber.Text == "")
            {
                pnlConnection.BackColor = Color.Red;
                MessageBox.Show("لطفا کادر های الزامی را پر کنید");
                return;
            }
            pnlConnection.BackColor = SystemColors.Control;


            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string UserName = alphabet.Substring(rnd.Next(0, 25), 1);
            UserName += rnd.Next(1000, 2000).ToString();
            UserName += cmbBirthYear.Text.Substring(2, 2);
            UserName += clsPublicVariable.nowyear().Substring(1, 3);
            tblEmployee employee = new tblEmployee()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Gender = cmbGender.Text,
                NationalCode = txtNationalCode.Text,
                Birth = cmbBirthYear.Text + "/" + cmbBirthMonth.Text + "/" + cmbBirthDay.Text,
                Province = txtProvince.Text,
                City = txtCity.Text,
                Address = txtAddress.Text,
                FatherName = txtFatherName.Text,
                MotherName = txtMotherName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Email = txtEmail.Text,
                UserName = UserName,
                Description = txtDescription.Text,
                Password = txtNationalCode.Text
            };
            db.tblEmployees.Add(employee);

            txtUserName.Text = employee.UserName;
            txtPassWord.Text = employee.Password;
            pnlLogIn.Visible = true;
            db.SaveChanges();
            
            tblEmployeeAccess employeeAccess = new tblEmployeeAccess()
            {
                EmployId = employee.Id,
            };
            db.tblEmployeeAccesses.Add(employeeAccess);
            db.SaveChanges();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbBirthDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBirthDay.Text.Length == 1)
                cmbBirthDay.Text = "0" + cmbBirthDay.Text;
        }

        private void cmbBirthMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBirthMonth.Text.Length == 1)
                cmbBirthMonth.Text = "0" + cmbBirthMonth.Text;
        }
    }
}
