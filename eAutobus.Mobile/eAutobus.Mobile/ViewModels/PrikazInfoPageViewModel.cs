using eAutobusModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobus.Mobile.ViewModels
{
    public class PrikazInfoPageViewModel : BaseViewModel
    {
        RasporedVoznjeModel _linija;
        public PrikazInfoPageViewModel(RasporedVoznjeModel linija)
        {
            _linija = linija;
        }
        private int _rasporedLinije;
        public int RasporedLinije
        {
            get { return _rasporedLinije; }
            set { SetProperty(ref _rasporedLinije, value); }
        }

        private int _brojLinije;
        public int BrojLinije
        {
            get { return _brojLinije; }
            set {
                    value = _linija.BrojLinije; 
                    SetProperty(ref _brojLinije, value);
            }
        }

        private string _polaziste;
        public string Polaziste
        {
            get { return _polaziste; }
            set {
                value = _linija.Polazak;
                SetProperty(ref _polaziste, value);
                }
        }


        private string _odrediste;
        public string Odrediste
        {
            get { return _odrediste; }
            set
            {
                value = _linija.Odlazak;
                SetProperty(ref _odrediste, value);
            }
        }

        private DateTime _odredisteDatum;
        public DateTime OdredisteDatum
        {
            get { return _odredisteDatum; }
            set
            {
                value = _linija.VrijemeDolaska;
                SetProperty(ref _odredisteDatum, value);
            }
        }
    }
}
