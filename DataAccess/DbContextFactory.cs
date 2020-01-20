using DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess
{
    public class DbContextFactory:IDbContextFactory
    {
        private readonly IConfiguration _configuration;

        public DbContextFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public ApplicationDbContext GetDbContext()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            builder.UseSqlite(
                _configuration.GetConnectionString("DefaultConnection"));
            return new ApplicationDbContext(builder.Options);
        }
    }
}