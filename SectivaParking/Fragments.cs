using System;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Webkit;

namespace SectivaParking
{
    public class Home : AndroidX.Fragment.App.Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
            return inflater.Inflate(Resource.Layout.fracment_home, container, false);
        }

    }  
    public class Cars : AndroidX.Fragment.App.Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
            return inflater.Inflate(Resource.Layout.fracment_cars, container, false);
        }

    }
    public class Pay : AndroidX.Fragment.App.Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
            return inflater.Inflate(Resource.Layout.fracment_pay, container, false);
        }

    }
  
    public class Profile : AndroidX.Fragment.App.Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
            return inflater.Inflate(Resource.Layout.fracment_profile, container, false);
        }

    }
}