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
    public class ViewApplicantModel : PageModel
    {
        private readonly CrecheContext _db;

        public ViewApplicantModel(CrecheContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Applicant applicant { get; set; }

        public IActionResult OnGet(int id)
        {
            applicant = _db.Applicants.Find(id);

            if (applicant == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}