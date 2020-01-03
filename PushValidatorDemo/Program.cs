using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace PushValidatorDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var webHost = WebHost.CreateDefaultBuilder(args)
                                 .ConfigureAppConfiguration(configuration =>
                                 {
                                     configuration.AddJsonFile("secrets.json", optional: true);
                                 });
            if (environment == EnvironmentName.Development)
            {
                webHost.UseKestrel(options =>
                {
                    options.ListenLocalhost(5002, listenOptions =>
                    {
                        listenOptions.UseHttps();
                    });
                });
            }
                                 
            return webHost.UseStartup<Startup>();
        }   
    }
}
