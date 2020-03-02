namespace SmartFitness.Forms.Interactive
{
    partial class PopisUcenika
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
            this.dgvUcenici = new System.Windows.Forms.DataGridView();
            this.iducenikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkorisnikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.natjecanjeucenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportucenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vjezbaucenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPopis = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtRazred = new System.Windows.Forms.TextBox();
            this.lblRazred = new System.Windows.Forms.Label();
            this.btnNatrag = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnObrisi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAzuriraj = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDodaj = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUcenici
            // 
            this.dgvUcenici.AutoGenerateColumns = false;
            this.dgvUcenici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUcenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUcenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iducenikaDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.razredDataGridViewTextBoxColumn,
            this.idkorisnikaDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.natjecanjeucenikDataGridViewTextBoxColumn,
            this.sportucenikDataGridViewTextBoxColumn,
            this.vjezbaucenikDataGridViewTextBoxColumn});
            this.dgvUcenici.DataSource = this.ucenikBindingSource;
            this.dgvUcenici.Location = new System.Drawing.Point(13, 31);
            this.dgvUcenici.Name = "dgvUcenici";
            this.dgvUcenici.RowTemplate.Height = 24;
            this.dgvUcenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUcenici.Size = new System.Drawing.Size(426, 512);
            this.dgvUcenici.TabIndex = 0;
            // 
            // iducenikaDataGridViewTextBoxColumn
            // 
            this.iducenikaDataGridViewTextBoxColumn.DataPropertyName = "id_ucenika";
            this.iducenikaDataGridViewTextBoxColumn.HeaderText = "id_ucenika";
            this.iducenikaDataGridViewTextBoxColumn.Name = "iducenikaDataGridViewTextBoxColumn";
            this.iducenikaDataGridViewTextBoxColumn.Visible = false;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // razredDataGridViewTextBoxColumn
            // 
            this.razredDataGridViewTextBoxColumn.DataPropertyName = "razred";
            this.razredDataGridViewTextBoxColumn.HeaderText = "razred";
            this.razredDataGridViewTextBoxColumn.Name = "razredDataGridViewTextBoxColumn";
            // 
            // idkorisnikaDataGridViewTextBoxColumn
            // 
            this.idkorisnikaDataGridViewTextBoxColumn.DataPropertyName = "id_korisnika";
            this.idkorisnikaDataGridViewTextBoxColumn.HeaderText = "id_korisnika";
            this.idkorisnikaDataGridViewTextBoxColumn.Name = "idkorisnikaDataGridViewTextBoxColumn";
            this.idkorisnikaDataGridViewTextBoxColumn.Visible = false;
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // natjecanjeucenikDataGridViewTextBoxColumn
            // 
            this.natjecanjeucenikDataGridViewTextBoxColumn.DataPropertyName = "natjecanje_ucenik";
            this.natjecanjeucenikDataGridViewTextBoxColumn.HeaderText = "natjecanje_ucenik";
            this.natjecanjeucenikDataGridViewTextBoxColumn.Name = "natjecanjeucenikDataGridViewTextBoxColumn";
            this.natjecanjeucenikDataGridViewTextBoxColumn.Visible = false;
            // 
            // sportucenikDataGridViewTextBoxColumn
            // 
            this.sportucenikDataGridViewTextBoxColumn.DataPropertyName = "sport_ucenik";
            this.sportucenikDataGridViewTextBoxColumn.HeaderText = "sport_ucenik";
            this.sportucenikDataGridViewTextBoxColumn.Name = "sportucenikDataGridViewTextBoxColumn";
            this.sportucenikDataGridViewTextBoxColumn.Visible = false;
            // 
            // vjezbaucenikDataGridViewTextBoxColumn
            // 
            this.vjezbaucenikDataGridViewTextBoxColumn.DataPropertyName = "vjezba_ucenik";
            this.vjezbaucenikDataGridViewTextBoxColumn.HeaderText = "vjezba_ucenik";
            this.vjezbaucenikDataGridViewTextBoxColumn.Name = "vjezbaucenikDataGridViewTextBoxColumn";
            this.vjezbaucenikDataGridViewTextBoxColumn.Visible = false;
            // 
            // ucenikBindingSource
            // 
            this.ucenikBindingSource.DataSource = typeof(SmartFitness.Database.ucenik);
            // 
            // lblPopis
            // 
            this.lblPopis.AutoSize = true;
            this.lblPopis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPopis.Location = new System.Drawing.Point(13, 8);
            this.lblPopis.Name = "lblPopis";
            this.lblPopis.Size = new System.Drawing.Size(100, 17);
            this.lblPopis.TabIndex = 1;
            this.lblPopis.Text = "Popis učenika:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIme.Location = new System.Drawing.Point(445, 36);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(30, 17);
            this.lblIme.TabIndex = 4;
            this.lblIme.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(507, 31);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(161, 22);
            this.txtIme.TabIndex = 5;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(507, 59);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(161, 22);
            this.txtPrezime.TabIndex = 7;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrezime.Location = new System.Drawing.Point(445, 64);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(59, 17);
            this.lblPrezime.TabIndex = 6;
            this.lblPrezime.Text = "Prezime";
            // 
            // txtRazred
            // 
            this.txtRazred.Location = new System.Drawing.Point(507, 87);
            this.txtRazred.Name = "txtRazred";
            this.txtRazred.Size = new System.Drawing.Size(161, 22);
            this.txtRazred.TabIndex = 9;
            // 
            // lblRazred
            // 
            this.lblRazred.AutoSize = true;
            this.lblRazred.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRazred.Location = new System.Drawing.Point(445, 92);
            this.lblRazred.Name = "lblRazred";
            this.lblRazred.Size = new System.Drawing.Size(54, 17);
            this.lblRazred.TabIndex = 8;
            this.lblRazred.Text = "Razred";
            // 
            // btnNatrag
            // 
            this.btnNatrag.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnNatrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnNatrag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNatrag.BorderRadius = 0;
            this.btnNatrag.ButtonText = "Natrag";
            this.btnNatrag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNatrag.DisabledColor = System.Drawing.Color.Gray;
            this.btnNatrag.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNatrag.Iconimage = null;
            this.btnNatrag.Iconimage_right = null;
            this.btnNatrag.Iconimage_right_Selected = null;
            this.btnNatrag.Iconimage_Selected = null;
            this.btnNatrag.IconMarginLeft = 0;
            this.btnNatrag.IconMarginRight = 0;
            this.btnNatrag.IconRightVisible = true;
            this.btnNatrag.IconRightZoom = 0D;
            this.btnNatrag.IconVisible = true;
            this.btnNatrag.IconZoom = 90D;
            this.btnNatrag.IsTab = true;
            this.btnNatrag.Location = new System.Drawing.Point(448, 500);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnNatrag.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnNatrag.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnNatrag.selected = true;
            this.btnNatrag.Size = new System.Drawing.Size(220, 43);
            this.btnNatrag.TabIndex = 37;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNatrag.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnNatrag.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnObrisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObrisi.BorderRadius = 0;
            this.btnObrisi.ButtonText = "Obrisi";
            this.btnObrisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObrisi.DisabledColor = System.Drawing.Color.Gray;
            this.btnObrisi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnObrisi.Iconimage = null;
            this.btnObrisi.Iconimage_right = null;
            this.btnObrisi.Iconimage_right_Selected = null;
            this.btnObrisi.Iconimage_Selected = null;
            this.btnObrisi.IconMarginLeft = 0;
            this.btnObrisi.IconMarginRight = 0;
            this.btnObrisi.IconRightVisible = true;
            this.btnObrisi.IconRightZoom = 0D;
            this.btnObrisi.IconVisible = true;
            this.btnObrisi.IconZoom = 90D;
            this.btnObrisi.IsTab = true;
            this.btnObrisi.Location = new System.Drawing.Point(448, 238);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnObrisi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnObrisi.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnObrisi.selected = true;
            this.btnObrisi.Size = new System.Drawing.Size(220, 43);
            this.btnObrisi.TabIndex = 36;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnObrisi.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnObrisi.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAzuriraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAzuriraj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAzuriraj.BorderRadius = 0;
            this.btnAzuriraj.ButtonText = "Azuriraj";
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
            this.btnAzuriraj.Location = new System.Drawing.Point(448, 187);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAzuriraj.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAzuriraj.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAzuriraj.selected = true;
            this.btnAzuriraj.Size = new System.Drawing.Size(220, 43);
            this.btnAzuriraj.TabIndex = 35;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAzuriraj.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnAzuriraj.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzurirajObrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodaj.BorderRadius = 0;
            this.btnDodaj.ButtonText = "Dodaj";
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
            this.btnDodaj.Location = new System.Drawing.Point(448, 136);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDodaj.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDodaj.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDodaj.selected = true;
            this.btnDodaj.Size = new System.Drawing.Size(220, 43);
            this.btnDodaj.TabIndex = 34;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDodaj.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnDodaj.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // PopisUcenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(680, 555);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtRazred);
            this.Controls.Add(this.lblRazred);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblPopis);
            this.Controls.Add(this.dgvUcenici);
            this.Name = "PopisUcenika";
            this.Text = "Učenici";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucenikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUcenici;
        private System.Windows.Forms.Label lblPopis;
        private System.Windows.Forms.BindingSource ucenikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iducenikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkorisnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn natjecanjeucenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportucenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vjezbaucenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtRazred;
        private System.Windows.Forms.Label lblRazred;
        private Bunifu.Framework.UI.BunifuFlatButton btnNatrag;
        private Bunifu.Framework.UI.BunifuFlatButton btnObrisi;
        private Bunifu.Framework.UI.BunifuFlatButton btnAzuriraj;
        private Bunifu.Framework.UI.BunifuFlatButton btnDodaj;
    }
}