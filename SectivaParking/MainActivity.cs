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
       protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
           
            var accountButton = FindViewById<Button>(Resource.Id.buttonAccount);
            var loginButton = FindViewById<Button>(Resource.Id.buttonLogin);
            
            loginButton.Click += (sender, e) =>
            {
                var editTextUser = FindViewById<EditText>(Resource.Id.editTextUser);
                var passwordEditText = FindViewById<EditText>(Resource.Id.editTextPassword);
                if (editTextUser.Text.Equals(""))
                {
                    Toast.MakeText(this, "El usuario es obligatorio", ToastLength.Long)?.Show();
                    return;
                }if (passwordEditText.Text.Equals(""))
                {
                    Toast.MakeText(this, "La contraseña es obligatoria", ToastLength.Long)?.Show();
                    return;
                }
                new NavigationMenu(new MainTabs());
            };
            
            accountButton.Click += (sender, e) =>
            {
               new SignUp();
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
            SetContentView(Resource.Layout.fracment_cars);
            // Fragment fragment =  id switch
            // {
            //     Resource.Id.menu_home => new Fragment(),
            //     Resource.Id.menu_cars => new Fragment(),
            //     Resource.Id.menu_pago => new Fragment(),
            //     Resource.Id.menu_park => new Fragment(),
            //     Resource.Id.menu_profile => new Fragment(),
            //     _ => null
            // };
            //
            return base.OnOptionsItemSelected(item);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
	}
}

