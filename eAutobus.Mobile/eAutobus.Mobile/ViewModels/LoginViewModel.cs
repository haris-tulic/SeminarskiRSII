using eAutobus.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eAutobus.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Kupac");
        public ICommand LoginCommand { get; }
        public ICommand RegistrujSeCommand { get; }
        private string _userName;
        private string _password;
        public string UserName
        {
            get { return _userName; }
            set { SetProperty(ref _userName, value); }
        }

        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            RegistrujSeCommand = new Command(async()=> await Registruj());
        }

        public async Task Registruj()
        {
            var route = $"{nameof(RegistracijaPage)}";
            await Application.Current.MainPage.Navigation.PushAsync(new RegistracijaPage());
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            //await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
            APIService.Username = UserName;
            APIService.Password = Password;
            try 
            {
                await _service.Get<dynamic>(null);
                Application.Current.MainPage= new MainPage();
            }
            catch (Exception)
            {
                await Application.Current.MainPage.DisplayAlert("Greška!", "Pogrešan username ili password!", "Uredu");
            }
        }
    }
}
