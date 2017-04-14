using Wallpaper.Services.Interfaces;

namespace Wallpaper.Droid.Services
{
    public class IosScreenService : IScreenService
    {
        public int Height
        {
            get
            {
				return 800;                                 
            }
        }        

        public int Width
        {
            get
            {
				return 480;             
            }
        }
    }
}