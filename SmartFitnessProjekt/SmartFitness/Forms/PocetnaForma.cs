using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartFitness.Forms;
using SmartFitness.Forms.Interactive;

namespace SmartFitness
{
    public partial class PocetnaForma : Form
    {
        public PocetnaForma()
        {
            InitializeComponent();
            PrikaziFormu(new Unos());
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //metoda za prikaz forme - pnlPrikaz forme
        private void PrikaziFormu(object forma)
        {
            //ako se nesto nalazi u panelu brisemo
            if (pnlPrikazForme.Controls.Count > 0)
            {
                pnlPrikazForme.Controls.RemoveAt(0);
            }

            Form form = (Form) forma;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            pnlPrikazForme.Controls.Add(form);
            pnlPrikazForme.Tag = form;

            form.Show();
        }


        //na ovaj nacin samo instancirati forme napravljene
        private void btnUnos_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new Unos());
        }

        private void btnIspisPretraga_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new IspisIPretraga());
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new StatistikaUcenika());
        }

        private void btnNatjecanja_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new PopisNatjecanja());
        }

        private void btnPopisVjezbi_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new PopisVjezbi());
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void PocetnaForma_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(PocetnaForma_KeyDown);
        }

        private void PocetnaForma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("F1"))
            {
                string nazivDatoteke = "Pomoc.chm";
                string putanjaDoMape = Path.Combine(Environment.CurrentDirectory, @"Data\", nazivDatoteke);
                string pravaPutanja = Path.GetFullPath(Path.Combine(putanjaDoMape, @"..\..\..\..\..\" + "\\" + nazivDatoteke));
                Help.ShowHelp(this, pravaPutanja);
            }
        }
    }
}
