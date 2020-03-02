namespace SmartFitness.Forms.Interactive
{
    partial class IspisIPretraga
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
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.comboBoxVrstaSporta = new System.Windows.Forms.ComboBox();
            this.sportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPretraziIspis = new System.Windows.Forms.TextBox();
            this.dgvPodaciIspisa = new System.Windows.Forms.DataGridView();
            this.dgvVjezbe = new System.Windows.Forms.DataGridView();
            this.vjezbaucenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblVjezbe = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.datumOd = new System.Windows.Forms.DateTimePicker();
            this.lblOd = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.datumDo = new System.Windows.Forms.DateTimePicker();
            this.dgvUceniciBezSporta = new System.Windows.Forms.DataGridView();
            this.ucenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblUcenici = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPretr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaciIspisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVjezbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vjezbaucenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUceniciBezSporta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(49, 42);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(123, 25);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Vrsta sporta:";
            // 
            // comboBoxVrstaSporta
            // 
            this.comboBoxVrstaSporta.DataSource = this.sportBindingSource;
            this.comboBoxVrstaSporta.DisplayMember = "naziv";
            this.comboBoxVrstaSporta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVrstaSporta.FormattingEnabled = true;
            this.comboBoxVrstaSporta.Location = new System.Drawing.Point(190, 44);
            this.comboBoxVrstaSporta.Name = "comboBoxVrstaSporta";
            this.comboBoxVrstaSporta.Size = new System.Drawing.Size(170, 24);
            this.comboBoxVrstaSporta.TabIndex = 2;
            this.comboBoxVrstaSporta.ValueMember = "id_sporta";
            this.comboBoxVrstaSporta.SelectedIndexChanged += new System.EventHandler(this.comboBoxVrstaIspisa_SelectedIndexChanged);
            // 
            // sportBindingSource
            // 
            this.sportBindingSource.DataSource = typeof(SmartFitness.Database.sport);
            // 
            // txtPretraziIspis
            // 
            this.txtPretraziIspis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretraziIspis.Location = new System.Drawing.Point(877, 43);
            this.txtPretraziIspis.Name = "txtPretraziIspis";
            this.txtPretraziIspis.Size = new System.Drawing.Size(281, 28);
            this.txtPretraziIspis.TabIndex = 3;
            this.txtPretraziIspis.Text = "Pretrazi po imenu ili prezimenu...";
            this.txtPretraziIspis.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPretraziIspis_MouseClick);
            this.txtPretraziIspis.TextChanged += new System.EventHandler(this.txtPretraziIspis_TextChanged);
            this.txtPretraziIspis.Enter += new System.EventHandler(this.txtPretraziIspis_Enter);
            // 
            // dgvPodaciIspisa
            // 
            this.dgvPodaciIspisa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPodaciIspisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPodaciIspisa.Location = new System.Drawing.Point(53, 92);
            this.dgvPodaciIspisa.Name = "dgvPodaciIspisa";
            this.dgvPodaciIspisa.RowHeadersWidth = 51;
            this.dgvPodaciIspisa.RowTemplate.Height = 24;
            this.dgvPodaciIspisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPodaciIspisa.Size = new System.Drawing.Size(1105, 233);
            this.dgvPodaciIspisa.TabIndex = 4;
            this.dgvPodaciIspisa.SelectionChanged += new System.EventHandler(this.dgvPodaciIspisa_SelectionChanged);
            // 
            // dgvVjezbe
            // 
            this.dgvVjezbe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVjezbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVjezbe.Location = new System.Drawing.Point(53, 377);
            this.dgvVjezbe.Name = "dgvVjezbe";
            this.dgvVjezbe.RowHeadersWidth = 51;
            this.dgvVjezbe.RowTemplate.Height = 24;
            this.dgvVjezbe.Size = new System.Drawing.Size(1104, 276);
            this.dgvVjezbe.TabIndex = 5;
            // 
            // vjezbaucenikBindingSource
            // 
            this.vjezbaucenikBindingSource.DataSource = typeof(SmartFitness.Database.vjezba_ucenik);
            // 
            // lblVjezbe
            // 
            this.lblVjezbe.AutoSize = true;
            this.lblVjezbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVjezbe.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblVjezbe.Location = new System.Drawing.Point(49, 342);
            this.lblVjezbe.Name = "lblVjezbe";
            this.lblVjezbe.Size = new System.Drawing.Size(73, 25);
            this.lblVjezbe.TabIndex = 6;
            this.lblVjezbe.Text = "Vježbe";
            // 
            // datumOd
            // 
            this.datumOd.Location = new System.Drawing.Point(593, 340);
            this.datumOd.Name = "datumOd";
            this.datumOd.Size = new System.Drawing.Size(200, 22);
            this.datumOd.TabIndex = 7;
            this.datumOd.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.datumOd.ValueChanged += new System.EventHandler(this.DatumOd_ValueChanged);
            // 
            // lblOd
            // 
            this.lblOd.AutoSize = true;
            this.lblOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblOd.Location = new System.Drawing.Point(474, 339);
            this.lblOd.Name = "lblOd";
            this.lblOd.Size = new System.Drawing.Size(109, 25);
            this.lblOd.TabIndex = 8;
            this.lblOd.Text = "Od datuma";
            // 
            // lblDo
            // 
            this.lblDo.AutoSize = true;
            this.lblDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDo.Location = new System.Drawing.Point(836, 339);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(107, 25);
            this.lblDo.TabIndex = 10;
            this.lblDo.Text = "Do datuma";
            // 
            // datumDo
            // 
            this.datumDo.Location = new System.Drawing.Point(957, 340);
            this.datumDo.Name = "datumDo";
            this.datumDo.Size = new System.Drawing.Size(200, 22);
            this.datumDo.TabIndex = 9;
            this.datumDo.ValueChanged += new System.EventHandler(this.datumDo_ValueChanged);
            // 
            // dgvUceniciBezSporta
            // 
            this.dgvUceniciBezSporta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUceniciBezSporta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUceniciBezSporta.Location = new System.Drawing.Point(54, 715);
            this.dgvUceniciBezSporta.Name = "dgvUceniciBezSporta";
            this.dgvUceniciBezSporta.RowHeadersWidth = 51;
            this.dgvUceniciBezSporta.RowTemplate.Height = 24;
            this.dgvUceniciBezSporta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUceniciBezSporta.Size = new System.Drawing.Size(1104, 259);
            this.dgvUceniciBezSporta.TabIndex = 11;
            this.dgvUceniciBezSporta.SelectionChanged += new System.EventHandler(this.dgvUceniciBezSporta_SelectionChanged);
            // 
            // ucenikBindingSource
            // 
            this.ucenikBindingSource.DataSource = typeof(SmartFitness.Database.ucenik);
            // 
            // lblUcenici
            // 
            this.lblUcenici.AutoSize = true;
            this.lblUcenici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUcenici.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUcenici.Location = new System.Drawing.Point(49, 677);
            this.lblUcenici.Name = "lblUcenici";
            this.lblUcenici.Size = new System.Drawing.Size(317, 25);
            this.lblUcenici.TabIndex = 12;
            this.lblUcenici.Text = "Učenici koji nemaju ocjenu u sportu";
            // 
            // txtPretr
            // 
            this.txtPretr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretr.Location = new System.Drawing.Point(876, 676);
            this.txtPretr.Name = "txtPretr";
            this.txtPretr.Size = new System.Drawing.Size(281, 28);
            this.txtPretr.TabIndex = 13;
            this.txtPretr.Text = "Pretrazi po imenu ili prezimenu...";
            this.txtPretr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPretr_MouseClick);
            this.txtPretr.TextChanged += new System.EventHandler(this.txtPretr_TextChanged);
            // 
            // IspisIPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1211, 986);
            this.Controls.Add(this.txtPretr);
            this.Controls.Add(this.lblUcenici);
            this.Controls.Add(this.dgvUceniciBezSporta);
            this.Controls.Add(this.lblDo);
            this.Controls.Add(this.datumDo);
            this.Controls.Add(this.lblOd);
            this.Controls.Add(this.datumOd);
            this.Controls.Add(this.lblVjezbe);
            this.Controls.Add(this.dgvVjezbe);
            this.Controls.Add(this.dgvPodaciIspisa);
            this.Controls.Add(this.txtPretraziIspis);
            this.Controls.Add(this.comboBoxVrstaSporta);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IspisIPretraga";
            this.Text = "IspisIPretraga";
            ((System.ComponentModel.ISupportInitialize)(this.sportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaciIspisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVjezbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vjezbaucenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUceniciBezSporta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucenikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox comboBoxVrstaSporta;
        private System.Windows.Forms.TextBox txtPretraziIspis;
        private System.Windows.Forms.DataGridView dgvPodaciIspisa;
        private System.Windows.Forms.BindingSource sportBindingSource;
        private System.Windows.Forms.DataGridView dgvVjezbe;
        private System.Windows.Forms.BindingSource vjezbaucenikBindingSource;
        private Bunifu.Framework.UI.BunifuCustomLabel lblVjezbe;
        private System.Windows.Forms.DateTimePicker datumOd;
        private Bunifu.Framework.UI.BunifuCustomLabel lblOd;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDo;
        private System.Windows.Forms.DateTimePicker datumDo;
        private System.Windows.Forms.DataGridView dgvUceniciBezSporta;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUcenici;
        private System.Windows.Forms.BindingSource ucenikBindingSource;
        private System.Windows.Forms.TextBox txtPretr;
    }
}