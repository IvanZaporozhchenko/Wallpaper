using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace Wallpaper.Droid
{
    [Activity(
        Label = ""
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait
        , ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize
        )]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}
