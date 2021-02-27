using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac.Extensions.DependencyInjection;

namespace MvcWebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            //var host = Host.CreateDefaultBuilder(args)
            //    .UseServiceProviderFactory(new AutofacServiceProviderFactory())
            //    .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>())
            //    .Build();

            //host.Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
