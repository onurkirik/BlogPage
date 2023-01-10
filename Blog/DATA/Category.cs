using System.ComponentModel.DataAnnotations;

namespace Blog.DATA
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;
        public List<Despatch> Despatches { get; set; } = new List<Despatch>();


    }
}
