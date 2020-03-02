namespace SmartFitness.Forms.Update
{
    partial class AzurirajRezultatVjezbe
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
            this.cboVjezbe = new System.Windows.Forms.ComboBox();
            this.vjezbaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dgvVjezbeUcenika = new System.Windows.Forms.DataGridView();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ostvarenoponavljanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucenikiducenikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vjezbaidvjezbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvjezbaucenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vjezbaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vjezbaucenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPonavljanja = new System.Windows.Forms.TextBox();
            this.dateVjezbanja = new System.Windows.Forms.DateTimePicker();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAzuriraj = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnObrisi = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.vjezbaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVjezbeUcenika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vjezbaucenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboVjezbe
            // 
            this.cboVjezbe.DataSource = this.vjezbaBindingSource;
            this.cboVjezbe.DisplayMember = "naziv";
            this.cboVjezbe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVjezbe.FormattingEnabled = true;
            this.cboVjezbe.Location = new System.Drawing.Point(91, 17);
            this.cboVjezbe.Name = "cboVjezbe";
            this.cboVjezbe.Size = new System.Drawing.Size(121, 24);
            this.cboVjezbe.TabIndex = 3;
            this.cboVjezbe.ValueMember = "id_vjezbe";
            this.cboVjezbe.SelectedIndexChanged += new System.EventHandler(this.cboVjezbe_SelectedIndexChanged);
            // 
            // vjezbaBindingSource
            // 
            this.vjezbaBindingSource.DataSource = typeof(SmartFitness.Database.vjezba);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(21, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vjezba";
            // 
            // dgvVjezbeUcenika
            // 
            this.dgvVjezbeUcenika.AllowUserToAddRows = false;
            this.dgvVjezbeUcenika.AllowUserToDeleteRows = false;
            this.dgvVjezbeUcenika.AutoGenerateColumns = false;
            this.dgvVjezbeUcenika.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVjezbeUcenika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVjezbeUcenika.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datumDataGridViewTextBoxColumn,
            this.ostvarenoponavljanjaDataGridViewTextBoxColumn,
            this.ucenikiducenikaDataGridViewTextBoxColumn,
            this.vjezbaidvjezbeDataGridViewTextBoxColumn,
            this.idvjezbaucenikDataGridViewTextBoxColumn,
            this.ucenikDataGridViewTextBoxColumn,
            this.vjezbaDataGridViewTextBoxColumn});
            this.dgvVjezbeUcenika.DataSource = this.vjezbaucenikBindingSource;
            this.dgvVjezbeUcenika.Location = new System.Drawing.Point(24, 64);
            this.dgvVjezbeUcenika.Name = "dgvVjezbeUcenika";
            this.dgvVjezbeUcenika.ReadOnly = true;
            this.dgvVjezbeUcenika.RowHeadersWidth = 51;
            this.dgvVjezbeUcenika.RowTemplate.Height = 24;
            this.dgvVjezbeUcenika.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVjezbeUcenika.Size = new System.Drawing.Size(372, 389);
            this.dgvVjezbeUcenika.TabIndex = 5;
            this.dgvVjezbeUcenika.SelectionChanged += new System.EventHandler(this.dgvVjezbeUcenika_SelectionChanged);
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ostvarenoponavljanjaDataGridViewTextBoxColumn
            // 
            this.ostvarenoponavljanjaDataGridViewTextBoxColumn.DataPropertyName = "ostvareno_ponavljanja";
            this.ostvarenoponavljanjaDataGridViewTextBoxColumn.HeaderText = "ostvareno_ponavljanja";
            this.ostvarenoponavljanjaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ostvarenoponavljanjaDataGridViewTextBoxColumn.Name = "ostvarenoponavljanjaDataGridViewTextBoxColumn";
            this.ostvarenoponavljanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ucenikiducenikaDataGridViewTextBoxColumn
            // 
            this.ucenikiducenikaDataGridViewTextBoxColumn.DataPropertyName = "ucenik_id_ucenika";
            this.ucenikiducenikaDataGridViewTextBoxColumn.HeaderText = "ucenik_id_ucenika";
            this.ucenikiducenikaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ucenikiducenikaDataGridViewTextBoxColumn.Name = "ucenikiducenikaDataGridViewTextBoxColumn";
            this.ucenikiducenikaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ucenikiducenikaDataGridViewTextBoxColumn.Visible = false;
            // 
            // vjezbaidvjezbeDataGridViewTextBoxColumn
            // 
            this.vjezbaidvjezbeDataGridViewTextBoxColumn.DataPropertyName = "vjezba_id_vjezbe";
            this.vjezbaidvjezbeDataGridViewTextBoxColumn.HeaderText = "vjezba_id_vjezbe";
            this.vjezbaidvjezbeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vjezbaidvjezbeDataGridViewTextBoxColumn.Name = "vjezbaidvjezbeDataGridViewTextBoxColumn";
            this.vjezbaidvjezbeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vjezbaidvjezbeDataGridViewTextBoxColumn.Visible = false;
            // 
            // idvjezbaucenikDataGridViewTextBoxColumn
            // 
            this.idvjezbaucenikDataGridViewTextBoxColumn.DataPropertyName = "id_vjezba_ucenik";
            this.idvjezbaucenikDataGridViewTextBoxColumn.HeaderText = "id_vjezba_ucenik";
            this.idvjezbaucenikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idvjezbaucenikDataGridViewTextBoxColumn.Name = "idvjezbaucenikDataGridViewTextBoxColumn";
            this.idvjezbaucenikDataGridViewTextBoxColumn.ReadOnly = true;
            this.idvjezbaucenikDataGridViewTextBoxColumn.Visible = false;
            // 
            // ucenikDataGridViewTextBoxColumn
            // 
            this.ucenikDataGridViewTextBoxColumn.DataPropertyName = "ucenik";
            this.ucenikDataGridViewTextBoxColumn.HeaderText = "ucenik";
            this.ucenikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ucenikDataGridViewTextBoxColumn.Name = "ucenikDataGridViewTextBoxColumn";
            this.ucenikDataGridViewTextBoxColumn.ReadOnly = true;
            this.ucenikDataGridViewTextBoxColumn.Visible = false;
            // 
            // vjezbaDataGridViewTextBoxColumn
            // 
            this.vjezbaDataGridViewTextBoxColumn.DataPropertyName = "vjezba";
            this.vjezbaDataGridViewTextBoxColumn.HeaderText = "vjezba";
            this.vjezbaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vjezbaDataGridViewTextBoxColumn.Name = "vjezbaDataGridViewTextBoxColumn";
            this.vjezbaDataGridViewTextBoxColumn.ReadOnly = true;
            this.vjezbaDataGridViewTextBoxColumn.Visible = false;
            // 
            // vjezbaucenikBindingSource
            // 
            this.vjezbaucenikBindingSource.DataSource = typeof(SmartFitness.Database.vjezba_ucenik);
            // 
            // txtPonavljanja
            // 
            this.txtPonavljanja.Location = new System.Drawing.Point(513, 102);
            this.txtPonavljanja.Name = "txtPonavljanja";
            this.txtPonavljanja.Size = new System.Drawing.Size(260, 22);
            this.txtPonavljanja.TabIndex = 15;
            // 
            // dateVjezbanja
            // 
            this.dateVjezbanja.CustomFormat = "yyyy-MM-dd";
            this.dateVjezbanja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateVjezbanja.Location = new System.Drawing.Point(513, 64);
            this.dateVjezbanja.Margin = new System.Windows.Forms.Padding(2);
            this.dateVjezbanja.MinDate = new System.DateTime(2018, 6, 21, 0, 0, 0, 0);
            this.dateVjezbanja.Name = "dateVjezbanja";
            this.dateVjezbanja.Size = new System.Drawing.Size(260, 22);
            this.dateVjezbanja.TabIndex = 12;
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRezultat.Location = new System.Drawing.Point(413, 105);
            this.lblRezultat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(81, 17);
            this.lblRezultat.TabIndex = 14;
            this.lblRezultat.Text = "Ponavljanja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(413, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Datum";
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAzuriraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAzuriraj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAzuriraj.BorderRadius = 0;
            this.btnAzuriraj.ButtonText = "Azuriraj trening";
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
            this.btnAzuriraj.Location = new System.Drawing.Point(416, 140);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAzuriraj.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAzuriraj.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAzuriraj.selected = true;
            this.btnAzuriraj.Size = new System.Drawing.Size(357, 40);
            this.btnAzuriraj.TabIndex = 17;
            this.btnAzuriraj.Text = "Azuriraj trening";
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
            this.btnObrisi.ButtonText = "Obrisi trening";
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
            this.btnObrisi.Location = new System.Drawing.Point(416, 186);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnObrisi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnObrisi.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnObrisi.selected = true;
            this.btnObrisi.Size = new System.Drawing.Size(357, 40);
            this.btnObrisi.TabIndex = 18;
            this.btnObrisi.Text = "Obrisi trening";
            this.btnObrisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnObrisi.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnObrisi.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // AzurirajRezultatVjezbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(794, 476);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.txtPonavljanja);
            this.Controls.Add(this.dateVjezbanja);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvVjezbeUcenika);
            this.Controls.Add(this.cboVjezbe);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AzurirajRezultatVjezbe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AzurirajRezultatVjezbe";
            ((System.ComponentModel.ISupportInitialize)(this.vjezbaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVjezbeUcenika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vjezbaucenikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboVjezbe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvVjezbeUcenika;
        private System.Windows.Forms.BindingSource vjezbaBindingSource;
        private System.Windows.Forms.BindingSource vjezbaucenikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ostvarenoponavljanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucenikiducenikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vjezbaidvjezbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvjezbaucenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vjezbaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtPonavljanja;
        private System.Windows.Forms.DateTimePicker dateVjezbanja;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton btnAzuriraj;
        private Bunifu.Framework.UI.BunifuFlatButton btnObrisi;
    }
}