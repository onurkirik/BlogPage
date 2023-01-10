using System.ComponentModel.DataAnnotations;

namespace Blog.DATA
{
    public class Despatch
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(400)]
        public string Title { get; set; } = null!;
        public string? Content { get; set; }
        [MaxLength(255)]
        public string? Image { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ChangedDate { get; set; } = DateTime.Now;
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
