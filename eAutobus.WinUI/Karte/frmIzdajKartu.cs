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
        private readonly APIService _cjenovnik = new APIService("Cjenovnik");
        private CjenovnikSearchRequest CijenaKarte = new CjenovnikSearchRequest();
        double CijenaK;
        KartaUpsertRequest insert = new KartaUpsertRequest();

        public frmIzdajKartu()
        {
            InitializeComponent();
        }

        
        private async void frmIzdajKartu_Load(object sender, EventArgs e)
        {
            await LoadVrstaKarte();
            await LoadTipkarte();
            await LoadPolazisteOdrediste();
            //await LoadVrstaITipKarte();
        }

        private async Task LoadVrstaITipKarte()
        {
            var listVT = await _cjenovnik.Get <List<CjenovnikModel>>(null);
            cbVrstaKarte.DataSource = listVT;
            cbTipKarte.DataSource = listVT;

            cbVrstaKarte.DisplayMember = "VrstaKarte";
            cbVrstaKarte.ValueMember = "VrstaKarteID";

            cbTipKarte.DisplayMember = "TipKarte";
            cbTipKarte.ValueMember = "TipKarteID";
        }



        private async Task LoadPolazisteOdrediste()
        {
            var listP = await _stanice.Get<List<StanicaModel>>(null);
            cbPolaziste.DataSource = listP;
            cbPolaziste.ValueMember = "StanicaID";
            cbPolaziste.DisplayMember = "NazivLokacijeStanice";

            var listO = await _stanice.Get<List<StanicaModel>>(null);
            cbOdrediste.DataSource = listO;
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
            if (this.ValidateChildren())
            {
                insert.Ime = txtIme.Text;
                insert.Prezime = txtPrezime.Text;
                insert.AdresaStanovanja = txtAdresa.Text;
                //insert.Email = txtEmail.Text;
                insert.VrstaKarteID = int.Parse(cbVrstaKarte.SelectedValue.ToString());
                insert.TipKarteID = int.Parse(cbTipKarte.SelectedValue.ToString());
                insert.PolazisteID = int.Parse(cbPolaziste.SelectedValue.ToString());
                insert.OdredisteID = int.Parse(cbOdrediste.SelectedValue.ToString());
                insert.DatumVadjenjaKarte = dtpDatumVadjenja.Value;
                insert.DatumVazenjaKarte = dtpDatumVazenja.Value;
                insert.Cijena = CijenaK;
                insert.BrojTelefona = txtBrojTelefona.Text;
                insert.NacinPlacanja = "Preuzećem";
                if (rbJedan.Checked)
                {
                    insert.Pravac = rbJedan.Checked;
                    insert.PravacS = rbJedan.Text;

                }
                else if(rbDva.Checked)
                {
                    insert.Pravac = rbDva.Checked;
                    insert.PravacS = rbDva.Text;

                    insert.Cijena*=1.67;
                }
                await _karta.Insert<KartaModel>(insert);
                MessageBox.Show("Karta je izdata!");
            }
        }

        private void cbVrstaKarte_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obj = cbVrstaKarte.SelectedValue;
            int.TryParse(obj.ToString(), out int id);
            CijenaKarte.VrstaKarteID = id;
            var check = this.cbVrstaKarte.GetItemText(this.cbVrstaKarte.SelectedItem);
            if (check.Contains("Mjesečna") || check.Contains("Godišnja") )
            {
                rbJedan.Enabled = false;
                rbDva.Enabled = false;
                //rbJedan.Visible = false;
                //rbDva.Visible = false;
            }
            else
            {
                rbJedan.Enabled = true;
                rbDva.Enabled = true;
                rbJedan.Visible = true;
                rbDva.Visible = true;

            }

        }

        private void cbTipKarte_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obj = cbTipKarte.SelectedValue;
            int.TryParse(obj.ToString(), out int id);
            CijenaKarte.TipkarteID = id;
          
        }
        private void cbPolaziste_SelectedIndexChanged(object sender, EventArgs e)
        {

            var obj = cbPolaziste.SelectedValue;
            int.TryParse(obj.ToString(), out int id);
            CijenaKarte.PolazisteID = id;
        }
        private void cbOdrediste_SelectedIndexChanged(object sender, EventArgs e)
        {

            var obj = cbOdrediste.SelectedValue;
            int.TryParse(obj.ToString(), out int id);
            CijenaKarte.OdredisteID = id;
        }
        private async  void txtCijena_Click(object sender,EventArgs e)
        {
             var cijena =await _cjenovnik.Get<List<CjenovnikModel>>(CijenaKarte);
            foreach (var x in cijena)
            {
                CijenaK = x.Cijena;
                txtCijena.Text = x.Cijena.ToString()+" KM";
            
            }
          
        }

        private void frmIzdajKartu_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBrojTelefona.Text))
            {
                errorProvider.SetError(txtBrojTelefona, "Obavezno polje!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtBrojTelefona, null);
            }
        }

        private  void btnPreuzmiPDF_Click(object sender, EventArgs e)
        {
            
            var kartaPrikaz = new IzvjestajIzdanaKartaModel
            {
                ImePrezime = txtIme.Text + " " + txtPrezime.Text,
                AdresaStanovanja = txtAdresa.Text,
                VrstaKarte =cbVrstaKarte.Text,
                TipKarte = cbTipKarte.Text,
                DatumVadjenja = dtpDatumVadjenja.Value,
                DatumVazenja = dtpDatumVazenja.Value,
                Polaziste = cbPolaziste.Text ,
                Odrediste = cbOdrediste.Text ,
                Cijena =txtCijena.Text,
            };
            if (rbJedan.Checked)
            {
                kartaPrikaz.Pravac = rbJedan.Text;

            }
            else
            {
                kartaPrikaz.Pravac = rbDva.Text;
            }
            Reports.IzdanaKartaReportView rpt = new Reports.IzdanaKartaReportView(kartaPrikaz);
            rpt.Show();
        }

        private void rbDva_MouseClick(object sender, MouseEventArgs e)
        {
            var cijenaPrikaz=CijenaK * 1.67;
            txtCijena.Text = cijenaPrikaz.ToString() + " KM";
        }

        private void rbJedan_MouseClick(object sender, MouseEventArgs e)
        {
            var cijenaPrikaz = CijenaK;
            txtCijena.Text = cijenaPrikaz.ToString() + " KM";
        }
    }
}
