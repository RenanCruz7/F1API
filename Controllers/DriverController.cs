using F1API.Models;
using Microsoft.AspNetCore.Mvc;

namespace F1API.Controllers;
[ApiController]
[Route("[controller]")]
public class DriverController : ControllerBase
{
    private List<Driver> drivers = new List<Driver>
    {
        new Driver {name = "Lewis Hamilton", team = "Mercedes", wins = 100, podiums = 200 },
        new Driver {name = "Max Verstappen", team = "Red Bull Racing", wins = 64, podiums = 100 },
        new Driver {name = "Charles Leclerc", team = "Ferrari", wins = 50, podiums = 50}
    };

    [HttpPost]
    public void AddDriver([FromBody]Driver driver)
    {
        drivers.Add(driver);
        Console.WriteLine(driver.name);
        Console.WriteLine(driver.team);
    }

    [HttpGet]
    public List<Driver> GetDrivers()
    {
        return drivers;
    }
}
