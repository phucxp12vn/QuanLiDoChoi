using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sanpham.api.Models;

namespace sanpham.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanphamsController : ControllerBase
    {
        private readonly QL_SanPhamContext _context;

        public SanphamsController(QL_SanPhamContext context)
        {
            _context = context;
        }

        // GET: api/Sanphams
        [HttpGet]
        public IEnumerable<Sanpham> GetSanpham()
        {
            return _context.Sanpham;
        }

        // GET: api/Sanphams/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSanpham([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sanpham = await _context.Sanpham.FindAsync(id);

            if (sanpham == null)
            {
                return NotFound();
            }

            return Ok(sanpham);
        }

        // PUT: api/Sanphams/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSanpham([FromRoute] string id, [FromBody] Sanpham sanpham)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sanpham.MaSp)
            {
                return BadRequest();
            }

            _context.Entry(sanpham).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SanphamExists(id))
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

        // POST: api/Sanphams
        [HttpPost]
        public async Task<IActionResult> PostSanpham([FromBody] Sanpham sanpham)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Sanpham.Add(sanpham);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SanphamExists(sanpham.MaSp))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSanpham", new { id = sanpham.MaSp }, sanpham);
        }

        // DELETE: api/Sanphams/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSanpham([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sanpham = await _context.Sanpham.FindAsync(id);
            if (sanpham == null)
            {
                return NotFound();
            }

            _context.Sanpham.Remove(sanpham);
            await _context.SaveChangesAsync();

            return Ok(sanpham);
        }

        private bool SanphamExists(string id)
        {
            return _context.Sanpham.Any(e => e.MaSp == id);
        }
    }
}