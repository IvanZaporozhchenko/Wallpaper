using System.Collections.Generic;
using Wallpaper.ViewModels;

namespace Wallpaper.Services
{
    public interface IImageFactory
    {
        IEnumerable<ImageItemViewModel> GetImageViewModels();
    }
}
