using UIKit;
using Wallpaper.Services.Interfaces;

namespace Wallpaper.Droid.Services
{
    public class IosScreenService : IScreenService
    {
        public int Height
        {
            get
            {
				return (int) UIScreen.MainScreen.Bounds.Height;                                 
            }
        }        

        public int Width
        {
            get
            {
				return (int) UIScreen.MainScreen.Bounds.Width;
            }
        }
    }
}