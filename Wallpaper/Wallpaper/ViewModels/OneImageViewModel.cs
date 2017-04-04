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
        public ICommand SaveImageCommand => _saveImageCommand;      

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

        private bool _isSaveImageEnabled;
        public bool IsSaveImageEnabled
        {
            get
            {
                return _isSaveImageEnabled;
            }

            set
            {
                SetProperty(ref _isSaveImageEnabled, value);                
            }
        }        

        public OneImageViewModel(IImageGalleryService imageGalleryService, IImageDownloaderService imageDownloaderService, IUserInteractionService userInteractionService)
        {
            _imageGalleryService = imageGalleryService;
            _imageDownloaderService = imageDownloaderService;
            _userInteractionService = userInteractionService;
            _imageDownloaderService.DownloadImageCompleted += ImageDownloaded;
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

        private void ImageDownloaded(object sender, DownloadCompletedEventHandlerArgs args)
        {
            ImageData = args.ResultStream.ToArray();
            IsSaveImageEnabled = !_imageGalleryService.IsImageExist(GetImageFileName());            
        }

        private void SaveImage()
        {
            string fileName = GetImageFileName();
            if (!_imageGalleryService.IsImageExist(fileName))
            {
                _imageGalleryService.SaveImageToLibrary(fileName, ImageData);
                IsSaveImageEnabled = false;
                _userInteractionService.ShowMessage("Image saved!");
            }
        }

        /// <summary>
        /// Get image file name in the system. It will be like Christmas<index>.jpg
        /// </summary>        
        private string GetImageFileName()
        {
            return $"Christmas{_index}.jpg";
        }
    }
}
