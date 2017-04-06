using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.Platform;
using System.Collections.Generic;

namespace Wallpaper.ViewModels
{
    public abstract class BaseViewModel : MvxViewModel
    {
        protected bool ShowViewModel<TViewModel, TInit>(TInit parameter) where TViewModel : BaseInitViewModel<TInit>
        {
            var text = Mvx.Resolve<IMvxJsonConverter>().SerializeObject(parameter);
            return base.ShowViewModel<TViewModel>(new Dictionary<string, string> { { "parameter", text } });
        }
    }
}
