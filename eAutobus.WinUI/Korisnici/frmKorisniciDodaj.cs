﻿using eAutobusModel;
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
    public partial class frmKorisniciDodaj : Form
    {
        private readonly APIService _tipK = new APIService("TipKorisnik");
        private readonly APIService _korisnik = new APIService("Korisnik");
        private readonly APIService _grad = new APIService("Grad");
        private int? id = null;
        public frmKorisniciDodaj(int? updateID=null)
        {
            id = updateID;
            InitializeComponent();
        }

         private async void frmKorisniciDodaj_Load(object sender, EventArgs e)
        {
       
            await LoadKorisnika();
            await LoadGrad();
        }

        private async Task LoadGrad()
        {
            var listG = await _grad.Get<List<GradModel>>(null);
            cmbGrad.DataSource = listG;
            cmbGrad.ValueMember = "GradID";
            cmbGrad.DisplayMember = "NazivGrada";
        }

        private async Task LoadKorisnika()
        {
            var listTipK = await _tipK.Get<List<TipKorisnikaModel>>(null);
            cmbTipKorisnika.DataSource = listTipK;
            cmbTipKorisnika.ValueMember = "TipKorisnikaID";
            cmbTipKorisnika.DisplayMember = "Naziv";
        }

        

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                errorKorisnik.SetError(txtIme, "Obavezno polje!");
                e.Cancel = true;
            }
            else
            {
                errorKorisnik.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrezime.Text))
            {
                errorKorisnik.SetError(txtPrezime, "Obavezno polje!");
                e.Cancel = true;
            }
            else
            {
                errorKorisnik.SetError(txtPrezime, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorKorisnik.SetError(txtEmail, "Obavezno polje!");
                e.Cancel = true;
            }
            else
            {
                errorKorisnik.SetError(txtEmail, null);
            }
        }

        private void dtpDatumRodjenja_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(dtpDatumRodjenja.Text))
            {
                errorKorisnik.SetError(dtpDatumRodjenja, "Obavezno polje!");
                e.Cancel = true;
            }
            else
            {
                errorKorisnik.SetError(dtpDatumRodjenja, null);
            }
        }

        private void txtBrojTelefona_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBrojTelefona.Text))
            {
                errorKorisnik.SetError(txtBrojTelefona, "Obavezno polje!");
                e.Cancel = true;
            }
            else
            {
                errorKorisnik.SetError(txtBrojTelefona, null);
            }
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var entity = new KorisnikUpsertRequest();
            if (this.ValidateChildren())
            {
                entity.Ime = txtIme.Text;
                entity.Prezime = txtPrezime.Text;
                entity.Email = txtEmail.Text;
                entity.DatumRodjenja = dtpDatumRodjenja.Value;
                entity.BrojTelefona = txtBrojTelefona.Text;
                entity.AdresaStanovanja = txtAdresaStanovanja.Text;
                entity.GradID = int.Parse(cmbGrad.SelectedValue.ToString());
                entity.TipKorisnikaID = int.Parse(cmbTipKorisnika.SelectedValue.ToString());
            }
            if (id.HasValue)
            {
                await _korisnik.Update<KorisnikModel>(entity,id);
                MessageBox.Show("Korisnik je izmjenjen!");
            }
            else
            {
                await _korisnik.Insert<KorisnikModel>(entity);
                MessageBox.Show("Novi korisnik uspjesno dodan!");
            }
        }
    }
}
