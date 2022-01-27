
namespace eAutobus.WinUI.RedVoznji
{
    partial class frmDodavanjeRedaVoznje
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
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtBrLinije = new System.Windows.Forms.TextBox();
            this.cbBrAutobusa = new System.Windows.Forms.ComboBox();
            this.cbVozac = new System.Windows.Forms.ComboBox();
            this.cbKondukter = new System.Windows.Forms.ComboBox();
            this.dtpPolazak = new System.Windows.Forms.DateTimePicker();
            this.dtpDolazak = new System.Windows.Forms.DateTimePicker();
            this.errorDodavanjeLinije = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbPolaziste = new System.Windows.Forms.ComboBox();
            this.cbOdrediste = new System.Windows.Forms.ComboBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorDodavanjeLinije)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj linije:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Polazište:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Odredište:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vrijeme polaska:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Broj autobusa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vozač:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kondukter:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Vrijeme dolaska:";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(331, 327);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 8;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // txtBrLinije
            // 
            this.txtBrLinije.Location = new System.Drawing.Point(119, 37);
            this.txtBrLinije.Name = "txtBrLinije";
            this.txtBrLinije.Size = new System.Drawing.Size(178, 20);
            this.txtBrLinije.TabIndex = 9;
            // 
            // cbBrAutobusa
            // 
            this.cbBrAutobusa.FormattingEnabled = true;
            this.cbBrAutobusa.Location = new System.Drawing.Point(489, 36);
            this.cbBrAutobusa.Name = "cbBrAutobusa";
            this.cbBrAutobusa.Size = new System.Drawing.Size(178, 21);
            this.cbBrAutobusa.TabIndex = 17;
            // 
            // cbVozac
            // 
            this.cbVozac.FormattingEnabled = true;
            this.cbVozac.Location = new System.Drawing.Point(489, 94);
            this.cbVozac.Name = "cbVozac";
            this.cbVozac.Size = new System.Drawing.Size(178, 21);
            this.cbVozac.TabIndex = 18;
            // 
            // cbKondukter
            // 
            this.cbKondukter.FormattingEnabled = true;
            this.cbKondukter.Location = new System.Drawing.Point(489, 144);
            this.cbKondukter.Name = "cbKondukter";
            this.cbKondukter.Size = new System.Drawing.Size(178, 21);
            this.cbKondukter.TabIndex = 19;
            // 
            // dtpPolazak
            // 
            this.dtpPolazak.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpPolazak.Location = new System.Drawing.Point(119, 200);
            this.dtpPolazak.Name = "dtpPolazak";
            this.dtpPolazak.Size = new System.Drawing.Size(178, 20);
            this.dtpPolazak.TabIndex = 20;
            this.dtpPolazak.Value = new System.DateTime(2022, 1, 6, 16, 1, 0, 0);
            // 
            // dtpDolazak
            // 
            this.dtpDolazak.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDolazak.Location = new System.Drawing.Point(489, 200);
            this.dtpDolazak.Name = "dtpDolazak";
            this.dtpDolazak.Size = new System.Drawing.Size(178, 20);
            this.dtpDolazak.TabIndex = 21;
            this.dtpDolazak.Value = new System.DateTime(2021, 10, 23, 16, 2, 13, 0);
            // 
            // errorDodavanjeLinije
            // 
            this.errorDodavanjeLinije.ContainerControl = this;
            // 
            // cbPolaziste
            // 
            this.cbPolaziste.FormattingEnabled = true;
            this.cbPolaziste.Location = new System.Drawing.Point(119, 88);
            this.cbPolaziste.Name = "cbPolaziste";
            this.cbPolaziste.Size = new System.Drawing.Size(178, 21);
            this.cbPolaziste.TabIndex = 22;
            // 
            // cbOdrediste
            // 
            this.cbOdrediste.FormattingEnabled = true;
            this.cbOdrediste.Location = new System.Drawing.Point(119, 139);
            this.cbOdrediste.Name = "cbOdrediste";
            this.cbOdrediste.Size = new System.Drawing.Size(178, 21);
            this.cbOdrediste.TabIndex = 23;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(119, 258);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(178, 20);
            this.dtpDatum.TabIndex = 24;
            this.dtpDatum.ValueChanged += new System.EventHandler(this.dtpDatum_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Datum:";
            // 
            // frmDodavanjeRedaVoznje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.cbOdrediste);
            this.Controls.Add(this.cbPolaziste);
            this.Controls.Add(this.dtpDolazak);
            this.Controls.Add(this.dtpPolazak);
            this.Controls.Add(this.cbKondukter);
            this.Controls.Add(this.cbVozac);
            this.Controls.Add(this.cbBrAutobusa);
            this.Controls.Add(this.txtBrLinije);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDodavanjeRedaVoznje";
            this.Text = "Dodavanje novog reda vožnje";
            this.Load += new System.EventHandler(this.frmDodavanjeRedaVoznje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorDodavanjeLinije)).EndInit();
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
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox txtBrLinije;
        private System.Windows.Forms.ComboBox cbBrAutobusa;
        private System.Windows.Forms.ComboBox cbVozac;
        private System.Windows.Forms.ComboBox cbKondukter;
        private System.Windows.Forms.DateTimePicker dtpPolazak;
        private System.Windows.Forms.DateTimePicker dtpDolazak;
        private System.Windows.Forms.ErrorProvider errorDodavanjeLinije;
        private System.Windows.Forms.ComboBox cbOdrediste;
        private System.Windows.Forms.ComboBox cbPolaziste;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDatum;
    }
}