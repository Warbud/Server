using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Warbud.Shared.Configurations;

namespace Warbud.Revit.Update
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseUrls("http://localhost:3020");
                });
    }
}