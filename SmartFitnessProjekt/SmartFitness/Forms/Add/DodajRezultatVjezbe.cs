using System;
using System.Windows.Forms;
using SmartFitness.Database;
using SmartFitness.Forms.Update;
using SmartFitness.Helpers.Messages.Error;
using SmartFitness.Helpers.Messages.Success;

namespace SmartFitness.Forms.Add
{
    public partial class DodajRezultatVjezbe : Form
    {
        public DodajRezultatVjezbe()
        {
            InitializeComponent();
            PrikaziUcenike();
            PrikaziVjezbe();
        }

        public void PrikaziUcenike()
        {
            ucenikBindingSource.DataSource = ucenik.DohvatiUcenike();
        }

        public void PrikaziVjezbe()
        {
            vjezbaBindingSource.DataSource = vjezba.DohvatiVjezbe();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                int vjezbaId = int.Parse(cboVjezba.SelectedValue.ToString());
                if (dgvUcenici.CurrentRow != null)
                {
                    int ucenikId = int.Parse(dgvUcenici.CurrentRow.Cells[3].Value.ToString());
                    DateTime datumVjezbanja = dateVjezbanja.Value.Date;
                    int brojPonavljanja = int.Parse(txtPonavljanja.Text);
                
                    vjezba_ucenik.DodajRezultatVjezbe(vjezbaId, ucenikId, datumVjezbanja, brojPonavljanja);
                    MessageBox.Show(PorukaUspjesno.UspjesnoDodanRezultatVjezbe, PorukaUspjesno.Zaglavlje);
                }
            }
            catch
            {
                MessageBox.Show(PorukaPogreska.NeispravanUnosPodataka, PorukaPogreska.Zaglavlje);
            }
        }
        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            try
            {
                var ucenik = dgvUcenici.SelectedRows[0].DataBoundItem as ucenik;
                var azurirajRezultatVjezbe = new AzurirajRezultatVjezbe(ucenik);
                azurirajRezultatVjezbe.ShowDialog();
            }
            catch {}
        }
    }
}
