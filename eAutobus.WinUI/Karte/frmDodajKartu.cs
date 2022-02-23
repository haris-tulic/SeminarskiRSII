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
    public partial class frmDodajKartu : Form
    {
        private readonly APIService _tipKarte = new APIService("TipKarte");
        private readonly APIService _vrstaKarte = new APIService("VrstaKarte");
        private readonly APIService _zona = new APIService("Zona");
        private readonly APIService _cjenovnik = new APIService("Cjenovnik");
        private readonly APIService _stanice = new APIService("Stanica");
        private int? id;
        public frmDodajKartu(int ?kartaID=null)
        {
            InitializeComponent();
            id = kartaID;
        }

        private async void frmDodajKartu_Load(object sender, EventArgs e) 
        {
            await LoadTipKarte();
            await LoadVrstuKarte();
            await LoadZonu();
            await LoadPolazisteIOdrediste();
            if (id.HasValue)
            {
                var karta=await _cjenovnik.GetById<CjenovnikModel>(id);
                cbTipKarte.SelectedValue = karta.TipkarteID;
                cbVrstaKarte.SelectedValue = karta.VrstaKarteID;
                cbZona.SelectedValue = karta.ZonaID;
                txtCijena.Text = karta.Cijena.ToString();
                cmbPolaziste.SelectedValue = karta.PolazisteID;
                cmbOdrediste.SelectedValue = karta.OdredisteID;
            }
        }

        private async Task LoadPolazisteIOdrediste()
        {
            var result = await _stanice.Get<List<StanicaModel>>(null);
            cmbPolaziste.DataSource = result;
            cmbPolaziste.ValueMember = "StanicaID";
            cmbPolaziste.DisplayMember = "NazivLokacijeStanice";

            var entity = await _stanice.Get<List<StanicaModel>>(null);
            cmbOdrediste.DataSource = entity;
            cmbOdrediste.ValueMember = "StanicaID";
            cmbOdrediste.DisplayMember = "NazivLokacijeStanice";

        }

        private async Task LoadZonu()
        {
            var zone = await _zona.Get<List<ZonaModel>>(null);
            cbZona.DataSource = zone;
            cbZona.ValueMember = "ZonaID";
            cbZona.DisplayMember = "OznakaZone";
        }

        private async Task LoadVrstuKarte()
        {
            var vrsteKarata = await _vrstaKarte.Get<List<VrstaKarteModel>>(null);
            cbVrstaKarte.DataSource = vrsteKarata;
            cbVrstaKarte.ValueMember = "VrstaKarteID";
            cbVrstaKarte.DisplayMember = "Naziv";
        }

        private async Task LoadTipKarte()
        {
            var tipKarata = await _tipKarte.Get<List<TipKarteModel>>(null);
            cbTipKarte.DataSource = tipKarata;
            cbTipKarte.ValueMember = "TipKarteID";
            cbTipKarte.DisplayMember = "Naziv";
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var newKarta = new CjenovnikInsertRequest();
                newKarta.TipkarteID = int.Parse(cbTipKarte.SelectedValue.ToString());
                newKarta.VrstakarteID = int.Parse(cbVrstaKarte.SelectedValue.ToString());
                newKarta.ZonaID = int.Parse(cbZona.SelectedValue.ToString());
                newKarta.Cijena = double.Parse(txtCijena.Text);
                newKarta.PolazisteID = int.Parse(cmbPolaziste.SelectedValue.ToString());
                newKarta.OdredisteID = int.Parse(cmbOdrediste.SelectedValue.ToString());
                if (id.HasValue)
                {
                    await _cjenovnik.Update<CjenovnikModel>(id, newKarta);
                    MessageBox.Show("Izmjenjena karta!");

                }
                else
                {
                    await _cjenovnik.Insert<CjenovnikModel>(newKarta);
                    MessageBox.Show("Dodana nova karta!");

                }
            }
        }

        private void cbTipKarte_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbTipKarte.SelectedItem.ToString()))
            {
                errorProvider.SetError(cbTipKarte, "Obavezno polje!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cbTipKarte, null);
            }
        }

        private void cbVrstaKarte_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbVrstaKarte.SelectedItem.ToString()))
            {
                errorProvider.SetError(cbVrstaKarte, "Obavezno polje!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cbVrstaKarte, null);
            }
        }

        private void cbZona_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbZona.SelectedItem.ToString()))
            {
                errorProvider.SetError(cbZona, "Obavezno polje!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cbZona, null);
            }
        }

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCijena.Text))
            {
                errorProvider.SetError(txtCijena, "Obavezno polje!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtCijena, null);
            }
        }

        private void cmbPolaziste_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbPolaziste.SelectedItem.ToString()))
            {
                errorProvider.SetError(cbZona, "Obavezno polje!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cbZona, null);
            }
        }

        private void cmbOdrediste_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbOdrediste.SelectedItem.ToString()))
            {
                errorProvider.SetError(cbZona, "Obavezno polje!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cbZona, null);
            }
        }
    }
}
