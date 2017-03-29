using System.Collections.Generic;

namespace Wallpaper.Services
{
    public interface IImageService
    {
        IEnumerable<string> GetImageUrls();
    }
}
