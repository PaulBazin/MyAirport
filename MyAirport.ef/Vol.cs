using System;
using Microsoft.EntityFrameworkCore;

namespace PBZN.MyAirport.ef
{
    public class Vol
    {
        public int VolId { get; set; }
        public string Cie { get; set; }
        public string Lig { get; set; }
        public DateTime Dhc { get; set; }
        public string Pkg { get; set; }
        public string Imm { get; set; }
        public int Pax { get; set; }
        public string Des { get; set; }

        public static implicit operator int(Vol v)
        {
            throw new NotImplementedException();
        }
    }
}
