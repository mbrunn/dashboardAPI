using Microsoft.EntityFrameworkCore;
using dashboardAPI.Models;

namespace dashboardAPI.Data
{
    public interface IDashboardContext
    {
        public DbSet<UserCredentials> Users {get; set;}
    }
}