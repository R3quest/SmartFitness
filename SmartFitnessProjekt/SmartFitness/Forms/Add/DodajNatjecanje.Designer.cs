namespace SmartFitness.Forms.Add
{
    partial class DodajNatjecanje
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.txtMjesto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRazina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSport = new System.Windows.Forms.ComboBox();
            this.sportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvNatjecanja = new System.Windows.Forms.DataGridView();
            this.idsportaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.razinanatjecanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjestoodrzavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumvrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnatjecanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.natjecanjeucenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.natjecanjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateVjezbanja = new System.Windows.Forms.DateTimePicker();
            this.btnDodajNatjecanje = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAzurirajNatjecanje = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnObrisiNatjecanje = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNatjecanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.natjecanjeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(117, 106);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(260, 22);
            this.txtOpis.TabIndex = 4;
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRezultat.Location = new System.Drawing.Point(19, 109);
            this.lblRezultat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(37, 17);
            this.lblRezultat.TabIndex = 14;
            this.lblRezultat.Text = "Opis";
            // 
            // txtMjesto
            // 
            this.txtMjesto.Location = new System.Drawing.Point(117, 78);
            this.txtMjesto.Name = "txtMjesto";
            this.txtMjesto.Size = new System.Drawing.Size(260, 22);
            this.txtMjesto.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(19, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mjesto";
            // 
            // txtRazina
            // 
            this.txtRazina.Location = new System.Drawing.Point(117, 49);
            this.txtRazina.Name = "txtRazina";
            this.txtRazina.Size = new System.Drawing.Size(260, 22);
            this.txtRazina.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(19, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Razina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(19, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(19, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Sport";
            // 
            // cboSport
            // 
            this.cboSport.DataSource = this.sportBindingSource;
            this.cboSport.DisplayMember = "naziv";
            this.cboSport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSport.FormattingEnabled = true;
            this.cboSport.Location = new System.Drawing.Point(117, 19);
            this.cboSport.Name = "cboSport";
            this.cboSport.Size = new System.Drawing.Size(260, 24);
            this.cboSport.TabIndex = 1;
            this.cboSport.ValueMember = "id_sporta";
            // 
            // sportBindingSource
            // 
            this.sportBindingSource.DataSource = typeof(SmartFitness.Database.sport);
            // 
            // dgvNatjecanja
            // 
            this.dgvNatjecanja.AllowUserToAddRows = false;
            this.dgvNatjecanja.AllowUserToDeleteRows = false;
            this.dgvNatjecanja.AutoGenerateColumns = false;
            this.dgvNatjecanja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNatjecanja.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvNatjecanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNatjecanja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsportaDataGridViewTextBoxColumn,
            this.razinanatjecanjaDataGridViewTextBoxColumn,
            this.mjestoodrzavanjaDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.datumvrijemeDataGridViewTextBoxColumn,
            this.idnatjecanjaDataGridViewTextBoxColumn,
            this.sportDataGridViewTextBoxColumn,
            this.natjecanjeucenikDataGridViewTextBoxColumn});
            this.dgvNatjecanja.DataSource = this.natjecanjeBindingSource;
            this.dgvNatjecanja.Location = new System.Drawing.Point(400, 34);
            this.dgvNatjecanja.Name = "dgvNatjecanja";
            this.dgvNatjecanja.ReadOnly = true;
            this.dgvNatjecanja.RowHeadersWidth = 51;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNatjecanja.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNatjecanja.RowTemplate.Height = 24;
            this.dgvNatjecanja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNatjecanja.Size = new System.Drawing.Size(684, 404);
            this.dgvNatjecanja.TabIndex = 24;
            // 
            // idsportaDataGridViewTextBoxColumn
            // 
            this.idsportaDataGridViewTextBoxColumn.DataPropertyName = "id_sporta";
            this.idsportaDataGridViewTextBoxColumn.DataSource = this.sportBindingSource;
            this.idsportaDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.idsportaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idsportaDataGridViewTextBoxColumn.HeaderText = "Sport";
            this.idsportaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idsportaDataGridViewTextBoxColumn.Name = "idsportaDataGridViewTextBoxColumn";
            this.idsportaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsportaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idsportaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idsportaDataGridViewTextBoxColumn.ValueMember = "id_sporta";
            // 
            // razinanatjecanjaDataGridViewTextBoxColumn
            // 
            this.razinanatjecanjaDataGridViewTextBoxColumn.DataPropertyName = "razina_natjecanja";
            this.razinanatjecanjaDataGridViewTextBoxColumn.HeaderText = "Razina natjecanja";
            this.razinanatjecanjaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.razinanatjecanjaDataGridViewTextBoxColumn.Name = "razinanatjecanjaDataGridViewTextBoxColumn";
            this.razinanatjecanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mjestoodrzavanjaDataGridViewTextBoxColumn
            // 
            this.mjestoodrzavanjaDataGridViewTextBoxColumn.DataPropertyName = "mjesto_odrzavanja";
            this.mjestoodrzavanjaDataGridViewTextBoxColumn.HeaderText = "Mjesto odrzavanja";
            this.mjestoodrzavanjaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mjestoodrzavanjaDataGridViewTextBoxColumn.Name = "mjestoodrzavanjaDataGridViewTextBoxColumn";
            this.mjestoodrzavanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis natjecanja";
            this.opisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumvrijemeDataGridViewTextBoxColumn
            // 
            this.datumvrijemeDataGridViewTextBoxColumn.DataPropertyName = "datum_vrijeme";
            this.datumvrijemeDataGridViewTextBoxColumn.HeaderText = "Datum i vrijeme";
            this.datumvrijemeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumvrijemeDataGridViewTextBoxColumn.Name = "datumvrijemeDataGridViewTextBoxColumn";
            this.datumvrijemeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idnatjecanjaDataGridViewTextBoxColumn
            // 
            this.idnatjecanjaDataGridViewTextBoxColumn.DataPropertyName = "id_natjecanja";
            this.idnatjecanjaDataGridViewTextBoxColumn.HeaderText = "id_natjecanja";
            this.idnatjecanjaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idnatjecanjaDataGridViewTextBoxColumn.Name = "idnatjecanjaDataGridViewTextBoxColumn";
            this.idnatjecanjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idnatjecanjaDataGridViewTextBoxColumn.Visible = false;
            // 
            // sportDataGridViewTextBoxColumn
            // 
            this.sportDataGridViewTextBoxColumn.DataPropertyName = "sport";
            this.sportDataGridViewTextBoxColumn.HeaderText = "sport";
            this.sportDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sportDataGridViewTextBoxColumn.Name = "sportDataGridViewTextBoxColumn";
            this.sportDataGridViewTextBoxColumn.ReadOnly = true;
            this.sportDataGridViewTextBoxColumn.Visible = false;
            // 
            // natjecanjeucenikDataGridViewTextBoxColumn
            // 
            this.natjecanjeucenikDataGridViewTextBoxColumn.DataPropertyName = "natjecanje_ucenik";
            this.natjecanjeucenikDataGridViewTextBoxColumn.HeaderText = "natjecanje_ucenik";
            this.natjecanjeucenikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.natjecanjeucenikDataGridViewTextBoxColumn.Name = "natjecanjeucenikDataGridViewTextBoxColumn";
            this.natjecanjeucenikDataGridViewTextBoxColumn.ReadOnly = true;
            this.natjecanjeucenikDataGridViewTextBoxColumn.Visible = false;
            // 
            // natjecanjeBindingSource
            // 
            this.natjecanjeBindingSource.DataSource = typeof(SmartFitness.Database.natjecanje);
            // 
            // dateVjezbanja
            // 
            this.dateVjezbanja.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateVjezbanja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateVjezbanja.Location = new System.Drawing.Point(117, 133);
            this.dateVjezbanja.Margin = new System.Windows.Forms.Padding(2);
            this.dateVjezbanja.MinDate = new System.DateTime(2018, 6, 21, 0, 0, 0, 0);
            this.dateVjezbanja.Name = "dateVjezbanja";
            this.dateVjezbanja.Size = new System.Drawing.Size(260, 22);
            this.dateVjezbanja.TabIndex = 5;
            // 
            // btnDodajNatjecanje
            // 
            this.btnDodajNatjecanje.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDodajNatjecanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDodajNatjecanje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodajNatjecanje.BorderRadius = 0;
            this.btnDodajNatjecanje.ButtonText = "Dodaj natjecanje";
            this.btnDodajNatjecanje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodajNatjecanje.DisabledColor = System.Drawing.Color.Gray;
            this.btnDodajNatjecanje.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDodajNatjecanje.Iconimage = null;
            this.btnDodajNatjecanje.Iconimage_right = null;
            this.btnDodajNatjecanje.Iconimage_right_Selected = null;
            this.btnDodajNatjecanje.Iconimage_Selected = null;
            this.btnDodajNatjecanje.IconMarginLeft = 0;
            this.btnDodajNatjecanje.IconMarginRight = 0;
            this.btnDodajNatjecanje.IconRightVisible = true;
            this.btnDodajNatjecanje.IconRightZoom = 0D;
            this.btnDodajNatjecanje.IconVisible = true;
            this.btnDodajNatjecanje.IconZoom = 90D;
            this.btnDodajNatjecanje.IsTab = true;
            this.btnDodajNatjecanje.Location = new System.Drawing.Point(117, 172);
            this.btnDodajNatjecanje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajNatjecanje.Name = "btnDodajNatjecanje";
            this.btnDodajNatjecanje.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDodajNatjecanje.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDodajNatjecanje.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDodajNatjecanje.selected = true;
            this.btnDodajNatjecanje.Size = new System.Drawing.Size(260, 42);
            this.btnDodajNatjecanje.TabIndex = 25;
            this.btnDodajNatjecanje.Text = "Dodaj natjecanje";
            this.btnDodajNatjecanje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDodajNatjecanje.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnDodajNatjecanje.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNatjecanje.Click += new System.EventHandler(this.btnDodajNatjecanje_Click);
            // 
            // btnAzurirajNatjecanje
            // 
            this.btnAzurirajNatjecanje.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAzurirajNatjecanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAzurirajNatjecanje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAzurirajNatjecanje.BorderRadius = 0;
            this.btnAzurirajNatjecanje.ButtonText = "Azuriraj natjecanje";
            this.btnAzurirajNatjecanje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAzurirajNatjecanje.DisabledColor = System.Drawing.Color.Gray;
            this.btnAzurirajNatjecanje.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAzurirajNatjecanje.Iconimage = null;
            this.btnAzurirajNatjecanje.Iconimage_right = null;
            this.btnAzurirajNatjecanje.Iconimage_right_Selected = null;
            this.btnAzurirajNatjecanje.Iconimage_Selected = null;
            this.btnAzurirajNatjecanje.IconMarginLeft = 0;
            this.btnAzurirajNatjecanje.IconMarginRight = 0;
            this.btnAzurirajNatjecanje.IconRightVisible = true;
            this.btnAzurirajNatjecanje.IconRightZoom = 0D;
            this.btnAzurirajNatjecanje.IconVisible = true;
            this.btnAzurirajNatjecanje.IconZoom = 90D;
            this.btnAzurirajNatjecanje.IsTab = true;
            this.btnAzurirajNatjecanje.Location = new System.Drawing.Point(117, 222);
            this.btnAzurirajNatjecanje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAzurirajNatjecanje.Name = "btnAzurirajNatjecanje";
            this.btnAzurirajNatjecanje.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAzurirajNatjecanje.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAzurirajNatjecanje.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAzurirajNatjecanje.selected = true;
            this.btnAzurirajNatjecanje.Size = new System.Drawing.Size(260, 42);
            this.btnAzurirajNatjecanje.TabIndex = 26;
            this.btnAzurirajNatjecanje.Text = "Azuriraj natjecanje";
            this.btnAzurirajNatjecanje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAzurirajNatjecanje.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnAzurirajNatjecanje.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajNatjecanje.Click += new System.EventHandler(this.btnAzurirajNatjecanje_Click);
            // 
            // btnObrisiNatjecanje
            // 
            this.btnObrisiNatjecanje.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnObrisiNatjecanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnObrisiNatjecanje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObrisiNatjecanje.BorderRadius = 0;
            this.btnObrisiNatjecanje.ButtonText = "Obrisi natjecanje";
            this.btnObrisiNatjecanje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObrisiNatjecanje.DisabledColor = System.Drawing.Color.Gray;
            this.btnObrisiNatjecanje.Iconcolor = System.Drawing.Color.Transparent;
            this.btnObrisiNatjecanje.Iconimage = null;
            this.btnObrisiNatjecanje.Iconimage_right = null;
            this.btnObrisiNatjecanje.Iconimage_right_Selected = null;
            this.btnObrisiNatjecanje.Iconimage_Selected = null;
            this.btnObrisiNatjecanje.IconMarginLeft = 0;
            this.btnObrisiNatjecanje.IconMarginRight = 0;
            this.btnObrisiNatjecanje.IconRightVisible = true;
            this.btnObrisiNatjecanje.IconRightZoom = 0D;
            this.btnObrisiNatjecanje.IconVisible = true;
            this.btnObrisiNatjecanje.IconZoom = 90D;
            this.btnObrisiNatjecanje.IsTab = true;
            this.btnObrisiNatjecanje.Location = new System.Drawing.Point(117, 272);
            this.btnObrisiNatjecanje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObrisiNatjecanje.Name = "btnObrisiNatjecanje";
            this.btnObrisiNatjecanje.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnObrisiNatjecanje.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnObrisiNatjecanje.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnObrisiNatjecanje.selected = true;
            this.btnObrisiNatjecanje.Size = new System.Drawing.Size(260, 42);
            this.btnObrisiNatjecanje.TabIndex = 27;
            this.btnObrisiNatjecanje.Text = "Obrisi natjecanje";
            this.btnObrisiNatjecanje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnObrisiNatjecanje.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnObrisiNatjecanje.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiNatjecanje.Click += new System.EventHandler(this.btnObrisiNatjecanje_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(400, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Lista svih natjecanja";
            // 
            // DodajNatjecanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1096, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnObrisiNatjecanje);
            this.Controls.Add(this.btnAzurirajNatjecanje);
            this.Controls.Add(this.btnDodajNatjecanje);
            this.Controls.Add(this.dateVjezbanja);
            this.Controls.Add(this.dgvNatjecanja);
            this.Controls.Add(this.cboSport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRazina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMjesto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.lblRezultat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DodajNatjecanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DodajNatjecanje";
            ((System.ComponentModel.ISupportInitialize)(this.sportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNatjecanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.natjecanjeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.TextBox txtMjesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRazina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSport;
        private System.Windows.Forms.BindingSource sportBindingSource;
        private System.Windows.Forms.DataGridView dgvNatjecanja;
        private System.Windows.Forms.BindingSource natjecanjeBindingSource;
        private System.Windows.Forms.DateTimePicker dateVjezbanja;
        private Bunifu.Framework.UI.BunifuFlatButton btnDodajNatjecanje;
        private Bunifu.Framework.UI.BunifuFlatButton btnAzurirajNatjecanje;
        private Bunifu.Framework.UI.BunifuFlatButton btnObrisiNatjecanje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewComboBoxColumn idsportaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razinanatjecanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjestoodrzavanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumvrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnatjecanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn natjecanjeucenikDataGridViewTextBoxColumn;
    }
}