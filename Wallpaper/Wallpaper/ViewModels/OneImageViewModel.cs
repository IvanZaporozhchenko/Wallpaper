﻿using MvvmCross.Core.ViewModels;
using System.Windows.Input;
using Wallpaper.Services.Interfaces;
using Wallpaper.Infrastructure;

namespace Wallpaper.ViewModels
{
    public class OneImageViewModel : MvxViewModel
    {        
        private readonly IImageDownloaderService _imageDownloaderService;
        private readonly IUserInteractionService _userInteractionService;
        private readonly IOneImageActionBarService _oneImageActionBarService;
        
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

        private bool _isSetWallpaperEnabled;
        public bool IsSetWallpaperEnabled
        {
            get
            {
                return _isSetWallpaperEnabled;
            }

            set
            {
                SetProperty(ref _isSetWallpaperEnabled, value);
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

        public void Init(ImageParameters parameter)
        {
            _imageDownloaderService.StartDownloadImageFromWeb(parameter.ImageUrl);
            _index = parameter.Index;
        }

        private void SetWallpaper()
        {            
            _oneImageActionBarService.SetWallpaper(ImageData);
            _userInteractionService.ShowMessage("Wallpaper is set!");
        }

        private void ImageDownloaded(object sender, DownloadCompletedEventHandlerArgs args)
        {
            ImageData = args.ResultStream.ToArray();
            IsSaveImageEnabled = !_oneImageActionBarService.IsImageExist(_index);
            IsSetWallpaperEnabled = true;
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
