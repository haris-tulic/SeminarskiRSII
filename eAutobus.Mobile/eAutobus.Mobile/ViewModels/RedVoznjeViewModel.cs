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
    public class RedVoznjeViewModel:BaseViewModel
    {
        private readonly APIService _polazisteService = new APIService("Stanica");
        private readonly APIService _redVoznjeService = new APIService("RasporedVoznje");
        private readonly APIService _prikazOcjene = new APIService("Preporuke");

        private RasporedVoznjeModel _linija;
        public RasporedVoznjeModel Linija
        {
            get { return _linija; }
            set
            {
                SetProperty(ref _linija, value);
            }
        }

        public StanicaModel _polaziste = null;
        public StanicaModel Polaziste
        {
            get { return _polaziste; }
            set { SetProperty(ref _polaziste, value);
                if (value!=null)
                {
                    Pretraga.Execute(null);
                }
            }
        }
        public RasporedVoznjeGetRequest search = new RasporedVoznjeGetRequest();
        public ObservableCollection<StanicaModel> PolazisteList { get; set; } = new ObservableCollection<StanicaModel>();
        public ObservableCollection<RasporedVoznjeModel> RedVoznjeList { get; set; } = new ObservableCollection<RasporedVoznjeModel>();
       
        private DateTime _datumPolaska=DateTime.Now;
        public DateTime DatumPolaska
        {
            get { return _datumPolaska; }
            set { SetProperty(ref _datumPolaska, value);
                if (value!=null)
                {
                    Pretraga.Execute(DatumPolaska);
                }        
            }
        }

        public ICommand Pretraga { get; set; }

        public RedVoznjeViewModel()
        {
            Pretraga = new Command(async () => await Pretrazi());
        }

        public async Task Pretrazi()
        {
            if (PolazisteList.Count==0)
            {
                var listP = await _polazisteService.Get<List<StanicaModel>>(null);
                foreach (var item in listP)
                {
                    PolazisteList.Add(item);
                }
            }
            if (Polaziste != null || DatumPolaska != null)
            {
                if (Polaziste != null)
                {
                    search.PolazisteID = Polaziste.StanicaID;
                }
                search.Datum = DatumPolaska;
                var listRV = await _redVoznjeService.Get<List<RasporedVoznjeModel>>(search);
                RedVoznjeList.Clear();
                foreach (var item in listRV)
                {
                    RedVoznjeList.Add(item);
                }
            }
            else {
                var listRV = await _redVoznjeService.Get<List<RasporedVoznjeModel>>(null);
                RedVoznjeList.Clear();
                foreach (var item in listRV)
                {
                    RedVoznjeList.Add(item);
                }
            }
        }
        public async Task PrikazOcjene(int? RasporedVoznjeID)
        {
            var linija= await _prikazOcjene.Get <RasporedVoznjeModel>(RasporedVoznjeID);
            await Application.Current.MainPage.Navigation.PushAsync(new PrikazInfoPage(linija));
        }
    }
}
