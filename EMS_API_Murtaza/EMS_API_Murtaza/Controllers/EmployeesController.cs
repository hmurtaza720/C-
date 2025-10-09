using AutoMapper;
using EMS_API_Murtaza.DTOs;
using EMS_API_Murtaza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace EMS_API_Murtaza.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EMSContext _context;
        private readonly IMemoryCache _cache;
        private readonly IMapper _mapper;
        private readonly ILogger<EmployeesController> _logger;

        public EmployeesController(EMSContext context, IMemoryCache cache, IMapper mapper, ILogger<EmployeesController> logger)
        {
            _context = context;
            _cache = cache;
            _mapper = mapper;
            _logger = logger;
        }

        // GET: api/Employees
        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            _logger.LogInformation("Fetching all employees at {time}", DateTime.Now);

            if (!_cache.TryGetValue("employees", out List<EmployeeDto>? employeeDtos))
            {
                var employees = await _context.Employees.ToListAsync();
                employeeDtos = _mapper.Map<List<EmployeeDto>>(employees);

                // store in cache for 5 minutes
                _cache.Set("employees", employeeDtos, TimeSpan.FromMinutes(5));
                _logger.LogInformation("Employee data cached at {time}", DateTime.Now);
            }

            return Ok(employeeDtos);
        }

        // GET: api/Employees/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            _logger.LogInformation("Fetching employee with ID {id} at {time}", id, DateTime.Now);

            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                _logger.LogWarning("Employee with ID {id} not found at {time}", id, DateTime.Now);
                return NotFound();
            }

            var employeeDto = _mapper.Map<EmployeeDto>(employee);
            return Ok(employeeDto);
        }
    }
}
