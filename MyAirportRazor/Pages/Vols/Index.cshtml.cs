using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PBZN_SSU.MyAirport.EF;
using MyAirport.EF;

namespace MyAirport.Razor
{
    public class IndexModelVol : PageModel
    {
        private readonly PBZN_SSU.MyAirport.EF.MyAirportContext _context;

        public IndexModelVol(PBZN_SSU.MyAirport.EF.MyAirportContext context)
        {
            _context = context;
        }

        public IList<Vol> Vol { get;set; }

        public async Task OnGetAsync()
        {
            Vol = await _context.Vols.ToListAsync();
        }
    }
}
