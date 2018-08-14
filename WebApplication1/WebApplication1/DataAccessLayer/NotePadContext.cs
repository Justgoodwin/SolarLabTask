using WebApplication1.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebApplication1.DataAccessLayer
{
    public class NotePadContext : DbContext
    {
        public NotePadContext() : base("NotePadCoontext")
        {

        }

        public DbSet<Notepad> NotePad { get; set; } // create note into Database

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}