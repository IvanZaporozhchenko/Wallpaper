using System.IO;
using Wallpaper.Services.Interfaces;

namespace Wallpaper.Services.Implementations
{
    public class OneImageActionBarService : IOneImageActionBarService
    {
        private readonly IImageGalleryService _imageGalleryService;
        private readonly IWallpaperService _wallpaperService;

        public OneImageActionBarService(IImageGalleryService imageGalleryService, IWallpaperService wallpaperService)
        {
            _imageGalleryService = imageGalleryService;
            _wallpaperService = wallpaperService;
        }

        public bool IsImageExist(int imageIndex)
        {
            return _imageGalleryService.IsImageExist(GetImageFileName(imageIndex));
        }

        public bool SaveImage(byte[] imageData, int imageIndex)
        {
            string fileName = GetImageFileName(imageIndex);
            if (!_imageGalleryService.IsImageExist(fileName))
            {
                _imageGalleryService.SaveImageToLibrary(fileName, imageData);
                return true;
            }

            return false;
        }

        public void SetWallpaper(byte[] imageData)
        {
            _wallpaperService.SetWallpaper(new MemoryStream(imageData));
        }

        /// <summary>
        /// Get image file name in the system. It will be like "Christmas<index>.jpg"
        /// </summary>        
        private string GetImageFileName(int index)
        {
            return $"Christmas{index}.jpg";
        }
    }
}
