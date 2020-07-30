using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace HuaweiCloud.SDK.Sidecar
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            var port = "8080";
            if (args.Length == 1)
            {
                port = args[0];
            }

            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>().UseUrls($"http://127.0.0.1:{port}");
                });
        }
    }
}