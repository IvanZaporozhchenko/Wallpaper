using Wallpaper.Services.Interfaces;

namespace Wallpaper.iOS.Services
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