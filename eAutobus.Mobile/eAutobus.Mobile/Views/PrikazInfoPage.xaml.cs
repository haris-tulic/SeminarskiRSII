using eAutobus.Mobile.ViewModels;
using eAutobusModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eAutobus.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrikazInfoPage : ContentPage
    {
        RasporedVoznjeModel _linija = new RasporedVoznjeModel();
        public PrikazInfoPage(RasporedVoznjeModel linija)
        {
            _linija = linija;
            InitializeComponent();
            BrojLinije.Text = _linija.BrojLinije.ToString();
            NazivLinije.Text = _linija.NazivLinije;
            Autobus.Text = _linija.BrojAutobusa.ToString();
            VrijemeDolaska.Text = _linija.VrijemeDolaska.ToString();
            VrijemePolaska.Text = _linija.VrijemePolaska.ToString();
            Polaziste.Text = _linija.Polazak;
            Odrediste.Text = _linija.Odlazak;
            Datum.Text = _linija.Datum.ToString();
            FinalOcjena.Text = _linija.FinalOcjena.ToString();
        }
    }
}