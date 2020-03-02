namespace SmartFitness.Forms.Interactive
{
    partial class PopisVjezbi
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtVrijeme = new System.Windows.Forms.TextBox();
            this.txtPonavljanje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvVjezbe = new System.Windows.Forms.DataGridView();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvjezbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemevjezbanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ponavljanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vjezbaucenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vjezbaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBrisi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAzuriraj = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUnos = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVjezbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vjezbaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(861, 58);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(245, 22);
            this.txtNaziv.TabIndex = 3;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(861, 99);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(245, 72);
            this.txtOpis.TabIndex = 4;
            // 
            // txtVrijeme
            // 
            this.txtVrijeme.Location = new System.Drawing.Point(861, 177);
            this.txtVrijeme.Name = "txtVrijeme";
            this.txtVrijeme.Size = new System.Drawing.Size(245, 22);
            this.txtVrijeme.TabIndex = 5;
            // 
            // txtPonavljanje
            // 
            this.txtPonavljanje.Location = new System.Drawing.Point(861, 205);
            this.txtPonavljanje.Name = "txtPonavljanje";
            this.txtPonavljanje.Size = new System.Drawing.Size(245, 22);
            this.txtPonavljanje.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(719, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(719, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Opis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(719, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Vrijeme vjezbanja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(719, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ponavljanja";
            // 
            // dgvVjezbe
            // 
            this.dgvVjezbe.AllowUserToAddRows = false;
            this.dgvVjezbe.AllowUserToDeleteRows = false;
            this.dgvVjezbe.AutoGenerateColumns = false;
            this.dgvVjezbe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVjezbe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVjezbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVjezbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivDataGridViewTextBoxColumn,
            this.idvjezbeDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.vrijemevjezbanjaDataGridViewTextBoxColumn,
            this.ponavljanjaDataGridViewTextBoxColumn,
            this.vjezbaucenikDataGridViewTextBoxColumn});
            this.dgvVjezbe.DataSource = this.vjezbaBindingSource;
            this.dgvVjezbe.Location = new System.Drawing.Point(26, 58);
            this.dgvVjezbe.Name = "dgvVjezbe";
            this.dgvVjezbe.ReadOnly = true;
            this.dgvVjezbe.RowHeadersWidth = 51;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVjezbe.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVjezbe.RowTemplate.Height = 24;
            this.dgvVjezbe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVjezbe.Size = new System.Drawing.Size(669, 432);
            this.dgvVjezbe.TabIndex = 11;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idvjezbeDataGridViewTextBoxColumn
            // 
            this.idvjezbeDataGridViewTextBoxColumn.DataPropertyName = "id_vjezbe";
            this.idvjezbeDataGridViewTextBoxColumn.HeaderText = "id_vjezbe";
            this.idvjezbeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idvjezbeDataGridViewTextBoxColumn.Name = "idvjezbeDataGridViewTextBoxColumn";
            this.idvjezbeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idvjezbeDataGridViewTextBoxColumn.Visible = false;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "opis";
            this.opisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrijemevjezbanjaDataGridViewTextBoxColumn
            // 
            this.vrijemevjezbanjaDataGridViewTextBoxColumn.DataPropertyName = "vrijeme_vjezbanja";
            this.vrijemevjezbanjaDataGridViewTextBoxColumn.HeaderText = "vrijeme_vjezbanja";
            this.vrijemevjezbanjaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vrijemevjezbanjaDataGridViewTextBoxColumn.Name = "vrijemevjezbanjaDataGridViewTextBoxColumn";
            this.vrijemevjezbanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ponavljanjaDataGridViewTextBoxColumn
            // 
            this.ponavljanjaDataGridViewTextBoxColumn.DataPropertyName = "ponavljanja";
            this.ponavljanjaDataGridViewTextBoxColumn.HeaderText = "ponavljanja";
            this.ponavljanjaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ponavljanjaDataGridViewTextBoxColumn.Name = "ponavljanjaDataGridViewTextBoxColumn";
            this.ponavljanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vjezbaucenikDataGridViewTextBoxColumn
            // 
            this.vjezbaucenikDataGridViewTextBoxColumn.DataPropertyName = "vjezba_ucenik";
            this.vjezbaucenikDataGridViewTextBoxColumn.HeaderText = "vjezba_ucenik";
            this.vjezbaucenikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vjezbaucenikDataGridViewTextBoxColumn.Name = "vjezbaucenikDataGridViewTextBoxColumn";
            this.vjezbaucenikDataGridViewTextBoxColumn.ReadOnly = true;
            this.vjezbaucenikDataGridViewTextBoxColumn.Visible = false;
            // 
            // vjezbaBindingSource
            // 
            this.vjezbaBindingSource.DataSource = typeof(SmartFitness.Database.vjezba);
            // 
            // btnBrisi
            // 
            this.btnBrisi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBrisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrisi.BorderRadius = 0;
            this.btnBrisi.ButtonText = "Obrisi";
            this.btnBrisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrisi.DisabledColor = System.Drawing.Color.Gray;
            this.btnBrisi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBrisi.Iconimage = null;
            this.btnBrisi.Iconimage_right = null;
            this.btnBrisi.Iconimage_right_Selected = null;
            this.btnBrisi.Iconimage_Selected = null;
            this.btnBrisi.IconMarginLeft = 0;
            this.btnBrisi.IconMarginRight = 0;
            this.btnBrisi.IconRightVisible = true;
            this.btnBrisi.IconRightZoom = 0D;
            this.btnBrisi.IconVisible = true;
            this.btnBrisi.IconZoom = 90D;
            this.btnBrisi.IsTab = true;
            this.btnBrisi.Location = new System.Drawing.Point(918, 307);
            this.btnBrisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBrisi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBrisi.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnBrisi.selected = true;
            this.btnBrisi.Size = new System.Drawing.Size(198, 43);
            this.btnBrisi.TabIndex = 39;
            this.btnBrisi.Text = "Obrisi";
            this.btnBrisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBrisi.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnBrisi.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
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
            this.btnAzuriraj.Location = new System.Drawing.Point(706, 307);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAzuriraj.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAzuriraj.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAzuriraj.selected = true;
            this.btnAzuriraj.Size = new System.Drawing.Size(204, 43);
            this.btnAzuriraj.TabIndex = 38;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAzuriraj.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnAzuriraj.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnUnos
            // 
            this.btnUnos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUnos.BorderRadius = 0;
            this.btnUnos.ButtonText = "Dodaj";
            this.btnUnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnos.DisabledColor = System.Drawing.Color.Gray;
            this.btnUnos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUnos.Iconimage = null;
            this.btnUnos.Iconimage_right = null;
            this.btnUnos.Iconimage_right_Selected = null;
            this.btnUnos.Iconimage_Selected = null;
            this.btnUnos.IconMarginLeft = 0;
            this.btnUnos.IconMarginRight = 0;
            this.btnUnos.IconRightVisible = true;
            this.btnUnos.IconRightZoom = 0D;
            this.btnUnos.IconVisible = true;
            this.btnUnos.IconZoom = 90D;
            this.btnUnos.IsTab = true;
            this.btnUnos.Location = new System.Drawing.Point(861, 247);
            this.btnUnos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUnos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUnos.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnUnos.selected = true;
            this.btnUnos.Size = new System.Drawing.Size(245, 43);
            this.btnUnos.TabIndex = 37;
            this.btnUnos.Text = "Dodaj";
            this.btnUnos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUnos.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnUnos.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // PopisVjezbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1125, 511);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.dgvVjezbe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPonavljanje);
            this.Controls.Add(this.txtVrijeme);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtNaziv);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopisVjezbi";
            this.Text = "PopisVjezbi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVjezbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vjezbaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtVrijeme;
        private System.Windows.Forms.TextBox txtPonavljanje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvVjezbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvjezbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemevjezbanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ponavljanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vjezbaucenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vjezbaBindingSource;
        private Bunifu.Framework.UI.BunifuFlatButton btnBrisi;
        private Bunifu.Framework.UI.BunifuFlatButton btnAzuriraj;
        private Bunifu.Framework.UI.BunifuFlatButton btnUnos;
    }
}