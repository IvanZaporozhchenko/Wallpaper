using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using Wallpaper.ViewModels;

namespace Wallpaper.iOS.Views
{
    public partial class MainView : MvxViewController
    {
        public MainView() : base("MainView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<MainView, MainViewModel>();
   
            set.Apply();
        }
    }
}
