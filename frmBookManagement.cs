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
    public partial class frmBookManagement : Form
    {
        public frmBookManagement()
        {
            InitializeComponent();
        }

        private void frmBookManagement_Load(object sender, EventArgs e)
        {
            Library_DBEntities db = new Library_DBEntities();
            // dgvBooks.DataSource = db.View_Books.ToList();
            List<tblBook> books = db.tblBooks.ToList();
            dgvBooks.Rows.Clear();
            for (int i = 0; i < books.Count; i++)
            {
                dgvBooks.Rows.Add();
                dgvBooks["clmBookCode", i].Value = books[i].BookCode;
                dgvBooks["clmBookName", i].Value = books[i].BookName;
                dgvBooks["clmWriter", i].Value = books[i].Writer;
                dgvBooks["clmCount", i].Value = books[i].Count;
                dgvBooks["clmInShelfCount", i].Value = books[i].InShelfCount;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmBookManagement_Load(null, null);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Hide();
            new frmAddBooks().ShowDialog();
            Show();
        }

        private void btnSearchByBookCode_Click(object sender, EventArgs e)
        {
            Library_DBEntities db = new Library_DBEntities();
            string bookcode = txtBookCode.Text;
            tblBook book = db.tblBooks.Where(b => b.BookCode == bookcode).FirstOrDefault();
            dgvBooks.Rows.Clear();
            if (book != null)
            {
                dgvBooks.Rows.Add();
                dgvBooks["clmBookCode", 0].Value = book.BookCode;
                dgvBooks["clmBookName", 0].Value = book.BookName;
                dgvBooks["clmWriter", 0].Value = book.Writer;
                dgvBooks["clmCount", 0].Value = book.Count;
                dgvBooks["clmInShelfCount", 0].Value = book.InShelfCount;
            }
        }

        private void SearchByBookName_Click(object sender, EventArgs e)
        {
            Library_DBEntities db = new Library_DBEntities();
            string bookname = txtBookName.Text;
            List<tblBook> books = db.tblBooks.Where(b => b.BookName == bookname).ToList();
            dgvBooks.Rows.Clear();
            for (int i = 0; i < books.Count; i++)
            {
                dgvBooks.Rows.Add();
                dgvBooks["clmBookCode", i].Value = books[i].BookCode;
                dgvBooks["clmBookName", i].Value = books[i].BookName;
                dgvBooks["clmWriter", i].Value = books[i].Writer;
                dgvBooks["clmCount", i].Value = books[i].Count;
                dgvBooks["clmInShelfCount", i].Value = books[i].InShelfCount;
            }
        }

        private void btnSearchByWriter_Click(object sender, EventArgs e)
        {
            Library_DBEntities db = new Library_DBEntities();
            string writer = txtWriterName.Text;
            List<tblBook> books = db.tblBooks.Where(b => b.BookName == writer).ToList();
            dgvBooks.Rows.Clear();
            for (int i = 0; i < books.Count; i++)
            {
                dgvBooks.Rows.Add();
                dgvBooks["clmBookCode", i].Value = books[i].BookCode;
                dgvBooks["clmBookName", i].Value = books[i].BookName;
                dgvBooks["clmWriter", i].Value = books[i].Writer;
                dgvBooks["clmCount", i].Value = books[i].Count;
                dgvBooks["clmInShelfCount", i].Value = books[i].InShelfCount;
            }
        }

        private void btnBookInsert_Click(object sender, EventArgs e)
        {
            Hide();
            new frmBookShelfMapping().ShowDialog();
            Show();
        }
    }
}
