using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;


namespace DependencyInjectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using var host = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration(config =>
                {

                })
                .ConfigureLogging(logging =>
                {

                })
                .ConfigureServices((context, services) =>
                {                                   
                    services.AddTransient<IHelloService, HelloService>();
                    // services.AddTransient<HomeController>();
                    services.AddHomeController(context.Configuration.GetSection("GreetingConfig"));
                }).Build();
            using var scope1 = host.Services.CreateScope();
            var controller = scope1.ServiceProvider.GetService<HomeController>();

            // var controller = host.Services.GetService<HomeController>();

            string result = controller.Index("Katharina");
            Console.WriteLine(result);
        }

    }
}
