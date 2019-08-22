﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PhotoLibraryApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DeletePhoto : Page
    {

        public DeletePhoto()
        {
            this.InitializeComponent();
            this.DataContext = Picture.Collection;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
        }

        private void Cancel_Button_ClickAsync(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private async void Delete_Button_ClickAsync(object sender, RoutedEventArgs e)
        {   
            //Create message dialog and set contents
            var confirmation = new MessageDialog("Are you sure you want to delete these photos?");
            //Add commands and set their callbacks
            confirmation.Commands.Add(new UICommand("Yes, Delete Photos", new UICommandInvokedHandler(this.CommandInvokedHandler)));
            confirmation.Commands.Add(new UICommand("Cancel", new UICommandInvokedHandler(this.CommandInvokedHandler)));
            //set command that will be invoked by default & 
            confirmation.DefaultCommandIndex = 0;
            confirmation.CancelCommandIndex = 1;
            await confirmation.ShowAsync();
        }

        private void CommandInvokedHandler(IUICommand command)
        {
        }

        private void Album_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AlbumPage));
        }

        private void Collection_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void DeleteGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}