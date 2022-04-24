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
            await LoadCjenovnik();
        }

        private async Task LoadCjenovnik()
        {
            var listC = await _cjenovnik.Get<List<CjenovnikModel>>(null);
            foreach (var item in listC)
            {
                item.CijenaPrikaz = item.Cijena.ToString() + " KM";
            }
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = listC;
        }

        private async Task LoadTipKarte()
        {
            var listT = await _tipKarte.Get<List<TipKarteModel>>(null);
            listT.Insert(0, new TipKarteModel { });
            cbTip.DataSource = listT;
            cbTip.ValueMember = "TipKarteID";
            cbTip.DisplayMember = "Naziv";
        }

        private async Task LoadZona()
        {
            var listZ = await _zone.Get<List<ZonaModel>>(null);
            listZ.Insert(0, new ZonaModel { });
            cbZona.DataSource = listZ;
            cbZona.ValueMember = "ZonaID";
            cbZona.DisplayMember = "OznakaZone";
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            var search = new CjenovnikSearchRequest();
           
                search.ZonaID = int.Parse(cbZona.SelectedValue.ToString());
                search.TipkarteID = int.Parse(cbTip.SelectedValue.ToString());
                                               
               var result=await _cjenovnik.Get<List<CjenovnikModel>>(search);
            foreach (var item in result)
            {
                item.CijenaPrikaz = item.Cijena.ToString() + " KM";
            }
            dataGridView1.AutoGenerateColumns = false;    
            dataGridView1.DataSource = result;
           
        }

        private async void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var kartaID = dataGridView1.SelectedRows[0].Cells[0].Value;
            var odabranaKarta = await _cjenovnik.GetById<CjenovnikModel>(kartaID);
            if (dataGridView1.CurrentCell is DataGridViewButtonCell)
            {
                await _cjenovnik.Delete<CjenovnikModel>(kartaID);
                MessageBox.Show("Izbrisali ste odabranu kartu: " + odabranaKarta.Tipkarte + " " + odabranaKarta.VrstaKarte);
                await LoadCjenovnik();
            }
            else
            {
                frmDodajKartu frm = new frmDodajKartu(int.Parse(kartaID.ToString()));
                frm.Show();
            }
        }

        private void btnPrintajKarte_Click(object sender, EventArgs e)
        {
            var cjenovinikPrikaz=dataGridView1.DataSource as List<CjenovnikModel>;
            Reports.PregledCjenovnika rpt= new Reports.PregledCjenovnika(cjenovinikPrikaz);
            rpt.Show();
        }
    }
}
