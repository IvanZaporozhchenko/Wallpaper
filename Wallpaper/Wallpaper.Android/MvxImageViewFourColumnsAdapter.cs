using System.Collections.Generic;
using Android.Content;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding.Droid.Views;
using MvvmCross.Platform;
using Wallpaper.Services.Interfaces;
using Wallpaper.ViewModels;
using Object = Java.Lang.Object;

namespace Wallpaper.Droid
{
    public class MvxImageViewFourColumnsAdapter : BaseAdapter
    {
        private readonly Context _context;

        private readonly List<ImageItemViewModel> _imageItemViewModels;

        public MvxImageViewFourColumnsAdapter(Context context, List<ImageItemViewModel> imageItemViewModels)
        {
            _context = context;
            _imageItemViewModels = imageItemViewModels;
        }

        public override int Count => _imageItemViewModels.Count;

        public override Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            MvxImageView imageView;

            if (convertView == null)
            {
                // if it's not recycled, initialize some attributes
                imageView = new MvxImageView(_context);
                var screenService = Mvx.Resolve<IScreenService>();
                var imageWidth = (screenService.Width - 40) / 4;
                var imageHeight = (screenService.Height - 40) / 4;
                imageView.SetAdjustViewBounds(true);
                imageView.SetMaxWidth(imageWidth);
                imageView.SetMaxHeight(imageHeight);
            }
            else
            {
                imageView = (MvxImageView) convertView;
            }

            imageView.ImageUrl = _imageItemViewModels[position].ImageUrl;
            return imageView;
        }

        public ImageItemViewModel GetImageItemViewModel(int position)
        {
            return _imageItemViewModels[position];
        }
    }
}