using CarShop.Domain;

namespace CarShop.Infrastructure;

public class CarRepository : ICarReporitory
{
    // public string GetAllCars()
    public Task<string> GetAllCars()
    // public Task<List<Car>> GetAllCars()
    {
        return Task.FromResult("All Data");
    }

    // public string GetCarById()
    public Task<string> GetCarById()
    // public Task<Car?> GetCarById()
    {
        return Task.FromResult("Data for id x");
        
    }
}
