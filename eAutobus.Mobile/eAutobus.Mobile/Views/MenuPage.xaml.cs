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

    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        
        List<HomeMenuItem> menuItems;

        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem{Id=MenuItemsType.Pocetna, Title="Početna" },
                new HomeMenuItem{Id=MenuItemsType.Cjenovnik, Title="Cjenovnik" },
                new HomeMenuItem{Id=MenuItemsType.Ocjena, Title="Ocjena" },
                new HomeMenuItem{Id=MenuItemsType.RedVoznje, Title="Red vožnje" },
                new HomeMenuItem{Id=MenuItemsType.HistorijaKarata, Title="Historija kupovine"},
                new HomeMenuItem{Id=MenuItemsType.RezervacijaKarte, Title="Karta" },
                new HomeMenuItem{Id=MenuItemsType.OdjaviSe, Title="Odjavi se" },


            };
           

                ListViewMenu.ItemsSource = menuItems;

                ListViewMenu.SelectedItem = menuItems[0];
                ListViewMenu.ItemSelected += async (sender, e) =>
                {
                    if (e.SelectedItem == null)
                        return;

                    var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                  
                    await  RootPage.NavigateFromMenu(id);
                };
            }

       
    }
}