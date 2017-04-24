using System;
using System.Diagnostics;
using System.IO;
using AssetsLibrary;
using Foundation;
using UIKit;
using Wallpaper.Services.Interfaces;

namespace Wallpaper.iOS.Services
{
    public class IosImageGaleryService : IImageGalleryService
    {
        public bool IsImageExist(string fileName)
        {           
            try
            {
                return File.Exists(fileName);
            }
            catch (Exception ex)
            {
				Console.WriteLine(ex.Message);
            }

            return true;
        }

        public void SaveImageToLibrary(string fileName, byte[] imageData)
        {
			try
			{
				var nsData = NSData.FromArray(imageData);
				var uiImage = UIImage.LoadFromData(nsData);
				var meta = new NSDictionary("UIImagePickerControllerMediaMetadata", fileName);
				var library = new ALAssetsLibrary();
				library.WriteImageToSavedPhotosAlbum (uiImage.CGImage, null, (assetUrl, error) =>{
        			Console.WriteLine ("assetUrl:"+assetUrl);
    			});
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
        }		 
    }
}