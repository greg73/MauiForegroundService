using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using MauiApp2.Platforms;

namespace MauiApp2
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        private Intent? _startServiceIntent;

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            _startServiceIntent = new Intent(this, typeof(TimestampService));
            _startServiceIntent.SetAction(Constants.ACTION_START_SERVICE);
            StartService(_startServiceIntent);
        }
    }
}
