namespace SmartFitness.Forms.Update
{
    partial class AzurirajUcenikaNaNatjecanju
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUcenik = new System.Windows.Forms.TextBox();
            this.dgvUcenikNatjecanje = new System.Windows.Forms.DataGridView();
            this.btnObrisi = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcenikNatjecanje)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(621, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ucenik";
            // 
            // txtUcenik
            // 
            this.txtUcenik.Enabled = false;
            this.txtUcenik.Location = new System.Drawing.Point(681, 16);
            this.txtUcenik.Name = "txtUcenik";
            this.txtUcenik.Size = new System.Drawing.Size(193, 22);
            this.txtUcenik.TabIndex = 1;
            // 
            // dgvUcenikNatjecanje
            // 
            this.dgvUcenikNatjecanje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUcenikNatjecanje.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvUcenikNatjecanje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUcenikNatjecanje.Location = new System.Drawing.Point(12, 16);
            this.dgvUcenikNatjecanje.Name = "dgvUcenikNatjecanje";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUcenikNatjecanje.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUcenikNatjecanje.RowTemplate.Height = 24;
            this.dgvUcenikNatjecanje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUcenikNatjecanje.Size = new System.Drawing.Size(582, 410);
            this.dgvUcenikNatjecanje.TabIndex = 2;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnObrisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObrisi.BorderRadius = 0;
            this.btnObrisi.ButtonText = "Obrisi natjecanje ucenika";
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
            this.btnObrisi.Location = new System.Drawing.Point(601, 381);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnObrisi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnObrisi.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnObrisi.selected = true;
            this.btnObrisi.Size = new System.Drawing.Size(297, 45);
            this.btnObrisi.TabIndex = 20;
            this.btnObrisi.Text = "Obrisi natjecanje ucenika";
            this.btnObrisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnObrisi.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnObrisi.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // AzurirajUcenikaNaNatjecanju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.dgvUcenikNatjecanje);
            this.Controls.Add(this.txtUcenik);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AzurirajUcenikaNaNatjecanju";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AzurirajUcenikaNaNatjecanju";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcenikNatjecanje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUcenik;
        private System.Windows.Forms.DataGridView dgvUcenikNatjecanje;
        private Bunifu.Framework.UI.BunifuFlatButton btnObrisi;
    }
}