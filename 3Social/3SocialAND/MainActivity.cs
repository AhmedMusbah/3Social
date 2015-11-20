using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Webkit;

namespace _3SocialAND
{
    [Activity(Label = "3Social", Icon = "@drawable/social", Theme = "@android:style/Theme.Holo.Light")]
    public class MainActivity : Activity
    {
        bool facebook = false;
        bool twitter = false;
        bool instagram = false;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
        }

        /*
		 * attach the menu to the menu button of the device
		 * for this activity
		 */
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            base.OnCreateOptionsMenu(menu);

            MenuInflater inflater = this.MenuInflater;

            inflater.Inflate(Resource.Menu.mainmenu, menu);

            return true;
        }

        /// <param name="item">The menu item that was selected.</param>
		/// <summary>
		/// This hook is called whenever an item in your options menu is selected.
		/// </summary>
		/// <returns>To be added.</returns>
		public override bool OnOptionsItemSelected(IMenuItem item)
        {
            base.OnOptionsItemSelected(item);

            WebView webFacebook = FindViewById<WebView>(Resource.Id.webFacebook);
            webFacebook.SetWebViewClient(new WebViewClient());
            webFacebook.Visibility = ViewStates.Gone;
            webFacebook.Settings.JavaScriptEnabled = true;

            WebView webTwitter = FindViewById<WebView>(Resource.Id.webTwitter);
            webTwitter.SetWebViewClient(new WebViewClient());
            webTwitter.Visibility = ViewStates.Gone;
            webTwitter.Settings.JavaScriptEnabled = true;

            WebView webInstagram = FindViewById<WebView>(Resource.Id.webInstagram);
            webInstagram.SetWebViewClient(new WebViewClient());
            webInstagram.Visibility = ViewStates.Gone;
            webInstagram.Settings.JavaScriptEnabled = true;

            switch (item.ItemId)
            {
                case Resource.Id.btnFacebook:
                    {
                        webFacebook.Visibility = ViewStates.Visible;
                        webTwitter.Visibility = ViewStates.Gone;
                        webInstagram.Visibility = ViewStates.Gone;

                        if (facebook == false)
                        {
                            webFacebook.LoadUrl("http://www.facebook.com");

                            facebook = true;
                        }

                        break;
                    }

                case Resource.Id.btnTwitter:
                    {
                        webFacebook.Visibility = ViewStates.Gone;
                        webTwitter.Visibility = ViewStates.Visible;
                        webInstagram.Visibility = ViewStates.Gone;

                        if (twitter == false)
                        {
                            webTwitter.LoadUrl("http://www.twitter.com");

                            twitter = true;
                        }

                        break;
                    }

                case Resource.Id.btnInstagram:
                    {
                        webFacebook.Visibility = ViewStates.Gone;
                        webTwitter.Visibility = ViewStates.Gone;
                        webInstagram.Visibility = ViewStates.Visible;

                        if (instagram == false)
                        {
                            webInstagram.LoadUrl("http://www.instagram.com");

                            instagram = true;
                        }

                        break;
                    }
            }

            return true;
        }
    }
}

