using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.ComponentModel;

namespace SectivaParking
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText editTextUser;
        EditText passwordEditText;
        Button accountButton;
        Button loginButton;
        Button btnDelete;
        Button btnUpdate;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            accountButton = FindViewById<Button>(Resource.Id.buttonAccount);
            loginButton = FindViewById<Button>(Resource.Id.buttonLogin);
            editTextUser = FindViewById<EditText>(Resource.Id.editTextUser);
            passwordEditText = FindViewById<EditText>(Resource.Id.editTextPassword);
            btnDelete = FindViewById<Button>(Resource.Id.btnDelete);
            btnUpdate = FindViewById<Button>(Resource.Id.btnUpdate);

            btnDelete.Click += BtnDelete_Click;
            btnUpdate.Click += BtnUpdate_Click;

            loginButton.Click += BtnLogin_Click;
            accountButton.Click += BtnSigUp_Click;
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (new Connection().BuscarCedula(editTextUser.Text) != null && !string.IsNullOrEmpty(editTextUser.Text.Trim()))
            {
                Intent i = new Intent(this, typeof(Update));
                StartActivity(i);
            }
            else
            {
                Toast.MakeText(this, "Ingrese cédula", ToastLength.Long).Show();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(editTextUser.Text) && new Connection().BuscarCedula(editTextUser.Text) != null)
            {
                new Connection().EliminarUsuario(int.Parse(editTextUser.Text));
                Toast.MakeText(this, "Delete user sucessful", ToastLength.Long).Show();
                Intent i = new Intent(this, typeof(MainActivity));
                StartActivity(i);
            }
            else
            {
                Toast.MakeText(this, "Ingrese cédula", ToastLength.Long).Show();

            }

        }

        private void BtnLogin_Click(object sender, System.EventArgs e)
        {
            Login resultado = null;

            if (editTextUser.Text.Equals(""))
            {
                Toast.MakeText(this, "La cédula es obligatoria", ToastLength.Short)?.Show();
                return;
            }

            if (passwordEditText.Text.Equals(""))
            {
                Toast.MakeText(this, "La contraseña es obligatoria", ToastLength.Short)?.Show();
                return;
            }
            resultado = new Connection().SelecionarUsuario(editTextUser.Text, passwordEditText.Text.Trim());

            if (resultado != null)
            {
                string user = resultado.Name;
                Toast.MakeText(this, $"Bienvenido {user}", ToastLength.Short).Show();
                Intent intent = new Intent(this, typeof(MainTabs));
                StartActivity(intent);
            }
            else
            {
                Toast.MakeText(this, "No existe la cédula", ToastLength.Short).Show();
            }

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

