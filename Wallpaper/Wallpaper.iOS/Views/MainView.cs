using System;
using System.Drawing;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using MvvmCross.Platform;
using UIKit;
using Wallpaper.Services.Interfaces;
using Wallpaper.ViewModels;

namespace Wallpaper.iOS
{
	[Register("MainView")]
	public class MainView : MvxCollectionViewController
	{
		private readonly bool _isInitialized;

		public MainView() : 
			base(new UICollectionViewFlowLayout 
			{ 
				ItemSize = new SizeF((Mvx.Resolve<IScreenService>().Width-8)/4, (Mvx.Resolve<IScreenService>().Height-8)/4),
				MinimumInteritemSpacing = 2,
				MinimumLineSpacing = 2
			})
		{
			_isInitialized = true;
		}

		public sealed override void ViewDidLoad()
		{
			if (!_isInitialized)
				return;
			
			base.ViewDidLoad();

			CollectionView.RegisterNibForCell(ImageCollectionCell.Nib, ImageCollectionCell.Key);
			var source = new MvxCollectionViewSource(CollectionView, ImageCollectionCell.Key);
			CollectionView.Source = source;

			var set = this.CreateBindingSet<MainView, MainViewModel>();
		    set.Bind(source).For(s=>s.SelectionChangedCommand).To(vm => vm.ImageChooseCommand);
			set.Bind(source).To(vm => vm.Images);
			set.Apply();

			CollectionView.ReloadData();
		}
	}
}
