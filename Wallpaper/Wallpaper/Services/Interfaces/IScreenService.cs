namespace Wallpaper.Services
{
    public interface IScreenService
    {
        /// <summary>
        /// Height of current device screen
        /// </summary>
        int Height { get; }

        /// <summary>
        /// Width of current device screen
        /// </summary>
        int Width { get; }
    }
}
