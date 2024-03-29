using System.ComponentModel;
using Xamarin.Forms;
using задачни.ViewModels;

namespace задачни.Views
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