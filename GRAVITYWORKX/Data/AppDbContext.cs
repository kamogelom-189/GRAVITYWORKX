using GRAVITYWORKX.Models;
using Microsoft.EntityFrameworkCore;


namespace GRAVITYWORKX.Data
{
    public class AppDbContext : DbContext
    {
        public 
            AppDbContext(DbContextOptions<AppDbContext> options)
        { 
        }

        public DbSet<Customer> customers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

    }
}
