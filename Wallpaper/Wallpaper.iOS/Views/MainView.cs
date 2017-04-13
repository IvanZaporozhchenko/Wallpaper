using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;


namespace Wallpaper.iOS
{
	public partial class MainView : MvxViewController
	{
		public MainView() : base("MainView", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			var set = this.CreateBindingSet<MainView, ViewModels.MainViewModel>();
			set.Apply();
		}
	}
}

