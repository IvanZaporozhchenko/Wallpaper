using System.Collections.Generic;
using Wallpaper.ViewModels;

namespace Wallpaper.Services
{
    public interface IImageService
    {
        IEnumerable<ImageItemViewModel> GetImageViewModels();
    }
}
