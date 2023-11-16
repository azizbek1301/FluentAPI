using Fluent_API.DataAcsess;
using Fluent_API.Models;
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
            //    var result = await _context.Cars
            //        .Include(x => x.Person)
            //        .ThenInclude(x => x.Cars)
            //        .ToListAsync();
            //.FirstOrDefaultAsync(x => x.Name == "Ali");
            return Ok(" ");
        }


        [HttpPost]
        public async ValueTask<IActionResult> CreatePerson(string name)
        {
            Person person = new Person();
            person.Name = name; 
            await _context.Persons.AddAsync(person);
            await _context.SaveChangesAsync();
            return Ok("Lets Check");
        }
    }
}
