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
        EditText txtNombres;
        EditText txtApellidos;
        EditText txtEmail;
        EditText txtPassword;
        Button accountButton;
        Button buttonCancel;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.signUp);
            accountButton = FindViewById<Button>(Resource.Id.buttonAccount);
            buttonCancel = FindViewById<Button>(Resource.Id.buttonCancel);
            
            buttonCancel.Click += (sender, e) =>
            {
                SetContentView(Resource.Layout.activity_main);
                throw new System.NotImplementedException();
            };

            accountButton.Click += (sender, e) =>
            {
                 txtNombres = FindViewById<EditText>(Resource.Id.txtNombres);
                 txtApellidos = FindViewById<EditText>(Resource.Id.txtApellidos);
                 txtEmail = FindViewById<EditText>(Resource.Id.txtEmail);
                 txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
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