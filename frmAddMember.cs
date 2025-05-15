using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class frmAddMember : Form
    {
        Random rnd = new Random();

        public frmAddMember()
        {
            InitializeComponent();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            Library_DBEntities db = new Library_DBEntities();
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtNationalCode.Text == "" || cmbGender.Text == "" ||
                cmbBirthDay.Text == "" || cmbBirthMonth.Text == "" || cmbBirthYear.Text == "")
            {
                pnlIdentity.BackColor = Color.Red;
                MessageBox.Show("کادر های الزامی را پر کنید");
                return;
            }

            if (db.tblMembers.Any(u => u.NationalCode == txtNationalCode.Text))
            {
                MessageBox.Show("این کد ملی قبلا ثبت نام کرده است", "اخطار");
                return;
            }

            int month = Convert.ToInt32(cmbBirthMonth.Text);
            int day = Convert.ToInt32(cmbBirthDay.Text);
            int year = Convert.ToInt32(cmbBirthYear.Text);

            if (year > Convert.ToInt32(clsPublicVariable.nowyear()) - 8)
            {
                MessageBox.Show("حداقل سن لازم برای ثبت نام 8 سال است");
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

            tblMember NewMember = new tblMember();
            NewMember.FirstName = txtFirstName.Text;
            NewMember.LastName = txtLastName.Text;
            NewMember.Gender = cmbGender.Text;
            NewMember.NationalCode = txtNationalCode.Text;
            NewMember.Birth = cmbBirthYear.Text + "/" + cmbBirthMonth.Text + "/" + cmbBirthDay.Text;
            NewMember.Province = txtProvince.Text;
            NewMember.City = txtCity.Text;
            NewMember.Address = txtAddress.Text;
            NewMember.FatherName = txtFatherName.Text;
            NewMember.MotherName = txtMotherName.Text;
            NewMember.PhoneNumber = txtPhoneNumber.Text;
            NewMember.Email = txtEmail.Text;
            string Id = rnd.Next(2000, 10000).ToString();
            Id += cmbBirthYear.Text.Substring(2, 2);
            Id += clsPublicVariable.nowyear().Substring(1, 3);
            NewMember.MemberId = Id;
            NewMember.JoinDate = clsPublicVariable.nowDate();
            NewMember.Description = txtDescription.Text;
            db.tblMembers.Add(NewMember);
            db.SaveChanges();
            txtId.Text = Id;
            MessageBox.Show("با موفقیت عضو شد \n کد عضویت : " + Id);
            lblId.Visible = true;
            txtId.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAddMember_Load(object sender, EventArgs e)
        {
            tmrClock_Tick(null, null);
            lblId.Visible = false;
            txtId.Visible = false;
            for (int i = 1300; i <= Convert.ToInt32(clsPublicVariable.nowyear()) - 8; i++)
                cmbBirthYear.Items.Add(i.ToString());
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();

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

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            clsPublicVariable.dt = DateTime.Now;
            lblClock.Text = string.Format("{2} : {1} : {0}", clsPublicVariable.dt.Hour, clsPublicVariable.dt.Minute, clsPublicVariable.dt.Second);
            lblDate.Text = string.Format(" {0}  {1} / {2} / {3}", clsPublicVariable.dayofweek(), clsPublicVariable.nowday(), clsPublicVariable.nowMonth(), clsPublicVariable.nowyear());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
