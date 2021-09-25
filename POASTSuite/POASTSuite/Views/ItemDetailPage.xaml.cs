using System.ComponentModel;
using Xamarin.Forms;
using POASTSuite.ViewModels;

namespace POASTSuite.Views
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