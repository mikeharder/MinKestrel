using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace MinKestrel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new WebHostBuilder()
                .UseKestrel()
                .Configure(app => app.Run(async (context) =>
                {
                    await context.Response.WriteAsync("Hello World!");
                }))
                .UseUrls("http://*:5000")
                .Build()
                .Run();
        }
    }
}
