using System;
using Maui.ToDo.Models.Navigation; 
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace Maui.ToDo
{
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            CollectionMenuView.SelectionChanged += CollectionMenuView_SelectionChanged;
        }

        private async void CollectionMenuView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { 
            var item = CollectionMenuView.SelectedItem as NavigationMenuItem;
            if (item == null) return;

            await Navigation.PushAsync(new ItemDetailView()
            {
                Title = item.Title
            });

            CollectionMenuView.SelectedItem = null;
        }
    }
}
