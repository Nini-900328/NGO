using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
using NGOPlatformWeb.Models.ViewModels;
=======
>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
namespace NGOPlatformWeb.Models.Entity
{
    public class NGODbContext : DbContext
    {
        public NGODbContext(DbContextOptions<NGODbContext> options) : base(options) { }

        public DbSet<Activity> Activities { get; set; }
        public DbSet<Supply> Supplies { get; set; }
        public DbSet<SupplyCategory> SupplyCategories { get; set; }
<<<<<<< HEAD
        public DbSet<User> Users { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<CaseLogin> CaseLogins { get; set; }
=======
>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
        // 後續其他 DbSet 也可一起加上
        public DbSet<RegularSupplyNeeds> RegularSuppliesNeeds { get; set; }
        public DbSet<EmergencySupplyNeeds> EmergencySupplyNeeds { get; set; }

    }
}
