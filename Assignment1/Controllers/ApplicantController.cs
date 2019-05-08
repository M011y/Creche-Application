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
        private readonly CrecheContext _context;

        public ApplicantController(CrecheContext context)
        {
            _context = context;
        }

        // GET data/applicant
        [HttpGet("{id}")]
        public async Task<ActionResult<Applicant>> GetApplicant(int ID)
        {
            var applicant = await _context.Applicants.FindAsync(ID);

            if (applicant == null)
            {
                return NotFound();
            }

            return applicant;
        }
    }
}