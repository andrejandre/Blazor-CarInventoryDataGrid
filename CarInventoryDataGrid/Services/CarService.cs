using CarInventoryDataGrid.Domain;
using CarInventoryDataGrid.Infrastructure;
using CarInventoryDataGrid.Models;

namespace CarInventoryDataGrid.Services;

public class CarService : ICarService
{
    private ICarRepository _carRepository;

    public CarService(ICarRepository carRepository)
    {
        _carRepository = carRepository;
    }

    public async Task<IEnumerable<CarEntity>> GetCarEntities()
    {
        return await _carRepository.GetAllAsync();
    }

    public IEnumerable<Car> GetCars()
    {
        return _carRepository.GetCars();
    }

    public async Task UpdateCarAsync(CarEntity car)
    {
        await _carRepository.UpdateAsync(car);
    }

    public async Task DeleteCarAsync(int id)
    {
        await _carRepository.DeleteAsync(id);
    }

    public async Task CreateCarAsync(CarEntity car)
    {
        await _carRepository.AddAsync(car);
    }
}
