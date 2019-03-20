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
    public class CrecheApplicationModel : PageModel
    {
        [BindProperty]
        public Child Child { get; set; }

        private readonly CrecheContext _db;

        public CrecheApplicationModel(CrecheContext db)
        {
            _db = db;
        }

        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _db.Children.Add(Child);
        //        await _db.SaveChangesAsync();
        //        return RedirectToPage("ListChildren");
        //    }

        //    else
        //    {
        //        return Page();
        //    }
        //}
    }
}