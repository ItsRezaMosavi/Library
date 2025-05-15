using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class frmBookShelfMapping : Form
    {
        bool select = false;
        tblBook SelectedBook;
        public frmBookShelfMapping()
        {
            InitializeComponent();
        }

        private void frmBookShelfMapping_Load(object sender, EventArgs e)
        {
            tmrClock_Tick(null, null);
            Library_DBEntities db = new Library_DBEntities();
            List<tblBook> books = db.tblBooks.ToList();
            for (int i = 0; i < books.Count; i++)
            {
                cmbBookCode.Items.Add(books[i].BookCode);
                cmbBookName.Items.Add(books[i].BookName);
                if (!cmbWriter.Items.Contains(books[i].Writer))
                    cmbWriter.Items.Add(books[i].Writer);
            }
            List<tblShelf> shelves = db.tblShelves.ToList();
            foreach (tblShelf s in shelves)
                cmbShelfNumber.Items.Add(s.ShelfNumber);
        }

        private void cmbBookCode_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbBookCode.Text != "")
            {
                Library_DBEntities db = new Library_DBEntities();
                tblBook book = db.tblBooks.Where(b => b.BookCode == cmbBookCode.Text).FirstOrDefault();
                cmbBookName.Items.Clear();
                cmbWriter.Items.Clear();
                if (book != null)
                {
                    cmbBookName.Items.Add(book.BookName);
                    cmbWriter.Items.Add(book.Writer);
                }
            }
            else
            {
                frmBookShelfMapping_Load(null, null);
            }
            select = false;
        }

        private void cmbBookName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbBookName.Text != "")
            {
                Library_DBEntities db = new Library_DBEntities();
                List<tblBook> books = db.tblBooks.Where(b => b.BookName == cmbBookName.Text).ToList();
                cmbBookCode.Items.Clear();
                cmbWriter.Items.Clear();
                foreach (tblBook book in books)
                {
                    cmbBookCode.Items.Add(book.BookCode);
                    cmbWriter.Items.Add(book.Writer);
                }
            }
            else
            {
                frmBookShelfMapping_Load(null, null);
            }
            select = false;
        }

        private void cmbWriter_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbWriter.Text != "")
            {
                Library_DBEntities db = new Library_DBEntities();
                List<tblBook> books = db.tblBooks.Where(b => b.Writer == cmbWriter.Text).ToList();
                cmbBookCode.Items.Clear();
                cmbBookName.Items.Clear();
                foreach (tblBook book in books)
                {
                    cmbBookCode.Items.Add(book.BookCode);
                    cmbBookName.Items.Add(book.BookName);
                }

            }
            else
            {
                frmBookShelfMapping_Load(null, null);
            }
            select = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (select == false)
            {
                MessageBox.Show("لطفا کتاب را انتخاب کنید");
                return;
            }
            int count;
            try
            {
                count = Convert.ToInt32(txtCount.Text);
            }
            catch
            {
                MessageBox.Show("لطفا تعداد را با عدد وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Library_DBEntities db = new Library_DBEntities();
            tblShelf shelf = db.tblShelves.Where(s => s.ShelfNumber == cmbShelfNumber.Text).FirstOrDefault();
            if (shelf == null)
            {
                MessageBox.Show("لطفا شماره قفسه را به درستی وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbShelfNumber.Focus();
                return;
            }
            if (count > SelectedBook.OutShelfCount)
            {
                MessageBox.Show("این تعداد از کتاب مورد نظر خارج از قفسه ها نیست", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (count > shelf.AvailableCapacity)
            {
                MessageBox.Show("قفسه مورد نظر ظرفیت کافی برای این تعداد کتاب ندارد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dr = MessageBox.Show(string.Format(" {0}عدد از کتاب {1} در قفسه {2} قرار میگیرد. آیا از انجام این عملیات اطمینان دارید ؟", count, SelectedBook.BookName, shelf.ShelfNumber), "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            if (dr == DialogResult.Cancel)
                return;
            tblBookShelfMapping bookShelfMapping = new tblBookShelfMapping()
            {
                BookId = SelectedBook.Id,
                ShelfId = shelf.Id,
                Count = count
            };
            db.tblBookShelfMappings.Add(bookShelfMapping);


            SelectedBook.InShelfCount += count;
            SelectedBook.OutShelfCount -= count;
            shelf.AvailableCapacity -= count;
            shelf.UsedCapacity += count;
            db.tblBooks.AddOrUpdate(SelectedBook);
            db.tblShelves.AddOrUpdate(shelf);
            db.SaveChanges();
            MessageBox.Show("با موفقیت انجام شد");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string bookcode = cmbBookCode.Text;
            string bookName = cmbBookName.Text;
            string writer = cmbWriter.Text;
            Library_DBEntities db = new Library_DBEntities();
            if (db.tblBooks.Any(b => b.BookCode == bookcode && b.BookName == bookName && b.Writer == writer))
            {
                MessageBox.Show("کتاب مورد نظر انتخاب شد");
                select = true;
                SelectedBook = db.tblBooks.Where(b => b.BookCode == bookcode).FirstOrDefault();
            }
            else
            {
                MessageBox.Show("اطلاعات کتاب را به درستی وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                select = false;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmBookShelfMapping_Load(null, null);
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            clsPublicVariable.dt = DateTime.Now;
            lblClock.Text = string.Format("{2} : {1} : {0}", clsPublicVariable.dt.Hour, clsPublicVariable.dt.Minute, clsPublicVariable.dt.Second);
            lblDate.Text = string.Format(" {0}  {1} / {2} / {3}", clsPublicVariable.dayofweek(), clsPublicVariable.nowday(), clsPublicVariable.nowMonth(), clsPublicVariable.nowyear());
        }
    }
}
