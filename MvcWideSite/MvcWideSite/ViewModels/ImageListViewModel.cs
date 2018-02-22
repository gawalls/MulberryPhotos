using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcWideSite.Enums;

namespace MvcWideSite.ViewModels
{
    public class ImageListViewModel : IEnumerable<ImageViewModel>
    {
        private List<ImageViewModel> _images = new List<ImageViewModel>();

        public ImageListViewModel()
        {
        }

        private ImageListViewModel(IEnumerable<ImageViewModel> enumerableItems)
        {
            _images = enumerableItems.ToList();
        }

        public void Add(ImageViewModel image)
        {
            _images.Add(image);
        }

        private IEnumerable<ImageViewModel> GetImages(ImageTypeEnum imageType)
        {
            return _images.FindAll(i => i.ImageType == imageType).OrderBy(s => s.RotationOrder).ToList();
        }

        public ImageListViewModel CarouselImages
        {
            get { return new ImageListViewModel(GetImages(ImageTypeEnum.Carousel)); }
        }

        public bool HasManyImages
        {
            get { return _images.Count > 1; }
        }

        public void AddRange(IEnumerable<ImageViewModel> images)
        {
            _images.AddRange(images);
        }
        public IEnumerator<ImageViewModel> GetEnumerator()
        {
            return _images.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}