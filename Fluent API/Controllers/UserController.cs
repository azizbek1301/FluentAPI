using Fluent_API.DataAcsess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fluent_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private ApplicationDbContext _context;
        public UserController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;

        }

        [HttpGet]
        public async ValueTask<IActionResult> GetNimadur()
        {
            var result = await _context.Persons
                .Include(x=>x.Cars)
                .ToListAsync();
            return Ok(result);
        }
    }
}
