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
    public class ListApplicantsModel : PageModel
    {
        //brings in database
        private readonly CrecheContext _db;

        public ListApplicantsModel(CrecheContext db)
        {
            _db = db;
        }

        //brings in applicants
        public IList<Applicant> Applicants { get; private set; }

        //search name property
        [BindProperty]
        public string SearchName { get; set; }

        //temp data search by
        [TempData]
        public string SearchBy { get; set; }

        //extracts applicants as list
        public async Task OnGetAsync()
        {
            Applicants = await _db.Applicants.AsNoTracking().ToListAsync();
        }

        //redirect to search page when search button is pressed.
        public async Task<IActionResult> OnPostAsync()
        {
            SearchBy = SearchName;
            return RedirectToPage("/Search");
        }
    }
}