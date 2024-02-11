using InventorySystem.Models;
using Microsoft.EntityFrameworkCore;

namespace InventorySystem.Controllers.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
