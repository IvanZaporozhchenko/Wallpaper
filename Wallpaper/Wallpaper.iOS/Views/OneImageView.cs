using System;
using System.Diagnostics;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using UIKit;
using Wallpaper.ViewModels;

namespace Wallpaper.iOS
{
	public partial class OneImageView : MvxViewController
	{
		private MvxImageViewLoader _loader;
		private UIBarButtonItem _rightBarButton;

		public OneImageView() : base("OneImageView", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			_rightBarButton = new UIBarButtonItem();
			_rightBarButton.Title = "Save";
			NavigationItem.RightBarButtonItem = _rightBarButton;
			_loader = new MvxImageViewLoader(() => this.MainImage);							
			var set = this.CreateBindingSet<OneImageView, OneImageViewModel>();
			set.Bind(_loader).To(vm => vm.ImageUrl);
			set.Bind(_rightBarButton).For("Clicked").To(vm => vm.SaveImageCommand);
			set.Apply();
		}
	}
}

