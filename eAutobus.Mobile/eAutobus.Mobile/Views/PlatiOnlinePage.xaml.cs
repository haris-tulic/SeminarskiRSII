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
    public partial class PlatiOnlinePage : ContentPage
    {
        private PlatiOnlineViewModel model;
        public KartaModel _karta = null;

        public PlatiOnlinePage(KartaModel karta)
        {
            _karta = karta;
            InitializeComponent();
            BindingContext = model = new PlatiOnlineViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            model._novaKarta = _karta;
            model.UcitajPodatke();
        }
        private void Number_changed(object sender, TextChangedEventArgs e)
        {
            if (Number.Text.Length > 16)
            {
                ErrorLabel_CardNumber.IsVisible = true;
                ErrorLabel_CardNumber.Text = "Broj kartice mora imati 16 brojeva!";
            }
            else if (Number.Text.Length < 1)
            {
                ErrorLabel_CardNumber.IsVisible = true;
                ErrorLabel_CardNumber.Text = "Obavezno polje!";
            }
            else
            {
                ErrorLabel_CardNumber.IsVisible = false;
            }
        }

        private void Number_unfocused(object sender, TextChangedEventArgs e)
        {
            if (Number.Text == null)
            {
                ErrorLabel_CardNumber.IsVisible = true;
                ErrorLabel_CardNumber.Text = "Obavezno polje!";
            }
            else
            {
                ErrorLabel_CardNumber.IsVisible = false;
            }
        }

        private void Month_changed(object sender, TextChangedEventArgs e)
        {
            if (Month.Text.Length != 2)
            {
                ErrorLabel_Month.IsVisible = true;
                ErrorLabel_Month.Text = "Ovo polje treba da sadržava 2 broja!";
            }
            else if (Month.Text == null)
            {
                ErrorLabel_Month.IsVisible = true;
                ErrorLabel_Month.Text = "Obavezno polje!";
            }
            else
            {
                ErrorLabel_Month.IsVisible = false;
            }
        }

        private void Month_unfocused(object sender, TextChangedEventArgs e)
        {
            if (Month.Text == null)
            {
                ErrorLabel_Month.IsVisible = true;
                ErrorLabel_Month.Text = "Obavezno polje!";
            }
            else
            {
                ErrorLabel_Month.IsVisible = false;
            }
        }

        private void Year_changed(object sender, TextChangedEventArgs e)
        {
            if (Year.Text.Length != 2)
            {
                ErrorLabel_Year.IsVisible = true;
                ErrorLabel_Year.Text = "Ovo polje treba da sadržava 2 broja!";
            }
            else if (Year.Text == null)
            {
                ErrorLabel_Year.IsVisible = true;
                ErrorLabel_Year.Text = "Obavezno polje!";
            }
            else
            {
                ErrorLabel_Year.IsVisible = false;
            }
        }

        private void Year_unfocused(object sender, TextChangedEventArgs e)
        {
            if (Year.Text == null)
            {
                ErrorLabel_Year.IsVisible = true;
                ErrorLabel_Year.Text = "Obavezno polje!";
            }
            else
            {
                ErrorLabel_Year.IsVisible = false;
            }
        }

        private void Cvv_changed(object sender, TextChangedEventArgs e)
        {
            if (Cvv.Text.Length != 3)
            {
                ErrorLabel_Cvv.IsVisible = true;
                ErrorLabel_Cvv.Text = "Ovo polje treba da sadržava 3 broja!";
            }
            else if (Cvv.Text == null)
            {
                ErrorLabel_Cvv.IsVisible = true;
                ErrorLabel_Cvv.Text = "Obavezno polje!";
            }
            else
            {
                ErrorLabel_Cvv.IsVisible = false;
            }
        }

        private void Cvv_unfocused(object sender, TextChangedEventArgs e)
        {
            if (Cvv.Text == null)
            {
                ErrorLabel_Cvv.IsVisible = true;
                ErrorLabel_Cvv.Text = "Obavezno polje!";
            }
            else
            {
                ErrorLabel_Cvv.IsVisible = false;
            }
        }
    
}
}