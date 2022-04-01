
using System.Collections.Generic;

namespace eAutobus.WinUI.Reports
{
    partial class PregledKorisnikaReportView
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.KorisniciPrikazListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KorisnikModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.KorisnikModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KorisniciPrikazListBindingSource)).BeginInit();

            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsKorisnici";
            reportDataSource1.Value = this.KorisnikModelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "eAutobus.WinUI.Reports.rptKorisnici.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(906, 505);
            this.reportViewer1.TabIndex = 0;
            // 
            // KorisnikModelBindingSource
            // 
            this.KorisnikModelBindingSource.DataSource = typeof(eAutobusModel.KorisnikModel);
            // 
            // PregledKorisnikaReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 505);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PregledKorisnikaReportView";
            this.Text = "PregledKorisnikaReportView";
            this.Load += new System.EventHandler(this.PregledKorisnikaReportView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KorisnikModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KorisniciPrikazListBindingSource)).EndInit();

            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KorisnikModelBindingSource;
        private System.Windows.Forms.BindingSource KorisniciPrikazListBindingSource;
    }
}