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

namespace eAutobus.WinUI.Korisnici
{
    public partial class frmKorisniciPrikaz : Form
    {
        private APIService _korisnici = new APIService("Korisnik");
        private APIService _korisniciTip = new APIService("TipKorisnik");

        public frmKorisniciPrikaz()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new KorisnikGetRequest
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                TipKorisnikaID= int.Parse(cbTipKorisnika.SelectedValue.ToString())
            };
            var entity = await _korisnici.Get<List<KorisnikModel>>(search);
            dgvPrikaz.AutoGenerateColumns = false;
            dgvPrikaz.DataSource = entity;
        }

        private async void frmKorisniciPrikaz_Load(object sender, EventArgs e)
        {
            await LoadTipKorisnika();
            await LoadKorisnike();
        }

        private async Task LoadKorisnike()
        {
            var list = await _korisnici.Get<List<KorisnikModel>>(null);
            dgvPrikaz.AutoGenerateColumns = false;
            dgvPrikaz.DataSource = list;
        }

        private async Task LoadTipKorisnika()
        {
            var list = await _korisniciTip.Get<List<TipKorisnikaModel>>(null);
            list.Insert(0, new TipKorisnikaModel { });
            cbTipKorisnika.DataSource = list;
            cbTipKorisnika.DisplayMember = "Naziv";
            cbTipKorisnika.ValueMember = "TipKorisnikaID";

        }

        private void dgvPrikaz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
