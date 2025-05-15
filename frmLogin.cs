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
    public partial class frmLogin : Form
    {
        private int childFormNumber = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tmrMain_Tick(null, null);
            this.Text = clsPublicVariable.Library_Name;
            lblLibraryName.Text = clsPublicVariable.Library_Name;
            lblTitle.Text = clsPublicVariable.Login_Title;

            clsUser mainadmin = new clsUser();
            mainadmin.FirstName = "reza";
            mainadmin.LastName = "Mosavi";
            mainadmin.Id = "1234567890";
            mainadmin.NationalCode = "4061442074";
            mainadmin.Age = clsPublicVariable.Age(1383, 2, 11);
            mainadmin.Password = "Reza_123";
            clsUser.users.Add(mainadmin);

            clsMember member = new clsMember();
            
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

        private void lblUserId_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (clsPublicVariable.LogIn_Check(txtFirstName.Text, txtLastName.Text, txtUserId.Text, txtPassword.Text))
            {
                frmMain frmMain = new frmMain();
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("نام یا کد پرسنلی یا گذرواژه غلط می باشد");
            }
        }
    }
}
