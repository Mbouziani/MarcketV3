using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MarcketV3.Models;

namespace MarcketV3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleZonesController : ControllerBase
    {
        private readonly MarketManagementDBContext _context;

        public SaleZonesController(MarketManagementDBContext context)
        {
            _context = context;
        }

        // GET: api/SaleZones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SaleZone>>> GetSaleZones()
        {
          if (_context.SaleZones == null)
          {
              return NotFound();
          }
            return await _context.SaleZones.ToListAsync();
        }

        // GET: api/SaleZones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SaleZone>> GetSaleZone(int id)
        {
          if (_context.SaleZones == null)
          {
              return NotFound();
          }
            var saleZone = await _context.SaleZones.FindAsync(id);

            if (saleZone == null)
            {
                return NotFound();
            }

            return saleZone;
        }

        // PUT: api/SaleZones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSaleZone(int id, SaleZone saleZone)
        {
            if (id != saleZone.SaleZoneId)
            {
                return BadRequest();
            }

            _context.Entry(saleZone).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SaleZoneExists(id))
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

        // POST: api/SaleZones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SaleZone>> PostSaleZone(SaleZone saleZone)
        {
          if (_context.SaleZones == null)
          {
              return Problem("Entity set 'MarketManagementDBContext.SaleZones'  is null.");
          }
            _context.SaleZones.Add(saleZone);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSaleZone", new { id = saleZone.SaleZoneId }, saleZone);
        }

        // DELETE: api/SaleZones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSaleZone(int id)
        {
            if (_context.SaleZones == null)
            {
                return NotFound();
            }
            var saleZone = await _context.SaleZones.FindAsync(id);
            if (saleZone == null)
            {
                return NotFound();
            }

            _context.SaleZones.Remove(saleZone);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SaleZoneExists(int id)
        {
            return (_context.SaleZones?.Any(e => e.SaleZoneId == id)).GetValueOrDefault();
        }
    }
}
