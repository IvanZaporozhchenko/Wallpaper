using MvvmCross.Core.ViewModels;
using System.Windows.Input;
using Wallpaper.Services.Interfaces;

namespace Wallpaper.ViewModels
{
    public class OneImageViewModel : MvxViewModel
    {
        private readonly IImageGalleryService _imageGalleryService;
        private readonly IImageDownloaderService _imageDownloaderService;
        private readonly IUserInteractionService _userInteractionService;

        private string _imageUrl;
        private int _index;

        private ICommand _saveImageCommand;
        public ICommand SaveImageCommand
        {
            get
            {
                return _saveImageCommand;
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
                _imageData = value;
                RaisePropertyChanged(() => ImageData);
            }
        }

        public OneImageViewModel(IImageGalleryService imageGalleryService, IImageDownloaderService imageDownloaderService, IUserInteractionService userInteractionService)
        {
            _imageGalleryService = imageGalleryService;
            _imageDownloaderService = imageDownloaderService;
            _userInteractionService = userInteractionService;
            _imageDownloaderService.DownloadImageCompleted += ImageDownloaderDownloadImageCompleted;            
        }

        public override void Start()
        {
            _saveImageCommand = _saveImageCommand ?? new MvxCommand(SaveImage);
            base.Start();
        }

        public void Init(string imageUrl, int index)
        {
            _imageUrl = imageUrl;
            _index = index;
            _imageDownloaderService.StartDownloadImageFromWeb(_imageUrl);
        }

        private void ImageDownloaderDownloadImageCompleted(object sender, DownloadCompletedEventHandlerArgs args)
        {
            ImageData = args.ResultStream.ToArray();
        }        

        private void SaveImage()
        {
            var fileName = $"Christmas{_index}.jpg";
            if (!_imageGalleryService.IsImageExist(fileName))
            {
                _imageGalleryService.SaveImageToLibrary(fileName, ImageData);
                _userInteractionService.ShowMessage("Image saved!");
            }
        }
    }
}
