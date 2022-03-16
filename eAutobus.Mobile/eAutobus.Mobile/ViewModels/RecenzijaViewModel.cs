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
    public class RecenzijaViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Recenzija");
        private readonly APIService _linije = new APIService("RasporedVoznje");
        private readonly APIService _kupci = new APIService("Kupac");
        public ICommand OcijeniCommand { get; set; }

        public ObservableCollection<RasporedVoznjeModel> LinijaList { get; set; } = new ObservableCollection<RasporedVoznjeModel>();
        public RecenzijaUpsertRequest _recenzija;
        public KupacModel _kupac = new KupacModel();
        public RecenzijaViewModel()
        {
             OcijeniCommand = new Command(async() => await Ocijeni());
        }

        private async Task Ocijeni()
        { 
             if (_recenzija==null)
            {
                _recenzija = new RecenzijaUpsertRequest
                {
                    DatumRecenzije = DateTime.Now,
                    KupacID = _kupac.KupacID,
                    VrstaUsluga = Svrha,
                    Komentar = Komentar,
                    Ocjena = Ocjena,
                    RasporedVoznjeID = Linija.RasporedVoznjeID
                };
                try
                {
                    await _service.Insert<RecenzijaModel>(_recenzija);
                    _recenzija = null;
                    await Application.Current.MainPage.DisplayAlert("Uspješno!", "Hvala vam na vašoj ocjeni!", "Uredu");
                   
                }
                catch (Exception)
                {
                    _recenzija = null;
                    throw;
                }
            }
        }

        public async Task Ucitaj()
        {
            if (LinijaList.Count>0)
            {
                LinijaList.Clear();
            }
            var list = await _linije.Get<List<RasporedVoznjeModel>>(null);
            foreach (var item in list)
            {
                LinijaList.Add(item);
            }
            var kupciList = await _kupci.Get<List<KupacModel>>(new KupacGetRequest { UserName = APIService.Username });
            if (kupciList.Count==1)
            {
                foreach (var item in kupciList)
                {
                    _kupac = item;
                }
            }
        }
        private int _ocjena;
        public int Ocjena
        {
            get { return _ocjena; }
            set { SetProperty(ref _ocjena, value); }

        }
        private string _ocjenaS;
        public string OcjenaS
        {
            get { return _ocjenaS; }
            set { SetProperty(ref _ocjenaS, value); }

        }
        private string _svrha;
        public string Svrha
        { 
            get { return _svrha; }
            set { SetProperty(ref _svrha, value); }
        }

        private string _komentar;
        public string Komentar
        {
            get { return _komentar; }
            set { SetProperty(ref _komentar, value); }
        }
        private RasporedVoznjeModel _linija;
        public RasporedVoznjeModel Linija
        {
            get { return _linija; }
            set
            {
                SetProperty(ref _linija, value);
            }
        }

    }
}
