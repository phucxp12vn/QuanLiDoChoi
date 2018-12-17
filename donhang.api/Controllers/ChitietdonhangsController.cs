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
    public class ChitietdonhangsController : ControllerBase
    {
        private readonly QL_DonHangContext _context;

        public ChitietdonhangsController(QL_DonHangContext context)
        {
            _context = context;
        }

        // GET: api/Chitietdonhangs
        [HttpGet]
        public IEnumerable<Chitietdonhang> GetChitietdonhang()
        {
            return _context.Chitietdonhang;
        }

        // GET: api/Chitietdonhangs/5/1
        [HttpGet("{MaDH}&&{MaSP}")]
        public async Task<IActionResult> GetChitietdonhang([FromRoute] string MaDH, string MaSP)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var chitietdonhang = await _context.Chitietdonhang.FindAsync(MaDH,MaSP);

            if (chitietdonhang == null)
            {
                return NotFound();
            }

            return Ok(chitietdonhang);

        }

        // PUT: api/Chitietdonhangs/5
        [HttpPut("{MaDH}&&{MaSP}")]
        public async Task<IActionResult> PutChitietdonhang([FromRoute] string MaDH, string MaSP, [FromBody] Chitietdonhang chitietdonhang)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (MaDH != chitietdonhang.MaDh || MaSP != chitietdonhang.MaSp)
            {
                return BadRequest();
            }

            _context.Entry(chitietdonhang).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChitietdonhangExists(MaDH) || !ChitietdonhangExists(MaSP))
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

        // POST: api/Chitietdonhangs
        [HttpPost]
        public async Task<IActionResult> PostChitietdonhang([FromBody] Chitietdonhang chitietdonhang)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Chitietdonhang.Add(chitietdonhang);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ChitietdonhangExists(chitietdonhang.MaDh))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetChitietdonhang", new { MaDH = chitietdonhang.MaDh, MaSP = chitietdonhang.MaSp}, chitietdonhang);
        }

        // DELETE: api/Chitietdonhangs/5
        [HttpDelete("{MaDH}&&{MaSP}")]
        public async Task<IActionResult> DeleteChitietdonhang([FromRoute] string MaDH, string MaSP)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var chitietdonhang = await _context.Chitietdonhang.FindAsync(MaDH,MaSP);
            if (chitietdonhang == null)
            {
                return NotFound();
            }

            _context.Chitietdonhang.Remove(chitietdonhang);
            await _context.SaveChangesAsync();

            return Ok(chitietdonhang);
        }

        private bool ChitietdonhangExists(string id)
        {
            return _context.Chitietdonhang.Any(e => e.MaDh == id);
        }
    }
}