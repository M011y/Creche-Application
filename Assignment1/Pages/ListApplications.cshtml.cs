using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Pages.Children
{
    public class ListApplicationsModel : PageModel
    {
        private readonly CrecheContext _db;

        public ListApplicationsModel(CrecheContext db)
        {
            _db = db;
        }

        public IList<Child> Children { get; private set; }

        public async Task OnGetAsync()
        {
            Children = await _db.Children.AsNoTracking().ToListAsync();
        }
    }
}