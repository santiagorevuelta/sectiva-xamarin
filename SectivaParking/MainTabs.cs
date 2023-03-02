using System;
using Android.App;
using Android.OS;
using AndroidX.AppCompat.App;
using Google.Android.Material.BottomNavigation;
using Java.Util;
using Fragment = AndroidX.Fragment.App.Fragment;

namespace SectivaParking
   {[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class MainTabs : AppCompatActivity
    {
        public static BottomNavigationView bottomnavigation;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_tabs_main);
            bottomnavigation = FindViewById<BottomNavigationView>(Resource.Id.bottom_navigation_view);
            bottomnavigation.NavigationItemSelected += NavigationItemSelected;
            LoadFragment(Resource.Id.menu_home);
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
                case Resource.Id.menu_pago:
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

