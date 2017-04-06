using Wallpaper.ViewModels;

namespace Wallpaper.Services.Interfaces
{
    public interface IImageItemViewModelFactory
    {
        ImageItemViewModel Create(string imageUrl);
    }
}
