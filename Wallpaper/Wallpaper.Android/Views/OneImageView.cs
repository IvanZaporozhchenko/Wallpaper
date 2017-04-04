using System;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Views;
using Wallpaper.ViewModels;
using MvvmCross.Platform.WeakSubscription;
using Android.Graphics;

namespace Wallpaper.Droid.Views
{
    [Activity]
    public class OneImageView : MvxActivity<OneImageViewModel>
    {
        private MvxNotifyPropertyChangedEventSubscription _eventSubscription;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.OneImageView);
            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            _eventSubscription = ViewModel.WeakSubscribe(() => ViewModel.IsSaveImageEnabled, IsSaveImageEnabledChanged);            
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        private void IsSaveImageEnabledChanged(object sender, EventArgs e)
        {            
            InvalidateOptionsMenu();            
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.top_menus, menu);
            var saveButton = menu.FindItem(Resource.Id.menu_save);
            saveButton.SetEnabled(ViewModel.IsSaveImageEnabled);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnPrepareOptionsMenu(IMenu menu)
        {
            var saveButton = menu.FindItem(Resource.Id.menu_save);

            //change icon if button is not enabled
            var icon = GetDrawable(Resource.Drawable.ic_save_black_24dp);
            if (!saveButton.IsEnabled)
            {
                icon.Mutate().SetColorFilter(Color.Rgb(150, 150, 150), PorterDuff.Mode.SrcIn);
            }

            saveButton.SetIcon(icon);
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
            }

            return base.OnOptionsItemSelected(item);
        }

        protected override void OnDestroy()
        {            
            base.OnDestroy();
            _eventSubscription.Dispose();
        }
    }
}