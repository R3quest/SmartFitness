namespace SmartFitness
{
    partial class PocetnaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PocetnaForma));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.plnHeader = new System.Windows.Forms.Panel();
            this.btnZatvori = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPopisVjezbi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNatjecanja = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnOdjava = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStatistika = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnIspisPretraga = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUnos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlPrikazForme = new System.Windows.Forms.Panel();
            this.bunifuDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.plnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnZatvori)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 2;
            this.bunifuElipse1.TargetControl = this;
            // 
            // plnHeader
            // 
            this.plnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.plnHeader.Controls.Add(this.btnZatvori);
            this.plnHeader.Controls.Add(this.bunifuCustomLabel1);
            this.plnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.plnHeader.Location = new System.Drawing.Point(0, 0);
            this.plnHeader.Name = "plnHeader";
            this.plnHeader.Size = new System.Drawing.Size(1481, 65);
            this.plnHeader.TabIndex = 0;
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnZatvori.Image = ((System.Drawing.Image)(resources.GetObject("btnZatvori.Image")));
            this.btnZatvori.ImageActive = null;
            this.btnZatvori.Location = new System.Drawing.Point(1451, 7);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(20, 21);
            this.btnZatvori.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnZatvori.TabIndex = 0;
            this.btnZatvori.TabStop = false;
            this.btnZatvori.Zoom = 20;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 19);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(213, 24);
            this.bunifuCustomLabel1.TabIndex = 10;
            this.bunifuCustomLabel1.Text = "SmartFitness - Aplikacija";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.btnPopisVjezbi);
            this.panel3.Controls.Add(this.btnNatjecanja);
            this.panel3.Controls.Add(this.btnOdjava);
            this.panel3.Controls.Add(this.btnStatistika);
            this.panel3.Controls.Add(this.btnIspisPretraga);
            this.panel3.Controls.Add(this.btnUnos);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 658);
            this.panel3.TabIndex = 2;
            // 
            // btnPopisVjezbi
            // 
            this.btnPopisVjezbi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnPopisVjezbi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPopisVjezbi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPopisVjezbi.BorderRadius = 0;
            this.btnPopisVjezbi.ButtonText = "       Popis vježbi";
            this.btnPopisVjezbi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPopisVjezbi.DisabledColor = System.Drawing.Color.Gray;
            this.btnPopisVjezbi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPopisVjezbi.Iconimage = null;
            this.btnPopisVjezbi.Iconimage_right = null;
            this.btnPopisVjezbi.Iconimage_right_Selected = null;
            this.btnPopisVjezbi.Iconimage_Selected = null;
            this.btnPopisVjezbi.IconMarginLeft = 0;
            this.btnPopisVjezbi.IconMarginRight = 0;
            this.btnPopisVjezbi.IconRightVisible = true;
            this.btnPopisVjezbi.IconRightZoom = 0D;
            this.btnPopisVjezbi.IconVisible = true;
            this.btnPopisVjezbi.IconZoom = 90D;
            this.btnPopisVjezbi.IsTab = true;
            this.btnPopisVjezbi.Location = new System.Drawing.Point(-4, 348);
            this.btnPopisVjezbi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPopisVjezbi.Name = "btnPopisVjezbi";
            this.btnPopisVjezbi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPopisVjezbi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPopisVjezbi.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnPopisVjezbi.selected = false;
            this.btnPopisVjezbi.Size = new System.Drawing.Size(273, 59);
            this.btnPopisVjezbi.TabIndex = 6;
            this.btnPopisVjezbi.Text = "       Popis vježbi";
            this.btnPopisVjezbi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPopisVjezbi.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnPopisVjezbi.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopisVjezbi.Click += new System.EventHandler(this.btnPopisVjezbi_Click);
            // 
            // btnNatjecanja
            // 
            this.btnNatjecanja.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnNatjecanja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnNatjecanja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNatjecanja.BorderRadius = 0;
            this.btnNatjecanja.ButtonText = "       Natjecanja";
            this.btnNatjecanja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNatjecanja.DisabledColor = System.Drawing.Color.Gray;
            this.btnNatjecanja.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNatjecanja.Iconimage = null;
            this.btnNatjecanja.Iconimage_right = null;
            this.btnNatjecanja.Iconimage_right_Selected = null;
            this.btnNatjecanja.Iconimage_Selected = null;
            this.btnNatjecanja.IconMarginLeft = 0;
            this.btnNatjecanja.IconMarginRight = 0;
            this.btnNatjecanja.IconRightVisible = true;
            this.btnNatjecanja.IconRightZoom = 0D;
            this.btnNatjecanja.IconVisible = true;
            this.btnNatjecanja.IconZoom = 90D;
            this.btnNatjecanja.IsTab = true;
            this.btnNatjecanja.Location = new System.Drawing.Point(-4, 281);
            this.btnNatjecanja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNatjecanja.Name = "btnNatjecanja";
            this.btnNatjecanja.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnNatjecanja.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnNatjecanja.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnNatjecanja.selected = false;
            this.btnNatjecanja.Size = new System.Drawing.Size(273, 59);
            this.btnNatjecanja.TabIndex = 5;
            this.btnNatjecanja.Text = "       Natjecanja";
            this.btnNatjecanja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNatjecanja.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnNatjecanja.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatjecanja.Click += new System.EventHandler(this.btnNatjecanja_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnOdjava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnOdjava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOdjava.BorderRadius = 0;
            this.btnOdjava.ButtonText = "       Odjava";
            this.btnOdjava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdjava.DisabledColor = System.Drawing.Color.Gray;
            this.btnOdjava.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOdjava.Iconimage = null;
            this.btnOdjava.Iconimage_right = null;
            this.btnOdjava.Iconimage_right_Selected = null;
            this.btnOdjava.Iconimage_Selected = null;
            this.btnOdjava.IconMarginLeft = 0;
            this.btnOdjava.IconMarginRight = 0;
            this.btnOdjava.IconRightVisible = true;
            this.btnOdjava.IconRightZoom = 0D;
            this.btnOdjava.IconVisible = true;
            this.btnOdjava.IconZoom = 90D;
            this.btnOdjava.IsTab = true;
            this.btnOdjava.Location = new System.Drawing.Point(-4, 415);
            this.btnOdjava.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnOdjava.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnOdjava.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnOdjava.selected = false;
            this.btnOdjava.Size = new System.Drawing.Size(273, 59);
            this.btnOdjava.TabIndex = 4;
            this.btnOdjava.Text = "       Odjava";
            this.btnOdjava.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdjava.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnOdjava.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnStatistika
            // 
            this.btnStatistika.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnStatistika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnStatistika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStatistika.BorderRadius = 0;
            this.btnStatistika.ButtonText = "       Statistika";
            this.btnStatistika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistika.DisabledColor = System.Drawing.Color.Gray;
            this.btnStatistika.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStatistika.Iconimage = null;
            this.btnStatistika.Iconimage_right = null;
            this.btnStatistika.Iconimage_right_Selected = null;
            this.btnStatistika.Iconimage_Selected = null;
            this.btnStatistika.IconMarginLeft = 0;
            this.btnStatistika.IconMarginRight = 0;
            this.btnStatistika.IconRightVisible = true;
            this.btnStatistika.IconRightZoom = 0D;
            this.btnStatistika.IconVisible = true;
            this.btnStatistika.IconZoom = 90D;
            this.btnStatistika.IsTab = true;
            this.btnStatistika.Location = new System.Drawing.Point(0, 214);
            this.btnStatistika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnStatistika.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnStatistika.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnStatistika.selected = false;
            this.btnStatistika.Size = new System.Drawing.Size(273, 59);
            this.btnStatistika.TabIndex = 3;
            this.btnStatistika.Text = "       Statistika";
            this.btnStatistika.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistika.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnStatistika.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // btnIspisPretraga
            // 
            this.btnIspisPretraga.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnIspisPretraga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnIspisPretraga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIspisPretraga.BorderRadius = 0;
            this.btnIspisPretraga.ButtonText = "       Ispis i pretraga";
            this.btnIspisPretraga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIspisPretraga.DisabledColor = System.Drawing.Color.Gray;
            this.btnIspisPretraga.Iconcolor = System.Drawing.Color.Transparent;
            this.btnIspisPretraga.Iconimage = null;
            this.btnIspisPretraga.Iconimage_right = null;
            this.btnIspisPretraga.Iconimage_right_Selected = null;
            this.btnIspisPretraga.Iconimage_Selected = null;
            this.btnIspisPretraga.IconMarginLeft = 0;
            this.btnIspisPretraga.IconMarginRight = 0;
            this.btnIspisPretraga.IconRightVisible = true;
            this.btnIspisPretraga.IconRightZoom = 0D;
            this.btnIspisPretraga.IconVisible = true;
            this.btnIspisPretraga.IconZoom = 90D;
            this.btnIspisPretraga.IsTab = true;
            this.btnIspisPretraga.Location = new System.Drawing.Point(4, 147);
            this.btnIspisPretraga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIspisPretraga.Name = "btnIspisPretraga";
            this.btnIspisPretraga.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnIspisPretraga.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnIspisPretraga.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnIspisPretraga.selected = false;
            this.btnIspisPretraga.Size = new System.Drawing.Size(269, 59);
            this.btnIspisPretraga.TabIndex = 2;
            this.btnIspisPretraga.Text = "       Ispis i pretraga";
            this.btnIspisPretraga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIspisPretraga.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnIspisPretraga.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIspisPretraga.Click += new System.EventHandler(this.btnIspisPretraga_Click);
            // 
            // btnUnos
            // 
            this.btnUnos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnUnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUnos.BorderRadius = 0;
            this.btnUnos.ButtonText = "       Unos";
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
            this.btnUnos.Location = new System.Drawing.Point(4, 80);
            this.btnUnos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUnos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUnos.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnUnos.selected = true;
            this.btnUnos.Size = new System.Drawing.Size(269, 59);
            this.btnUnos.TabIndex = 1;
            this.btnUnos.Text = "       Unos";
            this.btnUnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnos.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnUnos.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlPrikazForme
            // 
            this.pnlPrikazForme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.pnlPrikazForme.Location = new System.Drawing.Point(269, 62);
            this.pnlPrikazForme.Name = "pnlPrikazForme";
            this.pnlPrikazForme.Size = new System.Drawing.Size(1211, 658);
            this.pnlPrikazForme.TabIndex = 1;
            // 
            // bunifuDragControl
            // 
            this.bunifuDragControl.Fixed = true;
            this.bunifuDragControl.Horizontal = true;
            this.bunifuDragControl.TargetControl = this.plnHeader;
            this.bunifuDragControl.Vertical = true;
            // 
            // PocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 721);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlPrikazForme);
            this.Controls.Add(this.plnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PocetnaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PocetnaForma";
            this.Load += new System.EventHandler(this.PocetnaForma_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PocetnaForma_KeyDown);
            this.plnHeader.ResumeLayout(false);
            this.plnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnZatvori)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel plnHeader;
        private System.Windows.Forms.Panel pnlPrikazForme;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btnZatvori;
        private Bunifu.Framework.UI.BunifuFlatButton btnUnos;
        private Bunifu.Framework.UI.BunifuFlatButton btnOdjava;
        private Bunifu.Framework.UI.BunifuFlatButton btnStatistika;
        private Bunifu.Framework.UI.BunifuFlatButton btnIspisPretraga;
        private Bunifu.Framework.UI.BunifuFlatButton btnPopisVjezbi;
        private Bunifu.Framework.UI.BunifuFlatButton btnNatjecanja;
    }
}