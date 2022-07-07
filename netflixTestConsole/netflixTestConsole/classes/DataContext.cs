using ConsoleApp2.classes;
using Microsoft.EntityFrameworkCore;
using NetflixServerConsoleTest.classes;

namespace CoursEntityFrameWorkCore
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DataContext() : base(){  }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrateur\Documents\netflixDB.mdf;Integrated Security=True;Connect Timeout=30");
        }
    }
}