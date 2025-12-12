using Microsoft.EntityFrameworkCore;
using WebApplication1.Domain;

namespace WebApplication1
{
    public class VehicleContext : DbContext
    {
        public VehicleContext(DbContextOptions options)
           : base(options)
        {
        }
        public DbSet<Vehicle>? Vehicles { get; set; }
    }
}
