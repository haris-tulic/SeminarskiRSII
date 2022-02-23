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
    public partial class OcjenaPage : ContentPage
    {
        RecenzijaViewModel model;
        public OcjenaPage()
        {
            InitializeComponent();
            BindingContext = model = new RecenzijaViewModel();
        }
        void OcjenaChanged(object sender, EventArgs args)
        {
            RadioButton ocjena = sender as RadioButton;
            var clicked = ocjena.IsChecked;
            if (clicked)
            {
                model.OcjenaS = ocjena.Value.ToString();
                model.Ocjena = int.Parse(model.OcjenaS);
            }
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Ucitaj();
        }
    }
}