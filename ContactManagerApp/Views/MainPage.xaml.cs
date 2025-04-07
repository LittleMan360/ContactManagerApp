using ContactManagerApp.ViewModels;
using Microsoft.Maui.Controls;

namespace ContactManagerApp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}
