using Android.App;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.Internal;

namespace SectivaParking
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText editTextUser;
        EditText passwordEditText;
        Button accountButton;
        Button loginButton;
       protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            accountButton = FindViewById<Button>(Resource.Id.buttonAccount);
            loginButton = FindViewById<Button>(Resource.Id.buttonLogin);
            editTextUser = FindViewById<EditText>(Resource.Id.editTextUser);
            passwordEditText = FindViewById<EditText>(Resource.Id.editTextPassword);
            
            loginButton.Click += (sender, e) =>
            {
                if (editTextUser.Text.Equals(""))
                {
                    Toast.MakeText(this, "El usuario es obligatorio", ToastLength.Long)?.Show();
                    return;
                }if (passwordEditText.Text.Equals(""))
                {
                    Toast.MakeText(this, "La contraseña es obligatoria", ToastLength.Long)?.Show();
                    return;
                }
                SetContentView(Resource.Layout.activity_tabs_main);
            };
            
            accountButton.Click += (sender, e) =>
            {
                SetContentView(Resource.Layout.signUp);
            };
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            SetContentView(Resource.Layout.fracment_cars);
            return base.OnOptionsItemSelected(item);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
	}
}

