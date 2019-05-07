using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrecheController : ControllerBase
    {
        private readonly CrecheContext _context;

        public CrecheController(CrecheContext context)
        {
            _context = context;
        }

        // GET: api/Todo viewing applicants in database
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Applicant>>> GetApplicants()
        {
            return await _context.Applicants.ToListAsync();
        }

        // GET: api/Todo/5 getting a particular applicant from database
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

        // POST: api/Todo adding applicant to database
        [HttpPost]
        public async Task<ActionResult<Applicant>> PostApplicant(Applicant item)
        {
            _context.Applicants.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetApplicant), new { id = item.ID }, item);
        }

        // PUT: api/Todo/5 modifies existing record
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApplicant(int id, Applicant item)
        {
            if (id != item.ID)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }


        // DELETE: api/Todo/5 deleting an applicant from database
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApplicant(long ID)
        {
            var applicant = await _context.Applicants.FindAsync(ID);

            if (applicant == null)
            {
                return NotFound();
            }

            _context.Applicants.Remove(applicant);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}