using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using madicare.Data;
using medi_CareBDAPI.Models;

namespace medi_CareBDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class medicinesAPIController : ControllerBase
    {
        private readonly medicareDBContext _context;

        public medicinesAPIController(medicareDBContext context)
        {
            _context = context;
        }

        // GET: api/medicinesAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<medicine>>> Getmedicines()
        {
            return await _context.medicines.ToListAsync();
        }

        // GET: api/medicinesAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<medicine>> Getmedicine(int id)
        {
            var medicine = await _context.medicines.FindAsync(id);

            if (medicine == null)
            {
                return NotFound();
            }

            return medicine;
        }

        // PUT: api/medicinesAPI/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> Putmedicine(int id, medicine medicine)
        {
            if (id != medicine.MedicineId)
            {
                return BadRequest();
            }

            _context.Entry(medicine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!medicineExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/medicinesAPI
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<medicine>> Postmedicine(medicine medicine)
        {
            _context.medicines.Add(medicine);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getmedicine", new { id = medicine.MedicineId }, medicine);
        }

        // DELETE: api/medicinesAPI/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<medicine>> Deletemedicine(int id)
        {
            var medicine = await _context.medicines.FindAsync(id);
            if (medicine == null)
            {
                return NotFound();
            }

            _context.medicines.Remove(medicine);
            await _context.SaveChangesAsync();

            return medicine;
        }

        private bool medicineExists(int id)
        {
            return _context.medicines.Any(e => e.MedicineId == id);
        }
    }
}
