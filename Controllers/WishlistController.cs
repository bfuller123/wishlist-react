using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using wishlist_react.Models;

namespace wishlist_react.Controllers
{
    [Route("api/[controller]")]
    public class WishlistController : Controller
    {
        private WishlistContext _context;

        public WishlistController(WishlistContext context)
        {
            _context = context;
        }
        // GET: api/wishlist/5
        [HttpGet("{userId}")]
        public IEnumerable<WishlistItem> GetWishlist(long userId)
        {
            return _context.WishlistDB.Where(wishlistItem => wishlistItem.UserId == userId);
        }

        // GET api/values/5
        [HttpGet("{userId}/item/{id}")]
        public WishlistItem GetItem(long id)
        {
            return _context.WishlistDB.FirstOrDefault(wishlistItem => wishlistItem.Id == id);
        }

        // POST api/values
        [HttpPost("{userId}")]
        public IActionResult Post(long userId, [FromBody]WishlistItem item)
        {
            _context.WishlistDB.Add(item);
            _context.SaveChanges();
            return Ok($"{item.Description} added on {item.DateAdded.ToString()}");
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
