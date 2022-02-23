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
    public partial class HistorijaKarataPage : ContentPage
    {
        public HistorijaKarataViewModel model;
        public HistorijaKarataPage()
        {
            InitializeComponent();
            BindingContext = model = new HistorijaKarataViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.UcitajHistoriju();

        }
    }
}