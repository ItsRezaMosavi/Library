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
    public partial class frmShelves : Form
    {
        public frmShelves()
        {
            InitializeComponent();
        }

        private void frmShelves_Load(object sender, EventArgs e)
        {
            Library_DBEntities db = new Library_DBEntities();
            List<tblShelf> shelves = db.tblShelves.ToList();
            dgvShelves.Rows.Clear();
            for (int i = 0; i < shelves.Count; i++)
            {
                dgvShelves.Rows.Add();
                dgvShelves["clmShelfNumber", i].Value = shelves[i].ShelfNumber;
                dgvShelves["clmCapacity", i].Value = shelves[i].Capacity;
                dgvShelves["clmUsedCapacity", i].Value = shelves[i].UsedCapacity;
                dgvShelves["clmAvailableCapacity", i].Value = shelves[i].AvailableCapacity;
            }
        }

        private void btnAddShelf_Click(object sender, EventArgs e)
        {
            if (txtShelfNumber.Text != "" && txtCapacity.Text != "")
            {
                Library_DBEntities db = new Library_DBEntities();
                if (db.tblShelves.Any(s => s.ShelfNumber == txtShelfNumber.Text))
                {
                    MessageBox.Show("این قفسه قبلا اضافه شده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    return;
                }
                string ShelfNumber = "";
                int Capacity = 0;
                try
                {
                    ShelfNumber = txtShelfNumber.Text;
                    Capacity = Convert.ToInt32(txtCapacity.Text);
                }
                catch
                {
                    MessageBox.Show("لطفا مقادیر را به دقت پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    return;
                }
                if (Capacity <= 0)
                {
                    MessageBox.Show("ظرفیت هر قفسه حداقل یک کتاب می باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    return;
                }
                tblShelf newshelf = new tblShelf()
                {
                    ShelfNumber = ShelfNumber,
                    Capacity = Capacity,
                    AvailableCapacity = Capacity
                };

                db.tblShelves.Add(newshelf);
                db.SaveChanges();
                MessageBox.Show("قفسه افزوده شد");
            }
            else
            {
                MessageBox.Show("لطفا مقادیر را به دقت پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            frmShelves_Load(null, null);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmShelves_Load(null, null);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clsPublicVariable.dt = DateTime.Now;
            lblClock.Text = string.Format("{2} : {1} : {0}", clsPublicVariable.dt.Hour, clsPublicVariable.dt.Minute, clsPublicVariable.dt.Second);
            lblDate.Text = string.Format(" {0}  {1} / {2} / {3}", clsPublicVariable.dayofweek(), clsPublicVariable.nowday(), clsPublicVariable.nowMonth(), clsPublicVariable.nowyear());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new frmBookShelfMapping().ShowDialog();
            Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnShelfManagement_Click(object sender, EventArgs e)
        {
            Hide();
            new frmShelfManagement().ShowDialog();
            Show();
        }
    }
}
