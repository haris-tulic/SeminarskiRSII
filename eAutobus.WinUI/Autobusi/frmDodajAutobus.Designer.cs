
namespace eAutobus.WinUI.Autobusi
{
    partial class frmDodajAutobus
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
            this.txtBrojAutobusa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrojSjedista = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarkaAutobusa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDatumProizvodnje = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbIspravan = new System.Windows.Forms.CheckBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.cbGaraza = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvPrikazAutobusa = new System.Windows.Forms.DataGridView();
            this.AutobusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojAutobusa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkaAutobusa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumProizvodnje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojSjedista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivGaraze = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ispravan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazAutobusa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBrojAutobusa
            // 
            this.txtBrojAutobusa.Location = new System.Drawing.Point(40, 65);
            this.txtBrojAutobusa.Name = "txtBrojAutobusa";
            this.txtBrojAutobusa.Size = new System.Drawing.Size(222, 20);
            this.txtBrojAutobusa.TabIndex = 0;
            this.txtBrojAutobusa.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrojAutobusa_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Broj autobusa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Broj sjedista:";
            // 
            // txtBrojSjedista
            // 
            this.txtBrojSjedista.Location = new System.Drawing.Point(447, 65);
            this.txtBrojSjedista.Name = "txtBrojSjedista";
            this.txtBrojSjedista.Size = new System.Drawing.Size(222, 20);
            this.txtBrojSjedista.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Marka autobusa:";
            // 
            // txtMarkaAutobusa
            // 
            this.txtMarkaAutobusa.Location = new System.Drawing.Point(40, 136);
            this.txtMarkaAutobusa.Name = "txtMarkaAutobusa";
            this.txtMarkaAutobusa.Size = new System.Drawing.Size(222, 20);
            this.txtMarkaAutobusa.TabIndex = 4;
            this.txtMarkaAutobusa.Validating += new System.ComponentModel.CancelEventHandler(this.txtMarkaAutobusa_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Garaza:";
            // 
            // dtpDatumProizvodnje
            // 
            this.dtpDatumProizvodnje.Location = new System.Drawing.Point(447, 152);
            this.dtpDatumProizvodnje.Name = "dtpDatumProizvodnje";
            this.dtpDatumProizvodnje.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumProizvodnje.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Datum proizvodnje:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ispravan";
            // 
            // cbIspravan
            // 
            this.cbIspravan.AutoSize = true;
            this.cbIspravan.Location = new System.Drawing.Point(463, 234);
            this.cbIspravan.Name = "cbIspravan";
            this.cbIspravan.Size = new System.Drawing.Size(15, 14);
            this.cbIspravan.TabIndex = 15;
            this.cbIspravan.UseVisualStyleBackColor = true;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(331, 282);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 16;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // cbGaraza
            // 
            this.cbGaraza.FormattingEnabled = true;
            this.cbGaraza.Location = new System.Drawing.Point(40, 218);
            this.cbGaraza.Name = "cbGaraza";
            this.cbGaraza.Size = new System.Drawing.Size(222, 21);
            this.cbGaraza.TabIndex = 17;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // dgvPrikazAutobusa
            // 
            this.dgvPrikazAutobusa.AllowUserToAddRows = false;
            this.dgvPrikazAutobusa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazAutobusa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AutobusID,
            this.BrojAutobusa,
            this.MarkaAutobusa,
            this.DatumProizvodnje,
            this.BrojSjedista,
            this.NazivGaraze,
            this.Ispravan});
            this.dgvPrikazAutobusa.Location = new System.Drawing.Point(12, 331);
            this.dgvPrikazAutobusa.Name = "dgvPrikazAutobusa";
            this.dgvPrikazAutobusa.ReadOnly = true;
            this.dgvPrikazAutobusa.Size = new System.Drawing.Size(745, 259);
            this.dgvPrikazAutobusa.TabIndex = 18;
            // 
            // AutobusID
            // 
            this.AutobusID.DataPropertyName = "AutobusID";
            this.AutobusID.HeaderText = "ID";
            this.AutobusID.Name = "AutobusID";
            this.AutobusID.ReadOnly = true;
            this.AutobusID.Visible = false;
            // 
            // BrojAutobusa
            // 
            this.BrojAutobusa.DataPropertyName = "BrojAutobusa";
            this.BrojAutobusa.HeaderText = "Broj autobusa";
            this.BrojAutobusa.Name = "BrojAutobusa";
            this.BrojAutobusa.ReadOnly = true;
            // 
            // MarkaAutobusa
            // 
            this.MarkaAutobusa.DataPropertyName = "MarkaAutobusa";
            this.MarkaAutobusa.HeaderText = "Marka";
            this.MarkaAutobusa.Name = "MarkaAutobusa";
            this.MarkaAutobusa.ReadOnly = true;
            // 
            // DatumProizvodnje
            // 
            this.DatumProizvodnje.DataPropertyName = "DatumProizvodnje";
            this.DatumProizvodnje.HeaderText = "Datum proizvodnje";
            this.DatumProizvodnje.Name = "DatumProizvodnje";
            this.DatumProizvodnje.ReadOnly = true;
            // 
            // BrojSjedista
            // 
            this.BrojSjedista.DataPropertyName = "BrojSjedista";
            this.BrojSjedista.HeaderText = "Broj sjedista";
            this.BrojSjedista.Name = "BrojSjedista";
            this.BrojSjedista.ReadOnly = true;
            // 
            // NazivGaraze
            // 
            this.NazivGaraze.DataPropertyName = "NazivGaraze";
            this.NazivGaraze.HeaderText = "Garaza";
            this.NazivGaraze.Name = "NazivGaraze";
            this.NazivGaraze.ReadOnly = true;
            // 
            // Ispravan
            // 
            this.Ispravan.DataPropertyName = "Ispravan";
            this.Ispravan.HeaderText = "Ispravan";
            this.Ispravan.Name = "Ispravan";
            this.Ispravan.ReadOnly = true;
            this.Ispravan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ispravan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmDodajAutobus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 602);
            this.Controls.Add(this.dgvPrikazAutobusa);
            this.Controls.Add(this.cbGaraza);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.cbIspravan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDatumProizvodnje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMarkaAutobusa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBrojSjedista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrojAutobusa);
            this.Name = "frmDodajAutobus";
            this.Text = "frmDodajAutobus";
            this.Load += new System.EventHandler(this.frmDodajAutobus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazAutobusa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrojAutobusa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrojSjedista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarkaAutobusa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDatumProizvodnje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbIspravan;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.ComboBox cbGaraza;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridView dgvPrikazAutobusa;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutobusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojAutobusa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkaAutobusa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumProizvodnje;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojSjedista;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivGaraze;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ispravan;
    }
}