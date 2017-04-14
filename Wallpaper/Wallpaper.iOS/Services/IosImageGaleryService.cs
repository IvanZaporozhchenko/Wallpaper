
using System;
using AssetsLibrary;
using Foundation;

using System;
using System.IO;
using Wallpaper.Services.Interfaces;

namespace Wallpaper.Droid.Services
{
    public class IosImageGaleryService : IImageGalleryService
    {
        public bool IsImageExist(string fileName)
        {
           

            return true;
        }

        public void SaveImageToLibrary(string fileName, byte[] imageData)
        {
            
        }

        
    }
}