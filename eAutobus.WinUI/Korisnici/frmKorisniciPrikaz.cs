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
        public List<KorisnikModel> _korisniciList=new List<KorisnikModel>();
        public KorisnikModel _prikazK { get; set;}

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
            _korisniciList = entity;
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
            foreach (var item in list)
            {
                item.DatumRodjenja.ToString("MM/dd/yyyy");
            }
            _korisniciList = list;
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

        private async void dgvPrikaz_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var IdKorisnik = dgvPrikaz.SelectedRows[0].Cells[0].Value;
            var korisnik =await _korisnici.GetById<KorisnikModel>(IdKorisnik);
            if (dgvPrikaz.CurrentCell is DataGridViewButtonCell && korisnik!=null)
            {
                MessageBox.Show("Da li ste sigurni da želite da izbrišete korisnika " + korisnik.Ime+" "+korisnik.Prezime);
                await _korisnici.Delete<KorisnikModel>(korisnik.KorisnikID);
                await LoadKorisnike();
            }
            else
            {
                frmKorisniciDodaj frm = new frmKorisniciDodaj(int.Parse(IdKorisnik.ToString()));
                frm.Show();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var prikazKorisnika = dgvPrikaz.DataSource as List<KorisnikModel>;
            Reports.PregledKorisnikaReportView rpt= new Reports.PregledKorisnikaReportView(prikazKorisnika);
            rpt.Show();
        }
    }
}
