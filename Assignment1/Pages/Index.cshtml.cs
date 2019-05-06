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
        public string Value { get; private set; }

        public void OnGet()
        {
            var cookie = Request.Cookies["CrecheCookie"];

            CookieOptions options = new CookieOptions();

            options.Expires = DateTime.Now.AddYears(1);

            Response.Cookies.Append("CrecheCookie", Value = Convert.ToString(DateTime.Now), options);

            if (cookie != null)
            {
                Message = $"{cookie}";

            }
            else
            {
                Message = "First visit";
            }
        }
    }
}