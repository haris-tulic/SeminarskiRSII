using eAutobus.Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace eAutobus.Mobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}