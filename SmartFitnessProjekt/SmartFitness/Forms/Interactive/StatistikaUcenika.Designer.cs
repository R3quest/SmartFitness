using System.Windows.Forms;

namespace SmartFitness.Forms.Interactive
{
    partial class StatistikaUcenika
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvUcenici = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chartStatistikaVjezbe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cboVjezba = new System.Windows.Forms.ComboBox();
            this.vjezbaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtUkupniNapredak = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDnevniNapredak = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProsjek = new System.Windows.Forms.TextBox();
            this.txtNorma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPotrebnoVjezbati = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistikaVjezbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vjezbaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ucenik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(528, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vjezba";
            // 
            // dgvUcenici
            // 
            this.dgvUcenici.AllowUserToAddRows = false;
            this.dgvUcenici.AllowUserToDeleteRows = false;
            this.dgvUcenici.AutoGenerateColumns = false;
            this.dgvUcenici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUcenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUcenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvUcenici.DataSource = this.ucenikBindingSource;
            this.dgvUcenici.Location = new System.Drawing.Point(31, 43);
            this.dgvUcenici.Name = "dgvUcenici";
            this.dgvUcenici.ReadOnly = true;
            this.dgvUcenici.RowTemplate.Height = 24;
            this.dgvUcenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUcenici.Size = new System.Drawing.Size(480, 598);
            this.dgvUcenici.TabIndex = 9;
            this.dgvUcenici.SelectionChanged += new System.EventHandler(this.dgvUcenici_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ime";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prezime";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prezime";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "razred";
            this.dataGridViewTextBoxColumn4.HeaderText = "Razred";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_ucenika";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_ucenika";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_korisnika";
            this.dataGridViewTextBoxColumn5.HeaderText = "id_korisnika";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "korisnik";
            this.dataGridViewTextBoxColumn6.HeaderText = "korisnik";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "natjecanje_ucenik";
            this.dataGridViewTextBoxColumn7.HeaderText = "natjecanje_ucenik";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "sport_ucenik";
            this.dataGridViewTextBoxColumn8.HeaderText = "sport_ucenik";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "vjezba_ucenik";
            this.dataGridViewTextBoxColumn9.HeaderText = "vjezba_ucenik";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // ucenikBindingSource
            // 
            this.ucenikBindingSource.DataSource = typeof(SmartFitness.Database.ucenik);
            // 
            // chartStatistikaVjezbe
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStatistikaVjezbe.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStatistikaVjezbe.Legends.Add(legend1);
            this.chartStatistikaVjezbe.Location = new System.Drawing.Point(528, 211);
            this.chartStatistikaVjezbe.Name = "chartStatistikaVjezbe";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Ostvareno";
            this.chartStatistikaVjezbe.Series.Add(series1);
            this.chartStatistikaVjezbe.Size = new System.Drawing.Size(655, 339);
            this.chartStatistikaVjezbe.TabIndex = 11;
            this.chartStatistikaVjezbe.Text = "chart1";
            // 
            // cboVjezba
            // 
            this.cboVjezba.DataSource = this.vjezbaBindingSource;
            this.cboVjezba.DisplayMember = "naziv";
            this.cboVjezba.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVjezba.FormattingEnabled = true;
            this.cboVjezba.Location = new System.Drawing.Point(532, 44);
            this.cboVjezba.Name = "cboVjezba";
            this.cboVjezba.Size = new System.Drawing.Size(193, 24);
            this.cboVjezba.TabIndex = 13;
            this.cboVjezba.ValueMember = "id_vjezbe";
            this.cboVjezba.SelectedIndexChanged += new System.EventHandler(this.cboVjezba_SelectedIndexChanged);
            // 
            // vjezbaBindingSource
            // 
            this.vjezbaBindingSource.DataSource = typeof(SmartFitness.Database.vjezba);
            // 
            // txtUkupniNapredak
            // 
            this.txtUkupniNapredak.Enabled = false;
            this.txtUkupniNapredak.Location = new System.Drawing.Point(750, 621);
            this.txtUkupniNapredak.Name = "txtUkupniNapredak";
            this.txtUkupniNapredak.Size = new System.Drawing.Size(137, 22);
            this.txtUkupniNapredak.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(528, 621);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ukupni napredak";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(528, 591);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Odstupanje od prosjeka";
            // 
            // txtDnevniNapredak
            // 
            this.txtDnevniNapredak.Enabled = false;
            this.txtDnevniNapredak.Location = new System.Drawing.Point(750, 591);
            this.txtDnevniNapredak.Name = "txtDnevniNapredak";
            this.txtDnevniNapredak.Size = new System.Drawing.Size(137, 22);
            this.txtDnevniNapredak.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(528, 561);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Prosjek";
            // 
            // txtProsjek
            // 
            this.txtProsjek.Enabled = false;
            this.txtProsjek.Location = new System.Drawing.Point(750, 561);
            this.txtProsjek.Name = "txtProsjek";
            this.txtProsjek.Size = new System.Drawing.Size(137, 22);
            this.txtProsjek.TabIndex = 18;
            // 
            // txtNorma
            // 
            this.txtNorma.Enabled = false;
            this.txtNorma.Location = new System.Drawing.Point(1046, 43);
            this.txtNorma.Name = "txtNorma";
            this.txtNorma.Size = new System.Drawing.Size(137, 22);
            this.txtNorma.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(951, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Norma";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(861, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Potrebno vjezbati?";
            // 
            // txtPotrebnoVjezbati
            // 
            this.txtPotrebnoVjezbati.Enabled = false;
            this.txtPotrebnoVjezbati.Location = new System.Drawing.Point(1046, 73);
            this.txtPotrebnoVjezbati.Name = "txtPotrebnoVjezbati";
            this.txtPotrebnoVjezbati.Size = new System.Drawing.Size(137, 22);
            this.txtPotrebnoVjezbati.TabIndex = 22;
            // 
            // Statistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1236, 653);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPotrebnoVjezbati);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNorma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProsjek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDnevniNapredak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUkupniNapredak);
            this.Controls.Add(this.cboVjezba);
            this.Controls.Add(this.chartStatistikaVjezbe);
            this.Controls.Add(this.dgvUcenici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistika";
            this.Text = "Statistika";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistikaVjezbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vjezbaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvUcenici;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn razredDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iducenikaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idkorisnikaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sportucenikDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vjezbaucenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistikaVjezbe;
        private System.Windows.Forms.ComboBox cboVjezba;
        private System.Windows.Forms.TextBox txtUkupniNapredak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDnevniNapredak;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProsjek;
        private System.Windows.Forms.TextBox txtNorma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPotrebnoVjezbati;
        private System.Windows.Forms.BindingSource ucenikBindingSource;
        private System.Windows.Forms.BindingSource vjezbaBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}