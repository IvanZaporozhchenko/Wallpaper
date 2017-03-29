using System;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding.Droid.Target;
using Wallpaper.Models;
using MvvmCross.Binding.Droid.Views;

namespace Wallpaper.Droid
{
    public class ImageViewSizeCustomBinding : MvxAndroidTargetBinding
    {
        public ImageViewSizeCustomBinding(MvxImageView target) : base(target)
        {
        }

        public override Type TargetType
        {
            get { return typeof(ImageSize); }
        }

        protected override void SetValueImpl(object target, object value)
        {
            var realTarget = target as MvxImageView;
            if (target == null)
                return;

            var imageSize = value as ImageSize;
            if (imageSize != null)
            {
                ViewGroup.LayoutParams layoutParameters = realTarget.LayoutParameters;
                realTarget.LayoutParameters.Width = imageSize.Width;
            }            
        }        
    }
}