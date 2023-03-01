using System;
using Android.App;
using Android.OS;
using Google.Android.Material.BottomNavigation;
using Java.Util;
using Fragment = AndroidX.Fragment.App.Fragment;

namespace SectivaParking
{
    public class MainTabs : MainActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_tabs_main);
            var bottomNavigationView = FindViewById<BottomNavigationView>(Resource.Id.bottom_navigation_view);
            bottomNavigationView.NavigationItemSelected += BottomNavigationView_NavigationItemSelected;
        }

        private void BottomNavigationView_NavigationItemSelected(object sender, BottomNavigationView.NavigationItemSelectedEventArgs e)
        {
            LoadFragment(e.Item.ItemId);
        }

        private void LoadFragment(int id)
        {
            switch (id)
            {
                case Resource.Id.menu_home:
                    SetContentView(Resource.Layout.activity_tabs_main);
                    return;
                case Resource.Id.menu_cars:
                    SetContentView(Resource.Layout.activity_tabs_main);
                    return;
            }
        }

    }

}

