using Microsoft.EntityFrameworkCore;

namespace BugDemo
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Model> Models { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<Model>()
            //    .Property(entity => entity.EnumField)
            //    .HasConversion<string>();
        }
    }
}