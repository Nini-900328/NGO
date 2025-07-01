using Microsoft.EntityFrameworkCore;

namespace Caseshopping0625.Models
{
    public class ActivityContext : DbContext
    {
        public ActivityContext(DbContextOptions<ActivityContext> options)
            : base(options)
        {
        }

        public DbSet<ActivityItem> ActivityItem { get; set; }
    }
}
