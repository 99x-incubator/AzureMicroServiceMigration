using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AdminService.Models;

namespace AdminService.Controllers
{
    [Produces("application/json")]
    [Route("api/SystemUsers")]
    public class SystemUsersController : Controller
    {
        private readonly AdminDBContext _context;

        public SystemUsersController(AdminDBContext context)
        {
            _context = context;
        }

        // GET: api/SystemUsers
        [HttpGet]
        public IEnumerable<SystemUser> GetSystemUsers()
        {
            return _context.SystemUsers;
        }

        // GET: api/SystemUsers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSystemUser([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var systemUser = await _context.SystemUsers.SingleOrDefaultAsync(m => m.UserID == id);

            if (systemUser == null)
            {
                return NotFound();
            }

            return Ok(systemUser);
        }

        // PUT: api/SystemUsers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSystemUser([FromRoute] int id, [FromBody] SystemUser systemUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != systemUser.UserID)
            {
                return BadRequest();
            }

            _context.Entry(systemUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SystemUserExists(id))
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

        // POST: api/SystemUsers
        [HttpPost]
        public async Task<IActionResult> PostSystemUser([FromBody] SystemUser systemUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SystemUsers.Add(systemUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSystemUser", new { id = systemUser.UserID }, systemUser);
        }

        // DELETE: api/SystemUsers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSystemUser([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var systemUser = await _context.SystemUsers.SingleOrDefaultAsync(m => m.UserID == id);
            if (systemUser == null)
            {
                return NotFound();
            }

            _context.SystemUsers.Remove(systemUser);
            await _context.SaveChangesAsync();

            return Ok(systemUser);
        }

        private bool SystemUserExists(int id)
        {
            return _context.SystemUsers.Any(e => e.UserID == id);
        }
    }
}