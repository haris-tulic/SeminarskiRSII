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
    public partial class frmOnlineKarte : Form
    {
        private readonly APIService _onlineKarte = new APIService("PlatiKartu");
        public frmOnlineKarte()
        {
            InitializeComponent();
        }

        private async void frmOnlineKarte_Load(object sender, EventArgs e)
        {
            var listKarte = await _onlineKarte.Get<List<PlatiKartuModel>>(null);
            foreach (var item in listKarte)
            {
                item.CijenaString = item.Cijena.ToString() + " KM";
            }
            dgvPrikazKarata.AutoGenerateColumns = false;
            dgvPrikazKarata.DataSource = listKarte;
        }
    }
}
