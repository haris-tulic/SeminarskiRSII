
namespace eAutobus.WinUI.Karte
{
    partial class frmPrikazKarata
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.cbZona = new System.Windows.Forms.ComboBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPrintajKarte = new System.Windows.Forms.Button();
            this.CjenovnikID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipKarte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaKarte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Polaziste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odrediste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaPrikaz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Akcija = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tip:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(603, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zona:";
            // 
            // cbTip
            // 
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Location = new System.Drawing.Point(177, 90);
            this.cbTip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(228, 24);
            this.cbTip.TabIndex = 2;
            // 
            // cbZona
            // 
            this.cbZona.FormattingEnabled = true;
            this.cbZona.Location = new System.Drawing.Point(657, 90);
            this.cbZona.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbZona.Name = "cbZona";
            this.cbZona.Size = new System.Drawing.Size(228, 24);
            this.cbZona.TabIndex = 3;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(451, 170);
            this.btnPretraga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(100, 28);
            this.btnPretraga.TabIndex = 4;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CjenovnikID,
            this.TipKarte,
            this.Zona,
            this.VrstaKarte,
            this.Polaziste,
            this.Odrediste,
            this.CijenaPrikaz,
            this.Akcija});
            this.dataGridView1.Location = new System.Drawing.Point(71, 297);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(931, 242);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // btnPrintajKarte
            // 
            this.btnPrintajKarte.Location = new System.Drawing.Point(451, 609);
            this.btnPrintajKarte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrintajKarte.Name = "btnPrintajKarte";
            this.btnPrintajKarte.Size = new System.Drawing.Size(100, 28);
            this.btnPrintajKarte.TabIndex = 6;
            this.btnPrintajKarte.Text = "Printaj karte";
            this.btnPrintajKarte.UseVisualStyleBackColor = true;
            this.btnPrintajKarte.Click += new System.EventHandler(this.btnPrintajKarte_Click);
            // 
            // CjenovnikID
            // 
            this.CjenovnikID.DataPropertyName = "CjenovnikID";
            this.CjenovnikID.HeaderText = "CjenovnikID";
            this.CjenovnikID.MinimumWidth = 6;
            this.CjenovnikID.Name = "CjenovnikID";
            this.CjenovnikID.ReadOnly = true;
            this.CjenovnikID.Visible = false;
            this.CjenovnikID.Width = 125;
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
            // Zona
            // 
            this.Zona.DataPropertyName = "Zona";
            this.Zona.HeaderText = "Zona";
            this.Zona.MinimumWidth = 6;
            this.Zona.Name = "Zona";
            this.Zona.ReadOnly = true;
            this.Zona.Width = 125;
            // 
            // VrstaKarte
            // 
            this.VrstaKarte.DataPropertyName = "VrstaKarte";
            this.VrstaKarte.HeaderText = "Vrsta";
            this.VrstaKarte.MinimumWidth = 6;
            this.VrstaKarte.Name = "VrstaKarte";
            this.VrstaKarte.ReadOnly = true;
            this.VrstaKarte.Width = 125;
            // 
            // Polaziste
            // 
            this.Polaziste.DataPropertyName = "Polaziste";
            this.Polaziste.HeaderText = "Polazište";
            this.Polaziste.MinimumWidth = 6;
            this.Polaziste.Name = "Polaziste";
            this.Polaziste.ReadOnly = true;
            this.Polaziste.Width = 125;
            // 
            // Odrediste
            // 
            this.Odrediste.DataPropertyName = "Odrediste";
            this.Odrediste.HeaderText = "Odredište";
            this.Odrediste.MinimumWidth = 6;
            this.Odrediste.Name = "Odrediste";
            this.Odrediste.ReadOnly = true;
            this.Odrediste.Width = 125;
            // 
            // CijenaPrikaz
            // 
            this.CijenaPrikaz.DataPropertyName = "CijenaPrikaz";
            this.CijenaPrikaz.HeaderText = "Cijena";
            this.CijenaPrikaz.MinimumWidth = 6;
            this.CijenaPrikaz.Name = "CijenaPrikaz";
            this.CijenaPrikaz.ReadOnly = true;
            this.CijenaPrikaz.Width = 125;
            // 
            // Akcija
            // 
            this.Akcija.HeaderText = "Akcija";
            this.Akcija.MinimumWidth = 6;
            this.Akcija.Name = "Akcija";
            this.Akcija.ReadOnly = true;
            this.Akcija.Text = "Obriši";
            this.Akcija.UseColumnTextForButtonValue = true;
            this.Akcija.Width = 125;
            // 
            // frmPrikazKarata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 746);
            this.Controls.Add(this.btnPrintajKarte);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.cbZona);
            this.Controls.Add(this.cbTip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrikazKarata";
            this.Text = "frmPrikazKarata";
            this.Load += new System.EventHandler(this.frmPrikazKarata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.ComboBox cbZona;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPrintajKarte;
        private System.Windows.Forms.DataGridViewTextBoxColumn CjenovnikID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipKarte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zona;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaKarte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Polaziste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odrediste;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaPrikaz;
        private System.Windows.Forms.DataGridViewButtonColumn Akcija;
    }
}