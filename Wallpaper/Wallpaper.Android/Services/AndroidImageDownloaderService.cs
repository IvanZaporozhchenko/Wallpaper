using System;
using System.Net;
using System.Threading.Tasks;
using Wallpaper.Services.Interfaces;

namespace Wallpaper.Droid.Services
{
    public class AndroidImageDownloaderService : IImageDownloaderService
    {       
        public async Task<byte[]> DownloadImageFromWeb(string url)
        {
            using (var webClient = new WebClient())
            {
                return await webClient.DownloadDataTaskAsync(url);
            }
        }     
    }
}