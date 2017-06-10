using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WhatsTheDiff.Models
{
    public class StartReviewModel
    {
        [DisplayName("GitHub PR Url")]
        [Required(ErrorMessage = "Please provide a PR link")]
        public string GitPrUrl { get; set; }
    }
}