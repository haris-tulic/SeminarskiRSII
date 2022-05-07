
namespace eAutobus.WinUI.Karte
{
    partial class frmIzdajKartu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbVrstaKarte = new System.Windows.Forms.ComboBox();
            this.cbTipKarte = new System.Windows.Forms.ComboBox();
            this.cbPolaziste = new System.Windows.Forms.ComboBox();
            this.cbOdrediste = new System.Windows.Forms.ComboBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.dtpDatumVadjenja = new System.Windows.Forms.DateTimePicker();
            this.rbJedan = new System.Windows.Forms.RadioButton();
            this.rbDva = new System.Windows.Forms.RadioButton();
            this.btnIzdajKartu = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDatumVazenja = new System.Windows.Forms.DateTimePicker();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.btnPreuzmiPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresa stanovanja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vrsta karte:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tip:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Odredište:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Polazište:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Datum vađenja karte:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 524);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Pravac:";
            // 
            // cbVrstaKarte
            // 
            this.cbVrstaKarte.FormattingEnabled = true;
            this.cbVrstaKarte.Location = new System.Drawing.Point(332, 216);
            this.cbVrstaKarte.Name = "cbVrstaKarte";
            this.cbVrstaKarte.Size = new System.Drawing.Size(157, 21);
            this.cbVrstaKarte.TabIndex = 8;
            this.cbVrstaKarte.SelectedIndexChanged += new System.EventHandler(this.cbVrstaKarte_SelectedIndexChanged);
            this.cbVrstaKarte.Validating += new System.ComponentModel.CancelEventHandler(this.cbVrstaKarte_Validating);
            // 
            // cbTipKarte
            // 
            this.cbTipKarte.FormattingEnabled = true;
            this.cbTipKarte.Location = new System.Drawing.Point(332, 258);
            this.cbTipKarte.Name = "cbTipKarte";
            this.cbTipKarte.Size = new System.Drawing.Size(157, 21);
            this.cbTipKarte.TabIndex = 9;
            this.cbTipKarte.SelectedIndexChanged += new System.EventHandler(this.cbTipKarte_SelectedIndexChanged);
            this.cbTipKarte.Validating += new System.ComponentModel.CancelEventHandler(this.cbTipKarte_Validating);
            // 
            // cbPolaziste
            // 
            this.cbPolaziste.FormattingEnabled = true;
            this.cbPolaziste.Location = new System.Drawing.Point(333, 302);
            this.cbPolaziste.Name = "cbPolaziste";
            this.cbPolaziste.Size = new System.Drawing.Size(157, 21);
            this.cbPolaziste.TabIndex = 10;
            this.cbPolaziste.SelectedIndexChanged += new System.EventHandler(this.cbPolaziste_SelectedIndexChanged);
            this.cbPolaziste.Validating += new System.ComponentModel.CancelEventHandler(this.cbPolaziste_Validating);
            // 
            // cbOdrediste
            // 
            this.cbOdrediste.FormattingEnabled = true;
            this.cbOdrediste.Location = new System.Drawing.Point(333, 346);
            this.cbOdrediste.Name = "cbOdrediste";
            this.cbOdrediste.Size = new System.Drawing.Size(157, 21);
            this.cbOdrediste.TabIndex = 11;
            this.cbOdrediste.SelectedIndexChanged += new System.EventHandler(this.cbOdrediste_SelectedIndexChanged);
            this.cbOdrediste.Validating += new System.ComponentModel.CancelEventHandler(this.cbOdrediste_Validating);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(333, 44);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(157, 20);
            this.txtIme.TabIndex = 12;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtImePrezime_Validating);
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(333, 131);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(157, 20);
            this.txtAdresa.TabIndex = 13;
            this.txtAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdresa_Validating);
            // 
            // dtpDatumVadjenja
            // 
            this.dtpDatumVadjenja.Location = new System.Drawing.Point(333, 388);
            this.dtpDatumVadjenja.Name = "dtpDatumVadjenja";
            this.dtpDatumVadjenja.Size = new System.Drawing.Size(157, 20);
            this.dtpDatumVadjenja.TabIndex = 14;
            this.dtpDatumVadjenja.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDatum_Validating);
            // 
            // rbJedan
            // 
            this.rbJedan.AutoSize = true;
            this.rbJedan.Location = new System.Drawing.Point(333, 523);
            this.rbJedan.Name = "rbJedan";
            this.rbJedan.Size = new System.Drawing.Size(106, 17);
            this.rbJedan.TabIndex = 15;
            this.rbJedan.TabStop = true;
            this.rbJedan.Text = "U jednom pravcu";
            this.rbJedan.UseVisualStyleBackColor = true;
            this.rbJedan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbJedan_MouseClick);
            // 
            // rbDva
            // 
            this.rbDva.AutoSize = true;
            this.rbDva.Location = new System.Drawing.Point(458, 524);
            this.rbDva.Name = "rbDva";
            this.rbDva.Size = new System.Drawing.Size(90, 17);
            this.rbDva.TabIndex = 16;
            this.rbDva.TabStop = true;
            this.rbDva.Text = "U oba pravca";
            this.rbDva.UseVisualStyleBackColor = true;
            this.rbDva.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbDva_MouseClick);
            // 
            // btnIzdajKartu
            // 
            this.btnIzdajKartu.Location = new System.Drawing.Point(370, 579);
            this.btnIzdajKartu.Name = "btnIzdajKartu";
            this.btnIzdajKartu.Size = new System.Drawing.Size(82, 28);
            this.btnIzdajKartu.TabIndex = 17;
            this.btnIzdajKartu.Text = "Izdaj kartu";
            this.btnIzdajKartu.UseVisualStyleBackColor = true;
            this.btnIzdajKartu.Click += new System.EventHandler(this.btnIzdajKartu_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(222, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Datum važenja karte:";
            // 
            // dtpDatumVazenja
            // 
            this.dtpDatumVazenja.Location = new System.Drawing.Point(333, 431);
            this.dtpDatumVazenja.Name = "dtpDatumVazenja";
            this.dtpDatumVazenja.Size = new System.Drawing.Size(157, 20);
            this.dtpDatumVazenja.TabIndex = 19;
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Location = new System.Drawing.Point(280, 91);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(47, 13);
            this.labelPrezime.TabIndex = 20;
            this.labelPrezime.Text = "Prezime:";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(333, 474);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(157, 20);
            this.txtCijena.TabIndex = 22;
            this.txtCijena.Click += new System.EventHandler(this.txtCijena_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(283, 477);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Cijena:";
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Location = new System.Drawing.Point(333, 174);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(157, 20);
            this.txtBrojTelefona.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(258, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Broj telefona:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(333, 88);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(157, 20);
            this.txtPrezime.TabIndex = 26;
            // 
            // btnPreuzmiPDF
            // 
            this.btnPreuzmiPDF.Location = new System.Drawing.Point(572, 579);
            this.btnPreuzmiPDF.Name = "btnPreuzmiPDF";
            this.btnPreuzmiPDF.Size = new System.Drawing.Size(89, 28);
            this.btnPreuzmiPDF.TabIndex = 29;
            this.btnPreuzmiPDF.Text = "Preuzmi PDF";
            this.btnPreuzmiPDF.UseVisualStyleBackColor = true;
            this.btnPreuzmiPDF.Click += new System.EventHandler(this.btnPreuzmiPDF_Click);
            // 
            // frmIzdajKartu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 737);
            this.Controls.Add(this.btnPreuzmiPDF);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBrojTelefona);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.labelPrezime);
            this.Controls.Add(this.dtpDatumVazenja);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnIzdajKartu);
            this.Controls.Add(this.rbDva);
            this.Controls.Add(this.rbJedan);
            this.Controls.Add(this.dtpDatumVadjenja);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.cbOdrediste);
            this.Controls.Add(this.cbPolaziste);
            this.Controls.Add(this.cbTipKarte);
            this.Controls.Add(this.cbVrstaKarte);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmIzdajKartu";
            this.Text = "frmIzdajKartu";
            this.Load += new System.EventHandler(this.frmIzdajKartu_Load);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.frmIzdajKartu_Validating);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbVrstaKarte;
        private System.Windows.Forms.ComboBox cbTipKarte;
        private System.Windows.Forms.ComboBox cbPolaziste;
        private System.Windows.Forms.ComboBox cbOdrediste;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.DateTimePicker dtpDatumVadjenja;
        private System.Windows.Forms.RadioButton rbJedan;
        private System.Windows.Forms.RadioButton rbDva;
        private System.Windows.Forms.Button btnIzdajKartu;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDatumVazenja;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Button btnPreuzmiPDF;
    }
}