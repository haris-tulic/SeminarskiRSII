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
    public partial class frmPrikazKarata : Form
    {
        private readonly APIService _tipKarte = new APIService("TipKarte");
        private readonly APIService _zone = new APIService("Zona");
        private readonly APIService _cjenovnik = new APIService("Cjenovnik");
        private int? ID;
        public frmPrikazKarata(int?id=null)
        {
            InitializeComponent();
            ID = id;
        }

        private async void frmPrikazKarata_Load(object sender, EventArgs e)
        {
            await LoadTipKarte();
            await LoadZona();
        }

        private async Task LoadTipKarte()
        {
            var listT = await _tipKarte.Get<List<TipKarteModel>>(null);
            cbTip.DataSource = listT;
            cbTip.ValueMember = "TipKarteID";
            cbTip.DisplayMember = "Naziv";
        }

        private async Task LoadZona()
        {
            var listZ = await _zone.Get<List<ZonaModel>>(null);
            cbZona.DataSource = listZ;
            cbZona.ValueMember = "ZonaID";
            cbZona.DisplayMember = "OznakaZone";
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            var search = new CjenovnikSearchRequest();
            if (this.ValidateChildren())
            {
                search.ZonaID = int.Parse(cbZona.SelectedItem.ToString());
                search.TipkarteID = int.Parse(cbTip.SelectedItem.ToString());
                                               
                await _cjenovnik.Get<List<CjenovnikModel>>(search);
                
            }
        }
    }
}
