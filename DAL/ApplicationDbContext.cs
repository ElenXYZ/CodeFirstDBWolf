using DAL.Models;
using System.Data.Entity;

namespace DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base ("DbConnection")
        {
        }
        public DbSet<Folder> Folders { get; set; }
        public DbSet<File> Files { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Folder>().ToTable($"{nameof(Folders)}");
            modelBuilder.Entity<File>().ToTable($"{nameof(Files)}");
        }       
    }
}
