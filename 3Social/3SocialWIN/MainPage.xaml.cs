using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _3SocialWIN
{
    public sealed partial class MainPage : Page
    {
        bool facebook = false;
        bool twitter = false;
        bool instagram = false;

        public MainPage()
        {
            InitializeComponent();

            btnFacebook_Click(null, null);
        }

        private async void btnFacebook_Click(object sender, RoutedEventArgs e)
        {
            stkFacebook.Visibility = Visibility.Visible;
            stkTwitter.Visibility = Visibility.Collapsed;
            stkInstagram.Visibility = Visibility.Collapsed;
            btnFacebook.IsEnabled = false;
            btnTwitter.IsEnabled = true;
            btnInstagram.IsEnabled = true;

            if (facebook == false)
            {
                try
                {
                    var url = new Uri("https://www.facebook.com/");
                    webFacebook.Navigate(url);
                }
                catch (Exception ex)
                {
                    var cd = new ContentDialog();
                    cd.Title = "Check your Internet connectivity.";
                    cd.Content = ex.ToString();
                    await cd.ShowAsync();
                }

                facebook = true;
            }
        }

        private async void btnTwitter_Click(object sender, RoutedEventArgs e)
        {
            stkFacebook.Visibility = Visibility.Collapsed;
            stkTwitter.Visibility = Visibility.Visible;
            stkInstagram.Visibility = Visibility.Collapsed;
            btnFacebook.IsEnabled = true;
            btnTwitter.IsEnabled = false;
            btnInstagram.IsEnabled = true;

            if (twitter == false)
            {
                try
                {
                    var url = new Uri("https://www.twitter.com/");
                    webTwitter.Navigate(url);
                }
                catch (Exception ex)
                {
                    var cd = new ContentDialog();
                    cd.Title = "Check your Internet connectivity.";
                    cd.Content = ex.ToString();
                    await cd.ShowAsync();
                }

                twitter = true;
            }
        }

        private async void btnInstagram_Click(object sender, RoutedEventArgs e)
        {
            stkFacebook.Visibility = Visibility.Collapsed;
            stkTwitter.Visibility = Visibility.Collapsed;
            stkInstagram.Visibility = Visibility.Visible;
            btnFacebook.IsEnabled = true;
            btnTwitter.IsEnabled = true;
            btnInstagram.IsEnabled = false;

            if (instagram == false)
            {
                try
                {
                    var url = new Uri("https://www.instagram.com/");
                    webInstagram.Navigate(url);
                }
                catch (Exception ex)
                {
                    var cd = new ContentDialog();
                    cd.Title = "Check your Internet connectivity.";
                    cd.Content = ex.ToString();
                    await cd.ShowAsync();
                }

                instagram = true;
            }
        }
    }
}
