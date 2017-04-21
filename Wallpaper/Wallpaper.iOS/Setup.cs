using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform;
using MvvmCross.Platform.Platform;
using UIKit;
using Wallpaper.iOS.Services;
using Wallpaper.Services.Interfaces;

namespace Wallpaper.iOS
{
    public class Setup : MvxIosSetup
    {
        public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
        }
        
        public Setup(MvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter)
            : base(applicationDelegate, presenter)
        {
        }
    
        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
        
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

		protected override void InitializeLastChance()
		{
			base.InitializeLastChance();
			Mvx.RegisterType<IImageDownloaderService, IosImageDownloaderService>();
			Mvx.RegisterType<IImageGalleryService, IosImageGaleryService>();
			Mvx.RegisterType<IUserInteractionService, IosUserInteractionService>();
			Mvx.RegisterType<IScreenService, IosScreenService>();
			Mvx.RegisterType<IWallpaperService, IosWallpaperService>();
        }
    }
}
