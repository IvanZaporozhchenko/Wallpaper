using System.IO;

namespace Wallpaper.Services.Interfaces
{
    public interface IImageDownloaderService
    {
        void StartDownloadImageFromWeb(string url);

        event DownloadCompletedEventHandler DownloadImageCompleted;
    }

    public delegate void DownloadCompletedEventHandler(object sender, DownloadCompletedEventHandlerArgs args);

    public class DownloadCompletedEventHandlerArgs
    {
        public DownloadCompletedEventHandlerArgs(Stream resultStream)
        {
            ResultStream = new MemoryStream();
            byte[] buffer = new byte[resultStream.Length];
            int read;
            while ((read = resultStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                ResultStream.Write(buffer, 0, read);
            }
        }

        public MemoryStream ResultStream { get; private set; }
    }
}
