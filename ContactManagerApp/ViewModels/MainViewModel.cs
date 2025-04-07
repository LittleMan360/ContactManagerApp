using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactManagerApp.Models;
using System.Collections.ObjectModel;

namespace ContactManagerApp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public ObservableCollection<Models.Contact> Contacts { get; } = new();

        [ObservableProperty] private string name = string.Empty;
        [ObservableProperty] private string email = string.Empty;
        [ObservableProperty] private string phoneNumber = string.Empty;
        [ObservableProperty] private string description = string.Empty;

        [RelayCommand]
        private async Task SaveContact()
        {
            Contacts.Add(new Models.Contact
            {
                Name = Name,
                Email = Email,
                PhoneNumber = PhoneNumber,
                Description = Description
            });

            Name = Email = PhoneNumber = Description = string.Empty;
            await Shell.Current.GoToAsync("//ContactsPage");
        }
    }
}
