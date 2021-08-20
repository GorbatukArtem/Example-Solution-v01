using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace UI.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //webBuilder.UseIISIntegration();

                    //webBuilder.UseKestrel();

                    webBuilder.UseStartup<Startup>();
                });

            host.Build().Run();
        }
    }
}