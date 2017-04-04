using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Droid.Views;

namespace Wallpaper.Droid.Views
{
    [Activity(ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainView);
        }
    }
}
