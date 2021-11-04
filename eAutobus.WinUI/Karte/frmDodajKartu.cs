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

        public frmDodajKartu()
        {
            InitializeComponent();
        }

        private async void frmDodajKartu_Load(object sender, EventArgs e)
        {
            await LoadTipKarte();
            await LoadVrstuKarte();
            await LoadZonu();
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
                newKarta.TipkarteID = int.Parse(cbTipKarte.SelectedItem.ToString());
                newKarta.VrstakarteID = int.Parse(cbVrstaKarte.SelectedItem.ToString());
                newKarta.ZonaID = int.Parse(cbZona.SelectedItem.ToString());
                newKarta.Cijena = float.Parse(txtCijena.Text);

                await _cjenovnik.Insert<CjenovnikModel>(newKarta);
            }
            MessageBox.Show("Dodana nova karta!");
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
    }
}
