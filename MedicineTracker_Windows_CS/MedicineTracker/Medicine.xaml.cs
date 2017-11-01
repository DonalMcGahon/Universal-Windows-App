using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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
    public sealed partial class Medicine : Page
    {
        private MobileServiceCollection<TodoItem, TodoItem> items;
#if OFFLINE_SYNC_ENABLED
        private IMobileServiceSyncTable<TodoItem> todoTable = App.MobileService.GetSyncTable<TodoItem>(); // offline sync
#else
        private IMobileServiceTable<TodoItem> todoTable = App.MobileService.GetTable<TodoItem>();
#endif

        public Medicine()
        {
            this.InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
#if OFFLINE_SYNC_ENABLED
            await InitLocalStoreAsync(); // offline sync
#endif
            ButtonRefresh_Click(this, null);
        }

        private async Task InsertTodoItem(TodoItem todoItem)
        {
            // This code inserts a new TodoItem into the database. After the operation completes
            // and the mobile app backend has assigned an id, the item is added to the CollectionView.
            await todoTable.InsertAsync(todoItem);
            items.Add(todoItem);

#if OFFLINE_SYNC_ENABLED
            await App.MobileService.SyncContext.PushAsync(); // offline sync
#endif
        }

        private async Task RefreshTodoItems()
        {
            MobileServiceInvalidOperationException exception = null;
            try
            {
                // This code refreshes the entries in the list view by querying the TodoItems table.
                // The query excludes completed TodoItems.
                items = await todoTable
                    .Where(todoItem => todoItem.Complete == false)
                    .ToCollectionAsync();
            }
            catch (MobileServiceInvalidOperationException e)
            {
                exception = e;
            }

            if (exception != null)
            {
                await new MessageDialog(exception.Message, "Error loading items").ShowAsync();
            }
            else
            {
                //ListItems.ItemsSource = items;
                this.ButtonSave.IsEnabled = true;
            }
        }

        private async Task UpdateCheckedTodoItem(TodoItem item)
        {
            // This code takes a freshly completed TodoItem and updates the database.
            // After the MobileService client responds, the item is removed from the list.
            await todoTable.UpdateAsync(item);
            items.Remove(item);
            //ListItems.Focus(Windows.UI.Xaml.FocusState.Unfocused);

#if OFFLINE_SYNC_ENABLED
            await App.MobileService.SyncContext.PushAsync(); // offline sync
#endif
        }

        private async void ButtonRefresh_Click(object sender, RoutedEventArgs e)
        {
            //ButtonRefresh.IsEnabled = false;

#if OFFLINE_SYNC_ENABLED
            await SyncAsync(); // offline sync
#endif
            await RefreshTodoItems();

            //ButtonRefresh.IsEnabled = true;
        }

        private async void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            var todoItem = new TodoItem
            {
                pName = TextInput.Text,
                Med = TextInput2.Text,
                Dose = TextInput3.Text,
                Time = TextInput4.Text,
                Date = textBox_Copy.Text,
            };
            TextInput.Text = "";
            TextInput2.Text = "";
            TextInput3.Text = "";
            TextInput4.Text = "";
            textBox_Copy.Text = "";
            await InsertTodoItem(todoItem);
            this.Frame.Navigate(typeof(MedList));
        }

        private async void CheckBoxComplete_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            TodoItem item = cb.DataContext as TodoItem;
            await UpdateCheckedTodoItem(item);
        }

        private void TextInput_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                ButtonSave.Focus(FocusState.Programmatic);
            }
        }

        #region Offline sync
#if OFFLINE_SYNC_ENABLED
        private async Task InitLocalStoreAsync()
        {
           if (!App.MobileService.SyncContext.IsInitialized)
           {
               var store = new MobileServiceSQLiteStore("localstore.db");
               store.DefineTable<TodoItem>();
               await App.MobileService.SyncContext.InitializeAsync(store);
           }

           await SyncAsync();
        }

        private async Task SyncAsync()
        {
           await App.MobileService.SyncContext.PushAsync();
           await todoTable.PullAsync("todoItems", todoTable.CreateQuery());
        }
#endif
        #endregion

        // Calendar Button
        #region
        private void CalendarDatePicker_DateChanged(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args)
        {
            calendar.IsCalendarOpen = false;
            textBox_Copy.Text = args.NewDate?.DateTime.ToString("dd/MM/yyyy");
        }

        private void textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            calendar.IsCalendarOpen = true;
        }

        #endregion

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(WelcomePage));
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

        private void MenuButton4_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
