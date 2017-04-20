using MvvmCross.Core.ViewModels;
using System.Windows.Input;
using Wallpaper.Services.Interfaces;
using Wallpaper.Infrastructure;
using System.Threading.Tasks;
using System.Diagnostics;

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

		private string _imageUrl;
		public string ImageUrl
		{
			get => _imageUrl;

		    set => SetProperty(ref _imageUrl, value);
		}  
		
        private byte[] _imageData;
        public byte[] ImageData
        {
            get => _imageData;

            set => SetProperty(ref _imageData, value);
        }     

        private bool _isSaveImageEnabled;
        public bool IsSaveImageEnabled
        {
            get => _isSaveImageEnabled;

            set => SetProperty(ref _isSaveImageEnabled, value);
        }

        private bool _isSetWallpaperEnabled;
        public bool IsSetWallpaperEnabled
        {
            get => _isSetWallpaperEnabled;

            set => SetProperty(ref _isSetWallpaperEnabled, value);
        }

        public OneImageViewModel(
            IImageDownloaderService imageDownloaderService,
            IUserInteractionService userInteractionService,
            IOneImageActionBarService oneImageActionBarService)
        {            
            _imageDownloaderService = imageDownloaderService;
            _userInteractionService = userInteractionService;
            _oneImageActionBarService = oneImageActionBarService;      
        }

        public override void Start()
        {
            _saveImageCommand = _saveImageCommand ?? new MvxCommand(SaveImage);
            _setWallpaperCommand = _setWallpaperCommand ?? new MvxCommand(SetWallpaper);
            base.Start();
        }

        public void Init(ImageParameters parameter)
        {            
            _index = parameter.Index;
			ImageUrl = parameter.ImageUrl;
			Debug.WriteLine(ImageUrl);
            Task.Factory.StartNew(async () =>
            {				
                ImageData = await _imageDownloaderService.DownloadImageFromWeb(parameter.ImageUrl);
                IsSaveImageEnabled = !_oneImageActionBarService.IsImageExist(_index);
                IsSetWallpaperEnabled = true;
            });
        }

        private void SetWallpaper()
        {            
            _oneImageActionBarService.SetWallpaper(ImageData);
            _userInteractionService.ShowMessage("Wallpaper is set!");
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
