using MvvmCross.Platform.IoC;

namespace Wallpaper
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsDynamic();

            CreatableTypes()
                .EndingWith("Factory")
                .AsInterfaces()
                .RegisterAsDynamic();            

            RegisterAppStart<ViewModels.MainViewModel>();
        }
    }
}
