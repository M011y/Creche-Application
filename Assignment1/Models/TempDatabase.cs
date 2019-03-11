using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class TempDatabase : DbContext
    {
        public TempDatabase(DbContextOptions<TempDatabase> options) : base(options)
        { }

        public DbSet<Child> Children { get; set; }

        public DbSet<Parent> Parents { get; set; }
    }
}
