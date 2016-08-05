using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Object = Java.Lang.Object;

namespace List
{
    public class MyAdapter : BaseAdapter
    {
        private Activity activity;
        private Collection<Employee> employeers;

        public MyAdapter(Activity activity, ObservableCollection<Employee> persons)
        {
            this.activity = activity;
            this.employeers = persons;
        }

        public override int Count
        {
            get
            {
                return employeers.Count;
            }
        }

        public override Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return employeers[position].Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? activity.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, parent, false);

            var textName = view.FindViewById<TextView>(Android.Resource.Id.Text1);
            textName.Text = employeers[position].Name;

            return view;
        }
    }
}