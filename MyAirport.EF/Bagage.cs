using MyAirport.EF;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBZN_SSU.MyAirport.EF
{
    /// <summary>
    /// Class Bagage, représentant une instance de Bagage
    /// </summary>
    public class Bagage
    {
        /// <summary>
        /// PK/ID de l'objet bagage
        /// </summary>
        public int BagageId { get; set; }

        /// <summary>
        /// Vol associé au bagage
        /// </summary>
        public int? VolId { get; set; }

        /// <summary>
        /// CoddeIata du bagage unique à un instant T
        /// </summary>
        [Column(TypeName = "char(12")]
        public string CodeIata { get; set; }

        /// <summary>
        /// Date de la création du bagage
        /// </summary>
        public DateTime DateCreation { get; set; }

        /// <summary>
        /// R
        /// </summary>
        public Vol? Vol { get; set; }

        /// <summary>
        /// Classe
        /// </summary>
        public string? Classe { get; set; }

        /// <summary>
        /// Le gagage est priorioritaire
        /// </summary>
        public bool? Prioritaire { get; set; }


        /// <summary>
        /// Sta
        /// </summary>
        public string? Sta { get; set; }


        /// <summary>
        ///  Ssur
        /// </summary>
        public string? Ssur { get; set; }


        /// <summary>
        /// Destination
        /// </summary>
        public string? Destination { get; set; }


        /// <summary>
        ///  Escale(s) prévue(s)
        /// </summary>
        public string? Escale { get; set; }

        /// <summary>
        /// Propriété de navigation
        /// </summary>
        public Bagage(string codeIata, DateTime dateCreation)
        {
            CodeIata = codeIata;
            DateCreation = dateCreation;
        }
    }
}