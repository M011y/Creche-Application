using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment.Pages
{
    public class ThankYouModel : PageModel
    {
        //Calculations: €20 part time p/d, €35 full time p/d
        //Discount 10% if 4 or more days

        public string Message { get; set; } = "€157.50";
        //public void OnGet()
        //{
        //    if (Applicant.Hours = "Full-Time")
        //    {
        //        Message = "";
        //    }
        //    else
        //    {
        //        Message = "";
        //    }
        //}
    }
}