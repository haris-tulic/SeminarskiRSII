using eAutobusModel;
using eAutobusModel.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace eAutobus.Mobile.ViewModels
{
    public class HistorijaKarataViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Kupac");
        public ObservableCollection<KartaKupacModel> listaKarata { get; set; } = new ObservableCollection<KartaKupacModel>(); 
        public HistorijaKarataViewModel()
        {

        }

        private string _ime;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }

        private string _prezime;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty( ref _prezime, value); }
        }
        
        public async Task UcitajHistoriju()
        {
            listaKarata.Clear();
            KupacGetRequest trazeni = new KupacGetRequest
            {
                UserName = APIService.Username,
                Password=APIService.Password,
            };
            var pronadjeni = await _service.Get<List<KupacModel>>(trazeni);
            if (pronadjeni.Count == 1)
            {
                for (int i = 0; i < pronadjeni.Count; i++)
                {
                    Ime = pronadjeni[i].Ime;
                    Prezime = pronadjeni[i].Prezime;
                    for (int j = 0; j < pronadjeni[i].KartaKupacs.Count; j++)
                    {
                        listaKarata.Add(pronadjeni[i].KartaKupacs[j]);
                    }
                }
            }
        }
    }
}

