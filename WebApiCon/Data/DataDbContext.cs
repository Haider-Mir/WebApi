using Microsoft.EntityFrameworkCore;

namespace WebApiCon.Data
{
    public class DataDbContext : DbContext
    {
            public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
            {

            }
            public DbSet<Login> Login { get; set; }
        
    }
}
