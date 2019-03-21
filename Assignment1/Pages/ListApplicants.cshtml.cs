using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Pages.Applicants
{
    public class ListApplicantsModel : PageModel
    {
        private readonly CrecheContext _db;

        public ListApplicantsModel(CrecheContext db)
        {
            _db = db;
        }

        public IList<Applicant> Applicants { get; private set; }

        public async Task OnGetAsync()
        {
            Applicants = await _db.Applicants.AsNoTracking().ToListAsync();
        }

        public async Task<IActionResult> RedirectToPage()
        {
            return RedirectToPage("ViewApplicant");
        }
    }
}