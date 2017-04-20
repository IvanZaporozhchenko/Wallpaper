using System;
using System.IO;
using Wallpaper.Services.Interfaces;

namespace Wallpaper.iOS.Services
{
    public class IosWallpaperService : IWallpaperService
    {
        public void SetWallpaper(Stream imageStream)
        {
			throw new NotImplementedException("It is not possible in iOS");
        }
    }
}