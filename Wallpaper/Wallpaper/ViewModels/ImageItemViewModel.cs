using MvvmCross.Core.ViewModels;
using Wallpaper.Services.Interfaces;

namespace Wallpaper.ViewModels
{
    public class ImageItemViewModel : MvxViewModel
    {
        private IImageDownloaderService _imageDownloaderService;

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
                _imageDownloaderService.StartDownloadImageFromWeb(_imageUrl);
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

        public ImageItemViewModel(IImageDownloaderService imageDownloaderService, string imageUrl)
        {
            _imageDownloaderService = imageDownloaderService;
            _imageDownloaderService.DownloadImageCompleted += ImageDownloaded;
            ImageUrl = imageUrl;
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

        private void ImageDownloaded(object sender, DownloadCompletedEventHandlerArgs args)
        {
            ImageData = args.ResultStream.ToArray();
        }
    }   
}
