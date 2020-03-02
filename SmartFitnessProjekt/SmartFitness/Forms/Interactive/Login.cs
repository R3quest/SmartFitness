using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using SmartFitness.Database;
using SmartFitness.Helpers.Messages.Error;

namespace SmartFitness.Forms.Interactive
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
            if (txtKorisnickoIme.Text.Equals(""))
            {
                txtKorisnickoIme.Text = "Korisnicko ime";
                txtKorisnickoIme.ForeColor = Color.Silver;
            }
        }

        private void txtLozinka_Enter(object sender, EventArgs e)
        {
            if (txtLozinka.Text.Equals("Lozinka"))
            {
                txtLozinka.Text = "";
                txtLozinka.ForeColor = Color.Black;
            }
        }

        private void txtLozinka_Leave(object sender, EventArgs e)
        {
            if (txtLozinka.Text.Equals(""))
            {
                txtLozinka.Text = "Lozinka";
                txtLozinka.ForeColor = Color.Silver;
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool ProvjeraKorisnika()
        {
            var korisnickoIme = txtKorisnickoIme.Text;
            var lozinka = txtLozinka.Text;
            return korisnik.ProvjeraPrijave(korisnickoIme, lozinka);
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (ProvjeraKorisnika())
            {
                PocetnaForma pocetnaForma = new PocetnaForma();
                this.Hide();
                pocetnaForma.ShowDialog();
                this.Show();
                txtKorisnickoIme.Text = "";
                txtLozinka.Text = "";
                SendKeys.Send("+{TAB}");
            }
            else
            {
                MessageBox.Show(PorukaPogreska.NeispravanUnosPodataka, PorukaPogreska.Zaglavlje, MessageBoxButtons.OK);
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("F1"))
            {
                string nazivDatoteke = "Pomoc.chm";
                string putanjaDoMape = Path.Combine(Environment.CurrentDirectory, @"Data\", nazivDatoteke);
                string pravaPutanja = Path.GetFullPath(Path.Combine(putanjaDoMape, @"..\..\..\..\..\" + "\\" + nazivDatoteke));
                Help.ShowHelp(this, pravaPutanja);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Login_KeyDown);
        }

        private void txtKorisnickoIme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPrijava_Click(sender, e);
            }
        }

        private void txtLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPrijava_Click(sender, e);
            }

        }
    }
}
