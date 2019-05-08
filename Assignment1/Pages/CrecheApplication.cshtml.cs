using System.Threading.Tasks;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment.Pages
{
    public class CrecheApplicationModel : PageModel
    {
        //creates applicant object
        [BindProperty]
        public Applicant Applicant { get; set; }

        //brings in database
        private readonly CrecheContext _db;

        //adds applicant to database
        public CrecheApplicationModel(CrecheContext db)
        {
            Applicant = new Applicant();
            _db = db;
        }

        //if all validation is passed, including atleast one day checked, redirect to thank-you page, otherwise return this page
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid && CheckIfADayTicked(Applicant))
            {
                _db.Applicants.Add(Applicant);
                await _db.SaveChangesAsync();
                return RedirectToPage("ThankYou", new { id = Applicant.ID });
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