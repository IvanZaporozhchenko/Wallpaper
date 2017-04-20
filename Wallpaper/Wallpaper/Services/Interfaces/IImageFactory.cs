using System.Collections.Generic;
using Wallpaper.ViewModels;

namespace Wallpaper.Services.Interfaces
{
    public interface IImageFactory
    {
        IEnumerable<ImageItemViewModel> GetImageViewModels();
    }
}
