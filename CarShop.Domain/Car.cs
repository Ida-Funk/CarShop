namespace CarShop.Domain;

public class Car
{
    public int Id { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }
}

public interface ICarReporitory
{
    // // Task<List<Car>> GetAllCars();
    Task<string> GetAllCars();
    // string GetAllCars();
    // // Task<Car?> GetCarById();
    Task<string> GetCarById();
    // string GetCarById();
}