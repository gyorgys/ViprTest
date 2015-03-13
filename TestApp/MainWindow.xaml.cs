using MSAAuthControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using oneDrive;
using Microsoft.OData.ProxyExtensions;

namespace TestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isSignedIn = false;
        private OAuthResult signInResult;
        private oneDrive.oneDrive oneDriveClient;

        public MainWindow()
        {
            InitializeComponent();
            SetSignInStatus(null);
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            if (isSignedIn)
            {
                SetSignInStatus(null);
            }
            else
            {
                var result = Authenticator.GetAccessToken("00000000440E7C08", "wl.basic wl.offline_access wl.skydrive", false);
                SetSignInStatus(result);
            }
            
        }

        private void SetSignInStatus(OAuthResult result)
        {
            if(result == null || result.Status != OAuthResultStatus.Success)
            {
                isSignedIn = false;
                signInResult = null;
                oneDriveClient = null;

                loginButton.Content = "Log in";
                userNameLabel.Text = "";
            }
            else
            {
                isSignedIn = true;
                signInResult = result;

                loginButton.Content = "Log out";
                userNameLabel.Text = result.UserId;

                oneDriveClient = new oneDrive.oneDrive(new Uri("https://api.onedrive.com/v1.0"), getTokenAsync);
            }

            signedInUI.Visibility = isSignedIn ? Visibility.Visible : Visibility.Collapsed;
        }

        private Task<string> getTokenAsync()
        {
            return Task<string>.Factory.StartNew(() => { 
                return signInResult.AccessToken; 
            });
        }

        private void getRootButton_Click(object sender, RoutedEventArgs e)
        {
            itemsList.Items.Clear();
            IReadOnlyQueryableSet<Iitem> rootItems = oneDriveClient.drive.items["root"].children.Expand("thumbnails");

            LoadItemsPage(rootItems.ExecuteAsync());

        }

        private async void LoadItemsPage(Task<IPagedCollection<Iitem>> task, bool allPages = true)
        {
            IPagedCollection<Iitem> items = await task;
            foreach (Iitem item in items.CurrentPage)
            {
                itemsList.Items.Add(new OneDriveListItem(item));
            }

            if (items.MorePagesAvailable && allPages)
            {
                LoadItemsPage(items.GetNextPageAsync());
            }
        }

        private void itemsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (OneDriveListItem)itemsList.SelectedItem;
            if (selectedItem != null)
            {
                Iitem item = selectedItem.Item;
                if (item.thumbnails != null && item.thumbnails.CurrentPage.Count > 0)
                {
                    thumbnailImg.Visibility = Visibility.Visible;
                    thumbnailImg.Source = new BitmapImage( new Uri(item.thumbnails.CurrentPage[0].medium.url) );
                } else {
                    thumbnailImg.Visibility = Visibility.Hidden;
                }
            }

        }

        private void itemsList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedItem = (OneDriveListItem)itemsList.SelectedItem;
            Iitem item = selectedItem.Item;

            if (item.folder != null && item.folder.childCount > 0)
            {
                itemsList.Items.Clear();
                IReadOnlyQueryableSet<Iitem> childItems = oneDriveClient.drive.items[item.id].children.Expand("thumbnails");
                LoadItemsPage(childItems.ExecuteAsync());

            }
        }

        private async void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = (OneDriveListItem)itemsList.SelectedItem;
            if (selectedItem != null)
            {
                Iitem item = selectedItem.Item;
                await item.DeleteAsync();

            }

        }

        private async void allPhotosButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = (OneDriveListItem)itemsList.SelectedItem;
            if (selectedItem != null)
            {
                Iitem item = selectedItem.Item;
                if (item.folder != null)
                {
                    itemsList.Items.Clear();
                    var allPhotos = oneDriveClient.drive.items[item.id].children; //.allPhotosAsync();
                    
                    LoadItemsPage(allPhotos.ExecuteAsync());

                }
            }

            itemsList.Items.Clear();

        }


    }
}
