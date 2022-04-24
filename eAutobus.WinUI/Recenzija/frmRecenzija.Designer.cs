
namespace eAutobus.WinUI.Recenzija
{
    partial class frmRecenzija
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
            this.nmOcjena = new System.Windows.Forms.NumericUpDown();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.dgvRecenzije = new System.Windows.Forms.DataGridView();
            this.RecenzijaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Relacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRecenzije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Komentar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nmOcjena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecenzije)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ocjena:";
            // 
            // nmOcjena
            // 
            this.nmOcjena.Location = new System.Drawing.Point(491, 106);
            this.nmOcjena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmOcjena.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmOcjena.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmOcjena.Name = "nmOcjena";
            this.nmOcjena.Size = new System.Drawing.Size(93, 22);
            this.nmOcjena.TabIndex = 1;
            this.nmOcjena.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(484, 181);
            this.btnFiltriraj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(100, 28);
            this.btnFiltriraj.TabIndex = 2;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // dgvRecenzije
            // 
            this.dgvRecenzije.AllowUserToAddRows = false;
            this.dgvRecenzije.AllowUserToDeleteRows = false;
            this.dgvRecenzije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecenzije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecenzijaID,
            this.Vrsta,
            this.Relacija,
            this.DatumRecenzije,
            this.Ocjena,
            this.Komentar});
            this.dgvRecenzije.Location = new System.Drawing.Point(16, 257);
            this.dgvRecenzije.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRecenzije.Name = "dgvRecenzije";
            this.dgvRecenzije.ReadOnly = true;
            this.dgvRecenzije.RowHeadersWidth = 51;
            this.dgvRecenzije.Size = new System.Drawing.Size(1035, 282);
            this.dgvRecenzije.TabIndex = 3;
            // 
            // RecenzijaID
            // 
            this.RecenzijaID.DataPropertyName = "RecenzijaID";
            this.RecenzijaID.HeaderText = "ID";
            this.RecenzijaID.MinimumWidth = 6;
            this.RecenzijaID.Name = "RecenzijaID";
            this.RecenzijaID.ReadOnly = true;
            this.RecenzijaID.Visible = false;
            this.RecenzijaID.Width = 125;
            // 
            // Vrsta
            // 
            this.Vrsta.DataPropertyName = "VrstaUsluga";
            this.Vrsta.HeaderText = "Vrsta";
            this.Vrsta.MinimumWidth = 6;
            this.Vrsta.Name = "Vrsta";
            this.Vrsta.ReadOnly = true;
            this.Vrsta.Width = 125;
            // 
            // Relacija
            // 
            this.Relacija.DataPropertyName = "RasporedVoznje";
            this.Relacija.HeaderText = "Relacija";
            this.Relacija.MinimumWidth = 6;
            this.Relacija.Name = "Relacija";
            this.Relacija.ReadOnly = true;
            this.Relacija.Width = 125;
            // 
            // DatumRecenzije
            // 
            this.DatumRecenzije.DataPropertyName = "DatumRecenzije";
            this.DatumRecenzije.HeaderText = "Datum  recenzije";
            this.DatumRecenzije.MinimumWidth = 6;
            this.DatumRecenzije.Name = "DatumRecenzije";
            this.DatumRecenzije.ReadOnly = true;
            this.DatumRecenzije.Width = 125;
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.MinimumWidth = 6;
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            this.Ocjena.Width = 125;
            // 
            // Komentar
            // 
            this.Komentar.DataPropertyName = "Komentar";
            this.Komentar.HeaderText = "Komentar";
            this.Komentar.MinimumWidth = 6;
            this.Komentar.Name = "Komentar";
            this.Komentar.ReadOnly = true;
            this.Komentar.Width = 125;
            // 
            // frmRecenzija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvRecenzije);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.nmOcjena);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRecenzija";
            this.Text = "frmRecenzija";
            this.Load += new System.EventHandler(this.frmRecenzija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmOcjena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecenzije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmOcjena;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.DataGridView dgvRecenzije;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecenzijaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrsta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Relacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRecenzije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Komentar;
    }
}