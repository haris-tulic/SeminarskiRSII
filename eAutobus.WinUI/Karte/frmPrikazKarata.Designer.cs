
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
            this.KartaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipKarte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tip:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zona:";
            // 
            // cbTip
            // 
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Location = new System.Drawing.Point(133, 73);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(172, 21);
            this.cbTip.TabIndex = 2;
            // 
            // cbZona
            // 
            this.cbZona.FormattingEnabled = true;
            this.cbZona.Location = new System.Drawing.Point(493, 73);
            this.cbZona.Name = "cbZona";
            this.cbZona.Size = new System.Drawing.Size(172, 21);
            this.cbZona.TabIndex = 3;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(338, 138);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 4;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KartaID,
            this.TipKarte,
            this.Zona,
            this.Vrsta,
            this.Cijena});
            this.dataGridView1.Location = new System.Drawing.Point(12, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 197);
            this.dataGridView1.TabIndex = 5;
            // 
            // KartaID
            // 
            this.KartaID.HeaderText = "KartaID";
            this.KartaID.Name = "KartaID";
            this.KartaID.Visible = false;
            // 
            // TipKarte
            // 
            this.TipKarte.DataPropertyName = "TipKarte";
            this.TipKarte.HeaderText = "Tip karte";
            this.TipKarte.Name = "TipKarte";
            // 
            // Zona
            // 
            this.Zona.DataPropertyName = "Zona";
            this.Zona.HeaderText = "Zona";
            this.Zona.Name = "Zona";
            // 
            // Vrsta
            // 
            this.Vrsta.DataPropertyName = "Zona";
            this.Vrsta.HeaderText = "Vrsta";
            this.Vrsta.Name = "Vrsta";
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            // 
            // frmPrikazKarata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.cbZona);
            this.Controls.Add(this.cbTip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn KartaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipKarte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrsta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
    }
}