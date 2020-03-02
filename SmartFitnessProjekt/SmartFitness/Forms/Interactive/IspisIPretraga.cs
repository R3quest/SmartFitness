using System;
using System.Windows.Forms;
using SmartFitness.Database;

namespace SmartFitness.Forms.Interactive
{
    public partial class IspisIPretraga : Form
    {
        public bool Promjena { get; set; }
        public IspisIPretraga()
        {
            InitializeComponent();
            
            DohvatiSport();
            int sportId = (int)comboBoxVrstaSporta.SelectedValue;
            DohvatiUcenikeOcjene(sportId);
            if (dgvPodaciIspisa.SelectedRows.Count > 0)
            {
                int ucenik = Convert.ToInt32(dgvPodaciIspisa.SelectedRows[0].Cells[0].Value.ToString());
                DohvatiVjezbe(ucenik);
            }
            DohvatiUcenikeBezSporta();
        }

        
        public void DohvatiUcenikeBezSporta()
        {
            string pretraga = "";
            
            dgvUceniciBezSporta.DataSource = ucenik.PretrazivanjeUcenikaBezSporta(pretraga);
            dgvUceniciBezSporta.Columns[0].Visible = false;
        }

        public void DohvatiVjezbe(int idUcenika)
        {
            
            DateTime odDatum = datumOd.Value;
            DateTime doDatum = datumDo.Value;
            if (dgvPodaciIspisa.SelectedRows.Count > 0)
            {
                idUcenika = Convert.ToInt32(dgvPodaciIspisa.SelectedRows[0].Cells[0].Value.ToString());
            }

            dgvVjezbe.DataSource = vjezba.DohvatiVjezbePoDatumu(idUcenika, odDatum, doDatum);
            if (dgvVjezbe.Rows.Count != 0)
            {
                dgvVjezbe.Columns[0].Visible = false;
            }
            //dgvVjezbe.Columns[0].Visible = false;
        }



        

        public void DohvatiUcenikeOcjene(int sportId)
        {
            dgvPodaciIspisa.DataSource = ucenik.DohvatiOcijeneUcenika(sportId);
            dgvPodaciIspisa.Columns[0].Visible = false;
        }

        public void DohvatiSport()
        {
            sportBindingSource.DataSource = sport.DohvatiSportove();
        }


        private void comboBoxVrstaIspisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int sportId = (int)comboBoxVrstaSporta.SelectedValue;
                DohvatiUcenikeOcjene(sportId);
            }
            catch {}
        }

        private void txtPretraziIspis_TextChanged(object sender, EventArgs e)
        {
            comboBoxVrstaSporta.SelectedValue = "";
            string ime = txtPretraziIspis.Text;

            dgvPodaciIspisa.DataSource = ucenik.PretrazivanjeUcenika(ime);
            if (dgvPodaciIspisa.Rows.Count != 0)
            {
                dgvPodaciIspisa.Columns[0].Visible = false;
            }
            
        }

        private void txtPretraziIspis_Enter(object sender, EventArgs e)
        {
            if (txtPretraziIspis.Text.Equals("Pretrazi po imenu ili prezimenu..."))
            {
                txtPretraziIspis.Text = "";
            }
        }

        private void dgvPodaciIspisa_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPodaciIspisa.SelectedRows.Count > 0)
            {
                int ucenik = Convert.ToInt32(dgvPodaciIspisa.SelectedRows[0].Cells[0].Value.ToString());
                DohvatiVjezbe(ucenik);
            }
        }

        private void txtPretraziIspis_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxVrstaSporta.SelectedValue = "";
            string ime = txtPretraziIspis.Text;
            dgvPodaciIspisa.DataSource = ucenik.PretrazivanjeUcenika(ime);
            if (dgvPodaciIspisa.Rows.Count != 0)
            {
                dgvPodaciIspisa.Columns[0].Visible = false;
            }
            
        }

        private void DatumOd_ValueChanged(object sender, EventArgs e)
        {
            int idUcenika=0;
            DateTime odDatum = datumOd.Value;
            DateTime doDatum = datumDo.Value;
            if (dgvPodaciIspisa.SelectedRows.Count > 0)
            {
                 idUcenika = Convert.ToInt32(dgvPodaciIspisa.SelectedRows[0].Cells[0].Value.ToString());
            }
            dgvVjezbe.DataSource = vjezba.DohvatiVjezbePoDatumu(idUcenika,odDatum,doDatum);
            if (dgvVjezbe.Rows.Count != 0)
            {
                dgvVjezbe.Columns[0].Visible = false;
            }

        }

        private void datumDo_ValueChanged(object sender, EventArgs e)
        {
            
            int idUcenika = 0;
            DateTime odDatum = datumOd.Value;
            DateTime doDatum = datumDo.Value;
            if (dgvPodaciIspisa.SelectedRows.Count > 0)
            {
                idUcenika = Convert.ToInt32(dgvPodaciIspisa.SelectedRows[0].Cells[0].Value.ToString());
            }

            dgvVjezbe.DataSource = vjezba.DohvatiVjezbePoDatumu(idUcenika, odDatum, doDatum);
            if (!(dgvVjezbe.Rows.Count == 0))
            {
                dgvVjezbe.Columns[0].Visible = false;
            }
        }
        
        private void dgvUceniciBezSporta_SelectionChanged(object sender, EventArgs e)
        {
            int idUcenika = 0;
            DateTime odDatum = datumOd.Value;
            DateTime doDatum = datumDo.Value;
            if (dgvUceniciBezSporta.SelectedRows.Count > 0)
            {
                if (dgvUceniciBezSporta.SelectedRows.Count >0)
                {
                    try
                    {
                        idUcenika = int.Parse(dgvUceniciBezSporta.SelectedRows[0].Cells[0].Value.ToString());
                    }
                    catch{ }
                }
                
            }
            dgvVjezbe.DataSource = vjezba.DohvatiVjezbePoDatumu(idUcenika, odDatum, doDatum);
            if (dgvVjezbe.Rows.Count != 0)
            {
                dgvVjezbe.Columns[0].Visible = false;
            }
        }

        private void txtPretr_TextChanged(object sender, EventArgs e)
        {
            string pretraga = txtPretr.Text;
            dgvUceniciBezSporta.DataSource = ucenik.PretrazivanjeUcenikaBezSporta(pretraga);
            if (dgvUceniciBezSporta.Rows.Count != 0)
            {
                dgvUceniciBezSporta.Columns[0].Visible = false;
            }
            
        }

        private void txtPretr_MouseClick(object sender, MouseEventArgs e)
        {
            txtPretr.Text = "";
        }
    }
}
