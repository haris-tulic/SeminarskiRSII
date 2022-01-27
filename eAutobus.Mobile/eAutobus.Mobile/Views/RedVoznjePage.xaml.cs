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
        RedVoznjeViewModel raspored = null;
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
    }
}