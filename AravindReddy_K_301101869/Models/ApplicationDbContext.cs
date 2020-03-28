using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AravindReddy_K_301101869.Models
{
    public class ApplicationDbContext : DbContext
    {
         public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Club> clubitems { get; set; }

        public DbSet<Player> playeritems { get; set; }
    }

}
