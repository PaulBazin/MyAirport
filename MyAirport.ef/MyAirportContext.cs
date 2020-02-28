using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace PBZN.MyAirport.ef
{
    public class MyAirportContext : DbContext
    {
        public static readonly ILoggerFactory MyAirportLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
        public MyAirportContext(DbContextOptions<MyAirportContext> options) : base(options) { }
        public DbSet<Bagage> Bagages { get; set; }
        public DbSet<Vol> Vols { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //optionsBuilder.UseSqlServer(
        //        @"Server=(localdb)\mssqllocaldb;Database=MyAirportContext;Integrated Security=True");
        //}
    }
}
