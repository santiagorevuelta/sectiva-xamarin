using System;
using Android.App;
using Android.OS;
using AndroidX.AppCompat.App;
using Google.Android.Material.BottomNavigation;
using Java.Util;
using Fragment = AndroidX.Fragment.App.Fragment;

namespace SectivaParking
   {[Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar")]
    public class MainTabs : AppCompatActivity
    {
        private static BottomNavigationView _navigation;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_tabs_main);
            _navigation = FindViewById<BottomNavigationView>(Resource.Id.bottom_navigation_view);
            _navigation.NavigationItemSelected += NavigationItemSelected;
            _navigation.SelectedItemId = Resource.Id.menu_home;
            LoadFragment(Resource.Id.menu_home);
        }
        protected bool OnBackButtonPressed()
        {
            return true;    
        }
        public void NavigationItemSelected(object sender, BottomNavigationView.NavigationItemSelectedEventArgs e) {
            LoadFragment(e.Item.ItemId);
        }

        public void LoadFragment(int id) {
            var frag = SupportFragmentManager.BeginTransaction();
            switch (id) {
                case Resource.Id.menu_home:
                    frag.Replace(Resource.Id.fragment_container, new Home());
                    break;
                case Resource.Id.menu_cars:
                    frag.Replace(Resource.Id.fragment_container, new Cars());
                    break;
                case Resource.Id.menu_pay:
                    frag.Replace(Resource.Id.fragment_container, new Pay());
                    break;
                case Resource.Id.menu_park:
                    frag.Replace(Resource.Id.fragment_container, new Parck());
                    break;
                case Resource.Id.menu_profile:
                    frag.Replace(Resource.Id.fragment_container, new Profile());
                    break;
            }
            frag.Commit();
        }

    }

}

