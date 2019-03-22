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

        private readonly CrecheContext _db;

        public CrecheApplicationModel(CrecheContext db)
        {
            Applicant = new Applicant();
            _db = db;
        }

        public async Task<IActionResult> OnPostAsync()
        { 
            if (ModelState.IsValid && CheckIfADayTicked(Applicant))
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

        public bool CheckIfADayTicked(Applicant applicant)
        {
            if (applicant.Monday || applicant.Tuesday || applicant.Wednesday
                 || applicant.Thursday || applicant.Friday)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}