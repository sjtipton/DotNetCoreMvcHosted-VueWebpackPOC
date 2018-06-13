using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace DotNetCoreMvcHosted_VueWebpackPOC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = BuildWebHostAsIISReverseProxy(args);

            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
              .UseStartup<Startup>()
              .Build();
        }

        public static IWebHost BuildWebHostAsIISReverseProxy(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
              .UseKestrel()
              .UseContentRoot(Directory.GetCurrentDirectory())
              .UseIISIntegration()
              .UseStartup<Startup>()
              .Build();
        }
    }
}
