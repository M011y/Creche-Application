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

        public string[] DayList { get; set; }
        = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

        [BindProperty]
        public bool[] Days { get; set; } = new bool[5];

        public List<SelectListItem> HoursList { get; set; } =
        new List<SelectListItem>
            { new SelectListItem ("FullTime", "Full-Time" ),
              new SelectListItem ("PartTime", "Part-Time" )};

        //[BindProperty]
        //public Parent Parent { get; set; }

        public List<SelectListItem> RelationshipList { get; set; } =
        new List<SelectListItem>
            { new SelectListItem ("Father", "Father" ),
              new SelectListItem ("Mother", "Mother" ),
              new SelectListItem ("Other", "Other")};

        private readonly CrecheContext _db;

        public CrecheApplicationModel(CrecheContext db)
        {
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