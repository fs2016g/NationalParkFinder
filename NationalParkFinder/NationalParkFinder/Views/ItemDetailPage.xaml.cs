using System.ComponentModel;
using Xamarin.Forms;
using NationalParkFinder.ViewModels;

namespace NationalParkFinder.Views
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
