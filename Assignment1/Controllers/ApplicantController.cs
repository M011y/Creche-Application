using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class ApplicantController : Controller
    {
        //// GET: Applicant
        //public ActionResult Index()
        //{
        //    return View();
        //}

        // GET: Applicant/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}