using System;
using System.IO;
using System.Net;
using Wallpaper.Services.Interfaces;

namespace Wallpaper.Droid.Services
{
    public class AndroidImageDownloaderService : IImageDownloaderService
    {
        public event DownloadCompletedEventHandler DownloadImageCompleted;

        public async void StartDownloadImageFromWeb(string url)
        {
            using (var webClient = new WebClient())
            {
                var bytes = await webClient.DownloadDataTaskAsync(url);
                var downloadImageCompleted = DownloadImageCompleted;
                downloadImageCompleted?.Invoke(this, new DownloadCompletedEventHandlerArgs(new MemoryStream(bytes)));
            }
        }
    }
}