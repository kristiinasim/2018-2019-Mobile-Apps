using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace App7
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            int count = 0;
            var textView = FindViewById<TextView>(Resource.Id.textView1);
            var button = FindViewById<TextView>(Resource.Id.button2);
            var uusbutton = FindViewById<TextView>(Resource.Id.button3);

            //button.Click += delegate
            //{
            //    count++;
            //    textView.Text = "Vajutasid nuppu " + count + "korda.";

            //};

            button.Click += button2_Click;
            button.Click += button3_Click;
        }
        private void button2_Click (object sender, System.EventArgs e)
        {
            var SecondActivity = new Intent(this, typeof(Activity1));
            StartActivity(SecondActivity);
        }
        private void button3_Click(object sender, System.EventArgs e)
        {
            var ThirdActivity = new Intent(this, typeof(thirdActiv));
            StartActivity(ThirdActivity);
        }


    }
    }

