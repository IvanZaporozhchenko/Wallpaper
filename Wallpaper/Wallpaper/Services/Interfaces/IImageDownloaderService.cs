using System.Threading.Tasks;

namespace Wallpaper.Services.Interfaces
{
    public interface IImageDownloaderService
    {
        Task<byte[]> DownloadImageFromWeb(string url);        
    }
}
