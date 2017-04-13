using System.Threading.Tasks;

namespace Wallpaper.Services.Interfaces
{
    public interface IImageResizeService
    {
        Task<byte[]> ResizeImage(byte[] imageStream, int sampleSize);
    }
}
