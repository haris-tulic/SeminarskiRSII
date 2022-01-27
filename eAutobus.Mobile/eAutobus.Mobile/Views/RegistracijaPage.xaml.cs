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
    public partial class RegistracijaPage : ContentPage
    {
        RegistracijaViewModel model=null;
        public RegistracijaPage()
        {
            InitializeComponent();
            BindingContext = model = new RegistracijaViewModel();

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            bool postoji = false; 
            if (string.IsNullOrEmpty(Ime.Text))
            {
                Ime.Placeholder = "Obavezan unos!";
                Ime.PlaceholderColor = Color.Red;
                postoji = true;
            }
            if (string.IsNullOrEmpty(Prezime.Text))
            {
                Prezime.Placeholder = "Obavezan unos!";
                Prezime.PlaceholderColor = Color.Red;
                postoji = true;
            }
            if (string.IsNullOrEmpty(KorisnickoIme.Text))
            {
                KorisnickoIme.Placeholder = "Obavezan unos!";
                KorisnickoIme.PlaceholderColor = Color.Red;
                postoji = true;
            }
            if (string.IsNullOrEmpty(Email.Text))
            {
                Email.Placeholder = "Obavezan unos!";
                Email.PlaceholderColor = Color.Red;
                postoji = true;
            }
            if (string.IsNullOrEmpty(BrojTelefona.Text))
            {
                BrojTelefona.Placeholder = "Obavezan unos!";
                BrojTelefona.PlaceholderColor = Color.Red;
                postoji = true;
            }
            if (string.IsNullOrEmpty(Password.Text))
            {
                Password.Placeholder = "Obavezan unos!";
                Password.PlaceholderColor = Color.Red;
                postoji = true;
            }
            if (string.IsNullOrEmpty(PotvrdaPassworda.Text))
            {
                PotvrdaPassworda.Placeholder = "Obavezan unos!";
                PotvrdaPassworda.PlaceholderColor = Color.Red;
                postoji = true;
            }
            if (!postoji)
            {
                bool ok = true;
                if (await model.PostojiKorisnickoIme(KorisnickoIme.Text))
                {
                    await Application.Current.MainPage.DisplayAlert("Upozorenje", "Korisničko ime već postoji", "OK");
                    KorisnickoIme.Text = "Korisničko ime već postoji";
                    ok = false;
                }
                if (await model.PostojiEmail(Email.Text))
                {
                    await Application.Current.MainPage.DisplayAlert("Upozorenje", "Email već postoji", "OK");
                    ok = false;
                }
                if (Password.Text != PotvrdaPassworda.Text)
                {
                    await Application.Current.MainPage.DisplayAlert("Upozorenje", "Šifre se razlikuju", "OK");
                    ok = false;
                }
                if (ok)
                {
                    await model.RegistrujSe();
                }
            }
        }
    }
}
