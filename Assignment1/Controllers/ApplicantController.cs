using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    [Route("data/[controller]")]
    [ApiController]
    public class ApplicantController : ControllerBase
    {
        private readonly CrecheContext _db;

        public ApplicantController(CrecheContext db)
        {
            _db = db;
        }



        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Applicant>> GetApplicant(int ID)
        {
            var applicant = await _db.Applicants.FindAsync(ID);

            if (applicant == null)
            {
                return NotFound();
            }

            return applicant;
        }
    }
}