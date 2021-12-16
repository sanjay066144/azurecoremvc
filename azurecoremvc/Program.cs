using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace azurecoremvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureAppConfiguration(config =>
                    {
                        var setting = config.Build();
                        config.AddAzureAppConfiguration("Endpoint=https://az204webappappconfig.azconfig.io;Id=QN64-l3-s0:yoKTsMeyRakCxvs0msE7;Secret=a/SVeh4vkzWNjQ6hhfpqorHBrfFWUQdiAzkGVRYxOtg=");
                    });
                    webBuilder.UseStartup<Startup>();
                });
    }
}
