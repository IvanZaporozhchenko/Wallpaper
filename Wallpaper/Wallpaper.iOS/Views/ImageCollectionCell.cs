using System;

using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using UIKit;
using Wallpaper.ViewModels;

namespace Wallpaper.iOS
{
	public partial class ImageCollectionCell : MvxCollectionViewCell
	{
		private readonly MvxImageViewLoader _loader;

		public static readonly NSString Key = new NSString("ImageCollectionCell");
		public static readonly UINib Nib;

		static ImageCollectionCell()
		{
			Nib = UINib.FromName("ImageCollectionCell", NSBundle.MainBundle);
		}

		public ImageCollectionCell(IntPtr handle) : base(handle)
		{
			_loader = new MvxImageViewLoader(() => this.MainImage);

			this.DelayBind(() =>
			{
				var set = this.CreateBindingSet<ImageCollectionCell, ImageItemViewModel>();
				set.Bind(_loader).To(ivm => ivm.ImageUrl);
				set.Apply();
			});
		}

		public static ImageCollectionCell Create()
		{
			return (ImageCollectionCell)Nib.Instantiate(null, null)[0];
		}
	}
}
