using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SmartFitness.Database;
using SmartFitness.Helpers.Calculations;

namespace SmartFitness.Forms.Interactive
{
    public partial class StatistikaUcenika : Form
    {
        private List<int> ostvarenoPonavljanja = new List<int>();
        private List<DateTime> datumi = new List<DateTime>();

        public StatistikaUcenika()
        {
            InitializeComponent();
            PrikaziUcenike();
            DohvatiTreninge();
            PotrebnaNorma();
        }
        public void PrikaziUcenike()
        {
            ucenikBindingSource.DataSource = ucenik.DohvatiUcenikeKojiSuNaVjezbama();
        }

        public void PrikaziVjezbe(int ucenikId)
        {
            vjezbaBindingSource.DataSource = vjezba.DohvatiVjezbeUcenika(ucenikId);
        }

        public void DohvatiTreninge()
        {
            try
            {
                ostvarenoPonavljanja = null;
                datumi = null;
                if (dgvUcenici.CurrentRow != null)
                {
                    int ucenikId = int.Parse(dgvUcenici.CurrentRow.Cells[3].Value.ToString());
                    int vjezbaId = int.Parse(cboVjezba.SelectedValue.ToString());
                    using (var db = new SmartFitnessEntities())
                    {
                        this.ostvarenoPonavljanja = vjezba_ucenik.DohvatiPonavljanjaOdabraneVjezbeIUcenika(ucenikId,vjezbaId);
                        this.datumi = vjezba_ucenik.DohvatiDatumeOdabraneVjezbeIUcenika(ucenikId, vjezbaId);
                    }
                }
            }
            catch{}
        }

        public void AzurirajGraf()
        {
            try
            {
                DohvatiTreninge();
                OcistiGraf();
                DohvatiGraf();
                UkupniNapredak();
                StardardnaDevijacija();
                PotrebnaNorma();
            }
            catch {}
            if (cboVjezba.Items.Count == 0)
            {
                txtProsjek.Text = "-";
                txtDnevniNapredak.Text = "-";
                txtUkupniNapredak.Text = "-";
                txtPotrebnoVjezbati.Text = "-";
            }
        }

        public void StardardnaDevijacija()
        {
            double average = ostvarenoPonavljanja.Average();
            double rezultat = Statistika.IzracunajStandardnuDerivaciju(ostvarenoPonavljanja);
            if (double.IsInfinity(rezultat))
            {
                txtDnevniNapredak.Text = "-";
            }
            else
            {
                txtDnevniNapredak.Text = rezultat.ToString();
            }
            txtProsjek.Text = average > 0 ? average.ToString() : "-";
        }

        public void UkupniNapredak()
        {
            txtUkupniNapredak.Text =
                (ostvarenoPonavljanja.Max() - ostvarenoPonavljanja.Min()) > 0
                    ? (ostvarenoPonavljanja.Max() - ostvarenoPonavljanja.Min()).ToString()
                    : "-";
        }

        private void dgvUcenici_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var tmp = dgvUcenici.SelectedCells[3].Value;
                PrikaziVjezbe((int) tmp);
            }
            catch {}
            AzurirajGraf();
        }

        private void cboVjezba_SelectedIndexChanged(object sender, EventArgs e)
        {
            AzurirajGraf();
        }

        public void DohvatiGraf()
        {
            for (int i = 0; i < ostvarenoPonavljanja.Count; i++)
            {
                this.chartStatistikaVjezbe.Series["Ostvareno"].Points.AddXY(this.datumi[i], this.ostvarenoPonavljanja[i]);
            }
        }

        public void OcistiGraf()
        {
            foreach (var series in chartStatistikaVjezbe.Series)
            {
                series.Points.Clear();
            }
        }

        public void PotrebnaNorma()
        {
            try
            {
                ostvarenoPonavljanja = null;
                datumi = null;
                if (dgvUcenici.CurrentRow != null)
                {
                    int ucenikId = int.Parse(dgvUcenici.CurrentRow.Cells[3].Value.ToString());
                    int vjezbaId = int.Parse(cboVjezba.SelectedValue.ToString());
                    txtNorma.Text = vjezba_ucenik.DohvatiNormuVjezbe(ucenikId, vjezbaId).ToString();
                }
                int norma = int.Parse(txtNorma.Text);
                double prosjek = txtProsjek.Text.Length > 0 ? double.Parse(txtProsjek.Text) : 0;
                txtPotrebnoVjezbati.Text = norma > prosjek ? "Da" : "Ne";
            }
            catch {}
        }
    }
}
