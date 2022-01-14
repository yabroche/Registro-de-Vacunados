using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Registro_de_Vacunados.Entities;
using Registro_de_Vacunados.Services;

namespace Registro_de_Vacunados.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RvacunadosTabsController : ControllerBase
    {
        private readonly VacunadosDbContext _context;

        public RvacunadosTabsController(VacunadosDbContext context)
        {
            _context = context;
        }

        // GET: api/RvacunadosTabs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RvacunadosTab>>> GetRvacunadosTab()
        {
            return await _context.RvacunadosTab.ToListAsync();
        }

        // GET: api/RvacunadosTabs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RvacunadosTab>> GetRvacunadosTab(int id)
        {
            var rvacunadosTab = await _context.RvacunadosTab.FindAsync(id);

            if (rvacunadosTab == null)
            {
                return NotFound();
            }

            return rvacunadosTab;
        }

        // PUT: api/RvacunadosTabs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRvacunadosTab(int id, RvacunadosTab rvacunadosTab)
        {
            if (id != rvacunadosTab.Id)
            {
                return BadRequest();
            }

            _context.Entry(rvacunadosTab).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RvacunadosTabExists(id))
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

        // POST: api/RvacunadosTabs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RvacunadosTab>> PostRvacunadosTab(RvacunadosTab rvacunadosTab)
        {
            _context.RvacunadosTab.Add(rvacunadosTab);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRvacunadosTab", new { id = rvacunadosTab.Id }, rvacunadosTab);
        }

        // DELETE: api/RvacunadosTabs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRvacunadosTab(int id)
        {
            var rvacunadosTab = await _context.RvacunadosTab.FindAsync(id);
            if (rvacunadosTab == null)
            {
                return NotFound();
            }

            _context.RvacunadosTab.Remove(rvacunadosTab);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RvacunadosTabExists(int id)
        {
            return _context.RvacunadosTab.Any(e => e.Id == id);
        }
    }
}
