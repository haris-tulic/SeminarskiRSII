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
    public partial class frmKorisniciDodajRegistracija : Form
    {
        private readonly APIService _korisnikService = new APIService("Korisnik");
        private KorisnikUpsertRequest _korisnik = new KorisnikUpsertRequest();
        public frmKorisniciDodajRegistracija(KorisnikUpsertRequest korisnik)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }

        private async void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if (_korisnik!=null)
            {
                _korisnik.KorisnickoIme = txtKorisnickoIme.Text;
                _korisnik.Password = txtPassword.Text;
                _korisnik.PasswordPotrvda = txtConfirmPassword.Text;
                if (_korisnik.KorisnikID.HasValue)
                {
                    await _korisnikService.Update<KorisnikModel>(_korisnik.KorisnikID, _korisnik);
                    MessageBox.Show("Korisnik je izmjenjen!");
                }
                else
                {
                    await _korisnikService.Insert<KorisnikModel>(_korisnik);
                    MessageBox.Show("Novi korisnik uspjesno dodan!");
                    this.Close();
                }
            }
        }

        private async void frmKorisniciDodajRegistracija_Load(object sender, EventArgs e)
        {
            if (_korisnik.KorisnikID.HasValue)
            {
                var entity = await _korisnikService.GetById<KorisnikModel>(_korisnik.KorisnikID);
                if (entity != null)
                {
                    txtKorisnickoIme.Text = entity.KorisnickoIme;
                }
            }
          
        }
    }
}
