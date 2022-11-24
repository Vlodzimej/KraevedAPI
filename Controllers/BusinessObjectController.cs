using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KraevedAPI.Models;

namespace KraevedAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessObjectController : ControllerBase
    {
        private readonly KraevedContext _context;

        public BusinessObjectController(KraevedContext context)
        {
            _context = context;
        }

        // GET: api/BusinessObject
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BusinessObject>>> GetBusinessObjects()
        {
          if (_context.BusinessObjects == null)
          {
              return NotFound();
          }
            return await _context.BusinessObjects.ToListAsync();
        }

        // GET: api/BusinessObject/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BusinessObject>> GetBusinessObject(Guid id)
        {
          if (_context.BusinessObjects == null)
          {
              return NotFound();
          }
            var businessObject = await _context.BusinessObjects.FindAsync(id);

            if (businessObject == null)
            {
                return NotFound();
            }

            return businessObject;
        }

        // PUT: api/BusinessObject/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBusinessObject(Guid id, BusinessObject businessObject)
        {
            if (id != businessObject.Id)
            {
                return BadRequest();
            }

            _context.Entry(businessObject).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BusinessObjectExists(id))
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

        // POST: api/BusinessObject
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BusinessObject>> PostBusinessObject(BusinessObject businessObject)
        {
          if (_context.BusinessObjects == null)
          {
              return Problem("Entity set 'KraevedContext.BusinessObjects'  is null.");
          }
            _context.BusinessObjects.Add(businessObject);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBusinessObject", new { id = businessObject.Id }, businessObject);
        }

        // DELETE: api/BusinessObject/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBusinessObject(Guid id)
        {
            if (_context.BusinessObjects == null)
            {
                return NotFound();
            }
            var businessObject = await _context.BusinessObjects.FindAsync(id);
            if (businessObject == null)
            {
                return NotFound();
            }

            _context.BusinessObjects.Remove(businessObject);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BusinessObjectExists(Guid id)
        {
            return (_context.BusinessObjects?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
