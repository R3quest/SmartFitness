using System;
using System.Windows.Forms;
using SmartFitness.Forms.Add;

namespace SmartFitness.Forms.Interactive
{
    public partial class Unos : Form
    {
        public Unos()
        {
            InitializeComponent();
        }

        private void btnUnesiRezultat_Click(object sender, EventArgs e)
        {
            DodajRezultatVjezbe frmUnesiRezultatVjezbe = new DodajRezultatVjezbe();
            frmUnesiRezultatVjezbe.ShowDialog();
        }

        private void btnPopisUcenika_Click(object sender, EventArgs e)
        {
            PopisUcenika frm = new PopisUcenika();
            frm.ShowDialog();
        }

        private void btnUnosSportova_Click(object sender, EventArgs e)
        {
            PopisSportova frm = new PopisSportova();
            frm.ShowDialog();
        }

        private void btnOcijeniUcenika_Click(object sender, EventArgs e)
        {
            var dodajSportUceniku = new DodajSportUceniku();
            dodajSportUceniku.ShowDialog();
        }

        private void btnNatjecanje_Click(object sender, EventArgs e)
        {
            var dodajNatjecanje = new DodajNatjecanje();
            dodajNatjecanje.ShowDialog();
        }
    }
}
