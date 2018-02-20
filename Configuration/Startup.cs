using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace Configuration
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        { }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
           {
               await context.Response.WriteAsync(Configuration["key1"]);
               //    string v = Configuration["key1"];
               //    string v = Configuration.GetConnectionString("DefaultConnection");
               //    string v = Configuration.GetValue<string>("A:B:C", "china");
               //    IConfigurationSection v = Configuration.GetSection("subsection");
               //    IEnumerable<IConfigurationSection> v = Configuration.GetChildren();
           });
        }
    }
}
