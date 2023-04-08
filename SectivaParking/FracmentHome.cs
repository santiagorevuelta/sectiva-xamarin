using System;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Webkit;

namespace SectivaParking
{
    public class FracmentHome : AndroidX.Fragment.App.Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.fracment_home, container, false);
        }

    }
}