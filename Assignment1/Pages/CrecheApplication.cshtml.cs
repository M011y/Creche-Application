using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Pages
{
    public class CrecheApplicationModel : PageModel
    {
        [BindProperty]
        public Applicant Applicant { get; set; }

        public List<SelectListItem> HoursList { get; set; } =
        new List<SelectListItem>
            { new SelectListItem ("FullTime", "Full-Time" ),
              new SelectListItem ("PartTime", "Part-Time" )};

        public List<SelectListItem> RelationshipList { get; set; } =
        new List<SelectListItem>
            { new SelectListItem ("Father", "Father" ),
              new SelectListItem ("Mother", "Mother" ),
              new SelectListItem ("Other", "Other")};

        private readonly CrecheContext _db;

        public CrecheApplicationModel(CrecheContext db)
        {
            Applicant = new Applicant();
            _db = db;
        }

        public async Task<IActionResult> OnPostAsync()
        { 
            if (ModelState.IsValid)
            {
                _db.Applicants.Add(Applicant);
                await _db.SaveChangesAsync();
                return RedirectToPage("ThankYou");
            }

            else
            {
                return Page();
            } 
        }
    }
}