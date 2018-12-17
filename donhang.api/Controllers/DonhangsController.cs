using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using donhang.api.Models;

namespace donhang.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonhangsController : ControllerBase
    {
        private readonly QL_DonHangContext _context;

        public DonhangsController(QL_DonHangContext context)
        {
            _context = context;
        }

        // GET: api/Donhangs
        [HttpGet]
        public IEnumerable<Donhang> GetDonhang()
        {
            return _context.Donhang;
        }

        // GET: api/Donhangs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDonhang([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var donhang = await _context.Donhang.FindAsync(id);
    


            if (donhang == null)
            {
                return NotFound();
            }

            return Ok(donhang);
        }

        // PUT: api/Donhangs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDonhang([FromRoute] string id, [FromBody] Donhang donhang)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != donhang.MaDh)
            {
                return BadRequest();
            }

            _context.Entry(donhang).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DonhangExists(id))
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

        // POST: api/Donhangs
        [HttpPost]
        public async Task<IActionResult> PostDonhang([FromBody] Donhang donhang)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Donhang.Add(donhang);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DonhangExists(donhang.MaDh))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDonhang", new { id = donhang.MaDh }, donhang);
        }

        // DELETE: api/Donhangs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDonhang([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var donhang = await _context.Donhang.FindAsync(id);
            if (donhang == null)
            {
                return NotFound();
            }

            _context.Donhang.Remove(donhang);
            await _context.SaveChangesAsync();

            return Ok(donhang);
        }

        private bool DonhangExists(string id)
        {
            return _context.Donhang.Any(e => e.MaDh == id);
        }
    }
}