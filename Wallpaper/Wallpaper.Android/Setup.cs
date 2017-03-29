using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCross.Binding.Droid.Views;

namespace Wallpaper.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override void FillTargetFactories(IMvxTargetBindingFactoryRegistry registry)
        {
            registry.RegisterCustomBindingFactory<MvxImageView>(
                    "ImageSize",
                    v => new ImageViewSizeCustomBinding(v));
            base.FillTargetFactories(registry);
        }
    }
}
