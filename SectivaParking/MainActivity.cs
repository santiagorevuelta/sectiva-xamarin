using Android.App;
using Android.Content;
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

            loginButton.Click += BtnLogin_Click;
            accountButton.Click += BtnSigUp_Click;
        }
       
       private void BtnLogin_Click(object sender, System.EventArgs e)
       {
           if (editTextUser.Text.Equals(""))
           {
               Toast.MakeText(this, "El usuario es obligatorio", ToastLength.Long)?.Show();
               return;
           }
           
           if (passwordEditText.Text.Equals(""))
           {
               Toast.MakeText(this, "La contraseña es obligatoria", ToastLength.Long)?.Show();
               return;
           }

           var intent = new Intent(this, typeof(MainTabs));
           StartActivity(intent);
           Finish();
       }
       
       private void BtnSigUp_Click(object sender, System.EventArgs e)
       {
           var intent = new Intent(this, typeof(SignUp));
           StartActivity(intent);
       }
     
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
	}
}

