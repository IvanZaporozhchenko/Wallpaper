using MvvmCross.Core.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Wallpaper.Services;

namespace Wallpaper.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private readonly IScreenService _screenSize;
        private readonly IImageService _imageUrlGetter;
        private List<ImageItemViewModel> _images;
        private ICommand _imageChooseCommand;
        private int _selectedImageIndex;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="screenSize"></param>
        /// <param name="imageUrlGetter"></param>
        /// <param name="storeReviewService"></param>
        public MainViewModel(IScreenService screenSize, IImageService imageUrlGetter)
        {
            _screenSize = screenSize;
            _imageUrlGetter = imageUrlGetter;
            Images = _imageUrlGetter.GetImageUrls(_screenSize.Width, _screenSize.Height).Select(x => new ImageItemViewModel
            {
                ImageUrl = x,            
            }).ToList();
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
            _imageChooseCommand = _imageChooseCommand ?? new MvxCommand(ChooseImage);
            base.Start();
        }

        public ICommand ImageChooseCommand
        {
            get
            {
                return _imageChooseCommand;
            }
        }

        public int SelectedImageIndex
        {
            get { return _selectedImageIndex; }
            set
            {
                _selectedImageIndex = value;
                RaisePropertyChanged(() => SelectedImageIndex);
            }
        }

        private void ChooseImage()
        {
            
        }
    }
}
