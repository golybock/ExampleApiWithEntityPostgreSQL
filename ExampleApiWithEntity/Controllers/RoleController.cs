using Microsoft.AspNetCore.Mvc;
using ExampleApiWithEntity.Models;

namespace ExampleApiWithEntity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly ExampleDatabaseContext _context;

        public RoleController(ExampleDatabaseContext context)
        {
            _context = context;
        }

        [HttpGet("GetRole")]
        public IActionResult GetRole(int id)
        {
            return new OkObjectResult(_context.Roles.FirstOrDefault(c => c.Id == id));
        }

        [HttpPost("AddRole")]
        public IActionResult AddRole(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
            return new OkResult();
        }
        
        
    }
}
