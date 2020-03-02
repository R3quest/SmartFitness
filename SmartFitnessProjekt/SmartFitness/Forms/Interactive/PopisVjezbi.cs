using System;
using System.Windows.Forms;
using SmartFitness.Forms.Update;
using SmartFitness.Helpers.Messages.Error;
using SmartFitness.Helpers.Messages.Success;

namespace SmartFitness.Forms.Interactive
{
    public partial class PopisVjezbi : Form
    {
        public PopisVjezbi()
        {
            InitializeComponent();
            DohvatiVjezbe();
        }

        public void DohvatiVjezbe()
        {
            vjezbaBindingSource.DataSource = Database.vjezba.DohvatiVjezbe();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            try
            {
                var naziv = txtNaziv.Text;
                var opis = txtOpis.Text;
                var vrijemeVjezbanja = int.Parse(txtVrijeme.Text);
                var ponavljanja = int.Parse(txtPonavljanje.Text);

                Database.vjezba.DodajVjezbu(naziv, opis, vrijemeVjezbanja, ponavljanja);
                DohvatiVjezbe();
            }
            catch
            {
                MessageBox.Show(PorukaPogreska.NeispravanUnosPodataka, PorukaPogreska.Zaglavlje);
            }
           
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (dgvVjezbe.CurrentRow != null)
            {
                var azurirajVjezbu = new AzurirajVjezbu(dgvVjezbe.CurrentRow.DataBoundItem as Database.vjezba);
                azurirajVjezbu.ShowDialog();
                DohvatiVjezbe();
            }
            else
            {
                MessageBox.Show(PorukaPogreska.OznacenaVjezba, PorukaPogreska.Zaglavlje);
            }
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVjezbe.CurrentRow != null)
                {
                    Database.vjezba vjezba = dgvVjezbe.CurrentRow.DataBoundItem as Database.vjezba;
                    if (vjezba != null)
                    {
                        int vjezbaId = vjezba.id_vjezbe;
                        Database.vjezba.ObrisiVjezbu(vjezbaId);

                        MessageBox.Show(PorukaUspjesno.ObrisanaVjezba, PorukaUspjesno.Zaglavlje);
                        DohvatiVjezbe();
                        return;
                    }
                }
                MessageBox.Show(PorukaPogreska.OznacenaVjezba, PorukaPogreska.Zaglavlje);
            }
            catch
            {
                MessageBox.Show(@"Dogodila se greska", PorukaPogreska.Zaglavlje);
            }
        }
    }
}
