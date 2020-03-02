using System;
using System.Windows.Forms;
using SmartFitness.Database;
using SmartFitness.Forms.Update;
using SmartFitness.Helpers.Messages.Error;
using SmartFitness.Helpers.Messages.Success;

namespace SmartFitness.Forms.Interactive
{
    public partial class PopisUcenika : Form
    {
        public PopisUcenika()
        {
            InitializeComponent();
            PrikaziUcenike();
        }


        public void PrikaziUcenike()
        {           
            ucenikBindingSource.DataSource = ucenik.DohvatiUcenike();
            
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ucenik.DodajUcenika(txtIme.Text, txtPrezime.Text, Convert.ToInt32(txtRazred.Text));
                MessageBox.Show(PorukaUspjesno.DodanUcenik, PorukaUspjesno.Zaglavlje);
                txtIme.Clear();
                txtPrezime.Clear();
                txtRazred.Clear();
            }
            catch
            {
                MessageBox.Show(PorukaPogreska.NeispravanUnosPodataka, PorukaPogreska.Zaglavlje);
            }
            PrikaziUcenike();
            
        }

        private void btnAzurirajObrisi_Click(object sender, EventArgs e)
        {
            
            var ucenik = dgvUcenici.SelectedRows[0].DataBoundItem as ucenik;
            if (ucenik !=null)
            {
                AzuriranjeUcenika frm = new AzuriranjeUcenika(ucenik);
                frm.ShowDialog();
                PrikaziUcenike();
            }
            
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            ucenik selektiraniUcenik = ucenikBindingSource.Current as ucenik;
            if (selektiraniUcenik != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    ucenik.ObrisiUcenika(selektiraniUcenik);
                    PrikaziUcenike();
                }
            }
        }
    }
}

