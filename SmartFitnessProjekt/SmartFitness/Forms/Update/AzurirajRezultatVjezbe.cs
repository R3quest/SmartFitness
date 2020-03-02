using System;
using System.Windows.Forms;
using SmartFitness.Database;
using SmartFitness.Helpers.Messages.Error;

namespace SmartFitness.Forms.Update
{
    public partial class AzurirajRezultatVjezbe : Form
    {
        public ucenik Ucenik { get; set; }
        public int VjezbaId { get; set; }

        public AzurirajRezultatVjezbe(ucenik ucenik)
        {
            InitializeComponent();
            this.Ucenik = ucenik;
            DohvatiVjezbeUcenika();
            PrikaziTreninge();
        }

        public void DohvatiVjezbeUcenika()
        {
            vjezbaBindingSource.DataSource = vjezba.DohvatiVjezbeUcenika(Ucenik);
        }

        public void PrikaziTreninge()
        {
            try
            {
                this.VjezbaId = (int)cboVjezbe.SelectedValue;
                vjezbaucenikBindingSource.DataSource = vjezba_ucenik.DohvatiTreningeUcenika(VjezbaId, Ucenik);
            }
            catch
            {
                MessageBox.Show(PorukaPogreska.AzuriranjeRezultataVjezbeNijeNaTreningu, PorukaPogreska.Zaglavlje);
                this.Close();
            }
            
        }

        public void DohvatiVrijednostiTreninga()
        {
            if (dgvVjezbeUcenika.CurrentRow != null)
            {
                dateVjezbanja.Value = (DateTime) dgvVjezbeUcenika.CurrentRow.Cells[0].Value;
                txtPonavljanja.Text = dgvVjezbeUcenika.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void cboVjezbe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PrikaziTreninge();
            }
            catch {}
        }

        private void dgvVjezbeUcenika_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DohvatiVrijednostiTreninga();
            }
            catch {}
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            try
            {
                var treningUcenika = dgvVjezbeUcenika.CurrentRow.DataBoundItem as vjezba_ucenik;
                var datumVjezbanja = dateVjezbanja.Value;
                var ostvarenoPonavljanja = int.Parse(txtPonavljanja.Text);

                vjezba_ucenik.AzurirajTreningUcenika(treningUcenika, datumVjezbanja, ostvarenoPonavljanja);
                PrikaziTreninge();
            }
            catch
            {
                MessageBox.Show(PorukaPogreska.NeispravanUnosPodataka, PorukaPogreska.Zaglavlje);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvVjezbeUcenika.CurrentRow != null)
            {
                var trening = dgvVjezbeUcenika.CurrentRow.DataBoundItem as vjezba_ucenik;
                try
                {
                    vjezba_ucenik.ObrisiTreningUcenika(trening);
                    PrikaziTreninge();
                }
                catch
                {
                    MessageBox.Show(PorukaPogreska.AdministratorPogreska, PorukaPogreska.Zaglavlje);
                }
            }
        }
    }
}
