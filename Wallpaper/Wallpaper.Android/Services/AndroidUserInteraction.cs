using Android.App;
using Android.Widget;
using Wallpaper.Services.Interfaces;

namespace Wallpaper.Droid.Services
{
    public class AndroidUserInteractionService : IUserInteractionService
    {
        public void ShowMessage(string text)
        {
            Toast.MakeText(Application.Context, text, ToastLength.Short).Show();
        }
    }
}