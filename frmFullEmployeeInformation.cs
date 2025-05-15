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
    public partial class frmFullEmployeeInformation : Form
    {
        public frmFullEmployeeInformation()
        {
            InitializeComponent();
        }

        private void frmFullEmployeeInformation_Load(object sender, EventArgs e)
        {
            lblFName.Text = "";
            lblLName.Text = "";
            lblGen.Text = "";
            lblNationCode.Text = "";
            lblBirth.Text = "";
            lblFather.Text = "";
            lblMother.Text = "";
            lblOstan.Text = "";
            lblShahr.Text = "";
            lblAdres.Text = "";
            lblPhone.Text = "";
            lblMail.Text = "";
            lblDescript.Text = "";
            lblUser.Text = "";
        }
    }
}
