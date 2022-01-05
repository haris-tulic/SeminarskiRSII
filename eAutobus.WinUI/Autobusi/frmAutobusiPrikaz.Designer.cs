
namespace eAutobus.WinUI.Autobusi
{
    partial class frmAutobusiPrikaz
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAutobusi = new System.Windows.Forms.DataGridView();
            this.AutobusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkaAutobusa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojSjedista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumProizvodnje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivGaraze = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ispravan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Akcija = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.txtMarkaVozila = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutobusi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAutobusi);
            this.groupBox1.Location = new System.Drawing.Point(9, 188);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(782, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Autobusi";
            // 
            // dgvAutobusi
            // 
            this.dgvAutobusi.AllowUserToAddRows = false;
            this.dgvAutobusi.AllowUserToDeleteRows = false;
            this.dgvAutobusi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutobusi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AutobusID,
            this.MarkaAutobusa,
            this.BrojSjedista,
            this.DatumProizvodnje,
            this.NazivGaraze,
            this.Ispravan,
            this.Akcija});
            this.dgvAutobusi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAutobusi.Location = new System.Drawing.Point(2, 15);
            this.dgvAutobusi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAutobusi.Name = "dgvAutobusi";
            this.dgvAutobusi.ReadOnly = true;
            this.dgvAutobusi.RowHeadersWidth = 51;
            this.dgvAutobusi.RowTemplate.Height = 24;
            this.dgvAutobusi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutobusi.Size = new System.Drawing.Size(778, 281);
            this.dgvAutobusi.TabIndex = 0;
            this.dgvAutobusi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvAutobusi_MouseDoubleClick);
            // 
            // AutobusID
            // 
            this.AutobusID.DataPropertyName = "AutobusID";
            this.AutobusID.HeaderText = "AutobusID";
            this.AutobusID.MinimumWidth = 6;
            this.AutobusID.Name = "AutobusID";
            this.AutobusID.ReadOnly = true;
            this.AutobusID.Visible = false;
            this.AutobusID.Width = 125;
            // 
            // MarkaAutobusa
            // 
            this.MarkaAutobusa.DataPropertyName = "MarkaAutobusa";
            this.MarkaAutobusa.HeaderText = "Marka autobusa";
            this.MarkaAutobusa.MinimumWidth = 6;
            this.MarkaAutobusa.Name = "MarkaAutobusa";
            this.MarkaAutobusa.ReadOnly = true;
            this.MarkaAutobusa.Width = 125;
            // 
            // BrojSjedista
            // 
            this.BrojSjedista.DataPropertyName = "BrojSjedista";
            this.BrojSjedista.HeaderText = "Broj sjedista";
            this.BrojSjedista.MinimumWidth = 6;
            this.BrojSjedista.Name = "BrojSjedista";
            this.BrojSjedista.ReadOnly = true;
            this.BrojSjedista.Width = 125;
            // 
            // DatumProizvodnje
            // 
            this.DatumProizvodnje.DataPropertyName = "DatumProizvodnje";
            this.DatumProizvodnje.HeaderText = "Datum proizvodnje";
            this.DatumProizvodnje.MinimumWidth = 6;
            this.DatumProizvodnje.Name = "DatumProizvodnje";
            this.DatumProizvodnje.ReadOnly = true;
            this.DatumProizvodnje.Width = 125;
            // 
            // NazivGaraze
            // 
            this.NazivGaraze.DataPropertyName = "NazivGaraze";
            this.NazivGaraze.HeaderText = "Garaza";
            this.NazivGaraze.MinimumWidth = 6;
            this.NazivGaraze.Name = "NazivGaraze";
            this.NazivGaraze.ReadOnly = true;
            this.NazivGaraze.Width = 125;
            // 
            // Ispravan
            // 
            this.Ispravan.DataPropertyName = "Ispravan";
            this.Ispravan.HeaderText = "Ispravan";
            this.Ispravan.MinimumWidth = 6;
            this.Ispravan.Name = "Ispravan";
            this.Ispravan.ReadOnly = true;
            this.Ispravan.Width = 125;
            // 
            // Akcija
            // 
            this.Akcija.HeaderText = "Akcija";
            this.Akcija.Name = "Akcija";
            this.Akcija.ReadOnly = true;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(374, 127);
            this.btnPrikazi.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(99, 32);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Pretraga";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // txtMarkaVozila
            // 
            this.txtMarkaVozila.Location = new System.Drawing.Point(331, 76);
            this.txtMarkaVozila.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarkaVozila.Name = "txtMarkaVozila";
            this.txtMarkaVozila.Size = new System.Drawing.Size(189, 20);
            this.txtMarkaVozila.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marka vozila:";
            // 
            // frmAutobusiPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMarkaVozila);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAutobusiPrikaz";
            this.Text = "frmAutobusi";
            this.Load += new System.EventHandler(this.frmAutobusiPrikaz_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutobusi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAutobusi;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.TextBox txtMarkaVozila;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutobusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkaAutobusa;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojSjedista;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumProizvodnje;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivGaraze;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ispravan;
        private System.Windows.Forms.DataGridViewButtonColumn Akcija;
    }
}