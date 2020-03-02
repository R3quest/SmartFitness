namespace SmartFitness.Forms.Add
{
    partial class DodajRezultatVjezbe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboVjezba = new System.Windows.Forms.ComboBox();
            this.vjezbaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblRezultat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateVjezbanja = new System.Windows.Forms.DateTimePicker();
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
            this.txtPonavljanja = new System.Windows.Forms.TextBox();
            this.btnDodaj = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAzuriraj = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vjezbaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ucenik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(518, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vjezba";
            // 
            // cboVjezba
            // 
            this.cboVjezba.DataSource = this.vjezbaBindingSource;
            this.cboVjezba.DisplayMember = "naziv";
            this.cboVjezba.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVjezba.FormattingEnabled = true;
            this.cboVjezba.Location = new System.Drawing.Point(618, 43);
            this.cboVjezba.Margin = new System.Windows.Forms.Padding(2);
            this.cboVjezba.Name = "cboVjezba";
            this.cboVjezba.Size = new System.Drawing.Size(260, 24);
            this.cboVjezba.TabIndex = 1;
            this.cboVjezba.ValueMember = "id_vjezbe";
            // 
            // vjezbaBindingSource
            // 
            this.vjezbaBindingSource.DataSource = typeof(SmartFitness.Database.vjezba);
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRezultat.Location = new System.Drawing.Point(518, 112);
            this.lblRezultat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(81, 17);
            this.lblRezultat.TabIndex = 7;
            this.lblRezultat.Text = "Ponavljanja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(518, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Datum";
            // 
            // dateVjezbanja
            // 
            this.dateVjezbanja.CustomFormat = "yyyy-MM-dd";
            this.dateVjezbanja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateVjezbanja.Location = new System.Drawing.Point(618, 77);
            this.dateVjezbanja.Margin = new System.Windows.Forms.Padding(2);
            this.dateVjezbanja.MinDate = new System.DateTime(2018, 6, 21, 0, 0, 0, 0);
            this.dateVjezbanja.Name = "dateVjezbanja";
            this.dateVjezbanja.Size = new System.Drawing.Size(260, 22);
            this.dateVjezbanja.TabIndex = 2;
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
            this.dgvUcenici.Location = new System.Drawing.Point(15, 43);
            this.dgvUcenici.Name = "dgvUcenici";
            this.dgvUcenici.ReadOnly = true;
            this.dgvUcenici.RowHeadersWidth = 51;
            this.dgvUcenici.RowTemplate.Height = 24;
            this.dgvUcenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUcenici.Size = new System.Drawing.Size(480, 557);
            this.dgvUcenici.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ime";
            this.dataGridViewTextBoxColumn2.HeaderText = "ime";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prezime";
            this.dataGridViewTextBoxColumn3.HeaderText = "prezime";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "razred";
            this.dataGridViewTextBoxColumn4.HeaderText = "razred";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_ucenika";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_ucenika";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_korisnika";
            this.dataGridViewTextBoxColumn5.HeaderText = "id_korisnika";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "korisnik";
            this.dataGridViewTextBoxColumn6.HeaderText = "korisnik";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "natjecanje_ucenik";
            this.dataGridViewTextBoxColumn7.HeaderText = "natjecanje_ucenik";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "sport_ucenik";
            this.dataGridViewTextBoxColumn8.HeaderText = "sport_ucenik";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "vjezba_ucenik";
            this.dataGridViewTextBoxColumn9.HeaderText = "vjezba_ucenik";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // ucenikBindingSource
            // 
            this.ucenikBindingSource.DataSource = typeof(SmartFitness.Database.ucenik);
            // 
            // txtPonavljanja
            // 
            this.txtPonavljanja.Location = new System.Drawing.Point(618, 115);
            this.txtPonavljanja.Name = "txtPonavljanja";
            this.txtPonavljanja.Size = new System.Drawing.Size(260, 22);
            this.txtPonavljanja.TabIndex = 9;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodaj.BorderRadius = 0;
            this.btnDodaj.ButtonText = "Dodaj trening";
            this.btnDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodaj.DisabledColor = System.Drawing.Color.Gray;
            this.btnDodaj.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDodaj.Iconimage = null;
            this.btnDodaj.Iconimage_right = null;
            this.btnDodaj.Iconimage_right_Selected = null;
            this.btnDodaj.Iconimage_Selected = null;
            this.btnDodaj.IconMarginLeft = 0;
            this.btnDodaj.IconMarginRight = 0;
            this.btnDodaj.IconRightVisible = true;
            this.btnDodaj.IconRightZoom = 0D;
            this.btnDodaj.IconVisible = true;
            this.btnDodaj.IconZoom = 90D;
            this.btnDodaj.IsTab = true;
            this.btnDodaj.Location = new System.Drawing.Point(521, 171);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDodaj.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDodaj.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDodaj.selected = true;
            this.btnDodaj.Size = new System.Drawing.Size(357, 43);
            this.btnDodaj.TabIndex = 38;
            this.btnDodaj.Text = "Dodaj trening";
            this.btnDodaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDodaj.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnDodaj.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAzuriraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAzuriraj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAzuriraj.BorderRadius = 0;
            this.btnAzuriraj.ButtonText = "Azuriraj / Obrisi trening";
            this.btnAzuriraj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAzuriraj.DisabledColor = System.Drawing.Color.Gray;
            this.btnAzuriraj.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAzuriraj.Iconimage = null;
            this.btnAzuriraj.Iconimage_right = null;
            this.btnAzuriraj.Iconimage_right_Selected = null;
            this.btnAzuriraj.Iconimage_Selected = null;
            this.btnAzuriraj.IconMarginLeft = 0;
            this.btnAzuriraj.IconMarginRight = 0;
            this.btnAzuriraj.IconRightVisible = true;
            this.btnAzuriraj.IconRightZoom = 0D;
            this.btnAzuriraj.IconVisible = true;
            this.btnAzuriraj.IconZoom = 90D;
            this.btnAzuriraj.IsTab = true;
            this.btnAzuriraj.Location = new System.Drawing.Point(521, 222);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAzuriraj.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAzuriraj.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAzuriraj.selected = true;
            this.btnAzuriraj.Size = new System.Drawing.Size(357, 43);
            this.btnAzuriraj.TabIndex = 39;
            this.btnAzuriraj.Text = "Azuriraj / Obrisi trening";
            this.btnAzuriraj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAzuriraj.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnAzuriraj.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(519, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "/ metara";
            // 
            // DodajRezultatVjezbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(956, 619);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtPonavljanja);
            this.Controls.Add(this.dgvUcenici);
            this.Controls.Add(this.dateVjezbanja);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboVjezba);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DodajRezultatVjezbe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UnesiRezultatVjezbe";
            ((System.ComponentModel.ISupportInitialize)(this.vjezbaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucenikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboVjezba;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateVjezbanja;
        private System.Windows.Forms.DataGridView dgvUcenici;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iducenikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkorisnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn natjecanjeucenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportucenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vjezbaucenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtPonavljanja;
        private System.Windows.Forms.BindingSource vjezbaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.BindingSource ucenikBindingSource;
        private Bunifu.Framework.UI.BunifuFlatButton btnDodaj;
        private Bunifu.Framework.UI.BunifuFlatButton btnAzuriraj;
        private System.Windows.Forms.Label label3;
    }
}