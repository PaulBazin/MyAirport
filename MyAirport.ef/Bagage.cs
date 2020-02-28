using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBZN.MyAirport.ef
{
    public class Bagage
    {
        public int BagageID { get; set; }
        [ForeignKey("Vol")]
        public int VolID { get; set; }
        public Vol Vol { get; set; }
        public string CodeIata { get; set; }
        public DateTime DateCreation { get; set; }
        public string Classe { get; set; }
        public Boolean Prioritaire { get; set; }
        public Char Sta { get; set; }
        public string Ssur { get; set; }
        public string Destination { get; set; }
        public string Escale { get; set; }
    }
}
