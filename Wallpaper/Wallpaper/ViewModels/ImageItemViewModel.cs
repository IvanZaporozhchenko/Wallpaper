using MvvmCross.Core.ViewModels;

namespace Wallpaper.ViewModels
{
    public class ImageItemViewModel : MvxViewModel
    {
        public string ImageUrl { get; set; }

        public override bool Equals(object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to Point return false.
            ImageItemViewModel imageItemViewModel = obj as ImageItemViewModel;
            if (imageItemViewModel == null)
            {
                return false;
            }

            // Return true if the fields match:
            return (ImageUrl == imageItemViewModel.ImageUrl);
        }

        public override int GetHashCode()
        {
            return ImageUrl.GetHashCode();
        }
    }   
}
