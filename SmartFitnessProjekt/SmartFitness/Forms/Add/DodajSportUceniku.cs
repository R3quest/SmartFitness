using System;
using System.Windows.Forms;
using SmartFitness.Database;
using SmartFitness.Forms.Update;
using SmartFitness.Helpers.Messages.Error;
using SmartFitness.Helpers.Messages.Success;

namespace SmartFitness.Forms.Add
{
    public partial class DodajSportUceniku : Form
    {
        public DodajSportUceniku()
        {
            InitializeComponent();
            PrikaziUcenike();
            DohvatiSportove();
            DohvatiOcijene();
            DohvatiSveOcijeneUcenika();
        }

        public void PrikaziUcenike()
        {
            ucenikBindingSource.DataSource = ucenik.DohvatiUcenike();
        }

        public void DohvatiSportove()
        {
            sportBindingSource.DataSource = sport.DohvatiSportove();
        }

        public void DohvatiOcijene()
        {
            for (int i = 1; i < 6; i++)
            {
                cboOcijena.Items.Add(i);
            }
        }

        public void DohvatiSveOcijeneUcenika()
        {
            try
            {
                var ucenikId = (int) dgvUcenik.SelectedRows[0].Cells[3].Value;
                dgvOcijenePojedinogSportaUcenika.DataSource = ucenik.DohvatiSveOcijeneUcenika(ucenikId);
                dgvOcijenePojedinogSportaUcenika.Columns[2].Visible = false;
            }
            catch { }
        }

        public void DodjeliSportUceniku()
        {
            try
            {
                if (dgvUcenik.CurrentRow != null)
                {
                    ucenik ucenik = dgvUcenik.CurrentRow.DataBoundItem as ucenik;
                    sport sport = cboSport.SelectedItem as sport;
                    DateTime datum = dateVjezbanja.Value;
                    int ocijena = int.Parse(cboOcijena.Text);
                    string opis = txtOpis.Text;

                    var rezultat = sport_ucenik.DohvatiSportIOcijenuUcenika(ucenik, sport);
                    if (rezultat != null)
                    {
                        MessageBox.Show(PorukaPogreska.UcenikImaOcijenu, PorukaPogreska.Zaglavlje);
                        return;
                    }
                    sport_ucenik.DodajOcijenuUceniku(sport.id_sporta, ucenik.id_ucenika, datum, ocijena, opis);

                    MessageBox.Show(@"Uspjesno dodana ocijena: " + ocijena + "\nUceniku: " +
                                    dgvUcenik.SelectedRows[0].Cells[0].Value + @" " +
                                    dgvUcenik.SelectedRows[0].Cells[1].Value +
                                    "\nGodina: " + dgvUcenik.SelectedRows[0].Cells[3].Value, PorukaUspjesno.Zaglavlje);
                    DohvatiSveOcijeneUcenika();
                }
            }
            catch
            {
                MessageBox.Show(PorukaPogreska.ProvjeritePopunjenostForme, PorukaPogreska.Zaglavlje);
            }
        }

        private void btnDodajOcijenu_Click(object sender, EventArgs e)
        {
            DodjeliSportUceniku();
        }

        private void btnAzurirajOcijenu_Click(object sender, EventArgs e)
        {
            try
            {
                var azurirajOcijenuUcenika = new AzurirajOcijenuUcenika(dgvUcenik.CurrentRow.DataBoundItem as ucenik, cboSport.SelectedItem as sport);
                azurirajOcijenuUcenika.ShowDialog();
                DohvatiSveOcijeneUcenika();
            }
            catch { }
        }

        private void dgvUcenik_SelectionChanged(object sender, EventArgs e)
        {
            DohvatiSveOcijeneUcenika();
        }

        private void btnObrisiOcijenu_Click(object sender, EventArgs e)
        {
            var vjezbaId = (int) dgvOcijenePojedinogSportaUcenika.SelectedRows[0].Cells[2].Value;
            try
            {
                if (dgvOcijenePojedinogSportaUcenika.CurrentRow != null)
                {
                    var sportIOcijena = sport_ucenik.DohvatiSportIOcijenuUcenika(vjezbaId);
                    if (sportIOcijena != null)
                    {
                        sport_ucenik.ObrisiOcijenuUcenika(sportIOcijena);
                        DohvatiSveOcijeneUcenika();
                    }
                }
            }
            catch
            {
                MessageBox.Show(PorukaPogreska.OcijenaNijeOdabrana, PorukaPogreska.Zaglavlje);
            }
        }
    }
}
