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
    public class CjenovnikViewModel:BaseViewModel
    {
        private readonly APIService _cjenovnikService = new APIService("Cjenovnik");
        private readonly APIService _tipKarteService = new APIService("TipKarte");

        public ObservableCollection<CjenovnikModel> CjenovnikList { get; set; } = new ObservableCollection<CjenovnikModel>();
        public ObservableCollection<TipKarteModel> TipKarataList { get; set; } = new ObservableCollection<TipKarteModel>();
        public TipKarteModel _tipKarte = null;
        public TipKarteModel TipKarte
        {
            get { return _tipKarte; }
            set {
                SetProperty(ref _tipKarte, value);
                if (value!=null)
                {
                    InitCommand.Execute(null);
                }
            }
        }

        public ICommand InitCommand { get;}
        

        public CjenovnikViewModel()
        {
            InitCommand = new Command(async () => await GetCjenovnik());
        }

       

        public async Task GetCjenovnik()
        {
           
            if (TipKarataList.Count==0)
            {
                var listTK = await _tipKarteService.Get<List<TipKarteModel>>(null);
                
                foreach (var item in listTK)
                {
                    TipKarataList.Add(item);
                }
            }
            if (_tipKarte!=null)
            {
                CjenovnikSearchRequest search = new CjenovnikSearchRequest();
                search.TipkarteID = _tipKarte.TipKarteID;
                var list = await _cjenovnikService.Get<List<CjenovnikModel>>(search);
                CjenovnikList.Clear();

                foreach (var item in list)
                {
                    CjenovnikList.Add(item);
                }
            }
            else
            {
                var list = await _cjenovnikService.Get<List<CjenovnikModel>>(null);
                CjenovnikList.Clear();

                foreach (var item in list)
                {
                    CjenovnikList.Add(item);
                }
            }

           
        }
    }
}
