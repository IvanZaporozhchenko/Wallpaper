using MvvmCross.Platform;
using MvvmCross.Platform.Platform;

namespace Wallpaper.ViewModels
{
    public abstract class BaseInitViewModel<TInit> : BaseViewModel
    {
        public void Init(string parameter)
        {
            var deserialized = Mvx.Resolve<IMvxJsonConverter>().DeserializeObject<TInit>(parameter);
            RealInit(deserialized);
        }

        protected abstract void RealInit(TInit parameter);
    }
}
