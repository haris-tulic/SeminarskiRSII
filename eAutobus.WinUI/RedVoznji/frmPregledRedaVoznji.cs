using eAutobusModel;
using eAutobusModel.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAutobus.WinUI.RedVoznji
{
    public partial class frmPregledRedaVoznji : Form
    {
        private readonly APIService _linije = new APIService("RasporedVoznje");
        private readonly APIService _stanice = new APIService("Stanica");

        public frmPregledRedaVoznji()
        {
            InitializeComponent();
        }

        private async void frmPregledRedaVoznji_Load(object sender, EventArgs e)
        {
            await LoadRedVoznje();
        }

        private async Task LoadRedVoznje()
        {
            await LoadStanice();
            var result = await _linije.Get<List<RasporedVoznjeModel>>(null);
            dgvLinije.AutoGenerateColumns = false;
            dgvLinije.DataSource = result;

        }

        private async Task LoadStanice()
        {
            var result = await _stanice.Get<List<StanicaModel>>(null);
            cbPolaziste.DataSource = result;
            cbPolaziste.ValueMember = "StanicaID";
            cbPolaziste.DisplayMember = "NazivLokacijeStanice";

            var entity = await _stanice.Get<List<StanicaModel>>(null);
            cbOdrediste.DataSource = entity;
            cbOdrediste.ValueMember = "StanicaID";
            cbOdrediste.DisplayMember = "NazivLokacijeStanice";
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            var search = new RasporedVoznjeGetRequest()
            {
                PolazisteID = int.Parse(cbPolaziste.SelectedValue.ToString()),
                OdredisteID = int.Parse(cbOdrediste.SelectedValue.ToString()),
                Datum = dtpDatum.Value
               
            };
            var result = _linije.Get<List<RasporedVoznjeModel>>(search);
            dgvLinije.DataSource = result;
            dgvLinije.AutoGenerateColumns = false;
        }
    }
}
