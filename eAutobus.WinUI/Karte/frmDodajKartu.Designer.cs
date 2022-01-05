
namespace eAutobus.WinUI.Karte
{
    partial class frmDodajKartu
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
            this.cbTipKarte = new System.Windows.Forms.ComboBox();
            this.cbVrstaKarte = new System.Windows.Forms.ComboBox();
            this.cbZona = new System.Windows.Forms.ComboBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPolaziste = new System.Windows.Forms.ComboBox();
            this.cmbOdrediste = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tip karte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vrsta karte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zona:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cijena:";
            // 
            // cbTipKarte
            // 
            this.cbTipKarte.FormattingEnabled = true;
            this.cbTipKarte.Location = new System.Drawing.Point(307, 112);
            this.cbTipKarte.Name = "cbTipKarte";
            this.cbTipKarte.Size = new System.Drawing.Size(140, 21);
            this.cbTipKarte.TabIndex = 4;
            this.cbTipKarte.Validating += new System.ComponentModel.CancelEventHandler(this.cbTipKarte_Validating);
            // 
            // cbVrstaKarte
            // 
            this.cbVrstaKarte.FormattingEnabled = true;
            this.cbVrstaKarte.Location = new System.Drawing.Point(307, 147);
            this.cbVrstaKarte.Name = "cbVrstaKarte";
            this.cbVrstaKarte.Size = new System.Drawing.Size(140, 21);
            this.cbVrstaKarte.TabIndex = 5;
            this.cbVrstaKarte.Validating += new System.ComponentModel.CancelEventHandler(this.cbVrstaKarte_Validating);
            // 
            // cbZona
            // 
            this.cbZona.FormattingEnabled = true;
            this.cbZona.Location = new System.Drawing.Point(307, 182);
            this.cbZona.Name = "cbZona";
            this.cbZona.Size = new System.Drawing.Size(140, 21);
            this.cbZona.TabIndex = 6;
            this.cbZona.Validating += new System.ComponentModel.CancelEventHandler(this.cbZona_Validating);
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(307, 219);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(140, 20);
            this.txtCijena.TabIndex = 7;
            this.txtCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtCijena_Validating);
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(337, 341);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(75, 23);
            this.btnSnimi.TabIndex = 8;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Polazište:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Odredište:";
            // 
            // cmbPolaziste
            // 
            this.cmbPolaziste.FormattingEnabled = true;
            this.cmbPolaziste.Location = new System.Drawing.Point(307, 255);
            this.cmbPolaziste.Name = "cmbPolaziste";
            this.cmbPolaziste.Size = new System.Drawing.Size(140, 21);
            this.cmbPolaziste.TabIndex = 11;
            this.cmbPolaziste.Validating += new System.ComponentModel.CancelEventHandler(this.cmbPolaziste_Validating);
            // 
            // cmbOdrediste
            // 
            this.cmbOdrediste.FormattingEnabled = true;
            this.cmbOdrediste.Location = new System.Drawing.Point(307, 291);
            this.cmbOdrediste.Name = "cmbOdrediste";
            this.cmbOdrediste.Size = new System.Drawing.Size(140, 21);
            this.cmbOdrediste.TabIndex = 12;
            this.cmbOdrediste.Validating += new System.ComponentModel.CancelEventHandler(this.cmbOdrediste_Validating);
            // 
            // frmDodajKartu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbOdrediste);
            this.Controls.Add(this.cmbPolaziste);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.cbZona);
            this.Controls.Add(this.cbVrstaKarte);
            this.Controls.Add(this.cbTipKarte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDodajKartu";
            this.Text = "frmDodajKartu";
            this.Load += new System.EventHandler(this.frmDodajKartu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTipKarte;
        private System.Windows.Forms.ComboBox cbVrstaKarte;
        private System.Windows.Forms.ComboBox cbZona;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cmbOdrediste;
        private System.Windows.Forms.ComboBox cmbPolaziste;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}