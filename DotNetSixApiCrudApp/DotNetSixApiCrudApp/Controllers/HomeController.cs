using DotNetSixApiCrudApp.Models;
using DotNetSixApiCrudApp.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetSixApiCrudApp.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get People
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "GetPeople")]
        public async Task<IEnumerable<Person>> GetPeople()
        {
            return await _context.People.ToListAsync();
        }

        /// <summary>
        /// Add new person
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task AddPerson(PersonViewModel model)
        {
            await _context.People.AddAsync(new Person { Name = model.Name, Email = model.Email, Phone = model.Phone });
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Update person
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task UpdatePerson(int id, PersonViewModel model)
        {
            var result = await _context.People.FindAsync(id);
            result.Name = model.Name;
            result.Email = model.Email;
            result.Phone = model.Phone;
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Delete a Person.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task DeletePerson(int id)
        {
            var result = await _context.People.FindAsync(id);
            _context.Remove(result);
            await _context.SaveChangesAsync();
        }
    }
}
