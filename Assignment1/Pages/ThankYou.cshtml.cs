using System;
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
        //Calculations: €20 part time p/d, €35 full time p/d
        //Discount 10% if 4 or more days
        private readonly CrecheContext _db;

        public ThankYouModel(CrecheContext db)
        {
            _db = db;
        }

        public IList<Applicant> Applicants { get; private set; }

        public string Message { get; set; } = "€157.50";

        public async Task OnGetAsync()
        {
            Applicants = await _db.Applicants.AsNoTracking().ToListAsync();

            foreach (var applicant in Applicants) {
                if (applicant.Hours is "Full-Time")
                {
                    Message = "€157.50";
                }
                else
                {
                    Message = "€100";
                } }
        }

        
    }
}