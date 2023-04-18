using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SectivaParking
{
    public class Update : Activity
    {
        EditText txtId;
        EditText txtName;
        EditText txtLast;
        EditText txtEmail;
        EditText txtPassword;
        Button btnUpdate;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Update);
            txtId = FindViewById<EditText>(Resource.Id.txtId);
            txtEmail = FindViewById<EditText>(Resource.Id.txtEmail);
            txtLast = FindViewById<EditText>(Resource.Id.txtLastName);
            txtEmail = FindViewById<EditText>(Resource.Id.txtEmail);
            txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
            btnUpdate = FindViewById<Button>(Resource.Id.btnUpdate);

            btnUpdate.Click += BtnUpdate_Click;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text) &&
                !string.IsNullOrEmpty(txtName.Text) &&
                !string.IsNullOrEmpty(txtLast.Text) &&
                !string.IsNullOrEmpty(txtEmail.Text) &&
                !string.IsNullOrEmpty(txtPassword.Text))
            {
                new Connection().Insertar(new Login()
                {
                    Id = new Connection().BuscarCedula(txtId.Text).Id,
                    Name = txtName.Text.Trim().ToLower(),
                    LastName = txtLast.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                });
                Intent i = new Intent(this, typeof(MainActivity));
                StartActivity(i);
            }
            else
            {
                Toast.MakeText(this, "Complete los campos", ToastLength.Long).Show();
            }

        }
    }
}