using System;
using System.Net.Http;
using System.Threading.Tasks;
using Assignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment.Pages
{
    public class IndexModel : PageModel
    {
        //message property
        public string Message { get; set; }

        public string Joke { get; set; }

        //value of cookie
        public string Value { get; private set; }

        public async Task OnGetAsync()
        {
            //adding external api
            HttpClient client = new HttpClient();

            var request = new HttpRequestMessage(HttpMethod.Get, "https://icanhazdadjoke.com/");
            request.Headers.Add("Accept", "text/plain");
            var response = await client.SendAsync(request);

            Joke = await response.Content.ReadAsStringAsync();

            //creating cookie
            var cookie = Request.Cookies["CrecheCookie"];

            //creating cookie options
            CookieOptions options = new CookieOptions();

            //specifying cookie options - cookie will last for one year
            options.Expires = DateTime.Now.AddYears(1);

            //appending cookie each time with new time of visit
            Response.Cookies.Append("CrecheCookie", Value = Convert.ToString(DateTime.Now), options);

            //if there was already a cookie,c message = last time of visit
            if (cookie != null)
            {
                Message = $"{cookie}";

            }
            //if there was no previous cookie, message = first visit
            else
            {
                Message = "First visit";
            }
        }
    }
}