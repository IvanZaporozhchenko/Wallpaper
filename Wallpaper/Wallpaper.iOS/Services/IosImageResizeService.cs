using System.Threading.Tasks;
using Wallpaper.Services.Interfaces;

namespace Wallpaper.iOS.Services
{
    public class IosImageResizeService : IImageResizeService
    {
        public async Task<byte[]> ResizeImage(byte[] imageData, int sampleSize)
        {
			return await Task.FromResult(new byte[0]);
        }
    }
}