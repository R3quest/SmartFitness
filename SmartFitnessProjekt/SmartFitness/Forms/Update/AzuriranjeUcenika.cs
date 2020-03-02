using System;
using System.Windows.Forms;
using SmartFitness.Database;
using SmartFitness.Helpers.Messages.Error;
using SmartFitness.Helpers.Messages.Success;

namespace SmartFitness.Forms.Update
{
    public partial class AzuriranjeUcenika : Form
    {
        public ucenik Selektiraniucenik { get; set; }
        public AzuriranjeUcenika(ucenik ucenik)
        {
            InitializeComponent();
            this.Selektiraniucenik = ucenik;
            
            txtIme.Text = Selektiraniucenik.ime;
            txtPrezime.Text = Selektiraniucenik.prezime;
            txtRazred.Text = Selektiraniucenik.razred.ToString();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            try
            {
                ucenik.AzurirajUcenika(txtIme.Text, txtPrezime.Text, Convert.ToInt32(txtRazred.Text),Selektiraniucenik);
                MessageBox.Show(PorukaUspjesno.AzuriranjeUcenika, PorukaUspjesno.ZaglavljeUspjesnoAzurirano);
                this.Close();
            }
            catch
            {
                MessageBox.Show(PorukaPogreska.NeispravanUnosPodataka, PorukaPogreska.Zaglavlje);
            }
        }
    }
}
