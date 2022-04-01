
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
            this.RasporedVoznjeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojLinije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojAutobusa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Polazak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemePolaska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemeDolaska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odlazak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbPolaziste = new System.Windows.Forms.ComboBox();
            this.cbOdrediste = new System.Windows.Forms.ComboBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinije)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Polazište:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Odredište:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum:";
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSnimi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSnimi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSnimi.Location = new System.Drawing.Point(370, 174);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(75, 23);
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
            this.Datum});
            this.dgvLinije.Location = new System.Drawing.Point(12, 228);
            this.dgvLinije.Name = "dgvLinije";
            this.dgvLinije.ReadOnly = true;
            this.dgvLinije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLinije.Size = new System.Drawing.Size(743, 210);
            this.dgvLinije.TabIndex = 4;
            this.dgvLinije.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvLinije_MouseDoubleClick);
            // 
            // RasporedVoznjeID
            // 
            this.RasporedVoznjeID.DataPropertyName = "RasporedVoznjeID";
            this.RasporedVoznjeID.HeaderText = "RasporedVoznjeID";
            this.RasporedVoznjeID.Name = "RasporedVoznjeID";
            this.RasporedVoznjeID.ReadOnly = true;
            this.RasporedVoznjeID.Visible = false;
            // 
            // BrojLinije
            // 
            this.BrojLinije.DataPropertyName = "BrojLinije";
            this.BrojLinije.HeaderText = "Linija";
            this.BrojLinije.Name = "BrojLinije";
            this.BrojLinije.ReadOnly = true;
            // 
            // BrojAutobusa
            // 
            this.BrojAutobusa.DataPropertyName = "BrojAutobusa";
            this.BrojAutobusa.HeaderText = "Autobus";
            this.BrojAutobusa.Name = "BrojAutobusa";
            this.BrojAutobusa.ReadOnly = true;
            // 
            // Polazak
            // 
            this.Polazak.DataPropertyName = "Polazak";
            this.Polazak.HeaderText = "Polazište";
            this.Polazak.Name = "Polazak";
            this.Polazak.ReadOnly = true;
            // 
            // VrijemePolaska
            // 
            this.VrijemePolaska.DataPropertyName = "VrijemePolaska";
            this.VrijemePolaska.HeaderText = "Vrijeme polaska";
            this.VrijemePolaska.Name = "VrijemePolaska";
            this.VrijemePolaska.ReadOnly = true;
            this.VrijemePolaska.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // VrijemeDolaska
            // 
            this.VrijemeDolaska.DataPropertyName = "VrijemeDolaska";
            this.VrijemeDolaska.HeaderText = "Vrijeme dolaska";
            this.VrijemeDolaska.Name = "VrijemeDolaska";
            this.VrijemeDolaska.ReadOnly = true;
            this.VrijemeDolaska.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Odlazak
            // 
            this.Odlazak.DataPropertyName = "Odlazak";
            this.Odlazak.HeaderText = "Odredište";
            this.Odlazak.Name = "Odlazak";
            this.Odlazak.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            this.Datum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cbPolaziste
            // 
            this.cbPolaziste.FormattingEnabled = true;
            this.cbPolaziste.Location = new System.Drawing.Point(119, 54);
            this.cbPolaziste.Name = "cbPolaziste";
            this.cbPolaziste.Size = new System.Drawing.Size(138, 21);
            this.cbPolaziste.TabIndex = 5;
            // 
            // cbOdrediste
            // 
            this.cbOdrediste.FormattingEnabled = true;
            this.cbOdrediste.Location = new System.Drawing.Point(585, 54);
            this.cbOdrediste.Name = "cbOdrediste";
            this.cbOdrediste.Size = new System.Drawing.Size(138, 21);
            this.cbOdrediste.TabIndex = 6;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(326, 128);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 7;
            this.dtpDatum.ValueChanged += new System.EventHandler(this.dtpDatum_ValueChanged);
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.Location = new System.Drawing.Point(370, 480);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(75, 23);
            this.btnIzvjestaj.TabIndex = 8;
            this.btnIzvjestaj.Text = "Izvještaj";
            this.btnIzvjestaj.UseVisualStyleBackColor = true;
            this.btnIzvjestaj.Click += new System.EventHandler(this.btnIzvjestaj_Click);
            // 
            // frmPregledRedaVoznji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 556);
            this.Controls.Add(this.btnIzvjestaj);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.cbOdrediste);
            this.Controls.Add(this.cbPolaziste);
            this.Controls.Add(this.dgvLinije);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn RasporedVoznjeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojLinije;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojAutobusa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Polazak;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemePolaska;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemeDolaska;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odlazak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.Button btnIzvjestaj;
    }
}