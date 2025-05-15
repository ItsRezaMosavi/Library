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
    public partial class frmShelfManagement : Form
    {
        public frmShelfManagement()
        {
            InitializeComponent();
        }

        private void frmShelfManagement_Load(object sender, EventArgs e)
        {
            Library_DBEntities db = new Library_DBEntities();
            foreach (tblShelf s in db.tblShelves)
                cmbShelfNumber.Items.Add(s.ShelfNumber);
            pnlShelf.Visible = false;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Library_DBEntities db = new Library_DBEntities();
            tblShelf shelf = db.tblShelves.Where(s => s.ShelfNumber == cmbShelfNumber.Text).FirstOrDefault();
            if (shelf == null)
            {
                MessageBox.Show("لطفا شماره قفسه را به درستی انتخاب کنید");
                return;
            }
            txtShelfNumber.Text = shelf.ShelfNumber;
            txtCapacity.Text = shelf.Capacity.ToString();
            txtAvailableCapacity.Text = shelf.AvailableCapacity.ToString();
            txtUsedCapacity.Text = shelf.UsedCapacity.ToString();
            pnlShelf.Visible = true;





            List<tblBookShelfMapping> bookshelf = db.tblBookShelfMappings.Where(b => b.ShelfId == shelf.Id).ToList();
            List<int> booksid = bookshelf.Select(b => b.BookId).ToList();
            dgvShelf.Rows.Clear();
            for (int i = 0; i < bookshelf.Count; i++)
            {
                dgvShelf.Rows.Add();
                dgvShelf["clmBookCode", i].Value = bookshelf[i].BookId.ToString();
                var g = db.tblBooks.Where(b => b.Id == booksid[i]).FirstOrDefault();
                dgvShelf["clmBookName", i].Value = g.BookName.ToString();
                dgvShelf["clmBookCount", i].Value = bookshelf[i].Count.ToString();
            }


            //List<View_Books> books = db.View_Books.Where(b => b.ShelfId == shelf.Id).ToList();
            //for (int i = 0; i < books.Count; i++)
            //{
            //    dgvShelf["clmBookCode", i].Value = books[i].BookId;
            //    dgvShelf["clmBookName",i].Value = books[i].BookName;
            //    dgvShelf["clmBookCount", i].Value = books[i].Expr1;
            //}
        }
    }
}
