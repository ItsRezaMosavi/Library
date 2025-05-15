using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class frmEmployeeManagement : Form
    {
        public frmEmployeeManagement()
        {
            InitializeComponent();
        }

        private void frmEmployeeManagement_Load(object sender, EventArgs e)
        {
            dgvEmployee.Rows.Clear();

            Library_DBEntities db = new Library_DBEntities();
            List<View_Employee> lstEmployee = db.View_Employee.ToList();
            for (int i = 0; i < lstEmployee.Count; i++)
            {
                dgvEmployee.Rows.Add();
                dgvEmployee["clmUserName", i].Value = lstEmployee[i].UserName;
                dgvEmployee["clmFName", i].Value = lstEmployee[i].FirstName;
                dgvEmployee["clmLName", i].Value = lstEmployee[i].LastName;
                dgvEmployee["clmNationalCode", i].Value = lstEmployee[i].NationalCode;
                dgvEmployee["clmGender", i].Value = lstEmployee[i].Gender;
                dgvEmployee["clmPhoneNumber", i].Value = lstEmployee[i].PhoneNumber;
                dgvEmployee["clmEmail", i].Value = lstEmployee[i].Email;
                dgvEmployee["clmBookManagement", i].Value = lstEmployee[i].BookManagement;
                dgvEmployee["clmShelfManagement", i].Value = lstEmployee[i].ShelfManagement;
                dgvEmployee["clmEmployeeManagement", i].Value = lstEmployee[i].EmployManagement;
                dgvEmployee["clmMemberManagement", i].Value = lstEmployee[i].MembersManagement;
                dgvEmployee["clmEmployeeAccessManagement", i].Value = lstEmployee[i].EmployAccessManagement;
            }
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("با ادامه این عملیات این کارمند به طور کامل از سیستم حذف میشود. آیا تمایل به ادامه دارید؟", "اخطار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            if (dr == DialogResult.OK)
            {
                int index = dgvEmployee.CurrentRow.Index;
                string UserName = dgvEmployee["clmUserName", index].Value.ToString();
                Library_DBEntities db = new Library_DBEntities();
                tblEmployee employee = db.tblEmployees.Where(u => u.UserName == UserName).FirstOrDefault();

                tblEmployeeAccess employeeAccess = db.tblEmployeeAccesses.Where(u => u.EmployId == employee.Id).FirstOrDefault();
                db.tblEmployeeAccesses.Remove(employeeAccess);
                db.tblEmployees.Remove(employee);
                db.SaveChanges();
                frmEmployeeManagement_Load(null, null);
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Hide();
            new frmAddEmployee().ShowDialog();
            Show();
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            Library_DBEntities db = new Library_DBEntities();
            List<View_Employee> lstEmployee = new List<View_Employee>();
            if (txtFirstName.Text != "")
                if (txtLastName.Text != "")
                    lstEmployee = db.View_Employee.Where(u => u.FirstName == txtFirstName.Text && u.LastName == txtLastName.Text).ToList();
                else
                    lstEmployee = db.View_Employee.Where(u => u.FirstName == txtFirstName.Text).ToList();
            else if (txtLastName.Text != "")
                lstEmployee = db.View_Employee.Where(u => u.LastName == txtLastName.Text).ToList();
            dgvEmployee.Rows.Clear();
            if (lstEmployee != null)
                for (int i = 0; i < lstEmployee.Count; i++)
                {
                    dgvEmployee.Rows.Add();
                    dgvEmployee["clmUserName", i].Value = lstEmployee[i].UserName;
                    dgvEmployee["clmFName", i].Value = lstEmployee[i].FirstName;
                    dgvEmployee["clmLName", i].Value = lstEmployee[i].LastName;
                    dgvEmployee["clmNationalCode", i].Value = lstEmployee[i].NationalCode;
                    dgvEmployee["clmGender", i].Value = lstEmployee[i].Gender;
                    dgvEmployee["clmPhoneNumber", i].Value = lstEmployee[i].PhoneNumber;
                    dgvEmployee["clmEmail", i].Value = lstEmployee[i].Email;
                    dgvEmployee["clmBookManagement", i].Value = lstEmployee[i].BookManagement;
                    dgvEmployee["clmShelfManagement", i].Value = lstEmployee[i].ShelfManagement;
                    dgvEmployee["clmEmployeeManagement", i].Value = lstEmployee[i].EmployManagement;
                    dgvEmployee["clmMemberManagement", i].Value = lstEmployee[i].MembersManagement;
                    dgvEmployee["clmEmployeeAccessManagement", i].Value = lstEmployee[i].EmployAccessManagement;
                }
            else
                MessageBox.Show("کاربری با چنین مشخصاتی وجود ندارد");

        }

        private void btnSearchByUserName_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "")
            {
                string username = txtUserName.Text;
                Library_DBEntities db = new Library_DBEntities();
                View_Employee employee = db.View_Employee.Where(u => u.UserName == username).FirstOrDefault();
                dgvEmployee.Rows.Clear();
                if (employee != null)
                {
                    dgvEmployee.Rows.Add();
                    dgvEmployee["clmUserName", 0].Value = employee.UserName;
                    dgvEmployee["clmFName", 0].Value = employee.FirstName;
                    dgvEmployee["clmLName", 0].Value = employee.LastName;
                    dgvEmployee["clmNationalCode", 0].Value = employee.NationalCode;
                    dgvEmployee["clmGender", 0].Value = employee.Gender;
                    dgvEmployee["clmPhoneNumber", 0].Value = employee.PhoneNumber;
                    dgvEmployee["clmEmail", 0].Value = employee.Email;
                    dgvEmployee["clmBookManagement", 0].Value = employee.BookManagement;
                    dgvEmployee["clmShelfManagement", 0].Value = employee.ShelfManagement;
                    dgvEmployee["clmEmployeeManagement", 0].Value = employee.EmployManagement;
                    dgvEmployee["clmMemberManagement", 0].Value = employee.MembersManagement;
                    dgvEmployee["clmEmployeeAccessManagement", 0].Value = employee.EmployAccessManagement;
                }
                else
                    MessageBox.Show("کاربری با چنین مشخصاتی وجود ندارد");
            }
        }

        private void btnSearchByNationalCode_Click(object sender, EventArgs e)
        {
            if (txtNationalCode.Text != "")
            {
                string NationalCode = txtNationalCode.Text;
                Library_DBEntities db = new Library_DBEntities();
                View_Employee employee = db.View_Employee.Where(u => u.NationalCode == NationalCode).FirstOrDefault();
                dgvEmployee.Rows.Clear();
                if (employee != null)
                {
                    dgvEmployee.Rows.Add();
                    dgvEmployee["clmUserName", 0].Value = employee.UserName;
                    dgvEmployee["clmFName", 0].Value = employee.FirstName;
                    dgvEmployee["clmLName", 0].Value = employee.LastName;
                    dgvEmployee["clmNationalCode", 0].Value = employee.NationalCode;
                    dgvEmployee["clmGender", 0].Value = employee.Gender;
                    dgvEmployee["clmPhoneNumber", 0].Value = employee.PhoneNumber;
                    dgvEmployee["clmEmail", 0].Value = employee.Email;
                    dgvEmployee["clmBookManagement", 0].Value = employee.BookManagement;
                    dgvEmployee["clmShelfManagement", 0].Value = employee.ShelfManagement;
                    dgvEmployee["clmEmployeeManagement", 0].Value = employee.EmployManagement;
                    dgvEmployee["clmMemberManagement", 0].Value = employee.MembersManagement;
                    dgvEmployee["clmEmployeeAccessManagement", 0].Value = employee.EmployAccessManagement;
                }
                else
                    MessageBox.Show("کاربری با چنین مشخصاتی وجود ندارد");

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmEmployeeManagement_Load(null, null);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            clsPublicVariable.dt = DateTime.Now;
            lblClock.Text = string.Format("{2} : {1} : {0}", clsPublicVariable.dt.Hour, clsPublicVariable.dt.Minute, clsPublicVariable.dt.Second);
            lblDate.Text = string.Format("{0}  {1} / {2} / {3}", clsPublicVariable.dayofweek(), clsPublicVariable.nowday(), clsPublicVariable.nowMonth(), clsPublicVariable.nowyear());
        }
    }
}
