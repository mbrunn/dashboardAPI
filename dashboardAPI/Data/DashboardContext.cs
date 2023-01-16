using dashboardAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace dashboardAPI.Data {
    public class DashboardContext : DbContext {
        public DashboardContext(DbContextOptions<DashboardContext> options) : base(options) { }

        public DbSet<UserCredentials> _users { get; set; }
    }
}
