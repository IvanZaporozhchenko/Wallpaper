using Android.App;
using Android.Content;
using System;
using System.IO;
using Wallpaper.Services.Interfaces;

namespace Wallpaper.Droid.Services
{
    public class AndroidImageGalerySaverService : IImageGalleryService
    {
        public bool IsImageExist(string fileName)
        {
            try
            {
                return File.Exists(getFullPath(fileName));
            }
            catch (Exception)
            {
            }

            return true;
        }

        public void SaveImageToLibrary(string fileName, byte[] imageData)
        {
            string filePath = getFullPath(fileName);
            try
            {
                File.WriteAllBytes(filePath, imageData);
                var mediaScanIntent = new Intent(Intent.ActionMediaScannerScanFile);
                mediaScanIntent.SetData(Android.Net.Uri.FromFile(new Java.IO.File(filePath)));
                Application.Context.SendBroadcast(mediaScanIntent);
            }
            catch (Exception ex)
            {
            }
        }

        private static string getFullPath(string fileName)
        {
            var dir = Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryDcim);
            var pictures = dir.AbsolutePath;            
            string name = fileName;
            string filePath = Path.Combine(pictures, name);
            return filePath;
        }
    }
}