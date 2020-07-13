using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace ConfigSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using var host = Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(config =>
                {
                    
                })
                .Build();

            //var config = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json")
            //    .AddJsonFile($"appsettings.Development.json", optional: true)
            //    .AddUserSecrets("5e64296e-25ff-4e85-b952-7a02fdfebc04")
            //    .AddEnvironmentVariables()
            //    .AddCommandLine(args)
            //    .Build();

            var config = host.Services.GetService<IConfiguration>();
            var value = config["myconfig1"];
            Console.WriteLine(value);

            var secret = config["Mysecret"];
            Console.WriteLine($"secret: {secret}");

            var configfromsection = config.GetSection("mysection1")["myconfig2"];
            Console.WriteLine(configfromsection);

            var sqlConnection = config.GetConnectionString("MyBooks");
            Console.WriteLine(sqlConnection);
        }
    }
}
