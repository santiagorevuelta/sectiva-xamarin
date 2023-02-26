using System;
using Android.App;
using Android.OS;
using Android.Widget;

namespace SectivaParking
{
    public class LoginActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            EditText editTextUser = FindViewById<EditText>(Resource.Id.editTextUser);
            EditText passwordEditText = FindViewById<EditText>(Resource.Id.editTextPassword);
            Button AccountButton = FindViewById<Button>(Resource.Id.buttonAccount);
            Button loginButton = FindViewById<Button>(Resource.Id.buttonLogin);

            loginButton.Click += (sender, e) =>
            {
               
            };


        }
    }

}

