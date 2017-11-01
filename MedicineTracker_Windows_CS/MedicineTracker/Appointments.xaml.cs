using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Appointments;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MedicineTracker
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Appointments : Page
    {
        public Appointments()
        {
            this.InitializeComponent();
        }

        private async void Add_Click(object sender, RoutedEventArgs e)
        {
            // Reference link for code below, for adding events - http://stackoverflow.com/questions/38355922/system-argumentexception-in-app-when-accepting-appointment

            var rect = new Rect(new Point(Window.Current.Bounds.Width / 2, Window.Current.Bounds.Height / 2), new Size());
            DateTimeOffset date = StartDate.Date;
            TimeSpan time = StartTime.Time;
            int minutes = int.Parse((string)((ComboBoxItem)Duration.SelectedItem).Tag);

            // Creating a new Event
            Appointment newEvent = new Appointment()
            {
                // Creating a date and time values and getting the current date from OS using TimeZoneInfo.Local.GetUtcOffset(DateTime.Now)
                Subject = Subject.Text,
                Location = Location.Text,
                Details = Details.Text,
                StartTime = new DateTimeOffset(date.Year, date.Month, date.Day, time.Hours, time.Minutes, 0, TimeZoneInfo.Local.GetUtcOffset(DateTime.Now)),
                Duration = TimeSpan.FromMinutes(minutes)
            };
            // The following line triggers the launch of the calendar app for the user to confirm adding the appointment
            string id = await AppointmentManager.ShowAddAppointmentAsync(newEvent, rect, Placement.Default);

            // Empties all data entered
            StartDate.Date = DateTime.Now;
            StartTime.Time = DateTime.Now.TimeOfDay;
            Subject.Text = string.Empty;
            Details.Text = string.Empty;
            Location.Text = string.Empty;
            Duration.SelectedIndex = 0;
        }

        private async void Calendar_Click(object sender, RoutedEventArgs e)
        {
            // Opens Calendar App on the Current Date and Time
            await AppointmentManager.ShowTimeFrameAsync(StartDate.Date, StartTime.Time);
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void MenuButton1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Medicine));
        }

        private void MenuButton2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MedList));
        }

        private void MenuButton3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Appointments));
        }
    }
}
