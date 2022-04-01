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
    public partial class PregledCjenovnika : Form
    {
        public IEnumerable<CjenovnikModel> _cjenovnik;
        public PregledCjenovnika(IEnumerable<CjenovnikModel> cjenovnik)
        {
            _cjenovnik = cjenovnik;
            InitializeComponent();
        }

        private void PregledCjenovnika_Load(object sender, EventArgs e)
        {
            CjenovnikModelBindingSource.DataSource = _cjenovnik;
            this.reportViewer1.RefreshReport();
        }
    }
}
