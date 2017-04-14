using System;

using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using UIKit;
using Wallpaper.ViewModels;

namespace Wallpaper.iOS
{
	public partial class ImageCell : MvxTableViewCell
	{
		private readonly MvxImageViewLoader _imageViewLoader;

		public static readonly NSString Key = new NSString("ImageCell");
		public static readonly UINib Nib;

		static ImageCell()
		{
			Nib = UINib.FromName("ImageCell", NSBundle.MainBundle);
		}

		public ImageCell(IntPtr handle) : base(handle)
		{
			_imageViewLoader = new MvxImageViewLoader(() => this.MainImage);
			// Note: this .ctor should not contain any initialization logic.
			this.DelayBind(() =>
			{
				var set = this.CreateBindingSet<ImageCell, ImageItemViewModel>();
				set.Bind(MainLabel).To(ivm => ivm.ImageUrl);
				set.Bind(_imageViewLoader).To(ivm => ivm.ImageUrl);
				set.Apply();
			});
		}

		public static ImageCell Create()
		{
			return (ImageCell)Nib.Instantiate(null, null)[0];
		}
	}
}
