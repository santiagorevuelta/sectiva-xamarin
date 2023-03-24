using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace SectivaParking
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", ParentActivity = typeof(MainActivity))]
    public class SignUp: Activity
    {
        EditText _txtName;
        EditText _txtCc;
        EditText txtLastName;
        EditText txtEmail;
        EditText txtPassword;
        Button accountButton;
        //Button buttonCancel;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.signUp);
            accountButton = FindViewById<Button>(Resource.Id.buttonAccount);
            //buttonCancel = FindViewById<Button>(Resource.Id.buttonCancel);

            //buttonCancel.Click += BtnCancel_Click;
            accountButton.Click += BtnSignUp_Click;
        }

        
        private void BtnSignUp_Click(object sender, System.EventArgs e)
        {
            _txtName = FindViewById<EditText>(Resource.Id.txtName);
            _txtCc = FindViewById<EditText>(Resource.Id.txtCc);
            txtLastName = FindViewById<EditText>(Resource.Id.txtLastName);
            txtEmail = FindViewById<EditText>(Resource.Id.txtEmail);
            txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
            if (_txtCc.Text.Equals(""))
            {
                Toast.MakeText(this, "El campo identificador es obligatorio", ToastLength.Long)?.Show();
                return;
            }
            if (_txtName.Text.Equals(""))
            {
                Toast.MakeText(this, "El campo nombre es obligatorio", ToastLength.Long)?.Show();
                return;
            }
            if (txtLastName.Text.Equals(""))
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
            //var intent = new Intent(this, typeof(MainActivity));
            //StartActivity(intent);
        }
        
        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            //var intent = new Intent(this, typeof(MainActivity));
            //StartActivity(intent);
        }
        
    }
}