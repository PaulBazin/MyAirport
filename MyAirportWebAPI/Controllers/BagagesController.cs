using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PBZN_SSU.MyAirport.EF;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAirportWebApi
{
    [Route("api/[controller]")]
    [ApiController]


    public class BagagesController : ControllerBase
    {
        private readonly MyAirportContext _context;

        /// <summary>
        /// BagagesController
        /// </summary>
        /// <param name="context"></param>
        public BagagesController(MyAirportContext context)
        {
            _context = context;
        }

        // GET: api/Bagages
        /// <summary>
        /// Retourner les bagages (attention aux choses fragiles ! 🙃)
        /// </summary>
        /// <returns> Task contient un ActionResult contenant la liste de bagages </returns>
        
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bagage>>> GetBagages()
        {
            return await _context.Bagages.ToListAsync();
        }

        // GET: api/Bagages/:id
        /// <summary>
        /// Retourner un bagage en particulier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet("{id}")]
        public async Task<ActionResult<Bagage>> GetBagage(int id)
        {
            var bagage = await _context.Bagages.FindAsync(id);

            if (bagage == null)
            {
                return NotFound();
            }

            return bagage;
        }

        // PUT: api/Bagages/:id
        /// <summary>
        /// Modifier un bagage
        /// </summary>
        /// <param name="id"></param>
        /// <param name="bagage"></param>
        /// <returns></returns>
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for more details see https://aka.ms/RazorPagesCRUD.
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBagage(int id, Bagage bagage)
        {
            if (id != bagage.BagageId)
            {
                return BadRequest();
            }

            _context.Entry(bagage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BagageExists(id))
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

        // POST: api/Bagages
        /// <summary>
        /// Créer un nouveau bagage
        /// </summary>
        /// <param name="bagage"></param>
        /// <returns></returns>
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for more details see https://aka.ms/RazorPagesCRUD.
        [ProducesResponseType(StatusCodes.Status201Created)]
        [HttpPost]
        public async Task<ActionResult<Bagage>> PostBagage(Bagage bagage)
        {
            _context.Bagages.Add(bagage);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBagage", new { id = bagage.BagageId }, bagage);
        }

        // DELETE: api/Bagages/:id
        /// <summary>
        /// Supprimer un bagage
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Bagage>> DeleteBagage(int id)
        {
            var bagage = await _context.Bagages.FindAsync(id);
            if (bagage == null)
            {
                return NotFound();
            }

            _context.Bagages.Remove(bagage);
            await _context.SaveChangesAsync();

            return bagage;
        }

        private bool BagageExists(int id)
        {
            return _context.Bagages.Any(e => e.BagageId == id);
        }
    }
}
