using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Blog.Areas.Admin.Models
{
    public class DespatchViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "{0} field is necessery.")]
        [MaxLength(400)]
        public string Title { get; set; } = null!;

        [Display(Name = "Content")]
        public string? Content { get; set; } = "";

        [Display(Name = "Category")]
        [Required(ErrorMessage ="{0} field is necessary.")]
        public int? CategoryId { get; set; }
    }
}
