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
    public partial class PregledLinijaReportView : Form
    {
        public List<RasporedVoznjeModel> _linije;
        public PregledLinijaReportView(List<RasporedVoznjeModel>linije)
        {
            _linije = linije;
            InitializeComponent();
        }

        private void PregledLinijaReportView_Load(object sender, EventArgs e)
        {
            RasporedVoznjeModelBindingSource.DataSource = _linije;
            this.reportViewer1.RefreshReport();
        }
    }
}
