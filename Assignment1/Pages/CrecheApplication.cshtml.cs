using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment1.Pages
{
    public class CrecheApplicationModel : PageModel
    {
        public string[] DayList { get; set; }
        = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        [Required]
        [BindProperty]
        public bool[] Days { get; set; } = new bool[7];

        public void OnGet()
        {

        }
    }
}