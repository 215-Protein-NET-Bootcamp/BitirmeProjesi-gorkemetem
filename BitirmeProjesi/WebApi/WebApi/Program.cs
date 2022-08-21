using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using Service;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Read Configuration from appSettings
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            // Initialize Logger
            Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(config).CreateLogger();
            Log.Information("Application is starting.");

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .UseSerilog()
                .ConfigureContainer<ContainerBuilder>(builder =>
                {
                    builder.RegisterModule(new AutofacBusinessModule()); // for use new IoC container
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
