using System;
using System.Windows.Forms;
using SmartFitness.Database;
using SmartFitness.Helpers.Messages.Error;
using SmartFitness.Helpers.Messages.Success;

namespace SmartFitness.Forms.Update
{
    public partial class AzurirajNatjecanje : Form
    {
        public natjecanje Natjecanje { get; set; }
        public AzurirajNatjecanje(natjecanje natjecanje)
        {
            InitializeComponent();            
            this.Natjecanje = natjecanje;
            DohvatiSportove();
            PostaviVrijednosti();
        }

        public void PostaviVrijednosti()
        {
            txtOpis.Text = Natjecanje.opis;
            txtRazina.Text = Natjecanje.razina_natjecanja;
            txtMjesto.Text = Natjecanje.mjesto_odrzavanja;
            dateVjezbanja.Value = Natjecanje.datum_vrijeme;
            cboSport.SelectedValue = Natjecanje.id_sporta;
        }

        public void DohvatiSportove()
        {
            cboSport.DataSource = sport.DohvatiSportove();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            try
            {
                var opis = txtOpis.Text;
                var razina_natjecanja = txtRazina.Text;
                var mjesto_odrzavanja = txtMjesto.Text;
                var datum_vrijeme = dateVjezbanja.Value;
                var id_sporta = (int)cboSport.SelectedValue;
                natjecanje natjecanje = Database.natjecanje.DohvatiNatjecanjePomocuId(Natjecanje.id_natjecanja);
                if (natjecanje != null)
                {
                    Database.natjecanje.AzurirajNatjecanje(natjecanje, opis, razina_natjecanja, mjesto_odrzavanja, datum_vrijeme,
                        id_sporta);

                    MessageBox.Show(PorukaUspjesno.UspjesnoAzurirano, PorukaUspjesno.ZaglavljeUspjesnoAzurirano);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show( PorukaPogreska.NeispravanUnosPodataka, PorukaPogreska.Zaglavlje);
            }
        }
    }
}
