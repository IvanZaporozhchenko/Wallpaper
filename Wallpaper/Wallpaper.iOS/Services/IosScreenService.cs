using UIKit;
using Wallpaper.Services.Interfaces;

namespace Wallpaper.iOS.Services
{
    public class IosScreenService : IScreenService
    {
		public int Height => (int)(UIScreen.MainScreen.Bounds.Height * UIScreen.MainScreen.Scale);

		public int Width => (int)(UIScreen.MainScreen.Bounds.Width * UIScreen.MainScreen.Scale);
    }
}