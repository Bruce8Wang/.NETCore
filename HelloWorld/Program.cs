using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Server.HttpSys;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebHost.CreateDefaultBuilder(args)
                .UseHttpSys(options =>
                {
                    options.Authentication.AllowAnonymous = false;
                    options.Authentication.Schemes = AuthenticationSchemes.NTLM;  //仅限Windows系统
                })
                .Configure(app =>
                {
                    app.Run(async (context) =>
                    {
                        context.Response.ContentType = "text/html; charset=utf-8";
                        await context.Response.WriteAsync(context.User.Identity.Name);
                    });
                })
                .Build()
                .Run();
        }
    }
}
