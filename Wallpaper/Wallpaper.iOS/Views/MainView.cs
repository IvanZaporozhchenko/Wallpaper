using System;
using System.Drawing;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using UIKit;
using Wallpaper.ViewModels;

namespace Wallpaper.iOS
{
	[Register("MainView")]
	public class MainView : MvxCollectionViewController
	{
		private bool _isInitialized;

		public MainView() : 
			base(new UICollectionViewFlowLayout() 
			{ 
				ItemSize = new SizeF(50, 50),
				MinimumInteritemSpacing = 5,
				MinimumLineSpacing = 5
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
			set.Bind(source).To(vm => vm.Images);
			set.Apply();

			CollectionView.ReloadData();
		}
	}
}
