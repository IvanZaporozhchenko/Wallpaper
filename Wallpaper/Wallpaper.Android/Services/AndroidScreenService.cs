using Wallpaper.Services.Interfaces;
using Android.App;

namespace Wallpaper.Droid.Services
{
    public class AndroidScreenService : IScreenService
    {
        public int Height
        {
            get
            {                
                var displayMetrics = Application.Context.Resources.DisplayMetrics;
                return displayMetrics.HeightPixels;                                   
            }
        }        

        public int Width
        {
            get
            {
                var displayMetrics = Application.Context.Resources.DisplayMetrics;
                return displayMetrics.WidthPixels;                
            }
        }
    }
}