using Microsoft.EntityFrameworkCore;

namespace DBOperations.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base (options)
        {
            

        }
    }
}
