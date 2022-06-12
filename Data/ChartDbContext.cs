using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ChartModule.Data
{
    public class ChartDbContext:DbContext
    {
        
        
        public ChartDbContext(DbContextOptions<ChartDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }


        public ChartDbContext(): base()
        {
        }

        /*public DbSet<EmailTemplate> EmailTemplates { get; set; }
        public DbSet<EmailSent> EmailSents { get; set; }
        public DbSet<EmailSetting> Settings { get; set; }
        public DbSet<Email> Email { get; set; }*/
        
        public void DetachAll()
        {
            foreach (EntityEntry entityEntry in this.ChangeTracker.Entries().ToArray())
            {
                if (entityEntry.Entity != null)
                {
                    entityEntry.State = EntityState.Detached;
                }
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}