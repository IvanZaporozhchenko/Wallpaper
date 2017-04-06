using MvvmCross.Platform;
using Wallpaper.Services.Interfaces;
using Wallpaper.ViewModels;

namespace Wallpaper.Services.Implementations
{
    public class ImageItemViewModelFactory : IImageItemViewModelFactory
    {
        public ImageItemViewModel Create(string imageUrl)
        {
            return new ImageItemViewModel(Mvx.Resolve<IImageDownloaderService>(), imageUrl);
        }
    }
}
