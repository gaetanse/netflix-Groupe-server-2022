using Microsoft.EntityFrameworkCore;
using netflixTestConsole.database.classes;

namespace CoursEntityFrameWorkCore
{
    public class DataContext : DbContext
    {
        //public DbSet<Category> Categorys { get; set; }
        //public DbSet<Faq> Faqs { get; set; }
        //public DbSet<ImageData> Images { get; set; }
        //public DbSet<Ressource> Ressources { get; set; }
        //public DbSet<Statut> Statuts { get; set; }
        //public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<ImageData> ImageDatas { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Statut> Statuts { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Ressource> Ressources { get; set; }
        public DataContext() : base(){  }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrateur\Documents\netflix999.mdf;Integrated Security=True;Connect Timeout=30");
        }
    }
}