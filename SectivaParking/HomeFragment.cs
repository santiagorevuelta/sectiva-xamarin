using System;
using Android.App;
using Android.OS;
using Android.Views;

namespace SectivaParking
{
    public class HomeFragment : Activity
    {
        public View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.fracment_home, container, false);
        }

    }
}