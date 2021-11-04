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

namespace eAutobus.WinUI.Karte
{
    public partial class frmIzdajKartu : Form
    {
        private readonly APIService _vrstaKarte = new APIService("VrstaKarte");
        private readonly APIService _tipKarte = new APIService("TipKarte");
        private readonly APIService _stanice = new APIService("Stanica");
        private readonly APIService _karta = new APIService("Karta");
        public frmIzdajKartu()
        {
            InitializeComponent();
        }

        
        private async void frmIzdajKartu_Load(object sender, EventArgs e)
        {
            await LoadVrstaKarte();
            await LoadTipkarte();
            await LoadPolazisteOdrediste();

        }

        private async Task LoadPolazisteOdrediste()
        {
            var listP = await _stanice.Get<List<StanicaModel>>(null);
            cbPolaziste.DataSource = listP;
            cbPolaziste.ValueMember = "StanicaID";
            cbPolaziste.DisplayMember = "NazivLokacijeStanice";

            var listO = await _stanice.Get<List<StanicaModel>>(null);
            cbOdrediste.DataSource = listP;
            cbOdrediste.ValueMember = "StanicaID";
            cbOdrediste.DisplayMember = "NazivLokacijeStanice";

        }

        private async Task LoadVrstaKarte()
        {
            var listVK = await _vrstaKarte.Get<List<VrstaKarteModel>>(null);
            cbVrstaKarte.DataSource = listVK;
            cbVrstaKarte.ValueMember = "VrstaKarteID";
            cbVrstaKarte.DisplayMember = "Naziv";
        }

        private async Task LoadTipkarte()
        {
            var listTK = await _tipKarte.Get<List<TipKarteModel>>(null);
            cbTipKarte.DataSource = listTK;
            cbTipKarte.ValueMember = "TipKarteID";
            cbTipKarte.DisplayMember = "Naziv";
        }

        private void txtImePrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                errorProvider.SetError(txtIme, "Obavezno polje!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtIme,null);
            }
        }

        private void txtAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdresa.Text))
            {
                errorProvider.SetError(txtAdresa, "Obavezno polje!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtAdresa, null);
            }
        }

        private void cbVrstaKarte_Validating(object sender, CancelEventArgs e)
        {
            var check = cbVrstaKarte.SelectedItem.ToString();
            if (string.IsNullOrEmpty(check))
            {
                errorProvider.SetError(cbVrstaKarte, "Obavezno polje!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cbVrstaKarte, null);
            }
        }

        private void cbTipKarte_Validating(object sender, CancelEventArgs e)
        {
            var check = cbTipKarte.SelectedItem.ToString();
            if (string.IsNullOrEmpty(check))
            {
                errorProvider.SetError(cbTipKarte, "Obavezno polje!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cbTipKarte, null);
            }
        }

        private void cbPolaziste_Validating(object sender, CancelEventArgs e)
        {
            var check = cbPolaziste.SelectedItem.ToString();
            if (string.IsNullOrEmpty(check))
            {
                errorProvider.SetError(cbPolaziste, "Obavezno polje!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cbPolaziste, null);
            }
        }

        private void cbOdrediste_Validating(object sender, CancelEventArgs e)
        {
            var check = cbOdrediste.SelectedItem.ToString();
            if (string.IsNullOrEmpty(check))
            {
                errorProvider.SetError(cbOdrediste, "Obavezno polje!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cbOdrediste, null);
            }
        }

        private void dtpDatum_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dtpDatumVadjenja.ToString()))
            {
                errorProvider.SetError(dtpDatumVadjenja, "Obavezno polje!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(dtpDatumVadjenja, null);
            }
        }

      

        private async void btnIzdajKartu_Click(object sender, EventArgs e)
        {
            var insert = new KartaUpsertRequest();
            if (this.ValidateChildren())
            {
                insert.Ime = txtIme.Text;
                insert.Prezime = txtPrezime.Text;
                insert.AdresaStanovanja = txtAdresa.Text;
                insert.VrstaKarteID = int.Parse(cbVrstaKarte.SelectedItem.ToString());
                insert.TipKarteID = int.Parse(cbTipKarte.SelectedItem.ToString());
                insert.PolazisteID = int.Parse(cbPolaziste.SelectedItem.ToString());
                insert.OdredisteID = int.Parse(cbOdrediste.SelectedItem.ToString());
                insert.DatumVadjenjaKarte = dtpDatumVadjenja.Value;
                insert.DatumVazenjaKarte = dtpDatumVazenja.Value;
                if (rbJedan.Checked)
                {
                    insert.Pravac = rbJedan.Checked;
                }
                else
                {
                    insert.Pravac = rbDva.Checked;
                }
                await _karta.Insert<KartaModel>(insert);
                MessageBox.Show("Karta je izdata!");
            }
        }
    }
}
