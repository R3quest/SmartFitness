namespace SmartFitness.Forms.Add
{
    partial class DodajSportUceniku
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
            this.cboSport = new System.Windows.Forms.ComboBox();
            this.sportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvUcenik = new System.Windows.Forms.DataGridView();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iducenikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkorisnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.natjecanjeucenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportucenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vjezbaucenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dateVjezbanja = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.cboOcijena = new System.Windows.Forms.ComboBox();
            this.btnDodajOcijenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAzurirajOcijenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvOcijenePojedinogSportaUcenika = new System.Windows.Forms.DataGridView();
            this.btnObrisiOcijenu = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.sportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcenik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcijenePojedinogSportaUcenika)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sport";
            // 
            // cboSport
            // 
            this.cboSport.DataSource = this.sportBindingSource;
            this.cboSport.DisplayMember = "naziv";
            this.cboSport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSport.FormattingEnabled = true;
            this.cboSport.Location = new System.Drawing.Point(90, 22);
            this.cboSport.Name = "cboSport";
            this.cboSport.Size = new System.Drawing.Size(150, 24);
            this.cboSport.TabIndex = 1;
            this.cboSport.ValueMember = "id_sporta";
            // 
            // sportBindingSource
            // 
            this.sportBindingSource.DataSource = typeof(SmartFitness.Database.sport);
            // 
            // dgvUcenik
            // 
            this.dgvUcenik.AllowUserToAddRows = false;
            this.dgvUcenik.AllowUserToDeleteRows = false;
            this.dgvUcenik.AutoGenerateColumns = false;
            this.dgvUcenik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUcenik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUcenik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.razredDataGridViewTextBoxColumn,
            this.iducenikaDataGridViewTextBoxColumn,
            this.idkorisnikaDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.natjecanjeucenikDataGridViewTextBoxColumn,
            this.sportucenikDataGridViewTextBoxColumn,
            this.vjezbaucenikDataGridViewTextBoxColumn});
            this.dgvUcenik.DataSource = this.ucenikBindingSource;
            this.dgvUcenik.Location = new System.Drawing.Point(28, 78);
            this.dgvUcenik.Name = "dgvUcenik";
            this.dgvUcenik.ReadOnly = true;
            this.dgvUcenik.RowTemplate.Height = 24;
            this.dgvUcenik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUcenik.Size = new System.Drawing.Size(393, 567);
            this.dgvUcenik.TabIndex = 2;
            this.dgvUcenik.SelectionChanged += new System.EventHandler(this.dgvUcenik_SelectionChanged);
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // razredDataGridViewTextBoxColumn
            // 
            this.razredDataGridViewTextBoxColumn.DataPropertyName = "razred";
            this.razredDataGridViewTextBoxColumn.HeaderText = "razred";
            this.razredDataGridViewTextBoxColumn.Name = "razredDataGridViewTextBoxColumn";
            this.razredDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iducenikaDataGridViewTextBoxColumn
            // 
            this.iducenikaDataGridViewTextBoxColumn.DataPropertyName = "id_ucenika";
            this.iducenikaDataGridViewTextBoxColumn.HeaderText = "id_ucenika";
            this.iducenikaDataGridViewTextBoxColumn.Name = "iducenikaDataGridViewTextBoxColumn";
            this.iducenikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iducenikaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idkorisnikaDataGridViewTextBoxColumn
            // 
            this.idkorisnikaDataGridViewTextBoxColumn.DataPropertyName = "id_korisnika";
            this.idkorisnikaDataGridViewTextBoxColumn.HeaderText = "id_korisnika";
            this.idkorisnikaDataGridViewTextBoxColumn.Name = "idkorisnikaDataGridViewTextBoxColumn";
            this.idkorisnikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idkorisnikaDataGridViewTextBoxColumn.Visible = false;
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.ReadOnly = true;
            this.korisnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // natjecanjeucenikDataGridViewTextBoxColumn
            // 
            this.natjecanjeucenikDataGridViewTextBoxColumn.DataPropertyName = "natjecanje_ucenik";
            this.natjecanjeucenikDataGridViewTextBoxColumn.HeaderText = "natjecanje_ucenik";
            this.natjecanjeucenikDataGridViewTextBoxColumn.Name = "natjecanjeucenikDataGridViewTextBoxColumn";
            this.natjecanjeucenikDataGridViewTextBoxColumn.ReadOnly = true;
            this.natjecanjeucenikDataGridViewTextBoxColumn.Visible = false;
            // 
            // sportucenikDataGridViewTextBoxColumn
            // 
            this.sportucenikDataGridViewTextBoxColumn.DataPropertyName = "sport_ucenik";
            this.sportucenikDataGridViewTextBoxColumn.HeaderText = "sport_ucenik";
            this.sportucenikDataGridViewTextBoxColumn.Name = "sportucenikDataGridViewTextBoxColumn";
            this.sportucenikDataGridViewTextBoxColumn.ReadOnly = true;
            this.sportucenikDataGridViewTextBoxColumn.Visible = false;
            // 
            // vjezbaucenikDataGridViewTextBoxColumn
            // 
            this.vjezbaucenikDataGridViewTextBoxColumn.DataPropertyName = "vjezba_ucenik";
            this.vjezbaucenikDataGridViewTextBoxColumn.HeaderText = "vjezba_ucenik";
            this.vjezbaucenikDataGridViewTextBoxColumn.Name = "vjezbaucenikDataGridViewTextBoxColumn";
            this.vjezbaucenikDataGridViewTextBoxColumn.ReadOnly = true;
            this.vjezbaucenikDataGridViewTextBoxColumn.Visible = false;
            // 
            // ucenikBindingSource
            // 
            this.ucenikBindingSource.DataSource = typeof(SmartFitness.Database.ucenik);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ucenik";
            // 
            // dateVjezbanja
            // 
            this.dateVjezbanja.CustomFormat = "yyyy-MM-dd";
            this.dateVjezbanja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateVjezbanja.Location = new System.Drawing.Point(595, 78);
            this.dateVjezbanja.Margin = new System.Windows.Forms.Padding(2);
            this.dateVjezbanja.MinDate = new System.DateTime(2018, 6, 21, 0, 0, 0, 0);
            this.dateVjezbanja.Name = "dateVjezbanja";
            this.dateVjezbanja.Size = new System.Drawing.Size(260, 22);
            this.dateVjezbanja.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(495, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(495, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ocijena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(495, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Opis";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(595, 136);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(260, 140);
            this.txtOpis.TabIndex = 11;
            // 
            // cboOcijena
            // 
            this.cboOcijena.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOcijena.FormattingEnabled = true;
            this.cboOcijena.Location = new System.Drawing.Point(595, 106);
            this.cboOcijena.Name = "cboOcijena";
            this.cboOcijena.Size = new System.Drawing.Size(260, 24);
            this.cboOcijena.TabIndex = 19;
            // 
            // btnDodajOcijenu
            // 
            this.btnDodajOcijenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDodajOcijenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDodajOcijenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodajOcijenu.BorderRadius = 0;
            this.btnDodajOcijenu.ButtonText = "Dodaj ocijenu";
            this.btnDodajOcijenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodajOcijenu.DisabledColor = System.Drawing.Color.Gray;
            this.btnDodajOcijenu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDodajOcijenu.Iconimage = null;
            this.btnDodajOcijenu.Iconimage_right = null;
            this.btnDodajOcijenu.Iconimage_right_Selected = null;
            this.btnDodajOcijenu.Iconimage_Selected = null;
            this.btnDodajOcijenu.IconMarginLeft = 0;
            this.btnDodajOcijenu.IconMarginRight = 0;
            this.btnDodajOcijenu.IconRightVisible = true;
            this.btnDodajOcijenu.IconRightZoom = 0D;
            this.btnDodajOcijenu.IconVisible = true;
            this.btnDodajOcijenu.IconZoom = 90D;
            this.btnDodajOcijenu.IsTab = true;
            this.btnDodajOcijenu.Location = new System.Drawing.Point(498, 299);
            this.btnDodajOcijenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajOcijenu.Name = "btnDodajOcijenu";
            this.btnDodajOcijenu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDodajOcijenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDodajOcijenu.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDodajOcijenu.selected = true;
            this.btnDodajOcijenu.Size = new System.Drawing.Size(357, 42);
            this.btnDodajOcijenu.TabIndex = 28;
            this.btnDodajOcijenu.Text = "Dodaj ocijenu";
            this.btnDodajOcijenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDodajOcijenu.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnDodajOcijenu.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajOcijenu.Click += new System.EventHandler(this.btnDodajOcijenu_Click);
            // 
            // btnAzurirajOcijenu
            // 
            this.btnAzurirajOcijenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAzurirajOcijenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAzurirajOcijenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAzurirajOcijenu.BorderRadius = 0;
            this.btnAzurirajOcijenu.ButtonText = "Azuriraj ocijenu";
            this.btnAzurirajOcijenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAzurirajOcijenu.DisabledColor = System.Drawing.Color.Gray;
            this.btnAzurirajOcijenu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAzurirajOcijenu.Iconimage = null;
            this.btnAzurirajOcijenu.Iconimage_right = null;
            this.btnAzurirajOcijenu.Iconimage_right_Selected = null;
            this.btnAzurirajOcijenu.Iconimage_Selected = null;
            this.btnAzurirajOcijenu.IconMarginLeft = 0;
            this.btnAzurirajOcijenu.IconMarginRight = 0;
            this.btnAzurirajOcijenu.IconRightVisible = true;
            this.btnAzurirajOcijenu.IconRightZoom = 0D;
            this.btnAzurirajOcijenu.IconVisible = true;
            this.btnAzurirajOcijenu.IconZoom = 90D;
            this.btnAzurirajOcijenu.IsTab = true;
            this.btnAzurirajOcijenu.Location = new System.Drawing.Point(498, 347);
            this.btnAzurirajOcijenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAzurirajOcijenu.Name = "btnAzurirajOcijenu";
            this.btnAzurirajOcijenu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAzurirajOcijenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAzurirajOcijenu.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAzurirajOcijenu.selected = true;
            this.btnAzurirajOcijenu.Size = new System.Drawing.Size(357, 42);
            this.btnAzurirajOcijenu.TabIndex = 29;
            this.btnAzurirajOcijenu.Text = "Azuriraj ocijenu";
            this.btnAzurirajOcijenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAzurirajOcijenu.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnAzurirajOcijenu.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajOcijenu.Click += new System.EventHandler(this.btnAzurirajOcijenu_Click);
            // 
            // dgvOcijenePojedinogSportaUcenika
            // 
            this.dgvOcijenePojedinogSportaUcenika.AllowUserToAddRows = false;
            this.dgvOcijenePojedinogSportaUcenika.AllowUserToDeleteRows = false;
            this.dgvOcijenePojedinogSportaUcenika.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOcijenePojedinogSportaUcenika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOcijenePojedinogSportaUcenika.Location = new System.Drawing.Point(498, 396);
            this.dgvOcijenePojedinogSportaUcenika.Name = "dgvOcijenePojedinogSportaUcenika";
            this.dgvOcijenePojedinogSportaUcenika.ReadOnly = true;
            this.dgvOcijenePojedinogSportaUcenika.RowTemplate.Height = 24;
            this.dgvOcijenePojedinogSportaUcenika.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOcijenePojedinogSportaUcenika.Size = new System.Drawing.Size(357, 188);
            this.dgvOcijenePojedinogSportaUcenika.TabIndex = 34;
            // 
            // btnObrisiOcijenu
            // 
            this.btnObrisiOcijenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnObrisiOcijenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnObrisiOcijenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObrisiOcijenu.BorderRadius = 0;
            this.btnObrisiOcijenu.ButtonText = "Obrisi ocijenu";
            this.btnObrisiOcijenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObrisiOcijenu.DisabledColor = System.Drawing.Color.Gray;
            this.btnObrisiOcijenu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnObrisiOcijenu.Iconimage = null;
            this.btnObrisiOcijenu.Iconimage_right = null;
            this.btnObrisiOcijenu.Iconimage_right_Selected = null;
            this.btnObrisiOcijenu.Iconimage_Selected = null;
            this.btnObrisiOcijenu.IconMarginLeft = 0;
            this.btnObrisiOcijenu.IconMarginRight = 0;
            this.btnObrisiOcijenu.IconRightVisible = true;
            this.btnObrisiOcijenu.IconRightZoom = 0D;
            this.btnObrisiOcijenu.IconVisible = true;
            this.btnObrisiOcijenu.IconZoom = 90D;
            this.btnObrisiOcijenu.IsTab = true;
            this.btnObrisiOcijenu.Location = new System.Drawing.Point(498, 602);
            this.btnObrisiOcijenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObrisiOcijenu.Name = "btnObrisiOcijenu";
            this.btnObrisiOcijenu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnObrisiOcijenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnObrisiOcijenu.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnObrisiOcijenu.selected = true;
            this.btnObrisiOcijenu.Size = new System.Drawing.Size(357, 42);
            this.btnObrisiOcijenu.TabIndex = 35;
            this.btnObrisiOcijenu.Text = "Obrisi ocijenu";
            this.btnObrisiOcijenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnObrisiOcijenu.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnObrisiOcijenu.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiOcijenu.Click += new System.EventHandler(this.btnObrisiOcijenu_Click);
            // 
            // DodajSportUceniku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(900, 657);
            this.Controls.Add(this.btnObrisiOcijenu);
            this.Controls.Add(this.dgvOcijenePojedinogSportaUcenika);
            this.Controls.Add(this.btnAzurirajOcijenu);
            this.Controls.Add(this.btnDodajOcijenu);
            this.Controls.Add(this.cboOcijena);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateVjezbanja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvUcenik);
            this.Controls.Add(this.cboSport);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DodajSportUceniku";
            this.Text = "DodajSportUceniku";
            ((System.ComponentModel.ISupportInitialize)(this.sportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcenik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcijenePojedinogSportaUcenika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSport;
        private System.Windows.Forms.DataGridView dgvUcenik;
        private System.Windows.Forms.BindingSource sportBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iducenikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkorisnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn natjecanjeucenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportucenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vjezbaucenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ucenikBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateVjezbanja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.ComboBox cboOcijena;
        private Bunifu.Framework.UI.BunifuFlatButton btnDodajOcijenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnAzurirajOcijenu;
        private System.Windows.Forms.DataGridView dgvOcijenePojedinogSportaUcenika;
        private Bunifu.Framework.UI.BunifuFlatButton btnObrisiOcijenu;
    }
}