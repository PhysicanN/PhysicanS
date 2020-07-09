﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using System.Threading.Tasks;
using Physican;
using Android.Content.PM;
namespace Physican.SplashScreen
{
    [Activity(Theme = "@style/AppTheme", MainLauncher = true, NoHistory = true, ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashActivity : AppCompatActivity
    {
        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnCreate(savedInstanceState, persistentState);
        }
        protected override void OnResume()
        {
            base.OnResume();
            Task startupWork = new Task(() => { SimulateStartup(); });
        }
        public override void OnBackPressed()
        {
            
        }
        async void SimulateStartup()
        {
            await Task.Delay(8000);
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }

}