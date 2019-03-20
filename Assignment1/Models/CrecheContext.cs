using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class CrecheContext : DbContext
    {
        public CrecheContext(DbContextOptions<CrecheContext> options) : base(options)
        { }

        public DbSet<Child> Children { get; set; }

        //public DbSet<Parent> Parents { get; set; }
    }
}
