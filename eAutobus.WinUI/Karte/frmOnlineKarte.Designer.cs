
namespace eAutobus.WinUI.Karte
{
    partial class frmOnlineKarte
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
            this.dgvPrikazKarata = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.PlatiKartuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezimeKupca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipKarte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaKarteNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PolazisteOdrediste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumVadjenjaKarte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumVazenjaKarte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JeLiPlacena = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazKarata)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrikazKarata
            // 
            this.dgvPrikazKarata.AllowUserToAddRows = false;
            this.dgvPrikazKarata.AllowUserToDeleteRows = false;
            this.dgvPrikazKarata.ColumnHeadersHeight = 29;
            this.dgvPrikazKarata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPrikazKarata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlatiKartuID,
            this.ImePrezimeKupca,
            this.TipKarte,
            this.VrstaKarteNaziv,
            this.PolazisteOdrediste,
            this.DatumVadjenjaKarte,
            this.DatumVazenjaKarte,
            this.Cijena,
            this.JeLiPlacena});
            this.dgvPrikazKarata.Location = new System.Drawing.Point(48, 224);
            this.dgvPrikazKarata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPrikazKarata.Name = "dgvPrikazKarata";
            this.dgvPrikazKarata.ReadOnly = true;
            this.dgvPrikazKarata.RowHeadersWidth = 51;
            this.dgvPrikazKarata.RowTemplate.Height = 24;
            this.dgvPrikazKarata.Size = new System.Drawing.Size(1405, 327);
            this.dgvPrikazKarata.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Online plaćanje:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlatiKartuID
            // 
            this.PlatiKartuID.DataPropertyName = "PlatiKartuID";
            this.PlatiKartuID.HeaderText = "ID";
            this.PlatiKartuID.MinimumWidth = 6;
            this.PlatiKartuID.Name = "PlatiKartuID";
            this.PlatiKartuID.ReadOnly = true;
            this.PlatiKartuID.Visible = false;
            this.PlatiKartuID.Width = 125;
            // 
            // ImePrezimeKupca
            // 
            this.ImePrezimeKupca.DataPropertyName = "ImePrezimeKupca";
            this.ImePrezimeKupca.HeaderText = "Ime i prezime";
            this.ImePrezimeKupca.MinimumWidth = 6;
            this.ImePrezimeKupca.Name = "ImePrezimeKupca";
            this.ImePrezimeKupca.ReadOnly = true;
            this.ImePrezimeKupca.Width = 125;
            // 
            // TipKarte
            // 
            this.TipKarte.DataPropertyName = "TipKarteNaziv";
            this.TipKarte.HeaderText = "Tip karte";
            this.TipKarte.MinimumWidth = 6;
            this.TipKarte.Name = "TipKarte";
            this.TipKarte.ReadOnly = true;
            this.TipKarte.Width = 125;
            // 
            // VrstaKarteNaziv
            // 
            this.VrstaKarteNaziv.DataPropertyName = "VrstaKarteNaziv";
            this.VrstaKarteNaziv.HeaderText = "Vrsta karte";
            this.VrstaKarteNaziv.MinimumWidth = 6;
            this.VrstaKarteNaziv.Name = "VrstaKarteNaziv";
            this.VrstaKarteNaziv.ReadOnly = true;
            this.VrstaKarteNaziv.Width = 125;
            // 
            // PolazisteOdrediste
            // 
            this.PolazisteOdrediste.DataPropertyName = "PolazisteOdrediste";
            this.PolazisteOdrediste.HeaderText = "Relacija";
            this.PolazisteOdrediste.MinimumWidth = 6;
            this.PolazisteOdrediste.Name = "PolazisteOdrediste";
            this.PolazisteOdrediste.ReadOnly = true;
            this.PolazisteOdrediste.Width = 125;
            // 
            // DatumVadjenjaKarte
            // 
            this.DatumVadjenjaKarte.DataPropertyName = "DatumVadjenjaKarte";
            this.DatumVadjenjaKarte.HeaderText = "Datum izdavanja";
            this.DatumVadjenjaKarte.MinimumWidth = 6;
            this.DatumVadjenjaKarte.Name = "DatumVadjenjaKarte";
            this.DatumVadjenjaKarte.ReadOnly = true;
            this.DatumVadjenjaKarte.Width = 125;
            // 
            // DatumVazenjaKarte
            // 
            this.DatumVazenjaKarte.DataPropertyName = "DatumVazenjaKarte";
            this.DatumVazenjaKarte.HeaderText = "Datum isteka";
            this.DatumVazenjaKarte.MinimumWidth = 6;
            this.DatumVazenjaKarte.Name = "DatumVazenjaKarte";
            this.DatumVazenjaKarte.ReadOnly = true;
            this.DatumVazenjaKarte.Width = 125;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "CijenaString";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.MinimumWidth = 6;
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.Width = 125;
            // 
            // JeLiPlacena
            // 
            this.JeLiPlacena.DataPropertyName = "JeLiPlacena";
            this.JeLiPlacena.HeaderText = "Placena";
            this.JeLiPlacena.MinimumWidth = 6;
            this.JeLiPlacena.Name = "JeLiPlacena";
            this.JeLiPlacena.ReadOnly = true;
            this.JeLiPlacena.Width = 125;
            // 
            // frmOnlineKarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPrikazKarata);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmOnlineKarte";
            this.Text = "frmOnlineKarte";
            this.Load += new System.EventHandler(this.frmOnlineKarte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazKarata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrikazKarata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlatiKartuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezimeKupca;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipKarte;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaKarteNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn PolazisteOdrediste;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVadjenjaKarte;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVazenjaKarte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewCheckBoxColumn JeLiPlacena;
    }
}