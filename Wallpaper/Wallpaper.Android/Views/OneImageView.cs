using System;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Views;
using Wallpaper.ViewModels;
using MvvmCross.Platform.WeakSubscription;
using Android.Graphics;
using Android.Content.PM;

namespace Wallpaper.Droid.Views
{
    [Activity(ScreenOrientation = ScreenOrientation.Portrait)]
    public class OneImageView : MvxActivity<OneImageViewModel>
    {
        private MvxNotifyPropertyChangedEventSubscription _eventSubscriptionIsSaveImageEnabled;
        private MvxNotifyPropertyChangedEventSubscription _eventSubscriptionIsSetWallpaperEnabled;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.OneImageView);
            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            _eventSubscriptionIsSaveImageEnabled = ViewModel.WeakSubscribe(() => ViewModel.IsSaveImageEnabled, ActionBarChanged);
            _eventSubscriptionIsSetWallpaperEnabled = ViewModel.WeakSubscribe(() => ViewModel.IsSetWallpaperEnabled, ActionBarChanged);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        private void ActionBarChanged(object sender, EventArgs e)
        {            
            InvalidateOptionsMenu();            
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.top_menus, menu);
            var saveButton = menu.FindItem(Resource.Id.menu_save);
            var setWallpaperButton = menu.FindItem(Resource.Id.menu_setwallpaper);
            saveButton.SetEnabled(ViewModel.IsSaveImageEnabled);
            setWallpaperButton.SetEnabled(ViewModel.IsSetWallpaperEnabled);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnPrepareOptionsMenu(IMenu menu)
        {
            var saveButton = menu.FindItem(Resource.Id.menu_save);
            var setWallpaperButton = menu.FindItem(Resource.Id.menu_setwallpaper);

            //change icon if button is not enabled for save button
            var icon = GetDrawable(Resource.Drawable.ic_save_black_24dp);
            if (!saveButton.IsEnabled)
            {
                icon.Mutate().SetColorFilter(Color.Rgb(150, 150, 150), PorterDuff.Mode.SrcIn);
            }        
            saveButton.SetIcon(icon);

            //change icon if button is not enabled for set wallpaper button
            icon = GetDrawable(Resource.Drawable.ic_wallpaper_black_24dp);
            if (!setWallpaperButton.IsEnabled)
            {
                icon.Mutate().SetColorFilter(Color.Rgb(150, 150, 150), PorterDuff.Mode.SrcIn);
            }
            setWallpaperButton.SetIcon(icon);

            return base.OnPrepareOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.menu_save:
                    {
                        ViewModel.SaveImageCommand.Execute(null);
                        return true;
                    }
                case Resource.Id.menu_setwallpaper:
                    {
                        ViewModel.SetWallpaperCommand.Execute(null);
                        return true;
                    }
            }

            return base.OnOptionsItemSelected(item);
        }

        protected override void OnDestroy()
        {            
            base.OnDestroy();
            _eventSubscriptionIsSaveImageEnabled.Dispose();
            _eventSubscriptionIsSetWallpaperEnabled.Dispose();
        }
    }
}