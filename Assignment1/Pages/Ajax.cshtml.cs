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
    public class AjaxModel : PageModel
    {
        //brings in database
        private readonly CrecheContext _db;

        public AjaxModel(CrecheContext db)
        {
            //applicant = new Applicant();
            _db = db;
        }

        //brings in applicant
        [BindProperty]
        public Applicant applicant { get; set; }

        public IList<Applicant> Applicants { get; private set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Applicants = await _db.Applicants.AsNoTracking().ToListAsync();

            return Page();
        }
    }
}