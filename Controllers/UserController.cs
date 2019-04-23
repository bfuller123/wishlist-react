using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using wishlist_react.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace wishlist_react.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {

        private readonly UsersContext _context;

        private User[] PreloadUsers = {
            new User{ FirstName = "Bob", LastName = "Belcher" },
            new User{ FirstName = "Midge", LastName = "Maisel" },
            new User{ FirstName = "Tina", LastName = "Turner" },
            new User{ FirstName = "George", LastName = "Costanza" }
            };

        public UserController(UsersContext context)
        {
            _context = context;

            if (_context.UsersDB.Count() == 0)
            {
                _context.AddRange(PreloadUsers);
                _context.SaveChanges();
            }
        }

        // GET api/values/5
        [HttpGet("{userID}")]
        public async Task<ActionResult<User>> Get(long userID)
        {
            var user = await _context.UsersDB.FindAsync(userID);

            if(user == null)
            {
                return NotFound();
            }

            return user;
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            try
            {
                _context.Add(new User { FirstName = user.FirstName, LastName = user.LastName });
                _context.SaveChanges();
                return Ok("User Added");
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
