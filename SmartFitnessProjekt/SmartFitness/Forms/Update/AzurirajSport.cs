using System;
using System.Windows.Forms;
using SmartFitness.Database;
using SmartFitness.Helpers.Messages.Error;
using SmartFitness.Helpers.Messages.Success;

namespace SmartFitness.Forms.Update
{
    public partial class AzurirajSport : Form
    {
        public sport Selektiranisport { get; set; }
        public AzurirajSport(sport sport)
        {
            InitializeComponent();
            this.Selektiranisport = sport;
            txtDisciplina.Text = Selektiranisport.disciplina;
            txtNaziv.Text = Selektiranisport.naziv;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            try
            {

                sport.AzuriranjeSporta(txtNaziv.Text, txtDisciplina.Text, Selektiranisport);
                MessageBox.Show(PorukaUspjesno.UspjesnoAzuriranSport, PorukaUspjesno.ZaglavljeUspjesnoAzurirano);
                this.Close();
            }
            catch
            {
                MessageBox.Show(PorukaPogreska.NeispravanUnosPodataka, PorukaPogreska.Zaglavlje);
            }
        }
    }
}
