using CarInventoryDataGrid.Domain;
using CarInventoryDataGrid.Models;

namespace CarInventoryDataGrid.Services;

public interface ICarService
{
    Task CreateCarAsync(CarEntity car);
    Task DeleteCarAsync(int id);
    Task<IEnumerable<CarEntity>> GetCarEntities();
    IEnumerable<Car> GetCars();
    Task UpdateCarAsync(CarEntity car);
}
