using eAutobusModel;
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
    public partial class frmPreuzecemKarte : Form
    {
        private readonly APIService _karte = new APIService("Karta");
        public frmPreuzecemKarte()
        {
            InitializeComponent();
        }

        private async void frmPreuzecemKarte_Load(object sender, EventArgs e)
        {
            var listPrikaz = new List<KartaModel>();
            List<KartaModel> list = await _karte.Get<List<KartaModel>>(null);
            foreach (var item in list)
            {
                item.CijenaString = item.Cijena.ToString() + " KM";
                //if (!string.IsNullOrEmpty(item.NacinPlacanja) && item.NacinPlacanja.StartsWith("Preuzećem"))
                //{
                //    listPrikaz.Add(item);

                //}
            }
            dgvPrikazKarata.AutoGenerateColumns = false;
            dgvPrikazKarata.DataSource = list;
            if (listPrikaz.Count>0)
            {
                //dgvPrikazKarata.AutoGenerateColumns = false;
                //dgvPrikazKarata.DataSource = listPrikaz;
            }
        }
    }
}
