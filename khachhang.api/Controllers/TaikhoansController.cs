using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using khachhang.api.Models;

namespace khachhang.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaikhoansController : ControllerBase
    {
        private readonly QL_TaiKhoanContext _context;

        public TaikhoansController(QL_TaiKhoanContext context)
        {
            _context = context;
        }

        // GET: api/Taikhoans
        [HttpGet]
        public IEnumerable<Taikhoan> GetTaikhoan()
        {
            return _context.Taikhoan;
        }

        // GET: api/Taikhoans/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTaikhoan([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var taikhoan = await _context.Taikhoan.FindAsync(id);

            if (taikhoan == null)
            {
                return NotFound();
            }

            return Ok(taikhoan);
        }

        // PUT: api/Taikhoans/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTaikhoan([FromRoute] string id, [FromBody] Taikhoan taikhoan)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != taikhoan.TaiKhoan1)
            {
                return BadRequest();
            }

            _context.Entry(taikhoan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaikhoanExists(id))
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

        // POST: api/Taikhoans
        [HttpPost]
        public async Task<IActionResult> PostTaikhoan([FromBody] Taikhoan taikhoan)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Taikhoan.Add(taikhoan);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TaikhoanExists(taikhoan.TaiKhoan1))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTaikhoan", new { id = taikhoan.TaiKhoan1 }, taikhoan);
        }

        // DELETE: api/Taikhoans/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTaikhoan([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var taikhoan = await _context.Taikhoan.FindAsync(id);
            if (taikhoan == null)
            {
                return NotFound();
            }

            _context.Taikhoan.Remove(taikhoan);
            await _context.SaveChangesAsync();

            return Ok(taikhoan);
        }

        private bool TaikhoanExists(string id)
        {
            return _context.Taikhoan.Any(e => e.TaiKhoan1 == id);
        }
    }
}