using System.IO;

namespace Wallpaper.Services.Interfaces
{
    public interface IWallpaperService
    {
        void SetWallpaper(Stream imageStream);
    }
}
