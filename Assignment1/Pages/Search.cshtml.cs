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
    public class SearchModel : PageModel
    {
        //brings in database
        private readonly CrecheContext _db;

        public SearchModel(CrecheContext db)
        {
            _db = db;
        }

        //brings in applicants
        public IList<Applicant> Applicants { get; private set; }

        [TempData]
        public string SearchBy { get; set; }

        //extracts applicants as list
        public async Task OnGetAsync()
        {
            Applicants = await _db.Applicants.AsNoTracking().ToListAsync();
        }

        //public void OnGet()
        //{

        //}
    }
}