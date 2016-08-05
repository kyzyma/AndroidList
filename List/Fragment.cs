using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;


namespace List
{
    public class Fragment : DialogFragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.DIalog, container, false);

            var buttonYes = view.FindViewById<Button>(Resource.Id.BtnYes);
            buttonYes.Click += delegate { };

            return view;
        }
    }
}