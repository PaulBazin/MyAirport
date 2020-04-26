using PBZN_SSU.MyAirport.EF;
using System;
using System.Collections.Generic;


namespace MyAirport.EF
{
    /// <summary>
    /// Class Vol, représentant une instance de Vol
    /// </summary>
    public class Vol
    {
        /// <summary>
        /// PK/ID de l'objet Vol
        /// </summary>
        public int VolId { get; set; }

        /// <summary>
        /// Compagnie du vol
        /// </summary>
        public string Cie { get; set; }


        /// <summary>
        /// Horaire de départ du vol
        /// </summary>
        public DateTime Dhc { get; set; }

        /// <summary>
        /// Numéro de ligne du vol
        /// </summary>
        public string Lig { get; set; }


        /// <summary>
        /// Ville de destination du vol
        /// </summary>
        public string? Des { get; set; }
        
        /// <summary>
        /// Immatriculation du vol
        /// </summary>
        public string? Imm { get; set; }

        /// <summary>
        /// Parking
        /// </summary>
        public string? Pkg { get; set; }

        public int? Pax { get; set; }

        /// <summary>
        /// Propriété de navigation
        /// </summary>
        public IEnumerable<Bagage>? Bagages { get; set; }

        /// <summary>
        /// Vol
        /// </summary>
        /// <param name="cie"></param>
        /// <param name="lig"></param>
        /// <param name="dhc"></param>
        public Vol(string cie, string lig, DateTime dhc)
        {
            Cie = cie;
            Lig = lig;
            Dhc = dhc;
            // Bagages = null; // la liste est null par défaut, afin de mieux différencier les différents états d'un GET api/Vols/:id?(none/true/false)
            // mais le '?' de la méthode IEnumerable<Bagage>? Bagages initialise déjà à null par défaut
        }
    }
}