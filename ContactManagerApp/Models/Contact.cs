using CommunityToolkit.Mvvm.ComponentModel;

namespace ContactManagerApp.Models
{
    public partial class Contact : ObservableObject
    {
        [ObservableProperty]
        private string name;

        [ObservableProperty]
        private string email;

        [ObservableProperty]
        private string phoneNumber;

        [ObservableProperty]
        private string description;
    }
}
