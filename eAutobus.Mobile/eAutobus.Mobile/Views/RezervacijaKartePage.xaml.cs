using eAutobus.Mobile.ViewModels;
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
            await model.Ucitaj();
        }
        void PravacChanged(object sender, EventArgs args)
        {
            RadioButton pravac = sender as RadioButton;
            model.Pravac =pravac.IsChecked;
            model.PravacS = pravac.Value.ToString();
        }
    }
}