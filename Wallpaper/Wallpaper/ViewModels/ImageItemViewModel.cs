using MvvmCross.Core.ViewModels;

namespace Wallpaper.ViewModels
{
    public class ImageItemViewModel : MvxViewModel
    {
        private string _imageUrl;
        public string ImageUrl
        {
            get => _imageUrl;

            set => SetProperty(ref _imageUrl, value);
        }

        public override bool Equals(object obj)
        {
            // If parameter cannot be cast to Point return false.
            ImageItemViewModel imageItemViewModel = obj as ImageItemViewModel;
            if (imageItemViewModel == null)
            {
                return false;
            }

            // Return true if the fields match:
            return ImageUrl == imageItemViewModel.ImageUrl;
        }

        public override int GetHashCode()
        {
            return ImageUrl.GetHashCode();
        }      
    }   
}
