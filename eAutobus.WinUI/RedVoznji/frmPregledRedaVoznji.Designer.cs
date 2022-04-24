
namespace eAutobus.WinUI.RedVoznji
{
    partial class frmPregledRedaVoznji
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.dgvLinije = new System.Windows.Forms.DataGridView();
            this.cbPolaziste = new System.Windows.Forms.ComboBox();
            this.cbOdrediste = new System.Windows.Forms.ComboBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            this.RasporedVoznjeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojLinije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojAutobusa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Polazak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemePolaska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemeDolaska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odlazak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Akcija = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinije)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Polazište:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(699, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Odredište:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum:";
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSnimi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSnimi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSnimi.Location = new System.Drawing.Point(493, 214);
            this.btnSnimi.Margin = new System.Windows.Forms.Padding(4);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(100, 28);
            this.btnSnimi.TabIndex = 3;
            this.btnSnimi.Text = "Pretraga";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // dgvLinije
            // 
            this.dgvLinije.AllowUserToAddRows = false;
            this.dgvLinije.AllowUserToDeleteRows = false;
            this.dgvLinije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RasporedVoznjeID,
            this.BrojLinije,
            this.BrojAutobusa,
            this.Polazak,
            this.VrijemePolaska,
            this.VrijemeDolaska,
            this.Odlazak,
            this.Datum,
            this.Akcija});
            this.dgvLinije.Location = new System.Drawing.Point(16, 281);
            this.dgvLinije.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLinije.Name = "dgvLinije";
            this.dgvLinije.ReadOnly = true;
            this.dgvLinije.RowHeadersWidth = 51;
            this.dgvLinije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLinije.Size = new System.Drawing.Size(1053, 258);
            this.dgvLinije.TabIndex = 4;
            this.dgvLinije.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvLinije_MouseDoubleClick);
            // 
            // cbPolaziste
            // 
            this.cbPolaziste.FormattingEnabled = true;
            this.cbPolaziste.Location = new System.Drawing.Point(159, 66);
            this.cbPolaziste.Margin = new System.Windows.Forms.Padding(4);
            this.cbPolaziste.Name = "cbPolaziste";
            this.cbPolaziste.Size = new System.Drawing.Size(183, 24);
            this.cbPolaziste.TabIndex = 5;
            // 
            // cbOdrediste
            // 
            this.cbOdrediste.FormattingEnabled = true;
            this.cbOdrediste.Location = new System.Drawing.Point(780, 66);
            this.cbOdrediste.Margin = new System.Windows.Forms.Padding(4);
            this.cbOdrediste.Name = "cbOdrediste";
            this.cbOdrediste.Size = new System.Drawing.Size(183, 24);
            this.cbOdrediste.TabIndex = 6;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(435, 158);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(265, 22);
            this.dtpDatum.TabIndex = 7;
            this.dtpDatum.ValueChanged += new System.EventHandler(this.dtpDatum_ValueChanged);
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.Location = new System.Drawing.Point(493, 591);
            this.btnIzvjestaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(100, 28);
            this.btnIzvjestaj.TabIndex = 8;
            this.btnIzvjestaj.Text = "Izvještaj";
            this.btnIzvjestaj.UseVisualStyleBackColor = true;
            this.btnIzvjestaj.Click += new System.EventHandler(this.btnIzvjestaj_Click);
            // 
            // RasporedVoznjeID
            // 
            this.RasporedVoznjeID.DataPropertyName = "RasporedVoznjeID";
            this.RasporedVoznjeID.HeaderText = "RasporedVoznjeID";
            this.RasporedVoznjeID.MinimumWidth = 6;
            this.RasporedVoznjeID.Name = "RasporedVoznjeID";
            this.RasporedVoznjeID.ReadOnly = true;
            this.RasporedVoznjeID.Visible = false;
            this.RasporedVoznjeID.Width = 125;
            // 
            // BrojLinije
            // 
            this.BrojLinije.DataPropertyName = "BrojLinije";
            this.BrojLinije.HeaderText = "Linija";
            this.BrojLinije.MinimumWidth = 6;
            this.BrojLinije.Name = "BrojLinije";
            this.BrojLinije.ReadOnly = true;
            this.BrojLinije.Width = 125;
            // 
            // BrojAutobusa
            // 
            this.BrojAutobusa.DataPropertyName = "BrojAutobusa";
            this.BrojAutobusa.HeaderText = "Autobus";
            this.BrojAutobusa.MinimumWidth = 6;
            this.BrojAutobusa.Name = "BrojAutobusa";
            this.BrojAutobusa.ReadOnly = true;
            this.BrojAutobusa.Width = 125;
            // 
            // Polazak
            // 
            this.Polazak.DataPropertyName = "Polazak";
            this.Polazak.HeaderText = "Polazište";
            this.Polazak.MinimumWidth = 6;
            this.Polazak.Name = "Polazak";
            this.Polazak.ReadOnly = true;
            this.Polazak.Width = 125;
            // 
            // VrijemePolaska
            // 
            this.VrijemePolaska.DataPropertyName = "VrijemePolaska";
            this.VrijemePolaska.HeaderText = "Vrijeme polaska";
            this.VrijemePolaska.MinimumWidth = 6;
            this.VrijemePolaska.Name = "VrijemePolaska";
            this.VrijemePolaska.ReadOnly = true;
            this.VrijemePolaska.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.VrijemePolaska.Width = 125;
            // 
            // VrijemeDolaska
            // 
            this.VrijemeDolaska.DataPropertyName = "VrijemeDolaska";
            this.VrijemeDolaska.HeaderText = "Vrijeme dolaska";
            this.VrijemeDolaska.MinimumWidth = 6;
            this.VrijemeDolaska.Name = "VrijemeDolaska";
            this.VrijemeDolaska.ReadOnly = true;
            this.VrijemeDolaska.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.VrijemeDolaska.Width = 125;
            // 
            // Odlazak
            // 
            this.Odlazak.DataPropertyName = "Odlazak";
            this.Odlazak.HeaderText = "Odredište";
            this.Odlazak.MinimumWidth = 6;
            this.Odlazak.Name = "Odlazak";
            this.Odlazak.ReadOnly = true;
            this.Odlazak.Width = 125;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.MinimumWidth = 6;
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            this.Datum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Datum.Width = 125;
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
            // frmPregledRedaVoznji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 684);
            this.Controls.Add(this.btnIzvjestaj);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.cbOdrediste);
            this.Controls.Add(this.cbPolaziste);
            this.Controls.Add(this.dgvLinije);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPregledRedaVoznji";
            this.Text = "frmPregledRedaVoznji";
            this.Load += new System.EventHandler(this.frmPregledRedaVoznji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.DataGridView dgvLinije;
        private System.Windows.Forms.ComboBox cbPolaziste;
        private System.Windows.Forms.ComboBox cbOdrediste;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Button btnIzvjestaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn RasporedVoznjeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojLinije;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojAutobusa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Polazak;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemePolaska;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemeDolaska;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odlazak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewButtonColumn Akcija;
    }
}