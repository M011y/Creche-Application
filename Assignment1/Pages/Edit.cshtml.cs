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
    public class EditModel : PageModel
    {
        //brings in database
        private readonly CrecheContext _db;

        public EditModel(CrecheContext db)
        {
            //applicant = new Applicant();
            _db = db;
        }

        //brings in applicant
        [BindProperty]
        public Applicant applicant { get; set; }

        //checks ID from button clicked and helps route to correspoding view applicant page
        public IActionResult OnGet(int id)
        {
            applicant = _db.Applicants.Find(id);

            if (applicant == null)
            {
                return NotFound();
            }
            return Page();
        }

        //if all validation is passed, including atleast one day checked, redirect to thank-you page, otherwise return this page
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid && CheckIfADayTicked(applicant))
            {
                _db.Applicants.Update(applicant);
                await _db.SaveChangesAsync();
                return RedirectToPage("ThankYou", new { id = applicant.ID });
            }

            else
            {
                return Page();
            }
        }

        //method to check if atleast one day is chosen
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