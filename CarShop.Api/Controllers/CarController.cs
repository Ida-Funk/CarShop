using Microsoft.AspNetCore.Mvc;
using CarShop.Domain;
using CarShop.Infrastructure;
using System.Text;

namespace CarShop.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CarsController : ControllerBase
{
    private readonly ICarReporitory _carRepository;

    public CarsController(ICarReporitory carReporitory)
    {
        _carRepository = carReporitory;
    }

    [HttpGet]
    public async Task<ActionResult<string>> GetAllCars()
    {
        var cars = await _carRepository.GetAllCars();

        return Ok(cars);
    }
}
