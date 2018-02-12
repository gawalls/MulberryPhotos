using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcWideSite.ViewModels
{

    public class EnquiryViewModel : WebPageViewModel
    {
        [Required(ErrorMessage = "You must enter a name")]
        public string EnquiryName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "You must enter a valid phone number")]
        public string Phone { get; set; }
        
        public string Comments { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "You must enter an email address")]
        public string Email { get; set; }
        
        public EnquiryViewModel()
        {
        }

        public EnquiryViewModel(string name, string title, MetaDataViewModel metaData, List<ImageViewModel> images, List<ContentSectionViewModel> contentList) 
            : base(name, title, metaData, images, contentList)
        {
        }
    }
}