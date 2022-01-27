using eAutobusModel;
using eAutobusModel.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eAutobus.Mobile.ViewModels
{
    public class RezervacijaKarteViewModel:BaseViewModel
    {
        private readonly APIService _serviceK = new APIService("Karta");
        private readonly APIService _serviceTK = new APIService("TipKarte");
        private readonly APIService _serviceVK = new APIService("VrstaKarte");
        private readonly APIService _serviceS = new APIService("Stanica");
        private readonly APIService _serviceC = new APIService("Cjenovnik");
        public ICommand Kupi { get; set; }
        public CjenovnikSearchRequest _cijenaKarte=new CjenovnikSearchRequest();
        public KartaUpsertRequest _novaKarta=new KartaUpsertRequest();
        public ObservableCollection<TipKarteModel> TipKarteList { get; set; } = new ObservableCollection<TipKarteModel>();
        public ObservableCollection<VrstaKarteModel> VrstaKarteList { get; set; } = new ObservableCollection<VrstaKarteModel>();
        public ObservableCollection<StanicaModel> StanicaList { get; set; } = new ObservableCollection<StanicaModel>();
        

        public RezervacijaKarteViewModel()
        {
            Kupi = new Command(async () => await KupiKartu());
        }

        public async Task KupiKartu()
        {
            if (_novaKarta!=null)
            {
                await _serviceK.Insert<KartaModel>(_novaKarta);
            }
        }
        public async Task Ucitaj()
        {
            if (TipKarteList.Count==0 && VrstaKarteList.Count==0 && StanicaList.Count==0)
            {
                var listTk = await _serviceTK.Get<List<TipKarteModel>>(null);
                var listVk = await _serviceVK.Get<List<VrstaKarteModel>>(null);
                var listS = await _serviceS.Get<List<StanicaModel>>(null);

                foreach (var item in listTk)
                {
                    TipKarteList.Add(item);
                }
                foreach (var item in listVk)
                {
                    VrstaKarteList.Add(item);
                }
                foreach (var item in listS)
                {
                    StanicaList.Add(item);
                }
            }
        }

        public StanicaModel _polazak;
        public StanicaModel Polazak
        {
            get { return _polazak; }
            set { SetProperty(ref _polazak, value);
                if (value!=null)
                {
                    _novaKarta.PolazisteID = value.StanicaID;
                }
            }
        }

        public StanicaModel _odrediste;
        public StanicaModel Odrediste
        {
            get { return _odrediste; }
            set { SetProperty(ref _odrediste, value);
                if (value!=null)
                {
                    _novaKarta.OdredisteID = value.StanicaID;
                }
            }
        }

        public TipKarteModel _tipKarte = null;
        public TipKarteModel TipKarte
        {
            get { return _tipKarte; }
            set { SetProperty(ref _tipKarte, value);
                if (value!=null)
                {
                    _novaKarta.TipKarteID = value.TipKarteID;
                    _cijenaKarte.TipkarteID = value.TipKarteID;
                }
            }
        }

        public VrstaKarteModel _vrstaKarte = null;
        public VrstaKarteModel VrstaKarte
        {
            get { return _vrstaKarte; }
            set { SetProperty(ref _vrstaKarte, value);
                if (value!=null && TipKarte!=null)
                {
                    _novaKarta.VrstaKarteID = value.VrstaKarteID;
                    _cijenaKarte.VrstaKarteID = value.VrstaKarteID;
                    var cijena = _serviceC.Get<List<CjenovnikModel>>(_cijenaKarte);
                    
                }
            } 
        }

        public bool _pravac;
        public bool Pravac
        {
            get { return _pravac; }
            set { SetProperty(ref _pravac, value);
                _novaKarta.Pravac = value;
            }
        }

        public string _ime;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value);
                _novaKarta.Ime = value;
            }
        }

        public string _prezime;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value);
                _novaKarta.Prezime = value;
            }
        }

        public string _adresaStanovanja;
        public string AdresaStanovanja
        {
            get { return _adresaStanovanja; }
            set { SetProperty(ref _adresaStanovanja, value);
                _novaKarta.AdresaStanovanja = value;
            }
        }


        public string _brojTelefona;
        public string BrojTelefona
        {
            get { return _brojTelefona; }
            set { SetProperty(ref _brojTelefona, value);
                _novaKarta.BrojTelefona = value;
            }
        }
        private double _cijena;
        public double Cijena
        {
            get { return _cijena; }
            set { SetProperty(ref _cijena, value);
                _novaKarta.Cijena = value;
            }
        }

        private string _pravacS;
        public string PravacS
        {
            get{ return _pravacS; }
            set { SetProperty(ref _pravacS, value);
                _novaKarta.PravacS = value;
              }
        }

    }
}
