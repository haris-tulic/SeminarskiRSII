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
        private APIService _korisniciTip = new APIService("Uloge");

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
                UlogaID= int.Parse(cbUloga.SelectedValue.ToString())
            };
            var entity = await _korisnici.Get<List<KorisnikModel>>(search);
            dgvPrikaz.AutoGenerateColumns = false;
            dgvPrikaz.DataSource = entity;
        }

        private async void frmKorisniciPrikaz_Load(object sender, EventArgs e)
        {
            await LoadUloge();
            await LoadKorisnike();
        }

        private async Task LoadKorisnike()
        {
            var list = await _korisnici.Get<List<KorisnikModel>>(null);
            dgvPrikaz.AutoGenerateColumns = false;
            dgvPrikaz.DataSource = list;
        }

        private async Task LoadUloge()
        {
            var list = await _korisniciTip.Get<List<UlogeModel>>(null);
            list.Insert(0, new UlogeModel{});
            cbUloga.DataSource = list;
            cbUloga.DisplayMember = "Naziv";
            cbUloga.ValueMember = "UlogeID";

        }

        private void dgvPrikaz_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var IdKorisnik = dgvPrikaz.SelectedRows[0].Cells[0].Value;
            frmKorisniciDodaj frm = new frmKorisniciDodaj(int.Parse(IdKorisnik.ToString()));
            frm.Show();
        }
    }
}
