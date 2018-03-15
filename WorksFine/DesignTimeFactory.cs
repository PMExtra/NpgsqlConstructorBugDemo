using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WorksFine
{
    public class DesignTimeFactory : IDesignTimeDbContextFactory<MyDbContext>
    {
        public MyDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyDbContext>();

            builder.UseNpgsql("Server=localhost; UserId=postgres; Password=postgres; Database=Test;");

            return new MyDbContext(builder.Options);
        }
    }
}