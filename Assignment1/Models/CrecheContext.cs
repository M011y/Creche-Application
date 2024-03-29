﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//database to store the applicants
namespace Assignment.Models
{
    public class CrecheContext : DbContext
    {
        public CrecheContext(DbContextOptions<CrecheContext> options) : base(options)
        { }

        public DbSet<Applicant> Applicants { get; set; }
    }
}
