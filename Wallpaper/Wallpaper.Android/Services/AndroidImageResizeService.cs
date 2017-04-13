using System.IO;
using Wallpaper.Services.Interfaces;
using Android.Graphics;
using System.Threading.Tasks;


namespace Wallpaper.Droid.Services
{
    public class AndroidImageResizeService : IImageResizeService
    {
        public async Task<byte[]> ResizeImage(byte[] imageData, int sampleSize)
        {
            var options = new BitmapFactory.Options { InJustDecodeBounds = true };
            await BitmapFactory.DecodeByteArrayAsync(imageData, 0, imageData.Length, options);

            options.InSampleSize = sampleSize;
            options.InJustDecodeBounds = false;

            var bitmapScalled = await BitmapFactory.DecodeByteArrayAsync(imageData, 0, imageData.Length, options);
            using (var stream = new MemoryStream())
            {
                await bitmapScalled.CompressAsync(Bitmap.CompressFormat.Png, 0, stream);
                return stream.ToArray();
            }
        }
    }
}