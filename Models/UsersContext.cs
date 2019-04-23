using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace wishlist_react.Models
{
    public class UsersContext : DbContext
    {

        public UsersContext(DbContextOptions<UsersContext> options) : base(options)
        {
        }

        public DbSet<User> UsersDB { get; set; }

    }
}
