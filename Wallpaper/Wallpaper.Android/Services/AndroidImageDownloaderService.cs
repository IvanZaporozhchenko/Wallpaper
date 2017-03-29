using System;
using System.Net;
using Wallpaper.Services.Interfaces;

namespace Wallpaper.Droid.Services
{
    public class AndroidImageDownloaderService : IImageDownloaderService
    {
        public event DownloadCompletedEventHandler DownloadImageCompleted;

        public void StartDownloadImageFromWeb(string url)
        {
            var webClient = new WebClient();
            webClient.OpenReadCompleted += WebClientOpenReadCompleted;
            webClient.OpenReadAsync(new Uri(url));
        }

        private void WebClientOpenReadCompleted(object sender, OpenReadCompletedEventArgs e)
        {
            var downloadImageCompleted = DownloadImageCompleted;
            downloadImageCompleted?.Invoke(sender, new DownloadCompletedEventHandlerArgs(e.Result));
        }        
    }
}