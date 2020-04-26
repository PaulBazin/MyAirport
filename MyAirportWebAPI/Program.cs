using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using MyAirportWebAPI;

namespace PBZN_SSU.MyAirport.WebAPI
{
    /// <summary>
    /// WebAPI
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main de l'APIWeb
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Accessibilité au DBContext
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
