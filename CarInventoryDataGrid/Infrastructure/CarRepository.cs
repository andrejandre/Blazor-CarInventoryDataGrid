using CarInventoryDataGrid.Domain;
using CarInventoryDataGrid.Models;
using Microsoft.EntityFrameworkCore;

namespace CarInventoryDataGrid.Infrastructure;

public class CarRepository : ICarRepository
{

    private readonly CarsDbContext _context;

    public CarRepository(CarsDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<CarEntity>> GetAllAsync()
    {
        return await _context.CarInventory.ToListAsync();
    }

    public async Task<CarEntity?> GetByIdAsync(int id)
    {
        return await _context.CarInventory.FindAsync(id);
    }

    public async Task AddAsync(CarEntity car)
    {
        await _context.CarInventory.AddAsync(car);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(CarEntity car)
    {
        _context.CarInventory.Update(car);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var car = await _context.CarInventory.FindAsync(id);
        if (car != null)
        {
            _context.CarInventory.Remove(car);
            await _context.SaveChangesAsync();
        }
    }

    public IEnumerable<Car> GetCars()
    {
        return new List<Car>
        { 
            new Car("Porsche", "Macan", 2024, 80000, "Gasoline", "Orange"),
            new Car("Ford", "Mustang", 2020, 36313, "Gasoline", "Blue"),
            new Car("BMW", "3 Series", 2014, 17898, "Disel", "Black"),
            new Car("Tesla", "Model Y", 2022, 49888, "Electric", "Yellow"),
            new Car("Toyota", "Camry", 2019, 38999, "Hybrid", "Silver"),
            new Car("BMW", "3 Series", 2014, 17898, "Disel", "Black"),
            new Car("Tesla", "Model Y", 2022, 49888, "Electric", "Yellow"),
            new Car("Toyota", "Camry", 2019, 38999, "Hybrid", "Silver"),
            new Car("BMW", "3 Series", 2014, 17898, "Disel", "Black"),
            new Car("Tesla", "Model Y", 2022, 49888, "Electric", "Yellow"),
            new Car("Toyota", "Camry", 2019, 38999, "Hybrid", "Silver"),
            new Car("BMW", "3 Series", 2014, 17898, "Disel", "Black"),
            new Car("Tesla", "Model Y", 2022, 49888, "Electric", "Yellow"),
            new Car("Toyota", "Camry", 2019, 38999, "Hybrid", "Silver"),
            new Car("BMW", "3 Series", 2014, 17898, "Disel", "Black"),
            new Car("Tesla", "Model Y", 2022, 49888, "Electric", "Yellow"),
            new Car("Toyota", "Camry", 2019, 38999, "Hybrid", "Silver"),
            new Car("BMW", "3 Series", 2014, 17898, "Disel", "Black"),
            new Car("Tesla", "Model Y", 2022, 49888, "Electric", "Yellow"),
            new Car("Toyota", "Camry", 2019, 38999, "Hybrid", "Silver")
        };
    }
}
