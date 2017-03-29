namespace Wallpaper.Services.Interfaces
{
    public interface IImageGalleryService
    {
        void SaveImageToLibrary(string fileName, byte[] imageData);

        bool IsImageExist(string fileName);
    }
}
