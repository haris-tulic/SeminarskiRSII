using eAutobus.Mobile.ViewModels;
using eAutobus.Mobile.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace eAutobus.Mobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(CjenovnikPage), typeof(CjenovnikPage));
            Routing.RegisterRoute(nameof(RedVoznjePage), typeof(RedVoznjePage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(RegistracijaPage), typeof(RegistracijaPage));
            Routing.RegisterRoute(nameof(OcjenaPage), typeof(OcjenaPage));
            Routing.RegisterRoute(nameof(RezervacijaKartePage), typeof(RezervacijaKartePage));




        }

    }
}
