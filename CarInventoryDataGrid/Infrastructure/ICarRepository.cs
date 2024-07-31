using CarInventoryDataGrid.Domain;
using CarInventoryDataGrid.Models;

namespace CarInventoryDataGrid.Infrastructure;

public interface ICarRepository
{
    Task AddAsync(CarEntity car);
    Task DeleteAsync(int id);
    Task<IEnumerable<CarEntity>> GetAllAsync();
    Task<CarEntity?> GetByIdAsync(int id);
    IEnumerable<Car> GetCars();
    Task UpdateAsync(CarEntity car);
}
