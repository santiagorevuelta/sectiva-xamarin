using System;
using Android.App;
using Android.OS;
using Android.Views;

namespace SectivaParking
{
    public class Home : AndroidX.Fragment.App.Fragment
    {
        View view;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
            view = inflater.Inflate(Resource.Layout.fracment_home, container, false);
            return view;
        }

    }  
    public class Cars : AndroidX.Fragment.App.Fragment
    {
        View view;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
            view = inflater.Inflate(Resource.Layout.fracment_cars, container, false);
            return view;
        }

    }
}