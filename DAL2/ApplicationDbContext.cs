using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL2
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name=ConnectionStringForSQL") 
        {
           var ensureDllIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
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
