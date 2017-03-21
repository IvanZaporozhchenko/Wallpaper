using MvvmCross.Core.ViewModels;
using System.Collections.Generic;

namespace Wallpaper.ViewModels
{
    public class MainViewModel 
        : MvxViewModel
    {
        public MainViewModel()
        {
            Images = new List<ImageUrlModel>();
            Images.Add(new ImageUrlModel
            {
                ImageUrl = "https://pp.vk.me/c628629/v628629456/25236/V-DAlVsK1vc.jpg"
            });
            Images.Add(new ImageUrlModel
            {
                ImageUrl = "https://pp.vk.me/c628629/v628629456/25236/V-DAlVsK1vc.jpg"
            });
            Images.Add(new ImageUrlModel
            {
                ImageUrl = "https://pp.vk.me/c628629/v628629456/25236/V-DAlVsK1vc.jpg"
            });
            Images.Add(new ImageUrlModel
            {
                ImageUrl = "https://pp.vk.me/c628629/v628629456/25236/V-DAlVsK1vc.jpg"
            });
            Images.Add(new ImageUrlModel
            {
                ImageUrl = "https://pp.vk.me/c628629/v628629456/25236/V-DAlVsK1vc.jpg"
            });
        }

        public List<ImageUrlModel> Images { get; set; }
    }

}
