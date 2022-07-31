using IBMS_MOVIL.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace IBMS_MOVIL.Views
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