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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Library_DBEntities db = new Library_DBEntities();
            if (txtUserName.Text == null || txtPassword.Text == null)
            {
                MessageBox.Show("کادر ها را پر کنید");
                return;
            }

            if (db.tblEmployees.Any(u => u.UserName == txtUserName.Text && u.Password == txtPassword.Text))
            {
                clsPublicVariable.User = db.View_Employee.Where(u => u.UserName == txtUserName.Text).FirstOrDefault();
                if (clsPublicVariable.User.NationalCode == txtPassword.Text)
                    MessageBox.Show("لطفا رمز عبور خود را تغییر دهید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                this.Hide();
                new frmMain().ShowDialog();
            }
            else
            {
                MessageBox.Show("چنین کاربری یافت نشد");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
