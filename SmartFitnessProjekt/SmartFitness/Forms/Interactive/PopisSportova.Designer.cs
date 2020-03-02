namespace SmartFitness.Forms.Interactive
{
    partial class PopisSportova
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
            this.dgvSportovi = new System.Windows.Forms.DataGridView();
            this.idsportaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.natjecanjesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportucenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPopis = new System.Windows.Forms.Label();
            this.txtDisciplina = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.btnDodaj = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAzuriraj = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnObrisi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNatrag = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSportovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSportovi
            // 
            this.dgvSportovi.AutoGenerateColumns = false;
            this.dgvSportovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSportovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSportovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsportaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.disciplinaDataGridViewTextBoxColumn,
            this.natjecanjesDataGridViewTextBoxColumn,
            this.sportucenikDataGridViewTextBoxColumn});
            this.dgvSportovi.DataSource = this.sportBindingSource;
            this.dgvSportovi.Location = new System.Drawing.Point(13, 29);
            this.dgvSportovi.Name = "dgvSportovi";
            this.dgvSportovi.RowTemplate.Height = 24;
            this.dgvSportovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSportovi.Size = new System.Drawing.Size(374, 506);
            this.dgvSportovi.TabIndex = 0;
            // 
            // idsportaDataGridViewTextBoxColumn
            // 
            this.idsportaDataGridViewTextBoxColumn.DataPropertyName = "id_sporta";
            this.idsportaDataGridViewTextBoxColumn.HeaderText = "id_sporta";
            this.idsportaDataGridViewTextBoxColumn.Name = "idsportaDataGridViewTextBoxColumn";
            this.idsportaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // disciplinaDataGridViewTextBoxColumn
            // 
            this.disciplinaDataGridViewTextBoxColumn.DataPropertyName = "disciplina";
            this.disciplinaDataGridViewTextBoxColumn.HeaderText = "disciplina";
            this.disciplinaDataGridViewTextBoxColumn.Name = "disciplinaDataGridViewTextBoxColumn";
            // 
            // natjecanjesDataGridViewTextBoxColumn
            // 
            this.natjecanjesDataGridViewTextBoxColumn.DataPropertyName = "natjecanjes";
            this.natjecanjesDataGridViewTextBoxColumn.HeaderText = "natjecanjes";
            this.natjecanjesDataGridViewTextBoxColumn.Name = "natjecanjesDataGridViewTextBoxColumn";
            this.natjecanjesDataGridViewTextBoxColumn.Visible = false;
            // 
            // sportucenikDataGridViewTextBoxColumn
            // 
            this.sportucenikDataGridViewTextBoxColumn.DataPropertyName = "sport_ucenik";
            this.sportucenikDataGridViewTextBoxColumn.HeaderText = "sport_ucenik";
            this.sportucenikDataGridViewTextBoxColumn.Name = "sportucenikDataGridViewTextBoxColumn";
            this.sportucenikDataGridViewTextBoxColumn.Visible = false;
            // 
            // sportBindingSource
            // 
            this.sportBindingSource.DataSource = typeof(SmartFitness.Database.sport);
            // 
            // lblPopis
            // 
            this.lblPopis.AutoSize = true;
            this.lblPopis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPopis.Location = new System.Drawing.Point(10, 9);
            this.lblPopis.Name = "lblPopis";
            this.lblPopis.Size = new System.Drawing.Size(106, 17);
            this.lblPopis.TabIndex = 2;
            this.lblPopis.Text = "Popis sportova:";
            // 
            // txtDisciplina
            // 
            this.txtDisciplina.Location = new System.Drawing.Point(489, 57);
            this.txtDisciplina.Name = "txtDisciplina";
            this.txtDisciplina.Size = new System.Drawing.Size(161, 22);
            this.txtDisciplina.TabIndex = 11;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrezime.Location = new System.Drawing.Point(398, 62);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(68, 17);
            this.lblPrezime.TabIndex = 10;
            this.lblPrezime.Text = "Disciplina";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(489, 29);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(161, 22);
            this.txtNaziv.TabIndex = 9;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNaziv.Location = new System.Drawing.Point(398, 34);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(43, 17);
            this.lblNaziv.TabIndex = 8;
            this.lblNaziv.Text = "Naziv";
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
            this.btnDodaj.Location = new System.Drawing.Point(427, 100);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDodaj.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDodaj.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDodaj.selected = true;
            this.btnDodaj.Size = new System.Drawing.Size(223, 43);
            this.btnDodaj.TabIndex = 30;
            this.btnDodaj.Text = "Dodaj";
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
            this.btnAzuriraj.Location = new System.Drawing.Point(427, 151);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAzuriraj.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAzuriraj.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAzuriraj.selected = true;
            this.btnAzuriraj.Size = new System.Drawing.Size(223, 43);
            this.btnAzuriraj.TabIndex = 31;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAzuriraj.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnAzuriraj.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
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
            this.btnObrisi.Location = new System.Drawing.Point(427, 202);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnObrisi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnObrisi.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnObrisi.selected = true;
            this.btnObrisi.Size = new System.Drawing.Size(223, 43);
            this.btnObrisi.TabIndex = 32;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnObrisi.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnObrisi.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
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
            this.btnNatrag.Location = new System.Drawing.Point(427, 491);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnNatrag.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnNatrag.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnNatrag.selected = true;
            this.btnNatrag.Size = new System.Drawing.Size(223, 43);
            this.btnNatrag.TabIndex = 33;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNatrag.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnNatrag.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // PopisSportova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(664, 547);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtDisciplina);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblPopis);
            this.Controls.Add(this.dgvSportovi);
            this.Name = "PopisSportova";
            this.Text = "Popis sportova";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSportovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSportovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsportaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn natjecanjesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportucenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sportBindingSource;
        private System.Windows.Forms.Label lblPopis;
        private System.Windows.Forms.TextBox txtDisciplina;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private Bunifu.Framework.UI.BunifuFlatButton btnDodaj;
        private Bunifu.Framework.UI.BunifuFlatButton btnAzuriraj;
        private Bunifu.Framework.UI.BunifuFlatButton btnObrisi;
        private Bunifu.Framework.UI.BunifuFlatButton btnNatrag;
    }
}