using Android.App;
using Android.Util;
using System;
using System.IO;
using Wallpaper.Services.Interfaces;

namespace Wallpaper.Droid.Services
{
    public class AndroidWallpaperService : IWallpaperService
    {
        public void SetWallpaper(Stream imageStream)
        {
            WallpaperManager myWallpaperManager = WallpaperManager.GetInstance(Application.Context);
            try
            {
                myWallpaperManager.SetStream(imageStream);
            }
            catch (Exception ex)
            {
                Log.Error("Wallpaper", ex.Message);
            }
        }
    }
}