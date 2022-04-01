using eAutobusModel;
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
    public partial class PregledKorisnikaReportView : Form
    {
        public IEnumerable<KorisnikModel> prikazKorisnika;
        List<object> prikaz=new List<object>();
        
        public PregledKorisnikaReportView(List<KorisnikModel> korisnici)
        {
            prikazKorisnika = korisnici;
            InitializeComponent();
        }

        private void PregledKorisnikaReportView_Load(object sender, EventArgs e)
        {
            //ReportDataSource source = new ReportDataSource("dsKorisnici", prikazKorisnika);
            //this.reportViewer1.LocalReport.DataSources.Add(source);

            KorisnikModelBindingSource.DataSource = prikazKorisnika;
            this.reportViewer1.RefreshReport();




        }
    }
}
