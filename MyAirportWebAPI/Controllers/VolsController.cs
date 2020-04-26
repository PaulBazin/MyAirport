using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyAirport.EF;
using PBZN_SSU.MyAirport.EF;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAirportWebApi
{
    [Route("api/[controller]")]
    [ApiController]

  
    public class VolsController : ControllerBase
    {
        /// <summary>
        /// MyAirportContext
        /// </summary>
        private readonly MyAirportContext _context;


        /// <summary>
        /// Controleur de Vol du Context Airport
        /// </summary>
        /// <param name="context"></param>
        public VolsController(MyAirportContext context)
        {
            _context = context;
        }

        // GET: api/Vols
        /// <summary>
        /// Retourner les vols (passage turbulent...)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vol>>> GetVols()
        {
            return await _context.Vols.ToListAsync();
        }

        // GET: api/Vols/:id  - boolean
        /// <summary>
        /// Retourne un vol en particulier (possibilité de joindre la liste de ses bagages)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="bagages">Est-ce que la liste des bagages du vol doit être retournée au passage ?</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Vol>> GetVol(int id, [FromQuery] bool bagages = false)
        {
            Vol volsResult;

            if (bagages) //vol avec bagages
                volsResult = await _context.Vols.Include(v => v.Bagages).Where(v => v.VolId == id).FirstAsync();
            else
                volsResult = await _context.Vols.FindAsync(id);
            
            if (volsResult == null)
                return NotFound();
            else
                return volsResult;
        }
           
        /// <summary>
        /// Modifier les données d'un vol
        /// </summary>
        /// <param name="id"></param>
        /// <param name="vol"></param>
        /// <returns></returns>
        // PUT: api/Vols/:id
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVol(int id, Vol vol)
        {
            if (id != vol.VolId)
            {
                return BadRequest();
            }

            _context.Entry(vol).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VolExists(id))
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

        // POST: api/Vols
        /// <summary>
        /// Créer un nouveau vol
        /// </summary>
        /// <param name="vol"></param>
        /// <returns></returns>
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Vol>> PostVol(Vol vol)
        {
            _context.Vols.Add(vol);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVol", new { id = vol.VolId }, vol);
        }

        // DELETE: api/Vols/:id
        /// <summary>
        /// Suppresion d'un vol en particulier
        /// </summary>
        /// <param name="id">ID du vol à supprimer</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult<Vol>> DeleteVol(int id)
        {
            var vol = await _context.Vols.FindAsync(id);
            if (vol == null)
            {
                return NotFound();
            }

            _context.Vols.Remove(vol);
            await _context.SaveChangesAsync();

            return vol;
        }

        private bool VolExists(int id)
        {
            return _context.Vols.Any(e => e.VolId == id);
        }
    }
}
