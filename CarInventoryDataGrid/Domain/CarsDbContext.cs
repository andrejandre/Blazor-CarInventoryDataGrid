using Microsoft.EntityFrameworkCore;

namespace CarInventoryDataGrid.Domain;

public class CarsDbContext : DbContext
{
    public CarsDbContext(DbContextOptions<CarsDbContext> options) : base(options)
    {
        
    }

    public DbSet<CarEntity> CarInventory { get; set; }
}
