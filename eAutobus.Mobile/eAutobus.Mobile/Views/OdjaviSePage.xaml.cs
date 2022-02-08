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
    public partial class OdjaviSePage : ContentPage
    {
        OdjaviSeViewModel model = null;
        public OdjaviSePage()
        {
            InitializeComponent();
            BindingContext = model = new OdjaviSeViewModel();
        }

        protected  override void OnAppearing()
        {
            base.OnAppearing();
            model.OdjaviSe();
        }
    }
}