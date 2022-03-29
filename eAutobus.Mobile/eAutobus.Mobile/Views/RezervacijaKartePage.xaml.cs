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
    public partial class RezervacijaKartePage : ContentPage
    {
        RezervacijaKarteViewModel model;
        public RezervacijaKartePage()
        {
            InitializeComponent();
            BindingContext = model = new RezervacijaKarteViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            this.PravacG.IsEnabled = false;
            this.PravacG.Opacity=0.5;
            await model.Ucitaj();
        }
        void PravacChanged(object sender, EventArgs args)
        {
            RadioButton pravac = sender as RadioButton;
            model.Pravac =pravac.IsChecked;
            model.PravacS = pravac.Value.ToString();
            if (model.PravacS=="U oba smjera" && model.Pravac==true)
            {
                var novaCijena = model.Cijena * 1.67;
                model.Cijena = novaCijena;
            }
            else if(model.PravacS == "U jednom smjeru" && model.Pravac == true)
            {
                var staraCijena = model.Cijena/1.67;
                model.Cijena = staraCijena;
            }
        }

        private void VrstaKarteChanged(object sender, EventArgs e)
        {
            var vrsta = sender as Picker;
            var odabrana = vrsta.SelectedItem.ToString();
            var o = model.VrstaKarte.Naziv;
            if (o.StartsWith("Mjesečna") || o.StartsWith("Godišnja"))
            {
                this.PravacG.IsEnabled = false;
                this.PravacG.Opacity = 0.5;
                this.PravacJedan.IsChecked = true;
            }
            else
            {
                this.PravacG.IsEnabled = true;
                this.PravacG.Opacity = 1;
            }
        }

        private void DatumP_DateSelected(object sender, DateChangedEventArgs e)
        {
            string vrsta = string.Empty;
            vrsta = model.VrstaKarte.Naziv;
          
            if (vrsta.StartsWith("Mjesečna"))
            {
                model.DatumDolaska = model.DatumPolaska.AddMonths(1);
            }
            else if (vrsta.StartsWith("Godišnja"))
            {
                model.DatumDolaska = model.DatumPolaska.AddYears(1);
            }
        }




        //private void DatePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        //{
        //    var datum = sender as DatePicker;
        //    DatumP.MinimumDate = DateTime.Now;
        //    DatumV.MinimumDate = DateTime.Now;


        //}
    }
}