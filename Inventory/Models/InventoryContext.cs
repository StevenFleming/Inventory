using Microsoft.EntityFrameworkCore;

namespace Inventory.Models
{
  public class InventoryContext : DbContext
  {
    public DbSet<Collection> Collections { get; set; }

    public InventoryContext(DbContextOptions options) : base(options) { }
  }
}