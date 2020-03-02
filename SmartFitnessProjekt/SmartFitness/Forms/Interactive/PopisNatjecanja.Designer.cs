namespace SmartFitness.Forms.Interactive
{
    partial class PopisNatjecanja
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
            this.label2 = new System.Windows.Forms.Label();
            this.cboSport = new System.Windows.Forms.ComboBox();
            this.sportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvSportUcenik = new System.Windows.Forms.DataGridView();
            this.dgvNatjecanja = new System.Windows.Forms.DataGridView();
            this.idsportaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.razinanatjecanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumvrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjestoodrzavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnatjecanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.natjecanjeucenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.natjecanjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtGodina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodajNaNatjecanje = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAzurirajUcenikaNaNatjecanju = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvStudentiKojiSeNatjecu = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSportUcenik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNatjecanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.natjecanjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentiKojiSeNatjecu)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(32, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sport";
            // 
            // cboSport
            // 
            this.cboSport.DataSource = this.sportBindingSource;
            this.cboSport.DisplayMember = "naziv";
            this.cboSport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSport.FormattingEnabled = true;
            this.cboSport.Location = new System.Drawing.Point(108, 25);
            this.cboSport.Name = "cboSport";
            this.cboSport.Size = new System.Drawing.Size(138, 24);
            this.cboSport.TabIndex = 2;
            this.cboSport.ValueMember = "id_sporta";
            this.cboSport.SelectedIndexChanged += new System.EventHandler(this.cboSport_SelectedIndexChanged);
            // 
            // sportBindingSource
            // 
            this.sportBindingSource.DataSource = typeof(SmartFitness.Database.sport);
            // 
            // dgvSportUcenik
            // 
            this.dgvSportUcenik.AllowUserToAddRows = false;
            this.dgvSportUcenik.AllowUserToDeleteRows = false;
            this.dgvSportUcenik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSportUcenik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSportUcenik.Location = new System.Drawing.Point(36, 97);
            this.dgvSportUcenik.Name = "dgvSportUcenik";
            this.dgvSportUcenik.ReadOnly = true;
            this.dgvSportUcenik.RowTemplate.Height = 24;
            this.dgvSportUcenik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSportUcenik.Size = new System.Drawing.Size(1114, 170);
            this.dgvSportUcenik.TabIndex = 3;
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
            this.datumvrijemeDataGridViewTextBoxColumn,
            this.mjestoodrzavanjaDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.idnatjecanjaDataGridViewTextBoxColumn,
            this.sportDataGridViewTextBoxColumn,
            this.natjecanjeucenikDataGridViewTextBoxColumn});
            this.dgvNatjecanja.DataSource = this.natjecanjeBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNatjecanja.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNatjecanja.Location = new System.Drawing.Point(36, 294);
            this.dgvNatjecanja.Name = "dgvNatjecanja";
            this.dgvNatjecanja.ReadOnly = true;
            this.dgvNatjecanja.RowTemplate.Height = 24;
            this.dgvNatjecanja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNatjecanja.Size = new System.Drawing.Size(1114, 217);
            this.dgvNatjecanja.TabIndex = 4;
            this.dgvNatjecanja.SelectionChanged += new System.EventHandler(this.dgvNatjecanja_SelectionChanged);
            // 
            // idsportaDataGridViewTextBoxColumn
            // 
            this.idsportaDataGridViewTextBoxColumn.DataPropertyName = "id_sporta";
            this.idsportaDataGridViewTextBoxColumn.DataSource = this.sportBindingSource;
            this.idsportaDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.idsportaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idsportaDataGridViewTextBoxColumn.HeaderText = "Sport";
            this.idsportaDataGridViewTextBoxColumn.Name = "idsportaDataGridViewTextBoxColumn";
            this.idsportaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsportaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idsportaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idsportaDataGridViewTextBoxColumn.ValueMember = "id_sporta";
            this.idsportaDataGridViewTextBoxColumn.Visible = false;
            // 
            // razinanatjecanjaDataGridViewTextBoxColumn
            // 
            this.razinanatjecanjaDataGridViewTextBoxColumn.DataPropertyName = "razina_natjecanja";
            this.razinanatjecanjaDataGridViewTextBoxColumn.HeaderText = "Razina natjecanja";
            this.razinanatjecanjaDataGridViewTextBoxColumn.Name = "razinanatjecanjaDataGridViewTextBoxColumn";
            this.razinanatjecanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumvrijemeDataGridViewTextBoxColumn
            // 
            this.datumvrijemeDataGridViewTextBoxColumn.DataPropertyName = "datum_vrijeme";
            this.datumvrijemeDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumvrijemeDataGridViewTextBoxColumn.Name = "datumvrijemeDataGridViewTextBoxColumn";
            this.datumvrijemeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mjestoodrzavanjaDataGridViewTextBoxColumn
            // 
            this.mjestoodrzavanjaDataGridViewTextBoxColumn.DataPropertyName = "mjesto_odrzavanja";
            this.mjestoodrzavanjaDataGridViewTextBoxColumn.HeaderText = "Mjesto";
            this.mjestoodrzavanjaDataGridViewTextBoxColumn.Name = "mjestoodrzavanjaDataGridViewTextBoxColumn";
            this.mjestoodrzavanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idnatjecanjaDataGridViewTextBoxColumn
            // 
            this.idnatjecanjaDataGridViewTextBoxColumn.DataPropertyName = "id_natjecanja";
            this.idnatjecanjaDataGridViewTextBoxColumn.HeaderText = "id_natjecanja";
            this.idnatjecanjaDataGridViewTextBoxColumn.Name = "idnatjecanjaDataGridViewTextBoxColumn";
            this.idnatjecanjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idnatjecanjaDataGridViewTextBoxColumn.Visible = false;
            // 
            // sportDataGridViewTextBoxColumn
            // 
            this.sportDataGridViewTextBoxColumn.DataPropertyName = "sport";
            this.sportDataGridViewTextBoxColumn.HeaderText = "sport";
            this.sportDataGridViewTextBoxColumn.Name = "sportDataGridViewTextBoxColumn";
            this.sportDataGridViewTextBoxColumn.ReadOnly = true;
            this.sportDataGridViewTextBoxColumn.Visible = false;
            // 
            // natjecanjeucenikDataGridViewTextBoxColumn
            // 
            this.natjecanjeucenikDataGridViewTextBoxColumn.DataPropertyName = "natjecanje_ucenik";
            this.natjecanjeucenikDataGridViewTextBoxColumn.HeaderText = "natjecanje_ucenik";
            this.natjecanjeucenikDataGridViewTextBoxColumn.Name = "natjecanjeucenikDataGridViewTextBoxColumn";
            this.natjecanjeucenikDataGridViewTextBoxColumn.ReadOnly = true;
            this.natjecanjeucenikDataGridViewTextBoxColumn.Visible = false;
            // 
            // natjecanjeBindingSource
            // 
            this.natjecanjeBindingSource.DataSource = typeof(SmartFitness.Database.natjecanje);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(274, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Godina";
            // 
            // txtGodina
            // 
            this.txtGodina.Enabled = false;
            this.txtGodina.Location = new System.Drawing.Point(338, 25);
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.Size = new System.Drawing.Size(207, 22);
            this.txtGodina.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(36, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Najbolji ucenici u odabranom sportu";
            // 
            // btnDodajNaNatjecanje
            // 
            this.btnDodajNaNatjecanje.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDodajNaNatjecanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDodajNaNatjecanje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodajNaNatjecanje.BorderRadius = 0;
            this.btnDodajNaNatjecanje.ButtonText = "Dodaj ucenika na natjecanje";
            this.btnDodajNaNatjecanje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodajNaNatjecanje.DisabledColor = System.Drawing.Color.Gray;
            this.btnDodajNaNatjecanje.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDodajNaNatjecanje.Iconimage = null;
            this.btnDodajNaNatjecanje.Iconimage_right = null;
            this.btnDodajNaNatjecanje.Iconimage_right_Selected = null;
            this.btnDodajNaNatjecanje.Iconimage_Selected = null;
            this.btnDodajNaNatjecanje.IconMarginLeft = 0;
            this.btnDodajNaNatjecanje.IconMarginRight = 0;
            this.btnDodajNaNatjecanje.IconRightVisible = true;
            this.btnDodajNaNatjecanje.IconRightZoom = 0D;
            this.btnDodajNaNatjecanje.IconVisible = true;
            this.btnDodajNaNatjecanje.IconZoom = 90D;
            this.btnDodajNaNatjecanje.IsTab = true;
            this.btnDodajNaNatjecanje.Location = new System.Drawing.Point(36, 536);
            this.btnDodajNaNatjecanje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajNaNatjecanje.Name = "btnDodajNaNatjecanje";
            this.btnDodajNaNatjecanje.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDodajNaNatjecanje.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDodajNaNatjecanje.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDodajNaNatjecanje.selected = true;
            this.btnDodajNaNatjecanje.Size = new System.Drawing.Size(416, 43);
            this.btnDodajNaNatjecanje.TabIndex = 29;
            this.btnDodajNaNatjecanje.Text = "Dodaj ucenika na natjecanje";
            this.btnDodajNaNatjecanje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDodajNaNatjecanje.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnDodajNaNatjecanje.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNaNatjecanje.Click += new System.EventHandler(this.btnDodajNaNatjecanje_Click);
            // 
            // btnAzurirajUcenikaNaNatjecanju
            // 
            this.btnAzurirajUcenikaNaNatjecanju.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAzurirajUcenikaNaNatjecanju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAzurirajUcenikaNaNatjecanju.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAzurirajUcenikaNaNatjecanju.BorderRadius = 0;
            this.btnAzurirajUcenikaNaNatjecanju.ButtonText = "Prikazi / obrisi natjecanja ucenika";
            this.btnAzurirajUcenikaNaNatjecanju.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAzurirajUcenikaNaNatjecanju.DisabledColor = System.Drawing.Color.Gray;
            this.btnAzurirajUcenikaNaNatjecanju.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAzurirajUcenikaNaNatjecanju.Iconimage = null;
            this.btnAzurirajUcenikaNaNatjecanju.Iconimage_right = null;
            this.btnAzurirajUcenikaNaNatjecanju.Iconimage_right_Selected = null;
            this.btnAzurirajUcenikaNaNatjecanju.Iconimage_Selected = null;
            this.btnAzurirajUcenikaNaNatjecanju.IconMarginLeft = 0;
            this.btnAzurirajUcenikaNaNatjecanju.IconMarginRight = 0;
            this.btnAzurirajUcenikaNaNatjecanju.IconRightVisible = true;
            this.btnAzurirajUcenikaNaNatjecanju.IconRightZoom = 0D;
            this.btnAzurirajUcenikaNaNatjecanju.IconVisible = true;
            this.btnAzurirajUcenikaNaNatjecanju.IconZoom = 90D;
            this.btnAzurirajUcenikaNaNatjecanju.IsTab = true;
            this.btnAzurirajUcenikaNaNatjecanju.Location = new System.Drawing.Point(39, 587);
            this.btnAzurirajUcenikaNaNatjecanju.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAzurirajUcenikaNaNatjecanju.Name = "btnAzurirajUcenikaNaNatjecanju";
            this.btnAzurirajUcenikaNaNatjecanju.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAzurirajUcenikaNaNatjecanju.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAzurirajUcenikaNaNatjecanju.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAzurirajUcenikaNaNatjecanju.selected = true;
            this.btnAzurirajUcenikaNaNatjecanju.Size = new System.Drawing.Size(413, 43);
            this.btnAzurirajUcenikaNaNatjecanju.TabIndex = 30;
            this.btnAzurirajUcenikaNaNatjecanju.Text = "Prikazi / obrisi natjecanja ucenika";
            this.btnAzurirajUcenikaNaNatjecanju.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAzurirajUcenikaNaNatjecanju.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnAzurirajUcenikaNaNatjecanju.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajUcenikaNaNatjecanju.Click += new System.EventHandler(this.btnAzurirajUcenikaNaNatjecanju_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(496, 528);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "Učenici koji se natjecu na odabranom natjecanju";
            // 
            // dgvStudentiKojiSeNatjecu
            // 
            this.dgvStudentiKojiSeNatjecu.AllowUserToAddRows = false;
            this.dgvStudentiKojiSeNatjecu.AllowUserToDeleteRows = false;
            this.dgvStudentiKojiSeNatjecu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentiKojiSeNatjecu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentiKojiSeNatjecu.Location = new System.Drawing.Point(499, 551);
            this.dgvStudentiKojiSeNatjecu.Name = "dgvStudentiKojiSeNatjecu";
            this.dgvStudentiKojiSeNatjecu.ReadOnly = true;
            this.dgvStudentiKojiSeNatjecu.RowTemplate.Height = 24;
            this.dgvStudentiKojiSeNatjecu.Size = new System.Drawing.Size(651, 265);
            this.dgvStudentiKojiSeNatjecu.TabIndex = 33;
            this.dgvStudentiKojiSeNatjecu.SelectionChanged += new System.EventHandler(this.dgvStudentiKojiSeNatjecu_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(39, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Natjecanja odabranog sporta";
            // 
            // Natjecanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1211, 826);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvStudentiKojiSeNatjecu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAzurirajUcenikaNaNatjecanju);
            this.Controls.Add(this.btnDodajNaNatjecanje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGodina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNatjecanja);
            this.Controls.Add(this.dgvSportUcenik);
            this.Controls.Add(this.cboSport);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Natjecanja";
            this.Text = "Natjecanja";
            ((System.ComponentModel.ISupportInitialize)(this.sportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSportUcenik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNatjecanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.natjecanjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentiKojiSeNatjecu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSport;
        private System.Windows.Forms.DataGridView dgvSportUcenik;
        private System.Windows.Forms.BindingSource sportBindingSource;
        private System.Windows.Forms.DataGridView dgvNatjecanja;
        private System.Windows.Forms.BindingSource natjecanjeBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGodina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewComboBoxColumn idsportaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razinanatjecanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumvrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjestoodrzavanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnatjecanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn natjecanjeucenikDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuFlatButton btnDodajNaNatjecanje;
        private Bunifu.Framework.UI.BunifuFlatButton btnAzurirajUcenikaNaNatjecanju;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvStudentiKojiSeNatjecu;
        private System.Windows.Forms.Label label5;
    }
}