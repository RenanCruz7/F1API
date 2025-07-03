using F1API.Data;
using F1API.Models;
using Microsoft.AspNetCore.Mvc;

namespace F1API.Controllers;
[ApiController]
[Route("[controller]")]
public class DriverController : ControllerBase
{
    private DriverContext _context;

    public DriverController(DriverContext context)
    {
        _context = context;
    }

    [HttpPost]
    public ActionResult AddDriver([FromBody]Driver driver)
    {
        _context.Drivers.Add(driver);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetDriverById), new { Id = driver.Id }, driver);
    }

    [HttpGet]
    public IEnumerable<Driver> GetDrivers([FromQuery] int skip=0, [FromQuery] int take = 50)
    {
        return _context.Drivers.Skip(skip).Take(take);
    }

    [HttpGet("name/{name}")]
    public ActionResult<Driver> GetDriver(string name)
    {
        var driver = _context.Drivers.FirstOrDefault(d => d.name.Trim().Equals(name.Trim(), StringComparison.OrdinalIgnoreCase));
        if (driver == null)
        {
            return NotFound();
        }
        return Ok(driver);
    }

    [HttpGet("id/{Id}")]
    public ActionResult<Driver> GetDriverById(int Id)
    {
        var driver = _context.Drivers.FirstOrDefault(d => d.Id == Id);
        if (driver == null)
        {
            return NotFound();
        }
        return Ok(driver);
    }
}
