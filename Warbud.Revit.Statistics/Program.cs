using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Warbud.Shared.Configurations;

namespace Warbud.Revit.Statistics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    var port = UseUrlsConfiguration.Configure()
                        .SetConfigPath("C:/Users/afranczak/source/repos/Nairda015/Warbud/ports.json")
                        .GetPort("RevitStatistics");
                    webBuilder.UseUrls($"http://localhost:{port.ToString()}");
                });
        }
    }
}