using System.Collections.ObjectModel;
using Android.App;
using Android.Content;
using Android.Views;
using Android.Widget;
using Android.OS;
using List;


namespace List
{
    [Activity(Label = "List", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : ListActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            ListAdapter = new MyAdapter(this, list);
        }

        public static ObservableCollection<Employee> list = new ObservableCollection<Employee>
            {   new Employee { Id = 1, Name = "AAA"}, new Employee { Id = 2, Name = "BBB"}    };


        public const string TEXT_KEY = "TEXT_KEY";

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            Intent intent = new Intent(this, typeof(DetailActivity));

            intent.PutExtra(TEXT_KEY, list[position].Id.ToString());
            StartActivity(intent);
        }
    }
}

