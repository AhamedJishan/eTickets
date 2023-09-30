using Microsoft.EntityFrameworkCore;

namespace eTicket.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
        }
    }
}
