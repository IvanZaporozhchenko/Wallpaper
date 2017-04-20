using MvvmCross.Core.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Wallpaper.Infrastructure;
using Wallpaper.Services.Interfaces;

namespace Wallpaper.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private ICommand _imageChooseCommand;
        
        public MainViewModel(IImageFactory imageUrlGetter)
        {
            Images = imageUrlGetter.GetImageViewModels().ToList();
        }

        private List<ImageItemViewModel> _images;
        public List<ImageItemViewModel> Images
        {
            get => _images;
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

        public ICommand ImageChooseCommand => _imageChooseCommand;

        private void ChooseImage(ImageItemViewModel imageItemViewModel)
        {
            ShowViewModel<OneImageViewModel>(new ImageParameters
                {
                    ImageUrl = imageItemViewModel.ImageUrl,
                    Index = Images.IndexOf(imageItemViewModel)
                });
        }
    }
}
