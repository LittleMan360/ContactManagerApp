using ContactManagerApp.Models;
using ContactManagerApp.ViewModels;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;

namespace ContactManagerApp.Views
{
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        private void OnContactSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is ContactManagerApp.Models.Contact contact)
            {
                Shell.Current.GoToAsync("ContactDetailsPage", new Dictionary<string, object>
                {
                    { "SelectedContact", contact }
                });
            }

            ((CollectionView)sender).SelectedItem = null;
        }

        private void OnAddNewClicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//MainPage");
        }
    }
}
