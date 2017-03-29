using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using MvvmCross.Platform;
using Wallpaper.Services.Interfaces;
using Wallpaper.Droid.Services;

namespace Wallpaper.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
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
            Mvx.RegisterType<IImageDownloaderService, AndroidImageDownloaderService>();
            Mvx.RegisterType<IImageGalleryService, AndroidImageGalerySaverService>();
            Mvx.RegisterType<IUserInteractionService, AndroidUserInteractionService>();
        }
    }
}
