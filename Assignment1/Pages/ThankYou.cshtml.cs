﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Pages
{
    public class ThankYouModel : PageModel
    {
        //brings in database
        private readonly CrecheContext _db;

        public ThankYouModel(CrecheContext db)
        {
            _db = db;
        }

        //brings in applicants
        public IList<Applicant> Applicants { get; private set; }

        //message default at max cost - gets overwritten
        public string Message { get; set; } = "€157.50";

        //Calculations: €20 part time p/d, €35 full time p/d
        //Discount 10% if 4 or more days
        public async Task OnGetAsync()
        {
            Applicants = await _db.Applicants.AsNoTracking().ToListAsync();

            //checks how many days ticked
            foreach (var applicant in Applicants)
            {
                var numOfDays = 0;
                if (applicant.Monday) { numOfDays++; }
                if (applicant.Tuesday) { numOfDays++; }
                if (applicant.Wednesday) { numOfDays++; }
                if (applicant.Thursday) { numOfDays++; }
                if (applicant.Friday) { numOfDays++; }

                //calculations for full-time
                if (applicant.Hours is "Full-Time")
                {
                    decimal cost = numOfDays * 35;
                    if(numOfDays > 3)
                    {
                        cost = cost * (decimal)0.9;
                    }
                    Message = $"{cost:C}";
                }
                //calculations for part-time
                else
                {
                    decimal cost = numOfDays * 20;
                    if (numOfDays > 3)
                    {
                        cost = cost * (decimal)0.9;
                    }
                    Message = $"{cost:C}";
                }
            }
        }


    }
}