using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFitness
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtKorisnickoIme_Enter(object sender, EventArgs e)
        {
            if (txtKorisnickoIme.Text.Equals("Korisnicko ime"))
            {
                txtKorisnickoIme.Text = "";
                txtKorisnickoIme.ForeColor = Color.Black;
            }
        }

        private void txtKorisnickoIme_Leave(object sender, EventArgs e)
        {
            if (txtKorisnickoIme.Text == "")
            {
                txtKorisnickoIme.Text = "Korisnicko ime";
                txtKorisnickoIme.ForeColor = Color.Silver;
            }
        }

        private void txtLozinka_Enter(object sender, EventArgs e)
        {
            if (txtLozinka.Text == "Lozinka")
            {
                txtLozinka.Text = "";
                txtLozinka.ForeColor = Color.Black;
            }
        }

        private void txtLozinka_Leave(object sender, EventArgs e)
        {
            if (txtLozinka.Text == "")
            {
                txtLozinka.Text = "Lozinka";
                txtLozinka.ForeColor = Color.Silver;
            }
        }
    }
}
