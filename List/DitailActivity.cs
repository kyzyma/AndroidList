using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using List;

namespace List
{
    [Activity(Label = "DetailActivity")]
    public class DetailActivity : Activity
    {
        public int id;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Detail);

            TextView textView = FindViewById<TextView>(Resource.Id.Infa);

            id = Convert.ToInt32(Intent.GetStringExtra(MainActivity.TEXT_KEY));
            textView.Text = MainActivity.list[id].Name;

            var buttonCreate = FindViewById<Button>(Resource.Id.Create);
            buttonCreate.Click += Create;

            var buttonUpdate = FindViewById<Button>(Resource.Id.Update);
            buttonUpdate.Click += Update;           

        }

        public void Create(object sender, EventArgs args)
        {
        }

        public void Update(object sender, EventArgs args)
        {
        }

        
    }
}