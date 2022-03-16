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

namespace eAutobus.WinUI.Recenzija
{
    public partial class frmRecenzija : Form
    {
        private readonly APIService _recenzija = new APIService("Recenzija");
        public frmRecenzija()
        {
            InitializeComponent();
        }

        private async void frmRecenzija_Load(object sender, EventArgs e)
        {
            await LoadRecenzije();
        }

        private async Task LoadRecenzije()
        {
            var listR = await _recenzija.Get<List<RecenzijaModel>>(null);
            dgvRecenzije.AutoGenerateColumns = false;
            dgvRecenzije.DataSource = listR;
        }

        private async void btnFiltriraj_Click(object sender, EventArgs e)
        {
            RecenzijaGetRequest request = new RecenzijaGetRequest()
            {
                Ocjena = int.Parse(nmOcjena.Value.ToString())
            };
            var listR = await _recenzija.Get<List<RecenzijaModel>>(request);
            dgvRecenzije.AutoGenerateColumns = false;
            dgvRecenzije.DataSource = listR;
        }
    }
}
