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
        OcjenaViewModel model;
        public OcjenaPage()
        {
            InitializeComponent();
            BindingContext = model = new OcjenaViewModel();
        }
        void OcjenaChanged(object sender, EventArgs args)
        {
            RadioButton ocjena = sender as RadioButton;
            //model.Ocjena = ocjena.IsChecked;
            //model.OcjenaS = ocjena.Value.ToString();
        }
    }
}