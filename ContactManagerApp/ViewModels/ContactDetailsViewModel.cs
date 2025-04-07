using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactManagerApp.Models;

namespace ContactManagerApp.ViewModels
{
    public partial class ContactDetailsViewModel : ObservableObject, IQueryAttributable
    {
        [ObservableProperty] private Models.Contact? selectedContact;
        [ObservableProperty] private bool isEditing;

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query.TryGetValue("SelectedContact", out var contact))
            {
                SelectedContact = contact as ContactManagerApp.Models.Contact;
            }
        }
        [RelayCommand]
        private void EditContact() => IsEditing = true;

        [RelayCommand]
        private void SaveChanges() => IsEditing = false;

        [RelayCommand]
        private async Task GoBack() => await Shell.Current.GoToAsync("..");
    }
}
