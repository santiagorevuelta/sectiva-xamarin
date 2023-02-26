﻿using Android.App;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace SectivaParking
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            EditText editTextUser = FindViewById<EditText>(Resource.Id.editTextUser);
            EditText passwordEditText = FindViewById<EditText>(Resource.Id.editTextPassword);
            Button AccountButton = FindViewById<Button>(Resource.Id.buttonAccount);
            Button loginButton = FindViewById<Button>(Resource.Id.buttonLogin);

            loginButton.Click += (sender, e) =>
            {
                Toast.MakeText(this, "El usuario es obligatorio", ToastLength.Short).Show();
                if (editTextUser.Equals(true))
                {
                    
                    return;
                }

                if (passwordEditText.Equals(true))
                {
                    Toast.MakeText(this, "Your message here", ToastLength.Short).Show();
                    return;
                }
            };
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
	}
}
