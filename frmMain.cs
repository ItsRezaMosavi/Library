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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            if (clsPublicVariable.User.MembersManagement)
            {
                this.Hide();
                new frmAddMember().ShowDialog();
                this.Show();
            }
            else
            {
                DialogResult dr = MessageBox.Show("شما به این بخش دسترسی ندارید\n از مدیریت بخواهید سطح دسترسی شما را بالا تر ببرد", "خطای دسترسی", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (dr == DialogResult.Retry)
                    btnAddMember_Click(null, null);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tmrClock_Tick(null, null);
            MessageBox.Show(string.Format("سلام {0} جان", clsPublicVariable.User.FirstName));

        }

        private void btnMembersManagement_Click(object sender, EventArgs e)
        {
            if (!clsPublicVariable.User.MembersManagement)
            {
                DialogResult dr = MessageBox.Show("شما به این بخش دسترسی ندارید\n از مدیریت بخواهید سطح دسترسی شما را بالا تر ببرد", "خطای دسترسی", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (dr == DialogResult.Retry)
                    btnMembersManagement_Click(null, null);
                return;
            }
            this.Hide();
            new frmMemebersManagement().ShowDialog();
            Show();
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            clsPublicVariable.dt = DateTime.Now;
            lblClock.Text = string.Format("{2} : {1} : {0}", clsPublicVariable.dt.Hour, clsPublicVariable.dt.Minute, clsPublicVariable.dt.Second);
            lblDate.Text = string.Format(" {0}  {1} / {2} / {3}", clsPublicVariable.dayofweek(), clsPublicVariable.nowday(), clsPublicVariable.nowMonth(), clsPublicVariable.nowyear());
        }

        private void lblClock_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (!clsPublicVariable.User.EmployManagement)
            {
                DialogResult dr = MessageBox.Show("شما به این بخش دسترسی ندارید\n از مدیریت بخواهید سطح دسترسی شما را بالا تر ببرد", "خطای دسترسی", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (dr == DialogResult.Retry)
                    btnAddEmployee_Click(null, null);
                return;
            }
            Hide();
            new frmAddEmployee().ShowDialog();
            Show();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (!clsPublicVariable.User.BookManagement)
            {
                DialogResult dr = MessageBox.Show("شما به این بخش دسترسی ندارید\n از مدیریت بخواهید سطح دسترسی شما را بالا تر ببرد", "خطای دسترسی", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (dr == DialogResult.Retry)
                    btnAddBook_Click(null, null);
                return;
            }
            this.Hide();
            new frmAddBooks().ShowDialog();
            Show();
        }

        private void btnShelves_Click(object sender, EventArgs e)
        {
            if (!clsPublicVariable.User.ShelfManagement)
            {
                DialogResult dr = MessageBox.Show("شما به این بخش دسترسی ندارید\n از مدیریت بخواهید سطح دسترسی شما را بالا تر ببرد", "خطای دسترسی", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (dr == DialogResult.Retry)
                    btnShelves_Click(null, null);
                return;
            }
            Hide();
            new frmShelves().ShowDialog();
            Show();
        }

        private void btnEmployeeManagement_Click(object sender, EventArgs e)
        {
            if (!clsPublicVariable.User.EmployManagement)
            {
                DialogResult dr = MessageBox.Show("شما به این بخش دسترسی ندارید\n از مدیریت بخواهید سطح دسترسی شما را بالا تر ببرد", "خطای دسترسی", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (dr == DialogResult.Retry)
                    btnEmployeeManagement_Click(null, null);
                return;
            }
            Hide();
            new frmEmployeeManagement().ShowDialog();
            Show();
        }

        private void btnBooksManagement_Click(object sender, EventArgs e)
        {
            if (clsPublicVariable.User.BookManagement)
            {
                Hide();
                new frmBookManagement().ShowDialog();
                Show();
            }
            else
            {
                DialogResult dr = MessageBox.Show("شما به این بخش دسترسی ندارید\n از مدیریت بخواهید سطح دسترسی شما را بالا تر ببرد", "خطای دسترسی", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (dr == DialogResult.Retry)
                    btnEmployeeManagement_Click(null, null);
            }
        }
    }
}
