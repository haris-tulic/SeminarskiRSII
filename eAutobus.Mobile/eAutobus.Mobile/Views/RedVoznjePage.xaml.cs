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
    public partial class RedVoznjePage : ContentPage
    {
        RedVoznjeViewModel raspored;
        public RedVoznjePage()
        {
            InitializeComponent();
            BindingContext = raspored = new RedVoznjeViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
             await raspored.Pretrazi();
        }

        //private async void  RedVoznjeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    var trenutni = (e.CurrentSelection.FirstOrDefault() as RasporedVoznjeModel)?.RasporedVoznjeID;
        //    await raspored.PrikazOcjene(trenutni);
            
        //}

        //private void DatePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        //{
        //    var datum = sender as DatePicker;
        //    datum.MinimumDate = DateTime.Now;
        //}
    }
}