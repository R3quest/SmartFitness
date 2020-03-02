using System;
using System.Windows.Forms;
using SmartFitness.Database;
using SmartFitness.Forms.Update;
using SmartFitness.Helpers.Messages.Error;
using SmartFitness.Helpers.Messages.Success;

namespace SmartFitness.Forms.Interactive
{
    public partial class PopisSportova : Form
    {
        public PopisSportova()
        {
            InitializeComponent();
            PrikaziSportove();
        }

        public void PrikaziSportove()
        {
            
            sportBindingSource.DataSource = sport.DohvatiSportove();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(txtNaziv.Text=="" && txtDisciplina.Text==""))
                {
                    sport.DodavanjeSporta(txtNaziv.Text, txtDisciplina.Text);
                    MessageBox.Show(PorukaUspjesno.DodanSport, PorukaUspjesno.Zaglavlje);
                    txtDisciplina.Clear();
                    txtNaziv.Clear();
                }
                else
                {
                    MessageBox.Show(PorukaPogreska.ProvjeritePopunjenostForme, PorukaPogreska.Zaglavlje);
                }
                

            }
            catch
            {
                MessageBox.Show(PorukaPogreska.NeispravanUnosPodataka, PorukaPogreska.Zaglavlje);
            }
            PrikaziSportove();
            
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            
            var sport = dgvSportovi.SelectedRows[0].DataBoundItem as sport;
            if (sport!=null)
            {
                AzurirajSport frm = new AzurirajSport(sport);
                frm.ShowDialog();
                PrikaziSportove();
            }
            
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            sport selektiraniSport = sportBindingSource.Current as sport;
            if (selektiraniSport != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    sport.BrisanjeSporta(selektiraniSport);
                    PrikaziSportove();
                }
            }
        }
    }
}
