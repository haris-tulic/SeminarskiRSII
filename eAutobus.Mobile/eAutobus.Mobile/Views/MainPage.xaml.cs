using eAutobus.Mobile.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eAutobus.Mobile.Views
{
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> Menu = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();
            MasterBehavior = MasterBehavior.Popover;
            Menu.Add((int)MenuItemsType.Pocetna, (NavigationPage)Detail);
        }
        public async Task NavigateFromMenu(int id)
        {
            if (!Menu.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemsType.Pocetna:
                        Menu.Add(id, new NavigationPage(new PocetnaPage()));
                        break;
                    case (int)MenuItemsType.Ocjena:
                        Menu.Add(id, new NavigationPage(new OcjenaPage()));
                        break;
                    case (int)MenuItemsType.Cjenovnik:
                        Menu.Add(id, new NavigationPage(new CjenovnikPage()));
                        break;
                    case (int)MenuItemsType.RedVoznje:
                        Menu.Add(id, new NavigationPage(new RedVoznjePage()));
                        break;
                    case (int)MenuItemsType.HistorijaKarata:
                        Menu.Add(id, new NavigationPage(new HistorijaKarataPage()));
                        break;
                    case (int)MenuItemsType.RezervacijaKarte:
                        Menu.Add(id, new NavigationPage(new RezervacijaKartePage()));
                        break;
                    case (int)MenuItemsType.OdjaviSe:
                        Menu.Add(id, new NavigationPage(new OdjaviSePage()));
                        break;

                }
            }

            var newPage = Menu[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}