using ContactManagerApp.Views;

namespace ContactManagerApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Register navigation routes
        Routing.RegisterRoute("MainPage", typeof(MainPage));
        Routing.RegisterRoute("ContactsPage", typeof(ContactsPage));
        Routing.RegisterRoute("ContactDetailsPage", typeof(ContactDetailsPage));
    }
}
