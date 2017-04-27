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
			return false;
        }

        public void SaveImageToLibrary(string fileName, byte[] imageData)
        {
			try
			{
				var nsData = NSData.FromArray(imageData);
				var uiImage = UIImage.LoadFromData(nsData);
				var library = new ALAssetsLibrary();
				library.WriteImageToSavedPhotosAlbum (uiImage.CGImage, new NSDictionary(), (assetUrl, error) =>{
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