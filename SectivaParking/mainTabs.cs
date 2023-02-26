using System;
using Android.App;
using Android.OS;
using Google.Android.Material.BottomNavigation;
using Fragment = AndroidX.Fragment.App.Fragment;

namespace SectivaParking
{
    public class MainTabs : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_tabs_main);
            var bottomNavigationView = FindViewById<BottomNavigationView>(Resource.Id.bottom_navigation_view);
            bottomNavigationView.NavigationItemSelected += BottomNavigationView_NavigationItemSelected;
            LoadFragment(Resource.Id.menu_home);
        }

        private void BottomNavigationView_NavigationItemSelected(object sender, BottomNavigationView.NavigationItemSelectedEventArgs e)
        {
            LoadFragment(e.Item.ItemId);
        }

        private void LoadFragment(int id)
        {
            Fragment fragment = null;
            switch (id)
            {
                case Resource.Id.menu_home:
                    fragment = new Fragment();
                    break;
                case Resource.Id.menu_cars:
                    fragment = new Fragment();
                    break;
                case Resource.Id.menu_pago:
                    fragment = new Fragment();
                    break;
                case Resource.Id.menu_park:
                    fragment = new Fragment();
                    break;
                case Resource.Id.menu_profile:
                    fragment = new Fragment();
                    break;
            }

            if (fragment == null)
                return;

           // var fragmentManager = SupportFragmentManager.BeginTransaction();
            //fragmentManager.Replace(Resource.Id.fragment_container, fragment);
            //fragmentManager.Commit();
        }

    }

}

