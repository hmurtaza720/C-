using Microsoft.AspNetCore.Mvc;
using EMS_Murtaza.Models;

namespace EMS_Murtaza.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeesController : ControllerBase
{
    private readonly EMSContext _context;

    public EmployeesController(EMSContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var employees = _context.Employees.ToList();
        return Ok(employees);
    }
}
