using Microsoft.EntityFrameworkCore;
using EmployeeMSService.Models;

namespace EmployeeMSService.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<Employees> Employees { get; set; }
        public DbSet<Login> Login { get; set; }


    }
}
