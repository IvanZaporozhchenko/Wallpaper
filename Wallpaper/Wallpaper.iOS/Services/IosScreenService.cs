using UIKit;
using Wallpaper.Services.Interfaces;

namespace Wallpaper.iOS.Services
{
    public class IosScreenService : IScreenService
    {
        public int Height => (int) UIScreen.MainScreen.Bounds.Height;

        public int Width => (int) UIScreen.MainScreen.Bounds.Width;
    }
}