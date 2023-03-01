using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace SectivaParking
{
    public class SignUp: Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.signUp);
            var accountButton = FindViewById<Button>(Resource.Id.buttonAccount);
            var buttonCancel = FindViewById<Button>(Resource.Id.buttonCancel);

            buttonCancel.Click += (sender, e) =>
            {
                SetContentView(Resource.Layout.activity_main);
            };

            accountButton.Click += (sender, e) =>
            {
                var txtNombres = FindViewById<EditText>(Resource.Id.txtNombres);
                var txtApellidos = FindViewById<EditText>(Resource.Id.txtApellidos);
                var txtEmail = FindViewById<EditText>(Resource.Id.txtEmail);
                var txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
                if (txtNombres.Text.Equals(""))
                {
                    Toast.MakeText(this, "El campo nombre es obligatorio", ToastLength.Long)?.Show();
                    return;
                }
                if (txtApellidos.Text.Equals(""))
                {
                    Toast.MakeText(this, "El campo apellidos es obligatorio", ToastLength.Long)?.Show();
                    return;
                }
                if (txtEmail.Text.Equals(""))
                {
                    Toast.MakeText(this, "El campo correo es obligatorio", ToastLength.Long)?.Show();
                    return;
                }
                if (txtPassword.Text.Equals(""))
                {
                    Toast.MakeText(this, "El campo contraseña es obligatorio", ToastLength.Long)?.Show();
                    return;
                }
                Toast.MakeText(this, "Registro exitoso", ToastLength.Long)?.Show();
                SetContentView(Resource.Layout.activity_main);
            };
        }

    }
}