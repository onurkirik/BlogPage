using Microsoft.EntityFrameworkCore;

namespace Blog.DATA
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Despatch> Despatches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Genel" },
                new Category() { Id = 2, Name = "Gezilerim" },
                new Category() { Id = 3, Name = "Mutfağım" },
                new Category() { Id = 4, Name = "İş Dünyası" }
                );

            modelBuilder.Entity<Despatch>().HasData(CreateDespatch());

            base.OnModelCreating(modelBuilder);
        }

        private Despatch[] CreateDespatch()
        {
            var despatches = new Despatch[48];

            for (int i = 0; i < despatches.Length; i++)
            {
                despatches[i] = new Despatch
                {
                    Id = i + 1,
                    Title = $"Text Example {i}",
                    Content = @"
<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>
<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>",
                    CategoryId = (i / 12) + 1
                };
            }
            return despatches;
        }
    }
}
