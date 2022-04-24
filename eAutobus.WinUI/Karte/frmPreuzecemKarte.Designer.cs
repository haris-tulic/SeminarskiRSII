
namespace eAutobus.WinUI.Karte
{
    partial class frmPreuzecemKarte
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
            this.KartaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezimeKupca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaKarte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipKarte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Relacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumVadjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumVazenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JeLiPlacena = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazKarata)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrikazKarata
            // 
            this.dgvPrikazKarata.AllowUserToAddRows = false;
            this.dgvPrikazKarata.AllowUserToDeleteRows = false;
            this.dgvPrikazKarata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazKarata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KartaID,
            this.ImePrezimeKupca,
            this.VrstaKarte,
            this.TipKarte,
            this.Relacija,
            this.DatumVadjenja,
            this.DatumVazenja,
            this.Cijena,
            this.JeLiPlacena});
            this.dgvPrikazKarata.Location = new System.Drawing.Point(64, 213);
            this.dgvPrikazKarata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPrikazKarata.Name = "dgvPrikazKarata";
            this.dgvPrikazKarata.ReadOnly = true;
            this.dgvPrikazKarata.RowHeadersWidth = 51;
            this.dgvPrikazKarata.RowTemplate.Height = 24;
            this.dgvPrikazKarata.Size = new System.Drawing.Size(1058, 476);
            this.dgvPrikazKarata.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plaćanje preuzećem:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KartaID
            // 
            this.KartaID.DataPropertyName = "KartaID";
            this.KartaID.HeaderText = "ID";
            this.KartaID.MinimumWidth = 6;
            this.KartaID.Name = "KartaID";
            this.KartaID.ReadOnly = true;
            this.KartaID.Visible = false;
            this.KartaID.Width = 125;
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
            // VrstaKarte
            // 
            this.VrstaKarte.DataPropertyName = "VrstaKarte";
            this.VrstaKarte.HeaderText = "Vrsta karte";
            this.VrstaKarte.MinimumWidth = 6;
            this.VrstaKarte.Name = "VrstaKarte";
            this.VrstaKarte.ReadOnly = true;
            this.VrstaKarte.Width = 125;
            // 
            // TipKarte
            // 
            this.TipKarte.DataPropertyName = "TipKarte";
            this.TipKarte.HeaderText = "Tip karte";
            this.TipKarte.MinimumWidth = 6;
            this.TipKarte.Name = "TipKarte";
            this.TipKarte.ReadOnly = true;
            this.TipKarte.Width = 125;
            // 
            // Relacija
            // 
            this.Relacija.DataPropertyName = "Relacija";
            this.Relacija.HeaderText = "Relacija";
            this.Relacija.MinimumWidth = 6;
            this.Relacija.Name = "Relacija";
            this.Relacija.ReadOnly = true;
            this.Relacija.Width = 125;
            // 
            // DatumVadjenja
            // 
            this.DatumVadjenja.DataPropertyName = "DatumVadjenjaKarte";
            this.DatumVadjenja.HeaderText = "Datum izdavanja";
            this.DatumVadjenja.MinimumWidth = 6;
            this.DatumVadjenja.Name = "DatumVadjenja";
            this.DatumVadjenja.ReadOnly = true;
            this.DatumVadjenja.Width = 125;
            // 
            // DatumVazenja
            // 
            this.DatumVazenja.DataPropertyName = "DatumVazenjaKarte";
            this.DatumVazenja.HeaderText = "Datum isteka";
            this.DatumVazenja.MinimumWidth = 6;
            this.DatumVazenja.Name = "DatumVazenja";
            this.DatumVazenja.ReadOnly = true;
            this.DatumVazenja.Width = 125;
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
            // frmPreuzecemKarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 785);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPrikazKarata);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPreuzecemKarte";
            this.Text = "frmPreuzecemKarte";
            this.Load += new System.EventHandler(this.frmPreuzecemKarte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazKarata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrikazKarata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KartaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezimeKupca;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaKarte;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipKarte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Relacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVadjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVazenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewCheckBoxColumn JeLiPlacena;
    }
}