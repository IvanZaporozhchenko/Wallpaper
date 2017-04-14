using System;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using Wallpaper.ViewModels;

namespace Wallpaper.iOS
{
	[Register("MainView")]
	public class MainView : MvxTableViewController
	{
		public override void ViewDidLoad()
		{			
			base.ViewDidLoad();

			var source = new MvxStandardTableViewSource(TableView, "ImageUrl ImageUrl");
			TableView.Source = source;

									var set = this.CreateBindingSet<MainView, MainViewModel>();
			set.Bind(source).To(vm => vm.Images);
			set.Apply();

			TableView.ReloadData();
		}
	}
}
