using MvvmCross.Core.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Wallpaper.Services;

namespace Wallpaper.ViewModels
{
    public class MainViewModel : MvxViewModel
    {        
        private readonly IImageService _imageUrlGetter;
        private List<ImageItemViewModel> _images;
        private ICommand _imageChooseCommand;
        
        public MainViewModel(IImageService imageUrlGetter)
        {            
            _imageUrlGetter = imageUrlGetter;
            Images = _imageUrlGetter.GetImageUrls()
                .Select(x => new ImageItemViewModel {ImageUrl = x})
                .ToList();
        }

        public List<ImageItemViewModel> Images
        {
            get { return _images; }
            set
            {
                _images = value;
                RaisePropertyChanged(() => Images);
            }
        }

        public override void Start()
        {
            _imageChooseCommand = _imageChooseCommand ?? new MvxCommand<ImageItemViewModel>(ChooseImage);
            base.Start();
        }

        public ICommand ImageChooseCommand
        {
            get
            {
                return _imageChooseCommand;
            }
        }       

        private void ChooseImage(ImageItemViewModel imageItemViewModel)
        {
            ShowViewModel<OneImageViewModel>(new
                {
                    imageUrl = imageItemViewModel.ImageUrl,
                    index = Images.IndexOf(imageItemViewModel)
                });
        }
    }
}
