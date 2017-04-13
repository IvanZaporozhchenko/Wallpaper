using MvvmCross.Core.ViewModels;
using System.Threading.Tasks;
using Wallpaper.Services.Interfaces;

namespace Wallpaper.ViewModels
{
    public class ImageItemViewModel : MvxViewModel
    {
        private readonly IImageDownloaderService _imageDownloaderService;
        private readonly IImageResizeService _imageResizeService;

        private string _imageUrl;
        public string ImageUrl
        {
            get
            {
                return _imageUrl;
            }

            set
            {
                SetProperty(ref _imageUrl, value);
            }
        }

        private byte[] _imageData;
        public byte[] ImageData
        {
            get
            {
                return _imageData;
            }

            set
            {
                SetProperty(ref _imageData, value);
            }
        }

        public ImageItemViewModel(IImageDownloaderService imageDownloaderService, IImageResizeService imageResizeService, string imageUrl)
        {
            _imageDownloaderService = imageDownloaderService;
            _imageResizeService = imageResizeService;            
            ImageUrl = imageUrl;
            Task.Factory.StartNew(async () =>
            {
                await SetImageData(imageUrl);
            });            
        }

        private async Task SetImageData(string imageUrl)
        {
            var originalImageData = await _imageDownloaderService.DownloadImageFromWeb(imageUrl);

            //resize image to have better performance
            ImageData = await _imageResizeService.ResizeImage(originalImageData, 2);
        }

        public override bool Equals(object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to Point return false.
            ImageItemViewModel imageItemViewModel = obj as ImageItemViewModel;
            if (imageItemViewModel == null)
            {
                return false;
            }

            // Return true if the fields match:
            return (ImageUrl == imageItemViewModel.ImageUrl);
        }

        public override int GetHashCode()
        {
            return ImageUrl.GetHashCode();
        }      
    }   
}
