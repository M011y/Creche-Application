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

        // GET: Applicant/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
    }
}