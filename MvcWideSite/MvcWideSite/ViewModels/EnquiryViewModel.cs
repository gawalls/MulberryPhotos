using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

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

        public bool EmailSent { get; set; }
        
        public EnquiryViewModel()
        {
        }

        public EnquiryViewModel(string name, string title, MetaDataViewModel metaData, List<ImageViewModel> images, List<ContentSectionViewModel> contentList) 
            : base(name, title, metaData, images, contentList)
        {
        }

        public string HtmlMessageBody
        {
            get
            {
                StringBuilder builder = new StringBuilder();
                builder.Append("<p>There is a query from the following email address</p>");
                builder.Append("<br/>");
                builder.Append("<br/>");
                builder.Append("<table>");
                builder.Append($"<tr><td>Name</td><td>{EnquiryName}</td></tr>");
                builder.Append($"<tr><td>Phone</td><td>{Phone}</td></tr>");
                builder.Append($"<tr><td>Email</td><td>{Email}</td></tr>");
                builder.Append($"<tr><td>Comments</td><td>{Comments}</td></tr>");
                builder.Append("</table>");

                return builder.ToString();
            }
        }
    }
}