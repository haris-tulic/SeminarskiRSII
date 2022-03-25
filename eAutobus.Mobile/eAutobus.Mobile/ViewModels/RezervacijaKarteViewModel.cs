using eAutobus.Mobile.Views;
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
    public class RezervacijaKarteViewModel : BaseViewModel
    {
        private readonly APIService _serviceK = new APIService("Karta");
        private readonly APIService _serviceTK = new APIService("TipKarte");
        private readonly APIService _serviceVK = new APIService("VrstaKarte");
        private readonly APIService _serviceS = new APIService("Stanica");
        private readonly APIService _serviceC = new APIService("Cjenovnik");
        public ICommand KupiCommand { get; set; }
        public CjenovnikSearchRequest _cijenaKarte = new CjenovnikSearchRequest();
        public KartaUpsertRequest _novaKarta = new KartaUpsertRequest();
        public ObservableCollection<TipKarteModel> TipKarteList { get; set; } = new ObservableCollection<TipKarteModel>();
        public ObservableCollection<VrstaKarteModel> VrstaKarteList { get; set; } = new ObservableCollection<VrstaKarteModel>();
        public ObservableCollection<StanicaModel> StanicaList { get; set; } = new ObservableCollection<StanicaModel>();
        public double ccijena;
        public ICommand CijenaCommand { get; }
        public ICommand KupiKartuOnlineCommand { get; }
        
        public RezervacijaKarteViewModel()
        {
            KupiCommand = new Command(async () => await KupiKartu());
            KupiKartuOnlineCommand = new Command(async () => await KupiKartuOnline());
        }

        public async Task KupiKartu()
        {
             if (_novaKarta!=null)
            {
                try
                {
                    _novaKarta.DatumVadjenjaKarte = DatumPolaska;
                    
                    
                    if (VrstaKarte.Naziv.StartsWith("Mjesečna"))
                    {
                        _novaKarta.DatumVazenjaKarte = DatumPolaska.AddMonths(1);
                        _novaKarta.Pravac = true;
                        _novaKarta.PravacS = "U oba smjera";
                    }
                    else if (VrstaKarte.Naziv.StartsWith("Godišnja"))
                    {
                        _novaKarta.DatumVazenjaKarte = DatumPolaska.AddYears(1);
                        _novaKarta.Pravac = true;
                        _novaKarta.PravacS = "U oba smjera";
                    }
                    else
                    {
                        _novaKarta.DatumVazenjaKarte = DatumDolaska;
                        if (_novaKarta.Pravac==null && _novaKarta.PravacS==null)
                        {
                            _novaKarta.Pravac = true;
                            _novaKarta.PravacS = "U jednom smjeru";
                        }
                    }
                    
                    await _serviceK.Insert<KartaModel>(_novaKarta);
                    await Application.Current.MainPage.DisplayAlert("Uspješno!", "Uspješno ste kupili kartu. Vašu kartu ćete platiti prilikom preuzimanja na šalteru. Karta važi do: "+_novaKarta.DatumVazenjaKarte, "Uredu");
                    
                }
                catch (Exception)
                {
                    
                     await Application.Current.MainPage.DisplayAlert("Upozorenje!", "Nije izvršena kupovina!", "Ok");
                }
            }
        }
        public async Task KupiKartuOnline()
        {
            if (_novaKarta != null)
            {
                try
                {
                    _novaKarta.DatumVadjenjaKarte = DatumPolaska;
                   
                    if (VrstaKarte.Naziv.StartsWith("Mjesečna"))
                    {
                        _novaKarta.DatumVazenjaKarte = DatumPolaska.AddMonths(1);
                        _novaKarta.Pravac = true;
                        _novaKarta.PravacS = "U oba smjera";
                    }
                    else if (VrstaKarte.Naziv.StartsWith("Godišnja"))
                    {
                        _novaKarta.DatumVazenjaKarte = DatumPolaska.AddYears(1);
                        _novaKarta.Pravac = true;
                        _novaKarta.PravacS = "U oba smjera";
                    }
                    else
                    {
                        _novaKarta.DatumVazenjaKarte = DatumDolaska;
                        if (_novaKarta.Pravac == null && _novaKarta.PravacS == null)
                        {
                            _novaKarta.Pravac = true;
                            _novaKarta.PravacS = "U jednom smjeru";
                        }
                    }
                    var onlineKarta = await _serviceK.Insert<KartaModel>(_novaKarta);
                    if (onlineKarta!=null)
                    {
                            var popust = _novaKarta.Cijena * 5 / 100;
                            onlineKarta.Cijena -= popust;
                            await Application.Current.MainPage.Navigation.PushAsync(new PlatiOnlinePage(onlineKarta));
                    }
                    else
                    {
                           await Application.Current.MainPage.DisplayAlert("Upozorenje!", "Nije izvršena kupovina!", "Ok");
                    }
                    
                }
                catch (Exception)
                {

                    await Application.Current.MainPage.DisplayAlert("Upozorenje!","Nije izvršena kupovina!","Ok");

                }
            }
        }
        public async Task DodajCijenu()
        {
            if (_cijenaKarte.OdredisteID.ToString()!="0" && 
                _cijenaKarte.PolazisteID.ToString() != "0" && 
                _cijenaKarte.VrstaKarteID.ToString() != "0" && 
                _cijenaKarte.TipkarteID.ToString() != "0")
            {

                var cjenovnik = await _serviceC.Get<List<CjenovnikModel>>(_cijenaKarte);
                if (cjenovnik.Count == 0)
                {
                    Cijena = 0;
                    ccijena = 0;
                }
                else
                {
                    foreach (var item in cjenovnik)
                    {
                        Cijena = item.Cijena;
                        ccijena = item.Cijena;
                    }
                }

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
                    _cijenaKarte.PolazisteID = value.StanicaID;
                    var t= DodajCijenu();
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
                    _cijenaKarte.OdredisteID = value.StanicaID;
                    var t = DodajCijenu();
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
                    var t = DodajCijenu();
                }
            }
        }

        public VrstaKarteModel _vrstaKarte = null;
        public VrstaKarteModel VrstaKarte
        {
            get { return _vrstaKarte; }
            set { SetProperty(ref _vrstaKarte, value);
                if (value!=null)
                {
                    _novaKarta.VrstaKarteID = value.VrstaKarteID;
                    _cijenaKarte.VrstaKarteID = value.VrstaKarteID;
                    var t = DodajCijenu();
                }
            } 
        }

        public bool _pravac=true;
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
            set{ SetProperty(ref _ime, value);
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
            set {
                SetProperty(ref _cijena, value);

                _novaKarta.Cijena = value;
            }
        }

      

        private string _pravacS="U jednom smjeru";
        public string PravacS
        {
            get{ return _pravacS; }
            set { SetProperty(ref _pravacS, value);
                _novaKarta.PravacS = value;
              }
        }

        private DateTime _datumPolaska = DateTime.Now;
        public DateTime DatumPolaska
        {
            get { return _datumPolaska; }
            set
            {
                SetProperty(ref _datumPolaska, value);
                _novaKarta.DatumVadjenjaKarte = _datumPolaska;
            }
        }

        private DateTime _datumDolaska = DateTime.Now;
        public DateTime DatumDolaska
        {
            get { return _datumDolaska; }
            set
            {
                SetProperty(ref _datumDolaska, value);
                _novaKarta.DatumVazenjaKarte = _datumDolaska;
            }
        }

        

        private string _email;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value);
                _novaKarta.Email = value;
            }
        }
    }


   

}

