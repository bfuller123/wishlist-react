using System;
using Microsoft.EntityFrameworkCore;

namespace wishlist_react.Models
{
    public class WishlistContext : DbContext
    {
        public WishlistContext(DbContextOptions<WishlistContext> options) : base(options)
        {
        }

        public DbSet<WishlistItem> WishlistDB { get; set; }
    }
}
