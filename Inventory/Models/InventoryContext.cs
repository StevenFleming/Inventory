using Microsoft.EntityFrameworkCore;

namespace Inventory.Models
{
  public class InventoryContext : DbContext
  {
    public DbSet<Item> Items { get; set; }

    public InventoryContext(DbContextOptions options) : base(options) { }
  }
}