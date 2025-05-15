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
    public partial class frmAddBooks : Form
    {
        Random rnd = new Random();
        string bookcode = "";
        public frmAddBooks()
        {
            InitializeComponent();
        }

        private void frmAddBooks_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 200; i++)
                cmbCount.Items.Add(i);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text == "" && txtWriter.Text == "" && cmbCount.Text == "")
            {
                MessageBox.Show("کادر ها را پر کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }
            Library_DBEntities db = new Library_DBEntities();
            string bookname = txtBookName.Text;
            string writer = txtWriter.Text;
            if (db.tblBooks.Any(b => b.BookName == bookname && b.Writer == writer))
            {
                MessageBox.Show("این کتاب قبلا در کتابخانه اضافه شده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }
            codegenerate();
            tblBook newbook = new tblBook()
            {
                BookName = bookname,
                Writer = writer,
                BookCode = bookcode,
                Count = Convert.ToInt32(cmbCount.Text),
                OutShelfCount = Convert.ToInt32(cmbCount.Text)
            };
            db.tblBooks.Add(newbook);
            db.SaveChanges();
            MessageBox.Show("با موفقیت افزوده شد");
        }
        private void codegenerate()
        {
            Library_DBEntities db = new Library_DBEntities();
            bookcode = Convert.ToString(rnd.Next(100000000, 1000000000));
            if (db.tblBooks.Any(b => b.BookCode == bookcode))
                codegenerate();
        }
    }
}
