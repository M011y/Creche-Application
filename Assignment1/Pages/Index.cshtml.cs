using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            CookieOptions options = new CookieOptions();

            options.Expires = DateTime.Now.AddDays(365);

            Response.Cookies.Append("CrecheCookie", "Visit", options);

            if (Request.Cookies["CrecheCookie"] != null)
            {
                Message = "Welcome back";
            }
            else
            {
                Message = "First visit";
            }
        }
    }
}