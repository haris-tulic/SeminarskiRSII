
namespace eAutobus.WinUI.Korisnici
{
    partial class frmKorisniciPrikaz
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.dgvPrikaz = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipKorisnika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbTipKorisnika = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(280, 60);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(142, 20);
            this.txtIme.TabIndex = 1;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(303, 179);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 2;
            this.btnPrikazi.Text = "Pretraga";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tip korisnika";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(280, 98);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(142, 20);
            this.txtPrezime.TabIndex = 6;
            // 
            // dgvPrikaz
            // 
            this.dgvPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikaz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ime,
            this.Prezime,
            this.DatumRodjenja,
            this.TipKorisnika});
            this.dgvPrikaz.Location = new System.Drawing.Point(3, 227);
            this.dgvPrikaz.Name = "dgvPrikaz";
            this.dgvPrikaz.Size = new System.Drawing.Size(795, 222);
            this.dgvPrikaz.TabIndex = 7;
            this.dgvPrikaz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrikaz_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.DataPropertyName = "DatumRodjenja";
            this.DatumRodjenja.HeaderText = "Datum rodjenja";
            this.DatumRodjenja.Name = "DatumRodjenja";
            // 
            // TipKorisnika
            // 
            this.TipKorisnika.DataPropertyName = "TipKorisnika";
            this.TipKorisnika.HeaderText = "Tip korisnika";
            this.TipKorisnika.Name = "TipKorisnika";
            // 
            // cbTipKorisnika
            // 
            this.cbTipKorisnika.FormattingEnabled = true;
            this.cbTipKorisnika.Location = new System.Drawing.Point(280, 126);
            this.cbTipKorisnika.Name = "cbTipKorisnika";
            this.cbTipKorisnika.Size = new System.Drawing.Size(142, 21);
            this.cbTipKorisnika.TabIndex = 8;
            // 
            // frmKorisniciPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbTipKorisnika);
            this.Controls.Add(this.dgvPrikaz);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Name = "frmKorisniciPrikaz";
            this.Text = "frmKorisniciPrikaz";
            this.Load += new System.EventHandler(this.frmKorisniciPrikaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.DataGridView dgvPrikaz;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipKorisnika;
        private System.Windows.Forms.ComboBox cbTipKorisnika;
    }
}