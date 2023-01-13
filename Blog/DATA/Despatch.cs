using System.ComponentModel.DataAnnotations;

namespace Blog.DATA
{
    public class Despatch
    {
        public int Id { get; set; }

        [Display(Name ="Title")]
        [Required(ErrorMessage ="{0} field is necessery.")]
        [MaxLength(400)]
        public string Title { get; set; } = null!;
        
        [Display(Name ="Content")]
        public string? Content { get; set; } = "";

        [MaxLength(255)]
        public string? Image { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ChangedDate { get; set; } = DateTime.Now;
        
        [Display(Name ="Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
