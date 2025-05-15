using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class frmMemebersManagement : Form
    {
        public frmMemebersManagement()
        {
            InitializeComponent();
        }

        private void frmMemebersManagement_Load(object sender, EventArgs e)
        {
            tmrClock_Tick(null, null);
            dgvMembers.Rows.Clear();
            Library_DBEntities db = new Library_DBEntities();
            List<tblMember> lstMembers = db.tblMembers.ToList();
            for (int i = 0; i < lstMembers.Count; i++)
            {
                dgvMembers.Rows.Add();
                dgvMembers["clmId", i].Value = lstMembers[i].MemberId;
                dgvMembers["clmFirstName", i].Value = lstMembers[i].FirstName;
                dgvMembers["clmLastName", i].Value = lstMembers[i].LastName;
                dgvMembers["clmNationalCode", i].Value = lstMembers[i].NationalCode;
                dgvMembers["clmGender", i].Value = lstMembers[i].Gender;
                dgvMembers["clmBirth", i].Value = lstMembers[i].Birth;
                dgvMembers["clmJoinDate", i].Value = lstMembers[i].JoinDate;
                dgvMembers["clmFatherName", i].Value = lstMembers[i].FatherName;
                dgvMembers["clmMotherName", i].Value = lstMembers[i].MotherName;
                dgvMembers["clmPhone", i].Value = lstMembers[i].PhoneNumber;
                dgvMembers["clmEmail", i].Value = lstMembers[i].Email;
                dgvMembers["clmProvince", i].Value = lstMembers[i].Province;
                dgvMembers["clmCity", i].Value = lstMembers[i].City;
                dgvMembers["clmAddress", i].Value = lstMembers[i].Address;
                dgvMembers["clmDescription", i].Value = lstMembers[i].Description;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("با ادامه این عملیات این عضو از کتابخانه حذف می شود.آیا مایل به ادامه هستید ؟", "اخطار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            if (dr == DialogResult.OK)
            {
                int index = dgvMembers.CurrentRow.Index;
                int id = Convert.ToInt32(dgvMembers["clmId", index].Value.ToString());
                Library_DBEntities db = new Library_DBEntities();
                tblMember member = db.tblMembers.Where(u => u.Id == id).FirstOrDefault();
                db.tblMembers.Remove(member);
                db.SaveChanges();
                frmMemebersManagement_Load(null, null);
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            Hide();
            new frmAddMember().ShowDialog();
            Show();
            frmMemebersManagement_Load(null, null);
        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmMemebersManagement_Load(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Library_DBEntities db = new Library_DBEntities();
            List<tblMember> members = new List<tblMember>();
            if (txtFirstName.Text != "")
            {
                if (txtLastName.Text != "")
                    members = db.tblMembers.Where(u => u.FirstName == txtFirstName.Text && u.LastName == txtLastName.Text).ToList();
                else
                    members = db.tblMembers.Where(u => u.FirstName == txtFirstName.Text).ToList();
            }
            else if (txtLastName.Text != "")
                members = db.tblMembers.Where(u => u.LastName == txtLastName.Text).ToList();
            dgvMembers.Rows.Clear();
            for (int i = 0; i < members.Count; i++)
            {
                dgvMembers.Rows.Add();
                dgvMembers["clmId", i].Value = members[i].Id;
                dgvMembers["clmFirstName", i].Value = members[i].FirstName;
                dgvMembers["clmLastName", i].Value = members[i].LastName;
                dgvMembers["clmNationalCode", i].Value = members[i].NationalCode;
                dgvMembers["clmGender", i].Value = members[i].Gender;
                dgvMembers["clmBirth", i].Value = members[i].Birth;
                dgvMembers["clmJoinDate", i].Value = members[i].JoinDate;
                dgvMembers["clmFatherName", i].Value = members[i].FatherName;
                dgvMembers["clmMotherName", i].Value = members[i].MotherName;
                dgvMembers["clmPhone", i].Value = members[i].PhoneNumber;
                dgvMembers["clmEmail", i].Value = members[i].Email;
                dgvMembers["clmProvince", i].Value = members[i].Province;
                dgvMembers["clmCity", i].Value = members[i].City;
                dgvMembers["clmAddress", i].Value = members[i].Address;
                dgvMembers["clmDescription", i].Value = members[i].Description;
            }
        }

        private void btnSearchById_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                Library_DBEntities db = new Library_DBEntities();
                int id = Convert.ToInt32(txtId.Text);
                tblMember member = db.tblMembers.Where(u => u.Id == id).FirstOrDefault();
                dgvMembers.Rows.Clear();
                if (member != null)
                {
                    dgvMembers.Rows.Add();
                    dgvMembers["clmId", 0].Value = member.Id.ToString();
                    dgvMembers["clmFirstName", 0].Value = member.FirstName;
                    dgvMembers["clmLastName", 0].Value = member.LastName;
                    dgvMembers["clmNationalCode", 0].Value = member.NationalCode;
                    dgvMembers["clmGender", 0].Value = member.Gender;
                    dgvMembers["clmBirth", 0].Value = member.Birth;
                    dgvMembers["clmJoinDate", 0].Value = member.JoinDate;
                    dgvMembers["clmFatherName", 0].Value = member.FatherName;
                    dgvMembers["clmMotherName", 0].Value = member.MotherName;
                    dgvMembers["clmPhone", 0].Value = member.PhoneNumber;
                    dgvMembers["clmEmail", 0].Value = member.Email;
                    dgvMembers["clmProvince", 0].Value = member.Province;
                    dgvMembers["clmCity", 0].Value = member.City;
                    dgvMembers["clmAddress", 0].Value = member.Address;
                    dgvMembers["clmDescription", 0].Value = member.Description;
                }
                else
                    MessageBox.Show("کاربری با چنین مشخصاتی وجود ندارد");
            }
        }

        private void btnSearchByNationalCode_Click(object sender, EventArgs e)
        {
            if (txtNationalCode.Text != "")
            {
                Library_DBEntities db = new Library_DBEntities();
                tblMember member = db.tblMembers.Where(u => u.NationalCode == txtNationalCode.Text).FirstOrDefault();
                dgvMembers.Rows.Clear();
                if (member != null)
                {
                    dgvMembers.Rows.Add();
                    dgvMembers["clmId", 0].Value = member.Id.ToString();
                    dgvMembers["clmFirstName", 0].Value = member.FirstName;
                    dgvMembers["clmLastName", 0].Value = member.LastName;
                    dgvMembers["clmNationalCode", 0].Value = member.NationalCode;
                    dgvMembers["clmGender", 0].Value = member.Gender;
                    dgvMembers["clmBirth", 0].Value = member.Birth;
                    dgvMembers["clmJoinDate", 0].Value = member.JoinDate;
                    dgvMembers["clmFatherName", 0].Value = member.FatherName;
                    dgvMembers["clmMotherName", 0].Value = member.MotherName;
                    dgvMembers["clmPhone", 0].Value = member.PhoneNumber;
                    dgvMembers["clmEmail", 0].Value = member.Email;
                    dgvMembers["clmProvince", 0].Value = member.Province;
                    dgvMembers["clmCity", 0].Value = member.City;
                    dgvMembers["clmAddress", 0].Value = member.Address;
                    dgvMembers["clmDescription", 0].Value = member.Description;
                }
                else
                    MessageBox.Show("کاربری با چنین مشخصاتی وجود ندارد");
            }
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            clsPublicVariable.dt = DateTime.Now;
            lblClock.Text = string.Format("{2} : {1} : {0}", clsPublicVariable.dt.Hour, clsPublicVariable.dt.Minute, clsPublicVariable.dt.Second);
            lblDate.Text = string.Format("{0}  {1} / {2} / {3}", clsPublicVariable.dayofweek(), clsPublicVariable.nowday(), clsPublicVariable.nowMonth(), clsPublicVariable.nowyear());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}