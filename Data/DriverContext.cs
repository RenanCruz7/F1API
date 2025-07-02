using F1API.Models;
using Microsoft.EntityFrameworkCore;
namespace F1API.Data;
public class DriverContext : DbContext
{
    public DriverContext(DbContextOptions<DriverContext> opts) : base(opts)
    {
    }
    
    public DbSet<Driver> Drivers { get; set; }
}
