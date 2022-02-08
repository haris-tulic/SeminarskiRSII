using eAutobus.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eAutobus.Mobile.ViewModels
{
    public class OdjaviSeViewModel:BaseViewModel
    {
        public  void OdjaviSe()
        {
            APIService.Username = string.Empty;
            APIService.Password = string.Empty;

            //Application.Current.MainPage=new LoginPage();
            Application.Current.MainPage = new NavigationPage(new AppShell());  
        }
    }
}
