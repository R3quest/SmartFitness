using System;
using System.ComponentModel;
using System.Windows.Forms;
using SmartFitness.Forms.Update;
using SmartFitness.Helpers.Messages.Error;
using SmartFitness.Helpers.Messages.Success;
using sport = SmartFitness.Database.sport;

namespace SmartFitness.Forms.Add
{
    public partial class DodajNatjecanje : Form
    {
        public DodajNatjecanje()
        {
            InitializeComponent();
            DohvatiNatjecanjaISport();
        }

        public void DohvatiNatjecanjaISport()
        {
            DohvatiNatjecanja();
            DohvatiSport();
        }

        public void DohvatiNatjecanja()
        {
            natjecanjeBindingSource.DataSource = Database.natjecanje.DohvatiNatjecanja();
        }

        public void DohvatiSport()
        {
            BindingList<sport> listaSportova = sport.DohvatiSportove();
            sportBindingSource.DataSource = listaSportova;
        }

        private void btnDodajNatjecanje_Click(object sender, EventArgs e)
        {
            var opis = txtOpis.Text;
            var razina_natjecanja = txtRazina.Text;
            var mjesto_odrzavanja = txtMjesto.Text;
            var datum_vrijeme = dateVjezbanja.Value;
            var id_sporta = (int) cboSport.SelectedValue;
            try
            {
                Database.natjecanje.DodajNatjecanje(opis, razina_natjecanja, mjesto_odrzavanja, datum_vrijeme, id_sporta);
                MessageBox.Show(PorukaUspjesno.UspjesnoDodanoNatjecanje, PorukaUspjesno.Zaglavlje);
                DohvatiNatjecanja();
            }
            catch
            {
                MessageBox.Show(PorukaPogreska.ProvjeritePopunjenostForme, PorukaPogreska.Zaglavlje);
            }
            
        }

        private void btnAzurirajNatjecanje_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNatjecanja.CurrentRow != null)
                {
                    var azurirajNatjecanje = new AzurirajNatjecanje(dgvNatjecanja.CurrentRow.DataBoundItem as Database.natjecanje);
                    azurirajNatjecanje.ShowDialog();
                    DohvatiNatjecanja();
                }
            }
            catch
            {
                MessageBox.Show(PorukaPogreska.NisteOdabraliNatjecanje, PorukaPogreska.Zaglavlje);
            }
            
        }

        private void btnObrisiNatjecanje_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNatjecanja.CurrentRow != null)
                {
                    var natjecanje = dgvNatjecanja.CurrentRow.DataBoundItem as Database.natjecanje;
                    if (natjecanje != null)
                    {
                        Database.natjecanje.ObrisiNatjecanje(natjecanje);
                    }
                }
            }
            catch
            {
                MessageBox.Show(PorukaPogreska.ProvjeritePopunjenostForme, PorukaPogreska.Zaglavlje);
            }
        }
    }
}
