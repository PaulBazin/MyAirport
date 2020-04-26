using Microsoft.EntityFrameworkCore;
using MyAirport.EF;


namespace PBZN_SSU.MyAirport.EF
{

    /// <summary>
    /// BDD de notre Context Airport
    /// </summary>
    public class MyAirportContext : DbContext
    {
        //public static readonly ILoggerFactory MyAirportLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });

        /// <summary>
        /// Objet Vol
        /// </summary>
        public DbSet<Vol>? Vols { get; set; }

        /// <summary>
        /// Objet Bagage
        /// </summary>
        public DbSet<Bagage>? Bagages { get; set; }

        /// <summary>
        /// Liaison BDD
        /// </summary>
        public MyAirportContext(DbContextOptions<MyAirportContext> options) : base(options) { }

        /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["MyAirportContext"].ConnectionString);
             //optionsBuilder.UseLoggerFactory(MyAirportLoggerFactory);

         }*/
    }
}