using MedicineTracker.Common;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

#if OFFLINE_SYNC_ENABLED
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;  // offline sync
using Microsoft.WindowsAzure.MobileServices.Sync;         // offline sync
#endif

namespace MedicineTracker
{
    public sealed partial class MainPage : Page
    {

        Login database;

        public MainPage()
        {
            this.InitializeComponent();
            database = new Login();
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            // If user enters correct details
            if (database.LoginUser(txtUser.Text, txtPassword.Password))
            {
                // Message will appear
                var message = new MessageDialog("Login Success");
                await message.ShowAsync();
                this.Frame.Navigate(typeof(Medicine));
            }
            // If user enters wrong details
            else
            {
                var message = new MessageDialog("Login Failed");
                await message.ShowAsync();
            }

        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Register));
        }

    }
}
