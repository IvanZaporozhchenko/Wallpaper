
using BigTed;
using Wallpaper.Services.Interfaces;

namespace Wallpaper.Droid.Services
{
    public class IosUserInteractionService : IUserInteractionService
    {
        public void ShowMessage(string text)
        {
			BTProgressHUD.ShowToast(text, false);
        }ß
    }
}