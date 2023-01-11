namespace Blog.Models
{
    public class HomeviewModel
    {
        public int? CategoryId { get; set; }
        public List<Despatch> Despatches { get; set; } = new();
        public int Page { get; set; }
        public int PageNumber { get; set; }
        public bool ExistOldPage => PageNumber > Page;
        public bool ExistNewPage => Page > 1;
    }
}
