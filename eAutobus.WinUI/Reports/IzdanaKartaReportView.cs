using eAutobusModel;
using eAutobusModel.Requests;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAutobus.WinUI.Reports
{
    public partial class IzdanaKartaReportView : Form
    {
        public IzvjestajIzdanaKartaModel _karta;
        public IzdanaKartaReportView(IzvjestajIzdanaKartaModel karta)
        {
            _karta = karta;
            InitializeComponent();
        }

        private void IzdanaKartaReportView_Load(object sender, EventArgs e)
        {

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("ImeIPrezime", _karta.ImePrezime));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("AdresaStanovanja", _karta.AdresaStanovanja));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("VrstaKarte", _karta.VrstaKarte));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("TipKarte", _karta.TipKarte));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Polaziste", _karta.Polaziste));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Odrediste", _karta.Odrediste));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("DatumVadjenjaKarte", _karta.DatumVadjenja.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("DatumVazenjaKarte", _karta.DatumVazenja.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Pravac", _karta.Pravac));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Cijena", _karta.Cijena));

            this.reportViewer1.RefreshReport();
        }
    }
}
