using Microsoft.EntityFrameworkCore;

namespace EKartEFCore.DataContext
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {

        }
    }
}
