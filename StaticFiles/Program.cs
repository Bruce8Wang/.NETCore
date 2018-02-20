using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace StaticFiles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebHost.CreateDefaultBuilder(args)            
                .UseStartup<StartupDefault>()
                .Build()
                .Run();
        }
    }
}
