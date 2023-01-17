using Microsoft.EntityFrameworkCore;
using dashboardAPI.Models;

namespace dashboardAPI.Data {
    public class DashboardContext : DbContext, IDashboardContext{
        public DashboardContext(DbContextOptions<DashboardContext> options) : base(options) { }

        public DbSet<UserCredentials> Users { get; set; }
    }
}
