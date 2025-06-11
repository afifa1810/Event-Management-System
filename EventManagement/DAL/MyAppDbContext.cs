using EventManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EventManagement.DAL
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<Product> Products { get; set; }
    }
}
