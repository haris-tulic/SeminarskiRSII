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
        public List<RasporedVoznjeModel> _prikazLinija;

        public frmPregledRedaVoznji()
        {
            InitializeComponent();
        }

        private async void frmPregledRedaVoznji_Load(object sender, EventArgs e)
        {
            await LoadStanice();
            await LoadRedVoznje();
        }

        private async Task LoadRedVoznje()
        {
            var result = await _linije.Get<List<RasporedVoznjeModel>>(null);
            _prikazLinija = result;
            dgvLinije.AutoGenerateColumns = false;
            dgvLinije.DataSource = result;
           

        }

        private async Task LoadStanice()
        {
            var result = await _stanice.Get<List<StanicaModel>>(null);
            result.Insert(0, new StanicaModel { });
            cbPolaziste.DataSource = result;
            cbPolaziste.ValueMember = "StanicaID";
            cbPolaziste.DisplayMember = "NazivLokacijeStanice";

            var entity = await _stanice.Get<List<StanicaModel>>(null);
            entity.Insert(0, new StanicaModel { });
            cbOdrediste.DataSource = entity;
            cbOdrediste.ValueMember = "StanicaID";
            cbOdrediste.DisplayMember = "NazivLokacijeStanice";
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var search = new RasporedVoznjeGetRequest()
            {
                PolazisteID = int.Parse(cbPolaziste.SelectedValue.ToString()),
                OdredisteID = int.Parse(cbOdrediste.SelectedValue.ToString()),
                Datum= dtpDatum.Value.Date,
               
            };
            var result =await _linije.Get<List<RasporedVoznjeModel>>(search);
            dgvLinije.AutoGenerateColumns = false;
            dgvLinije.DataSource = result;
        }

        private async void dgvLinije_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var RedVoznjeID = dgvLinije.SelectedRows[0].Cells[0].Value;
            var odabranaLinija = await _linije.GetById<RasporedVoznjeModel>(RedVoznjeID);
            if (dgvLinije.CurrentCell is DataGridViewButtonCell)
            {
                await _linije.Delete<RasporedVoznjeModel>(RedVoznjeID);
                MessageBox.Show("Izbrisali ste liniju: "+odabranaLinija.Polazak+"-"+odabranaLinija.Odlazak);
                await LoadRedVoznje();
            }
            else
            {
                frmDodavanjeRedaVoznje frm = new frmDodavanjeRedaVoznje(int.Parse(RedVoznjeID.ToString()));
                frm.Show();
            }
           
        }

        private void dtpDatum_ValueChanged(object sender, EventArgs e)
        {
            dtpDatum.CustomFormat = "dd/MM/yyyy";
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            Reports.PregledLinijaReportView rpt = new Reports.PregledLinijaReportView(_prikazLinija);
            rpt.Show();
        }
    }
}
