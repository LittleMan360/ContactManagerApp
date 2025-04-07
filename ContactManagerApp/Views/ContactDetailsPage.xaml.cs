using ContactManagerApp.ViewModels;
using Microsoft.Maui.Controls;

namespace ContactManagerApp.Views
{
    public partial class ContactDetailsPage : ContentPage
    {
        public ContactDetailsPage(ContactDetailsViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}
