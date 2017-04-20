using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Widget;
using MvvmCross.Droid.Views;
using Wallpaper.ViewModels;

namespace Wallpaper.Droid.Views
{
    [Activity(ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainView : MvxActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainView);

            var gridView = FindViewById<GridView>(Resource.Id.gridView);                
            gridView.Adapter = new MvxImageViewFourColumnsAdapter(this, ViewModel.Images);
            gridView.ItemClick += GridViewItemClick;
        }

        private void GridViewItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var gridView = FindViewById<GridView>(Resource.Id.gridView);
            var adapter = (MvxImageViewFourColumnsAdapter) gridView.Adapter;
            if (ViewModel.ImageChooseCommand.CanExecute(adapter.GetImageItemViewModel(e.Position)))
            {
                ViewModel.ImageChooseCommand.Execute(adapter.GetImageItemViewModel(e.Position));
            }
        }
    }    
}
