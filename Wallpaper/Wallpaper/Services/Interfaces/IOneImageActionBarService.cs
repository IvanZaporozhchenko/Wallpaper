namespace Wallpaper.Services.Interfaces
{
    public interface IOneImageActionBarService
    {
        /// <summary>
        /// Save image to gallery
        /// </summary>
        /// <returns>
        /// Return true if image is saved, otherwise false</returns>
        bool SaveImage(byte[] imageData, int imageIndex);

        /// <summary>
        /// Gets value indicating whether image already exist in gallery
        /// </summary>       
        bool IsImageExist(int imageIndex);

        /// <summary>
        /// Sets wallpaper
        /// </summary>        
        void SetWallpaper(byte[] imageData);
    }
}
