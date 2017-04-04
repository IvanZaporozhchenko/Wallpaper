using MvvmCross.Core.ViewModels;
using System.Windows.Input;
using Wallpaper.Services.Interfaces;
using System;

namespace Wallpaper.ViewModels
{
    public class OneImageViewModel : MvxViewModel
    {        
        private readonly IImageDownloaderService _imageDownloaderService;
        private readonly IUserInteractionService _userInteractionService;
        private readonly IOneImageActionBarService _oneImageActionBarService;

        private string _imageUrl;
        private int _index;

        private ICommand _saveImageCommand;
        public ICommand SaveImageCommand => _saveImageCommand;

        private ICommand _setWallpaperCommand;
        public ICommand SetWallpaperCommand => _setWallpaperCommand;

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

        public OneImageViewModel(
            IImageDownloaderService imageDownloaderService,
            IUserInteractionService userInteractionService,
            IOneImageActionBarService oneImageActionBarService)
        {            
            _imageDownloaderService = imageDownloaderService;
            _userInteractionService = userInteractionService;
            _oneImageActionBarService = oneImageActionBarService;
            _imageDownloaderService.DownloadImageCompleted += ImageDownloaded;
        }

        public override void Start()
        {
            _saveImageCommand = _saveImageCommand ?? new MvxCommand(SaveImage);
            _setWallpaperCommand = _setWallpaperCommand ?? new MvxCommand(SetWallpaper);
            base.Start();
        }       

        public void Init(string imageUrl, int index)
        {
            _imageUrl = imageUrl;
            _index = index;
            _imageDownloaderService.StartDownloadImageFromWeb(_imageUrl);
        }

        private void SetWallpaper()
        {
            _oneImageActionBarService.SetWallpaper(ImageData);
            _userInteractionService.ShowMessage("Wallpaper is setted!");
        }

        private void ImageDownloaded(object sender, DownloadCompletedEventHandlerArgs args)
        {
            ImageData = args.ResultStream.ToArray();
            IsSaveImageEnabled = !_oneImageActionBarService.IsImageExist(_index);            
        }

        private void SaveImage()
        {
            if (_oneImageActionBarService.SaveImage(ImageData, _index))
            {
                IsSaveImageEnabled = false;
                _userInteractionService.ShowMessage("Image saved!");
            }
        }       
    }
}
