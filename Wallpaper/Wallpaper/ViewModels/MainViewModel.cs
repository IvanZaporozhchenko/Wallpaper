using MvvmCross.Core.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Wallpaper.Infrastructure;
using Wallpaper.Services;

namespace Wallpaper.ViewModels
{
    public class MainViewModel : MvxViewModel
    {        
        private readonly IImageFactory _imageUrlGetter;        
        private ICommand _imageChooseCommand;
        
        public MainViewModel(IImageFactory imageUrlGetter)
        {            
            _imageUrlGetter = imageUrlGetter;
            Images = _imageUrlGetter.GetImageViewModels().ToList();
        }

        private List<ImageItemViewModel> _images;
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
            ShowViewModel<OneImageViewModel>(new ImageParameters
                {
                    ImageUrl = imageItemViewModel.ImageUrl,
                    Index = Images.IndexOf(imageItemViewModel)
                });
        }
    }
}
