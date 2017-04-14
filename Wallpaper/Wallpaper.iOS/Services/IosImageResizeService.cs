using System.IO;
using Wallpaper.Services.Interfaces;
using System.Threading.Tasks;


namespace Wallpaper.Droid.Services
{
    public class IosImageResizeService : IImageResizeService
    {
        public async Task<byte[]> ResizeImage(byte[] imageData, int sampleSize)
        {
			return await Task.FromResult(new byte[0]);
        }
    }
}