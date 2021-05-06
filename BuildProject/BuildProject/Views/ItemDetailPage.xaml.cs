using BuildProject.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace BuildProject.Views
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