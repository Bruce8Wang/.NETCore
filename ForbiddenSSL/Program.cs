using System.IO;
using System.Net;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace ForbiddenSSL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseKestrel(options =>
                {
                    options.Listen(IPAddress.Loopback, 5000, listenOptions =>
                    {
                        listenOptions.UseHttps(Path.Combine(Directory.GetCurrentDirectory(), "DotNetCore.pfx"), "123");
                    });
                })
                .UseStartup<Startup>()
                .Build();
    }
}
