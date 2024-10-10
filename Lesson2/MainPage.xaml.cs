using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Lesson2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //method to create a dialog box
        public async void showMessage(string message)
        {
            var dialog = new ContentDialog()
            {
                Title = "COMMAND TYPES",
                Content = message,
                CloseButtonText = "OKAY"
            };
            await dialog.ShowAsync();
        }
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnViewOutput(object sender, RoutedEventArgs e)
        {
            //call the dialog box method 
            showMessage("You've clicked successfully");
            //to navigate to a page called Home
            Frame.Navigate(typeof(Home));
        }
    }
}
