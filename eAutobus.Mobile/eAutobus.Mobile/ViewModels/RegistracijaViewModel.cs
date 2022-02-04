using eAutobus.Mobile.Views;
using eAutobusModel;
using eAutobusModel.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eAutobus.Mobile.ViewModels
{
    public class RegistracijaViewModel : BaseViewModel
    {
        private readonly APIService _serviceK = new APIService("Kupac");
        public ICommand RegistrujSeCommand { get; }
        public ICommand PrijaviSeCommand { get; }

        public RegistracijaViewModel()
        {
            //RegistrujSeCommand = new Command(async () => await RegistrujSe());
            PrijaviSeCommand = new Command(async() => await PrijaviSe());
        }

        public async Task PrijaviSe()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LoginPage());
        }

        public async Task RegistrujSe()
        {
            if (Password==PotvrdaPassworda)
            { 
                KupacInsertRequest noviKupac = new KupacInsertRequest();
                noviKupac.Ime = Ime;
                noviKupac.Prezime = Prezime;
                noviKupac.Email = Email;
                noviKupac.BrojTelefona = BrojTelefona;
                noviKupac.AdresaStanovanja = AdresaStanovanja;
                noviKupac.KorisnickoIme = KorisnickoIme;
                noviKupac.Password = Password;
                try
                {
                    await _serviceK.Insert<KupacModel>(noviKupac);
                    await Application.Current.MainPage.DisplayAlert("Uspješno", "Uspješno ste se registrovali.", "Uredu");
                    await Application.Current.MainPage.Navigation.PushAsync(new LoginPage());
                }
                catch (Exception)
                {

                    await Application.Current.MainPage.DisplayAlert("Greška!","Podaci nisu pravilno uneseni!", "Uredu");
                }
               
            }
            else
            {
               await Application.Current.MainPage.DisplayAlert("Greška", "Passwordi se ne slažu", "Uredu");
            }
        }

        private string _ime;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }

        private string _prezime;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        private string _brojTelefona;
        public string BrojTelefona
        {
            get { return _brojTelefona; }
            set { SetProperty(ref _brojTelefona, value); }
        }

        private string _adresaStanovanja;
        public string AdresaStanovanja
        {
            get { return _adresaStanovanja; }
            set { SetProperty(ref _adresaStanovanja, value); }
        }

        public async Task<bool> PostojiKorisnickoIme(string text)
        {
            var list = await _serviceK.Get<List<KupacModel>>(null);
            foreach (var item in list)
            {
                if (item.KorisnickoIme==text)
                {
                    return true;
                }
            }
            return false;
        }

        

        public async Task<bool> PostojiEmail(string text)
        {
            var list = await _serviceK.Get<List<KupacModel>>(null);
            foreach (var item in list)
            {
                if (item.Email==text)
                {
                    return true;
                }
            }
            return false;
        }
        private string _korisnickoIme;
        public string KorisnickoIme
        {
            get { return _korisnickoIme; }
            set { SetProperty(ref _korisnickoIme, value); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        private string _potvrdaPassworda;

     
        public string PotvrdaPassworda
        {
            get { return _potvrdaPassworda; }
            set { SetProperty(ref _potvrdaPassworda, value); }
        }




    }
}
